using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class VmStock
{
    public int id { get; set; }

    public String Name { get; set; }

    public float UnitPrice { get; set; }

    public float Amount { get; set; }

    public float Total
    {
        get
        {
            return UnitPrice * Amount;
        }
    }

}