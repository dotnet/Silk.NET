// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFT_AUDIO_DECODER_DEGRADATION_TYPE.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_TYPE"]/*' />
public enum MFT_AUDIO_DECODER_DEGRADATION_TYPE
{
    /// <include file='MFT_AUDIO_DECODER_DEGRADATION_TYPE.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_TYPE.MFT_AUDIO_DECODER_DEGRADATION_TYPE_NONE"]/*' />
    MFT_AUDIO_DECODER_DEGRADATION_TYPE_NONE = 0,

    /// <include file='MFT_AUDIO_DECODER_DEGRADATION_TYPE.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_TYPE.MFT_AUDIO_DECODER_DEGRADATION_TYPE_DOWNMIX2CHANNEL"]/*' />
    MFT_AUDIO_DECODER_DEGRADATION_TYPE_DOWNMIX2CHANNEL = 1,

    /// <include file='MFT_AUDIO_DECODER_DEGRADATION_TYPE.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_TYPE.MFT_AUDIO_DECODER_DEGRADATION_TYPE_DOWNMIX6CHANNEL"]/*' />
    MFT_AUDIO_DECODER_DEGRADATION_TYPE_DOWNMIX6CHANNEL = 2,

    /// <include file='MFT_AUDIO_DECODER_DEGRADATION_TYPE.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_TYPE.MFT_AUDIO_DECODER_DEGRADATION_TYPE_DOWNMIX8CHANNEL"]/*' />
    MFT_AUDIO_DECODER_DEGRADATION_TYPE_DOWNMIX8CHANNEL = 3,
}
