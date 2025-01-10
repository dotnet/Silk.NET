// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVAudioChannelConfig
{
    eAVAudioChannelConfig_FRONT_LEFT = 0x1,
    eAVAudioChannelConfig_FRONT_RIGHT = 0x2,
    eAVAudioChannelConfig_FRONT_CENTER = 0x4,
    eAVAudioChannelConfig_LOW_FREQUENCY = 0x8,
    eAVAudioChannelConfig_BACK_LEFT = 0x10,
    eAVAudioChannelConfig_BACK_RIGHT = 0x20,
    eAVAudioChannelConfig_FRONT_LEFT_OF_CENTER = 0x40,
    eAVAudioChannelConfig_FRONT_RIGHT_OF_CENTER = 0x80,
    eAVAudioChannelConfig_BACK_CENTER = 0x100,
    eAVAudioChannelConfig_SIDE_LEFT = 0x200,
    eAVAudioChannelConfig_SIDE_RIGHT = 0x400,
    eAVAudioChannelConfig_TOP_CENTER = 0x800,
    eAVAudioChannelConfig_TOP_FRONT_LEFT = 0x1000,
    eAVAudioChannelConfig_TOP_FRONT_CENTER = 0x2000,
    eAVAudioChannelConfig_TOP_FRONT_RIGHT = 0x4000,
    eAVAudioChannelConfig_TOP_BACK_LEFT = 0x8000,
    eAVAudioChannelConfig_TOP_BACK_CENTER = 0x10000,
    eAVAudioChannelConfig_TOP_BACK_RIGHT = 0x20000,
}
