// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_RETRIEVE_KEY_TAB_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_REQUEST"]/*'/>
public partial struct KERB_RETRIEVE_KEY_TAB_REQUEST
{
    /// <include file='KERB_RETRIEVE_KEY_TAB_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_RETRIEVE_KEY_TAB_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_REQUEST.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_RETRIEVE_KEY_TAB_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_REQUEST.UserName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;
    /// <include file='KERB_RETRIEVE_KEY_TAB_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_REQUEST.DomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
    /// <include file='KERB_RETRIEVE_KEY_TAB_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_KEY_TAB_REQUEST.Password"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Password;
}