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

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [Extension("IMG_use_gralloc_ptr")]
    public unsafe partial class ImgUseGrallocPtr : NativeExtension<CL>
    {
        public const string ExtensionName = "IMG_use_gralloc_ptr";
        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public unsafe partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        public partial int EnqueueAcquireGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public unsafe partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        public partial int EnqueueReleaseGrallocObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        public ImgUseGrallocPtr(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

