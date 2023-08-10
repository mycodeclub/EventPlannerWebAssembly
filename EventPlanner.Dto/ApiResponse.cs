using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Dto
{
    public class ApiResponse
    {

        public bool IsCreated { get; set; }
        public Guid UniqueId { get; set; }
        public List<string>? ErrorMessages { get; set; }
        public List<string>? SuccessMessages { get; set; }
        public List<string>? Details { get; set; }
    }
}
