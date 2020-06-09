using System;
using System.ComponentModel.DataAnnotations;

namespace CityCritic.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Required(ErrorMessage = "You must write something in your review")]
        public string ReviewText { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int StarRating { get; set; }
    }
}

