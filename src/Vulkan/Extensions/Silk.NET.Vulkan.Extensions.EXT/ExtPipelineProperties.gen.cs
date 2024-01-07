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
    [Extension("VK_EXT_pipeline_properties")]
    public unsafe partial class ExtPipelineProperties : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_pipeline_properties";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelinePropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineInfoEXT* pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BaseOutStructure* pPipelineProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelinePropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineInfoEXT* pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out BaseOutStructure pPipelineProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelinePropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineInfoEXT pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BaseOutStructure* pPipelineProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelinePropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPipelineProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineInfoEXT pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out BaseOutStructure pPipelineProperties);

        public ExtPipelineProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

