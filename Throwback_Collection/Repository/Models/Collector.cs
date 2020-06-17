﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Collector
    {
        [Key]
        public int CollectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Collection")]
        public int CollectionId { get; set; }
        public CollectionObj Collection { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        [ForeignKey("WishList")]
        public int WishListId { get; set; }
        public string WishList { get; set; }
    }
}
