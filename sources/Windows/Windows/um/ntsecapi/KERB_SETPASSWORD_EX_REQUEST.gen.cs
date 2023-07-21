// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST"]/*' />
public partial struct KERB_SETPASSWORD_EX_REQUEST
{
    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.LogonId"]/*' />
    public LUID LogonId;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.CredentialsHandle"]/*' />
    public SecHandle CredentialsHandle;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.AccountRealm"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING AccountRealm;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.AccountName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING AccountName;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.Password"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Password;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.ClientRealm"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientRealm;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.ClientName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientName;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.Impersonating"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Impersonating;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.KdcAddress"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING KdcAddress;

    /// <include file='KERB_SETPASSWORD_EX_REQUEST.xml' path='doc/member[@name="KERB_SETPASSWORD_EX_REQUEST.KdcAddressType"]/*' />
    [NativeTypeName("ULONG")]
    public uint KdcAddressType;
}
