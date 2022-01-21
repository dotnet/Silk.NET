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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
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
        public readonly Luid GetLUID()
        {
            Luid silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Luid* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Luid*, Luid*>)LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid*, Luid*>)LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Luid*, Luid*>)LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
            }
            #endif
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(Guid* riid, void** ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppv);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppv);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppv);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(Guid* riid, ref void* ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppvPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppvPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppvPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppv);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppv);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppv);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppvPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppvPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppvPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                        }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
                        }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
                        }
            #endif
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
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
                        }
            #endif
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
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                            }
            #endif
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
