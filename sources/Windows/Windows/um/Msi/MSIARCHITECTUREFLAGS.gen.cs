// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSIARCHITECTUREFLAGS.xml' path='doc/member[@name="MSIARCHITECTUREFLAGS"]/*'/>
public enum MSIARCHITECTUREFLAGS
{
    /// <include file='MSIARCHITECTUREFLAGS.xml' path='doc/member[@name="MSIARCHITECTUREFLAGS.MSIARCHITECTUREFLAGS_X86"]/*'/>
    MSIARCHITECTUREFLAGS_X86 = 0x00000001,
    /// <include file='MSIARCHITECTUREFLAGS.xml' path='doc/member[@name="MSIARCHITECTUREFLAGS.MSIARCHITECTUREFLAGS_IA64"]/*'/>
    MSIARCHITECTUREFLAGS_IA64 = 0x00000002,
    /// <include file='MSIARCHITECTUREFLAGS.xml' path='doc/member[@name="MSIARCHITECTUREFLAGS.MSIARCHITECTUREFLAGS_AMD64"]/*'/>
    MSIARCHITECTUREFLAGS_AMD64 = 0x00000004,
    /// <include file='MSIARCHITECTUREFLAGS.xml' path='doc/member[@name="MSIARCHITECTUREFLAGS.MSIARCHITECTUREFLAGS_ARM"]/*'/>
    MSIARCHITECTUREFLAGS_ARM = 0x00000008,
}