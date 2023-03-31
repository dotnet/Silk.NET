// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_query_resource")]
    public unsafe partial class NVQueryResource : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource";
        [NativeApi(EntryPoint = "glQueryResourceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int QueryResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV queryType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int tagId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* buffer);

        [NativeApi(EntryPoint = "glQueryResourceNV", Convention = CallingConvention.Winapi)]
        public partial int QueryResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV queryType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int tagId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int buffer);

        public unsafe int QueryResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV queryType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int tagId, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> buffer)
        {
            // ImplicitCountSpanOverloader
            return QueryResource(queryType, tagId, (uint) buffer.Length, out buffer.GetPinnableReference());
        }

        public NVQueryResource(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

