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
    [Extension("SGIS_fog_function")]
    public abstract unsafe partial class SgisFogFunction : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_fog_function";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        public abstract unsafe void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        public abstract void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="points">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        public abstract unsafe void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] float* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="points">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
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

