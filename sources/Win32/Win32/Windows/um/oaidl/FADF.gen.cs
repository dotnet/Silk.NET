// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FADF
{
    [NativeTypeName("#define FADF_AUTO ( 0x1 )")]
    public const int FADF_AUTO = (0x1);

    [NativeTypeName("#define FADF_STATIC ( 0x2 )")]
    public const int FADF_STATIC = (0x2);

    [NativeTypeName("#define FADF_EMBEDDED ( 0x4 )")]
    public const int FADF_EMBEDDED = (0x4);

    [NativeTypeName("#define FADF_FIXEDSIZE ( 0x10 )")]
    public const int FADF_FIXEDSIZE = (0x10);

    [NativeTypeName("#define FADF_RECORD ( 0x20 )")]
    public const int FADF_RECORD = (0x20);

    [NativeTypeName("#define FADF_HAVEIID ( 0x40 )")]
    public const int FADF_HAVEIID = (0x40);

    [NativeTypeName("#define FADF_HAVEVARTYPE ( 0x80 )")]
    public const int FADF_HAVEVARTYPE = (0x80);

    [NativeTypeName("#define FADF_BSTR ( 0x100 )")]
    public const int FADF_BSTR = (0x100);

    [NativeTypeName("#define FADF_UNKNOWN ( 0x200 )")]
    public const int FADF_UNKNOWN = (0x200);

    [NativeTypeName("#define FADF_DISPATCH ( 0x400 )")]
    public const int FADF_DISPATCH = (0x400);

    [NativeTypeName("#define FADF_VARIANT ( 0x800 )")]
    public const int FADF_VARIANT = (0x800);

    [NativeTypeName("#define FADF_RESERVED ( 0xf008 )")]
    public const int FADF_RESERVED = (0xf008);
}
