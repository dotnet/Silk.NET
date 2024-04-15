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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_bind_memory2")]
    public unsafe partial class KhrBindMemory2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_bind_memory2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2KHR", Convention = CallingConvention.Winapi)]
        public partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BindBufferMemoryInfo pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2KHR", Convention = CallingConvention.Winapi)]
        public partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BindImageMemoryInfo pBindInfos);

        /// <summary>To be documented.</summary>
        public unsafe Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindBufferMemoryInfo> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindBufferMemory2(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindImageMemoryInfo> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindImageMemory2(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        public KhrBindMemory2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

