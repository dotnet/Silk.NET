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
    [Extension("EXT_device_enumeration")]
    public unsafe partial class ExtDeviceEnumeration : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_enumeration";
        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public unsafe partial int QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public unsafe partial int QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out int num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public unsafe partial int QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public partial int QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out int num_devices);

        public ExtDeviceEnumeration(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

