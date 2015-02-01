using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Characters;
using TheSlum.Items;
using TheSlum.Weapons;

namespace TheSlum.GameEngine
{
    class ExtendedEngine : Engine
    {
        public ExtendedEngine()
            : base()
        {
            
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        // create characterClass id x y team
        protected override void CreateCharacter(string[] inputParams)
        {
            Character champion;
            switch (inputParams[1].ToLower())
            {
                case "warrior" :
                    champion = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        200,
                        100,
                        (Team)Enum.Parse(typeof(Team), inputParams[5]),
                        2
                        );
                    this.characterList.Add(champion);
                    break;

                case "mage":
                    champion = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        150,
                        50,
                        (Team)Enum.Parse(typeof(Team), inputParams[5]),
                        5
                        );
                    this.characterList.Add(champion);
                    break;

                case "healer":
                    champion = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        75,
                        50,
                        (Team)Enum.Parse(typeof(Team), inputParams[5]),
                        6
                        );
                    this.characterList.Add(champion);
                    break;

                default :
                    break;
            }
        }

        // add character itemClass itemId
        protected void AddItem(string[] inputParams)
        {
            Character champion = GetCharacterById(inputParams[1]);
            Item artifact;

            switch (inputParams[2].ToLower())
            {
                case "axe":
                    artifact = new Axe(
                        inputParams[3],
                        0,
                        0,
                        75);
                    champion.AddToInventory(artifact);
                    break;

                case "shield":
                    artifact = new Shield(
                        inputParams[3],
                        0,
                        50,
                        0);
                    champion.AddToInventory(artifact);
                    break;

                case "injection":
                    artifact = new Injection(
                        inputParams[3],
                        200,
                        0,
                        0);
                    champion.AddToInventory(artifact);
                    break;

                case "pill":
                    artifact = new Pill(
                        inputParams[3],
                        0,
                        0,
                        100);
                    champion.AddToInventory(artifact);
                    break;

                default :
                    break;
            }
        }
    }
}
