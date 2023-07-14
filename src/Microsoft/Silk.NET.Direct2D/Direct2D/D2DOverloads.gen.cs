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

namespace Silk.NET.Direct2D
{
    public static class D2DOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 5 in d2d1_2.h")]
        public static unsafe float D2D1ComputeMaximumScaleFactor(this D2D thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            return thisApi.D2D1ComputeMaximumScaleFactor(in matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDevice(this D2D thisApi, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ID2D1Device** d2dDevice)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDevice(dxgiDevice, in creationProperties.GetPinnableReference(), d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDevice(this D2D thisApi, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ref ID2D1Device* d2dDevice)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDevice(dxgiDevice, in creationProperties.GetPinnableReference(), ref d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDevice(this D2D thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ID2D1Device** d2dDevice)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDevice(ref dxgiDevice.GetPinnableReference(), creationProperties, d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDevice(this D2D thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ID2D1Device* d2dDevice)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDevice(ref dxgiDevice.GetPinnableReference(), creationProperties, ref d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDevice(this D2D thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ID2D1Device** d2dDevice)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDevice(ref dxgiDevice.GetPinnableReference(), in creationProperties.GetPinnableReference(), d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDevice(this D2D thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ref ID2D1Device* d2dDevice)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDevice(ref dxgiDevice.GetPinnableReference(), in creationProperties.GetPinnableReference(), ref d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDeviceContext(this D2D thisApi, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ID2D1DeviceContext** d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDeviceContext(dxgiSurface, in creationProperties.GetPinnableReference(), d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDeviceContext(this D2D thisApi, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ref ID2D1DeviceContext* d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDeviceContext(dxgiSurface, in creationProperties.GetPinnableReference(), ref d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDeviceContext(this D2D thisApi, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), creationProperties, d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDeviceContext(this D2D thisApi, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ID2D1DeviceContext* d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), creationProperties, ref d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDeviceContext(this D2D thisApi, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ID2D1DeviceContext** d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), in creationProperties.GetPinnableReference(), d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int D2D1CreateDeviceContext(this D2D thisApi, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreationProperties> creationProperties, ref ID2D1DeviceContext* d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.D2D1CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), in creationProperties.GetPinnableReference(), ref d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2463, Column 5 in d2d1_1.h")]
        public static unsafe Silk.NET.DXGI.D3Dcolorvalue D2D1ConvertColorSpace(this D2D thisApi, ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color)
        {
            // SpanOverloader
            return thisApi.D2D1ConvertColorSpace(sourceColorSpace, destinationColorSpace, in color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        public static unsafe void D2D1SinCos(this D2D thisApi, float angle, float* s, Span<float> c)
        {
            // SpanOverloader
            thisApi.D2D1SinCos(angle, s, ref c.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        public static unsafe void D2D1SinCos(this D2D thisApi, float angle, Span<float> s, float* c)
        {
            // SpanOverloader
            thisApi.D2D1SinCos(angle, ref s.GetPinnableReference(), c);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        public static unsafe void D2D1SinCos(this D2D thisApi, float angle, Span<float> s, Span<float> c)
        {
            // SpanOverloader
            thisApi.D2D1SinCos(angle, ref s.GetPinnableReference(), ref c.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int D2D1CreateFactory(this D2D thisApi, FactoryType factoryType, Guid* riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FactoryOptions> pFactoryOptions, void** ppIFactory)
        {
            // SpanOverloader
            return thisApi.D2D1CreateFactory(factoryType, riid, in pFactoryOptions.GetPinnableReference(), ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int D2D1CreateFactory(this D2D thisApi, FactoryType factoryType, Guid* riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FactoryOptions> pFactoryOptions, ref void* ppIFactory)
        {
            // SpanOverloader
            return thisApi.D2D1CreateFactory(factoryType, riid, in pFactoryOptions.GetPinnableReference(), ref ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int D2D1CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FactoryOptions* pFactoryOptions, void** ppIFactory)
        {
            // SpanOverloader
            return thisApi.D2D1CreateFactory(factoryType, ref riid.GetPinnableReference(), pFactoryOptions, ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int D2D1CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FactoryOptions* pFactoryOptions, ref void* ppIFactory)
        {
            // SpanOverloader
            return thisApi.D2D1CreateFactory(factoryType, ref riid.GetPinnableReference(), pFactoryOptions, ref ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int D2D1CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FactoryOptions> pFactoryOptions, void** ppIFactory)
        {
            // SpanOverloader
            return thisApi.D2D1CreateFactory(factoryType, ref riid.GetPinnableReference(), in pFactoryOptions.GetPinnableReference(), ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int D2D1CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FactoryOptions> pFactoryOptions, ref void* ppIFactory)
        {
            // SpanOverloader
            return thisApi.D2D1CreateFactory(factoryType, ref riid.GetPinnableReference(), in pFactoryOptions.GetPinnableReference(), ref ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3676, Column 5 in d2d1.h")]
        public static unsafe void D2D1MakeRotateMatrix(this D2D thisApi, float angle, Silk.NET.Maths.Vector2D<float> center, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            thisApi.D2D1MakeRotateMatrix(angle, center, ref matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 5 in d2d1.h")]
        public static unsafe void D2D1MakeSkewMatrix(this D2D thisApi, float angleX, float angleY, Silk.NET.Maths.Vector2D<float> center, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            thisApi.D2D1MakeSkewMatrix(angleX, angleY, center, ref matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3691, Column 5 in d2d1.h")]
        public static unsafe Silk.NET.Core.Bool32 D2D1IsMatrixInvertible(this D2D thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            return thisApi.D2D1IsMatrixInvertible(in matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3696, Column 5 in d2d1.h")]
        public static unsafe Silk.NET.Core.Bool32 D2D1InvertMatrix(this D2D thisApi, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            return thisApi.D2D1InvertMatrix(ref matrix.GetPinnableReference());
        }

    }
}

