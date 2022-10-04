﻿using System.ComponentModel.DataAnnotations;

namespace RunClubWebApp.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }

        public int Pace { get; set; }

        public int Distance { get; set; }

        public Address Address { get; set; }

        
        public ICollection<Club> Clubs { get; set; }
       
        public ICollection<Race> Races { get; set; }



    }
}
