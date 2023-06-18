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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_vertex_input_dynamic_state")]
    public unsafe partial class ExtVertexInputDynamicState : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_vertex_input_dynamic_state";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetVertexInputEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetVertexInput([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputBindingDescription2EXT* pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);

        public ExtVertexInputDynamicState(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

