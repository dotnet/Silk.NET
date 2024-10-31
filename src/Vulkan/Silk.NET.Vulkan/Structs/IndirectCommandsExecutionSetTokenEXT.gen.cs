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
    [NativeName("Name", "VkIndirectCommandsExecutionSetTokenEXT")]
    public unsafe partial struct IndirectCommandsExecutionSetTokenEXT
    {
        public IndirectCommandsExecutionSetTokenEXT
        (
            IndirectExecutionSetInfoTypeEXT? type = null,
            ShaderStageFlags? shaderStages = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (shaderStages is not null)
            {
                ShaderStages = shaderStages.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkIndirectExecutionSetInfoTypeEXT")]
        [NativeName("Type.Name", "VkIndirectExecutionSetInfoTypeEXT")]
        [NativeName("Name", "type")]
        public IndirectExecutionSetInfoTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "shaderStages")]
        public ShaderStageFlags ShaderStages;
    }
}
