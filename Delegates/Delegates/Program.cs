using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Custom delegate
            PhotoProcessor photoProcessor = new PhotoProcessor();

            Filters filters = new Filters();

            PhotoProcessor.ApplyFilters filterList = filters.ApplyBrightness;
            filterList += ApplyShade; // ApplyShade's signature is similar to the ApplyFilters delegate
            filterList += filters.ApplyContrast;

            photoProcessor.Process(@"C:\img.png", filterList);




            // Using Action<> delegate
            PhotoProcessor2 photoProcessor2 = new PhotoProcessor2();

            Filters filters2 = new Filters();

            Action<Photo> filterList2 = filters.ApplyBrightness;
            filterList2 += ApplyShade; // ApplyShade's signature is similar to the ApplyFilters delegate
            filterList2 += filters.ApplyContrast;

            photoProcessor2.Process(@"C:\img.png", filterList2);
        }

        public static void ApplyShade(Photo photo) // method signature similar to the one accepted by ApplyFilters delegate
        {
            Console.WriteLine("Shade applied");
        }
    }
}
