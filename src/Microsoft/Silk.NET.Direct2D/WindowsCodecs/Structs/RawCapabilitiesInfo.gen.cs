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
    public unsafe partial struct RawCapabilitiesInfo
    {
        public RawCapabilitiesInfo
        (
            uint? cbSize = null,
            uint? codecMajorVersion = null,
            uint? codecMinorVersion = null,
            RawCapabilities? exposureCompensationSupport = null,
            RawCapabilities? contrastSupport = null,
            RawCapabilities? rGBWhitePointSupport = null,
            RawCapabilities? namedWhitePointSupport = null,
            uint? namedWhitePointSupportMask = null,
            RawCapabilities? kelvinWhitePointSupport = null,
            RawCapabilities? gammaSupport = null,
            RawCapabilities? tintSupport = null,
            RawCapabilities? saturationSupport = null,
            RawCapabilities? sharpnessSupport = null,
            RawCapabilities? noiseReductionSupport = null,
            RawCapabilities? destinationColorProfileSupport = null,
            RawCapabilities? toneCurveSupport = null,
            RawRotationCapabilities? rotationSupport = null,
            RawCapabilities? renderModeSupport = null
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
        public RawCapabilities ExposureCompensationSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "ContrastSupport")]
        public RawCapabilities ContrastSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "RGBWhitePointSupport")]
        public RawCapabilities RGBWhitePointSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "NamedWhitePointSupport")]
        public RawCapabilities NamedWhitePointSupport;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NamedWhitePointSupportMask")]
        public uint NamedWhitePointSupportMask;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "KelvinWhitePointSupport")]
        public RawCapabilities KelvinWhitePointSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "GammaSupport")]
        public RawCapabilities GammaSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "TintSupport")]
        public RawCapabilities TintSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "SaturationSupport")]
        public RawCapabilities SaturationSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "SharpnessSupport")]
        public RawCapabilities SharpnessSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "NoiseReductionSupport")]
        public RawCapabilities NoiseReductionSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "DestinationColorProfileSupport")]
        public RawCapabilities DestinationColorProfileSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "ToneCurveSupport")]
        public RawCapabilities ToneCurveSupport;

        [NativeName("Type", "WICRawRotationCapabilities")]
        [NativeName("Type.Name", "WICRawRotationCapabilities")]
        [NativeName("Name", "RotationSupport")]
        public RawRotationCapabilities RotationSupport;

        [NativeName("Type", "WICRawCapabilities")]
        [NativeName("Type.Name", "WICRawCapabilities")]
        [NativeName("Name", "RenderModeSupport")]
        public RawCapabilities RenderModeSupport;
    }
}
