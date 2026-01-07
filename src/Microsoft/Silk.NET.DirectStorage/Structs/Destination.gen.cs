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

namespace Silk.NET.DirectStorage
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "DSTORAGE_DESTINATION")]
    public unsafe partial struct Destination
    {
        public Destination
        (
            DestinationMemory? memory = null,
            DestinationBuffer? buffer = null,
            DestinationTextureRegion? texture = null,
            DestinationMultipleSubresources? multipleSubresources = null,
            DestinationTiles? tiles = null,
            DestinationMultipleSubresourcesRange? multipleSubresourcesRange = null
        ) : this()
        {
            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (texture is not null)
            {
                Texture = texture.Value;
            }

            if (multipleSubresources is not null)
            {
                MultipleSubresources = multipleSubresources.Value;
            }

            if (tiles is not null)
            {
                Tiles = tiles.Value;
            }

            if (multipleSubresourcesRange is not null)
            {
                MultipleSubresourcesRange = multipleSubresourcesRange.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_DESTINATION_MEMORY")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION_MEMORY")]
        [NativeName("Name", "Memory")]
        public DestinationMemory Memory;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_DESTINATION_BUFFER")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION_BUFFER")]
        [NativeName("Name", "Buffer")]
        public DestinationBuffer Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_DESTINATION_TEXTURE_REGION")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION_TEXTURE_REGION")]
        [NativeName("Name", "Texture")]
        public DestinationTextureRegion Texture;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_DESTINATION_MULTIPLE_SUBRESOURCES")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION_MULTIPLE_SUBRESOURCES")]
        [NativeName("Name", "MultipleSubresources")]
        public DestinationMultipleSubresources MultipleSubresources;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_DESTINATION_TILES")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION_TILES")]
        [NativeName("Name", "Tiles")]
        public DestinationTiles Tiles;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_DESTINATION_MULTIPLE_SUBRESOURCES_RANGE")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION_MULTIPLE_SUBRESOURCES_RANGE")]
        [NativeName("Name", "MultipleSubresourcesRange")]
        public DestinationMultipleSubresourcesRange MultipleSubresourcesRange;
    }
}
