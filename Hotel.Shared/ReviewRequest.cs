﻿using System.ComponentModel.DataAnnotations;

namespace Hotel.Shared
{
    public class ReviewRequest
    {
        [MaxLength(255, ErrorMessage = "No more than 255 characters allowed!")]
        public string? Description { get; set; }
        [Required]
        [RegularExpression(@"^[1-5]{1}$", ErrorMessage = "Grade must be between 1 and 5!")]
        public int Grade { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]{8}-([A-Za-z0-9]{4}-){3}[A-Za-z0-9]{12}$", ErrorMessage = "Booking Number format is incorrect!")]
        public string BookingNumber { get; set; }
        public bool Anonymous { get; set; } = false;
    }
}
