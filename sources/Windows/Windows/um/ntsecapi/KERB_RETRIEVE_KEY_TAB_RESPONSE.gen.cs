// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_RETRIEVE_KEY_TAB_RESPONSE.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_RESPONSE"]/*' />
public unsafe partial struct KERB_RETRIEVE_KEY_TAB_RESPONSE
{
    /// <include file='KERB_RETRIEVE_KEY_TAB_RESPONSE.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_RESPONSE.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_RETRIEVE_KEY_TAB_RESPONSE.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_RESPONSE.KeyTabLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint KeyTabLength;

    /// <include file='KERB_RETRIEVE_KEY_TAB_RESPONSE.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_RESPONSE.KeyTab"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* KeyTab;
}
