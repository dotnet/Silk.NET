// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.AMD
{
    public static class AmdShaderInfoOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetShaderInfo<T0>(this AmdShaderInfo thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] UIntPtr* pInfoSize, [Count(Computed = "pInfoSize")] Span<T0> pInfo) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetShaderInfo(device, pipeline, shaderStage, infoType, pInfoSize, ref pInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetShaderInfo(this AmdShaderInfo thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] Span<UIntPtr> pInfoSize, [Count(Computed = "pInfoSize")] void* pInfo)
        {
            // SpanOverloader
            return thisApi.GetShaderInfo(device, pipeline, shaderStage, infoType, ref pInfoSize.GetPinnableReference(), pInfo);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetShaderInfo<T0>(this AmdShaderInfo thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] Span<UIntPtr> pInfoSize, [Count(Computed = "pInfoSize")] Span<T0> pInfo) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetShaderInfo(device, pipeline, shaderStage, infoType, ref pInfoSize.GetPinnableReference(), ref pInfo.GetPinnableReference());
        }

    }
}

