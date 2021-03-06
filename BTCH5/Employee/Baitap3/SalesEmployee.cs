﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class SalesEmployee :SalariedEmployee
    {
        private double commission;
        private double sales;

        public SalesEmployee(string name, int year, int month, int day, double salary,
            double commission, double sales)
            :base(name,year,month,day,salary)
        {
            this.commission = commission;
            this.sales = sales;
        }



        public override string DisplayStat()
        {
            return string.Format("Name: {0}; " +
                "Ngay sinh: {1}; " +
                "Dia chi: {2}; " + 
                "Commission: {3}; " +
                "Sales: {4} " +
                 "CalcPay: {5}", this.name, this.date.DisplayStat(), this.adress.DisplayStat(), this.commission, this.sales);
        }
    }
}
