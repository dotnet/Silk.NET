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

namespace Silk.NET.DirectStorage
{
    [Guid("5de95e7b-955a-4868-a73c-243b29f4b8da")]
    [NativeName("Name", "IDStorageFile")]
    public unsafe partial struct IDStorageFile
    {
        public static readonly Guid Guid = new("5de95e7b-955a-4868-a73c-243b29f4b8da");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageFile val)
            => Unsafe.As<IDStorageFile, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageFile
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
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageFile*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Close()
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageFile*, void>)LpVtbl[3])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileInformation(Silk.NET.Core.Win32Extras.ByHandleFileInformation* info)
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)LpVtbl[4])(@this, info);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)LpVtbl[4])(@this, info);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)LpVtbl[4])(@this, info);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileInformation(ref Silk.NET.Core.Win32Extras.ByHandleFileInformation info)
        {
            var @this = (IDStorageFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.ByHandleFileInformation* infoPtr = &info)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)LpVtbl[4])(@this, infoPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)LpVtbl[4])(@this, infoPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)LpVtbl[4])(@this, infoPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
