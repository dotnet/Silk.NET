// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFAudioDecoderDegradationInfo.xml' path='doc/member[@name="MFAudioDecoderDegradationInfo"]/*' />
public partial struct MFAudioDecoderDegradationInfo
{
    /// <include file='MFAudioDecoderDegradationInfo.xml' path='doc/member[@name="MFAudioDecoderDegradationInfo.eDegradationReason"]/*' />
    public MFT_AUDIO_DECODER_DEGRADATION_REASON eDegradationReason;

    /// <include file='MFAudioDecoderDegradationInfo.xml' path='doc/member[@name="MFAudioDecoderDegradationInfo.eType"]/*' />
    public MFT_AUDIO_DECODER_DEGRADATION_TYPE eType;
}
