// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE
{
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE.Version"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Version;

    /// <include file='CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE.Name"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* Name;
}
