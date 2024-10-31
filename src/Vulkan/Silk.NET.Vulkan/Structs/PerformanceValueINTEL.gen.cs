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
    [NativeName("Name", "VkPerformanceValueINTEL")]
    public unsafe partial struct PerformanceValueINTEL
    {
        public PerformanceValueINTEL
        (
            PerformanceValueTypeINTEL? type = null,
            PerformanceValueDataINTEL? data = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPerformanceValueTypeINTEL")]
        [NativeName("Type.Name", "VkPerformanceValueTypeINTEL")]
        [NativeName("Name", "type")]
        public PerformanceValueTypeINTEL Type;
/// <summary></summary>
        [NativeName("Type", "VkPerformanceValueDataINTEL")]
        [NativeName("Type.Name", "VkPerformanceValueDataINTEL")]
        [NativeName("Name", "data")]
        public PerformanceValueDataINTEL Data;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
