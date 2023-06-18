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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_gl_sharing")]
    public unsafe partial class KhrGlSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_gl_sharing";
        [NativeApi(EntryPoint = "clCreateFromGLBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGlbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGlrenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] GlObjectType* gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* gl_object_name);

        [NativeApi(EntryPoint = "clGetGLTextureInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGltextureInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlTextureInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        public KhrGlSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

