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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkIndirectExecutionSetInfoEXT")]
    public unsafe partial struct IndirectExecutionSetInfoEXT
    {
        public IndirectExecutionSetInfoEXT
        (
            IndirectExecutionSetPipelineInfoEXT* pPipelineInfo = null,
            IndirectExecutionSetShaderInfoEXT* pShaderInfo = null
        ) : this()
        {
            if (pPipelineInfo is not null)
            {
                PPipelineInfo = pPipelineInfo;
            }

            if (pShaderInfo is not null)
            {
                PShaderInfo = pShaderInfo;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkIndirectExecutionSetPipelineInfoEXT*")]
        [NativeName("Type.Name", "VkIndirectExecutionSetPipelineInfoEXT")]
        [NativeName("Name", "pPipelineInfo")]
        public IndirectExecutionSetPipelineInfoEXT* PPipelineInfo;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkIndirectExecutionSetShaderInfoEXT*")]
        [NativeName("Type.Name", "VkIndirectExecutionSetShaderInfoEXT")]
        [NativeName("Name", "pShaderInfo")]
        public IndirectExecutionSetShaderInfoEXT* PShaderInfo;
    }
}
