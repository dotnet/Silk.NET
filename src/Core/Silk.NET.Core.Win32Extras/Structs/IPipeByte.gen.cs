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
    [Guid("db2f3aca-2f86-11d1-8e04-00c04fb9989a")]
    [NativeName("Name", "IPipeByte")]
    public unsafe partial struct IPipeByte
    {
        public static readonly Guid Guid = new("db2f3aca-2f86-11d1-8e04-00c04fb9989a");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPipeByte val)
            => Unsafe.As<IPipeByte, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPipeByte
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
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull(byte* buf, uint cRequest, uint* pcReturned)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, uint*, int>)LpVtbl[3])(@this, buf, cRequest, pcReturned);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull(byte* buf, uint cRequest, ref uint pcReturned)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, uint*, int>)LpVtbl[3])(@this, buf, cRequest, pcReturnedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull(ref byte buf, uint cRequest, uint* pcReturned)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufPtr = &buf)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, uint*, int>)LpVtbl[3])(@this, bufPtr, cRequest, pcReturned);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Pull(ref byte buf, uint cRequest, ref uint pcReturned)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufPtr = &buf)
            {
                fixed (uint* pcReturnedPtr = &pcReturned)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, uint*, int>)LpVtbl[3])(@this, bufPtr, cRequest, pcReturnedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint cRequest, uint* pcReturned)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, uint*, int>)LpVtbl[3])(@this, bufPtr, cRequest, pcReturned);
            SilkMarshal.Free((nint)bufPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Pull([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint cRequest, ref uint pcReturned)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, uint*, int>)LpVtbl[3])(@this, bufPtr, cRequest, pcReturnedPtr);
            }
            SilkMarshal.Free((nint)bufPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Push(byte* buf, uint cSent)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, int>)LpVtbl[4])(@this, buf, cSent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Push(ref byte buf, uint cSent)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufPtr = &buf)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, int>)LpVtbl[4])(@this, bufPtr, cSent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Push([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint cSent)
        {
            var @this = (IPipeByte*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufPtr = (byte*) SilkMarshal.StringToPtr(buf, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPipeByte*, byte*, uint, int>)LpVtbl[4])(@this, bufPtr, cSent);
            SilkMarshal.Free((nint)bufPtr);
            return ret;
        }

    }
}
