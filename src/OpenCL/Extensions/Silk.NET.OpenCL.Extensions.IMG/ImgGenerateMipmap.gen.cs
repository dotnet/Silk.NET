// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [Extension("IMG_generate_mipmap")]
    public unsafe partial class ImgGenerateMipmap : NativeExtension<CL>
    {
        public const string ExtensionName = "IMG_generate_mipmap";
        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] UIntPtr* array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] UIntPtr* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public unsafe partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG")]
        public partial int EnqueueGenerateMipmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] in UIntPtr array_region, [Flow(FlowDirection.In)] in UIntPtr mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        public ImgGenerateMipmap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

