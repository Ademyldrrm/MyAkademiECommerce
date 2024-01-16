namespace MyAkademiECommerce.Discount.Dtos
{
    public class CreateCouponDto
    {
       
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActice { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
