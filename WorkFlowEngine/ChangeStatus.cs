using System;

namespace WorkFlowEngine
{
    internal class ChangeStatus : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Changing Status...");
        }
    }
}