using System;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
    public class OrderModel
    {
        [Required] public Guid CustomerGuid { get; set; }

        [Required] public string CustomerName { get; set; }
    }
}