using PracticesCsharp01Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesCsharp01Enum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        //property OrderStatus type enum in a class  
        public OrderStatus Status{ get; set; }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }



        //to print
        public override string ToString()
        {                
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
            }
        }

    }

