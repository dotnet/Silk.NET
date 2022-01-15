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
        [NativeName("Name", "DXC_CP_ACP")]
        public const int CPAcp = unchecked((int) 0x0);
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
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in D:/Windows Kits/10/Include/10.0.22000.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);


        public DXC(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

