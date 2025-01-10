// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpatialAudioMetadataCopyMode
{
    SpatialAudioMetadataCopy_Overwrite = 0,
    SpatialAudioMetadataCopy_Append = (SpatialAudioMetadataCopy_Overwrite + 1),
    SpatialAudioMetadataCopy_AppendMergeWithLast = (SpatialAudioMetadataCopy_Append + 1),
    SpatialAudioMetadataCopy_AppendMergeWithFirst =
        (SpatialAudioMetadataCopy_AppendMergeWithLast + 1),
}
