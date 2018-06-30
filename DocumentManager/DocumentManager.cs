using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public class DocumentManager<T> where T:IDocument
    {

        private readonly Queue<T> queue = new Queue<T>();

        public void AddDoc(T doc)
        {
            lock (this)
            {
                queue.Enqueue(doc);
            }
        }

        public T GetDoc()
        {
            T doc = default(T);

            lock (this)
            {
                doc = IsHasDocument ? queue.Dequeue():doc;
            }

            return doc;
        }
        public void DisplayAllDocument()
        {
            foreach(T doc in queue)
            {
                Console.WriteLine(doc.Title);
            }
            
        }

        /// <summary>
        /// 是否存在文档(表达式方法的写法)
        /// </summary>
        public bool IsHasDocument => queue.Count > 0;
             
    }
}
