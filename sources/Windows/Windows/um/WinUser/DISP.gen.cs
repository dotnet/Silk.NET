// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class DISP
{
    [NativeTypeName("#define DISP_CHANGE_SUCCESSFUL 0")]
    public const int DISP_CHANGE_SUCCESSFUL = 0;
    [NativeTypeName("#define DISP_CHANGE_RESTART 1")]
    public const int DISP_CHANGE_RESTART = 1;
    [NativeTypeName("#define DISP_CHANGE_FAILED -1")]
    public const int DISP_CHANGE_FAILED = -1;
    [NativeTypeName("#define DISP_CHANGE_BADMODE -2")]
    public const int DISP_CHANGE_BADMODE = -2;
    [NativeTypeName("#define DISP_CHANGE_NOTUPDATED -3")]
    public const int DISP_CHANGE_NOTUPDATED = -3;
    [NativeTypeName("#define DISP_CHANGE_BADFLAGS -4")]
    public const int DISP_CHANGE_BADFLAGS = -4;
    [NativeTypeName("#define DISP_CHANGE_BADPARAM -5")]
    public const int DISP_CHANGE_BADPARAM = -5;
    [NativeTypeName("#define DISP_CHANGE_BADDUALVIEW -6")]
    public const int DISP_CHANGE_BADDUALVIEW = -6;
}