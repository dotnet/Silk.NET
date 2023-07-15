// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WM
{
    [NativeTypeName("#define WM_CPL_LAUNCH (WM_USER+1000)")]
    public const int WM_CPL_LAUNCH = (0x0400 + 1000);
    [NativeTypeName("#define WM_CPL_LAUNCHED (WM_USER+1001)")]
    public const int WM_CPL_LAUNCHED = (0x0400 + 1001);
}