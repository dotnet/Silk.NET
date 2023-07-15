// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CB
{
    [NativeTypeName("#define CB_SETMINVISIBLE (CBM_FIRST + 1)")]
    public const int CB_SETMINVISIBLE = (0x1700 + 1);
    [NativeTypeName("#define CB_GETMINVISIBLE (CBM_FIRST + 2)")]
    public const int CB_GETMINVISIBLE = (0x1700 + 2);
    [NativeTypeName("#define CB_SETCUEBANNER (CBM_FIRST + 3)")]
    public const int CB_SETCUEBANNER = (0x1700 + 3);
    [NativeTypeName("#define CB_GETCUEBANNER (CBM_FIRST + 4)")]
    public const int CB_GETCUEBANNER = (0x1700 + 4);
}