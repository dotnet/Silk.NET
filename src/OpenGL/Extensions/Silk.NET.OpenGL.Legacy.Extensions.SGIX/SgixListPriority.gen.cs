// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_list_priority")]
    public unsafe partial class SgixListPriority : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_list_priority";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplListParameter(list, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glListParameteriSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplListParameter(list, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] float param)
            => ImplListParameter(list, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glListParameteriSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplListParameter(list, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplListParameter(list, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplListParameter(list, pname, @params);

        public SgixListPriority(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

