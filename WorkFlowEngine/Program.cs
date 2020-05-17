using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkFlowEngine workFlowEngine = new WorkFlowEngine();
            workFlowEngine.RegisterWorkFlow(new Upload());
            workFlowEngine.RegisterWorkFlow(new VideoEncoding());
            workFlowEngine.RegisterWorkFlow(new SendEmail());
            workFlowEngine.RegisterWorkFlow(new ChangeStatus());

            workFlowEngine.ExecuteWorkFlows();

            Console.ReadLine();
        }
    }
}
