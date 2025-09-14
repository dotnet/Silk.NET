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
    [NativeName("Name", "XrRaycastHitResultsANDROID")]
    public unsafe partial struct RaycastHitResultsANDROID
    {
        public RaycastHitResultsANDROID
        (
            StructureType? type = StructureType.TypeRaycastHitResultsAndroid,
            void* next = null,
            uint? resultsCapacityInput = null,
            uint? resultsCountOutput = null,
            RaycastHitResultANDROID* results = null
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

            if (resultsCapacityInput is not null)
            {
                ResultsCapacityInput = resultsCapacityInput.Value;
            }

            if (resultsCountOutput is not null)
            {
                ResultsCountOutput = resultsCountOutput.Value;
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
        [NativeName("Name", "resultsCapacityInput")]
        public uint ResultsCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "resultsCountOutput")]
        public uint ResultsCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrRaycastHitResultANDROID*")]
        [NativeName("Type.Name", "XrRaycastHitResultANDROID")]
        [NativeName("Name", "results")]
        public RaycastHitResultANDROID* Results;
    }
}
