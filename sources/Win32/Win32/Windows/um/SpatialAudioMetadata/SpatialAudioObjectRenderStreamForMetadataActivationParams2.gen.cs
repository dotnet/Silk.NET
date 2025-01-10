// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams2
{
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;
    public AudioObjectType StaticObjectTypeMask;

    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;

    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;
    public AUDIO_STREAM_CATEGORY Category;
    public HANDLE EventHandle;
    public Guid MetadataFormatId;

    [NativeTypeName("UINT32")]
    public uint MaxMetadataItemCount;

    [NativeTypeName("const PROPVARIANT *")]
    public PROPVARIANT* MetadataActivationParams;
    public ISpatialAudioObjectRenderStreamNotify NotifyObject;
    public SPATIAL_AUDIO_STREAM_OPTIONS Options;
}
