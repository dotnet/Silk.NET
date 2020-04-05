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

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_device_base")]
    public abstract unsafe partial class ExtDeviceBase : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT")]
        public abstract unsafe bool QueryDeviceAttrib([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT")]
        public abstract bool QueryDeviceAttrib([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public abstract unsafe bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] int* num_devices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDevicesEXT")]
        public abstract bool QueryDevices([Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<int> num_devices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT")]
        public abstract unsafe char* QueryDeviceString([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] int name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT")]
        public abstract unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT")]
        public abstract bool QueryDisplayAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT")]
        public abstract string QueryDeviceStringS([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] int name);

        public unsafe bool QueryDeviceAttrib([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryDeviceAttrib(new IntPtr(device), attribute, value);
        }

        public unsafe bool QueryDeviceAttrib([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryDeviceAttrib(new IntPtr(device), attribute, value);
        }

        public unsafe char* QueryDeviceString([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryDeviceString(new IntPtr(device), name);
        }

        public unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryDisplayAttrib(new IntPtr(dpy), attribute, value);
        }

        public unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryDisplayAttrib(new IntPtr(dpy), attribute, value);
        }

        public unsafe string QueryDeviceStringS([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryDeviceStringS(new IntPtr(device), name);
        }

        public ExtDeviceBase(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

