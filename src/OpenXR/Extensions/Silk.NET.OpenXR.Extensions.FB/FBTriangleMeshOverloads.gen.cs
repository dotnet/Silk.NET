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

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBTriangleMeshOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTriangleMeshFB(this FBTriangleMesh thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleMeshCreateInfoFB* createInfo, [Count(Count = 0)] Span<TriangleMeshFB> outTriangleMesh)
        {
            // SpanOverloader
            return thisApi.CreateTriangleMeshFB(session, createInfo, ref outTriangleMesh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTriangleMeshFB(this FBTriangleMesh thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleMeshCreateInfoFB> createInfo, [Count(Count = 0)] TriangleMeshFB* outTriangleMesh)
        {
            // SpanOverloader
            return thisApi.CreateTriangleMeshFB(session, in createInfo.GetPinnableReference(), outTriangleMesh);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTriangleMeshFB(this FBTriangleMesh thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleMeshCreateInfoFB> createInfo, [Count(Count = 0)] Span<TriangleMeshFB> outTriangleMesh)
        {
            // SpanOverloader
            return thisApi.CreateTriangleMeshFB(session, in createInfo.GetPinnableReference(), ref outTriangleMesh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result TriangleMeshBeginVertexBufferUpdateFB(this FBTriangleMesh thisApi, [Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] Span<uint> outVertexCount)
        {
            // SpanOverloader
            return thisApi.TriangleMeshBeginVertexBufferUpdateFB(mesh, ref outVertexCount.GetPinnableReference());
        }

    }
}

