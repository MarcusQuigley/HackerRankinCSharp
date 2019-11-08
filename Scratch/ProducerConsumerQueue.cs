using System;
using System.Collections.Generic;
using System.Threading;

namespace Scratch
{
    public class ProducerConsumerQueue : IDisposable
    {
        //Queue<Action> queue = new Queue<Action>();
        //ManualResetEvent signal = new ManualResetEvent(false);
        EventWaitHandle _wh = new AutoResetEvent(false);
        Thread _worker;
        readonly object _locker = new object();
        Queue<string> _tasks = new Queue<string>();

        public ProducerConsumerQueue()
        {
            _worker = new Thread(Work);
            _worker.Start();
        }
        public void Add(string action)
        {
            if (action != null)
            {
                _tasks.Enqueue(action);
            }
        }

        void Work()
        {
            while (true)
            {

            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


}
