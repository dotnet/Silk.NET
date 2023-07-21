// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST"]/*' />
public unsafe partial struct MSV1_0_PASSTHROUGH_REQUEST
{
    /// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST.MessageType"]/*' />
    public MSV1_0_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST.DomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;

    /// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST.PackageName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING PackageName;

    /// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST.DataLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint DataLength;

    /// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST.LogonData"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* LogonData;

    /// <include file='MSV1_0_PASSTHROUGH_REQUEST.xml' path='doc/member[@name="MSV1_0_PASSTHROUGH_REQUEST.Pad"]/*' />
    [NativeTypeName("ULONG")]
    public uint Pad;
}
