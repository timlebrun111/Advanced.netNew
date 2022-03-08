﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster.Models
{
    [ModelMetadataType(typeof(TransactionMetaData))]
    public partial class Transaction
    {
    }

    public class TransactionMetaData
    {
        [Display(Name = "Checked Out Date")]
        public DateTime CheckedOutDate { get; set; }
        [Display(Name ="Due Date")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Checked In")]
        public string CheckedIn { get; set; }
    }
}
