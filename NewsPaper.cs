using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne
{
    public interface NewsPaper
    {
         int Id { get; set; }
         int Quantity { get; set; }
         decimal Price { get; set; }
         int Week { get; set; }
        decimal Total { get; set; }
    }
}
