// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_SEEKING_SEEKING_CAPABILITIES
{
    AM_SEEKING_CanSeekAbsolute = 0x1,
    AM_SEEKING_CanSeekForwards = 0x2,
    AM_SEEKING_CanSeekBackwards = 0x4,
    AM_SEEKING_CanGetCurrentPos = 0x8,
    AM_SEEKING_CanGetStopPos = 0x10,
    AM_SEEKING_CanGetDuration = 0x20,
    AM_SEEKING_CanPlayBackwards = 0x40,
    AM_SEEKING_CanDoSegments = 0x80,
    AM_SEEKING_Source = 0x100,
}
