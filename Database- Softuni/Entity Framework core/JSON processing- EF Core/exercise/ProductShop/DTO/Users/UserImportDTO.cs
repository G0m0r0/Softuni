﻿using Newtonsoft.Json;

namespace ProductShop.DTO.Users
{
    public class UserImportDTO
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("age")]
        public int? Age { get; set; }
    }
}
