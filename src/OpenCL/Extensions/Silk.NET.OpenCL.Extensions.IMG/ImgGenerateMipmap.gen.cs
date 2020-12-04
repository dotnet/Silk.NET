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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [Extension("IMG_generate_mipmap")]
    public abstract unsafe partial class ImgGenerateMipmap : NativeExtension<CL>
    {
        public const string ExtensionName = "IMG_generate_mipmap";
        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public abstract unsafe int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public abstract int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] Span<UIntPtr> array_region, [Flow(FlowDirection.In)] Span<UIntPtr> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        public unsafe int EnqueueGenerateMipmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueGenerateMipmap(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_image), mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueGenerateMipmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] Span<UIntPtr> array_region, [Flow(FlowDirection.In)] Span<UIntPtr> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueGenerateMipmap(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_image), mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, @event);
        }

        public ImgGenerateMipmap(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

