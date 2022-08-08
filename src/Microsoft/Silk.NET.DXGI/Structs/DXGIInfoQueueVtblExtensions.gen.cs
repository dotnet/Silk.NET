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

namespace Silk.NET.DXGI;

public unsafe static class DXGIInfoQueueVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMessageCountLimit<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageCountLimit) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, int>)@this->LpVtbl[3])(@this, Producer, MessageCountLimit);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearStoredMessages<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[4])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, ref nuint pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, nuint* pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, ref nuint pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueMessage* pMessagePtr = &pMessage)
        {
            fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessagesAllowedByRetrievalFilters<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[6])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessages<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[7])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDiscardedByMessageCountLimit<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[8])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMessageCountLimit<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[9])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesAllowedByStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[10])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDeniedByStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[11])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddStorageFilterEntries<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[14])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[15])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushDenyAllStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[16])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[17])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[18])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[18])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopStorageFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[19])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static uint GetStorageFilterStackSize<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)@this->LpVtbl[20])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRetrievalFilterEntries<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[21])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[21])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[23])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[24])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushDenyAllRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[25])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[26])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[27])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, ref InfoQueueFilter pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[27])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[28])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static uint GetRetrievalFilterStackSize<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)@this->LpVtbl[29])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMessage<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, byte* pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, ref byte pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddApplicationMessage<TThis>(this TThis thisVtbl, InfoQueueMessageSeverity Severity, byte* pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage<TThis>(this TThis thisVtbl, InfoQueueMessageSeverity Severity, ref byte pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage<TThis>(this TThis thisVtbl, InfoQueueMessageSeverity Severity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnCategory<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageCategory Category, int bEnable) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int, int>)@this->LpVtbl[32])(@this, Producer, Category, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnSeverity<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageSeverity Severity, int bEnable) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int, int>)@this->LpVtbl[33])(@this, Producer, Severity, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnID<TThis>(this TThis thisVtbl, Guid Producer, int ID, int bEnable) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, int, int>)@this->LpVtbl[34])(@this, Producer, ID, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakOnCategory<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageCategory Category) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int>)@this->LpVtbl[35])(@this, Producer, Category);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakOnSeverity<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageSeverity Severity) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int>)@this->LpVtbl[36])(@this, Producer, Severity);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakOnID<TThis>(this TThis thisVtbl, Guid Producer, int ID) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, int>)@this->LpVtbl[37])(@this, Producer, ID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMuteDebugOutput<TThis>(this TThis thisVtbl, Guid Producer, int bMute) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, void>)@this->LpVtbl[38])(@this, Producer, bMute);
    }

    /// <summary>To be documented.</summary>
    public static int GetMuteDebugOutput<TThis>(this TThis thisVtbl, Guid Producer) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[39])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, Span<nuint> pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMessageA(Producer, MessageIndex, pMessage, ref pMessageByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, Span<InfoQueueMessage> pMessage, nuint* pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMessageA(Producer, MessageIndex, ref pMessage.GetPinnableReference(), pMessageByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA<TThis>(this TThis thisVtbl, Guid Producer, ulong MessageIndex, Span<InfoQueueMessage> pMessage, Span<nuint> pMessageByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMessageA(Producer, MessageIndex, ref pMessage.GetPinnableReference(), ref pMessageByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AddStorageFilterEntries(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter, Span<nuint> pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStorageFilter(Producer, pFilter, ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStorageFilter(Producer, ref pFilter.GetPinnableReference(), pFilterByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, Span<nuint> pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStorageFilter(Producer, ref pFilter.GetPinnableReference(), ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PushStorageFilter(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AddRetrievalFilterEntries(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueFilter* pFilter, Span<nuint> pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRetrievalFilter(Producer, pFilter, ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRetrievalFilter(Producer, ref pFilter.GetPinnableReference(), pFilterByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, Span<nuint> pFilterByteLength) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRetrievalFilter(Producer, ref pFilter.GetPinnableReference(), ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter<TThis>(this TThis thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PushRetrievalFilter(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage<TThis>(this TThis thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, Span<byte> pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AddMessage(Producer, Category, Severity, ID, ref pDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage<TThis>(this TThis thisVtbl, InfoQueueMessageSeverity Severity, Span<byte> pDescription) where TThis : IComVtbl<IDXGIInfoQueue>
    {
        var @this = (IDXGIInfoQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AddApplicationMessage(Severity, ref pDescription.GetPinnableReference());
    }

}
