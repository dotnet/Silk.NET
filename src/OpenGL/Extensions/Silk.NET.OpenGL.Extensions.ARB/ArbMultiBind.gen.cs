// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_multi_bind")]
    public unsafe partial class ArbMultiBind : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_bind";
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public unsafe partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public unsafe partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Texture textures);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public unsafe partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public unsafe partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Sampler* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Sampler samplers);

        [NativeApi(EntryPoint = "glBindTextures")]
        public unsafe partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public unsafe partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Texture textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        public ArbMultiBind(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

