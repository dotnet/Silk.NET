// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_tessellation_shader")]
    public abstract unsafe partial class ArbTessellationShader : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameteri")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract unsafe void PatchParameter([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameteri")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract unsafe void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        public ArbTessellationShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

