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

namespace Silk.NET.Direct3D.Compilers
{
    public static class DXCOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance(this DXC thisApi, Guid* rclsid, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance(rclsid, ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance(this DXC thisApi, Guid* rclsid, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance(rclsid, ref riid.GetPinnableReference(), ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance(this DXC thisApi, Span<Guid> rclsid, Guid* riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance(ref rclsid.GetPinnableReference(), riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance(this DXC thisApi, Span<Guid> rclsid, Guid* riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance(ref rclsid.GetPinnableReference(), riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance(this DXC thisApi, Span<Guid> rclsid, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance(ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance(this DXC thisApi, Span<Guid> rclsid, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance(ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, IMalloc* pMalloc, Guid* rclsid, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(pMalloc, rclsid, ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, IMalloc* pMalloc, Guid* rclsid, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(pMalloc, rclsid, ref riid.GetPinnableReference(), ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, IMalloc* pMalloc, Span<Guid> rclsid, Guid* riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(pMalloc, ref rclsid.GetPinnableReference(), riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, IMalloc* pMalloc, Span<Guid> rclsid, Guid* riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(pMalloc, ref rclsid.GetPinnableReference(), riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, IMalloc* pMalloc, Span<Guid> rclsid, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(pMalloc, ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, IMalloc* pMalloc, Span<Guid> rclsid, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(pMalloc, ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Guid* rclsid, Guid* riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), rclsid, riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Guid* rclsid, Guid* riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), rclsid, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Guid* rclsid, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), rclsid, ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Guid* rclsid, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), rclsid, ref riid.GetPinnableReference(), ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Span<Guid> rclsid, Guid* riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), ref rclsid.GetPinnableReference(), riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Span<Guid> rclsid, Guid* riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), ref rclsid.GetPinnableReference(), riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Span<Guid> rclsid, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public static unsafe int CreateInstance2(this DXC thisApi, Span<IMalloc> pMalloc, Span<Guid> rclsid, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateInstance2(ref pMalloc.GetPinnableReference(), ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
        }

    }
}

