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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_list_priority")]
    public unsafe partial class SgixListPriority : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_list_priority";
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glListParameterfSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glListParameterfSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glListParameterfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glListParameteriSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glListParameteriSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glListParameterivSGIX", Convention = CallingConvention.Winapi)]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        public SgixListPriority(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

