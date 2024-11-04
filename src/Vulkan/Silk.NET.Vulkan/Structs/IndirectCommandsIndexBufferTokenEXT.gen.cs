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
    [NativeName("Name", "VkIndirectCommandsIndexBufferTokenEXT")]
    public unsafe partial struct IndirectCommandsIndexBufferTokenEXT
    {
        public IndirectCommandsIndexBufferTokenEXT
        (
            IndirectCommandsInputModeFlagsEXT? mode = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsInputModeFlagBitsEXT")]
        [NativeName("Type.Name", "VkIndirectCommandsInputModeFlagBitsEXT")]
        [NativeName("Name", "mode")]
        public IndirectCommandsInputModeFlagsEXT Mode;
    }
}
