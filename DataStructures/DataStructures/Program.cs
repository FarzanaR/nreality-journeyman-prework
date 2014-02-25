using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class CustomQueue
    {
        private List<object> _queue;

        public List<object> queue
        {
            get { return this._queue; }
 
            set { this._queue = value; }
        }
 
        public void PUSH(object newObject)
        {
            List<object> temp = queue;
            temp.Add(newObject);
            queue = temp;
        }

        public void PULL()
        {
            int count = queue.Count;
            var temp = queue;
            temp.RemoveAt(count - 1);
            queue = temp;
        }

        public void PULL(int index)
        {
            List<object> tQueue = queue;
            tQueue.RemoveAt(index);
            queue = tQueue;
        }

        public int SEARCH(object item)
        {
            return queue.IndexOf(item);
        }

        static void Main(string[] args)
        {
        }
    }
}
