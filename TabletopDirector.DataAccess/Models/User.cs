using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TabletopDirector.DataAccess.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        [ForeignKey("Name")]
        public Guid NameId { get; set; }
        public Name Name { get; set; }
        [ForeignKey("Email")]
        public Guid EmailId { get; set; }
        public Email Email { get; set; }
        [ForeignKey("Phone")]
        public Guid PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
    public class Name
    {
        public Guid Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
    public class Email
    {
        public Guid Id { get; set; }
        public string Primary { get; set; }
    }
    public class Phone
    {
        public Guid Id { get; set; }
        public string Primary { get; set; }
    }
}
