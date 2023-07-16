// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MEM_ADDRESS_REQUIREMENTS.xml' path='doc/member[@name="MEM_ADDRESS_REQUIREMENTS"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct MEM_ADDRESS_REQUIREMENTS
{
    /// <include file='MEM_ADDRESS_REQUIREMENTS.xml' path='doc/member[@name="MEM_ADDRESS_REQUIREMENTS.LowestStartingAddress"]/*'/>
    [NativeTypeName("PVOID")]
    public void* LowestStartingAddress;
    /// <include file='MEM_ADDRESS_REQUIREMENTS.xml' path='doc/member[@name="MEM_ADDRESS_REQUIREMENTS.HighestEndingAddress"]/*'/>
    [NativeTypeName("PVOID")]
    public void* HighestEndingAddress;
    /// <include file='MEM_ADDRESS_REQUIREMENTS.xml' path='doc/member[@name="MEM_ADDRESS_REQUIREMENTS.Alignment"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint Alignment;
}