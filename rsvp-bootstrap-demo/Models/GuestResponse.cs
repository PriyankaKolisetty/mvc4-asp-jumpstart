using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rsvp_bootstrap_demo.Models {
    public class GuestResponse {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public bool IsAvailable { get; set; }
    }
}
