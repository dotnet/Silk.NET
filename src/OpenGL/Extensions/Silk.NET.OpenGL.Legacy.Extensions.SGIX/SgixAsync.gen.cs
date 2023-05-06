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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_async")]
    public unsafe partial class SgixAsync : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_async";
        [NativeApi(EntryPoint = "glAsyncMarkerSGIX", Convention = CallingConvention.Winapi)]
        public partial void AsyncMarker([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint marker);

        [NativeApi(EntryPoint = "glDeleteAsyncMarkersSGIX", Convention = CallingConvention.Winapi)]
        public partial void DeleteAsyncMarkers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint marker, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glFinishAsyncSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial int FinishAsync([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* markerp);

        [NativeApi(EntryPoint = "glFinishAsyncSGIX", Convention = CallingConvention.Winapi)]
        public partial int FinishAsync([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint markerp);

        [NativeApi(EntryPoint = "glGenAsyncMarkersSGIX", Convention = CallingConvention.Winapi)]
        public partial uint GenAsyncMarkers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glIsAsyncMarkerSGIX", Convention = CallingConvention.Winapi)]
        public partial bool IsAsyncMarker([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint marker);

        [NativeApi(EntryPoint = "glPollAsyncSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial int PollAsync([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* markerp);

        [NativeApi(EntryPoint = "glPollAsyncSGIX", Convention = CallingConvention.Winapi)]
        public partial int PollAsync([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint markerp);

        public SgixAsync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

