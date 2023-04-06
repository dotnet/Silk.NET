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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_FEATURE_DATA_DOUBLES")]
    public unsafe partial struct FeatureDataDoubles
    {
        public FeatureDataDoubles
        (
            Silk.NET.Core.Bool32? doublePrecisionFloatShaderOps = null
        ) : this()
        {
            if (doublePrecisionFloatShaderOps is not null)
            {
                DoublePrecisionFloatShaderOps = doublePrecisionFloatShaderOps.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "doublePrecisionFloatShaderOps")]
        public Silk.NET.Core.Bool32 DoublePrecisionFloatShaderOps;
    }
}
