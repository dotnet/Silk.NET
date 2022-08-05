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
        public static unsafe float ComputeMaximumScaleFactor(this D2D thisApi, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            return thisApi.ComputeMaximumScaleFactor(ref matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDevice(this D2D thisApi, IDXGIDevice* dxgiDevice, Span<CreationProperties> creationProperties, ID2D1Device** d2dDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(dxgiDevice, ref creationProperties.GetPinnableReference(), d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDevice(this D2D thisApi, IDXGIDevice* dxgiDevice, Span<CreationProperties> creationProperties, ref ID2D1Device* d2dDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(dxgiDevice, ref creationProperties.GetPinnableReference(), ref d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDevice(this D2D thisApi, Span<IDXGIDevice> dxgiDevice, CreationProperties* creationProperties, ID2D1Device** d2dDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), creationProperties, d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDevice(this D2D thisApi, Span<IDXGIDevice> dxgiDevice, CreationProperties* creationProperties, ref ID2D1Device* d2dDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), creationProperties, ref d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDevice(this D2D thisApi, Span<IDXGIDevice> dxgiDevice, Span<CreationProperties> creationProperties, ID2D1Device** d2dDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), ref creationProperties.GetPinnableReference(), d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDevice(this D2D thisApi, Span<IDXGIDevice> dxgiDevice, Span<CreationProperties> creationProperties, ref ID2D1Device* d2dDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), ref creationProperties.GetPinnableReference(), ref d2dDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDeviceContext(this D2D thisApi, IDXGISurface* dxgiSurface, Span<CreationProperties> creationProperties, ID2D1DeviceContext** d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceContext(dxgiSurface, ref creationProperties.GetPinnableReference(), d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDeviceContext(this D2D thisApi, IDXGISurface* dxgiSurface, Span<CreationProperties> creationProperties, ref ID2D1DeviceContext* d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceContext(dxgiSurface, ref creationProperties.GetPinnableReference(), ref d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDeviceContext(this D2D thisApi, Span<IDXGISurface> dxgiSurface, CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), creationProperties, d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDeviceContext(this D2D thisApi, Span<IDXGISurface> dxgiSurface, CreationProperties* creationProperties, ref ID2D1DeviceContext* d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), creationProperties, ref d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDeviceContext(this D2D thisApi, Span<IDXGISurface> dxgiSurface, Span<CreationProperties> creationProperties, ID2D1DeviceContext** d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), ref creationProperties.GetPinnableReference(), d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public static unsafe int CreateDeviceContext(this D2D thisApi, Span<IDXGISurface> dxgiSurface, Span<CreationProperties> creationProperties, ref ID2D1DeviceContext* d2dDeviceContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceContext(ref dxgiSurface.GetPinnableReference(), ref creationProperties.GetPinnableReference(), ref d2dDeviceContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2463, Column 5 in d2d1_1.h")]
        public static unsafe _D3DCOLORVALUE ConvertColorSpace(this D2D thisApi, ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, Span<_D3DCOLORVALUE> color)
        {
            // SpanOverloader
            return thisApi.ConvertColorSpace(sourceColorSpace, destinationColorSpace, ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        public static unsafe void SinCos(this D2D thisApi, float angle, float* s, Span<float> c)
        {
            // SpanOverloader
            thisApi.SinCos(angle, s, ref c.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        public static unsafe void SinCos(this D2D thisApi, float angle, Span<float> s, float* c)
        {
            // SpanOverloader
            thisApi.SinCos(angle, ref s.GetPinnableReference(), c);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        public static unsafe void SinCos(this D2D thisApi, float angle, Span<float> s, Span<float> c)
        {
            // SpanOverloader
            thisApi.SinCos(angle, ref s.GetPinnableReference(), ref c.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int CreateFactory(this D2D thisApi, FactoryType factoryType, Guid* riid, Span<FactoryOptions> pFactoryOptions, void** ppIFactory)
        {
            // SpanOverloader
            return thisApi.CreateFactory(factoryType, riid, ref pFactoryOptions.GetPinnableReference(), ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int CreateFactory(this D2D thisApi, FactoryType factoryType, Guid* riid, Span<FactoryOptions> pFactoryOptions, ref void* ppIFactory)
        {
            // SpanOverloader
            return thisApi.CreateFactory(factoryType, riid, ref pFactoryOptions.GetPinnableReference(), ref ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, FactoryOptions* pFactoryOptions, void** ppIFactory)
        {
            // SpanOverloader
            return thisApi.CreateFactory(factoryType, ref riid.GetPinnableReference(), pFactoryOptions, ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, FactoryOptions* pFactoryOptions, ref void* ppIFactory)
        {
            // SpanOverloader
            return thisApi.CreateFactory(factoryType, ref riid.GetPinnableReference(), pFactoryOptions, ref ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, Span<FactoryOptions> pFactoryOptions, void** ppIFactory)
        {
            // SpanOverloader
            return thisApi.CreateFactory(factoryType, ref riid.GetPinnableReference(), ref pFactoryOptions.GetPinnableReference(), ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        public static unsafe int CreateFactory(this D2D thisApi, FactoryType factoryType, Span<Guid> riid, Span<FactoryOptions> pFactoryOptions, ref void* ppIFactory)
        {
            // SpanOverloader
            return thisApi.CreateFactory(factoryType, ref riid.GetPinnableReference(), ref pFactoryOptions.GetPinnableReference(), ref ppIFactory);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3676, Column 5 in d2d1.h")]
        public static unsafe void MakeRotateMatrix(this D2D thisApi, float angle, D2D_POINT_2F center, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            thisApi.MakeRotateMatrix(angle, center, ref matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 5 in d2d1.h")]
        public static unsafe void MakeSkewMatrix(this D2D thisApi, float angleX, float angleY, D2D_POINT_2F center, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            thisApi.MakeSkewMatrix(angleX, angleY, center, ref matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3691, Column 5 in d2d1.h")]
        public static unsafe int IsMatrixInvertible(this D2D thisApi, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            return thisApi.IsMatrixInvertible(ref matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3696, Column 5 in d2d1.h")]
        public static unsafe int InvertMatrix(this D2D thisApi, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
        {
            // SpanOverloader
            return thisApi.InvertMatrix(ref matrix.GetPinnableReference());
        }

    }
}

