// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_shader_info")]
    public unsafe partial class AmdShaderInfo : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_shader_info";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetShaderInfoAMD")]
        public unsafe partial Result GetShaderInfo([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] UIntPtr* pInfoSize, [Count(Computed = "pInfoSize")] void* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetShaderInfoAMD")]
        public partial Result GetShaderInfo<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] ref UIntPtr pInfoSize, [Count(Computed = "pInfoSize")] ref T0 pInfo) where T0 : unmanaged;

        public AmdShaderInfo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

