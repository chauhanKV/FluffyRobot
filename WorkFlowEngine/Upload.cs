using System;

namespace WorkFlowEngine
{
    internal class Upload : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video..");
        }
    }
}