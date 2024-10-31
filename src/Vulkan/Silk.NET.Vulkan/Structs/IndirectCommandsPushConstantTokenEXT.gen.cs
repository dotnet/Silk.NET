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
    [NativeName("Name", "VkIndirectCommandsPushConstantTokenEXT")]
    public unsafe partial struct IndirectCommandsPushConstantTokenEXT
    {
        public IndirectCommandsPushConstantTokenEXT
        (
            PushConstantRange? updateRange = null
        ) : this()
        {
            if (updateRange is not null)
            {
                UpdateRange = updateRange.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPushConstantRange")]
        [NativeName("Type.Name", "VkPushConstantRange")]
        [NativeName("Name", "updateRange")]
        public PushConstantRange UpdateRange;
    }
}
