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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_flush_buffer_range")]
    public unsafe partial class AppleFlushBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_flush_buffer_range";
        [NativeApi(EntryPoint = "glBufferParameteriAPPLE")]
        public partial void BufferParameter([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        public AppleFlushBufferRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

