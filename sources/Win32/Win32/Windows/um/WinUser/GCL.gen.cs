// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GCL
{
    [NativeTypeName("#define GCL_MENUNAME (-8)")]
    public const int GCL_MENUNAME = (-8);

    [NativeTypeName("#define GCL_HBRBACKGROUND (-10)")]
    public const int GCL_HBRBACKGROUND = (-10);

    [NativeTypeName("#define GCL_HCURSOR (-12)")]
    public const int GCL_HCURSOR = (-12);

    [NativeTypeName("#define GCL_HICON (-14)")]
    public const int GCL_HICON = (-14);

    [NativeTypeName("#define GCL_HMODULE (-16)")]
    public const int GCL_HMODULE = (-16);

    [NativeTypeName("#define GCL_CBWNDEXTRA (-18)")]
    public const int GCL_CBWNDEXTRA = (-18);

    [NativeTypeName("#define GCL_CBCLSEXTRA (-20)")]
    public const int GCL_CBCLSEXTRA = (-20);

    [NativeTypeName("#define GCL_WNDPROC (-24)")]
    public const int GCL_WNDPROC = (-24);

    [NativeTypeName("#define GCL_STYLE (-26)")]
    public const int GCL_STYLE = (-26);

    [NativeTypeName("#define GCL_HICONSM (-34)")]
    public const int GCL_HICONSM = (-34);
}
