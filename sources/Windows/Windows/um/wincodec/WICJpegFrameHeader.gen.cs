// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader"]/*'/>
public partial struct WICJpegFrameHeader
{
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.Width"]/*'/>
    public uint Width;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.Height"]/*'/>
    public uint Height;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.TransferMatrix"]/*'/>
    public WICJpegTransferMatrix TransferMatrix;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.ScanType"]/*'/>
    public WICJpegScanType ScanType;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.cComponents"]/*'/>
    public uint cComponents;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.ComponentIdentifiers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ComponentIdentifiers;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.SampleFactors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SampleFactors;
    /// <include file='WICJpegFrameHeader.xml' path='doc/member[@name="WICJpegFrameHeader.QuantizationTableIndices"]/*'/>
    [NativeTypeName("DWORD")]
    public uint QuantizationTableIndices;
}