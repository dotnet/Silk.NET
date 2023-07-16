// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SpatialAudioMetadataWriterOverflowMode.xml' path='doc/member[@name="SpatialAudioMetadataWriterOverflowMode"]/*'/>
public enum SpatialAudioMetadataWriterOverflowMode
{
    /// <include file='SpatialAudioMetadataWriterOverflowMode.xml' path='doc/member[@name="SpatialAudioMetadataWriterOverflowMode.SpatialAudioMetadataWriterOverflow_Fail"]/*'/>
    SpatialAudioMetadataWriterOverflow_Fail = 0,
    /// <include file='SpatialAudioMetadataWriterOverflowMode.xml' path='doc/member[@name="SpatialAudioMetadataWriterOverflowMode.SpatialAudioMetadataWriterOverflow_MergeWithNew"]/*'/>
    SpatialAudioMetadataWriterOverflow_MergeWithNew = (SpatialAudioMetadataWriterOverflow_Fail + 1),
    /// <include file='SpatialAudioMetadataWriterOverflowMode.xml' path='doc/member[@name="SpatialAudioMetadataWriterOverflowMode.SpatialAudioMetadataWriterOverflow_MergeWithLast"]/*'/>
    SpatialAudioMetadataWriterOverflow_MergeWithLast = (SpatialAudioMetadataWriterOverflow_MergeWithNew + 1),
}