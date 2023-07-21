// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NEGOTIATE_CALLER_NAME_RESPONSE.xml' path='doc/member[@name="NEGOTIATE_CALLER_NAME_RESPONSE"]/*' />
public unsafe partial struct NEGOTIATE_CALLER_NAME_RESPONSE
{
    /// <include file='NEGOTIATE_CALLER_NAME_RESPONSE.xml' path='doc/member[@name="NEGOTIATE_CALLER_NAME_RESPONSE.MessageType"]/*' />
    [NativeTypeName("ULONG")]
    public uint MessageType;

    /// <include file='NEGOTIATE_CALLER_NAME_RESPONSE.xml' path='doc/member[@name="NEGOTIATE_CALLER_NAME_RESPONSE.CallerName"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* CallerName;
}
