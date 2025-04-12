namespace DeleGateAndEvent
{
    using System;


    delegate void EventHandler();

    class EventPublisher
    {
        public event EventHandler? MyEvent;

        public void TriggerEvent()
        {

            if (MyEvent != null)
            {
                Console.WriteLine("Event triggered.");

                MyEvent.Invoke();
            }
        }
    }

    class EventSubscriber
    {

        public void HandleEvent()
        {
            Console.WriteLine("Event handled.");
        }
    }

    public class EventDemo
    {
        public static void RunProgram()
        {

            EventPublisher publisher = new EventPublisher();

            EventSubscriber subscriber = new EventSubscriber();


            publisher.MyEvent += subscriber.HandleEvent;


            publisher.TriggerEvent();

        }
    }
}