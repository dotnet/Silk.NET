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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_occlusion_query_event")]
    public unsafe partial class AmdOcclusionQueryEvent : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_occlusion_query_event";
        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD", Convention = CallingConvention.Winapi)]
        public partial void QueryObjectParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint param);

        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD", Convention = CallingConvention.Winapi)]
        public partial void QueryObjectParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] OcclusionQueryEventMaskAMD param);

        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD", Convention = CallingConvention.Winapi)]
        public partial void QueryObjectParameter([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint param);

        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD", Convention = CallingConvention.Winapi)]
        public partial void QueryObjectParameter([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] OcclusionQueryEventMaskAMD param);

        public AmdOcclusionQueryEvent(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

