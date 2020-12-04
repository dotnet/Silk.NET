// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_pixel_texture")]
    public unsafe partial class SgisPixelTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_pixel_texture";
        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public unsafe partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public unsafe partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterivSGIS")]
        public partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public unsafe partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public unsafe partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
        public partial void GetPixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTexGenParameteriSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public unsafe partial void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public unsafe partial void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterivSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public unsafe partial void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public unsafe partial void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTexGenParameterfvSGIS")]
        public partial void PixelTexGenParameter([Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        public unsafe int GetPixelTexGenParameter([Flow(FlowDirection.In)] SGIS pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetPixelTexGenParameter(pname, &ret);
            return ret;
        }

        public SgisPixelTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

