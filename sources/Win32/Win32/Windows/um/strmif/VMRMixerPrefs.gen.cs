// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum VMRMixerPrefs
{
    MixerPref_NoDecimation = 0x1,
    MixerPref_DecimateOutput = 0x2,
    MixerPref_ARAdjustXorY = 0x4,
    MixerPref_DecimationReserved = 0x8,
    MixerPref_DecimateMask = 0xf,
    MixerPref_BiLinearFiltering = 0x10,
    MixerPref_PointFiltering = 0x20,
    MixerPref_FilteringMask = 0xf0,
    MixerPref_RenderTargetRGB = 0x100,
    MixerPref_RenderTargetYUV = 0x1000,
    MixerPref_RenderTargetYUV420 = 0x200,
    MixerPref_RenderTargetYUV422 = 0x400,
    MixerPref_RenderTargetYUV444 = 0x800,
    MixerPref_RenderTargetReserved = 0xe000,
    MixerPref_RenderTargetMask = 0xff00,
    MixerPref_DynamicSwitchToBOB = 0x10000,
    MixerPref_DynamicDecimateBy2 = 0x20000,
    MixerPref_DynamicReserved = 0xc0000,
    MixerPref_DynamicMask = 0xf0000,
}
