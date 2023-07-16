// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='SYSTEM_RESOURCE_ATTRIBUTE_ACE.xml' path='doc/member[@name="SYSTEM_RESOURCE_ATTRIBUTE_ACE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct SYSTEM_RESOURCE_ATTRIBUTE_ACE
{
    /// <include file='SYSTEM_RESOURCE_ATTRIBUTE_ACE.xml' path='doc/member[@name="SYSTEM_RESOURCE_ATTRIBUTE_ACE.Header"]/*'/>
    public ACE_HEADER Header;
    /// <include file='SYSTEM_RESOURCE_ATTRIBUTE_ACE.xml' path='doc/member[@name="SYSTEM_RESOURCE_ATTRIBUTE_ACE.Mask"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint Mask;
    /// <include file='SYSTEM_RESOURCE_ATTRIBUTE_ACE.xml' path='doc/member[@name="SYSTEM_RESOURCE_ATTRIBUTE_ACE.SidStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SidStart;
}