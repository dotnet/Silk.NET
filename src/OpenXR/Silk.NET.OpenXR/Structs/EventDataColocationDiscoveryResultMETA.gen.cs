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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEventDataColocationDiscoveryResultMETA")]
    public unsafe partial struct EventDataColocationDiscoveryResultMETA
    {
        public EventDataColocationDiscoveryResultMETA
        (
            StructureType? type = StructureType.TypeEventDataColocationDiscoveryResultMeta,
            void* next = null,
            ulong? discoveryRequestId = null,
            Uuid? advertisementUuid = null,
            uint? bufferSize = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (discoveryRequestId is not null)
            {
                DiscoveryRequestId = discoveryRequestId.Value;
            }

            if (advertisementUuid is not null)
            {
                AdvertisementUuid = advertisementUuid.Value;
            }

            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrAsyncRequestIdFB")]
        [NativeName("Type.Name", "XrAsyncRequestIdFB")]
        [NativeName("Name", "discoveryRequestId")]
        public ulong DiscoveryRequestId;
/// <summary></summary>
        [NativeName("Type", "XrUuid")]
        [NativeName("Type.Name", "XrUuid")]
        [NativeName("Name", "advertisementUuid")]
        public Uuid AdvertisementUuid;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferSize")]
        public uint BufferSize;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "buffer")]
        public fixed byte Buffer[1024];
    }
}
