// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVEncVideoSourceScanType.xml' path='doc/member[@name="eAVEncVideoSourceScanType"]/*'/>
public enum eAVEncVideoSourceScanType
{
    /// <include file='eAVEncVideoSourceScanType.xml' path='doc/member[@name="eAVEncVideoSourceScanType.eAVEncVideoSourceScan_Automatic"]/*'/>
    eAVEncVideoSourceScan_Automatic = 0,
    /// <include file='eAVEncVideoSourceScanType.xml' path='doc/member[@name="eAVEncVideoSourceScanType.eAVEncVideoSourceScan_Interlaced"]/*'/>
    eAVEncVideoSourceScan_Interlaced = 1,
    /// <include file='eAVEncVideoSourceScanType.xml' path='doc/member[@name="eAVEncVideoSourceScanType.eAVEncVideoSourceScan_Progressive"]/*'/>
    eAVEncVideoSourceScan_Progressive = 2,
}