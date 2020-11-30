// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS4")]
    public unsafe partial struct FeatureDataD3D11Options4
    {
        public FeatureDataD3D11Options4
        (
            int? extendedNV12SharedTextureSupported = null
        ) : this()
        {
            if (extendedNV12SharedTextureSupported is not null)
            {
                ExtendedNV12SharedTextureSupported = extendedNV12SharedTextureSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedNV12SharedTextureSupported")]
        public int ExtendedNV12SharedTextureSupported;
    }
}
