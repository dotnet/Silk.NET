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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS18")]
    public unsafe partial struct FeatureDataD3D12Options18
    {
        public FeatureDataD3D12Options18
        (
            Silk.NET.Core.Bool32? renderPassesValid = null
        ) : this()
        {
            if (renderPassesValid is not null)
            {
                RenderPassesValid = renderPassesValid.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "RenderPassesValid")]
        public Silk.NET.Core.Bool32 RenderPassesValid;
    }
}
