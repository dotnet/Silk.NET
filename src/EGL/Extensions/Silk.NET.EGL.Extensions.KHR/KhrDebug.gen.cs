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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_debug")]
    public unsafe partial class KhrDebug : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_debug";
        [NativeApi(EntryPoint = "eglDebugMessageControlKHR")]
        public unsafe partial int DebugMessageControl([Flow(FlowDirection.In)] PfnDebugProcKhr callback, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglDebugMessageControlKHR")]
        public partial int DebugMessageControl([Flow(FlowDirection.In)] PfnDebugProcKhr callback, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglLabelObjectKHR")]
        public partial int LabelObject([Flow(FlowDirection.In)] nint display, [Flow(FlowDirection.In)] KHR objectType, [Flow(FlowDirection.In)] nint @object, [Flow(FlowDirection.In)] nint label);

        [NativeApi(EntryPoint = "eglQueryDebugKHR")]
        public unsafe partial bool QueryDebug([Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDebugKHR")]
        public partial bool QueryDebug([Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        public KhrDebug(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

