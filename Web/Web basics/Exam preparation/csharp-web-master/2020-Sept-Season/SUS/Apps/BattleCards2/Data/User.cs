﻿namespace BattleCards2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserCard = new HashSet<UserCard>();
        }
        public string Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<UserCard> UserCard { get; set; }
    }
}
