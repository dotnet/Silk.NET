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
    [NativeName("Name", "D2D1_RESOURCE_TEXTURE_PROPERTIES")]
    public unsafe partial struct ResourceTextureProperties
    {
        public ResourceTextureProperties
        (
            uint* extents = null,
            uint? dimensions = null,
            BufferPrecision? bufferPrecision = null,
            ChannelDepth? channelDepth = null,
            Filter? filter = null,
            ExtendMode* extendModes = null
        ) : this()
        {
            if (extents is not null)
            {
                Extents = extents;
            }

            if (dimensions is not null)
            {
                Dimensions = dimensions.Value;
            }

            if (bufferPrecision is not null)
            {
                BufferPrecision = bufferPrecision.Value;
            }

            if (channelDepth is not null)
            {
                ChannelDepth = channelDepth.Value;
            }

            if (filter is not null)
            {
                Filter = filter.Value;
            }

            if (extendModes is not null)
            {
                ExtendModes = extendModes;
            }
        }


        [NativeName("Type", "const UINT32 *")]
        [NativeName("Type.Name", "const UINT32 *")]
        [NativeName("Name", "extents")]
        public uint* Extents;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "dimensions")]
        public uint Dimensions;

        [NativeName("Type", "D2D1_BUFFER_PRECISION")]
        [NativeName("Type.Name", "D2D1_BUFFER_PRECISION")]
        [NativeName("Name", "bufferPrecision")]
        public BufferPrecision BufferPrecision;

        [NativeName("Type", "D2D1_CHANNEL_DEPTH")]
        [NativeName("Type.Name", "D2D1_CHANNEL_DEPTH")]
        [NativeName("Name", "channelDepth")]
        public ChannelDepth ChannelDepth;

        [NativeName("Type", "D2D1_FILTER")]
        [NativeName("Type.Name", "D2D1_FILTER")]
        [NativeName("Name", "filter")]
        public Filter Filter;

        [NativeName("Type", "const D2D1_EXTEND_MODE *")]
        [NativeName("Type.Name", "const D2D1_EXTEND_MODE *")]
        [NativeName("Name", "extendModes")]
        public ExtendMode* ExtendModes;
    }
}
