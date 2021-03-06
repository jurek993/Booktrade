﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Booktrade.ViewModels
{
    public class SellBookModel
    {

        [Required]
        [StringLength(50)]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Gatunek")]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Autor")]
        [StringLength(50)]
        public string Author { get; set; }
        [Display(Name = "Wydawca")]
        public string Publisher { get; set; }
        [Display(Name = "Data wydania")]
        public DateTime? PublicationDate { get; set; }
        [Display(Name = "Chęć wymiany")]
        public bool Changeable { get; set; }
        [Range(0, 100000)]
        [Display(Name = "Cena")]
        public float? Price { get; set; }
        [Display(Name = "Zdjęcie")]
        public IEnumerable<HttpPostedFileBase> BookImages { get; set; }
        public AppUser Seller { get; set; }

        //DELIVERY
        [Display(Name = "Opcje dostawy")]
        public List<float> DeliveryPrice { get; set; }
        public List<string> DeliveryName { get; set; }
    }
}