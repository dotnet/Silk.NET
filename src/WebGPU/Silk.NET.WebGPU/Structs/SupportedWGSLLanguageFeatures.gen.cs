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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSupportedWGSLLanguageFeatures")]
    public unsafe partial struct SupportedWGSLLanguageFeatures
    {
        public SupportedWGSLLanguageFeatures
        (
            nuint? featureCount = null,
            WGSLLanguageFeatureName* features = null
        ) : this()
        {
            if (featureCount is not null)
            {
                FeatureCount = featureCount.Value;
            }

            if (features is not null)
            {
                Features = features;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "featureCount")]
        public nuint FeatureCount;

        [NativeName("Type", "const WGPUWGSLLanguageFeatureName *")]
        [NativeName("Type.Name", "const WGPUWGSLLanguageFeatureName *")]
        [NativeName("Name", "features")]
        public WGSLLanguageFeatureName* Features;
    }
}
