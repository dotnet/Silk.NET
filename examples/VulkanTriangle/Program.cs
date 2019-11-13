using System;
using System.IO;

namespace VulkanTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new HelloTriangleApplication();
            app.Run();
        }

        internal static byte[] LoadEmbeddedResourceBytes(string path)
        {
            using (var s = typeof(Program).Assembly.GetManifestResourceStream(path))
            {
                using (var ms = new MemoryStream())
                {
                    s.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
