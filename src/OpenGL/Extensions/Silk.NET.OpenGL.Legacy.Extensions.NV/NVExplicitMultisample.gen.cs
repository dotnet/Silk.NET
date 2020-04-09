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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_explicit_multisample")]
    public abstract unsafe partial class NVExplicitMultisample : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] Span<float> val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleMaskIndexedNV")]
        public abstract void SampleMaskIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexRenderbufferNV")]
        public abstract void TexRenderbuffer([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] Span<float> val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexRenderbufferNV")]
        public abstract void TexRenderbuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        public NVExplicitMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

