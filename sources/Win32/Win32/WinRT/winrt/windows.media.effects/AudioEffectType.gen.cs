// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AudioEffectType
{
    AudioEffectType_Other = 0,
    AudioEffectType_AcousticEchoCancellation = 1,
    AudioEffectType_NoiseSuppression = 2,
    AudioEffectType_AutomaticGainControl = 3,
    AudioEffectType_BeamForming = 4,
    AudioEffectType_ConstantToneRemoval = 5,
    AudioEffectType_Equalizer = 6,
    AudioEffectType_LoudnessEqualizer = 7,
    AudioEffectType_BassBoost = 8,
    AudioEffectType_VirtualSurround = 9,
    AudioEffectType_VirtualHeadphones = 10,
    AudioEffectType_SpeakerFill = 11,
    AudioEffectType_RoomCorrection = 12,
    AudioEffectType_BassManagement = 13,
    AudioEffectType_EnvironmentalEffects = 14,
    AudioEffectType_SpeakerProtection = 15,
    AudioEffectType_SpeakerCompensation = 16,
    AudioEffectType_DynamicRangeCompression = 17,
    AudioEffectType_FarFieldBeamForming = 18,
    AudioEffectType_DeepNoiseSuppression = 19,
}
