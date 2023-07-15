// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams2
{
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.ObjectFormat"]/*'/>
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.StaticObjectTypeMask"]/*'/>
    public AudioObjectType StaticObjectTypeMask;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.MinDynamicObjectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.MaxDynamicObjectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.Category"]/*'/>
    public AUDIO_STREAM_CATEGORY Category;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.EventHandle"]/*'/>
    public HANDLE EventHandle;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.MetadataFormatId"]/*'/>
    public Guid MetadataFormatId;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.MaxMetadataItemCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxMetadataItemCount;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.MetadataActivationParams"]/*'/>
    [NativeTypeName("const PROPVARIANT *")]
    public PROPVARIANT* MetadataActivationParams;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.NotifyObject"]/*'/>
    public ISpatialAudioObjectRenderStreamNotify* NotifyObject;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams2.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams2.Options"]/*'/>
    public SPATIAL_AUDIO_STREAM_OPTIONS Options;
}