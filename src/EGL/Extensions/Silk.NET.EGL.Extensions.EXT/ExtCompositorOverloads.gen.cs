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

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    public static class ExtCompositorOverloads
    {
        public static unsafe int CompositorSetContextAttributes(this ExtCompositor thisApi, [Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] ReadOnlySpan<int> context_attributes, [Flow(FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetContextAttributes(external_ref_id, in context_attributes.GetPinnableReference(), num_entries);
        }

        public static unsafe int CompositorSetContextList(this ExtCompositor thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<int> external_ref_ids, [Flow(FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetContextList(in external_ref_ids.GetPinnableReference(), num_entries);
        }

        public static unsafe int CompositorSetWindowAttributes(this ExtCompositor thisApi, [Flow(FlowDirection.In)] int external_win_id, [Flow(FlowDirection.In)] ReadOnlySpan<int> window_attributes, [Flow(FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetWindowAttributes(external_win_id, in window_attributes.GetPinnableReference(), num_entries);
        }

        public static unsafe int CompositorSetWindowList(this ExtCompositor thisApi, [Flow(FlowDirection.In)] int external_ref_id, [Flow(FlowDirection.In)] ReadOnlySpan<int> external_win_ids, [Flow(FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetWindowList(external_ref_id, in external_win_ids.GetPinnableReference(), num_entries);
        }

    }
}

