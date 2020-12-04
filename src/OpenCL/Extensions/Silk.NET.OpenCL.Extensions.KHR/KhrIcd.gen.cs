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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_icd")]
    public unsafe partial class KhrIcd : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_icd";
        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR")]
        public unsafe partial int IcdGetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* platforms, [Flow(FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR")]
        public unsafe partial int IcdGetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* platforms, [Flow(FlowDirection.Out)] out uint num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR")]
        public unsafe partial int IcdGetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr platforms, [Flow(FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR")]
        public partial int IcdGetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr platforms, [Flow(FlowDirection.Out)] out uint num_platforms);

        public KhrIcd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

