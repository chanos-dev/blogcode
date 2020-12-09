using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_1027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_serialize_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = "홍길동";
            person.Age = 23;
            person.Sex = "남자";
            person.Address = "경기도 광주시";

            string json = JsonConvert.SerializeObject(person);
            textBox1.Text = json;
        }

        private void button_deserialize_Click(object sender, EventArgs e)
        {
            Person newPerson = JsonConvert.DeserializeObject<Person>(textBox1.Text);
            newPerson.PrintInfo(textBox2, newPerson);
        }

        private void button_serializeArr_Click(object sender, EventArgs e)
        {
            Village village = new Village();
            village.Location = "Korea";
            village.Fruit = new[] { new Fruit("Apple", 52, 1200),
                                    new Fruit("Banana", 88, 800),
                                    new Fruit("Strawberry", 32, 500)};

            string json = JsonConvert.SerializeObject(village);
            textBox1.Text = json;
        }

        private void button_deserializeArr_Click(object sender, EventArgs e)
        {
            Village newVillage = JsonConvert.DeserializeObject<Village>(textBox1.Text);
            newVillage.PrintInfo(textBox2, newVillage);
        } 
    }

    class Person
    {
        public Person() { }

        public string Name;
        public int Age;
        public string Sex;
        public string Address;
        
        public void PrintInfo(object obj, Person person)
        {
            if(obj is TextBox textBox)
            {
                textBox.Text = person.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name : {this.Name}");
            sb.AppendLine($"Age : {this.Age}");
            sb.AppendLine($"Sex : {this.Sex}");
            sb.AppendLine($"Address : {this.Address}");

            return sb.ToString();
        }
    }

    class Village
    {
        public Village() { }

        public string Location;
        public Fruit[] Fruit;

        public void PrintInfo(object obj, Village village)
        {
            if (obj is TextBox textBox)
            {
                textBox.Text = village.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Location : {this.Location}");

            foreach(Fruit fruits in Fruit)
            {
                sb.AppendLine($"Fruit.Name : {fruits.Name}");
                sb.AppendLine($"Fruit.Kcal : {fruits.Kcal}");
                sb.AppendLine($"Fruit.Price : {fruits.Price}");
            }            

            return sb.ToString();
        }
    }

    class Fruit
    { 
        public Fruit(string name, int kcal, int price)
        {
            Name = name;
            Kcal = kcal;
            Price = price;
        }

        
        public string Name;
        public int Kcal;
        public int Price;
    }
}
