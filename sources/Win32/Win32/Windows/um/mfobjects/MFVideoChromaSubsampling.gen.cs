// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFVideoChromaSubsampling
{
    MFVideoChromaSubsampling_Unknown = 0,
    MFVideoChromaSubsampling_ProgressiveChroma = 0x8,
    MFVideoChromaSubsampling_Horizontally_Cosited = 0x4,
    MFVideoChromaSubsampling_Vertically_Cosited = 0x2,
    MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes = 0x1,
    MFVideoChromaSubsampling_MPEG2 =
        (
            MFVideoChromaSubsampling_Horizontally_Cosited
            | MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes
        ),
    MFVideoChromaSubsampling_MPEG1 = MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes,
    MFVideoChromaSubsampling_DV_PAL =
        (
            MFVideoChromaSubsampling_Horizontally_Cosited
            | MFVideoChromaSubsampling_Vertically_Cosited
        ),
    MFVideoChromaSubsampling_Cosited =
        (
            (
                MFVideoChromaSubsampling_Horizontally_Cosited
                | MFVideoChromaSubsampling_Vertically_Cosited
            ) | MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes
        ),
    MFVideoChromaSubsampling_Last = (MFVideoChromaSubsampling_Cosited + 1),
    MFVideoChromaSubsampling_ForceDWORD = 0x7fffffff,
}
