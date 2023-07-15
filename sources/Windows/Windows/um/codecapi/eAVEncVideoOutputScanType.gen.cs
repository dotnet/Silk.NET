// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVEncVideoOutputScanType.xml' path='doc/member[@name="eAVEncVideoOutputScanType"]/*'/>
public enum eAVEncVideoOutputScanType
{
    /// <include file='eAVEncVideoOutputScanType.xml' path='doc/member[@name="eAVEncVideoOutputScanType.eAVEncVideoOutputScan_Progressive"]/*'/>
    eAVEncVideoOutputScan_Progressive = 0,
    /// <include file='eAVEncVideoOutputScanType.xml' path='doc/member[@name="eAVEncVideoOutputScanType.eAVEncVideoOutputScan_Interlaced"]/*'/>
    eAVEncVideoOutputScan_Interlaced = 1,
    /// <include file='eAVEncVideoOutputScanType.xml' path='doc/member[@name="eAVEncVideoOutputScanType.eAVEncVideoOutputScan_SameAsInput"]/*'/>
    eAVEncVideoOutputScan_SameAsInput = 2,
    /// <include file='eAVEncVideoOutputScanType.xml' path='doc/member[@name="eAVEncVideoOutputScanType.eAVEncVideoOutputScan_Automatic"]/*'/>
    eAVEncVideoOutputScan_Automatic = 3,
}