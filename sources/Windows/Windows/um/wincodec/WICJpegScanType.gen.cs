// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICJpegScanType.xml' path='doc/member[@name="WICJpegScanType"]/*'/>
public enum WICJpegScanType
{
    /// <include file='WICJpegScanType.xml' path='doc/member[@name="WICJpegScanType.WICJpegScanTypeInterleaved"]/*'/>
    WICJpegScanTypeInterleaved = 0,
    /// <include file='WICJpegScanType.xml' path='doc/member[@name="WICJpegScanType.WICJpegScanTypePlanarComponents"]/*'/>
    WICJpegScanTypePlanarComponents = 0x1,
    /// <include file='WICJpegScanType.xml' path='doc/member[@name="WICJpegScanType.WICJpegScanTypeProgressive"]/*'/>
    WICJpegScanTypeProgressive = 0x2,
    /// <include file='WICJpegScanType.xml' path='doc/member[@name="WICJpegScanType.WICJpegScanType_FORCE_DWORD"]/*'/>
    WICJpegScanType_FORCE_DWORD = 0x7fffffff,
}