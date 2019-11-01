using System;

namespace Vk.Generator
{
    public static class Configuration
    {
        public static string CodeOutputPath { get; set; } = AppContext.BaseDirectory;
        public static bool MapBaseTypes { get; set; } = true;
    }
}
