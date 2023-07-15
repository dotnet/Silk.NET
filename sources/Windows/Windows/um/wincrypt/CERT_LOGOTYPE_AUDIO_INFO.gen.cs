// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_LOGOTYPE_AUDIO_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO_INFO"]/*'/>
public unsafe partial struct CERT_LOGOTYPE_AUDIO_INFO
{
    /// <include file='CERT_LOGOTYPE_AUDIO_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO_INFO.dwFileSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileSize;
    /// <include file='CERT_LOGOTYPE_AUDIO_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO_INFO.dwPlayTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPlayTime;
    /// <include file='CERT_LOGOTYPE_AUDIO_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO_INFO.dwChannels"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwChannels;
    /// <include file='CERT_LOGOTYPE_AUDIO_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO_INFO.dwSampleRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSampleRate;
    /// <include file='CERT_LOGOTYPE_AUDIO_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_AUDIO_INFO.pwszLanguage"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszLanguage;
}