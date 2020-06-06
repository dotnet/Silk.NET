// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_fragment_shader")]
    public unsafe partial class AtiFragmentShader : NativeExtension<GL>
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod)
            => ImplAlphaFragmentOp1(op, dst, dstMod, arg1, arg1Rep, arg1Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod)
            => ImplAlphaFragmentOp2(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod)
            => ImplAlphaFragmentOp3(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glBeginFragmentShaderATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginFragmentShader()
            => ImplBeginFragmentShader();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragmentShaderATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFragmentShader([Flow(FlowDirection.In)] uint id)
            => ImplBindFragmentShader(id);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod)
            => ImplColorFragmentOp1(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod)
            => ImplColorFragmentOp2(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod)
            => ImplColorFragmentOp3(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteFragmentShaderATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteFragmentShader([Flow(FlowDirection.In)] uint id)
            => ImplDeleteFragmentShader(id);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndFragmentShaderATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndFragmentShader()
            => ImplEndFragmentShader();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenFragmentShadersATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GenFragmentShaders([Flow(FlowDirection.In)] uint range)
            => ImplGenFragmentShaders(range);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] ATI swizzle)
            => ImplPassTexCoord(dst, coord, swizzle);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] ATI swizzle)
            => ImplSampleMap(dst, interp, swizzle);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] float* value)
            => ImplSetFragmentShaderConstant(dst, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> value)
            => ImplSetFragmentShaderConstant(dst, value);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod)
            => ImplAlphaFragmentOp1(op, dst, dstMod, arg1, arg1Rep, arg1Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod)
            => ImplAlphaFragmentOp2(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod)
            => ImplAlphaFragmentOp3(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod)
            => ImplColorFragmentOp1(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod)
            => ImplColorFragmentOp2(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod)
            => ImplColorFragmentOp3(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] SwizzleOpATI swizzle)
            => ImplPassTexCoord(dst, coord, swizzle);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] SwizzleOpATI swizzle)
            => ImplSampleMap(dst, interp, swizzle);

        public AtiFragmentShader(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

