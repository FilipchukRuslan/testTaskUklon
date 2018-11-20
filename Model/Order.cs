using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }

        public string AddressFrom { get; set; }

        public string AddressTo { get; set; }

        public string Phone { get; set; }

        public int Price { get; set; }

        public bool IsCanceled { get; set; }
    }
}
