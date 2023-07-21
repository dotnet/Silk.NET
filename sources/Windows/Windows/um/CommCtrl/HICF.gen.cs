// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class HICF
{
    [NativeTypeName("#define HICF_OTHER 0x00000000")]
    public const int HICF_OTHER = 0x00000000;

    [NativeTypeName("#define HICF_MOUSE 0x00000001")]
    public const int HICF_MOUSE = 0x00000001;

    [NativeTypeName("#define HICF_ARROWKEYS 0x00000002")]
    public const int HICF_ARROWKEYS = 0x00000002;

    [NativeTypeName("#define HICF_ACCELERATOR 0x00000004")]
    public const int HICF_ACCELERATOR = 0x00000004;

    [NativeTypeName("#define HICF_DUPACCEL 0x00000008")]
    public const int HICF_DUPACCEL = 0x00000008;

    [NativeTypeName("#define HICF_ENTERING 0x00000010")]
    public const int HICF_ENTERING = 0x00000010;

    [NativeTypeName("#define HICF_LEAVING 0x00000020")]
    public const int HICF_LEAVING = 0x00000020;

    [NativeTypeName("#define HICF_RESELECT 0x00000040")]
    public const int HICF_RESELECT = 0x00000040;

    [NativeTypeName("#define HICF_LMOUSE 0x00000080")]
    public const int HICF_LMOUSE = 0x00000080;

    [NativeTypeName("#define HICF_TOGGLEDROPDOWN 0x00000100")]
    public const int HICF_TOGGLEDROPDOWN = 0x00000100;
}
