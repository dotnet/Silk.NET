// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class LWA
{
    [NativeTypeName("#define LWA_COLORKEY 0x00000001")]
    public const int LWA_COLORKEY = 0x00000001;
    [NativeTypeName("#define LWA_ALPHA 0x00000002")]
    public const int LWA_ALPHA = 0x00000002;
}