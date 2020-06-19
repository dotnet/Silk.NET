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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_sample_positions")]
    public abstract unsafe partial class AmdSamplePositions : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_sample_positions";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="val">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSetMultisamplefvAMD")]
        public abstract unsafe void SetMultisample([Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="val">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSetMultisamplefvAMD")]
        public abstract void SetMultisample([Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> val);

        public AmdSamplePositions(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

