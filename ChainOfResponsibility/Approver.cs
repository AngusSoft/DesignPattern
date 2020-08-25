using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 抽象审批人
    /// </summary>
    public interface Approver
    {
        /// <summary>
        /// 审批人名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 定义审批方法
        /// </summary>
        /// <param name="amount"></param>
        void Approve(ApplyRequest request);
    }
}
