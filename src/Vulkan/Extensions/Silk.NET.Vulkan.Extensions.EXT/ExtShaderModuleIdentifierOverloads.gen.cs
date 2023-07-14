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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtShaderModuleIdentifierOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        public static unsafe void GetShaderModuleCreateInfoIdentifier(this ExtShaderModuleIdentifier thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModuleIdentifierEXT> pIdentifier)
        {
            // SpanOverloader
            thisApi.GetShaderModuleCreateInfoIdentifier(device, pCreateInfo, out pIdentifier.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetShaderModuleCreateInfoIdentifier(this ExtShaderModuleIdentifier thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderModuleIdentifierEXT* pIdentifier)
        {
            // SpanOverloader
            thisApi.GetShaderModuleCreateInfoIdentifier(device, in pCreateInfo.GetPinnableReference(), pIdentifier);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        public static unsafe void GetShaderModuleCreateInfoIdentifier(this ExtShaderModuleIdentifier thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModuleIdentifierEXT> pIdentifier)
        {
            // SpanOverloader
            thisApi.GetShaderModuleCreateInfoIdentifier(device, in pCreateInfo.GetPinnableReference(), out pIdentifier.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pIdentifier = new(StructureType.ShaderModuleIdentifierExt);")]
        public static unsafe void GetShaderModuleIdentifier(this ExtShaderModuleIdentifier thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderModuleIdentifierEXT> pIdentifier)
        {
            // SpanOverloader
            thisApi.GetShaderModuleIdentifier(device, shaderModule, out pIdentifier.GetPinnableReference());
        }

    }
}

