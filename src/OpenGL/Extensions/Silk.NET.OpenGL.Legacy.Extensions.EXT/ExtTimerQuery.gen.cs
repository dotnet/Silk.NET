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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_timer_query")]
    public unsafe partial class ExtTimerQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_timer_query";
        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        public unsafe long GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetQueryObject(id, pname, out long silkRet);
            return silkRet;
        }

        public unsafe long GetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryObjectParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetQueryObject(id, pname, out long silkRet);
            return silkRet;
        }

        public ExtTimerQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

