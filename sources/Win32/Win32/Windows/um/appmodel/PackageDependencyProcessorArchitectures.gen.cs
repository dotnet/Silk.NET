// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.22621.0")]
public enum PackageDependencyProcessorArchitectures
{
    PackageDependencyProcessorArchitectures_None = 0,
    PackageDependencyProcessorArchitectures_Neutral = 0x00000001,
    PackageDependencyProcessorArchitectures_X86 = 0x00000002,
    PackageDependencyProcessorArchitectures_X64 = 0x00000004,
    PackageDependencyProcessorArchitectures_Arm = 0x00000008,
    PackageDependencyProcessorArchitectures_Arm64 = 0x00000010,
    PackageDependencyProcessorArchitectures_X86A64 = 0x00000020,
}
