// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode"]/*'/>
public enum eAVEncCommonRateControlMode
{
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_CBR"]/*'/>
    eAVEncCommonRateControlMode_CBR = 0,
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_PeakConstrainedVBR"]/*'/>
    eAVEncCommonRateControlMode_PeakConstrainedVBR = 1,
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_UnconstrainedVBR"]/*'/>
    eAVEncCommonRateControlMode_UnconstrainedVBR = 2,
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_Quality"]/*'/>
    eAVEncCommonRateControlMode_Quality = 3,
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_LowDelayVBR"]/*'/>
    eAVEncCommonRateControlMode_LowDelayVBR = 4,
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_GlobalVBR"]/*'/>
    eAVEncCommonRateControlMode_GlobalVBR = 5,
    /// <include file='eAVEncCommonRateControlMode.xml' path='doc/member[@name="eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_GlobalLowDelayVBR"]/*'/>
    eAVEncCommonRateControlMode_GlobalLowDelayVBR = 6,
}