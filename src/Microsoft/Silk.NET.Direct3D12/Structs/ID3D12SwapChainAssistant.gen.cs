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

namespace Silk.NET.Direct3D12
{
    [Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f")]
    [NativeName("Name", "ID3D12SwapChainAssistant")]
    public unsafe partial struct ID3D12SwapChainAssistant
    {
        public static readonly Guid Guid = new("f1df64b6-57fd-49cd-8807-c0eb88b45c8f");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12SwapChainAssistant val)
            => Unsafe.As<ID3D12SwapChainAssistant, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12SwapChainAssistant
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
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ValueTuple<ulong,long> GetLUID()
        {
            ValueTuple<ulong,long> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ValueTuple<ulong,long>* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, ValueTuple<ulong,long>*, ValueTuple<ulong,long>*>)LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(Guid* riid, void** ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(Guid* riid, ref void* ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(ref Guid riid, void** ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(ref Guid riid, ref void* ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    fixed (Guid* riidQueuePtr = &riidQueue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    fixed (Guid* riidQueuePtr = &riidQueue)
                    {
                        fixed (void** ppvQueuePtr = &ppvQueue)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertImplicitSync()
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)LpVtbl[6])(@this);
            return ret;
        }

    }
}
