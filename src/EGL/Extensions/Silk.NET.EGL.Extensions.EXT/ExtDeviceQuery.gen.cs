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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_device_query")]
    public unsafe partial class ExtDeviceQuery : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_query";
        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT")]
        public unsafe partial bool QueryDeviceAttrib([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT")]
        public partial bool QueryDeviceAttrib([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT")]
        public unsafe partial byte* QueryDeviceString([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT")]
        public partial string QueryDeviceStringS([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT")]
        public unsafe partial bool QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT")]
        public partial bool QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        public ExtDeviceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

