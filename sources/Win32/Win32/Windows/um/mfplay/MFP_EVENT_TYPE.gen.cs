// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFP_EVENT_TYPE
{
    MFP_EVENT_TYPE_PLAY = 0,
    MFP_EVENT_TYPE_PAUSE = 1,
    MFP_EVENT_TYPE_STOP = 2,
    MFP_EVENT_TYPE_POSITION_SET = 3,
    MFP_EVENT_TYPE_RATE_SET = 4,
    MFP_EVENT_TYPE_MEDIAITEM_CREATED = 5,
    MFP_EVENT_TYPE_MEDIAITEM_SET = 6,
    MFP_EVENT_TYPE_FRAME_STEP = 7,
    MFP_EVENT_TYPE_MEDIAITEM_CLEARED = 8,
    MFP_EVENT_TYPE_MF = 9,
    MFP_EVENT_TYPE_ERROR = 10,
    MFP_EVENT_TYPE_PLAYBACK_ENDED = 11,
    MFP_EVENT_TYPE_ACQUIRE_USER_CREDENTIAL = 12,
}
