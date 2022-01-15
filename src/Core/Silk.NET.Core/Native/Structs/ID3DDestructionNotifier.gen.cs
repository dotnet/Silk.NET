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
    [Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3")]
    [NativeName("Name", "ID3DDestructionNotifier")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public static readonly Guid Guid = new("a06eb39a-50da-425b-8c31-4eecd6c270f3");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DDestructionNotifier val)
            => Unsafe.As<ID3DDestructionNotifier, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DDestructionNotifier
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
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterDestructionCallback(PfnDestructionCallback callbackFn, void* pData, uint* pCallbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackID);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackID);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackID);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterDestructionCallback(PfnDestructionCallback callbackFn, void* pData, ref uint pCallbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCallbackIDPtr = &pCallbackID)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackIDPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackIDPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackIDPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0>(PfnDestructionCallback callbackFn, ref T0 pData, uint* pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackID);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackID);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackID);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterDestructionCallback<T0>(PfnDestructionCallback callbackFn, ref T0 pData, ref uint pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pCallbackIDPtr = &pCallbackID)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackIDPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackIDPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackIDPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterDestructionCallback(uint callbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DDestructionNotifier*, uint, int>)LpVtbl[4])(@this, callbackID);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint, int>)LpVtbl[4])(@this, callbackID);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, uint, int>)LpVtbl[4])(@this, callbackID);
            }
            #endif
            return ret;
        }

    }
}
