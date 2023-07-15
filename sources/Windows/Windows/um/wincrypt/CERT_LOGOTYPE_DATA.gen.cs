// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_LOGOTYPE_DATA.xml' path='doc/member[@name="CERT_LOGOTYPE_DATA"]/*'/>
public unsafe partial struct CERT_LOGOTYPE_DATA
{
    /// <include file='CERT_LOGOTYPE_DATA.xml' path='doc/member[@name="CERT_LOGOTYPE_DATA.cLogotypeImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cLogotypeImage;
    /// <include file='CERT_LOGOTYPE_DATA.xml' path='doc/member[@name="CERT_LOGOTYPE_DATA.rgLogotypeImage"]/*'/>
    [NativeTypeName("PCERT_LOGOTYPE_IMAGE")]
    public CERT_LOGOTYPE_IMAGE* rgLogotypeImage;
    /// <include file='CERT_LOGOTYPE_DATA.xml' path='doc/member[@name="CERT_LOGOTYPE_DATA.cLogotypeAudio"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cLogotypeAudio;
    /// <include file='CERT_LOGOTYPE_DATA.xml' path='doc/member[@name="CERT_LOGOTYPE_DATA.rgLogotypeAudio"]/*'/>
    [NativeTypeName("PCERT_LOGOTYPE_AUDIO")]
    public CERT_LOGOTYPE_AUDIO* rgLogotypeAudio;
}