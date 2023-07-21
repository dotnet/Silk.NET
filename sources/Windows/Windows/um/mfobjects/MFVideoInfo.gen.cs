// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo"]/*' />
public partial struct MFVideoInfo
{
    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.dwWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwWidth;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.dwHeight"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHeight;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.PixelAspectRatio"]/*' />
    public MFRatio PixelAspectRatio;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.SourceChromaSubsampling"]/*' />
    public MFVideoChromaSubsampling SourceChromaSubsampling;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.InterlaceMode"]/*' />
    public MFVideoInterlaceMode InterlaceMode;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.TransferFunction"]/*' />
    public MFVideoTransferFunction TransferFunction;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.ColorPrimaries"]/*' />
    public MFVideoPrimaries ColorPrimaries;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.TransferMatrix"]/*' />
    public MFVideoTransferMatrix TransferMatrix;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.SourceLighting"]/*' />
    public MFVideoLighting SourceLighting;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.FramesPerSecond"]/*' />
    public MFRatio FramesPerSecond;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.NominalRange"]/*' />
    public MFNominalRange NominalRange;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.GeometricAperture"]/*' />
    public MFVideoArea GeometricAperture;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.MinimumDisplayAperture"]/*' />
    public MFVideoArea MinimumDisplayAperture;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.PanScanAperture"]/*' />
    public MFVideoArea PanScanAperture;

    /// <include file='MFVideoInfo.xml' path='doc/member[@name="MFVideoInfo.VideoFlags"]/*' />
    [NativeTypeName("unsigned long long")]
    public ulong VideoFlags;
}
