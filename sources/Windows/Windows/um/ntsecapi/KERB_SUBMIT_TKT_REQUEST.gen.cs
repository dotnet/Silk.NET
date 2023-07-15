// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST"]/*'/>
public partial struct KERB_SUBMIT_TKT_REQUEST
{
    /// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST.LogonId"]/*'/>
    public LUID LogonId;
    /// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST.Key"]/*'/>
    public KERB_CRYPTO_KEY32 Key;
    /// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST.KerbCredSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint KerbCredSize;
    /// <include file='KERB_SUBMIT_TKT_REQUEST.xml' path='doc/member[@name="KERB_SUBMIT_TKT_REQUEST.KerbCredOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint KerbCredOffset;
}