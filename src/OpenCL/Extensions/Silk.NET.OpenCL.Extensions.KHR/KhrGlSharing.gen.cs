// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_gl_sharing")]
    public unsafe partial class KhrGlSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_gl_sharing";
        [NativeApi(EntryPoint = "clCreateFromGLBuffer")]
        public unsafe partial IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLBuffer")]
        public partial IntPtr CreateFromGlbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer")]
        public unsafe partial IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer")]
        public partial IntPtr CreateFromGlrenderbuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture")]
        public unsafe partial IntPtr CreateFromGltexture([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture")]
        public partial IntPtr CreateFromGltexture([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D")]
        public unsafe partial IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D")]
        public partial IntPtr CreateFromGltexture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D")]
        public unsafe partial IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D")]
        public partial IntPtr CreateFromGltexture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects")]
        public partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects")]
        public partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public unsafe partial int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR")]
        public partial int GetGlcontextInfo<T0>([Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] out uint gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] out uint gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo")]
        public partial int GetGlobjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] out uint gl_object_type, [Flow(FlowDirection.Out)] out uint gl_object_name);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        public unsafe partial int GetGltextureInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        public unsafe partial int GetGltextureInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        public unsafe partial int GetGltextureInfo<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetGLTextureInfo")]
        public partial int GetGltextureInfo<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        public KhrGlSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

