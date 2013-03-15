﻿using DDD.OnlineStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OnlineStore.Domain.Model
{
    public class Order : OrderBase, IEntity
    {
        public Order() : base() { }

        public int ID { get; set; }
        public User User { get; set; }

        protected override void Add(OrderItem item)
        {                                               
            if (item == null || item.IsValid)                       
                throw new Exception("cann't add an invalid item to the order");

            if (item.OrderID != this.ID)
                throw new Exception("this order item belongs to another order!");

 	         base.Add(item);
        }

    }
}
