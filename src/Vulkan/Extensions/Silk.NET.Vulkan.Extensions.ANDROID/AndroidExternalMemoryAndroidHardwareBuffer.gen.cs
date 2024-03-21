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

namespace Silk.NET.Vulkan.Extensions.ANDROID
{
    [Extension("VK_ANDROID_external_memory_android_hardware_buffer")]
    public unsafe partial class AndroidExternalMemoryAndroidHardwareBuffer : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AndroidHardwareBufferPropertiesANDROID* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.AndroidHardwareBufferPropertiesAndroid);")]
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AndroidHardwareBufferPropertiesANDROID pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AndroidHardwareBufferPropertiesANDROID* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.AndroidHardwareBufferPropertiesAndroid);")]
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AndroidHardwareBufferPropertiesANDROID pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetAndroidHardwareBufferInfoANDROID pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetAndroidHardwareBufferInfoANDROID pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint* pBuffer);

        public AndroidExternalMemoryAndroidHardwareBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

