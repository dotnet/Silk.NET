// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define PERCEIVEDFLAG_UNDEFINED 0x0000")]
    public const int PERCEIVEDFLAG_UNDEFINED = 0x0000;

    [NativeTypeName("#define PERCEIVEDFLAG_SOFTCODED 0x0001")]
    public const int PERCEIVEDFLAG_SOFTCODED = 0x0001;

    [NativeTypeName("#define PERCEIVEDFLAG_HARDCODED 0x0002")]
    public const int PERCEIVEDFLAG_HARDCODED = 0x0002;

    [NativeTypeName("#define PERCEIVEDFLAG_NATIVESUPPORT 0x0004")]
    public const int PERCEIVEDFLAG_NATIVESUPPORT = 0x0004;

    [NativeTypeName("#define PERCEIVEDFLAG_GDIPLUS 0x0010")]
    public const int PERCEIVEDFLAG_GDIPLUS = 0x0010;

    [NativeTypeName("#define PERCEIVEDFLAG_WMSDK 0x0020")]
    public const int PERCEIVEDFLAG_WMSDK = 0x0020;

    [NativeTypeName("#define PERCEIVEDFLAG_ZIPFOLDER 0x0040")]
    public const int PERCEIVEDFLAG_ZIPFOLDER = 0x0040;
}
