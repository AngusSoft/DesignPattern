using System;

namespace MediatorPattern
{
    public class Man : Person
    {
        public Man(string name)
            :base(name)
        {

        }

        /// <summary>
        /// 联系中介者想要谈恋爱
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mediator"></param>
        public void TalkLove(string message,IMediator mediator)
        {
            Console.WriteLine(message);
            mediator.WoManConnect();
        }

        /// <summary>
        /// 自我介绍
        /// </summary>
        public override void MySelfInfo()
        {
            Console.WriteLine($"我的名字是：{Name}，你看我合适吗？");
        }
    }
}
