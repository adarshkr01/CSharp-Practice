namespace StructTypeExtension
{
    public static class IntegerExtensions
    {
        public static bool IsGreaterThan10(this int num)
        {
            return num > 10;
        }

        public static void Make10(ref this int num)
        {
            num = 10;
        }
    }
}
