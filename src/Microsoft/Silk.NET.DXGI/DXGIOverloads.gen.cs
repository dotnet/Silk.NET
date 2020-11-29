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

namespace Silk.NET.DXGI
{
    public static class DXGIOverloads
    {
        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 16 in dxgidebug.h")]
        public static unsafe int GetDebugInterface(this DXGI thisApi, Span<Guid> riid, void** ppDebug)
        {
            // SpanOverloader
            return thisApi.GetDebugInterface(ref riid.GetPinnableReference(), ppDebug);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 155, Column 16 in dxgidebug.h")]
        public static unsafe int GetDebugInterface(this DXGI thisApi, Span<Guid> riid, ref void* ppDebug)
        {
            // SpanOverloader
            return thisApi.GetDebugInterface(ref riid.GetPinnableReference(), ref ppDebug);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 113, Column 16 in dxgi1_3.h")]
        public static unsafe int CreateDXGIFactory2(this DXGI thisApi, uint Flags, Span<Guid> riid, void** ppFactory)
        {
            // SpanOverloader
            return thisApi.CreateDXGIFactory2(Flags, ref riid.GetPinnableReference(), ppFactory);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 113, Column 16 in dxgi1_3.h")]
        public static unsafe int CreateDXGIFactory2(this DXGI thisApi, uint Flags, Span<Guid> riid, ref void* ppFactory)
        {
            // SpanOverloader
            return thisApi.CreateDXGIFactory2(Flags, ref riid.GetPinnableReference(), ref ppFactory);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 114, Column 16 in dxgi1_3.h")]
        public static unsafe int GetDebugInterface1(this DXGI thisApi, uint Flags, Span<Guid> riid, void** pDebug)
        {
            // SpanOverloader
            return thisApi.GetDebugInterface1(Flags, ref riid.GetPinnableReference(), pDebug);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 114, Column 16 in dxgi1_3.h")]
        public static unsafe int GetDebugInterface1(this DXGI thisApi, uint Flags, Span<Guid> riid, ref void* pDebug)
        {
            // SpanOverloader
            return thisApi.GetDebugInterface1(Flags, ref riid.GetPinnableReference(), ref pDebug);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 2165, Column 16 in dxgi.h")]
        public static unsafe int CreateDXGIFactory(this DXGI thisApi, Span<Guid> riid, void** ppFactory)
        {
            // SpanOverloader
            return thisApi.CreateDXGIFactory(ref riid.GetPinnableReference(), ppFactory);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 2165, Column 16 in dxgi.h")]
        public static unsafe int CreateDXGIFactory(this DXGI thisApi, Span<Guid> riid, ref void* ppFactory)
        {
            // SpanOverloader
            return thisApi.CreateDXGIFactory(ref riid.GetPinnableReference(), ref ppFactory);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 2168, Column 16 in dxgi.h")]
        public static unsafe int CreateDXGIFactory1(this DXGI thisApi, Span<Guid> riid, void** ppFactory)
        {
            // SpanOverloader
            return thisApi.CreateDXGIFactory1(ref riid.GetPinnableReference(), ppFactory);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 2168, Column 16 in dxgi.h")]
        public static unsafe int CreateDXGIFactory1(this DXGI thisApi, Span<Guid> riid, ref void* ppFactory)
        {
            // SpanOverloader
            return thisApi.CreateDXGIFactory1(ref riid.GetPinnableReference(), ref ppFactory);
        }

    }
}

