using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models {
    public class Order {

        [BindNever]
        public int id { get; set; }
        [Display(Name = "Имя")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surname { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string addres { get; set; }
        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина телефона не менее 8 символов")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина Email не менее 15 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }


    }
}
