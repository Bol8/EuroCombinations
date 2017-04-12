﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.TableUtilities;
using System.ComponentModel.DataAnnotations;

namespace LoteriaUI.Models.Euromillones
{
    public class mEuroCombination
    {
        [Display(Name = @"Nº 1")]
        [DisplayName(@"Nº 1")]
        public int Number1 { get; set; }

        [Display(Name = @"Nº 2")]
        [DisplayName(@"Nº 2")]
        public int Number2 { get; set; }

        [Display(Name = @"Nº 3")]
        [DisplayName(@"Nº 3")]
        public int Number3 { get; set; }

        [Display(Name = @"Nº 4")]
        [DisplayName(@"Nº 4")]
        public int Number4 { get; set; }

        [Display(Name = @"Nº 5")]
        [DisplayName(@"Nº 5")]
        public int Number5 { get; set; }

        [Display(Name = @"Estrella 1")]
        [DisplayName(@"Estrella 1")]
        public int Star1 { get; set; }

        [Display(Name = @"Estrella 2")]
        [DisplayName(@"Estrella 2")]
        public int Star2 { get; set; }

        [Display(Name = @"Fecha")]
        [DisplayName(@"Fecha")]
        public DateTime Date { get; set; }



    }
}
