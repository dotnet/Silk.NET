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
    [Extension("SGIS_fog_function")]
    public abstract unsafe partial class SgisFogFunction : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        public abstract unsafe void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        public abstract void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        public abstract unsafe void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] float* points);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        public abstract void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] out float points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="points">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        public unsafe float GetFogFunc()
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFogFunc(&ret);
            return ret;
        }

        public SgisFogFunction(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

