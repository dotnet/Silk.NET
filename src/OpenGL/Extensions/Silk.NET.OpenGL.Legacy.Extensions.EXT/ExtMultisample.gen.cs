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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_multisample")]
    public abstract unsafe partial class ExtMultisample : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleMaskEXT")]
        public abstract void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplePatternEXT")]
        public abstract void SamplePattern([Flow(FlowDirection.In)] EXT pattern);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplePatternEXT")]
        public abstract void SamplePattern([Flow(FlowDirection.In)] SamplePatternEXT pattern);

        public ExtMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

