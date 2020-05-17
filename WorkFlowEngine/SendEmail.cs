using System;

namespace WorkFlowEngine
{
    internal class SendEmail : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email..");
        }
    }
}