// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class RBBS
{
    [NativeTypeName("#define RBBS_BREAK 0x00000001")]
    public const int RBBS_BREAK = 0x00000001;

    [NativeTypeName("#define RBBS_FIXEDSIZE 0x00000002")]
    public const int RBBS_FIXEDSIZE = 0x00000002;

    [NativeTypeName("#define RBBS_CHILDEDGE 0x00000004")]
    public const int RBBS_CHILDEDGE = 0x00000004;

    [NativeTypeName("#define RBBS_HIDDEN 0x00000008")]
    public const int RBBS_HIDDEN = 0x00000008;

    [NativeTypeName("#define RBBS_NOVERT 0x00000010")]
    public const int RBBS_NOVERT = 0x00000010;

    [NativeTypeName("#define RBBS_FIXEDBMP 0x00000020")]
    public const int RBBS_FIXEDBMP = 0x00000020;

    [NativeTypeName("#define RBBS_VARIABLEHEIGHT 0x00000040")]
    public const int RBBS_VARIABLEHEIGHT = 0x00000040;

    [NativeTypeName("#define RBBS_GRIPPERALWAYS 0x00000080")]
    public const int RBBS_GRIPPERALWAYS = 0x00000080;

    [NativeTypeName("#define RBBS_NOGRIPPER 0x00000100")]
    public const int RBBS_NOGRIPPER = 0x00000100;

    [NativeTypeName("#define RBBS_USECHEVRON 0x00000200")]
    public const int RBBS_USECHEVRON = 0x00000200;

    [NativeTypeName("#define RBBS_HIDETITLE 0x00000400")]
    public const int RBBS_HIDETITLE = 0x00000400;

    [NativeTypeName("#define RBBS_TOPALIGN 0x00000800")]
    public const int RBBS_TOPALIGN = 0x00000800;
}
