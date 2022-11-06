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
    [Guid("db2f3acb-2f86-11d1-8e04-00c04fb9989a")]
    [NativeName("Name", "AsyncIPipeByte")]
    public unsafe partial struct AsyncIPipeByte : IComVtbl<AsyncIPipeByte>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("db2f3acb-2f86-11d1-8e04-00c04fb9989a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(AsyncIPipeByte val)
            => Unsafe.As<AsyncIPipeByte, Silk.NET.Core.Native.IUnknown>(ref val);

        public AsyncIPipeByte
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
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginPull(uint cRequest)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, uint, int>)@this->LpVtbl[3])(@this, cRequest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishPull(byte* buf, uint* pcReturned)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturned);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishPull(byte* buf, ref uint pcReturned)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturnedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishPull(ref byte buf, uint* pcReturned)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufPtr = &buf)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturned);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishPull(ref byte buf, ref uint pcReturned)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufPtr = &buf)
            {
                fixed (uint* pcReturnedPtr = &pcReturned)
                {
                    ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturnedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishPull([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint* pcReturned)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturned);
            SilkMarshal.Free((nint)bufPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishPull([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, ref uint pcReturned)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint*, int>)@this->LpVtbl[4])(@this, bufPtr, pcReturnedPtr);
            }
            SilkMarshal.Free((nint)bufPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginPush(byte* buf, uint cSent)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint, int>)@this->LpVtbl[5])(@this, buf, cSent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginPush(ref byte buf, uint cSent)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufPtr = &buf)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint, int>)@this->LpVtbl[5])(@this, bufPtr, cSent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginPush([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint cSent)
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, byte*, uint, int>)@this->LpVtbl[5])(@this, bufPtr, cSent);
            SilkMarshal.Free((nint)bufPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishPush()
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeByte*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (AsyncIPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
