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
    [Guid("0e6d4d90-6738-11cf-9608-00aa00680db4")]
    [NativeName("Name", "ILayoutStorage")]
    public unsafe partial struct ILayoutStorage : IComVtbl<ILayoutStorage>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0e6d4d90-6738-11cf-9608-00aa00680db4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ILayoutStorage val)
            => Unsafe.As<ILayoutStorage, Silk.NET.Core.Native.IUnknown>(ref val);

        public ILayoutStorage
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
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LayoutScript(StorageLayout* pStorageLayout, uint nEntries, uint glfInterleavedFlag)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, StorageLayout*, uint, uint, int>)@this->LpVtbl[3])(@this, pStorageLayout, nEntries, glfInterleavedFlag);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LayoutScript(ref StorageLayout pStorageLayout, uint nEntries, uint glfInterleavedFlag)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StorageLayout* pStorageLayoutPtr = &pStorageLayout)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, StorageLayout*, uint, uint, int>)@this->LpVtbl[3])(@this, pStorageLayoutPtr, nEntries, glfInterleavedFlag);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginMonitor()
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndMonitor()
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReLayoutDocfile(char* pwcsNewDfName)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, char*, int>)@this->LpVtbl[6])(@this, pwcsNewDfName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReLayoutDocfile(ref char pwcsNewDfName)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pwcsNewDfNamePtr = &pwcsNewDfName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, char*, int>)@this->LpVtbl[6])(@this, pwcsNewDfNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReLayoutDocfile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewDfName)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pwcsNewDfNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewDfName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, byte*, int>)@this->LpVtbl[6])(@this, pwcsNewDfNamePtr);
            SilkMarshal.Free((nint)pwcsNewDfNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReLayoutDocfileOnILockBytes(ILockBytes* pILockBytes)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, ILockBytes*, int>)@this->LpVtbl[7])(@this, pILockBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReLayoutDocfileOnILockBytes(ref ILockBytes pILockBytes)
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ILockBytes* pILockBytesPtr = &pILockBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, ILockBytes*, int>)@this->LpVtbl[7])(@this, pILockBytesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ReLayoutDocfileOnILockBytes<TI0>(ComPtr<TI0> pILockBytes) where TI0 : unmanaged, IComVtbl<ILockBytes>, IComVtbl<TI0>
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ReLayoutDocfileOnILockBytes((ILockBytes*) pILockBytes.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ILayoutStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
