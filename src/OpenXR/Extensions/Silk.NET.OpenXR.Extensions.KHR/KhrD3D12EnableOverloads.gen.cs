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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrD3D12EnableOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetD3D12GraphicsRequirements(this KhrD3D12Enable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<GraphicsRequirementsD3D12KHR> graphicsRequirements)
        {
            // SpanOverloader
            return thisApi.GetD3D12GraphicsRequirements(instance, systemId, ref graphicsRequirements.GetPinnableReference());
        }

    }
}

