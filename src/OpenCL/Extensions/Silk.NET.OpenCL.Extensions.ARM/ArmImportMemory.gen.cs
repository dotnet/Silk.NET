// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Extension("ARM_import_memory")]
    public unsafe partial class ArmImportMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "ARM_import_memory";
        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public unsafe partial IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        public partial IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] in IntPtr properties, [Flow(FlowDirection.Out)] out T0 memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        public ArmImportMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

