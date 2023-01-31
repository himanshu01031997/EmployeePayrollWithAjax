using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpPayrollMVCWithAjax.Models
{
    public class EmpModel
    {
        [Key]
        public int EmpID { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "This Field is required.")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "This Field is required.")]
        [Column(TypeName = "nvarchar(500)")]
        public string ProfileImg { get; set; }

        [Required(ErrorMessage = "This Field is required.")]
        [Column(TypeName = "nvarchar(255)")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "This Field is required.")]
        [Column(TypeName = "nvarchar(255)")]
        public string Department { get; set; }

        [Required(ErrorMessage = "This Field is required.")]
        public float Salary { get; set; }

        [Required(ErrorMessage = "This Field is required.")]
        [Column(TypeName = "DateTime")]

        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }



        [Column(TypeName = "nvarchar(255)")]
        public string Notes { get; set; }
    }
}
