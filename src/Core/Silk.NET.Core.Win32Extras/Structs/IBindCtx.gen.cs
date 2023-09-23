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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("0000000e-0000-0000-c000-000000000046")]
    [NativeName("Name", "IBindCtx")]
    public unsafe partial struct IBindCtx : IComVtbl<IBindCtx>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000000e-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IBindCtx val)
            => Unsafe.As<IBindCtx, Silk.NET.Core.Native.IUnknown>(ref val);

        public IBindCtx
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
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObjectBound(Silk.NET.Core.Native.IUnknown* punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, punk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterObjectBound(ref Silk.NET.Core.Native.IUnknown punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, punkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RevokeObjectBound(Silk.NET.Core.Native.IUnknown* punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, punk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeObjectBound(ref Silk.NET.Core.Native.IUnknown punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, punkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseBoundObjects()
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBindOptions(BindOpts* pbindopts)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[6])(@this, pbindopts);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBindOptions(ref BindOpts pbindopts)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BindOpts* pbindoptsPtr = &pbindopts)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[6])(@this, pbindoptsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBindOptions(BindOpts* pbindopts)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[7])(@this, pbindopts);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBindOptions(ref BindOpts pbindopts)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BindOpts* pbindoptsPtr = &pbindopts)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, BindOpts*, int>)@this->LpVtbl[7])(@this, pbindoptsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRunningObjectTable(IRunningObjectTable** pprot)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IRunningObjectTable**, int>)@this->LpVtbl[8])(@this, pprot);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRunningObjectTable(ref IRunningObjectTable* pprot)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IRunningObjectTable** pprotPtr = &pprot)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IRunningObjectTable**, int>)@this->LpVtbl[8])(@this, pprotPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObjectParam(char* pszKey, Silk.NET.Core.Native.IUnknown* punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKey, punk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObjectParam(char* pszKey, ref Silk.NET.Core.Native.IUnknown punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKey, punkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObjectParam(ref char pszKey, Silk.NET.Core.Native.IUnknown* punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszKeyPtr = &pszKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punk);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterObjectParam(ref char pszKey, ref Silk.NET.Core.Native.IUnknown punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszKeyPtr = &pszKey)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObjectParam([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, Silk.NET.Core.Native.IUnknown* punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punk);
            SilkMarshal.Free((nint)pszKeyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterObjectParam([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ref Silk.NET.Core.Native.IUnknown punk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Native.IUnknown* punkPtr = &punk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pszKeyPtr, punkPtr);
            }
            SilkMarshal.Free((nint)pszKeyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam(char* pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKey, ppunk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam(char* pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppunkPtr = &ppunk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKey, ppunkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam(ref char pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszKeyPtr = &pszKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunk);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam(ref char pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszKeyPtr = &pszKey)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppunkPtr = &ppunk)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, Silk.NET.Core.Native.IUnknown** ppunk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunk);
            SilkMarshal.Free((nint)pszKeyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ref Silk.NET.Core.Native.IUnknown* ppunk)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Native.IUnknown** ppunkPtr = &ppunk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, pszKeyPtr, ppunkPtr);
            }
            SilkMarshal.Free((nint)pszKeyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumObjectParam(IEnumString** ppenum)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IEnumString**, int>)@this->LpVtbl[11])(@this, ppenum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumObjectParam(ref IEnumString* ppenum)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumString** ppenumPtr = &ppenum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, IEnumString**, int>)@this->LpVtbl[11])(@this, ppenumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RevokeObjectParam(char* pszKey)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, int>)@this->LpVtbl[12])(@this, pszKey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeObjectParam(ref char pszKey)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszKeyPtr = &pszKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, char*, int>)@this->LpVtbl[12])(@this, pszKeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeObjectParam([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey)
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszKeyPtr = (byte*) SilkMarshal.StringToPtr(pszKey, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IBindCtx*, byte*, int>)@this->LpVtbl[12])(@this, pszKeyPtr);
            SilkMarshal.Free((nint)pszKeyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterObjectBound<TI0>(ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObjectBound((Silk.NET.Core.Native.IUnknown*) punk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeObjectBound<TI0>(ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RevokeObjectBound((Silk.NET.Core.Native.IUnknown*) punk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRunningObjectTable<TI0>(ref ComPtr<TI0> pprot) where TI0 : unmanaged, IComVtbl<IRunningObjectTable>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRunningObjectTable((IRunningObjectTable**) pprot.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObjectParam<TI0>(char* pszKey, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown*) punk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterObjectParam<TI0>(ref char pszKey, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObjectParam(ref pszKey, (Silk.NET.Core.Native.IUnknown*) punk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterObjectParam<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ComPtr<TI0> punk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown*) punk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectParam<TI0>(char* pszKey, ref ComPtr<TI0> ppunk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown**) ppunk.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetObjectParam<TI0>(ref char pszKey, ref ComPtr<TI0> ppunk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetObjectParam(ref pszKey, (Silk.NET.Core.Native.IUnknown**) ppunk.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetObjectParam<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszKey, ref ComPtr<TI0> ppunk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetObjectParam(pszKey, (Silk.NET.Core.Native.IUnknown**) ppunk.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumObjectParam<TI0>(ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumString>, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumObjectParam((IEnumString**) ppenum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IBindCtx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
