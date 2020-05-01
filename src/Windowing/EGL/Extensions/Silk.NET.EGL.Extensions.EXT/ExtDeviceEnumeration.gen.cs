// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_device_enumeration")]
    public abstract unsafe partial class ExtDeviceEnumeration : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_enumeration";
        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public abstract unsafe bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public abstract bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<int> num_devices);

        public ExtDeviceEnumeration(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

