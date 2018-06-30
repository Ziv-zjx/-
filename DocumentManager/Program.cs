using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("C#高级编程","教你怎么上升一个阶梯！");
            DocumentManager<Document> docManager = new DocumentManager<Document>();
            docManager.AddDoc(doc);
            doc.Title += "10.0";
            docManager.AddDoc(doc);
            Console.WriteLine(docManager.GetDoc().Content);
            docManager.DisplayAllDocument();
            

            Console.Read();
        }
    }
}
