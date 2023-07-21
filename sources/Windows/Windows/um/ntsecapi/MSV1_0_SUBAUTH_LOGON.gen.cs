// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON"]/*' />
public unsafe partial struct MSV1_0_SUBAUTH_LOGON
{
    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.MessageType"]/*' />
    public MSV1_0_LOGON_SUBMIT_TYPE MessageType;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.LogonDomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.UserName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.Workstation"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Workstation;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.ChallengeToClient"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public fixed byte ChallengeToClient[8];

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.AuthenticationInfo1"]/*' />
    [NativeTypeName("STRING")]
    public LSA_STRING AuthenticationInfo1;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.AuthenticationInfo2"]/*' />
    [NativeTypeName("STRING")]
    public LSA_STRING AuthenticationInfo2;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.ParameterControl"]/*' />
    [NativeTypeName("ULONG")]
    public uint ParameterControl;

    /// <include file='MSV1_0_SUBAUTH_LOGON.xml' path='doc/member[@name="MSV1_0_SUBAUTH_LOGON.SubAuthPackageId"]/*' />
    [NativeTypeName("ULONG")]
    public uint SubAuthPackageId;
}
