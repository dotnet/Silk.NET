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
    [NativeName("Name", "XrEventDataStartColocationAdvertisementCompleteMETA")]
    public unsafe partial struct EventDataStartColocationAdvertisementCompleteMETA
    {
        public EventDataStartColocationAdvertisementCompleteMETA
        (
            StructureType? type = StructureType.TypeEventDataStartColocationAdvertisementCompleteMeta,
            void* next = null,
            ulong? advertisementRequestId = null,
            Result? result = null,
            Uuid? advertisementUuid = null
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

            if (advertisementRequestId is not null)
            {
                AdvertisementRequestId = advertisementRequestId.Value;
            }

            if (result is not null)
            {
                Result = result.Value;
            }

            if (advertisementUuid is not null)
            {
                AdvertisementUuid = advertisementUuid.Value;
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
        [NativeName("Name", "advertisementRequestId")]
        public ulong AdvertisementRequestId;
/// <summary></summary>
        [NativeName("Type", "XrResult")]
        [NativeName("Type.Name", "XrResult")]
        [NativeName("Name", "result")]
        public Result Result;
/// <summary></summary>
        [NativeName("Type", "XrUuid")]
        [NativeName("Type.Name", "XrUuid")]
        [NativeName("Name", "advertisementUuid")]
        public Uuid AdvertisementUuid;
    }
}
