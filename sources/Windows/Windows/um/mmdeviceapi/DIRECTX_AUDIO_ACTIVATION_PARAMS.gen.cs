// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='DIRECTX_AUDIO_ACTIVATION_PARAMS.xml' path='doc/member[@name="DIRECTX_AUDIO_ACTIVATION_PARAMS"]/*'/>
public partial struct DIRECTX_AUDIO_ACTIVATION_PARAMS
{
    /// <include file='DIRECTX_AUDIO_ACTIVATION_PARAMS.xml' path='doc/member[@name="DIRECTX_AUDIO_ACTIVATION_PARAMS.cbDirectXAudioActivationParams"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbDirectXAudioActivationParams;
    /// <include file='DIRECTX_AUDIO_ACTIVATION_PARAMS.xml' path='doc/member[@name="DIRECTX_AUDIO_ACTIVATION_PARAMS.guidAudioSession"]/*'/>
    public Guid guidAudioSession;
    /// <include file='DIRECTX_AUDIO_ACTIVATION_PARAMS.xml' path='doc/member[@name="DIRECTX_AUDIO_ACTIVATION_PARAMS.dwAudioStreamFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAudioStreamFlags;
}