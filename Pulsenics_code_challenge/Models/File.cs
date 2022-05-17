using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsenics_code_challenge
{
    public class File
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Created_at { get; set; }
        public string? Updated_at { get; set; }
        public ICollection<User_file>? Users { get; set; }

    }
}
