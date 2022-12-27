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
    [NativeName("Name", "D2D1_BLEND_DESCRIPTION")]
    public unsafe partial struct BlendDescription
    {
        public BlendDescription
        (
            Blend? sourceBlend = null,
            Blend? destinationBlend = null,
            BlendOperation? blendOperation = null,
            Blend? sourceBlendAlpha = null,
            Blend? destinationBlendAlpha = null,
            BlendOperation? blendOperationAlpha = null
        ) : this()
        {
            if (sourceBlend is not null)
            {
                SourceBlend = sourceBlend.Value;
            }

            if (destinationBlend is not null)
            {
                DestinationBlend = destinationBlend.Value;
            }

            if (blendOperation is not null)
            {
                BlendOperation = blendOperation.Value;
            }

            if (sourceBlendAlpha is not null)
            {
                SourceBlendAlpha = sourceBlendAlpha.Value;
            }

            if (destinationBlendAlpha is not null)
            {
                DestinationBlendAlpha = destinationBlendAlpha.Value;
            }

            if (blendOperationAlpha is not null)
            {
                BlendOperationAlpha = blendOperationAlpha.Value;
            }
        }


        [NativeName("Type", "D2D1_BLEND")]
        [NativeName("Type.Name", "D2D1_BLEND")]
        [NativeName("Name", "sourceBlend")]
        public Blend SourceBlend;

        [NativeName("Type", "D2D1_BLEND")]
        [NativeName("Type.Name", "D2D1_BLEND")]
        [NativeName("Name", "destinationBlend")]
        public Blend DestinationBlend;

        [NativeName("Type", "D2D1_BLEND_OPERATION")]
        [NativeName("Type.Name", "D2D1_BLEND_OPERATION")]
        [NativeName("Name", "blendOperation")]
        public BlendOperation BlendOperation;

        [NativeName("Type", "D2D1_BLEND")]
        [NativeName("Type.Name", "D2D1_BLEND")]
        [NativeName("Name", "sourceBlendAlpha")]
        public Blend SourceBlendAlpha;

        [NativeName("Type", "D2D1_BLEND")]
        [NativeName("Type.Name", "D2D1_BLEND")]
        [NativeName("Name", "destinationBlendAlpha")]
        public Blend DestinationBlendAlpha;

        [NativeName("Type", "D2D1_BLEND_OPERATION")]
        [NativeName("Type.Name", "D2D1_BLEND_OPERATION")]
        [NativeName("Name", "blendOperationAlpha")]
        public BlendOperation BlendOperationAlpha;
        [NativeName("Type", "FLOAT[4]")]
        [NativeName("Type.Name", "FLOAT[4]")]
        [NativeName("Name", "blendFactor")]
        public fixed float BlendFactor[4];
    }
}
