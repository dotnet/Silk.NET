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
    [Extension("EXT_cull_vertex")]
    public unsafe partial class ExtCullVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_cull_vertex";
        [NativeApi(EntryPoint = "glCullParameterdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glCullParameterdvEXT", Convention = CallingConvention.Winapi)]
        public partial void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glCullParameterdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glCullParameterdvEXT", Convention = CallingConvention.Winapi)]
        public partial void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        public ExtCullVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

