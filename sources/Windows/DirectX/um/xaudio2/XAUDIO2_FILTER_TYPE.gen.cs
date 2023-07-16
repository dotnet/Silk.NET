// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE"]/*'/>
public enum XAUDIO2_FILTER_TYPE
{
    /// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE.LowPassFilter"]/*'/>
    LowPassFilter,
    /// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE.BandPassFilter"]/*'/>
    BandPassFilter,
    /// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE.HighPassFilter"]/*'/>
    HighPassFilter,
    /// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE.NotchFilter"]/*'/>
    NotchFilter,
    /// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE.LowPassOnePoleFilter"]/*'/>
    LowPassOnePoleFilter,
    /// <include file='XAUDIO2_FILTER_TYPE.xml' path='doc/member[@name="XAUDIO2_FILTER_TYPE.HighPassOnePoleFilter"]/*'/>
    HighPassOnePoleFilter,
}