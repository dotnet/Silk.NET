// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface")]
        public unsafe partial int GetDebugInterface(Guid* riid, void** ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface")]
        public unsafe partial int GetDebugInterface(Guid* riid, ref void* ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface")]
        public unsafe partial int GetDebugInterface(ref Guid riid, void** ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 16 in dxgidebug.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface")]
        public unsafe partial int GetDebugInterface(ref Guid riid, ref void* ppDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 85, Column 16 in dxgi1_6.h")]
        [NativeApi(EntryPoint = "DXGIDeclareAdapterRemovalSupport")]
        public partial int DeclareAdapterRemovalSupport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 113, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2")]
        public unsafe partial int CreateDXGIFactory2(uint Flags, Guid* riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 113, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2")]
        public unsafe partial int CreateDXGIFactory2(uint Flags, Guid* riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 113, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2")]
        public unsafe partial int CreateDXGIFactory2(uint Flags, ref Guid riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 113, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory2")]
        public unsafe partial int CreateDXGIFactory2(uint Flags, ref Guid riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1")]
        public unsafe partial int GetDebugInterface1(uint Flags, Guid* riid, void** pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1")]
        public unsafe partial int GetDebugInterface1(uint Flags, Guid* riid, ref void* pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1")]
        public unsafe partial int GetDebugInterface1(uint Flags, ref Guid riid, void** pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 16 in dxgi1_3.h")]
        [NativeApi(EntryPoint = "DXGIGetDebugInterface1")]
        public unsafe partial int GetDebugInterface1(uint Flags, ref Guid riid, ref void* pDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2165, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory")]
        public unsafe partial int CreateDXGIFactory(Guid* riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2165, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory")]
        public unsafe partial int CreateDXGIFactory(Guid* riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2165, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory")]
        public unsafe partial int CreateDXGIFactory(ref Guid riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2165, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory")]
        public unsafe partial int CreateDXGIFactory(ref Guid riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2168, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1")]
        public unsafe partial int CreateDXGIFactory1(Guid* riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2168, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1")]
        public unsafe partial int CreateDXGIFactory1(Guid* riid, ref void* ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2168, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1")]
        public unsafe partial int CreateDXGIFactory1(ref Guid riid, void** ppFactory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2168, Column 16 in dxgi.h")]
        [NativeApi(EntryPoint = "CreateDXGIFactory1")]
        public unsafe partial int CreateDXGIFactory1(ref Guid riid, ref void* ppFactory);


        public DXGI(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

