// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SZ
{
    [NativeTypeName("#define SZ_THDOCPROP_DISPLAYNAME L\"DisplayName\"")]
    public const string SZ_THDOCPROP_DISPLAYNAME = "DisplayName";

    [NativeTypeName("#define SZ_THDOCPROP_CANONICALNAME L\"ThemeName\"")]
    public const string SZ_THDOCPROP_CANONICALNAME = "ThemeName";

    [NativeTypeName("#define SZ_THDOCPROP_TOOLTIP L\"ToolTip\"")]
    public const string SZ_THDOCPROP_TOOLTIP = "ToolTip";

    [NativeTypeName("#define SZ_THDOCPROP_AUTHOR L\"author\"")]
    public const string SZ_THDOCPROP_AUTHOR = "author";
}
