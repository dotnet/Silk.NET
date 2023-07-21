// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ELEMENT
{
    [NativeTypeName("#define ELEMENT_STATUS_FULL 0x00000001")]
    public const int ELEMENT_STATUS_FULL = 0x00000001;

    [NativeTypeName("#define ELEMENT_STATUS_IMPEXP 0x00000002")]
    public const int ELEMENT_STATUS_IMPEXP = 0x00000002;

    [NativeTypeName("#define ELEMENT_STATUS_EXCEPT 0x00000004")]
    public const int ELEMENT_STATUS_EXCEPT = 0x00000004;

    [NativeTypeName("#define ELEMENT_STATUS_ACCESS 0x00000008")]
    public const int ELEMENT_STATUS_ACCESS = 0x00000008;

    [NativeTypeName("#define ELEMENT_STATUS_EXENAB 0x00000010")]
    public const int ELEMENT_STATUS_EXENAB = 0x00000010;

    [NativeTypeName("#define ELEMENT_STATUS_INENAB 0x00000020")]
    public const int ELEMENT_STATUS_INENAB = 0x00000020;

    [NativeTypeName("#define ELEMENT_STATUS_PRODUCT_DATA 0x00000040")]
    public const int ELEMENT_STATUS_PRODUCT_DATA = 0x00000040;

    [NativeTypeName("#define ELEMENT_STATUS_LUN_VALID 0x00001000")]
    public const int ELEMENT_STATUS_LUN_VALID = 0x00001000;

    [NativeTypeName("#define ELEMENT_STATUS_ID_VALID 0x00002000")]
    public const int ELEMENT_STATUS_ID_VALID = 0x00002000;

    [NativeTypeName("#define ELEMENT_STATUS_NOT_BUS 0x00008000")]
    public const int ELEMENT_STATUS_NOT_BUS = 0x00008000;

    [NativeTypeName("#define ELEMENT_STATUS_INVERT 0x00400000")]
    public const int ELEMENT_STATUS_INVERT = 0x00400000;

    [NativeTypeName("#define ELEMENT_STATUS_SVALID 0x00800000")]
    public const int ELEMENT_STATUS_SVALID = 0x00800000;

    [NativeTypeName("#define ELEMENT_STATUS_PVOLTAG 0x10000000")]
    public const int ELEMENT_STATUS_PVOLTAG = 0x10000000;

    [NativeTypeName("#define ELEMENT_STATUS_AVOLTAG 0x20000000")]
    public const int ELEMENT_STATUS_AVOLTAG = 0x20000000;
}
