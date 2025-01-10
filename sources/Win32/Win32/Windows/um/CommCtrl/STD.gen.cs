// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class STD
{
    [NativeTypeName("#define STD_CUT 0")]
    public const int STD_CUT = 0;

    [NativeTypeName("#define STD_COPY 1")]
    public const int STD_COPY = 1;

    [NativeTypeName("#define STD_PASTE 2")]
    public const int STD_PASTE = 2;

    [NativeTypeName("#define STD_UNDO 3")]
    public const int STD_UNDO = 3;

    [NativeTypeName("#define STD_REDOW 4")]
    public const int STD_REDOW = 4;

    [NativeTypeName("#define STD_DELETE 5")]
    public const int STD_DELETE = 5;

    [NativeTypeName("#define STD_FILENEW 6")]
    public const int STD_FILENEW = 6;

    [NativeTypeName("#define STD_FILEOPEN 7")]
    public const int STD_FILEOPEN = 7;

    [NativeTypeName("#define STD_FILESAVE 8")]
    public const int STD_FILESAVE = 8;

    [NativeTypeName("#define STD_PRINTPRE 9")]
    public const int STD_PRINTPRE = 9;

    [NativeTypeName("#define STD_PROPERTIES 10")]
    public const int STD_PROPERTIES = 10;

    [NativeTypeName("#define STD_HELP 11")]
    public const int STD_HELP = 11;

    [NativeTypeName("#define STD_FIND 12")]
    public const int STD_FIND = 12;

    [NativeTypeName("#define STD_REPLACE 13")]
    public const int STD_REPLACE = 13;

    [NativeTypeName("#define STD_PRINT 14")]
    public const int STD_PRINT = 14;
}
