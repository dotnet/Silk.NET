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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_TYPOGRAPHIC_FEATURES")]
    public unsafe partial struct TypographicFeatures
    {
        public TypographicFeatures
        (
            FontFeature* features = null,
            uint? featureCount = null
        ) : this()
        {
            if (features is not null)
            {
                Features = features;
            }

            if (featureCount is not null)
            {
                FeatureCount = featureCount.Value;
            }
        }


        [NativeName("Type", "DWRITE_FONT_FEATURE *")]
        [NativeName("Type.Name", "DWRITE_FONT_FEATURE *")]
        [NativeName("Name", "features")]
        public FontFeature* Features;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "featureCount")]
        public uint FeatureCount;
    }
}
