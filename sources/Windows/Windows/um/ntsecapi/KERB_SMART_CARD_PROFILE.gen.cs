// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_SMART_CARD_PROFILE.xml' path='doc/member[@name="KERB_SMART_CARD_PROFILE"]/*'/>
public unsafe partial struct KERB_SMART_CARD_PROFILE
{
    /// <include file='KERB_SMART_CARD_PROFILE.xml' path='doc/member[@name="KERB_SMART_CARD_PROFILE.Profile"]/*'/>
    public KERB_INTERACTIVE_PROFILE Profile;
    /// <include file='KERB_SMART_CARD_PROFILE.xml' path='doc/member[@name="KERB_SMART_CARD_PROFILE.CertificateSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CertificateSize;
    /// <include file='KERB_SMART_CARD_PROFILE.xml' path='doc/member[@name="KERB_SMART_CARD_PROFILE.CertificateData"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* CertificateData;
}