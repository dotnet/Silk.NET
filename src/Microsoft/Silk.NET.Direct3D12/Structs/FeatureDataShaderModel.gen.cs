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
    [NativeName("Name", "D3D12_FEATURE_DATA_SHADER_MODEL")]
    public unsafe partial struct FeatureDataShaderModel
    {
        public FeatureDataShaderModel
        (
            D3DShaderModel? highestShaderModel = null
        ) : this()
        {
            if (highestShaderModel is not null)
            {
                HighestShaderModel = highestShaderModel.Value;
            }
        }


        [NativeName("Type", "D3D_SHADER_MODEL")]
        [NativeName("Type.Name", "D3D_SHADER_MODEL")]
        [NativeName("Name", "HighestShaderModel")]
        public D3DShaderModel HighestShaderModel;
    }
}
