// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFT_AUDIO_DECODER_DEGRADATION_REASON.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_REASON"]/*'/>
public enum MFT_AUDIO_DECODER_DEGRADATION_REASON
{
    /// <include file='MFT_AUDIO_DECODER_DEGRADATION_REASON.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_REASON.MFT_AUDIO_DECODER_DEGRADATION_REASON_NONE"]/*'/>
    MFT_AUDIO_DECODER_DEGRADATION_REASON_NONE = 0,
    /// <include file='MFT_AUDIO_DECODER_DEGRADATION_REASON.xml' path='doc/member[@name="MFT_AUDIO_DECODER_DEGRADATION_REASON.MFT_AUDIO_DECODER_DEGRADATION_REASON_LICENSING_REQUIREMENT"]/*'/>
    MFT_AUDIO_DECODER_DEGRADATION_REASON_LICENSING_REQUIREMENT = 1,
}