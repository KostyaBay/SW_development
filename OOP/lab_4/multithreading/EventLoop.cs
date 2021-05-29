using System;
using System.Collections.Generic;
using System.Threading;

public class EventLoop
{

    private static ManualResetEventSlim _messageEvent = new ManualResetEventSlim(false);
    private static Queue<string> _messageQueue = new Queue<string>();

    public void Threadmain()
    {
        var thread = new Thread(PumpMessages);
        thread.Start();

        while (true)
        {
            var message = WaitMessage();
            WriteLine("Received message: " + message);
            if (message == "exit")
            {
                break;
            }
        }
    }

    private string WaitMessage()
    {
        _messageEvent.Wait();
        var message = _messageQueue.Dequeue();
        _messageEvent.Reset();
        return message;
    }

    private void PumpMessages()
    {
        while (true)
        {
            var symbol = ReadLine();
            _messageQueue.Enqueue(symbol);
            _messageEvent.Set();
            if (symbol == "exit")
            {
                break;
            }
        }
    }

    public virtual string ReadLine()
    {
        return Console.ReadLine();
    }

    public virtual void WriteLine(string str)
    {
        Console.WriteLine(str);
    }
}