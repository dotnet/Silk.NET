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
        [NativeApi(EntryPoint = "glBindBufferARB")]
        public partial void BindBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferARB")]
        public partial void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferDataARB")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public unsafe partial void BufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public partial void BufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public unsafe partial void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubDataARB")]
        public partial void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        public unsafe partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        public partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        public unsafe partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffersARB")]
        public partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Buffer buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB")]
        public unsafe partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB")]
        public partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB")]
        public unsafe partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Buffer* buffers);

        [NativeApi(EntryPoint = "glGenBuffersARB")]
        public partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Buffer buffers);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterivARB")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervARB")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public unsafe partial void GetBufferSubData([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public partial void GetBufferSubData<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public unsafe partial void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubDataARB")]
        public partial void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsBufferARB")]
        public partial bool IsBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMapBufferARB")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapBufferARB")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glMapBufferARB")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapBufferARB")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBufferARB")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glUnmapBufferARB")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target);

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

        public ArbVertexBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

