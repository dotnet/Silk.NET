// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_FORMAT_INFO")]
    public unsafe partial struct FeatureDataFormatInfo
    {
        public FeatureDataFormatInfo
        (
            Silk.NET.DXGI.Format? format = null,
            byte? planeCount = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (planeCount is not null)
            {
                PlaneCount = planeCount.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "PlaneCount")]
        public byte PlaneCount;
    }
}
