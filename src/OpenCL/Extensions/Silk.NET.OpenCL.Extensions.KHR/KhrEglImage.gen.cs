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
    [Extension("KHR_egl_image")]
    public unsafe partial class KhrEglImage : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_egl_image";
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromEglimage([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromEglimage(context, egldisplay, eglimage, flags, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromEglimage([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromEglimage(context, egldisplay, eglimage, flags, properties, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueAcquireEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueAcquireEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReleaseEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueReleaseEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromEglimage([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int egldisplay, [Flow(FlowDirection.In)] int eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromEglimage(new IntPtr(context), new IntPtr(egldisplay), new IntPtr(eglimage), flags, properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromEglimage([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int egldisplay, [Flow(FlowDirection.In)] int eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromEglimage(new IntPtr(context), new IntPtr(egldisplay), new IntPtr(eglimage), flags, properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public KhrEglImage(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

