using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class SilverState : State
    {
        private GameMan _gameMan { get; set; }

        public SilverState(GameMan gameMan)
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
            if (_gameMan.rankScore <= 0)
            {
                _gameMan.level = "白银";
                _gameMan.rankScore = 0;
                _gameMan.state = this;
            }
            else if(_gameMan.rankScore <= 100)
            {
                _gameMan.level = "白银";
                _gameMan.state = this;
            }
            else
            {
                _gameMan.level = "黄金";
                _gameMan.state = new GoldState(_gameMan);
            }
        }
    }
}
