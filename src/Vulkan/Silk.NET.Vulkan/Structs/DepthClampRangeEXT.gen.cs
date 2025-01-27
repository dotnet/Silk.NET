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
    [NativeName("Name", "VkDepthClampRangeEXT")]
    public unsafe partial struct DepthClampRangeEXT
    {
        public DepthClampRangeEXT
        (
            float? minDepthClamp = null,
            float? maxDepthClamp = null
        ) : this()
        {
            if (minDepthClamp is not null)
            {
                MinDepthClamp = minDepthClamp.Value;
            }

            if (maxDepthClamp is not null)
            {
                MaxDepthClamp = maxDepthClamp.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minDepthClamp")]
        public float MinDepthClamp;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxDepthClamp")]
        public float MaxDepthClamp;
    }
}
