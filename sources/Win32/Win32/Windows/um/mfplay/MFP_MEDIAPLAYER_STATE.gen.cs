// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFP_MEDIAPLAYER_STATE
{
    MFP_MEDIAPLAYER_STATE_EMPTY = 0,
    MFP_MEDIAPLAYER_STATE_STOPPED = 0x1,
    MFP_MEDIAPLAYER_STATE_PLAYING = 0x2,
    MFP_MEDIAPLAYER_STATE_PAUSED = 0x3,
    MFP_MEDIAPLAYER_STATE_SHUTDOWN = 0x4,
}
