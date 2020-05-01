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
    [Extension("SGIS_texture_filter4")]
    public abstract unsafe partial class SgisTextureFilter4 : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture_filter4";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is computed from target and filter.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract unsafe void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is computed from target and filter.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract unsafe void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is computed from target and filter.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract unsafe void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is computed from target and filter.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public abstract void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract unsafe void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public abstract void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> weights);

        public SgisTextureFilter4(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

