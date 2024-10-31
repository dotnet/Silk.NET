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
        [NativeName("Type", "int")]
        [NativeName("Name", "DXC_CP_UTF8")]
        public const int CPUtf8 = unchecked((int) 0xFDE9);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXC_CP_UTF16")]
        public const int CPUtf16 = unchecked((int) 0x4B0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXC_CP_UTF32")]
        public const int CPUtf32 = unchecked((int) 0x2EE0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXC_CP_ACP")]
        public const int CPAcp = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXC_CP_WIDE")]
        public const int CPWide = unchecked((int) 0x4B0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXC_HASHFLAG_INCLUDES_SOURCE")]
        public const int HashflagIncludesSource = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_DEBUG")]
        public const string ArgDebug = unchecked((string) "-Zi");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_SKIP_VALIDATION")]
        public const string ArgSkipValidation = unchecked((string) "-Vd");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_SKIP_OPTIMIZATIONS")]
        public const string ArgSkipOptimizations = unchecked((string) "-Od");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_PACK_MATRIX_ROW_MAJOR")]
        public const string ArgPackMatrixRowMajor = unchecked((string) "-Zpr");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_PACK_MATRIX_COLUMN_MAJOR")]
        public const string ArgPackMatrixColumnMajor = unchecked((string) "-Zpc");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_AVOID_FLOW_CONTROL")]
        public const string ArgAvoidFlowControl = unchecked((string) "-Gfa");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_PREFER_FLOW_CONTROL")]
        public const string ArgPreferFlowControl = unchecked((string) "-Gfp");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_ENABLE_STRICTNESS")]
        public const string ArgEnableStrictness = unchecked((string) "-Ges");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_ENABLE_BACKWARDS_COMPATIBILITY")]
        public const string ArgEnableBackwardsCompatibility = unchecked((string) "-Gec");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_IEEE_STRICTNESS")]
        public const string ArgIeeeStrictness = unchecked((string) "-Gis");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_OPTIMIZATION_LEVEL0")]
        public const string ArgOptimizationLevel0 = unchecked((string) "-O0");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_OPTIMIZATION_LEVEL1")]
        public const string ArgOptimizationLevel1 = unchecked((string) "-O1");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_OPTIMIZATION_LEVEL2")]
        public const string ArgOptimizationLevel2 = unchecked((string) "-O2");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_OPTIMIZATION_LEVEL3")]
        public const string ArgOptimizationLevel3 = unchecked((string) "-O3");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_WARNINGS_ARE_ERRORS")]
        public const string ArgWarningsAreErrors = unchecked((string) "-WX");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_RESOURCES_MAY_ALIAS")]
        public const string ArgResourcesMayAlias = unchecked((string) "-res_may_alias");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_ALL_RESOURCES_BOUND")]
        public const string ArgAllResourcesBound = unchecked((string) "-all_resources_bound");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_DEBUG_NAME_FOR_SOURCE")]
        public const string ArgDebugNameForSource = unchecked((string) "-Zss");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_ARG_DEBUG_NAME_FOR_BINARY")]
        public const string ArgDebugNameForBinary = unchecked((string) "-Zsb");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_EXTRA_OUTPUT_NAME_STDOUT")]
        public const string ExtraOutputNameStdout = unchecked((string) "*stdout*");
        [NativeName("Type", "")]
        [NativeName("Name", "DXC_EXTRA_OUTPUT_NAME_STDERR")]
        public const string ExtraOutputNameStderr = unchecked((string) "*stderr*");

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance<TI0>(Guid* rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance(rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance<TI0>(ref Guid rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance(ref rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, Guid* rclsid, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, Guid* rclsid, Guid* riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, Guid* rclsid, ref Guid riid, void** ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, ref riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, rclsid, ref riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, ref Guid rclsid, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, ref Guid rclsid, ref Guid riid, void** ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, ref riid, ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ComPtr<TI0> pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateInstance2((IMalloc*) pMalloc.Handle, ref rclsid, ref riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ref IMalloc pMalloc, Guid* rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2(ref pMalloc, rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe int CreateInstance2<TI0>(ref IMalloc pMalloc, ref Guid rclsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppv = default;
            return CreateInstance2(ref pMalloc, ref rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance<TI0>(Guid* rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance(rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 34 in dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance<TI0>(ref Guid rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance(ref rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe ComPtr<TI1> CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, Guid* rclsid) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(pMalloc, rclsid, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe ComPtr<TI1> CreateInstance2<TI0, TI1>(ComPtr<TI0> pMalloc, ref Guid rclsid) where TI0 : unmanaged, IComVtbl<IMalloc>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(pMalloc, ref rclsid, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
        public unsafe ComPtr<TI0> CreateInstance2<TI0>(ref IMalloc pMalloc, Guid* rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateInstance2(ref pMalloc, rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in dxcapi.h")]
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

