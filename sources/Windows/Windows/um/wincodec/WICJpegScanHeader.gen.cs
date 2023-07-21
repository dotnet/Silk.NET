// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader"]/*' />
public partial struct WICJpegScanHeader
{
    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.cComponents"]/*' />
    public uint cComponents;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.RestartInterval"]/*' />
    public uint RestartInterval;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.ComponentSelectors"]/*' />
    [NativeTypeName("DWORD")]
    public uint ComponentSelectors;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.HuffmanTableIndices"]/*' />
    [NativeTypeName("DWORD")]
    public uint HuffmanTableIndices;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.StartSpectralSelection"]/*' />
    public byte StartSpectralSelection;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.EndSpectralSelection"]/*' />
    public byte EndSpectralSelection;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.SuccessiveApproximationHigh"]/*' />
    public byte SuccessiveApproximationHigh;

    /// <include file='WICJpegScanHeader.xml' path='doc/member[@name="WICJpegScanHeader.SuccessiveApproximationLow"]/*' />
    public byte SuccessiveApproximationLow;
}
