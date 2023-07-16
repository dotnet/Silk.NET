// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA"]/*'/>
public unsafe partial struct AUDIO_VOLUME_NOTIFICATION_DATA
{
    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.guidEventContext"]/*'/>
    public Guid guidEventContext;
    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.bMuted"]/*'/>
    public BOOL bMuted;
    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.fMasterVolume"]/*'/>
    public float fMasterVolume;
    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.nChannels"]/*'/>
    public uint nChannels;
    /// <include file='AUDIO_VOLUME_NOTIFICATION_DATA.xml' path='doc/member[@name="AUDIO_VOLUME_NOTIFICATION_DATA.afChannelVolumes"]/*'/>
    [NativeTypeName("float[1]")]
    public fixed float afChannelVolumes[1];
}