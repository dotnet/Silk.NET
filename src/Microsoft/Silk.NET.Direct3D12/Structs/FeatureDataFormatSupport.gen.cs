// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            Silk.NET.DXGI.Format format = default,
            FormatSupport1 support1 = default,
            FormatSupport2 support2 = default
        )
        {
            Format = format;
            Support1 = support1;
            Support2 = support2;
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
