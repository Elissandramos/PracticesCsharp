using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesCsharp01Enum.Entities.Enums
{
    enum OrderStatus : int    {

        //PendingPayment = 0,
        //Processing =  1,
        //Shipped = 2,
        //Delivered = 3

        //OR -> if without '=0', it will be automatically starting with '0'

        PendingPayment,
        Processing,
        Shipped ,
        Delivered
    }
}
