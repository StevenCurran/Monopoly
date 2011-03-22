using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    class Trader
    {
        public Trader(String name, Board.TraderID id)
        {
            this.name = name;
            this.id = id;
        }

        public void TransferMoney(Trader destination, int amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                destination.Balance += amount;
            }
            else
            {
                // Display some sort of error that they can't afford nothin'
            }
        }

        public void TransferPropertySquare(Trader destination, PropertySquare property)
        {
            RemovePropertySquare(property);
            destination.AddPropertySquare(property);
        }

        public void AddPropertySquare(PropertySquare property)
        {
            properties.Add(property);
            property.Owner = id;
        }

        public void RemovePropertySquare(PropertySquare property)
        {
            properties.Remove(property);
        }

        public String Name
        {
            get
            {
                return name;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance += value;
                if(balance < 0 && id != Board.TraderID.Banker)
                {
                    // Do something in here to kick the player out of the game
                    // Player.Kick("Ping, noob!");
                    // Something like force them to mortgage stuff or sell houses or they lose. If they can't,
                    // then obviously they lose. If they choose not to, well, that's their choice isn't it.
                }
            }
        }

        public List<PropertySquare> Properties
        {
            get
            {
                return properties;
            }
        }

        public Board.TraderID ID
        {
            get
            {
                return id;
            }
        }

        private Board.TraderID id;
        private int balance;
        private String name;
        private List<PropertySquare> properties;
    }
}