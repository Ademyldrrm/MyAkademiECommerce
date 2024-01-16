﻿namespace MyAkademiECommerce.Discount.Models
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActice { get; set; }
        public DateTime ValidDate { get; set; }
    }
}