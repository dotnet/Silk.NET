// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WICJpegFrameHeader
{
    public uint Width;
    public uint Height;
    public WICJpegTransferMatrix TransferMatrix;
    public WICJpegScanType ScanType;
    public uint cComponents;

    [NativeTypeName("DWORD")]
    public uint ComponentIdentifiers;

    [NativeTypeName("DWORD")]
    public uint SampleFactors;

    [NativeTypeName("DWORD")]
    public uint QuantizationTableIndices;
}
