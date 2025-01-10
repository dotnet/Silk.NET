// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MSIARCHITECTUREFLAGS
{
    MSIARCHITECTUREFLAGS_X86 = 0x00000001,
    MSIARCHITECTUREFLAGS_IA64 = 0x00000002,
    MSIARCHITECTUREFLAGS_AMD64 = 0x00000004,
    MSIARCHITECTUREFLAGS_ARM = 0x00000008,
}
