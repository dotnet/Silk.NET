// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams
{
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.ObjectFormat"]/*'/>
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.StaticObjectTypeMask"]/*'/>
    public AudioObjectType StaticObjectTypeMask;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.MinDynamicObjectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.MaxDynamicObjectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.Category"]/*'/>
    public AUDIO_STREAM_CATEGORY Category;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.EventHandle"]/*'/>
    public HANDLE EventHandle;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.MetadataFormatId"]/*'/>
    public Guid MetadataFormatId;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.MaxMetadataItemCount"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort MaxMetadataItemCount;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.MetadataActivationParams"]/*'/>
    [NativeTypeName("const PROPVARIANT *")]
    public PROPVARIANT* MetadataActivationParams;
    /// <include file='SpatialAudioObjectRenderStreamForMetadataActivationParams.xml' path='doc/member[@name="SpatialAudioObjectRenderStreamForMetadataActivationParams.NotifyObject"]/*'/>
    public ISpatialAudioObjectRenderStreamNotify* NotifyObject;
}