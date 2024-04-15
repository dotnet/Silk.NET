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
    [Extension("EXT_buffer_storage")]
    public unsafe partial class ExtBufferStorage : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_buffer_storage";
        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged;

        public unsafe void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferStorage(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferStorage(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferStorage(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void BufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferStorage(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public ExtBufferStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

