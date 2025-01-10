// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFVideoInfo
{
    [NativeTypeName("DWORD")]
    public uint dwWidth;

    [NativeTypeName("DWORD")]
    public uint dwHeight;
    public MFRatio PixelAspectRatio;
    public MFVideoChromaSubsampling SourceChromaSubsampling;
    public MFVideoInterlaceMode InterlaceMode;
    public MFVideoTransferFunction TransferFunction;
    public MFVideoPrimaries ColorPrimaries;
    public MFVideoTransferMatrix TransferMatrix;
    public MFVideoLighting SourceLighting;
    public MFRatio FramesPerSecond;
    public MFNominalRange NominalRange;
    public MFVideoArea GeometricAperture;
    public MFVideoArea MinimumDisplayAperture;
    public MFVideoArea PanScanAperture;

    [NativeTypeName("unsigned long long")]
    public ulong VideoFlags;
}
