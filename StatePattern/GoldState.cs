using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class GoldState : State
    {
        private GameMan _gameMan { get; set; }

        public string Level { get; set; }

        public GoldState(GameMan gameMan)
        {
            _gameMan = gameMan;
        }

        public void Lose()
        {
            _gameMan.rankScore -= 20;
            StateChange();
        }

        public void Win()
        {
            _gameMan.rankScore += 30;
            StateChange();


        }

        private void StateChange()
        {
            if (_gameMan.rankScore > 100)
            {
                _gameMan.level = "黄金";
                _gameMan.state = this;
            }
            else
            {
                _gameMan.level = "白银";
                _gameMan.state = new SilverState(_gameMan);
            }
        }
    }
}
