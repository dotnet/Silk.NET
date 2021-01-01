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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_map_buffer_range")]
    public unsafe partial class ExtMapBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_map_buffer_range";
        [NativeApi(EntryPoint = "glFlushMappedBufferRangeEXT")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeEXT")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glMapBufferRangeEXT")]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMapBufferRangeEXT")]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] uint access);

        public ExtMapBufferRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

