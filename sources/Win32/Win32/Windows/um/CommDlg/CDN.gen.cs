// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CDN
{
    [NativeTypeName("#define CDN_FIRST (0U-601U)")]
    public const uint CDN_FIRST = unchecked(0U - 601U);

    [NativeTypeName("#define CDN_LAST (0U-699U)")]
    public const uint CDN_LAST = unchecked(0U - 699U);

    [NativeTypeName("#define CDN_INITDONE (CDN_FIRST - 0x0000)")]
    public const uint CDN_INITDONE = unchecked((0U - 601U) - 0x0000);

    [NativeTypeName("#define CDN_SELCHANGE (CDN_FIRST - 0x0001)")]
    public const uint CDN_SELCHANGE = unchecked((0U - 601U) - 0x0001);

    [NativeTypeName("#define CDN_FOLDERCHANGE (CDN_FIRST - 0x0002)")]
    public const uint CDN_FOLDERCHANGE = unchecked((0U - 601U) - 0x0002);

    [NativeTypeName("#define CDN_SHAREVIOLATION (CDN_FIRST - 0x0003)")]
    public const uint CDN_SHAREVIOLATION = unchecked((0U - 601U) - 0x0003);

    [NativeTypeName("#define CDN_HELP (CDN_FIRST - 0x0004)")]
    public const uint CDN_HELP = unchecked((0U - 601U) - 0x0004);

    [NativeTypeName("#define CDN_FILEOK (CDN_FIRST - 0x0005)")]
    public const uint CDN_FILEOK = unchecked((0U - 601U) - 0x0005);

    [NativeTypeName("#define CDN_TYPECHANGE (CDN_FIRST - 0x0006)")]
    public const uint CDN_TYPECHANGE = unchecked((0U - 601U) - 0x0006);

    [NativeTypeName("#define CDN_INCLUDEITEM (CDN_FIRST - 0x0007)")]
    public const uint CDN_INCLUDEITEM = unchecked((0U - 601U) - 0x0007);
}
