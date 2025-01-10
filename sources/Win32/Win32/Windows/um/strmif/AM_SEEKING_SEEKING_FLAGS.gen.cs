// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_SEEKING_SEEKING_FLAGS
{
    AM_SEEKING_NoPositioning = 0,
    AM_SEEKING_AbsolutePositioning = 0x1,
    AM_SEEKING_RelativePositioning = 0x2,
    AM_SEEKING_IncrementalPositioning = 0x3,
    AM_SEEKING_PositioningBitsMask = 0x3,
    AM_SEEKING_SeekToKeyFrame = 0x4,
    AM_SEEKING_ReturnTime = 0x8,
    AM_SEEKING_Segment = 0x10,
    AM_SEEKING_NoFlush = 0x20,
}
