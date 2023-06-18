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

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_image_requirements_info")]
    public unsafe partial class ExtImageRequirementsInfo : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_image_requirements_info";
        [NativeApi(EntryPoint = "clGetImageRequirementsInfoEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetImageRequirementsInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageFormat* image_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageDesc* image_desc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        public ExtImageRequirementsInfo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

