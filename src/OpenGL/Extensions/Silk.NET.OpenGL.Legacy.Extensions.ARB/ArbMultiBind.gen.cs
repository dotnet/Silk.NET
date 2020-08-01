// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_multi_bind")]
    public unsafe partial class ArbMultiBind : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_bind";
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial unsafe void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial unsafe void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial unsafe void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial unsafe void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> strides);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial unsafe void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        public ArbMultiBind(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

