// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling"]/*' />
public enum MFVideoChromaSubsampling
{
    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_Unknown"]/*' />
    MFVideoChromaSubsampling_Unknown = 0,

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_ProgressiveChroma"]/*' />
    MFVideoChromaSubsampling_ProgressiveChroma = 0x8,

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_Horizontally_Cosited"]/*' />
    MFVideoChromaSubsampling_Horizontally_Cosited = 0x4,

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_Vertically_Cosited"]/*' />
    MFVideoChromaSubsampling_Vertically_Cosited = 0x2,

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes"]/*' />
    MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes = 0x1,

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_MPEG2"]/*' />
    MFVideoChromaSubsampling_MPEG2 = (MFVideoChromaSubsampling_Horizontally_Cosited | MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes),

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_MPEG1"]/*' />
    MFVideoChromaSubsampling_MPEG1 = MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes,

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_DV_PAL"]/*' />
    MFVideoChromaSubsampling_DV_PAL = (MFVideoChromaSubsampling_Horizontally_Cosited | MFVideoChromaSubsampling_Vertically_Cosited),

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_Cosited"]/*' />
    MFVideoChromaSubsampling_Cosited = ((MFVideoChromaSubsampling_Horizontally_Cosited | MFVideoChromaSubsampling_Vertically_Cosited) | MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes),

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_Last"]/*' />
    MFVideoChromaSubsampling_Last = (MFVideoChromaSubsampling_Cosited + 1),

    /// <include file='MFVideoChromaSubsampling.xml' path='doc/member[@name="MFVideoChromaSubsampling.MFVideoChromaSubsampling_ForceDWORD"]/*' />
    MFVideoChromaSubsampling_ForceDWORD = 0x7fffffff,
}
