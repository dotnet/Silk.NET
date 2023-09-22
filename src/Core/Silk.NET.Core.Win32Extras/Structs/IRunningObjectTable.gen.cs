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
    [Guid("00000010-0000-0000-c000-000000000046")]
    [NativeName("Name", "IRunningObjectTable")]
    public unsafe partial struct IRunningObjectTable : IComVtbl<IRunningObjectTable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000010-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRunningObjectTable val)
            => Unsafe.As<IRunningObjectTable, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRunningObjectTable
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
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, IMoniker* pmkObjectName, uint* pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectName, pdwRegister);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, IMoniker* pmkObjectName, ref uint pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwRegisterPtr = &pdwRegister)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectName, pdwRegisterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, ref IMoniker pmkObjectName, uint* pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectNamePtr, pdwRegister);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                fixed (uint* pdwRegisterPtr = &pdwRegister)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectNamePtr, pdwRegisterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, IMoniker* pmkObjectName, uint* pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectName, pdwRegister);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, IMoniker* pmkObjectName, ref uint pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
            {
                fixed (uint* pdwRegisterPtr = &pdwRegister)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectName, pdwRegisterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register(uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ref IMoniker pmkObjectName, uint* pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
            {
                fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectNamePtr, pdwRegister);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Register(uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
            {
                fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
                {
                    fixed (uint* pdwRegisterPtr = &pdwRegister)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectNamePtr, pdwRegisterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Revoke(uint dwRegister)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, int>)@this->LpVtbl[4])(@this, dwRegister);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(IMoniker* pmkObjectName)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, int>)@this->LpVtbl[5])(@this, pmkObjectName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning(ref IMoniker pmkObjectName)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, int>)@this->LpVtbl[5])(@this, pmkObjectNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(IMoniker* pmkObjectName, Silk.NET.Core.Native.IUnknown** ppunkObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectName, ppunkObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(IMoniker* pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppunkObjectPtr = &ppunkObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectName, ppunkObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref IMoniker pmkObjectName, Silk.NET.Core.Native.IUnknown** ppunkObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectNamePtr, ppunkObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(ref IMoniker pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppunkObjectPtr = &ppunkObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectNamePtr, ppunkObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NoteChangeTime(uint dwRegister, Filetime* pfiletime)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Filetime*, int>)@this->LpVtbl[7])(@this, dwRegister, pfiletime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NoteChangeTime(uint dwRegister, ref Filetime pfiletime)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pfiletimePtr = &pfiletime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Filetime*, int>)@this->LpVtbl[7])(@this, dwRegister, pfiletimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(IMoniker* pmkObjectName, Filetime* pfiletime)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectName, pfiletime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(IMoniker* pmkObjectName, ref Filetime pfiletime)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pfiletimePtr = &pfiletime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectName, pfiletimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(ref IMoniker pmkObjectName, Filetime* pfiletime)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectNamePtr, pfiletime);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimeOfLastChange(ref IMoniker pmkObjectName, ref Filetime pfiletime)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                fixed (Filetime* pfiletimePtr = &pfiletime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectNamePtr, pfiletimePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumRunning(IEnumMoniker** ppenumMoniker)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IEnumMoniker**, int>)@this->LpVtbl[9])(@this, ppenumMoniker);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumRunning(ref IEnumMoniker* ppenumMoniker)
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumMoniker** ppenumMonikerPtr = &ppenumMoniker)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IEnumMoniker**, int>)@this->LpVtbl[9])(@this, ppenumMonikerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register<TI0, TI1>(uint grfFlags, ComPtr<TI0> punkObject, ComPtr<TI1> pmkObjectName, uint* pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, (IMoniker*) pmkObjectName.Handle, pdwRegister);
        }

        /// <summary>To be documented.</summary>
        public readonly int Register<TI0, TI1>(uint grfFlags, ComPtr<TI0> punkObject, ComPtr<TI1> pmkObjectName, ref uint pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, (IMoniker*) pmkObjectName.Handle, ref pdwRegister);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register<TI0>(uint grfFlags, ComPtr<TI0> punkObject, ref IMoniker pmkObjectName, uint* pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, ref pmkObjectName, pdwRegister);
        }

        /// <summary>To be documented.</summary>
        public readonly int Register<TI0>(uint grfFlags, ComPtr<TI0> punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, ref pmkObjectName, ref pdwRegister);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Register<TI0>(uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ComPtr<TI0> pmkObjectName, uint* pdwRegister) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Register(grfFlags, ref punkObject, (IMoniker*) pmkObjectName.Handle, pdwRegister);
        }

        /// <summary>To be documented.</summary>
        public readonly int Register<TI0>(uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ComPtr<TI0> pmkObjectName, ref uint pdwRegister) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Register(grfFlags, ref punkObject, (IMoniker*) pmkObjectName.Handle, ref pdwRegister);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0>(ComPtr<TI0> pmkObjectName) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning((IMoniker*) pmkObjectName.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetObjectA<TI0, TI1>(ComPtr<TI0> pmkObjectName, ref ComPtr<TI1> ppunkObject) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetObjectA((IMoniker*) pmkObjectName.Handle, (Silk.NET.Core.Native.IUnknown**) ppunkObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA<TI0>(ComPtr<TI0> pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetObjectA((IMoniker*) pmkObjectName.Handle, ref ppunkObject);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetObjectA<TI0>(ref IMoniker pmkObjectName, ref ComPtr<TI0> ppunkObject) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetObjectA(ref pmkObjectName, (Silk.NET.Core.Native.IUnknown**) ppunkObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange<TI0>(ComPtr<TI0> pmkObjectName, Filetime* pfiletime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange((IMoniker*) pmkObjectName.Handle, pfiletime);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimeOfLastChange<TI0>(ComPtr<TI0> pmkObjectName, ref Filetime pfiletime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange((IMoniker*) pmkObjectName.Handle, ref pfiletime);
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumRunning<TI0>(ref ComPtr<TI0> ppenumMoniker) where TI0 : unmanaged, IComVtbl<IEnumMoniker>, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumRunning((IEnumMoniker**) ppenumMoniker.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRunningObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
