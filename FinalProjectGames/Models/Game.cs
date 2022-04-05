using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectGames.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public int GameTypeId { get; set; }
        public string GameType { get; set; }

        [Required]
        [Range(1, 5)]
        public int? Rating { get; set; }
        public string Description { get; set; }
    }
}
