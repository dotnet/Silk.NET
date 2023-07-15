// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ES
{
    [NativeTypeName("#define ES_SYSTEM_REQUIRED ((DWORD)0x00000001)")]
    public const uint ES_SYSTEM_REQUIRED = ((uint)(0x00000001));
    [NativeTypeName("#define ES_DISPLAY_REQUIRED ((DWORD)0x00000002)")]
    public const uint ES_DISPLAY_REQUIRED = ((uint)(0x00000002));
    [NativeTypeName("#define ES_USER_PRESENT ((DWORD)0x00000004)")]
    public const uint ES_USER_PRESENT = ((uint)(0x00000004));
    [NativeTypeName("#define ES_AWAYMODE_REQUIRED ((DWORD)0x00000040)")]
    public const uint ES_AWAYMODE_REQUIRED = ((uint)(0x00000040));
    [NativeTypeName("#define ES_CONTINUOUS ((DWORD)0x80000000)")]
    public const uint ES_CONTINUOUS = ((uint)(0x80000000));
}