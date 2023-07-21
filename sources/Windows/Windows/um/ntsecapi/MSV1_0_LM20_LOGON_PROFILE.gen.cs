// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE"]/*' />
public unsafe partial struct MSV1_0_LM20_LOGON_PROFILE
{
    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.MessageType"]/*' />
    public MSV1_0_PROFILE_BUFFER_TYPE MessageType;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.KickOffTime"]/*' />
    public LARGE_INTEGER KickOffTime;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LogoffTime"]/*' />
    public LARGE_INTEGER LogoffTime;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.UserFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint UserFlags;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.UserSessionKey"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public fixed byte UserSessionKey[16];

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LogonDomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LanmanSessionKey"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public fixed byte LanmanSessionKey[8];

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.LogonServer"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonServer;

    /// <include file='MSV1_0_LM20_LOGON_PROFILE.xml' path='doc/member[@name="MSV1_0_LM20_LOGON_PROFILE.UserParameters"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserParameters;
}
