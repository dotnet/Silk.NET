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

namespace Silk.NET.DXVA
{
    public static class DXVAOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public static unsafe int HDCreateDevice(this DXVA thisApi, Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HDContentDesc> pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice)
        {
            // SpanOverloader
            return thisApi.HDCreateDevice(pD3DDevice, in pContentDesc.GetPinnableReference(), Usage, pPlugin, ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public static unsafe int HDCreateDevice(this DXVA thisApi, Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HDContentDesc> pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice)
        {
            // SpanOverloader
            return thisApi.HDCreateDevice(pD3DDevice, in pContentDesc.GetPinnableReference(), Usage, pPlugin, ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public static unsafe int HDCreateDevice(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9Ex> pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice)
        {
            // SpanOverloader
            return thisApi.HDCreateDevice(ref pD3DDevice.GetPinnableReference(), pContentDesc, Usage, pPlugin, ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public static unsafe int HDCreateDevice(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9Ex> pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice)
        {
            // SpanOverloader
            return thisApi.HDCreateDevice(ref pD3DDevice.GetPinnableReference(), pContentDesc, Usage, pPlugin, ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public static unsafe int HDCreateDevice(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9Ex> pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HDContentDesc> pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice)
        {
            // SpanOverloader
            return thisApi.HDCreateDevice(ref pD3DDevice.GetPinnableReference(), in pContentDesc.GetPinnableReference(), Usage, pPlugin, ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public static unsafe int HDCreateDevice(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9Ex> pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HDContentDesc> pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice)
        {
            // SpanOverloader
            return thisApi.HDCreateDevice(ref pD3DDevice.GetPinnableReference(), in pContentDesc.GetPinnableReference(), Usage, pPlugin, ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateDirect3DDeviceManager9(this DXVA thisApi, Span<uint> pResetToken, IDirect3DDeviceManager9** ppDeviceManager)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateDirect3DDeviceManager9(ref pResetToken.GetPinnableReference(), ppDeviceManager);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateDirect3DDeviceManager9(this DXVA thisApi, Span<uint> pResetToken, ref IDirect3DDeviceManager9* ppDeviceManager)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateDirect3DDeviceManager9(ref pResetToken.GetPinnableReference(), ref ppDeviceManager);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateVideoService(this DXVA thisApi, Silk.NET.Direct3D9.IDirect3DDevice9* pDD, Span<Guid> riid, void** ppService)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateVideoService(pDD, ref riid.GetPinnableReference(), ppService);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateVideoService(this DXVA thisApi, Silk.NET.Direct3D9.IDirect3DDevice9* pDD, Span<Guid> riid, ref void* ppService)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateVideoService(pDD, ref riid.GetPinnableReference(), ref ppService);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateVideoService(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9> pDD, Guid* riid, void** ppService)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateVideoService(ref pDD.GetPinnableReference(), riid, ppService);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateVideoService(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9> pDD, Guid* riid, ref void* ppService)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateVideoService(ref pDD.GetPinnableReference(), riid, ref ppService);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateVideoService(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9> pDD, Span<Guid> riid, void** ppService)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateVideoService(ref pDD.GetPinnableReference(), ref riid.GetPinnableReference(), ppService);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public static unsafe int DXVA2CreateVideoService(this DXVA thisApi, Span<Silk.NET.Direct3D9.IDirect3DDevice9> pDD, Span<Guid> riid, ref void* ppService)
        {
            // SpanOverloader
            return thisApi.DXVA2CreateVideoService(ref pDD.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppService);
        }

    }
}

