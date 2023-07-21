// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVEncVideoChromaSubsampling.xml' path='doc/member[@name="eAVEncVideoChromaSubsampling"]/*' />
public enum eAVEncVideoChromaSubsampling
{
    /// <include file='eAVEncVideoChromaSubsampling.xml' path='doc/member[@name="eAVEncVideoChromaSubsampling.eAVEncVideoChromaSubsamplingFormat_SameAsSource"]/*' />
    eAVEncVideoChromaSubsamplingFormat_SameAsSource = 0,

    /// <include file='eAVEncVideoChromaSubsampling.xml' path='doc/member[@name="eAVEncVideoChromaSubsampling.eAVEncVideoChromaSubsamplingFormat_ProgressiveChroma"]/*' />
    eAVEncVideoChromaSubsamplingFormat_ProgressiveChroma = 0x8,

    /// <include file='eAVEncVideoChromaSubsampling.xml' path='doc/member[@name="eAVEncVideoChromaSubsampling.eAVEncVideoChromaSubsamplingFormat_Horizontally_Cosited"]/*' />
    eAVEncVideoChromaSubsamplingFormat_Horizontally_Cosited = 0x4,

    /// <include file='eAVEncVideoChromaSubsampling.xml' path='doc/member[@name="eAVEncVideoChromaSubsampling.eAVEncVideoChromaSubsamplingFormat_Vertically_Cosited"]/*' />
    eAVEncVideoChromaSubsamplingFormat_Vertically_Cosited = 0x2,

    /// <include file='eAVEncVideoChromaSubsampling.xml' path='doc/member[@name="eAVEncVideoChromaSubsampling.eAVEncVideoChromaSubsamplingFormat_Vertically_AlignedChromaPlanes"]/*' />
    eAVEncVideoChromaSubsamplingFormat_Vertically_AlignedChromaPlanes = 0x1,
}
