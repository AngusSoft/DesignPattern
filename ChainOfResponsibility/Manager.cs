using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Manager : Approver
    {
        public string Name { get; set; }

        public Approver NextApprover;

        public Manager(string name)
        {
            Name = name;
        }

        public void Approve(ApplyRequest request)
        {
            if(request.Amount < 10000)
            {
                Console.WriteLine($"{Name}审批已完成，结束流程。");
            }
            else
            {
                Console.WriteLine($"{Name}审批已完成，等待{NextApprover.Name}审批。");
                NextApprover.Approve(request);
            }
        }
    }
}
