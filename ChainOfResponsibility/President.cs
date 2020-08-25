using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class President : Approver
    {
        public string Name { get; set; }

        public Approver NextApprover;

        public President(string name)
        {
            Name = name;
        }

        public void Approve(ApplyRequest request)
        {
            Console.WriteLine($"{Name}已审批完成,流程结束。");
        }

    }
}
