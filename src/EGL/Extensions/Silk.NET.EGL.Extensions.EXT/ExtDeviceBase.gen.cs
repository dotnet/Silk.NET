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
    [Extension("EXT_device_base")]
    public unsafe partial class ExtDeviceBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_base";
        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT")]
        public unsafe partial bool QueryDeviceAttrib([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT")]
        public partial bool QueryDeviceAttrib([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public unsafe partial bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public unsafe partial bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out int num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public unsafe partial bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public partial bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out int num_devices);

        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT")]
        public unsafe partial byte* QueryDeviceString([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT")]
        public partial string QueryDeviceStringS([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT")]
        public unsafe partial bool QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT")]
        public partial bool QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        public ExtDeviceBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

