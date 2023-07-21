// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVDecVideoInputScanType.xml' path='doc/member[@name="eAVDecVideoInputScanType"]/*' />
public enum eAVDecVideoInputScanType
{
    /// <include file='eAVDecVideoInputScanType.xml' path='doc/member[@name="eAVDecVideoInputScanType.eAVDecVideoInputScan_Unknown"]/*' />
    eAVDecVideoInputScan_Unknown = 0,

    /// <include file='eAVDecVideoInputScanType.xml' path='doc/member[@name="eAVDecVideoInputScanType.eAVDecVideoInputScan_Progressive"]/*' />
    eAVDecVideoInputScan_Progressive = 1,

    /// <include file='eAVDecVideoInputScanType.xml' path='doc/member[@name="eAVDecVideoInputScanType.eAVDecVideoInputScan_Interlaced_UpperFieldFirst"]/*' />
    eAVDecVideoInputScan_Interlaced_UpperFieldFirst = 2,

    /// <include file='eAVDecVideoInputScanType.xml' path='doc/member[@name="eAVDecVideoInputScanType.eAVDecVideoInputScan_Interlaced_LowerFieldFirst"]/*' />
    eAVDecVideoInputScan_Interlaced_LowerFieldFirst = 3,
}
