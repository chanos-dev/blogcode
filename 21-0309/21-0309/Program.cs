using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_0309
{
    enum SingletonType
    {
        [SingletonFactory(typeof(UnsafeSingleton))]
        Unsafe,
        [SingletonFactory(typeof(SafeSingleton))]
        Safe,
        [SingletonFactory(typeof(DCLSingleton))]
        DCL,
        [SingletonFactory(typeof(StaticSingleton))]
        Static,
        [SingletonFactory(typeof(LazySingleton))]
        Lazy,
    }

    class Program
    { 
        static void Main(string[] args)
        {
            foreach (var name in Enum.GetNames(typeof(SingletonType)))
            {
                var singletonAttribute = typeof(SingletonType).GetMember(name).FirstOrDefault().GetCustomAttribute<SingletonFactoryAttribute>();
                
                List<Thread> threads = new List<Thread>();

                Action singletonAct = () =>
                {
                    var property = singletonAttribute.Type.GetProperty("Instance");

                    var obj = property.GetValue(property);

                    if (obj is Singleton singleton)
                    {
                        singleton.Print();
                    }
                }; 

                for(int idx = 0; idx < 5; idx++)
                {
                    threads.Add(new Thread(new ThreadStart(singletonAct)));
                } 

                Parallel.ForEach(threads, thread =>
                {
                    thread.Start();

                    thread.Join();
                }); 

                Console.WriteLine("");  
            } 
        }
    } 

    abstract class Singleton
    {
        public abstract void Print();
    }

    class SingletonFactoryAttribute : Attribute
    {
        private Type _type;

        public SingletonFactoryAttribute(Type type)
        {
            this._type = type;
        }

        public Type Type => _type;
    }

    class UnsafeSingleton : Singleton
    { 
        private static UnsafeSingleton _instance;

        public static UnsafeSingleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new UnsafeSingleton();
                }

                return _instance;
            }
        } 

        protected UnsafeSingleton() => Console.WriteLine("Create UnsafeSingleton instance!!");

        public override void Print()
        {
            Console.WriteLine("Print UnsafeSingleton!!");
        }
    }

    class SafeSingleton : Singleton
    {
        private static object _thislock = new object();
        private static SafeSingleton _instance;

        public static SafeSingleton Instance
        {
            get
            {
                lock (_thislock)
                {
                    if (_instance is null)
                    {
                        _instance = new SafeSingleton();
                    }
                }

                return _instance;
            }
        }

        protected SafeSingleton() => Console.WriteLine("Create SafeSingleton instance!!");

        public override void Print()
        {
            Console.WriteLine("Print SafeSingleton!!");
        }
    }

    //Double Checked Locking
    class DCLSingleton : Singleton
    {
        private static object _thislock = new object();
        private static DCLSingleton _instance;

        public static DCLSingleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_thislock)
                    {
                        if (_instance is null)
                        {
                            _instance = new DCLSingleton();
                        }
                    }
                }

                return _instance;
            }
        }

        protected DCLSingleton() => Console.WriteLine("Create DCLSingleton instance!!");

        public override void Print()
        {
            Console.WriteLine("Print DCLSingleton!!");
        }
    }

    class StaticSingleton : Singleton
    {
        private static readonly StaticSingleton _instance;

        static StaticSingleton()
        {
            _instance = new StaticSingleton();
        }

        public static StaticSingleton Instance => _instance;

        protected StaticSingleton() => Console.WriteLine("Create StaticSingleton instance!!");

        public override void Print()
        {
            Console.WriteLine("Print StaticSingleton!!");
        }
    }

    class LazySingleton : Singleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance => _instance.Value;

        protected LazySingleton() => Console.WriteLine("Create LazySingleton instance!!");

        public override void Print()
        {
            Console.WriteLine("Print LazySingleton!!");
        }
    }
}
