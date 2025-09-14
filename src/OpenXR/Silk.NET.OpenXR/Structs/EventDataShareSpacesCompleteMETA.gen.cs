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
    [NativeName("Name", "XrEventDataShareSpacesCompleteMETA")]
    public unsafe partial struct EventDataShareSpacesCompleteMETA
    {
        public EventDataShareSpacesCompleteMETA
        (
            StructureType? type = StructureType.TypeEventDataShareSpacesCompleteMeta,
            void* next = null,
            ulong? requestId = null,
            Result? result = null
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

            if (requestId is not null)
            {
                RequestId = requestId.Value;
            }

            if (result is not null)
            {
                Result = result.Value;
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
        [NativeName("Name", "requestId")]
        public ulong RequestId;
/// <summary></summary>
        [NativeName("Type", "XrResult")]
        [NativeName("Type.Name", "XrResult")]
        [NativeName("Name", "result")]
        public Result Result;
    }
}
