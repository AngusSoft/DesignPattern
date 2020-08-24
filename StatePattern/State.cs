using System;

namespace StatePattern
{
    public interface State
    {
        /// <summary>
        /// 战斗胜利
        /// </summary>
        public void Win();

        /// <summary>
        /// 战斗失败
        /// </summary>
        public void Lose();
    }
}
