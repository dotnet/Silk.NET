// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpatialAudioHrtfEnvironmentType
{
    SpatialAudioHrtfEnvironment_Small = 0,
    SpatialAudioHrtfEnvironment_Medium = (SpatialAudioHrtfEnvironment_Small + 1),
    SpatialAudioHrtfEnvironment_Large = (SpatialAudioHrtfEnvironment_Medium + 1),
    SpatialAudioHrtfEnvironment_Outdoors = (SpatialAudioHrtfEnvironment_Large + 1),
    SpatialAudioHrtfEnvironment_Average = (SpatialAudioHrtfEnvironment_Outdoors + 1),
}
