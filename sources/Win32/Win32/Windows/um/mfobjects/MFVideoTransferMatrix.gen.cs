// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFVideoTransferMatrix
{
    MFVideoTransferMatrix_Unknown = 0,
    MFVideoTransferMatrix_BT709 = 1,
    MFVideoTransferMatrix_BT601 = 2,
    MFVideoTransferMatrix_SMPTE240M = 3,
    MFVideoTransferMatrix_BT2020_10 = 4,
    MFVideoTransferMatrix_BT2020_12 = 5,
    MFVideoTransferMatrix_Identity = 6,
    MFVideoTransferMatrix_FCC47 = 7,
    MFVideoTransferMatrix_YCgCo = 8,
    MFVideoTransferMatrix_SMPTE2085 = 9,
    MFVideoTransferMatrix_Chroma = 10,
    MFVideoTransferMatrix_Chroma_const = 11,
    MFVideoTransferMatrix_ICtCp = 12,
    MFVideoTransferMatrix_Last = (MFVideoTransferMatrix_ICtCp + 1),
    MFVideoTransferMatrix_ForceDWORD = 0x7fffffff,
}
