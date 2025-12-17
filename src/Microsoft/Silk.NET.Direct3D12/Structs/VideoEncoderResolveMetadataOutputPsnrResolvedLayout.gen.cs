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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_PSNR_RESOLVED_LAYOUT")]
    public unsafe partial struct VideoEncoderResolveMetadataOutputPsnrResolvedLayout
    {
        public VideoEncoderResolveMetadataOutputPsnrResolvedLayout
        (
            float? pSNRY = null,
            float? pSNRU = null,
            float? pSNRV = null
        ) : this()
        {
            if (pSNRY is not null)
            {
                PSNRY = pSNRY.Value;
            }

            if (pSNRU is not null)
            {
                PSNRU = pSNRU.Value;
            }

            if (pSNRV is not null)
            {
                PSNRV = pSNRV.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "PSNRY")]
        public float PSNRY;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "PSNRU")]
        public float PSNRU;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "PSNRV")]
        public float PSNRV;
    }
}
