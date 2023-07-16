// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_LOGOTYPE_AUDIO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO"]/*'/>
public unsafe partial struct CERT_LOGOTYPE_AUDIO
{
    /// <include file='CERT_LOGOTYPE_AUDIO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO.LogotypeDetails"]/*'/>
    public CERT_LOGOTYPE_DETAILS LogotypeDetails;
    /// <include file='CERT_LOGOTYPE_AUDIO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO.pLogotypeAudioInfo"]/*'/>
    [NativeTypeName("PCERT_LOGOTYPE_AUDIO_INFO")]
    public CERT_LOGOTYPE_AUDIO_INFO* pLogotypeAudioInfo;
}