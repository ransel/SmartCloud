using System;

namespace SmartCloud.Services.Helpers
{
    public static class PinGenerator
    {
        public static string Generate()
        {
            var generator = new Random();
            return generator.Next(0, 999999).ToString("D6");
        }
    }
}