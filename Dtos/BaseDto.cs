using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; } = null;
        public int CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
