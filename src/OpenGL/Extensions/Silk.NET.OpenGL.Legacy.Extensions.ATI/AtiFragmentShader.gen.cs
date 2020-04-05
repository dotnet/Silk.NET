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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_fragment_shader")]
    public abstract unsafe partial class AtiFragmentShader : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI")]
        public abstract void AlphaFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI")]
        public abstract void AlphaFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI")]
        public abstract void AlphaFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginFragmentShaderATI")]
        public abstract void BeginFragmentShader();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragmentShaderATI")]
        public abstract void BindFragmentShader([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFragmentOp1ATI")]
        public abstract void ColorFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFragmentOp2ATI")]
        public abstract void ColorFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFragmentOp3ATI")]
        public abstract void ColorFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFragmentShaderATI")]
        public abstract void DeleteFragmentShader([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndFragmentShaderATI")]
        public abstract void EndFragmentShader();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFragmentShadersATI")]
        public abstract uint GenFragmentShaders([Flow(FlowDirection.In)] uint range);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPassTexCoordATI")]
        public abstract void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] ATI swizzle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleMapATI")]
        public abstract void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] ATI swizzle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI")]
        public abstract unsafe void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI")]
        public abstract void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI")]
        public abstract void AlphaFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI")]
        public abstract void AlphaFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI")]
        public abstract void AlphaFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFragmentOp1ATI")]
        public abstract void ColorFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFragmentOp2ATI")]
        public abstract void ColorFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFragmentOp3ATI")]
        public abstract void ColorFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPassTexCoordATI")]
        public abstract void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] SwizzleOpATI swizzle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleMapATI")]
        public abstract void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] SwizzleOpATI swizzle);

        public AtiFragmentShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

