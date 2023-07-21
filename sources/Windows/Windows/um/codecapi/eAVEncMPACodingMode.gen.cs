// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVEncMPACodingMode.xml' path='doc/member[@name="eAVEncMPACodingMode"]/*' />
public enum eAVEncMPACodingMode
{
    /// <include file='eAVEncMPACodingMode.xml' path='doc/member[@name="eAVEncMPACodingMode.eAVEncMPACodingMode_Mono"]/*' />
    eAVEncMPACodingMode_Mono = 0,

    /// <include file='eAVEncMPACodingMode.xml' path='doc/member[@name="eAVEncMPACodingMode.eAVEncMPACodingMode_Stereo"]/*' />
    eAVEncMPACodingMode_Stereo = 1,

    /// <include file='eAVEncMPACodingMode.xml' path='doc/member[@name="eAVEncMPACodingMode.eAVEncMPACodingMode_DualChannel"]/*' />
    eAVEncMPACodingMode_DualChannel = 2,

    /// <include file='eAVEncMPACodingMode.xml' path='doc/member[@name="eAVEncMPACodingMode.eAVEncMPACodingMode_JointStereo"]/*' />
    eAVEncMPACodingMode_JointStereo = 3,

    /// <include file='eAVEncMPACodingMode.xml' path='doc/member[@name="eAVEncMPACodingMode.eAVEncMPACodingMode_Surround"]/*' />
    eAVEncMPACodingMode_Surround = 4,
}
