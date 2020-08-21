// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVQueryResourceTagOverloads
    {
        public static unsafe void DeleteQueryResourceTag(this NVQueryResourceTag thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> tagIds)
        {
            // SpanOverloader
            thisApi.DeleteQueryResourceTag(n, in tagIds.GetPinnableReference());
        }

        public static unsafe void GenQueryResourceTag(this NVQueryResourceTag thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<int> tagIds)
        {
            // SpanOverloader
            thisApi.GenQueryResourceTag(n, out tagIds.GetPinnableReference());
        }

        public static unsafe void QueryResourceTag(this NVQueryResourceTag thisApi, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] ReadOnlySpan<byte> tagString)
        {
            // SpanOverloader
            thisApi.QueryResourceTag(tagId, in tagString.GetPinnableReference());
        }

    }
}

