// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix"]/*'/>
public enum MFVideoTransferMatrix
{
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Unknown"]/*'/>
    MFVideoTransferMatrix_Unknown = 0,
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT709"]/*'/>
    MFVideoTransferMatrix_BT709 = 1,
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT601"]/*'/>
    MFVideoTransferMatrix_BT601 = 2,
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_SMPTE240M"]/*'/>
    MFVideoTransferMatrix_SMPTE240M = 3,
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT2020_10"]/*'/>
    MFVideoTransferMatrix_BT2020_10 = 4,
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_BT2020_12"]/*'/>
    MFVideoTransferMatrix_BT2020_12 = 5,
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_Last"]/*'/>
    MFVideoTransferMatrix_Last = (MFVideoTransferMatrix_BT2020_12 + 1),
    /// <include file='MFVideoTransferMatrix.xml' path='doc/member[@name="MFVideoTransferMatrix.MFVideoTransferMatrix_ForceDWORD"]/*'/>
    MFVideoTransferMatrix_ForceDWORD = 0x7fffffff,
}