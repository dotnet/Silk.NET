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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_pixel_texture")]
    public abstract unsafe partial class SgisPixelTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_pixel_texture";
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract unsafe void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public abstract void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract unsafe void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public abstract void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        public unsafe int GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

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

