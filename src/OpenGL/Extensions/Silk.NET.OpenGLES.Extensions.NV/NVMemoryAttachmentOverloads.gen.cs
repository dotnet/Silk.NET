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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVMemoryAttachmentOverloads
    {
        public static unsafe void GetMemoryObjectDetachedResources(this NVMemoryAttachment thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetMemoryObjectDetachedResources(memory, pname, first, count, out @params.GetPinnableReference());
        }

    }
}

