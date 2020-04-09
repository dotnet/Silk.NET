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
    [Extension("SGIS_detail_texture")]
    public abstract unsafe partial class SgisDetailTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public abstract unsafe void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public abstract void DetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public abstract unsafe void GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public abstract void GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public abstract unsafe void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDetailTexFuncSGIS")]
        public abstract void DetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public abstract unsafe void GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDetailTexFuncSGIS")]
        public abstract void GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        public unsafe float GetDetailTexFunc([Flow(FlowDirection.In)] SGIS target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetDetailTexFunc(target, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        public unsafe float GetDetailTexFunc([Flow(FlowDirection.In)] TextureTarget target)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetDetailTexFunc(target, &ret);
            return ret;
        }

        public SgisDetailTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

