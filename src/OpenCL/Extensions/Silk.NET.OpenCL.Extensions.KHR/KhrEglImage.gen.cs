// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_egl_image")]
    public abstract unsafe partial class KhrEglImage : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR")]
        public abstract unsafe IntPtr CreateFromEglimage([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR")]
        public abstract IntPtr CreateFromEglimage([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR")]
        public abstract unsafe int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR")]
        public abstract int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR")]
        public abstract unsafe int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR")]
        public abstract int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        public unsafe IntPtr CreateFromEglimage([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int egldisplay, [Flow(FlowDirection.In)] int eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromEglimage(new IntPtr(context), new IntPtr(egldisplay), new IntPtr(eglimage), flags, properties, errcode_ret);
        }

        public unsafe IntPtr CreateFromEglimage([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int egldisplay, [Flow(FlowDirection.In)] int eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromEglimage(new IntPtr(context), new IntPtr(egldisplay), new IntPtr(eglimage), flags, properties, errcode_ret);
        }

        public unsafe int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseEglobjects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public KhrEglImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

