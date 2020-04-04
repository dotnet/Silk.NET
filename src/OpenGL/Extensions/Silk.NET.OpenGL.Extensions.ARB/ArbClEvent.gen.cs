// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_cl_event")]
    public abstract unsafe partial class ArbClEvent : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateSyncFromCLeventARB")]
        public abstract unsafe IntPtr CreateSyncFromCLevent([Flow(FlowDirection.Out)] IntPtr* context, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateSyncFromCLeventARB")]
        public abstract IntPtr CreateSyncFromCLevent([Flow(FlowDirection.Out)] Span<IntPtr> context, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.In)] uint flags);

        public ArbClEvent(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

