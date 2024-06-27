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

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange", Convention = CallingConvention.Winapi)]
        public partial void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nuint sizes);

        [NativeApi(EntryPoint = "glBindImageTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindImageTextures", Convention = CallingConvention.Winapi)]
        public partial void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures);

        [NativeApi(EntryPoint = "glBindImageTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glBindImageTextures", Convention = CallingConvention.Winapi)]
        public partial void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures);

        [NativeApi(EntryPoint = "glBindSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindSamplers", Convention = CallingConvention.Winapi)]
        public partial void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint samplers);

        [NativeApi(EntryPoint = "glBindSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Sampler* samplers);

        [NativeApi(EntryPoint = "glBindSamplers", Convention = CallingConvention.Winapi)]
        public partial void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Sampler samplers);

        [NativeApi(EntryPoint = "glBindTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindTextures", Convention = CallingConvention.Winapi)]
        public partial void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures);

        [NativeApi(EntryPoint = "glBindTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glBindTextures", Convention = CallingConvention.Winapi)]
        public partial void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers", Convention = CallingConvention.Winapi)]
        public partial void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        public unsafe void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // ImplicitCountSpanOverloader
            BindImageTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindImageTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            BindImageTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            BindSamplers(first, (uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe void BindSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
        {
            // ImplicitCountSpanOverloader
            BindSamplers(first, (uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // ImplicitCountSpanOverloader
            BindTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            BindTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, strides);
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, strides);
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public ArbMultiBind(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

