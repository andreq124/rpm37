using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM2
{
    public class EventAggregator
    {
        private Dictionary<Type, List<Delegate>> subscribers = new Dictionary<Type, List<Delegate>>();

        public void Subscribe<TEvent>(Action<TEvent> handler)
        {
            var eventType = typeof(TEvent);

            if (!subscribers.ContainsKey(eventType))
                subscribers[eventType] = new List<Delegate>();

            subscribers[eventType].Add(handler);
        }

        public void Publish<TEvent>(TEvent @event)
        {
            var eventType = typeof(TEvent);

            if (subscribers.ContainsKey(eventType))
            {
                foreach (var handler in subscribers[eventType])
                {
                    if (handler is Action<TEvent> action)
                    {
                        action.Invoke(@event);
                    }
                }
            }
        }
    }
}
