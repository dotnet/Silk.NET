// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST"]/*'/>
public partial struct KERB_ADD_CREDENTIALS_REQUEST
{
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST.UserName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST.DomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST.Password"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Password;
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST.LogonId"]/*'/>
    public LUID LogonId;
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}