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

namespace Silk.NET.DXGI
{
    public unsafe partial class DXGI : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCNDR_H_VERSION__")]
        public const int RequiredRpcndrHVersion = unchecked((int) 0x1F4);
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCSAL_H_VERSION__")]
        public const int RequiredRpcsalHVersion = unchecked((int) 0x64);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "DXGI_STANDARD_MULTISAMPLE_QUALITY_PATTERN")]
        public const uint StandardMultisampleQualityPattern = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "DXGI_CENTER_MULTISAMPLE_QUALITY_PATTERN")]
        public const uint CenterMultisampleQualityPattern = unchecked((uint) 0xFFFFFFFFFFFFFFFE);
        [NativeName("Type", "int")]
        [NativeName("Name", "_FACDXGI")]
        public const int Facdxgi = unchecked((int) 0x87A);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_CPU_ACCESS_NONE")]
        public const int CpuAccessNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_CPU_ACCESS_DYNAMIC")]
        public const int CpuAccessDynamic = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_CPU_ACCESS_READ_WRITE")]
        public const int CpuAccessReadWrite = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_CPU_ACCESS_SCRATCH")]
        public const int CpuAccessScratch = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_CPU_ACCESS_FIELD")]
        public const int CpuAccessField = unchecked((int) 0xF);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_SHADER_INPUT")]
        public const uint UsageShaderInput = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_RENDER_TARGET_OUTPUT")]
        public const uint UsageRenderTargetOutput = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_BACK_BUFFER")]
        public const uint UsageBackBuffer = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_SHARED")]
        public const uint UsageShared = unchecked((uint) 0x80);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_READ_ONLY")]
        public const uint UsageReadOnly = unchecked((uint) 0x100);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_DISCARD_ON_PRESENT")]
        public const uint UsageDiscardOnPresent = unchecked((uint) 0x200);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_USAGE_UNORDERED_ACCESS")]
        public const uint UsageUnorderedAccess = unchecked((uint) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_RESOURCE_PRIORITY_MINIMUM")]
        public const int ResourcePriorityMinimum = unchecked((int) 0x28000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_RESOURCE_PRIORITY_LOW")]
        public const int ResourcePriorityLow = unchecked((int) 0x50000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_RESOURCE_PRIORITY_NORMAL")]
        public const int ResourcePriorityNormal = unchecked((int) 0x78000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "DXGI_RESOURCE_PRIORITY_HIGH")]
        public const uint ResourcePriorityHigh = unchecked((uint) 0xFFFFFFFFA0000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "DXGI_RESOURCE_PRIORITY_MAXIMUM")]
        public const uint ResourcePriorityMaximum = unchecked((uint) 0xFFFFFFFFC8000000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_MAP_READ")]
        public const uint MapRead = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_MAP_WRITE")]
        public const uint MapWrite = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_MAP_DISCARD")]
        public const uint MapDiscard = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_ENUM_MODES_INTERLACED")]
        public const uint EnumModesInterlaced = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_ENUM_MODES_SCALING")]
        public const uint EnumModesScaling = unchecked((uint) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_MAX_SWAP_CHAIN_BUFFERS")]
        public const int MaxSwapChainBuffers = unchecked((int) 0x10);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_TEST")]
        public const uint PresentTest = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_DO_NOT_SEQUENCE")]
        public const uint PresentDONotSequence = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_RESTART")]
        public const uint PresentRestart = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_DO_NOT_WAIT")]
        public const uint PresentDONotWait = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_STEREO_PREFER_RIGHT")]
        public const uint PresentStereoPreferRight = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_STEREO_TEMPORARY_MONO")]
        public const uint PresentStereoTemporaryMono = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_RESTRICT_TO_OUTPUT")]
        public const uint PresentRestrictToOutput = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_USE_DURATION")]
        public const uint PresentUseDuration = unchecked((uint) 0x100);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "DXGI_PRESENT_ALLOW_TEARING")]
        public const uint PresentAllowTearing = unchecked((uint) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXGI_MWA_VALID")]
        public const int MwaValid = unchecked((int) 0x7);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface(Guid* riid, void** ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface(Guid* riid, ref void* ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface(ref Guid riid, void** ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface(ref Guid riid, ref void* ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 16 in dxgi1_6.h")]
        [NativeApi(EntryPoint = "DXGIDeclareAdapterRemovalSupport", Convention = CallingConvention.StdCall)]
        public partial int DeclareAdapterRemovalSupport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory2(uint Flags, Guid* riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory2(uint Flags, Guid* riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory2(uint Flags, ref Guid riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory2(uint Flags, ref Guid riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface1(uint Flags, Guid* riid, void** pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface1(uint Flags, Guid* riid, ref void* pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface1(uint Flags, ref Guid riid, void** pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDebugInterface1(uint Flags, ref Guid riid, ref void* pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory(Guid* riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory(Guid* riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory(ref Guid riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory(ref Guid riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2296, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory1(Guid* riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2296, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory1(Guid* riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2296, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory1(ref Guid riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2296, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateDXGIFactory1(ref Guid riid, ref void* ppFactory);


        public DXGI(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

