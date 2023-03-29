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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    public static class AmdShaderInfoOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetShaderInfo<T0>(this AmdShaderInfo thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] ShaderStageFlags shaderStage, [Count(Count = 0)] ShaderInfoTypeAMD infoType, [Count(Count = 0)] Span<nuint> pInfoSize, [Count(Parameter = "pInfoSize")] Span<T0> pInfo) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pInfoSpp = pInfo)
                return thisApi.GetShaderInfo(device, pipeline, shaderStage, infoType, ref pInfoSize.GetPinnableReference(), pInfoSpp);
        }

    }
}

