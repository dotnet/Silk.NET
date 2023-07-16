// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard"]/*'/>
public enum AnalogVideoStandard
{
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_None"]/*'/>
    AnalogVideo_None = 0,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_NTSC_M"]/*'/>
    AnalogVideo_NTSC_M = 0x1,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_NTSC_M_J"]/*'/>
    AnalogVideo_NTSC_M_J = 0x2,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_NTSC_433"]/*'/>
    AnalogVideo_NTSC_433 = 0x4,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_B"]/*'/>
    AnalogVideo_PAL_B = 0x10,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_D"]/*'/>
    AnalogVideo_PAL_D = 0x20,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_G"]/*'/>
    AnalogVideo_PAL_G = 0x40,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_H"]/*'/>
    AnalogVideo_PAL_H = 0x80,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_I"]/*'/>
    AnalogVideo_PAL_I = 0x100,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_M"]/*'/>
    AnalogVideo_PAL_M = 0x200,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_N"]/*'/>
    AnalogVideo_PAL_N = 0x400,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_60"]/*'/>
    AnalogVideo_PAL_60 = 0x800,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_B"]/*'/>
    AnalogVideo_SECAM_B = 0x1000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_D"]/*'/>
    AnalogVideo_SECAM_D = 0x2000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_G"]/*'/>
    AnalogVideo_SECAM_G = 0x4000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_H"]/*'/>
    AnalogVideo_SECAM_H = 0x8000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_K"]/*'/>
    AnalogVideo_SECAM_K = 0x10000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_K1"]/*'/>
    AnalogVideo_SECAM_K1 = 0x20000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_L"]/*'/>
    AnalogVideo_SECAM_L = 0x40000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_SECAM_L1"]/*'/>
    AnalogVideo_SECAM_L1 = 0x80000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideo_PAL_N_COMBO"]/*'/>
    AnalogVideo_PAL_N_COMBO = 0x100000,
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideoMask_MCE_NTSC"]/*'/>
    AnalogVideoMask_MCE_NTSC = ((((((AnalogVideo_NTSC_M | AnalogVideo_NTSC_M_J) | AnalogVideo_NTSC_433) | AnalogVideo_PAL_M) | AnalogVideo_PAL_N) | AnalogVideo_PAL_60) | AnalogVideo_PAL_N_COMBO),
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideoMask_MCE_PAL"]/*'/>
    AnalogVideoMask_MCE_PAL = ((((AnalogVideo_PAL_B | AnalogVideo_PAL_D) | AnalogVideo_PAL_G) | AnalogVideo_PAL_H) | AnalogVideo_PAL_I),
    /// <include file='AnalogVideoStandard.xml' path='doc/member[@name="AnalogVideoStandard.AnalogVideoMask_MCE_SECAM"]/*'/>
    AnalogVideoMask_MCE_SECAM = (((((((AnalogVideo_SECAM_B | AnalogVideo_SECAM_D) | AnalogVideo_SECAM_G) | AnalogVideo_SECAM_H) | AnalogVideo_SECAM_K) | AnalogVideo_SECAM_K1) | AnalogVideo_SECAM_L) | AnalogVideo_SECAM_L1),
}