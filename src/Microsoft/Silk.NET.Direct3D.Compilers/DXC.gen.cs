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
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance")]
        public unsafe partial int CreateInstance(ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(IMalloc* pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, Guid* rclsid, ref Guid riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\dxcapi.h")]
        [NativeApi(EntryPoint = "DxcCreateInstance2")]
        public unsafe partial int CreateInstance2(ref IMalloc pMalloc, ref Guid rclsid, ref Guid riid, ref void* ppv);


        public DXC(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

