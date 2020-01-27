using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Learncs6
{
    [Serializable]
    class Program
    {
        public int ID;
        public string Name;
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ID = 1;
            obj.Name = "testing name for serializable";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\vmohan\Desktop\example.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\Users\vmohan\Desktop\example.txt", FileMode.Open, FileAccess.Read);

            Program objnew = (Program)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);
            Console.ReadKey();
        }
    }
}
