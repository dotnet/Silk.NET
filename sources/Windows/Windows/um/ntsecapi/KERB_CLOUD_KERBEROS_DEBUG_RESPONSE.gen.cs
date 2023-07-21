// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE"]/*' />
public unsafe partial struct KERB_CLOUD_KERBEROS_DEBUG_RESPONSE
{
    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.Data"]/*' />
    [NativeTypeName("ULONG[1]")]
    public fixed uint Data[1];
}
