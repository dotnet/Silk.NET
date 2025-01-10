// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum tagAM_SAMPLE_PROPERTY_FLAGS
{
    AM_SAMPLE_SPLICEPOINT = 0x1,
    AM_SAMPLE_PREROLL = 0x2,
    AM_SAMPLE_DATADISCONTINUITY = 0x4,
    AM_SAMPLE_TYPECHANGED = 0x8,
    AM_SAMPLE_TIMEVALID = 0x10,
    AM_SAMPLE_TIMEDISCONTINUITY = 0x40,
    AM_SAMPLE_FLUSH_ON_PAUSE = 0x80,
    AM_SAMPLE_STOPVALID = 0x100,
    AM_SAMPLE_ENDOFSTREAM = 0x200,
    AM_STREAM_MEDIA = 0,
    AM_STREAM_CONTROL = 1,
}
