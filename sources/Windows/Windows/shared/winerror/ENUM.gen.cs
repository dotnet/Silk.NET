// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ENUM
{
    [NativeTypeName("#define ENUM_E_FIRST 0x800401B0L")]
    public const uint ENUM_E_FIRST = 0x800401B0;
    [NativeTypeName("#define ENUM_E_LAST 0x800401BFL")]
    public const uint ENUM_E_LAST = 0x800401BF;
    [NativeTypeName("#define ENUM_S_FIRST 0x000401B0L")]
    public const int ENUM_S_FIRST = 0x000401B0;
    [NativeTypeName("#define ENUM_S_LAST 0x000401BFL")]
    public const int ENUM_S_LAST = 0x000401BF;
}