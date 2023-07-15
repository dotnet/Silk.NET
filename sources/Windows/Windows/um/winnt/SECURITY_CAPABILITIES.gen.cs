// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='SECURITY_CAPABILITIES.xml' path='doc/member[@name="SECURITY_CAPABILITIES"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct SECURITY_CAPABILITIES
{
    /// <include file='SECURITY_CAPABILITIES.xml' path='doc/member[@name="SECURITY_CAPABILITIES.AppContainerSid"]/*'/>
    [NativeTypeName("PSID")]
    public void* AppContainerSid;
    /// <include file='SECURITY_CAPABILITIES.xml' path='doc/member[@name="SECURITY_CAPABILITIES.Capabilities"]/*'/>
    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* Capabilities;
    /// <include file='SECURITY_CAPABILITIES.xml' path='doc/member[@name="SECURITY_CAPABILITIES.CapabilityCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CapabilityCount;
    /// <include file='SECURITY_CAPABILITIES.xml' path='doc/member[@name="SECURITY_CAPABILITIES.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}