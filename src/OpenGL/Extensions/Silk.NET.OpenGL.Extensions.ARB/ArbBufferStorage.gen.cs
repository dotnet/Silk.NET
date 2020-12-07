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
    [Extension("ARB_buffer_storage")]
    public unsafe partial class ArbBufferStorage : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_buffer_storage";
        [NativeApi(EntryPoint = "glBufferStorage")]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public partial void BufferStorage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferStorage")]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public partial void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        public ArbBufferStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

