// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_list_priority")]
    public unsafe partial class SgixListPriority : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_list_priority";
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public unsafe partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public partial void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glListParameterfSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glListParameterfSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glListParameteriSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glListParameteriSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public unsafe partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public partial void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        public SgixListPriority(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

