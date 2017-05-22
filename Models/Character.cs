using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using CharacterGame.Controllers;

namespace CharacterGame.Models
{
    public class Character
    {
        //public string Name;
        public string Type;

        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexteriry { get; set; }
        public int Intelligence { get; set; }
        public List<Character> Characters { get; set; }

        public static void Create(string CharacterName, string CharacterType)
        {
            var character = new Character();

            character.Name = CharacterName;
            character.Type = CharacterType;

            GlobalVariables.Characters.Add(character);
        }

        public static List<Character> GetAll()
        {
            return GlobalVariables.Characters;
        }
    }
}
