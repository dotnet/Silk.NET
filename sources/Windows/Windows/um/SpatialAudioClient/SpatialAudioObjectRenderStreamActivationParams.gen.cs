// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioObjectRenderStreamActivationParams
{
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.ObjectFormat"]/*'/>
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.StaticObjectTypeMask"]/*'/>
    public AudioObjectType StaticObjectTypeMask;
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.MinDynamicObjectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.MaxDynamicObjectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.Category"]/*'/>
    public AUDIO_STREAM_CATEGORY Category;
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.EventHandle"]/*'/>
    public HANDLE EventHandle;
    /// <include file='SpatialAudioObjectRenderStreamActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamActivationParams.NotifyObject"]/*'/>
    public ISpatialAudioObjectRenderStreamNotify* NotifyObject;
}