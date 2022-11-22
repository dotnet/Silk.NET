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
    [NativeName("Name", "D3D11_FEATURE_DATA_DISPLAYABLE")]
    public unsafe partial struct FeatureDataDisplayable
    {
        public FeatureDataDisplayable
        (
            Silk.NET.Core.Bool32? displayableTexture = null,
            SharedResourceTier? sharedResourceTier = null
        ) : this()
        {
            if (displayableTexture is not null)
            {
                DisplayableTexture = displayableTexture.Value;
            }

            if (sharedResourceTier is not null)
            {
                SharedResourceTier = sharedResourceTier.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DisplayableTexture")]
        public Silk.NET.Core.Bool32 DisplayableTexture;

        [NativeName("Type", "D3D11_SHARED_RESOURCE_TIER")]
        [NativeName("Type.Name", "D3D11_SHARED_RESOURCE_TIER")]
        [NativeName("Name", "SharedResourceTier")]
        public SharedResourceTier SharedResourceTier;
    }
}
