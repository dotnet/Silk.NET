// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TYPE")]
    public enum RequestDestinationType : ulong
    {
        [Obsolete("Deprecated in favour of \"Memory\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_MEMORY")]
        RequestDestinationMemory = 0x0,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_BUFFER")]
        RequestDestinationBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"TextureRegion\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TEXTURE_REGION")]
        RequestDestinationTextureRegion = 0x2,
        [Obsolete("Deprecated in favour of \"MultipleSubresources\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_MULTIPLE_SUBRESOURCES")]
        RequestDestinationMultipleSubresources = 0x3,
        [Obsolete("Deprecated in favour of \"Tiles\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TILES")]
        RequestDestinationTiles = 0x4,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_MEMORY")]
        Memory = 0x0,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_BUFFER")]
        Buffer = 0x1,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TEXTURE_REGION")]
        TextureRegion = 0x2,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_MULTIPLE_SUBRESOURCES")]
        MultipleSubresources = 0x3,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TILES")]
        Tiles = 0x4,
    }
}
