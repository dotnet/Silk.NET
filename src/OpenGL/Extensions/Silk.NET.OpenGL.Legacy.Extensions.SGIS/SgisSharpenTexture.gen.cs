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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_sharpen_texture")]
    public unsafe partial class SgisSharpenTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_sharpen_texture";
        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS")]
        public unsafe partial void GetSharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS")]
        public partial void GetSharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS")]
        public unsafe partial void SharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS")]
        public partial void SharpenTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS")]
        public unsafe partial void GetSharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetSharpenTexFuncSGIS")]
        public partial void GetSharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS")]
        public unsafe partial void SharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glSharpenTexFuncSGIS")]
        public partial void SharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        public unsafe float GetSharpenTexFunc([Flow(FlowDirection.In)] SGIS target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetSharpenTexFunc(target, &ret);
            return ret;
        }

        public unsafe float GetSharpenTexFunc([Flow(FlowDirection.In)] TextureTarget target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetSharpenTexFunc(target, &ret);
            return ret;
        }

        public SgisSharpenTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

