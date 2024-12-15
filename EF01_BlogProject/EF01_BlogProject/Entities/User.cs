using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01_BlogProject.Entities
{
    public class User
    {
        public int ID { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

        // Navigation properties
        public ICollection<Post>? Posts { get; set; } = new List<Post>();
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();

        public override string ToString()
        {
            return $"[{ID,-2}] | UserName: {UserName,-20}, Password: {Password,-20}";
        }
    }
}
