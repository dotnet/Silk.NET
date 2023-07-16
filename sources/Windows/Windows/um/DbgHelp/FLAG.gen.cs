// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FLAG
{
    [NativeTypeName("#define FLAG_ENGINE_PRESENT 0x4")]
    public const int FLAG_ENGINE_PRESENT = 0x4;
    [NativeTypeName("#define FLAG_ENGOPT_DISALLOW_NETWORK_PATHS 0x8")]
    public const int FLAG_ENGOPT_DISALLOW_NETWORK_PATHS = 0x8;
    [NativeTypeName("#define FLAG_OVERRIDE_ARM_MACHINE_TYPE 0x10")]
    public const int FLAG_OVERRIDE_ARM_MACHINE_TYPE = 0x10;
}