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
    [NativeName("Name", "XrSpaceQueryInfoFB")]
    public unsafe partial struct SpaceQueryInfoFB
    {
        public SpaceQueryInfoFB
        (
            StructureType? type = StructureType.TypeSpaceQueryInfoFB,
            void* next = null,
            SpaceQueryActionFB? queryAction = null,
            uint? maxResultCount = null,
            long? timeout = null,
            SpaceFilterInfoBaseHeaderFB* filter = null,
            SpaceFilterInfoBaseHeaderFB* excludeFilter = null
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

            if (queryAction is not null)
            {
                QueryAction = queryAction.Value;
            }

            if (maxResultCount is not null)
            {
                MaxResultCount = maxResultCount.Value;
            }

            if (timeout is not null)
            {
                Timeout = timeout.Value;
            }

            if (filter is not null)
            {
                Filter = filter;
            }

            if (excludeFilter is not null)
            {
                ExcludeFilter = excludeFilter;
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
        [NativeName("Type", "XrSpaceQueryActionFB")]
        [NativeName("Type.Name", "XrSpaceQueryActionFB")]
        [NativeName("Name", "queryAction")]
        public SpaceQueryActionFB QueryAction;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxResultCount")]
        public uint MaxResultCount;
/// <summary></summary>
        [NativeName("Type", "XrDuration")]
        [NativeName("Type.Name", "XrDuration")]
        [NativeName("Name", "timeout")]
        public long Timeout;
/// <summary></summary>
        [NativeName("Type", "XrSpaceFilterInfoBaseHeaderFB*")]
        [NativeName("Type.Name", "XrSpaceFilterInfoBaseHeaderFB")]
        [NativeName("Name", "filter")]
        public SpaceFilterInfoBaseHeaderFB* Filter;
/// <summary></summary>
        [NativeName("Type", "XrSpaceFilterInfoBaseHeaderFB*")]
        [NativeName("Type.Name", "XrSpaceFilterInfoBaseHeaderFB")]
        [NativeName("Name", "excludeFilter")]
        public SpaceFilterInfoBaseHeaderFB* ExcludeFilter;
    }
}
