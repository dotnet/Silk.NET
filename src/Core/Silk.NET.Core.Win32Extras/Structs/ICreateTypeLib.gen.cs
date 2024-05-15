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
    [Guid("00020406-0000-0000-c000-000000000046")]
    [NativeName("Name", "ICreateTypeLib")]
    public unsafe partial struct ICreateTypeLib : IComVtbl<ICreateTypeLib>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00020406-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ICreateTypeLib val)
            => Unsafe.As<ICreateTypeLib, Silk.NET.Core.Native.IUnknown>(ref val);

        public ICreateTypeLib
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
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo(char* szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szName, tkind, ppCTInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo(char* szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICreateTypeInfo** ppCTInfoPtr = &ppCTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szName, tkind, ppCTInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo(ref char szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo(ref char szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                fixed (ICreateTypeInfo** ppCTInfoPtr = &ppCTInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, TypeKind tkind, ICreateTypeInfo** ppCTInfo)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfo);
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, TypeKind tkind, ref ICreateTypeInfo* ppCTInfo)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            fixed (ICreateTypeInfo** ppCTInfoPtr = &ppCTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, TypeKind, ICreateTypeInfo**, int>)@this->LpVtbl[3])(@this, szNamePtr, tkind, ppCTInfoPtr);
            }
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* szName)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[4])(@this, szName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char szName)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[4])(@this, szNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, int>)@this->LpVtbl[4])(@this, szNamePtr);
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVersion(ushort wMajorVerNum, ushort wMinorVerNum)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, ushort, ushort, int>)@this->LpVtbl[5])(@this, wMajorVerNum, wMinorVerNum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGuid(Guid* guid)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, int>)@this->LpVtbl[6])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGuid(ref Guid guid)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, Guid*, int>)@this->LpVtbl[6])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDocString(char* szDoc)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[7])(@this, szDoc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDocString(ref char szDoc)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDocPtr = &szDoc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[7])(@this, szDocPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDocString([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDoc)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDocPtr = (byte*) SilkMarshal.StringToPtr(szDoc, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, int>)@this->LpVtbl[7])(@this, szDocPtr);
            SilkMarshal.Free((nint)szDocPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetHelpFileName(char* szHelpFileName)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[8])(@this, szHelpFileName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpFileName(ref char szHelpFileName)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szHelpFileNamePtr = &szHelpFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, char*, int>)@this->LpVtbl[8])(@this, szHelpFileNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpFileName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szHelpFileName)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szHelpFileNamePtr = (byte*) SilkMarshal.StringToPtr(szHelpFileName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, byte*, int>)@this->LpVtbl[8])(@this, szHelpFileNamePtr);
            SilkMarshal.Free((nint)szHelpFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpContext(uint dwHelpContext)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint, int>)@this->LpVtbl[9])(@this, dwHelpContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLcid(uint lcid)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint, int>)@this->LpVtbl[10])(@this, lcid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLibFlags(uint uLibFlags)
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, uint, int>)@this->LpVtbl[11])(@this, uLibFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveAllChanges()
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeLib*, int>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypeInfo<TI0>(char* szName, TypeKind tkind, ref ComPtr<TI0> ppCTInfo) where TI0 : unmanaged, IComVtbl<ICreateTypeInfo>, IComVtbl<TI0>
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTypeInfo(szName, tkind, (ICreateTypeInfo**) ppCTInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTypeInfo<TI0>(ref char szName, TypeKind tkind, ref ComPtr<TI0> ppCTInfo) where TI0 : unmanaged, IComVtbl<ICreateTypeInfo>, IComVtbl<TI0>
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTypeInfo(ref szName, tkind, (ICreateTypeInfo**) ppCTInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTypeInfo<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, TypeKind tkind, ref ComPtr<TI0> ppCTInfo) where TI0 : unmanaged, IComVtbl<ICreateTypeInfo>, IComVtbl<TI0>
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTypeInfo(szName, tkind, (ICreateTypeInfo**) ppCTInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICreateTypeLib*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
