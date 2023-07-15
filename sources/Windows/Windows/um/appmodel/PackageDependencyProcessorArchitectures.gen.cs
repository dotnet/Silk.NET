// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures"]/*'/>
[SupportedOSPlatform("windows10.0.22621.0")]
public enum PackageDependencyProcessorArchitectures
{
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_None"]/*'/>
    PackageDependencyProcessorArchitectures_None = 0,
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_Neutral"]/*'/>
    PackageDependencyProcessorArchitectures_Neutral = 0x00000001,
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_X86"]/*'/>
    PackageDependencyProcessorArchitectures_X86 = 0x00000002,
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_X64"]/*'/>
    PackageDependencyProcessorArchitectures_X64 = 0x00000004,
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_Arm"]/*'/>
    PackageDependencyProcessorArchitectures_Arm = 0x00000008,
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_Arm64"]/*'/>
    PackageDependencyProcessorArchitectures_Arm64 = 0x00000010,
    /// <include file='PackageDependencyProcessorArchitectures.xml' path='doc/member[@name="PackageDependencyProcessorArchitectures.PackageDependencyProcessorArchitectures_X86A64"]/*'/>
    PackageDependencyProcessorArchitectures_X86A64 = 0x00000020,
}