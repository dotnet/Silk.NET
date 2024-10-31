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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVertexInputBindingDivisorDescriptionKHR")]
    [NativeName("Aliases", "VkVertexInputBindingDivisorDescriptionEXT")]
    public unsafe partial struct VertexInputBindingDivisorDescriptionKHR
    {
        public VertexInputBindingDivisorDescriptionKHR
        (
            uint? binding = null,
            uint? divisor = null
        ) : this()
        {
            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (divisor is not null)
            {
                Divisor = divisor.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "divisor")]
        public uint Divisor;
    }
}
