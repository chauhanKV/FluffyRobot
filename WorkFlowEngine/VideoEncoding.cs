using System;

namespace WorkFlowEngine
{
    internal class VideoEncoding : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Encoding Video..");
        }
    }
}