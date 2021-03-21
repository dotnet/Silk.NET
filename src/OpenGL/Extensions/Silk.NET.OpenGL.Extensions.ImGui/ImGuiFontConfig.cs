using System;

namespace Silk.NET.OpenGL.Extensions.ImGui
{
    public readonly struct ImGuiFontConfig
    {
        public ImGuiFontConfig(string fontPath, int fontSize)
        {
            if (fontSize <= 0) throw new ArgumentOutOfRangeException(nameof(fontSize));
            FontPath = fontPath ?? throw new ArgumentNullException(nameof(fontPath));
            FontSize = fontSize;
        }

        public string FontPath { get; }
        public int FontSize { get; }
    }
}
