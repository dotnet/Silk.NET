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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_explicit_multisample")]
    public unsafe partial class NVExplicitMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_explicit_multisample";
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
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultisample([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] float* val)
            => ImplGetMultisample(pname, index, val);

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
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultisample([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] Span<float> val)
            => ImplGetMultisample(pname, index, val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleMaskIndexedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SampleMaskIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint mask)
            => ImplSampleMaskIndexed(index, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexRenderbufferNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexRenderbuffer([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplTexRenderbuffer(target, renderbuffer);

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
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] float* val)
            => ImplGetMultisample(pname, index, val);

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
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] Span<float> val)
            => ImplGetMultisample(pname, index, val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexRenderbufferNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexRenderbuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplTexRenderbuffer(target, renderbuffer);

        public NVExplicitMultisample(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

