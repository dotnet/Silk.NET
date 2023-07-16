// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_SMART_CARD_LOGON.xml' path='doc/member[@name="KERB_SMART_CARD_LOGON"]/*'/>
public unsafe partial struct KERB_SMART_CARD_LOGON
{
    /// <include file='KERB_SMART_CARD_LOGON.xml' path='doc/member[@name="KERB_SMART_CARD_LOGON.MessageType"]/*'/>
    public KERB_LOGON_SUBMIT_TYPE MessageType;
    /// <include file='KERB_SMART_CARD_LOGON.xml' path='doc/member[@name="KERB_SMART_CARD_LOGON.Pin"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Pin;
    /// <include file='KERB_SMART_CARD_LOGON.xml' path='doc/member[@name="KERB_SMART_CARD_LOGON.CspDataLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CspDataLength;
    /// <include file='KERB_SMART_CARD_LOGON.xml' path='doc/member[@name="KERB_SMART_CARD_LOGON.CspData"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* CspData;
}