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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_multi_bind")]
    public unsafe partial class ArbMultiBind : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_bind";
        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindImageTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        public ArbMultiBind(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

