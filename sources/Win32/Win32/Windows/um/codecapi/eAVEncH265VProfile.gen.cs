// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncH265VProfile
{
    eAVEncH265VProfile_unknown = 0,
    eAVEncH265VProfile_Main_420_8 = 1,
    eAVEncH265VProfile_Main_420_10 = 2,
    eAVEncH265VProfile_Main_420_12 = 3,
    eAVEncH265VProfile_Main_422_10 = 4,
    eAVEncH265VProfile_Main_422_12 = 5,
    eAVEncH265VProfile_Main_444_8 = 6,
    eAVEncH265VProfile_Main_444_10 = 7,
    eAVEncH265VProfile_Main_444_12 = 8,
    eAVEncH265VProfile_Monochrome_12 = 9,
    eAVEncH265VProfile_Monochrome_16 = 10,
    eAVEncH265VProfile_MainIntra_420_8 = 11,
    eAVEncH265VProfile_MainIntra_420_10 = 12,
    eAVEncH265VProfile_MainIntra_420_12 = 13,
    eAVEncH265VProfile_MainIntra_422_10 = 14,
    eAVEncH265VProfile_MainIntra_422_12 = 15,
    eAVEncH265VProfile_MainIntra_444_8 = 16,
    eAVEncH265VProfile_MainIntra_444_10 = 17,
    eAVEncH265VProfile_MainIntra_444_12 = 18,
    eAVEncH265VProfile_MainIntra_444_16 = 19,
    eAVEncH265VProfile_MainStill_420_8 = 20,
    eAVEncH265VProfile_MainStill_444_8 = 21,
    eAVEncH265VProfile_MainStill_444_16 = 22,
}
