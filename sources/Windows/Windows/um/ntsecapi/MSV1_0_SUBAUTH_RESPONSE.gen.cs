// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_SUBAUTH_RESPONSE.xml' path='doc/member[@name="MSV1_0_SUBAUTH_RESPONSE"]/*' />
public unsafe partial struct MSV1_0_SUBAUTH_RESPONSE
{
    /// <include file='MSV1_0_SUBAUTH_RESPONSE.xml' path='doc/member[@name="MSV1_0_SUBAUTH_RESPONSE.MessageType"]/*' />
    public MSV1_0_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='MSV1_0_SUBAUTH_RESPONSE.xml' path='doc/member[@name="MSV1_0_SUBAUTH_RESPONSE.SubAuthInfoLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint SubAuthInfoLength;

    /// <include file='MSV1_0_SUBAUTH_RESPONSE.xml' path='doc/member[@name="MSV1_0_SUBAUTH_RESPONSE.SubAuthReturnBuffer"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* SubAuthReturnBuffer;
}
