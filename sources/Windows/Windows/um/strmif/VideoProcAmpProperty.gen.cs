// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty"]/*' />
public enum VideoProcAmpProperty
{
    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Brightness"]/*' />
    VideoProcAmp_Brightness = 0,

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Contrast"]/*' />
    VideoProcAmp_Contrast = (VideoProcAmp_Brightness + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Hue"]/*' />
    VideoProcAmp_Hue = (VideoProcAmp_Contrast + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Saturation"]/*' />
    VideoProcAmp_Saturation = (VideoProcAmp_Hue + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Sharpness"]/*' />
    VideoProcAmp_Sharpness = (VideoProcAmp_Saturation + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Gamma"]/*' />
    VideoProcAmp_Gamma = (VideoProcAmp_Sharpness + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_ColorEnable"]/*' />
    VideoProcAmp_ColorEnable = (VideoProcAmp_Gamma + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_WhiteBalance"]/*' />
    VideoProcAmp_WhiteBalance = (VideoProcAmp_ColorEnable + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_BacklightCompensation"]/*' />
    VideoProcAmp_BacklightCompensation = (VideoProcAmp_WhiteBalance + 1),

    /// <include file='VideoProcAmpProperty.xml' path='doc/member[@name="VideoProcAmpProperty.VideoProcAmp_Gain"]/*' />
    VideoProcAmp_Gain = (VideoProcAmp_BacklightCompensation + 1),
}
