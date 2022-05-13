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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_queue_family_properties_intel")]
    public unsafe partial struct QueueFamilyPropertiesIntel
    {
        public QueueFamilyPropertiesIntel
        (
            CommandQueueProperties? properties = null,
            CommandQueueCapabilities? capabilities = null,
            uint? count = null
        ) : this()
        {
            if (properties is not null)
            {
                Properties = properties.Value;
            }

            if (capabilities is not null)
            {
                Capabilities = capabilities.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_command_queue_properties")]
        [NativeName("Type.Name", "cl_command_queue_properties")]
        [NativeName("Name", "properties")]
        public CommandQueueProperties Properties;
/// <summary></summary>
        [NativeName("Type", "cl_command_queue_capabilities_intel")]
        [NativeName("Type.Name", "cl_command_queue_capabilities_intel")]
        [NativeName("Name", "capabilities")]
        public CommandQueueCapabilities Capabilities;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "count")]
        public uint Count;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[64];
    }
}
