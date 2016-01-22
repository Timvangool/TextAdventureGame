using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Player
    {
        private string playerName;
        private int playerLives, playerLevel, playerMoney;

        public Player()
        {

        }

        public Player(string playerName, int playerLives, int playerLevel)
        {
            
        }

        #region Get Set
        public string GetPlayerName()
        {
            return this.playerName;
        }

        public void SetPlayerName(string playerName)
        {
            this.playerName = playerName;
        }

        public int GetPlayerLevel()
        {
            return playerLevel;
        }

        public void SetPlayerLevel(int playerLevel)
        {
            this.playerLevel = playerLevel;
        }

        public int GetPlayerLives()
        {
            return playerLives;
        }

        public void SetPlayerLives(int playerLives)
        {
            this.playerLives = playerLives;
        }

        public int GetPlayerMoney()
        {
            return playerMoney;
        }

        public void SetPlayerMoney(int playerMoney)
        {
            this.playerMoney = playerMoney;
        }
        #endregion
    }
}
