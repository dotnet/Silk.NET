// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "Enum")]
    public enum Enum : int
    {
        [NativeName("Name", "AliceBlue")]
        AliceBlue = 0xF0F8FF,
        [NativeName("Name", "AntiqueWhite")]
        AntiqueWhite = 0xFAEBD7,
        [NativeName("Name", "Aqua")]
        Aqua = 0xFFFF,
        [NativeName("Name", "Aquamarine")]
        Aquamarine = 0x7FFFD4,
        [NativeName("Name", "Azure")]
        Azure = 0xF0FFFF,
        [NativeName("Name", "Beige")]
        Beige = 0xF5F5DC,
        [NativeName("Name", "Bisque")]
        Bisque = 0xFFE4C4,
        [NativeName("Name", "Black")]
        Black = 0x0,
        [NativeName("Name", "BlanchedAlmond")]
        BlanchedAlmond = 0xFFEBCD,
        [NativeName("Name", "Blue")]
        Blue = 0xFF,
        [NativeName("Name", "BlueViolet")]
        BlueViolet = 0x8A2BE2,
        [NativeName("Name", "Brown")]
        Brown = 0xA52A2A,
        [NativeName("Name", "BurlyWood")]
        BurlyWood = 0xDEB887,
        [NativeName("Name", "CadetBlue")]
        CadetBlue = 0x5F9EA0,
        [NativeName("Name", "Chartreuse")]
        Chartreuse = 0x7FFF00,
        [NativeName("Name", "Chocolate")]
        Chocolate = 0xD2691E,
        [NativeName("Name", "Coral")]
        Coral = 0xFF7F50,
        [NativeName("Name", "CornflowerBlue")]
        CornflowerBlue = 0x6495ED,
        [NativeName("Name", "Cornsilk")]
        Cornsilk = 0xFFF8DC,
        [NativeName("Name", "Crimson")]
        Crimson = 0xDC143C,
        [NativeName("Name", "Cyan")]
        Cyan = 0xFFFF,
        [NativeName("Name", "DarkBlue")]
        DarkBlue = 0x8B,
        [NativeName("Name", "DarkCyan")]
        DarkCyan = 0x8B8B,
        [NativeName("Name", "DarkGoldenrod")]
        DarkGoldenrod = 0xB8860B,
        [NativeName("Name", "DarkGray")]
        DarkGray = 0xA9A9A9,
        [NativeName("Name", "DarkGreen")]
        DarkGreen = 0x6400,
        [NativeName("Name", "DarkKhaki")]
        DarkKhaki = 0xBDB76B,
        [NativeName("Name", "DarkMagenta")]
        DarkMagenta = 0x8B008B,
        [NativeName("Name", "DarkOliveGreen")]
        DarkOliveGreen = 0x556B2F,
        [NativeName("Name", "DarkOrange")]
        DarkOrange = 0xFF8C00,
        [NativeName("Name", "DarkOrchid")]
        DarkOrchid = 0x9932CC,
        [NativeName("Name", "DarkRed")]
        DarkRed = 0x8B0000,
        [NativeName("Name", "DarkSalmon")]
        DarkSalmon = 0xE9967A,
        [NativeName("Name", "DarkSeaGreen")]
        DarkSeaGreen = 0x8FBC8F,
        [NativeName("Name", "DarkSlateBlue")]
        DarkSlateBlue = 0x483D8B,
        [NativeName("Name", "DarkSlateGray")]
        DarkSlateGray = 0x2F4F4F,
        [NativeName("Name", "DarkTurquoise")]
        DarkTurquoise = 0xCED1,
        [NativeName("Name", "DarkViolet")]
        DarkViolet = 0x9400D3,
        [NativeName("Name", "DeepPink")]
        DeepPink = 0xFF1493,
        [NativeName("Name", "DeepSkyBlue")]
        DeepSkyBlue = 0xBFFF,
        [NativeName("Name", "DimGray")]
        DimGray = 0x696969,
        [NativeName("Name", "DodgerBlue")]
        DodgerBlue = 0x1E90FF,
        [NativeName("Name", "Firebrick")]
        Firebrick = 0xB22222,
        [NativeName("Name", "FloralWhite")]
        FloralWhite = 0xFFFAF0,
        [NativeName("Name", "ForestGreen")]
        ForestGreen = 0x228B22,
        [NativeName("Name", "Fuchsia")]
        Fuchsia = 0xFF00FF,
        [NativeName("Name", "Gainsboro")]
        Gainsboro = 0xDCDCDC,
        [NativeName("Name", "GhostWhite")]
        GhostWhite = 0xF8F8FF,
        [NativeName("Name", "Gold")]
        Gold = 0xFFD700,
        [NativeName("Name", "Goldenrod")]
        Goldenrod = 0xDAA520,
        [NativeName("Name", "Gray")]
        Gray = 0x808080,
        [NativeName("Name", "Green")]
        Green = 0x8000,
        [NativeName("Name", "GreenYellow")]
        GreenYellow = 0xADFF2F,
        [NativeName("Name", "Honeydew")]
        Honeydew = 0xF0FFF0,
        [NativeName("Name", "HotPink")]
        HotPink = 0xFF69B4,
        [NativeName("Name", "IndianRed")]
        IndianRed = 0xCD5C5C,
        [NativeName("Name", "Indigo")]
        Indigo = 0x4B0082,
        [NativeName("Name", "Ivory")]
        Ivory = 0xFFFFF0,
        [NativeName("Name", "Khaki")]
        Khaki = 0xF0E68C,
        [NativeName("Name", "Lavender")]
        Lavender = 0xE6E6FA,
        [NativeName("Name", "LavenderBlush")]
        LavenderBlush = 0xFFF0F5,
        [NativeName("Name", "LawnGreen")]
        LawnGreen = 0x7CFC00,
        [NativeName("Name", "LemonChiffon")]
        LemonChiffon = 0xFFFACD,
        [NativeName("Name", "LightBlue")]
        LightBlue = 0xADD8E6,
        [NativeName("Name", "LightCoral")]
        LightCoral = 0xF08080,
        [NativeName("Name", "LightCyan")]
        LightCyan = 0xE0FFFF,
        [NativeName("Name", "LightGoldenrodYellow")]
        LightGoldenrodYellow = 0xFAFAD2,
        [NativeName("Name", "LightGreen")]
        LightGreen = 0x90EE90,
        [NativeName("Name", "LightGray")]
        LightGray = 0xD3D3D3,
        [NativeName("Name", "LightPink")]
        LightPink = 0xFFB6C1,
        [NativeName("Name", "LightSalmon")]
        LightSalmon = 0xFFA07A,
        [NativeName("Name", "LightSeaGreen")]
        LightSeaGreen = 0x20B2AA,
        [NativeName("Name", "LightSkyBlue")]
        LightSkyBlue = 0x87CEFA,
        [NativeName("Name", "LightSlateGray")]
        LightSlateGray = 0x778899,
        [NativeName("Name", "LightSteelBlue")]
        LightSteelBlue = 0xB0C4DE,
        [NativeName("Name", "LightYellow")]
        LightYellow = 0xFFFFE0,
        [NativeName("Name", "Lime")]
        Lime = 0xFF00,
        [NativeName("Name", "LimeGreen")]
        LimeGreen = 0x32CD32,
        [NativeName("Name", "Linen")]
        Linen = 0xFAF0E6,
        [NativeName("Name", "Magenta")]
        Magenta = 0xFF00FF,
        [NativeName("Name", "Maroon")]
        Maroon = 0x800000,
        [NativeName("Name", "MediumAquamarine")]
        MediumAquamarine = 0x66CDAA,
        [NativeName("Name", "MediumBlue")]
        MediumBlue = 0xCD,
        [NativeName("Name", "MediumOrchid")]
        MediumOrchid = 0xBA55D3,
        [NativeName("Name", "MediumPurple")]
        MediumPurple = 0x9370DB,
        [NativeName("Name", "MediumSeaGreen")]
        MediumSeaGreen = 0x3CB371,
        [NativeName("Name", "MediumSlateBlue")]
        MediumSlateBlue = 0x7B68EE,
        [NativeName("Name", "MediumSpringGreen")]
        MediumSpringGreen = 0xFA9A,
        [NativeName("Name", "MediumTurquoise")]
        MediumTurquoise = 0x48D1CC,
        [NativeName("Name", "MediumVioletRed")]
        MediumVioletRed = 0xC71585,
        [NativeName("Name", "MidnightBlue")]
        MidnightBlue = 0x191970,
        [NativeName("Name", "MintCream")]
        MintCream = 0xF5FFFA,
        [NativeName("Name", "MistyRose")]
        MistyRose = 0xFFE4E1,
        [NativeName("Name", "Moccasin")]
        Moccasin = 0xFFE4B5,
        [NativeName("Name", "NavajoWhite")]
        NavajoWhite = 0xFFDEAD,
        [NativeName("Name", "Navy")]
        Navy = 0x80,
        [NativeName("Name", "OldLace")]
        OldLace = 0xFDF5E6,
        [NativeName("Name", "Olive")]
        Olive = 0x808000,
        [NativeName("Name", "OliveDrab")]
        OliveDrab = 0x6B8E23,
        [NativeName("Name", "Orange")]
        Orange = 0xFFA500,
        [NativeName("Name", "OrangeRed")]
        OrangeRed = 0xFF4500,
        [NativeName("Name", "Orchid")]
        Orchid = 0xDA70D6,
        [NativeName("Name", "PaleGoldenrod")]
        PaleGoldenrod = 0xEEE8AA,
        [NativeName("Name", "PaleGreen")]
        PaleGreen = 0x98FB98,
        [NativeName("Name", "PaleTurquoise")]
        PaleTurquoise = 0xAFEEEE,
        [NativeName("Name", "PaleVioletRed")]
        PaleVioletRed = 0xDB7093,
        [NativeName("Name", "PapayaWhip")]
        PapayaWhip = 0xFFEFD5,
        [NativeName("Name", "PeachPuff")]
        PeachPuff = 0xFFDAB9,
        [NativeName("Name", "Peru")]
        Peru = 0xCD853F,
        [NativeName("Name", "Pink")]
        Pink = 0xFFC0CB,
        [NativeName("Name", "Plum")]
        Plum = 0xDDA0DD,
        [NativeName("Name", "PowderBlue")]
        PowderBlue = 0xB0E0E6,
        [NativeName("Name", "Purple")]
        Purple = 0x800080,
        [NativeName("Name", "Red")]
        Red = 0xFF0000,
        [NativeName("Name", "RosyBrown")]
        RosyBrown = 0xBC8F8F,
        [NativeName("Name", "RoyalBlue")]
        RoyalBlue = 0x4169E1,
        [NativeName("Name", "SaddleBrown")]
        SaddleBrown = 0x8B4513,
        [NativeName("Name", "Salmon")]
        Salmon = 0xFA8072,
        [NativeName("Name", "SandyBrown")]
        SandyBrown = 0xF4A460,
        [NativeName("Name", "SeaGreen")]
        SeaGreen = 0x2E8B57,
        [NativeName("Name", "SeaShell")]
        SeaShell = 0xFFF5EE,
        [NativeName("Name", "Sienna")]
        Sienna = 0xA0522D,
        [NativeName("Name", "Silver")]
        Silver = 0xC0C0C0,
        [NativeName("Name", "SkyBlue")]
        SkyBlue = 0x87CEEB,
        [NativeName("Name", "SlateBlue")]
        SlateBlue = 0x6A5ACD,
        [NativeName("Name", "SlateGray")]
        SlateGray = 0x708090,
        [NativeName("Name", "Snow")]
        Snow = 0xFFFAFA,
        [NativeName("Name", "SpringGreen")]
        SpringGreen = 0xFF7F,
        [NativeName("Name", "SteelBlue")]
        SteelBlue = 0x4682B4,
        [NativeName("Name", "Tan")]
        Tan = 0xD2B48C,
        [NativeName("Name", "Teal")]
        Teal = 0x8080,
        [NativeName("Name", "Thistle")]
        Thistle = 0xD8BFD8,
        [NativeName("Name", "Tomato")]
        Tomato = 0xFF6347,
        [NativeName("Name", "Turquoise")]
        Turquoise = 0x40E0D0,
        [NativeName("Name", "Violet")]
        Violet = 0xEE82EE,
        [NativeName("Name", "Wheat")]
        Wheat = 0xF5DEB3,
        [NativeName("Name", "White")]
        White = 0xFFFFFF,
        [NativeName("Name", "WhiteSmoke")]
        WhiteSmoke = 0xF5F5F5,
        [NativeName("Name", "Yellow")]
        Yellow = 0xFFFF00,
        [NativeName("Name", "YellowGreen")]
        YellowGreen = 0x9ACD32,
    }
}
