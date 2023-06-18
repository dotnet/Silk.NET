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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_disjoint_timer_query")]
    public unsafe partial class ExtDisjointTimerQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_disjoint_timer_query";
        [NativeApi(EntryPoint = "glBeginQueryEXT", Convention = CallingConvention.Winapi)]
        public partial void BeginQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteQueriesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glEndQueryEXT", Convention = CallingConvention.Winapi)]
        public partial void EndQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenQueriesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGetInteger64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetQueryivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glIsQueryEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glQueryCounterEXT", Convention = CallingConvention.Winapi)]
        public partial void QueryCounter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        public ExtDisjointTimerQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

