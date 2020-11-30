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

namespace Silk.NET.Core.Native
{
    [Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3")]
    [NativeName("Name", "ID3DDestructionNotifier")]
    public unsafe partial struct ID3DDestructionNotifier
    {
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback(void* callbackFn, void* pData, uint* pCallbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, void*, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackID);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback(void* callbackFn, void* pData, ref uint pCallbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pCallbackIDPtr = &pCallbackID)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, void*, void*, uint*, int>)LpVtbl[3])(@this, callbackFn, pData, pCallbackIDPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0>(void* callbackFn, ref T0 pData, uint* pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, void*, T0*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackID);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0>(void* callbackFn, ref T0 pData, ref uint pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                fixed (uint* pCallbackIDPtr = &pCallbackID)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, void*, T0*, uint*, int>)LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackIDPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0>(ref T0 callbackFn, void* pData, uint* pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* callbackFnPtr = &callbackFn)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, T0*, void*, uint*, int>)LpVtbl[3])(@this, callbackFnPtr, pData, pCallbackID);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0>(ref T0 callbackFn, void* pData, ref uint pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* callbackFnPtr = &callbackFn)
            {
                fixed (uint* pCallbackIDPtr = &pCallbackID)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, T0*, void*, uint*, int>)LpVtbl[3])(@this, callbackFnPtr, pData, pCallbackIDPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0, T1>(ref T0 callbackFn, ref T1 pData, uint* pCallbackID) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* callbackFnPtr = &callbackFn)
            {
                fixed (T1* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, T0*, T1*, uint*, int>)LpVtbl[3])(@this, callbackFnPtr, pDataPtr, pCallbackID);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int RegisterDestructionCallback<T0, T1>(ref T0 callbackFn, ref T1 pData, ref uint pCallbackID) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* callbackFnPtr = &callbackFn)
            {
                fixed (T1* pDataPtr = &pData)
                {
                    fixed (uint* pCallbackIDPtr = &pCallbackID)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, T0*, T1*, uint*, int>)LpVtbl[3])(@this, callbackFnPtr, pDataPtr, pCallbackIDPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int UnregisterDestructionCallback(uint callbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DDestructionNotifier*, uint, int>)LpVtbl[4])(@this, callbackID);
            return ret;
        }

    }
}
