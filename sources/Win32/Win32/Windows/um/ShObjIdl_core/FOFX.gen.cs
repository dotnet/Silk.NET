// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FOFX
{
    [NativeTypeName("#define FOFX_NOSKIPJUNCTIONS 0x00010000")]
    public const int FOFX_NOSKIPJUNCTIONS = 0x00010000;

    [NativeTypeName("#define FOFX_PREFERHARDLINK 0x00020000")]
    public const int FOFX_PREFERHARDLINK = 0x00020000;

    [NativeTypeName("#define FOFX_SHOWELEVATIONPROMPT 0x00040000")]
    public const int FOFX_SHOWELEVATIONPROMPT = 0x00040000;

    [NativeTypeName("#define FOFX_RECYCLEONDELETE 0x00080000")]
    public const int FOFX_RECYCLEONDELETE = 0x00080000;

    [NativeTypeName("#define FOFX_EARLYFAILURE 0x00100000")]
    public const int FOFX_EARLYFAILURE = 0x00100000;

    [NativeTypeName("#define FOFX_PRESERVEFILEEXTENSIONS 0x00200000")]
    public const int FOFX_PRESERVEFILEEXTENSIONS = 0x00200000;

    [NativeTypeName("#define FOFX_KEEPNEWERFILE 0x00400000")]
    public const int FOFX_KEEPNEWERFILE = 0x00400000;

    [NativeTypeName("#define FOFX_NOCOPYHOOKS 0x00800000")]
    public const int FOFX_NOCOPYHOOKS = 0x00800000;

    [NativeTypeName("#define FOFX_NOMINIMIZEBOX 0x01000000")]
    public const int FOFX_NOMINIMIZEBOX = 0x01000000;

    [NativeTypeName("#define FOFX_MOVEACLSACROSSVOLUMES 0x02000000")]
    public const int FOFX_MOVEACLSACROSSVOLUMES = 0x02000000;

    [NativeTypeName("#define FOFX_DONTDISPLAYSOURCEPATH 0x04000000")]
    public const int FOFX_DONTDISPLAYSOURCEPATH = 0x04000000;

    [NativeTypeName("#define FOFX_DONTDISPLAYDESTPATH 0x08000000")]
    public const int FOFX_DONTDISPLAYDESTPATH = 0x08000000;

    [NativeTypeName("#define FOFX_REQUIREELEVATION 0x10000000")]
    public const int FOFX_REQUIREELEVATION = 0x10000000;

    [NativeTypeName("#define FOFX_ADDUNDORECORD 0x20000000")]
    public const int FOFX_ADDUNDORECORD = 0x20000000;

    [NativeTypeName("#define FOFX_COPYASDOWNLOAD 0x40000000")]
    public const int FOFX_COPYASDOWNLOAD = 0x40000000;

    [NativeTypeName("#define FOFX_DONTDISPLAYLOCATIONS 0x80000000")]
    public const uint FOFX_DONTDISPLAYLOCATIONS = 0x80000000;
}
