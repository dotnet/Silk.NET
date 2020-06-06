// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_buffer_object")]
    public unsafe partial class ArbVertexBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_buffer_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBuffer(target, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
            => ImplBufferData(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
            => ImplBufferData<T0>(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
            => ImplBufferSubData(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplBufferSubData<T0>(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers)
            => ImplDeleteBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> buffers)
            => ImplDeleteBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenBuffersARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers)
            => ImplGenBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenBuffersARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers)
            => ImplGenBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetBufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetBufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetBufferPointer(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetBufferPointer<T0>(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
            => ImplGetBufferSubData(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplGetBufferSubData<T0>(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplIsBuffer(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB access)
            => ImplMapBuffer(target, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapBuffer([Flow(FlowDirection.In)] ARB target)
            => ImplUnmapBuffer(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBuffer(target, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
            => ImplBufferData(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
            => ImplBufferData<T0>(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
            => ImplBufferSubData(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplBufferSubData<T0>(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetBufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetBufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetBufferPointer(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetBufferPointer<T0>(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
            => ImplGetBufferSubData(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplGetBufferSubData<T0>(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access)
            => ImplMapBuffer(target, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target)
            => ImplUnmapBuffer(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public ArbVertexBufferObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

