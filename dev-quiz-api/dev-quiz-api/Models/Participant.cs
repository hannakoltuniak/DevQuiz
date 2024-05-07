﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dev_quiz_api.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public int Score { get; set; }

        public int TimeTaken { get; set; }
    }
}