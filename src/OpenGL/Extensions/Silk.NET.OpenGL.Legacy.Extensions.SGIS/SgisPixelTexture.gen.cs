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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_pixel_texture")]
    public unsafe partial class SgisPixelTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_pixel_texture";
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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetPixelTexGenParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelTexGenParameter(pname, param);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplPixelTexGenParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] float param)
            => ImplPixelTexGenParameter(pname, param);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetPixelTexGenParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelTexGenParameter(pname, param);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplPixelTexGenParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] float param)
            => ImplPixelTexGenParameter(pname, param);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplPixelTexGenParameter(pname, @params);

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
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplPixelTexGenParameter(pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

        public SgisPixelTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

