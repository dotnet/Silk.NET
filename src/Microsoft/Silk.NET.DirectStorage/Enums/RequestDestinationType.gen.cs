// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TYPE")]
    public enum RequestDestinationType : ulong
    {
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_MEMORY")]
        RequestDestinationMemory = 0x0,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_BUFFER")]
        RequestDestinationBuffer = 0x1,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TEXTURE_REGION")]
        RequestDestinationTextureRegion = 0x2,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_MULTIPLE_SUBRESOURCES")]
        RequestDestinationMultipleSubresources = 0x3,
        [NativeName("Name", "DSTORAGE_REQUEST_DESTINATION_TILES")]
        RequestDestinationTiles = 0x4,
    }
}
