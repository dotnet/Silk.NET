// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CC
{
    [NativeTypeName("#define CC_RGBINIT 0x00000001")]
    public const int CC_RGBINIT = 0x00000001;
    [NativeTypeName("#define CC_FULLOPEN 0x00000002")]
    public const int CC_FULLOPEN = 0x00000002;
    [NativeTypeName("#define CC_PREVENTFULLOPEN 0x00000004")]
    public const int CC_PREVENTFULLOPEN = 0x00000004;
    [NativeTypeName("#define CC_SHOWHELP 0x00000008")]
    public const int CC_SHOWHELP = 0x00000008;
    [NativeTypeName("#define CC_ENABLEHOOK 0x00000010")]
    public const int CC_ENABLEHOOK = 0x00000010;
    [NativeTypeName("#define CC_ENABLETEMPLATE 0x00000020")]
    public const int CC_ENABLETEMPLATE = 0x00000020;
    [NativeTypeName("#define CC_ENABLETEMPLATEHANDLE 0x00000040")]
    public const int CC_ENABLETEMPLATEHANDLE = 0x00000040;
    [NativeTypeName("#define CC_SOLIDCOLOR 0x00000080")]
    public const int CC_SOLIDCOLOR = 0x00000080;
    [NativeTypeName("#define CC_ANYCOLOR 0x00000100")]
    public const int CC_ANYCOLOR = 0x00000100;
}