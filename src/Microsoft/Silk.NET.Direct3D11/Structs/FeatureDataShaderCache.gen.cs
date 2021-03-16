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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_SHADER_CACHE")]
    public unsafe partial struct FeatureDataShaderCache
    {
        public FeatureDataShaderCache
        (
            uint? supportFlags = null
        ) : this()
        {
            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SupportFlags")]
        public uint SupportFlags;
    }
}
