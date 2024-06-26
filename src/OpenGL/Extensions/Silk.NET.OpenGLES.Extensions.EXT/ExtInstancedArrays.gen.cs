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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_instanced_arrays")]
    public unsafe partial class ExtInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_instanced_arrays";
        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribDivisorEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        public ExtInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

