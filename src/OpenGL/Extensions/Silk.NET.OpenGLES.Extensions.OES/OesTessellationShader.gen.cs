// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_tessellation_shader")]
    public abstract unsafe partial class OesTessellationShader : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameteriOES")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameteriOES")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        public OesTessellationShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

