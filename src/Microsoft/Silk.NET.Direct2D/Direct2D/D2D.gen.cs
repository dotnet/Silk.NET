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
        public unsafe partial float D2D1ComputeMaximumScaleFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 5 in d2d1_2.h")]
        [NativeApi(EntryPoint = "D2D1ComputeMaximumScaleFactor", Convention = CallingConvention.StdCall)]
        public partial float D2D1ComputeMaximumScaleFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ID2D1Device** d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ID2D1Device* d2dDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ID2D1DeviceContext** d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1CreateDeviceContext", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateDeviceContext(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ID2D1DeviceContext* d2dDeviceContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2463, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1ConvertColorSpace", Convention = CallingConvention.StdCall)]
        public unsafe partial Silk.NET.DXGI.D3Dcolorvalue D2D1ConvertColorSpace(ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2463, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1ConvertColorSpace", Convention = CallingConvention.StdCall)]
        public partial Silk.NET.DXGI.D3Dcolorvalue D2D1ConvertColorSpace(ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1SinCos(float angle, float* s, float* c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1SinCos(float angle, float* s, ref float c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1SinCos(float angle, ref float s, float* c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1SinCos", Convention = CallingConvention.StdCall)]
        public partial void D2D1SinCos(float angle, ref float s, ref float c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1Tan", Convention = CallingConvention.StdCall)]
        public partial float D2D1Tan(float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2482, Column 5 in d2d1_1.h")]
        [NativeApi(EntryPoint = "D2D1Vec3Length", Convention = CallingConvention.StdCall)]
        public partial float D2D1Vec3Length(float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, Guid* riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FactoryOptions* pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, Guid* riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FactoryOptions* pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, Guid* riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FactoryOptions pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, Guid* riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FactoryOptions pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, ref Guid riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FactoryOptions* pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, ref Guid riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FactoryOptions* pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, ref Guid riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FactoryOptions pFactoryOptions, void** ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3667, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1CreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int D2D1CreateFactory(FactoryType factoryType, ref Guid riid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FactoryOptions pFactoryOptions, ref void* ppIFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3676, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeRotateMatrix", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1MakeRotateMatrix(float angle, Silk.NET.Maths.Vector2D<float> center, Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3676, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeRotateMatrix", Convention = CallingConvention.StdCall)]
        public partial void D2D1MakeRotateMatrix(float angle, Silk.NET.Maths.Vector2D<float> center, ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeSkewMatrix", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1MakeSkewMatrix(float angleX, float angleY, Silk.NET.Maths.Vector2D<float> center, Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1MakeSkewMatrix", Convention = CallingConvention.StdCall)]
        public partial void D2D1MakeSkewMatrix(float angleX, float angleY, Silk.NET.Maths.Vector2D<float> center, ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3691, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1IsMatrixInvertible", Convention = CallingConvention.StdCall)]
        public unsafe partial Silk.NET.Core.Bool32 D2D1IsMatrixInvertible([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3691, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1IsMatrixInvertible", Convention = CallingConvention.StdCall)]
        public partial Silk.NET.Core.Bool32 D2D1IsMatrixInvertible([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3696, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1InvertMatrix", Convention = CallingConvention.StdCall)]
        public unsafe partial Silk.NET.Core.Bool32 D2D1InvertMatrix(Silk.NET.Maths.Matrix3X2<float>* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3696, Column 5 in d2d1.h")]
        [NativeApi(EntryPoint = "D2D1InvertMatrix", Convention = CallingConvention.StdCall)]
        public partial Silk.NET.Core.Bool32 D2D1InvertMatrix(ref Silk.NET.Maths.Matrix3X2<float> matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDevice<TI0>(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDevice(dxgiDevice, creationProperties, (ID2D1Device**) d2dDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDevice<TI0>(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDevice(dxgiDevice, in creationProperties, (ID2D1Device**) d2dDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDevice(ref dxgiDevice, creationProperties, (ID2D1Device**) d2dDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDevice(ref dxgiDevice, in creationProperties, (ID2D1Device**) d2dDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDeviceContext<TI0>(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ComPtr<TI0> d2dDeviceContext) where TI0 : unmanaged, IComVtbl<ID2D1DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDeviceContext(dxgiSurface, creationProperties, (ID2D1DeviceContext**) d2dDeviceContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDeviceContext<TI0>(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ComPtr<TI0> d2dDeviceContext) where TI0 : unmanaged, IComVtbl<ID2D1DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDeviceContext(dxgiSurface, in creationProperties, (ID2D1DeviceContext**) d2dDeviceContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDeviceContext<TI0>(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CreationProperties* creationProperties, ref ComPtr<TI0> d2dDeviceContext) where TI0 : unmanaged, IComVtbl<ID2D1DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDeviceContext(ref dxgiSurface, creationProperties, (ID2D1DeviceContext**) d2dDeviceContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 5 in d2d1_1.h")]
        public unsafe int D2D1CreateDeviceContext<TI0>(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CreationProperties creationProperties, ref ComPtr<TI0> d2dDeviceContext) where TI0 : unmanaged, IComVtbl<ID2D1DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D2D1CreateDeviceContext(ref dxgiSurface, in creationProperties, (ID2D1DeviceContext**) d2dDeviceContext.GetAddressOf());
        }


        public D2D(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

