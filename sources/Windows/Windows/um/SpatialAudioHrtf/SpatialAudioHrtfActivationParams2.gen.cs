// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioHrtfActivationParams2
{
    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.ObjectFormat"]/*' />
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.StaticObjectTypeMask"]/*' />
    public AudioObjectType StaticObjectTypeMask;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.MinDynamicObjectCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.MaxDynamicObjectCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.Category"]/*' />
    public AUDIO_STREAM_CATEGORY Category;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.EventHandle"]/*' />
    public HANDLE EventHandle;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.NotifyObject"]/*' />
    public ISpatialAudioObjectRenderStreamNotify* NotifyObject;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.DistanceDecay"]/*' />
    public SpatialAudioHrtfDistanceDecay* DistanceDecay;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.Directivity"]/*' />
    public SpatialAudioHrtfDirectivityUnion* Directivity;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.Environment"]/*' />
    public SpatialAudioHrtfEnvironmentType* Environment;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.Orientation"]/*' />
    [NativeTypeName("SpatialAudioHrtfOrientation *")]
    public float* Orientation;

    /// <include file='SpatialAudioHrtfActivationParams2.xml' path='doc/member[@name="SpatialAudioHrtfActivationParams2.Options"]/*' />
    public SPATIAL_AUDIO_STREAM_OPTIONS Options;
}
