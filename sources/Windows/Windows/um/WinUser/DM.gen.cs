// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class DM
{
    [NativeTypeName("#define DM_POINTERHITTEST 0x0250")]
    public const int DM_POINTERHITTEST = 0x0250;
    [NativeTypeName("#define DM_GETDEFID (WM_USER+0)")]
    public const int DM_GETDEFID = (0x0400 + 0);
    [NativeTypeName("#define DM_SETDEFID (WM_USER+1)")]
    public const int DM_SETDEFID = (0x0400 + 1);
    [NativeTypeName("#define DM_REPOSITION (WM_USER+2)")]
    public const int DM_REPOSITION = (0x0400 + 2);
}