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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_draw_elements_base_vertex")]
    public unsafe partial class OesDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_draw_elements_base_vertex";
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexOES", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int basevertex);

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public OesDrawElementsBaseVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

