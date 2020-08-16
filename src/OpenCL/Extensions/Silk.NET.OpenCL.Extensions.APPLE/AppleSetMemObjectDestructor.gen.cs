// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    [Extension("APPLE_SetMemObjectDestructor")]
    public unsafe partial class AppleSetMemObjectDestructor : NativeExtension<CL>
    {
        public const string ExtensionName = "APPLE_SetMemObjectDestructor";
        [NativeApi(EntryPoint = "clSetMemObjectDestructorAPPLE")]
        public unsafe partial int SetMemObjectDestructor([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorAPPLE")]
        public partial int SetMemObjectDestructor<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        public unsafe int SetMemObjectDestructor([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetMemObjectDestructor(new IntPtr(memobj), pfn_notify, user_data);
        }

        public unsafe int SetMemObjectDestructor<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetMemObjectDestructor(new IntPtr(memobj), pfn_notify, user_data);
        }

        public AppleSetMemObjectDestructor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

