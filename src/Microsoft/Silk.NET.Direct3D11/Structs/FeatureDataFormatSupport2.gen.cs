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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_FORMAT_SUPPORT2")]
    public unsafe partial struct FeatureDataFormatSupport2
    {
        public FeatureDataFormatSupport2
        (
            DXGI_FORMAT inFormat = default,
            uint outFormatSupport2 = default
        )
        {
            InFormat = inFormat;
            OutFormatSupport2 = outFormatSupport2;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InFormat")]
        public DXGI_FORMAT InFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutFormatSupport2")]
        public uint OutFormatSupport2;
    }
}
