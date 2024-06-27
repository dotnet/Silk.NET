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
    [Extension("VK_EXT_shader_module_identifier")]
    public unsafe partial class ExtShaderModuleIdentifier : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_shader_module_identifier";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderModuleCreateInfoIdentifier([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModuleIdentifierEXT* pIdentifier);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        [NativeApi(EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderModuleCreateInfoIdentifier([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ShaderModuleIdentifierEXT pIdentifier);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderModuleCreateInfoIdentifier([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModuleIdentifierEXT* pIdentifier);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        [NativeApi(EntryPoint = "vkGetShaderModuleCreateInfoIdentifierEXT", Convention = CallingConvention.Winapi)]
        public partial void GetShaderModuleCreateInfoIdentifier([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ShaderModuleIdentifierEXT pIdentifier);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderModuleIdentifierEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderModuleIdentifier([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModuleIdentifierEXT* pIdentifier);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        [NativeApi(EntryPoint = "vkGetShaderModuleIdentifierEXT", Convention = CallingConvention.Winapi)]
        public partial void GetShaderModuleIdentifier([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ShaderModuleIdentifierEXT pIdentifier);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        public unsafe ShaderModuleIdentifierEXT GetShaderModuleCreateInfoIdentifier([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo)
        {
            // NonKhrReturnTypeOverloader
            GetShaderModuleCreateInfoIdentifier(device, pCreateInfo, out ShaderModuleIdentifierEXT silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        public unsafe ShaderModuleIdentifierEXT GetShaderModuleCreateInfoIdentifier([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleCreateInfo pCreateInfo)
        {
            // NonKhrReturnTypeOverloader
            GetShaderModuleCreateInfoIdentifier(device, in pCreateInfo, out ShaderModuleIdentifierEXT silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        public unsafe ShaderModuleIdentifierEXT GetShaderModuleIdentifier([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule)
        {
            // NonKhrReturnTypeOverloader
            GetShaderModuleIdentifier(device, shaderModule, out ShaderModuleIdentifierEXT silkRet);
            return silkRet;
        }

        public ExtShaderModuleIdentifier(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

