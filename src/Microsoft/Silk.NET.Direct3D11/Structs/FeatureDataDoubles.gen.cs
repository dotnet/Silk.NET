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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_DOUBLES")]
    public unsafe partial struct FeatureDataDoubles
    {
        public FeatureDataDoubles
        (
            int? doublePrecisionFloatShaderOps = null
        ) : this()
        {
            if (doublePrecisionFloatShaderOps is not null)
            {
                DoublePrecisionFloatShaderOps = doublePrecisionFloatShaderOps.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DoublePrecisionFloatShaderOps")]
        public int DoublePrecisionFloatShaderOps;
    }
}
