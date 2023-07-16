// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VIDEOENCODER_BITRATE_MODE.xml' path='doc/member[@name="VIDEOENCODER_BITRATE_MODE"]/*'/>
public enum VIDEOENCODER_BITRATE_MODE
{
    /// <include file='VIDEOENCODER_BITRATE_MODE.xml' path='doc/member[@name="VIDEOENCODER_BITRATE_MODE.ConstantBitRate"]/*'/>
    ConstantBitRate = 0,
    /// <include file='VIDEOENCODER_BITRATE_MODE.xml' path='doc/member[@name="VIDEOENCODER_BITRATE_MODE.VariableBitRateAverage"]/*'/>
    VariableBitRateAverage = (ConstantBitRate + 1),
    /// <include file='VIDEOENCODER_BITRATE_MODE.xml' path='doc/member[@name="VIDEOENCODER_BITRATE_MODE.VariableBitRatePeak"]/*'/>
    VariableBitRatePeak = (VariableBitRateAverage + 1),
}