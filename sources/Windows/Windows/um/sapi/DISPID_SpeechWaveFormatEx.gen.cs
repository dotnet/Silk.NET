// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx"]/*' />
public enum DISPID_SpeechWaveFormatEx
{
    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFEFormatTag"]/*' />
    DISPID_SWFEFormatTag = 1,

    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFEChannels"]/*' />
    DISPID_SWFEChannels = (DISPID_SWFEFormatTag + 1),

    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFESamplesPerSec"]/*' />
    DISPID_SWFESamplesPerSec = (DISPID_SWFEChannels + 1),

    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFEAvgBytesPerSec"]/*' />
    DISPID_SWFEAvgBytesPerSec = (DISPID_SWFESamplesPerSec + 1),

    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFEBlockAlign"]/*' />
    DISPID_SWFEBlockAlign = (DISPID_SWFEAvgBytesPerSec + 1),

    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFEBitsPerSample"]/*' />
    DISPID_SWFEBitsPerSample = (DISPID_SWFEBlockAlign + 1),

    /// <include file='DISPID_SpeechWaveFormatEx.xml' path='doc/member[@name="DISPID_SpeechWaveFormatEx.DISPID_SWFEExtraData"]/*' />
    DISPID_SWFEExtraData = (DISPID_SWFEBitsPerSample + 1),
}
