// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='eAVEncVideoColorTransferMatrix.xml' path='doc/member[@name="eAVEncVideoColorTransferMatrix"]/*'/>
public enum eAVEncVideoColorTransferMatrix
{
    /// <include file='eAVEncVideoColorTransferMatrix.xml' path='doc/member[@name="eAVEncVideoColorTransferMatrix.eAVEncVideoColorTransferMatrix_SameAsSource"]/*'/>
    eAVEncVideoColorTransferMatrix_SameAsSource = 0,
    /// <include file='eAVEncVideoColorTransferMatrix.xml' path='doc/member[@name="eAVEncVideoColorTransferMatrix.eAVEncVideoColorTransferMatrix_BT709"]/*'/>
    eAVEncVideoColorTransferMatrix_BT709 = 1,
    /// <include file='eAVEncVideoColorTransferMatrix.xml' path='doc/member[@name="eAVEncVideoColorTransferMatrix.eAVEncVideoColorTransferMatrix_BT601"]/*'/>
    eAVEncVideoColorTransferMatrix_BT601 = 2,
    /// <include file='eAVEncVideoColorTransferMatrix.xml' path='doc/member[@name="eAVEncVideoColorTransferMatrix.eAVEncVideoColorTransferMatrix_SMPTE240M"]/*'/>
    eAVEncVideoColorTransferMatrix_SMPTE240M = 3,
}