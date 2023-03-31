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
    public static class NVQueryResourceTagOverloads
    {
        public static unsafe void DeleteQueryResourceTag(this NVQueryResourceTag thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> tagIds)
        {
            // SpanOverloader
            thisApi.DeleteQueryResourceTag(n, in tagIds.GetPinnableReference());
        }

        public static unsafe void GenQueryResourceTag(this NVQueryResourceTag thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> tagIds)
        {
            // SpanOverloader
            thisApi.GenQueryResourceTag(n, out tagIds.GetPinnableReference());
        }

        public static unsafe void QueryResourceTag(this NVQueryResourceTag thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int tagId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tagString)
        {
            // SpanOverloader
            thisApi.QueryResourceTag(tagId, in tagString.GetPinnableReference());
        }

    }
}

