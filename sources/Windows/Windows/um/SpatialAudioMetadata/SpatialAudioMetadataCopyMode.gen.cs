// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SpatialAudioMetadataCopyMode.xml' path='doc/member[@name="SpatialAudioMetadataCopyMode"]/*'/>
public enum SpatialAudioMetadataCopyMode
{
    /// <include file='SpatialAudioMetadataCopyMode.xml' path='doc/member[@name="SpatialAudioMetadataCopyMode.SpatialAudioMetadataCopy_Overwrite"]/*'/>
    SpatialAudioMetadataCopy_Overwrite = 0,
    /// <include file='SpatialAudioMetadataCopyMode.xml' path='doc/member[@name="SpatialAudioMetadataCopyMode.SpatialAudioMetadataCopy_Append"]/*'/>
    SpatialAudioMetadataCopy_Append = (SpatialAudioMetadataCopy_Overwrite + 1),
    /// <include file='SpatialAudioMetadataCopyMode.xml' path='doc/member[@name="SpatialAudioMetadataCopyMode.SpatialAudioMetadataCopy_AppendMergeWithLast"]/*'/>
    SpatialAudioMetadataCopy_AppendMergeWithLast = (SpatialAudioMetadataCopy_Append + 1),
    /// <include file='SpatialAudioMetadataCopyMode.xml' path='doc/member[@name="SpatialAudioMetadataCopyMode.SpatialAudioMetadataCopy_AppendMergeWithFirst"]/*'/>
    SpatialAudioMetadataCopy_AppendMergeWithFirst = (SpatialAudioMetadataCopy_AppendMergeWithLast + 1),
}