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

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [Extension("QCOM_ext_host_ptr")]
    public unsafe partial class QComExtHostPtr : NativeExtension<CL>
    {
        public const string ExtensionName = "QCOM_ext_host_ptr";
        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceImageInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageFormat* image_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImagePitchInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        public QComExtHostPtr(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

