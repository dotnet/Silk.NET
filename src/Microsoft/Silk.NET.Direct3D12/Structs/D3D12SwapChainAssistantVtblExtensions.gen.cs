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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12SwapChainAssistantVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Luid GetLUID(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Luid silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Luid* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid*, Luid*>)@this->LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvQueuePtr = &ppvQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidQueuePtr = &riidQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidQueuePtr = &riidQueue)
        {
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InsertImplicitSync(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetSwapChainObject<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetSwapChainObject(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSwapChainObject(ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSwapChainObject(ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentResourceAndCommandQueue<TI0, TI1>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref ComPtr<TI0> ppvResource, out ComPtr<TI1> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref ComPtr<TI0> ppvResource, Guid* riidQueue, ref void* ppvQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, Span<Guid> riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref ComPtr<TI0> ppvResource, ref Guid riidQueue, void** ppvQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), ref riidQueue, ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, Span<Guid> riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref ComPtr<TI0> ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), ref riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, out ComPtr<TI0> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, Span<Guid> riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource, Span<Guid> riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, riidQueue, ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, void** ppvResource, out ComPtr<TI0> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource, ppvResource, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, void** ppvResource, Span<Guid> riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, void** ppvResource, Span<Guid> riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, riidQueue, ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, ref void* ppvResource, out ComPtr<TI0> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource, ref ppvResource, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Span<Guid> riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Span<Guid> riidQueue, ref void* ppvQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetSwapChainObject<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetSwapChainObject(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> GetCurrentResourceAndCommandQueue<TI0, TI1>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(ref ppvResource, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(ref riidResource, ppvResource, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCurrentResourceAndCommandQueue<TI0>(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(ref riidResource, ref ppvResource, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
