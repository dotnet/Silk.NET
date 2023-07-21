// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioObjectRenderStreamActivationParams2
{
    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.ObjectFormat"]/*' />
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.StaticObjectTypeMask"]/*' />
    public AudioObjectType StaticObjectTypeMask;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.MinDynamicObjectCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.MaxDynamicObjectCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.Category"]/*' />
    public AUDIO_STREAM_CATEGORY Category;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.EventHandle"]/*' />
    public HANDLE EventHandle;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.NotifyObject"]/*' />
    public ISpatialAudioObjectRenderStreamNotify* NotifyObject;

    /// <include file='SpatialAudioObjectRenderStreamActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams2.Options"]/*' />
    public SPATIAL_AUDIO_STREAM_OPTIONS Options;
}
