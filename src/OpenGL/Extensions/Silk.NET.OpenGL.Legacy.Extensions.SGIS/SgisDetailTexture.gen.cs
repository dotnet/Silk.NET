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
    [Extension("SGIS_detail_texture")]
    public unsafe partial class SgisDetailTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_detail_texture";
        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public unsafe partial void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public partial void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public unsafe partial void GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public partial void GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public unsafe partial void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public partial void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public unsafe partial void GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public partial void GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        public unsafe float GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetDetailTexFunc(target, &ret);
            return ret;
        }

        public unsafe float GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetDetailTexFunc(target, &ret);
            return ret;
        }

        public SgisDetailTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

