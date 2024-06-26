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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_buffer_object")]
    public unsafe partial class ArbVertexBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_buffer_object";
        [NativeApi(EntryPoint = "glBindBufferARB", Convention = CallingConvention.Winapi)]
        public partial void BindBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferARB", Convention = CallingConvention.Winapi)]
        public partial void BindBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public partial void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public partial void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public partial void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB", Convention = CallingConvention.Winapi)]
        public partial void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public partial void BufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public partial void BufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeleteBuffersARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB", Convention = CallingConvention.Winapi)]
        public partial void GenBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB", Convention = CallingConvention.Winapi)]
        public partial void GenBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Buffer buffers);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB", Convention = CallingConvention.Winapi)]
        public partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public partial void GetBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB", Convention = CallingConvention.Winapi)]
        public partial void GetBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsBufferARB", Convention = CallingConvention.Winapi)]
        public partial bool IsBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMapBufferARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapBufferARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glMapBufferARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapBufferARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBufferARB", Convention = CallingConvention.Winapi)]
        public partial bool UnmapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glUnmapBufferARB", Convention = CallingConvention.Winapi)]
        public partial bool UnmapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target);

        public unsafe void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferData(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), usage);
        }

        public unsafe void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferData(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), usage);
        }

        public unsafe void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferData(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), usage);
        }

        public unsafe void BufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferData(target, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), usage);
        }

        public unsafe void BufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferSubData(target, offset, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void BufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            BufferSubData(target, offset, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        public unsafe void DeleteBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            DeleteBuffers((uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void DeleteBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            DeleteBuffers((uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        public unsafe void GenBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            GenBuffers((uint) buffers.Length, out buffers.GetPinnableReference());
        }

        public unsafe void GenBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            GenBuffers((uint) buffers.Length, out buffers.GetPinnableReference());
        }

        public unsafe void GetBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetBufferSubData(target, offset, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void GetBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetBufferSubData(target, offset, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe uint GenBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenBuffers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe T0 GetBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetBufferSubData(target, offset, size, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetBufferSubData(target, offset, size, out T0 silkRet);
            return silkRet;
        }

        public ArbVertexBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

