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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_point_sprite")]
    public unsafe partial class NVPointSprite : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_point_sprite";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param)
            => ImplPointParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PointParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplPointParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplPointParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] int param)
            => ImplPointParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplPointParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplPointParameter(pname, @params);

        public NVPointSprite(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

