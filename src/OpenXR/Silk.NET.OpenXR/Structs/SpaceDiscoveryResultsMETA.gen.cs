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
    [NativeName("Name", "XrSpaceDiscoveryResultsMETA")]
    public unsafe partial struct SpaceDiscoveryResultsMETA
    {
        public SpaceDiscoveryResultsMETA
        (
            StructureType? type = StructureType.TypeSpaceDiscoveryResultsMeta,
            void* next = null,
            uint? resultCapacityInput = null,
            uint? resultCountOutput = null,
            SpaceDiscoveryResultMETA* results = null
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

            if (resultCapacityInput is not null)
            {
                ResultCapacityInput = resultCapacityInput.Value;
            }

            if (resultCountOutput is not null)
            {
                ResultCountOutput = resultCountOutput.Value;
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
        [NativeName("Name", "resultCapacityInput")]
        public uint ResultCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "resultCountOutput")]
        public uint ResultCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrSpaceDiscoveryResultMETA*")]
        [NativeName("Type.Name", "XrSpaceDiscoveryResultMETA")]
        [NativeName("Name", "results")]
        public SpaceDiscoveryResultMETA* Results;
    }
}
