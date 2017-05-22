using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterGame.Models;

namespace CharacterGame.Controllers
{
    public static class GlobalVariables
    {
        public static List<Character> Characters { get; set; } = new List<Character>();
    }
}
