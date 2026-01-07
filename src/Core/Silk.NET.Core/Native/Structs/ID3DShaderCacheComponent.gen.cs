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

namespace Silk.NET.Core.Native
{
    [Guid("eed1bf00-f5c7-4cf7-885c-d0f9c0cb4828")]
    [NativeName("Name", "ID3DShaderCacheComponent")]
    public unsafe partial struct ID3DShaderCacheComponent : IComVtbl<ID3DShaderCacheComponent>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("eed1bf00-f5c7-4cf7-885c-d0f9c0cb4828");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DShaderCacheComponent val)
            => Unsafe.As<ID3DShaderCacheComponent, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DShaderCacheComponent
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComponentName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pName)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[3])(@this, pName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComponentName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pName)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[3])(@this, pNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStateObjectDatabasePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[4])(@this, pPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStateObjectDatabasePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pPathPtr = &pPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char**, int>)@this->LpVtbl[4])(@this, pPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamily, pPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pPathPtr = &pPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamily, pPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pAdapterFamilyPtr = &pAdapterFamily)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPath);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pAdapterFamilyPtr = &pAdapterFamily)
            {
                fixed (char** pPathPtr = &pPath)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, char*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPathPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pAdapterFamilyPtr = (byte*) SilkMarshal.StringToPtr(pAdapterFamily, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, byte*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPath);
            SilkMarshal.Free((nint)pAdapterFamilyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char* pPath)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pAdapterFamilyPtr = (byte*) SilkMarshal.StringToPtr(pAdapterFamily, NativeStringEncoding.UTF8);
            fixed (char** pPathPtr = &pPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, byte*, char**, int>)@this->LpVtbl[5])(@this, pAdapterFamilyPtr, pPathPtr);
            }
            SilkMarshal.Free((nint)pAdapterFamilyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPrecompiledShaderDatabaseCount()
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledShaderDatabases(uint ArraySize, D3DShaderCachePsdbProperties* pPSDBs)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint, D3DShaderCachePsdbProperties*, int>)@this->LpVtbl[7])(@this, ArraySize, pPSDBs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrecompiledShaderDatabases(uint ArraySize, ref D3DShaderCachePsdbProperties pPSDBs)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D3DShaderCachePsdbProperties* pPSDBsPtr = &pPSDBs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheComponent*, uint, D3DShaderCachePsdbProperties*, int>)@this->LpVtbl[7])(@this, ArraySize, pPSDBsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComponentName([Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pNameSa)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pName = (char**) SilkMarshal.StringArrayToPtr(pNameSa);
            var ret = @this->GetComponentName(pName);
            SilkMarshal.CopyPtrToStringArray((nint) pName, pNameSa);
            SilkMarshal.Free((nint) pName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStateObjectDatabasePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
            var ret = @this->GetStateObjectDatabasePath(pPath);
            SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
            SilkMarshal.Free((nint) pPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
            var ret = @this->GetPrecompiledCachePath(pAdapterFamily, pPath);
            SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
            SilkMarshal.Free((nint) pPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
            var ret = @this->GetPrecompiledCachePath(in pAdapterFamily, pPath);
            SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
            SilkMarshal.Free((nint) pPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrecompiledCachePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pAdapterFamily, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pPathSa)
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pPath = (char**) SilkMarshal.StringArrayToPtr(pPathSa);
            var ret = @this->GetPrecompiledCachePath(pAdapterFamily, pPath);
            SilkMarshal.CopyPtrToStringArray((nint) pPath, pPathSa);
            SilkMarshal.Free((nint) pPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheComponent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
