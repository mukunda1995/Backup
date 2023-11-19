using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CinemaGo.DataModels.CustomModels
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int? Quantity { get; set; }

        public int? ProductId { get; set; }

        public int? SubTotal { get; set; }

        public string CreatedOn { get; set; }


    }
}
