// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_S4U_LOGON.xml' path='doc/member[@name="MSV1_0_S4U_LOGON"]/*' />
public partial struct MSV1_0_S4U_LOGON
{
    /// <include file='MSV1_0_S4U_LOGON.xml' path='doc/member[@name="MSV1_0_S4U_LOGON.MessageType"]/*' />
    public MSV1_0_LOGON_SUBMIT_TYPE MessageType;

    /// <include file='MSV1_0_S4U_LOGON.xml' path='doc/member[@name="MSV1_0_S4U_LOGON.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='MSV1_0_S4U_LOGON.xml' path='doc/member[@name="MSV1_0_S4U_LOGON.UserPrincipalName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserPrincipalName;

    /// <include file='MSV1_0_S4U_LOGON.xml' path='doc/member[@name="MSV1_0_S4U_LOGON.DomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
}
