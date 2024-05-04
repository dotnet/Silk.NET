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

namespace Silk.NET.Vulkan.Extensions.QNX
{
    [Extension("VK_QNX_external_memory_screen_buffer")]
    public unsafe partial class QnxExternalMemoryScreenBuffer : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_QNX_external_memory_screen_buffer";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetScreenBufferPropertiesQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetScreenBufferPropertiesQnx([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ScreenBufferPropertiesQNX* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ScreenBufferPropertiesQnx);")]
        [NativeApi(EntryPoint = "vkGetScreenBufferPropertiesQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetScreenBufferPropertiesQnx([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ScreenBufferPropertiesQNX pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetScreenBufferPropertiesQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetScreenBufferPropertiesQnx<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ScreenBufferPropertiesQNX* pProperties) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ScreenBufferPropertiesQnx);")]
        [NativeApi(EntryPoint = "vkGetScreenBufferPropertiesQNX", Convention = CallingConvention.Winapi)]
        public partial Result GetScreenBufferPropertiesQnx<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ScreenBufferPropertiesQNX pProperties) where T0 : unmanaged;

        public QnxExternalMemoryScreenBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

