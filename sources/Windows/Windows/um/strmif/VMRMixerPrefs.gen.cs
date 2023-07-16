// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs"]/*'/>
public enum VMRMixerPrefs
{
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_NoDecimation"]/*'/>
    MixerPref_NoDecimation = 0x1,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DecimateOutput"]/*'/>
    MixerPref_DecimateOutput = 0x2,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_ARAdjustXorY"]/*'/>
    MixerPref_ARAdjustXorY = 0x4,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DecimationReserved"]/*'/>
    MixerPref_DecimationReserved = 0x8,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DecimateMask"]/*'/>
    MixerPref_DecimateMask = 0xf,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_BiLinearFiltering"]/*'/>
    MixerPref_BiLinearFiltering = 0x10,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_PointFiltering"]/*'/>
    MixerPref_PointFiltering = 0x20,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_FilteringMask"]/*'/>
    MixerPref_FilteringMask = 0xf0,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetRGB"]/*'/>
    MixerPref_RenderTargetRGB = 0x100,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetYUV"]/*'/>
    MixerPref_RenderTargetYUV = 0x1000,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetYUV420"]/*'/>
    MixerPref_RenderTargetYUV420 = 0x200,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetYUV422"]/*'/>
    MixerPref_RenderTargetYUV422 = 0x400,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetYUV444"]/*'/>
    MixerPref_RenderTargetYUV444 = 0x800,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetReserved"]/*'/>
    MixerPref_RenderTargetReserved = 0xe000,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_RenderTargetMask"]/*'/>
    MixerPref_RenderTargetMask = 0xff00,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DynamicSwitchToBOB"]/*'/>
    MixerPref_DynamicSwitchToBOB = 0x10000,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DynamicDecimateBy2"]/*'/>
    MixerPref_DynamicDecimateBy2 = 0x20000,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DynamicReserved"]/*'/>
    MixerPref_DynamicReserved = 0xc0000,
    /// <include file='VMRMixerPrefs.xml' path='doc/member[@name="VMRMixerPrefs.MixerPref_DynamicMask"]/*'/>
    MixerPref_DynamicMask = 0xf0000,
}