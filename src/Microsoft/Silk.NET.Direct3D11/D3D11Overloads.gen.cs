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

namespace Silk.NET.Direct3D11
{
    public static class D3D11Overloads
    {
        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14447, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, IDXGIAdapter* pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, HINSTANCE__* Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14521, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<IDXGIAdapter> pAdapter, D3DDriverType DriverType, Span<HINSTANCE__> Software, uint Flags, Span<D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, Span<DXGI_SWAP_CHAIN_DESC> pSwapChainDesc, ref IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, ref Software.GetPinnableReference(), Flags, ref pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

    }
}

