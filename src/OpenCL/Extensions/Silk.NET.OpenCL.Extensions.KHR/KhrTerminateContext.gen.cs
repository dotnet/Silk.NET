// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_terminate_context")]
    public abstract unsafe partial class KhrTerminateContext : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clTerminateContextKHR")]
        public abstract int TerminateContext([Flow(FlowDirection.In)] IntPtr context);

        public unsafe int TerminateContext([Flow(FlowDirection.In)] int context)
        {
            // IntPtrOverloader
            return TerminateContext(new IntPtr(context));
        }

        public KhrTerminateContext(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

