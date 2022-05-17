using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsenics_code_challenge
{
    public class User_file
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

        public int FileId { get; set; }

        public File File { get; set; } 
    }
}
