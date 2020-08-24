using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class GameMan
    {
        internal State state;

        /// <summary>
        /// rank分数
        /// </summary>
        internal int rankScore { get; set; }

        /// <summary>
        /// 当前段位
        /// </summary>
        internal string level { get; set; }

        public GameMan()
        {
            rankScore = 0;
            level = "白银";
            state = new SilverState(this);
        }

        public void Win()
        {
            Console.WriteLine("游戏胜利");
            state.Win();
            Console.WriteLine($"当前游戏Rank分数：{rankScore}");
            Console.WriteLine($"当前段位：{level}");
        }

        public void Lose()
        {
            Console.WriteLine("游戏失败");
            state.Lose();
            Console.WriteLine($"当前游戏Rank分数：{rankScore}");
            Console.WriteLine($"当前段位：{level}");
        }

    }
}
