// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluscolor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public partial struct Color
{
    [NativeTypeName("Gdiplus::ARGB")]
    public uint Argb;

    public Color()
    {
        Argb = (uint)(Black);
    }

    public Color(byte r, byte g, byte b)
    {
        Argb = MakeARGB(255, r, g, b);
    }

    public Color(byte a, byte r, byte g, byte b)
    {
        Argb = MakeARGB(a, r, g, b);
    }

    public Color([NativeTypeName("Gdiplus::ARGB")] uint argb)
    {
        Argb = argb;
    }

    public byte GetAlpha()
    {
        return (byte)(Argb >> (int)(AlphaShift));
    }

    public byte GetA()
    {
        return GetAlpha();
    }

    public byte GetRed()
    {
        return (byte)(Argb >> (int)(RedShift));
    }

    public byte GetR()
    {
        return GetRed();
    }

    public byte GetGreen()
    {
        return (byte)(Argb >> (int)(GreenShift));
    }

    public byte GetG()
    {
        return GetGreen();
    }

    public byte GetBlue()
    {
        return (byte)(Argb >> (int)(BlueShift));
    }

    public byte GetB()
    {
        return GetBlue();
    }

    [return: NativeTypeName("Gdiplus::ARGB")]
    public uint GetValue()
    {
        return Argb;
    }

    public void SetValue([NativeTypeName("Gdiplus::ARGB")] uint argb)
    {
        Argb = argb;
    }

    public void SetFromCOLORREF(COLORREF rgb)
    {
        Argb = MakeARGB(
            255,
            (((byte)(((nuint)(rgb)) & 0xff))),
            (((byte)(((nuint)(unchecked(((ushort)(rgb)) >> 8))) & 0xff))),
            (((byte)(((nuint)((rgb) >> 16)) & 0xff)))
        );
    }

    [return: NativeTypeName("Gdiplus::ARGB")]
    public static uint MakeARGB(byte a, byte r, byte g, byte b)
    {
        return (
            ((uint)(b) << (int)(BlueShift))
            | ((uint)(g) << (int)(GreenShift))
            | ((uint)(r) << (int)(RedShift))
            | ((uint)(a) << (int)(AlphaShift))
        );
    }

    public const uint AliceBlue = 0xFFF0F8FF;
    public const uint AntiqueWhite = 0xFFFAEBD7;
    public const uint Aqua = 0xFF00FFFF;
    public const uint Aquamarine = 0xFF7FFFD4;
    public const uint Azure = 0xFFF0FFFF;
    public const uint Beige = 0xFFF5F5DC;
    public const uint Bisque = 0xFFFFE4C4;
    public const uint Black = 0xFF000000;
    public const uint BlanchedAlmond = 0xFFFFEBCD;
    public const uint Blue = 0xFF0000FF;
    public const uint BlueViolet = 0xFF8A2BE2;
    public const uint Brown = 0xFFA52A2A;
    public const uint BurlyWood = 0xFFDEB887;
    public const uint CadetBlue = 0xFF5F9EA0;
    public const uint Chartreuse = 0xFF7FFF00;
    public const uint Chocolate = 0xFFD2691E;
    public const uint Coral = 0xFFFF7F50;
    public const uint CornflowerBlue = 0xFF6495ED;
    public const uint Cornsilk = 0xFFFFF8DC;
    public const uint Crimson = 0xFFDC143C;
    public const uint Cyan = 0xFF00FFFF;
    public const uint DarkBlue = 0xFF00008B;
    public const uint DarkCyan = 0xFF008B8B;
    public const uint DarkGoldenrod = 0xFFB8860B;
    public const uint DarkGray = 0xFFA9A9A9;
    public const uint DarkGreen = 0xFF006400;
    public const uint DarkKhaki = 0xFFBDB76B;
    public const uint DarkMagenta = 0xFF8B008B;
    public const uint DarkOliveGreen = 0xFF556B2F;
    public const uint DarkOrange = 0xFFFF8C00;
    public const uint DarkOrchid = 0xFF9932CC;
    public const uint DarkRed = 0xFF8B0000;
    public const uint DarkSalmon = 0xFFE9967A;
    public const uint DarkSeaGreen = 0xFF8FBC8B;
    public const uint DarkSlateBlue = 0xFF483D8B;
    public const uint DarkSlateGray = 0xFF2F4F4F;
    public const uint DarkTurquoise = 0xFF00CED1;
    public const uint DarkViolet = 0xFF9400D3;
    public const uint DeepPink = 0xFFFF1493;
    public const uint DeepSkyBlue = 0xFF00BFFF;
    public const uint DimGray = 0xFF696969;
    public const uint DodgerBlue = 0xFF1E90FF;
    public const uint Firebrick = 0xFFB22222;
    public const uint FloralWhite = 0xFFFFFAF0;
    public const uint ForestGreen = 0xFF228B22;
    public const uint Fuchsia = 0xFFFF00FF;
    public const uint Gainsboro = 0xFFDCDCDC;
    public const uint GhostWhite = 0xFFF8F8FF;
    public const uint Gold = 0xFFFFD700;
    public const uint Goldenrod = 0xFFDAA520;
    public const uint Gray = 0xFF808080;
    public const uint Green = 0xFF008000;
    public const uint GreenYellow = 0xFFADFF2F;
    public const uint Honeydew = 0xFFF0FFF0;
    public const uint HotPink = 0xFFFF69B4;
    public const uint IndianRed = 0xFFCD5C5C;
    public const uint Indigo = 0xFF4B0082;
    public const uint Ivory = 0xFFFFFFF0;
    public const uint Khaki = 0xFFF0E68C;
    public const uint Lavender = 0xFFE6E6FA;
    public const uint LavenderBlush = 0xFFFFF0F5;
    public const uint LawnGreen = 0xFF7CFC00;
    public const uint LemonChiffon = 0xFFFFFACD;
    public const uint LightBlue = 0xFFADD8E6;
    public const uint LightCoral = 0xFFF08080;
    public const uint LightCyan = 0xFFE0FFFF;
    public const uint LightGoldenrodYellow = 0xFFFAFAD2;
    public const uint LightGray = 0xFFD3D3D3;
    public const uint LightGreen = 0xFF90EE90;
    public const uint LightPink = 0xFFFFB6C1;
    public const uint LightSalmon = 0xFFFFA07A;
    public const uint LightSeaGreen = 0xFF20B2AA;
    public const uint LightSkyBlue = 0xFF87CEFA;
    public const uint LightSlateGray = 0xFF778899;
    public const uint LightSteelBlue = 0xFFB0C4DE;
    public const uint LightYellow = 0xFFFFFFE0;
    public const uint Lime = 0xFF00FF00;
    public const uint LimeGreen = 0xFF32CD32;
    public const uint Linen = 0xFFFAF0E6;
    public const uint Magenta = 0xFFFF00FF;
    public const uint Maroon = 0xFF800000;
    public const uint MediumAquamarine = 0xFF66CDAA;
    public const uint MediumBlue = 0xFF0000CD;
    public const uint MediumOrchid = 0xFFBA55D3;
    public const uint MediumPurple = 0xFF9370DB;
    public const uint MediumSeaGreen = 0xFF3CB371;
    public const uint MediumSlateBlue = 0xFF7B68EE;
    public const uint MediumSpringGreen = 0xFF00FA9A;
    public const uint MediumTurquoise = 0xFF48D1CC;
    public const uint MediumVioletRed = 0xFFC71585;
    public const uint MidnightBlue = 0xFF191970;
    public const uint MintCream = 0xFFF5FFFA;
    public const uint MistyRose = 0xFFFFE4E1;
    public const uint Moccasin = 0xFFFFE4B5;
    public const uint NavajoWhite = 0xFFFFDEAD;
    public const uint Navy = 0xFF000080;
    public const uint OldLace = 0xFFFDF5E6;
    public const uint Olive = 0xFF808000;
    public const uint OliveDrab = 0xFF6B8E23;
    public const uint Orange = 0xFFFFA500;
    public const uint OrangeRed = 0xFFFF4500;
    public const uint Orchid = 0xFFDA70D6;
    public const uint PaleGoldenrod = 0xFFEEE8AA;
    public const uint PaleGreen = 0xFF98FB98;
    public const uint PaleTurquoise = 0xFFAFEEEE;
    public const uint PaleVioletRed = 0xFFDB7093;
    public const uint PapayaWhip = 0xFFFFEFD5;
    public const uint PeachPuff = 0xFFFFDAB9;
    public const uint Peru = 0xFFCD853F;
    public const uint Pink = 0xFFFFC0CB;
    public const uint Plum = 0xFFDDA0DD;
    public const uint PowderBlue = 0xFFB0E0E6;
    public const uint Purple = 0xFF800080;
    public const uint Red = 0xFFFF0000;
    public const uint RosyBrown = 0xFFBC8F8F;
    public const uint RoyalBlue = 0xFF4169E1;
    public const uint SaddleBrown = 0xFF8B4513;
    public const uint Salmon = 0xFFFA8072;
    public const uint SandyBrown = 0xFFF4A460;
    public const uint SeaGreen = 0xFF2E8B57;
    public const uint SeaShell = 0xFFFFF5EE;
    public const uint Sienna = 0xFFA0522D;
    public const uint Silver = 0xFFC0C0C0;
    public const uint SkyBlue = 0xFF87CEEB;
    public const uint SlateBlue = 0xFF6A5ACD;
    public const uint SlateGray = 0xFF708090;
    public const uint Snow = 0xFFFFFAFA;
    public const uint SpringGreen = 0xFF00FF7F;
    public const uint SteelBlue = 0xFF4682B4;
    public const uint Tan = 0xFFD2B48C;
    public const uint Teal = 0xFF008080;
    public const uint Thistle = 0xFFD8BFD8;
    public const uint Tomato = 0xFFFF6347;
    public const uint Transparent = 0x00FFFFFF;
    public const uint Turquoise = 0xFF40E0D0;
    public const uint Violet = 0xFFEE82EE;
    public const uint Wheat = 0xFFF5DEB3;
    public const uint White = 0xFFFFFFFF;
    public const uint WhiteSmoke = 0xFFF5F5F5;
    public const uint Yellow = 0xFFFFFF00;
    public const uint YellowGreen = 0xFF9ACD32;
    public const int AlphaShift = 24;
    public const int RedShift = 16;
    public const int GreenShift = 8;
    public const int BlueShift = 0;
    public const uint AlphaMask = 0xff000000;
    public const uint RedMask = 0x00ff0000;
    public const uint GreenMask = 0x0000ff00;
    public const uint BlueMask = 0x000000ff;
}
