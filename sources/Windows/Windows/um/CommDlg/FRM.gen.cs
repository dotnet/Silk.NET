// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FRM
{
    [NativeTypeName("#define FRM_FIRST (WM_USER + 100)")]
    public const int FRM_FIRST = (0x0400 + 100);
    [NativeTypeName("#define FRM_LAST (WM_USER + 200)")]
    public const int FRM_LAST = (0x0400 + 200);
    [NativeTypeName("#define FRM_SETOPERATIONRESULT (FRM_FIRST + 0x0000)")]
    public const int FRM_SETOPERATIONRESULT = ((0x0400 + 100) + 0x0000);
    [NativeTypeName("#define FRM_SETOPERATIONRESULTTEXT (FRM_FIRST + 0x0001)")]
    public const int FRM_SETOPERATIONRESULTTEXT = ((0x0400 + 100) + 0x0001);
}