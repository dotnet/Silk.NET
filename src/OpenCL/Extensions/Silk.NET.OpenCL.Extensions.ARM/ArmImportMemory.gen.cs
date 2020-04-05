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

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Extension("ARM_import_memory")]
    public abstract unsafe partial class ArmImportMemory : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public abstract unsafe IntPtr ImportMemory([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] int* errcode_ret);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public abstract IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        public unsafe IntPtr ImportMemory([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return ImportMemory(new IntPtr(context), flags, properties, memory, new UIntPtr(size), errcode_ret);
        }

        public unsafe IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return ImportMemory(new IntPtr(context), flags, properties, memory, new UIntPtr(size), errcode_ret);
        }

        public ArmImportMemory(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

