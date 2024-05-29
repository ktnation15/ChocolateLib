namespace ChocolateLib
{
    public class EasterEgg
    {
        public int ProductNo { get; set; }
        public string ChocolateType { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }

        public override string ToString()
        {
            return $"ProductNo: {ProductNo}, ChocolateType: {ChocolateType}, Price: {Price}, InStock: {InStock}";
        }
    }
}
