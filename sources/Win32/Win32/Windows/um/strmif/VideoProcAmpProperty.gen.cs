// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum VideoProcAmpProperty
{
    VideoProcAmp_Brightness = 0,
    VideoProcAmp_Contrast = (VideoProcAmp_Brightness + 1),
    VideoProcAmp_Hue = (VideoProcAmp_Contrast + 1),
    VideoProcAmp_Saturation = (VideoProcAmp_Hue + 1),
    VideoProcAmp_Sharpness = (VideoProcAmp_Saturation + 1),
    VideoProcAmp_Gamma = (VideoProcAmp_Sharpness + 1),
    VideoProcAmp_ColorEnable = (VideoProcAmp_Gamma + 1),
    VideoProcAmp_WhiteBalance = (VideoProcAmp_ColorEnable + 1),
    VideoProcAmp_BacklightCompensation = (VideoProcAmp_WhiteBalance + 1),
    VideoProcAmp_Gain = (VideoProcAmp_BacklightCompensation + 1),
}
