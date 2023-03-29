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
        public unsafe partial nint CreateFromGlbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLBuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGlbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGlbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLBuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGlbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint bufobj, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGlrenderbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGlrenderbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGlrenderbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGlrenderbuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGltexture([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLTexture", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGltexture([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture2D", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGltexture2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLTexture2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLTexture2D", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGltexture2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromGLTexture3D", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGltexture3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLTexture3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromGltexture3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromGLTexture3D", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromGltexture3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] int miplevel, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGLObjects", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGLObjects", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseGlobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] GlContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] GlContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] GlContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] GlContextInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetGLContextInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlcontextInfo([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] GlObjectType* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] GlObjectType* gl_object_type, [Flow(FlowDirection.Out)] out uint gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out GlObjectType gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out GlObjectType gl_object_type, [Flow(FlowDirection.Out)] out uint gl_object_name);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] uint* gl_object_type, [Flow(FlowDirection.Out)] out uint gl_object_name);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out uint gl_object_type, [Flow(FlowDirection.Out)] uint* gl_object_name);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetGLObjectInfo", Convention = CallingConvention.Winapi)]
        public partial int GetGlobjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out uint gl_object_type, [Flow(FlowDirection.Out)] out uint gl_object_name);

        [NativeApi(EntryPoint = "clGetGLTextureInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGltextureInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] GlTextureInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetGLTextureInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGltextureInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] GlTextureInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlTextureInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetGLTextureInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGltextureInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlTextureInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetGLTextureInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGltextureInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        public KhrGlSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

