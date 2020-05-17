using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class WorkFlowEngine
    {
        List<IWorkFlow> workFlows;

        public WorkFlowEngine()
        {
            workFlows = new List<IWorkFlow>();
        }

        public void RegisterWorkFlow(IWorkFlow workflow)
        {
            workFlows.Add(workflow);
        }

        public void ExecuteWorkFlows()
        {
            foreach (IWorkFlow workflow in workFlows)
            {
                workflow.Execute();
            }
        }

    }
}
