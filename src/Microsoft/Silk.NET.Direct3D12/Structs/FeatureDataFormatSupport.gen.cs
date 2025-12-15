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
    [NativeName("Name", "D3D12_FEATURE_DATA_FORMAT_SUPPORT")]
    public unsafe partial struct FeatureDataFormatSupport
    {
        public FeatureDataFormatSupport
        (
            Silk.NET.DXGI.Format? format = null,
            FormatSupport1? support1 = null,
            FormatSupport2? support2 = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (support1 is not null)
            {
                Support1 = support1.Value;
            }

            if (support2 is not null)
            {
                Support2 = support2.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D12_FORMAT_SUPPORT1")]
        [NativeName("Type.Name", "D3D12_FORMAT_SUPPORT1")]
        [NativeName("Name", "Support1")]
        public FormatSupport1 Support1;

        [NativeName("Type", "D3D12_FORMAT_SUPPORT2")]
        [NativeName("Type.Name", "D3D12_FORMAT_SUPPORT2")]
        [NativeName("Name", "Support2")]
        public FormatSupport2 Support2;
    }
}
