// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SHGSI
{
    [NativeTypeName("#define SHGSI_ICONLOCATION 0")]
    public const int SHGSI_ICONLOCATION = 0;

    [NativeTypeName("#define SHGSI_ICON SHGFI_ICON")]
    public const int SHGSI_ICON = 0x000000100;

    [NativeTypeName("#define SHGSI_SYSICONINDEX SHGFI_SYSICONINDEX")]
    public const int SHGSI_SYSICONINDEX = 0x000004000;

    [NativeTypeName("#define SHGSI_LINKOVERLAY SHGFI_LINKOVERLAY")]
    public const int SHGSI_LINKOVERLAY = 0x000008000;

    [NativeTypeName("#define SHGSI_SELECTED SHGFI_SELECTED")]
    public const int SHGSI_SELECTED = 0x000010000;

    [NativeTypeName("#define SHGSI_LARGEICON SHGFI_LARGEICON")]
    public const int SHGSI_LARGEICON = 0x000000000;

    [NativeTypeName("#define SHGSI_SMALLICON SHGFI_SMALLICON")]
    public const int SHGSI_SMALLICON = 0x000000001;

    [NativeTypeName("#define SHGSI_SHELLICONSIZE SHGFI_SHELLICONSIZE")]
    public const int SHGSI_SHELLICONSIZE = 0x000000004;
}
