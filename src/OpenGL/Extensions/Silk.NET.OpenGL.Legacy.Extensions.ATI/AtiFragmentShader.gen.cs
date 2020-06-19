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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_fragment_shader")]
    public abstract unsafe partial class AtiFragmentShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_fragment_shader";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI")]
        public abstract void AlphaFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI")]
        public abstract void AlphaFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        /// <param name="arg3">
        /// To be added.
        /// </param>
        /// <param name="arg3Rep">
        /// To be added.
        /// </param>
        /// <param name="arg3Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI")]
        public abstract void AlphaFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glBeginFragmentShaderATI")]
        public abstract void BeginFragmentShader();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragmentShaderATI")]
        public abstract void BindFragmentShader([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMask">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFragmentOp1ATI")]
        public abstract void ColorFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMask">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFragmentOp2ATI")]
        public abstract void ColorFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMask">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        /// <param name="arg3">
        /// To be added.
        /// </param>
        /// <param name="arg3Rep">
        /// To be added.
        /// </param>
        /// <param name="arg3Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFragmentOp3ATI")]
        public abstract void ColorFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteFragmentShaderATI")]
        public abstract void DeleteFragmentShader([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndFragmentShaderATI")]
        public abstract void EndFragmentShader();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenFragmentShadersATI")]
        public abstract uint GenFragmentShaders([Flow(FlowDirection.In)] uint range);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="swizzle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPassTexCoordATI")]
        public abstract void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] ATI swizzle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="interp">
        /// To be added.
        /// </param>
        /// <param name="swizzle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleMapATI")]
        public abstract void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] ATI swizzle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI")]
        public abstract unsafe void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] float* value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI")]
        public abstract void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI")]
        public abstract void AlphaFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI")]
        public abstract void AlphaFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        /// <param name="arg3">
        /// To be added.
        /// </param>
        /// <param name="arg3Rep">
        /// To be added.
        /// </param>
        /// <param name="arg3Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI")]
        public abstract void AlphaFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMask">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFragmentOp1ATI")]
        public abstract void ColorFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMask">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFragmentOp2ATI")]
        public abstract void ColorFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="dstMask">
        /// To be added.
        /// </param>
        /// <param name="dstMod">
        /// To be added.
        /// </param>
        /// <param name="arg1">
        /// To be added.
        /// </param>
        /// <param name="arg1Rep">
        /// To be added.
        /// </param>
        /// <param name="arg1Mod">
        /// To be added.
        /// </param>
        /// <param name="arg2">
        /// To be added.
        /// </param>
        /// <param name="arg2Rep">
        /// To be added.
        /// </param>
        /// <param name="arg2Mod">
        /// To be added.
        /// </param>
        /// <param name="arg3">
        /// To be added.
        /// </param>
        /// <param name="arg3Rep">
        /// To be added.
        /// </param>
        /// <param name="arg3Mod">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFragmentOp3ATI")]
        public abstract void ColorFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="swizzle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPassTexCoordATI")]
        public abstract void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] SwizzleOpATI swizzle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="dst">
        /// To be added.
        /// </param>
        /// <param name="interp">
        /// To be added.
        /// </param>
        /// <param name="swizzle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleMapATI")]
        public abstract void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] SwizzleOpATI swizzle);

        public AtiFragmentShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

