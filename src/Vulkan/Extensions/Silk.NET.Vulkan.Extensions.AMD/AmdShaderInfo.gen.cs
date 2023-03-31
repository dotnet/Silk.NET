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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_shader_info")]
    public unsafe partial class AmdShaderInfo : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_shader_info";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetShaderInfo([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] nuint* pInfoSize, [Count(Parameter = "pInfoSize")] void* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetShaderInfo<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] nuint* pInfoSize, [Count(Parameter = "pInfoSize")] ref T0 pInfo) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetShaderInfo([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] ref nuint pInfoSize, [Count(Parameter = "pInfoSize")] void* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderInfoAMD", Convention = CallingConvention.Winapi)]
        public partial Result GetShaderInfo<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] ref nuint pInfoSize, [Count(Parameter = "pInfoSize")] ref T0 pInfo) where T0 : unmanaged;

        public AmdShaderInfo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

