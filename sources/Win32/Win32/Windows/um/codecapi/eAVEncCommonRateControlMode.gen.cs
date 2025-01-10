// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncCommonRateControlMode
{
    eAVEncCommonRateControlMode_CBR = 0,
    eAVEncCommonRateControlMode_PeakConstrainedVBR = 1,
    eAVEncCommonRateControlMode_UnconstrainedVBR = 2,
    eAVEncCommonRateControlMode_Quality = 3,
    eAVEncCommonRateControlMode_LowDelayVBR = 4,
    eAVEncCommonRateControlMode_GlobalVBR = 5,
    eAVEncCommonRateControlMode_GlobalLowDelayVBR = 6,
}
