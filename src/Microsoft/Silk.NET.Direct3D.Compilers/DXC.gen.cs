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
    public unsafe partial class DXC : NativeAPI
    {
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcValidatorFlags_Default")]
        public const uint ValidatorFlagsDefault = unchecked((uint) 0x0);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcValidatorFlags_InPlaceEdit")]
        public const uint ValidatorFlagsInPlaceEdit = unchecked((uint) 0x1);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcValidatorFlags_RootSignatureOnly")]
        public const uint ValidatorFlagsRootSignatureOnly = unchecked((uint) 0x2);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcValidatorFlags_ModuleOnly")]
        public const uint ValidatorFlagsModuleOnly = unchecked((uint) 0x4);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcValidatorFlags_ValidMask")]
        public const uint ValidatorFlagsValidMask = unchecked((uint) 0x7);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcVersionInfoFlags_None")]
        public const uint VersionInfoFlagsNone = unchecked((uint) 0x0);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcVersionInfoFlags_Debug")]
        public const uint VersionInfoFlagsDebug = unchecked((uint) 0x1);
        [NativeName("Type", "const UINT32")]
        [NativeName("Name", "DxcVersionInfoFlags_Internal")]
        public const uint VersionInfoFlagsInternal = unchecked((uint) 0x2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance<TI0>(Guid* rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance(rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance<TI0>(ref Guid rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance(ref rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, Guid* rclsid, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, Guid* rclsid, Guid* riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, Guid* rclsid, ref Guid riid, void** ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, ref riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, ref riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, ref Guid rclsid, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, ref Guid rclsid, ref Guid riid, void** ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, ref riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, ref riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ref IMalloc pMalloc, Guid* rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2(ref pMalloc, rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ref IMalloc pMalloc, ref Guid rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2(ref pMalloc, ref rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance<TI0>(Guid* rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance(rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance<TI0>(ref Guid rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance(ref rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe ComPtr<TI1> CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, Guid* rclsid) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(pMalloc, rclsid, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe ComPtr<TI1> CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, ref Guid rclsid) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(pMalloc, ref rclsid, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance2<TI0>(ref IMalloc pMalloc, Guid* rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(ref pMalloc, rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance2<TI0>(ref IMalloc pMalloc, ref Guid rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(ref pMalloc, ref rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }


        public DXC(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

