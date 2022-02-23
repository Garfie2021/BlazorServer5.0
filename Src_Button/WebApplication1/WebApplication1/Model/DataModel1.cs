using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Const;

namespace WebApplication1.Model
{
    public class DataModel1
    {
        [Display(Name = "入力欄A")]
        [Required(ErrorMessage = Message.RequiredErrorMessage)]
        public string InputA { get; set; }
    }
}
