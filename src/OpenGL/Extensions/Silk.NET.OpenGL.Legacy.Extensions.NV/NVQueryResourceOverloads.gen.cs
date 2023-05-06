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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVQueryResourceOverloads
    {
        public static unsafe int QueryResource(this NVQueryResource thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV queryType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int tagId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> buffer)
        {
            // SpanOverloader
            return thisApi.QueryResource(queryType, tagId, count, out buffer.GetPinnableReference());
        }

    }
}

