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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Luid GetLUID<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        Luid ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, Guid* riid, void** ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, ref Guid riid, void** ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvQueuePtr = &ppvQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidQueuePtr = &riidQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
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
    public static int InsertImplicitSync<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetSwapChainObject<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->GetSwapChainObject(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSwapChainObject(ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSwapChainObject(ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentResourceAndCommandQueue<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppvResource, out ComPtr<TI1> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppvResource, Guid* riidQueue, ref void* ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, Span<Guid> riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppvResource, ref Guid riidQueue, void** ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), ref riidQueue, ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, Span<Guid> riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetCurrentResourceAndCommandQueue(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf(), ref riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, out ComPtr<TI0> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, Span<Guid> riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, Span<Guid> riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, riidQueue, ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, out ComPtr<TI0> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource, ppvResource, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, void** ppvResource, Span<Guid> riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, void** ppvResource, Span<Guid> riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, riidQueue, ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, out ComPtr<TI0> ppvQueue) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvQueue = default;
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource, ref ppvResource, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, riidQueue, ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Span<Guid> riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, ref riidQueue.GetPinnableReference(), ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Span<Guid> riidResource, ref void* ppvResource, Span<Guid> riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentResourceAndCommandQueue(ref riidResource.GetPinnableReference(), ref ppvResource, ref riidQueue.GetPinnableReference(), ref ppvQueue);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetSwapChainObject<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetSwapChainObject(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> GetCurrentResourceAndCommandQueue<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(ref ppvResource, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(riidResource, ref ppvResource, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(ref riidResource, ppvResource, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCurrentResourceAndCommandQueue<TI0, TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCurrentResourceAndCommandQueue(ref riidResource, ref ppvResource, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
