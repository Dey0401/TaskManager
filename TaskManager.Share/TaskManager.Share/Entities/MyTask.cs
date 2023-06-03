using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Share.Entities
{
    public class MyTask
    {
        #region Properties
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; }
        #endregion


    }
}
