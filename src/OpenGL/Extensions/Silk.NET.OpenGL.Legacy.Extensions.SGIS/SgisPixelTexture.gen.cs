// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_pixel_texture")]
    public abstract unsafe partial class SgisPixelTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

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
        public unsafe int GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

        public SgisPixelTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

