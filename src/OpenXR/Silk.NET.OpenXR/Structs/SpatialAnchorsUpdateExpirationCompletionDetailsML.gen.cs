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
    [NativeName("Name", "XrSpatialAnchorsUpdateExpirationCompletionDetailsML")]
    public unsafe partial struct SpatialAnchorsUpdateExpirationCompletionDetailsML
    {
        public SpatialAnchorsUpdateExpirationCompletionDetailsML
        (
            StructureType? type = StructureType.TypeSpatialAnchorsUpdateExpirationCompletionDetailsML,
            void* next = null,
            uint? resultCount = null,
            SpatialAnchorCompletionResultML* results = null
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

            if (resultCount is not null)
            {
                ResultCount = resultCount.Value;
            }

            if (results is not null)
            {
                Results = results;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "resultCount")]
        public uint ResultCount;
/// <summary></summary>
        [NativeName("Type", "XrSpatialAnchorCompletionResultML*")]
        [NativeName("Type.Name", "XrSpatialAnchorCompletionResultML")]
        [NativeName("Name", "results")]
        public SpatialAnchorCompletionResultML* Results;
    }
}
