// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.xml' path='doc/member[@name="KERB_ADD_BINDING_CACHE_ENTRY_REQUEST"]/*' />
public partial struct KERB_ADD_BINDING_CACHE_ENTRY_REQUEST
{
    /// <include file='KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.xml' path='doc/member[@name="KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.xml' path='doc/member[@name="KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.RealmName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING RealmName;

    /// <include file='KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.xml' path='doc/member[@name="KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.KdcAddress"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING KdcAddress;

    /// <include file='KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.xml' path='doc/member[@name="KERB_ADD_BINDING_CACHE_ENTRY_REQUEST.AddressType"]/*' />
    [NativeTypeName("ULONG")]
    public uint AddressType;
}
