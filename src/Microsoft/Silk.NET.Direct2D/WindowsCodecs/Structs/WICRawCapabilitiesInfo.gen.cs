// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawCapabilitiesInfo")]
    public unsafe partial struct WICRawCapabilitiesInfo
    {
        public WICRawCapabilitiesInfo
        (
            uint? cbSize = null,
            uint? codecMajorVersion = null,
            uint? codecMinorVersion = null,
            WICRawCapabilities? exposureCompensationSupport = null,
            WICRawCapabilities? contrastSupport = null,
            WICRawCapabilities? rGBWhitePointSupport = null,
            WICRawCapabilities? namedWhitePointSupport = null,
            uint? namedWhitePointSupportMask = null,
            WICRawCapabilities? kelvinWhitePointSupport = null,
            WICRawCapabilities? gammaSupport = null,
            WICRawCapabilities? tintSupport = null,
            WICRawCapabilities? saturationSupport = null,
            WICRawCapabilities? sharpnessSupport = null,
            WICRawCapabilities? noiseReductionSupport = null,
            WICRawCapabilities? destinationColorProfileSupport = null,
            WICRawCapabilities? toneCurveSupport = null,
            WICRawRotationCapabilities? rotationSupport = null,
            WICRawCapabilities? renderModeSupport = null
        ) : this()
        {
            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (codecMajorVersion is not null)
            {
                CodecMajorVersion = codecMajorVersion.Value;
            }

            if (codecMinorVersion is not null)
            {
                CodecMinorVersion = codecMinorVersion.Value;
            }

            if (exposureCompensationSupport is not null)
            {
                ExposureCompensationSupport = exposureCompensationSupport.Value;
            }

            if (contrastSupport is not null)
            {
                ContrastSupport = contrastSupport.Value;
            }

            if (rGBWhitePointSupport is not null)
            {
                RGBWhitePointSupport = rGBWhitePointSupport.Value;
            }

            if (namedWhitePointSupport is not null)
            {
                NamedWhitePointSupport = namedWhitePointSupport.Value;
            }

            if (namedWhitePointSupportMask is not null)
            {
                NamedWhitePointSupportMask = namedWhitePointSupportMask.Value;
            }

            if (kelvinWhitePointSupport is not null)
            {
                KelvinWhitePointSupport = kelvinWhitePointSupport.Value;
            }

            if (gammaSupport is not null)
            {
                GammaSupport = gammaSupport.Value;
            }

            if (tintSupport is not null)
            {
                TintSupport = tintSupport.Value;
            }

            if (saturationSupport is not null)
            {
                SaturationSupport = saturationSupport.Value;
            }

            if (sharpnessSupport is not null)
            {
                SharpnessSupport = sharpnessSupport.Value;
            }

            if (noiseReductionSupport is not null)
            {
                NoiseReductionSupport = noiseReductionSupport.Value;
            }

            if (destinationColorProfileSupport is not null)
            {
                DestinationColorProfileSupport = destinationColorProfileSupport.Value;
            }

            if (toneCurveSupport is not null)
            {
                ToneCurveSupport = toneCurveSupport.Value;
            }

            if (rotationSupport is not null)
            {
                RotationSupport = rotationSupport.Value;
            }

            if (renderModeSupport is not null)
            {
                RenderModeSupport = renderModeSupport.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cbSize")]
        public uint CbSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CodecMajorVersion")]
        public uint CodecMajorVersion;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CodecMinorVersion")]
        public uint CodecMinorVersion;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "ExposureCompensationSupport")]
        public WICRawCapabilities ExposureCompensationSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "ContrastSupport")]
        public WICRawCapabilities ContrastSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "RGBWhitePointSupport")]
        public WICRawCapabilities RGBWhitePointSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "NamedWhitePointSupport")]
        public WICRawCapabilities NamedWhitePointSupport;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NamedWhitePointSupportMask")]
        public uint NamedWhitePointSupportMask;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "KelvinWhitePointSupport")]
        public WICRawCapabilities KelvinWhitePointSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "GammaSupport")]
        public WICRawCapabilities GammaSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "TintSupport")]
        public WICRawCapabilities TintSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "SaturationSupport")]
        public WICRawCapabilities SaturationSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "SharpnessSupport")]
        public WICRawCapabilities SharpnessSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "NoiseReductionSupport")]
        public WICRawCapabilities NoiseReductionSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "DestinationColorProfileSupport")]
        public WICRawCapabilities DestinationColorProfileSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "ToneCurveSupport")]
        public WICRawCapabilities ToneCurveSupport;

        [NativeName("Type", "WICRawRotationCapabilities")]
        [NativeName("Type.Name", "WICRawRotationCapabilities")]
        [NativeName("Name", "RotationSupport")]
        public WICRawRotationCapabilities RotationSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "RenderModeSupport")]
        public WICRawCapabilities RenderModeSupport;
    }
}
