// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum AudioObjectType
{
    AudioObjectType_None = 0,
    AudioObjectType_Dynamic = (1 << 0),
    AudioObjectType_FrontLeft = (1 << 1),
    AudioObjectType_FrontRight = (1 << 2),
    AudioObjectType_FrontCenter = (1 << 3),
    AudioObjectType_LowFrequency = (1 << 4),
    AudioObjectType_SideLeft = (1 << 5),
    AudioObjectType_SideRight = (1 << 6),
    AudioObjectType_BackLeft = (1 << 7),
    AudioObjectType_BackRight = (1 << 8),
    AudioObjectType_TopFrontLeft = (1 << 9),
    AudioObjectType_TopFrontRight = (1 << 10),
    AudioObjectType_TopBackLeft = (1 << 11),
    AudioObjectType_TopBackRight = (1 << 12),
    AudioObjectType_BottomFrontLeft = (1 << 13),
    AudioObjectType_BottomFrontRight = (1 << 14),
    AudioObjectType_BottomBackLeft = (1 << 15),
    AudioObjectType_BottomBackRight = (1 << 16),
    AudioObjectType_BackCenter = (1 << 17),
    AudioObjectType_StereoLeft = (1 << 18),
    AudioObjectType_StereoRight = (1 << 19),
}
