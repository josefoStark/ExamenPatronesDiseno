using System.Collections.Generic;
using System.Linq;

namespace BussinesLogic
{
    public class Publisher
    {
        private readonly List<ISubscriber> _lstSubscribers;

        public Publisher()
        {
            _lstSubscribers = new List<ISubscriber>();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            string name = nameof(subscriber.GetType);

            if (!_lstSubscribers.Select(x => x.GetType().Name).Contains(name))
                _lstSubscribers.Add(subscriber);
        }

        public void NotifyUser()
        {
            _lstSubscribers.ForEach(subscriber => subscriber.Notify());
        }

        public void Reset()
        {
            _lstSubscribers.Clear();
        }
    }
}
