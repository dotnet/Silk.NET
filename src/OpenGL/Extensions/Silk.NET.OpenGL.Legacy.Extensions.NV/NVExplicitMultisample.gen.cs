// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_explicit_multisample")]
    public unsafe partial class NVExplicitMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_explicit_multisample";
        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public unsafe partial void GetMultisample([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public partial void GetMultisample([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public unsafe partial void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefvNV")]
        public partial void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glSampleMaskIndexedNV")]
        public partial void SampleMaskIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexRenderbufferNV")]
        public partial void TexRenderbuffer([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glTexRenderbufferNV")]
        public partial void TexRenderbuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        public NVExplicitMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

