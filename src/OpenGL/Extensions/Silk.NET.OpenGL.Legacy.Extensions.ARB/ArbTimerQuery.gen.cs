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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_timer_query")]
    public unsafe partial class ArbTimerQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_timer_query";
        [NativeApi(EntryPoint = "glGetQueryObjecti64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glQueryCounter", Convention = CallingConvention.Winapi)]
        public partial void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glQueryCounter", Convention = CallingConvention.Winapi)]
        public partial void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryCounterTarget target);

        public ArbTimerQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

