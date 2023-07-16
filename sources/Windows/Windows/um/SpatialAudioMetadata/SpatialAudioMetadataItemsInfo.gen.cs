// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SpatialAudioMetadataItemsInfo.xml' path='doc/member[@name="SpatialAudioMetadataItemsInfo"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioMetadataItemsInfo
{
    /// <include file='SpatialAudioMetadataItemsInfo.xml' path='doc/member[@name="SpatialAudioMetadataItemsInfo.FrameCount"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort FrameCount;
    /// <include file='SpatialAudioMetadataItemsInfo.xml' path='doc/member[@name="SpatialAudioMetadataItemsInfo.ItemCount"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort ItemCount;
    /// <include file='SpatialAudioMetadataItemsInfo.xml' path='doc/member[@name="SpatialAudioMetadataItemsInfo.MaxItemCount"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort MaxItemCount;
    /// <include file='SpatialAudioMetadataItemsInfo.xml' path='doc/member[@name="SpatialAudioMetadataItemsInfo.MaxValueBufferLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxValueBufferLength;
}