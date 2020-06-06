// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_gl_sharing")]
    public unsafe partial class KhrGlSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_gl_sharing";
        [NativeApi(EntryPoint = "clCreateFromGLBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromGlbuffer(context, flags, bufobj, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromGlbuffer(context, flags, bufobj, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromGlrenderbuffer(context, flags, renderbuffer, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromGlrenderbuffer(context, flags, renderbuffer, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromGltexture(context, flags, target, miplevel, texture, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromGltexture([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromGltexture(context, flags, target, miplevel, texture, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromGltexture2D(context, flags, target, miplevel, texture, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromGltexture2D(context, flags, target, miplevel, texture, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromGltexture3D(context, flags, target, miplevel, texture, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromGltexture3D(context, flags, target, miplevel, texture, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueAcquireGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueAcquireGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReleaseGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueReleaseGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGlcontextInfo([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetGlcontextInfo(properties, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetGlcontextInfo<T0>(properties, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name)
            => ImplGetGlobjectInfo(memobj, gl_object_type, gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] Span<uint> gl_object_type, [Flow(FlowDirection.Out)] Span<uint> gl_object_name)
            => ImplGetGlobjectInfo(memobj, gl_object_type, gl_object_name);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGltextureInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetGltextureInfo(memobj, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetGltextureInfo<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetGltextureInfo<T0>(memobj, param_name, param_value_size, param_value, param_value_size_ret);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlbuffer(new IntPtr(context), flags, bufobj, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlbuffer(new IntPtr(context), flags, bufobj, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlrenderbuffer(new IntPtr(context), flags, renderbuffer, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGlrenderbuffer(new IntPtr(context), flags, renderbuffer, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture2D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture2D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture3D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromGltexture3D(new IntPtr(context), flags, target, miplevel, texture, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseGlobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGlcontextInfo([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetGlcontextInfo(properties, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetGlcontextInfo(properties, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGlobjectInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name)
        {
            // IntPtrOverloader
            return GetGlobjectInfo(new IntPtr(memobj), gl_object_type, gl_object_name);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGlobjectInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] Span<uint> gl_object_type, [Flow(FlowDirection.Out)] Span<uint> gl_object_name)
        {
            // IntPtrOverloader
            return GetGlobjectInfo(new IntPtr(memobj), gl_object_type, gl_object_name);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGltextureInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetGltextureInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetGltextureInfo<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetGltextureInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public KhrGlSharing(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

