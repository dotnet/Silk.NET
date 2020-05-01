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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_icd")]
    public abstract unsafe partial class KhrIcd : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_icd";
        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR")]
        public abstract unsafe int IcdGetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* platforms, [Flow(FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clIcdGetPlatformIDsKHR")]
        public abstract int IcdGetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms);

        public KhrIcd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

