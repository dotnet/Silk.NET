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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_sharing_format_query_dx9")]
    public unsafe partial class IntelSharingFormatQueryDx9 : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_sharing_format_query_dx9";
        [NativeApi(EntryPoint = "clGetSupportedDX9MediaSurfaceFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedDX9MediaSurfaceFormats([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dx9_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_surface_formats);

        public IntelSharingFormatQueryDx9(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

