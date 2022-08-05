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
    public unsafe partial class D2D : NativeAPI
    {
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "sc_redShift")]
        public const uint ScRedShift = unchecked((uint) 0x10);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "sc_greenShift")]
        public const uint ScGreenShift = unchecked((uint) 0x8);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "sc_blueShift")]
        public const uint ScBlueShift = unchecked((uint) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FACILITY_D2D")]
        public const int FacilityD2D = unchecked((int) 0x899);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D2D1_APPEND_ALIGNED_ELEMENT")]
        public const uint AppendAlignedElement = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D2D1_INVALID_PROPERTY_INDEX")]
        public const uint InvalidPropertyIndex = unchecked((uint) 0xFFFFFFFFFFFFFFFF);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 5 in d2d1_2.h")]
        [NativeApi(EntryPoint = "D2D1ComputeMaximumScaleFactor", Convention = CallingConvention.StdCall)]
        public unsafe partial float ComputeMaximumScaleFactor(Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 5 in d2d1_2.h")]
        [NativeApi(EntryPoint = "D2D1ComputeMaximumScaleFactor", Convention = CallingConvention.StdCall)]
        public partial float ComputeMaximumScaleFactor(ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(IDXGIDevice* dxgiDevice, CreationProperties* creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(IDXGIDevice* dxgiDevice, CreationProperties* creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(IDXGIDevice* dxgiDevice, ref CreationProperties creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(IDXGIDevice* dxgiDevice, ref CreationProperties creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref IDXGIDevice dxgiDevice, CreationProperties* creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref IDXGIDevice dxgiDevice, CreationProperties* creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref IDXGIDevice dxgiDevice, ref CreationProperties creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref IDXGIDevice dxgiDevice, ref CreationProperties creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(IDXGISurface* dxgiSurface, CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(IDXGISurface* dxgiSurface, CreationProperties* creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(IDXGISurface* dxgiSurface, ref CreationProperties creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(IDXGISurface* dxgiSurface, ref CreationProperties creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(ref IDXGISurface dxgiSurface, CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(ref IDXGISurface dxgiSurface, CreationProperties* creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(ref IDXGISurface dxgiSurface, ref CreationProperties creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceContext(ref IDXGISurface dxgiSurface, ref CreationProperties creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2463, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1ConvertColorSpace", Convention = CallingConvention.StdCall)]
        public unsafe partial _D3DCOLORVALUE ConvertColorSpace(ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, _D3DCOLORVALUE* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2463, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1ConvertColorSpace", Convention = CallingConvention.StdCall)]
        public partial _D3DCOLORVALUE ConvertColorSpace(ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, ref _D3DCOLORVALUE color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public unsafe partial void SinCos(float angle, float* s, float* c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public unsafe partial void SinCos(float angle, float* s, ref float c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public unsafe partial void SinCos(float angle, ref float s, float* c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public partial void SinCos(float angle, ref float s, ref float c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1Tan", Convention = CallingConvention.StdCall)]
        public partial float Tan(float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2482, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1Vec3Length", Convention = CallingConvention.StdCall)]
        public partial float Vec3Length(float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, Guid* riid, FactoryOptions* pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, Guid* riid, FactoryOptions* pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, Guid* riid, ref FactoryOptions pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, Guid* riid, ref FactoryOptions pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, ref Guid riid, FactoryOptions* pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, ref Guid riid, FactoryOptions* pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, ref Guid riid, ref FactoryOptions pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFactory(FactoryType factoryType, ref Guid riid, ref FactoryOptions pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3676, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeRotateMatrix", Convention = CallingConvention.StdCall)]
        public unsafe partial void MakeRotateMatrix(float angle, D2D_POINT_2F center, Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3676, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeRotateMatrix", Convention = CallingConvention.StdCall)]
        public partial void MakeRotateMatrix(float angle, D2D_POINT_2F center, ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeSkewMatrix", Convention = CallingConvention.StdCall)]
        public unsafe partial void MakeSkewMatrix(float angleX, float angleY, D2D_POINT_2F center, Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeSkewMatrix", Convention = CallingConvention.StdCall)]
        public partial void MakeSkewMatrix(float angleX, float angleY, D2D_POINT_2F center, ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3691, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1IsMatrixInvertible", Convention = CallingConvention.StdCall)]
        public unsafe partial int IsMatrixInvertible(Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3691, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1IsMatrixInvertible", Convention = CallingConvention.StdCall)]
        public partial int IsMatrixInvertible(ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3696, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1InvertMatrix", Convention = CallingConvention.StdCall)]
        public unsafe partial int InvertMatrix(Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3696, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1InvertMatrix", Convention = CallingConvention.StdCall)]
        public partial int InvertMatrix(ref Silk.NET.Maths.Matrix3X2<float> matrix);


        public D2D(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

