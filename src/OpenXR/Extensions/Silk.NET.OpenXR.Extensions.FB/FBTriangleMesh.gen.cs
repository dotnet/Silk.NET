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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_triangle_mesh")]
    public unsafe partial class FBTriangleMesh : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_triangle_mesh";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTriangleMeshFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTriangleMeshFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleMeshCreateInfoFB* createInfo, [Count(Count = 0)] TriangleMeshFB* outTriangleMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTriangleMeshFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTriangleMeshFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleMeshCreateInfoFB* createInfo, [Count(Count = 0)] ref TriangleMeshFB outTriangleMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTriangleMeshFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateTriangleMeshFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleMeshCreateInfoFB createInfo, [Count(Count = 0)] TriangleMeshFB* outTriangleMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateTriangleMeshFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateTriangleMeshFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleMeshCreateInfoFB createInfo, [Count(Count = 0)] ref TriangleMeshFB outTriangleMesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyTriangleMeshFB", Convention = CallingConvention.Winapi)]
        public partial Result DestroyTriangleMeshFB([Count(Count = 0)] TriangleMeshFB mesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshBeginUpdateFB", Convention = CallingConvention.Winapi)]
        public partial Result TriangleMeshBeginUpdateFB([Count(Count = 0)] TriangleMeshFB mesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshBeginVertexBufferUpdateFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TriangleMeshBeginVertexBufferUpdateFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] uint* outVertexCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshBeginVertexBufferUpdateFB", Convention = CallingConvention.Winapi)]
        public partial Result TriangleMeshBeginVertexBufferUpdateFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] ref uint outVertexCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshEndUpdateFB", Convention = CallingConvention.Winapi)]
        public partial Result TriangleMeshEndUpdateFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] uint vertexCount, [Count(Count = 0)] uint triangleCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshEndVertexBufferUpdateFB", Convention = CallingConvention.Winapi)]
        public partial Result TriangleMeshEndVertexBufferUpdateFB([Count(Count = 0)] TriangleMeshFB mesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshGetIndexBufferFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TriangleMeshGetIndexBufferFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] uint** outIndexBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshGetIndexBufferFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TriangleMeshGetIndexBufferFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] ref uint* outIndexBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshGetVertexBufferFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TriangleMeshGetVertexBufferFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] Vector3f** outVertexBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTriangleMeshGetVertexBufferFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TriangleMeshGetVertexBufferFB([Count(Count = 0)] TriangleMeshFB mesh, [Count(Count = 0)] ref Vector3f* outVertexBuffer);

        public FBTriangleMesh(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

