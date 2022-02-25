using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _22_0224
{
    class Program
    {
        private enum ETag
        {
            Artist = 0x013b,
            Software = 0x0131,
            CreateDate = 0x9004,
            // others...
        }

        static void Main(string[] args)
        {
            var origin = @"star.jpg";
            var temp = @"star_temp.jpg";

            using (var img = Image.FromFile(origin))
            {
                SetPropertyItems(img, new Dictionary<ETag, string>()
                {
                    [ETag.Artist] = "Test Artist",
                    [ETag.Software] = "Test Software",
                    [ETag.CreateDate] = DateTime.Now.ToString("yyyyMMdd:HHmmss"),
                });

                img.RemovePropertyItem((int)ETag.Software);

                img.Save(temp);
            }

            Console.WriteLine("DONE - press any key...");
            Console.ReadLine();
        }

        private static void SetPropertyItems(Image img, Dictionary<ETag, string> items)
        {
            foreach (var item in items)
            {
                SetPropertyItem(img, item.Key, item.Value);
            }
        }

        /// <summary>
        /// 테스트 - 태그 타입이 스트링인 경우만 
        /// </summary>
        /// <param name="img"></param>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        private static void SetPropertyItem(Image img, ETag tag, string value)
        {            
            // 이렇게 사용해도 된다.            
            // var propertyItem = img.PropertyItems[0];

            var propertyItem = FormatterServices.GetUninitializedObject(typeof(PropertyItem)) as PropertyItem;

            // string인 경우 null 종결자 필요
            var val = Encoding.UTF8.GetBytes($"{value}\0");
            propertyItem.Id = (int)tag;
            propertyItem.Type = 2; // ascii string인 경우 type이 2
            propertyItem.Value = val;
            propertyItem.Len = val.Length;

            img.SetPropertyItem(propertyItem);
        }
    }
}
