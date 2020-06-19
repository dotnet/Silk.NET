// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_buffer_object")]
    public abstract unsafe partial class ArbVertexBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_buffer_object";
        [NativeApi(EntryPoint = "glBindBufferARB")]
        public abstract void BindBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public abstract unsafe void BufferData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public abstract void BufferData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public abstract unsafe void BufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public abstract void BufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        public abstract unsafe void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        public abstract void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB")]
        public abstract unsafe void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB")]
        public abstract void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public abstract unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public abstract unsafe void GetBufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public abstract void GetBufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsBufferARB")]
        public abstract bool IsBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMapBufferARB")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glUnmapBufferARB")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glBindBufferARB")]
        public abstract void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public abstract unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public abstract void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public abstract unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public abstract void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public abstract unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public abstract unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public abstract void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapBufferARB")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBufferARB")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target);

        public unsafe void BufferData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public ArbVertexBufferObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

