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

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_migrate_memobject")]
    public abstract unsafe partial class ExtMigrateMemobject : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        public abstract unsafe int EnqueueMigrateMemObject([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        public abstract int EnqueueMigrateMemObject([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        public unsafe int EnqueueMigrateMemObject([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMemObject(new IntPtr(command_queue), num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueMigrateMemObject([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMemObject(new IntPtr(command_queue), num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public ExtMigrateMemobject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

