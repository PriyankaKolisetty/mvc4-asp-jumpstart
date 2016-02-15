using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace empty_demo.Models {
    public class GuestResponse {
        [Required(ErrorMessage="Name is mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage ="we need your email id before we can register you")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="email is not in the format as expected")]
        public string  Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}