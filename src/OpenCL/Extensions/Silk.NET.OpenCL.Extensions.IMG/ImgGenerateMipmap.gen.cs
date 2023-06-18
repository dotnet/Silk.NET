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

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [Extension("IMG_generate_mipmap")]
    public unsafe partial class ImgGenerateMipmap : NativeExtension<CL>
    {
        public const string ExtensionName = "IMG_generate_mipmap";
        [NativeApi(EntryPoint = "clEnqueueGenerateMipmapIMG", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueGenerateMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        public ImgGenerateMipmap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

