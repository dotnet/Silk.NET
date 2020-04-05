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
    [Extension("SGIS_texture_filter4")]
    public abstract unsafe partial class SgisTextureFilter4 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract unsafe void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract unsafe void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract unsafe void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract unsafe void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> weights);

        public SgisTextureFilter4(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

