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
    [Extension("KHR_il_program")]
    public abstract unsafe partial class KhrIlProgram : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clCreateProgramWithILKHR")]
        public abstract unsafe IntPtr CreateProgramWithIL([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.Out)] int* errcode_ret);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clCreateProgramWithILKHR")]
        public abstract IntPtr CreateProgramWithIL<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        public unsafe IntPtr CreateProgramWithIL([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithIL(new IntPtr(context), il, new UIntPtr(length), errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithIL<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateProgramWithIL(new IntPtr(context), il, new UIntPtr(length), errcode_ret);
        }

        public KhrIlProgram(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

