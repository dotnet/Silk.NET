// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo"]/*' />
public partial struct WICRawCapabilitiesInfo
{
    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.cbSize"]/*' />
    public uint cbSize;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.CodecMajorVersion"]/*' />
    public uint CodecMajorVersion;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.CodecMinorVersion"]/*' />
    public uint CodecMinorVersion;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.ExposureCompensationSupport"]/*' />
    public WICRawCapabilities ExposureCompensationSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.ContrastSupport"]/*' />
    public WICRawCapabilities ContrastSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.RGBWhitePointSupport"]/*' />
    public WICRawCapabilities RGBWhitePointSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.NamedWhitePointSupport"]/*' />
    public WICRawCapabilities NamedWhitePointSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.NamedWhitePointSupportMask"]/*' />
    public uint NamedWhitePointSupportMask;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.KelvinWhitePointSupport"]/*' />
    public WICRawCapabilities KelvinWhitePointSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.GammaSupport"]/*' />
    public WICRawCapabilities GammaSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.TintSupport"]/*' />
    public WICRawCapabilities TintSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.SaturationSupport"]/*' />
    public WICRawCapabilities SaturationSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.SharpnessSupport"]/*' />
    public WICRawCapabilities SharpnessSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.NoiseReductionSupport"]/*' />
    public WICRawCapabilities NoiseReductionSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.DestinationColorProfileSupport"]/*' />
    public WICRawCapabilities DestinationColorProfileSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.ToneCurveSupport"]/*' />
    public WICRawCapabilities ToneCurveSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.RotationSupport"]/*' />
    public WICRawRotationCapabilities RotationSupport;

    /// <include file='WICRawCapabilitiesInfo.xml' path='doc/member[@name="WICRawCapabilitiesInfo.RenderModeSupport"]/*' />
    public WICRawCapabilities RenderModeSupport;
}
