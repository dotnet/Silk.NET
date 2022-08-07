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

public unsafe static class D3D12InfoQueue1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMessageCountLimit<TThis>(this TThis thisVtbl, ulong MessageCountLimit) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, int>)@this->LpVtbl[3])(@this, MessageCountLimit);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearStoredMessages<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, ulong MessageIndex, Message* pMessage, ref nuint pMessageByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA<TThis>(this TThis thisVtbl, ulong MessageIndex, ref Message pMessage, nuint* pMessageByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Message* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA<TThis>(this TThis thisVtbl, ulong MessageIndex, ref Message pMessage, ref nuint pMessageByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Message* pMessagePtr = &pMessage)
        {
            fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesAllowedByStorageFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDeniedByStorageFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessages<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessagesAllowedByRetrievalFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDiscardedByMessageCountLimit<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMessageCountLimit<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddStorageFilterEntries<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearStorageFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[14])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyStorageFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfStorageFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushStorageFilter<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[17])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[17])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopStorageFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[18])(@this);
    }

    /// <summary>To be documented.</summary>
    public static uint GetStorageFilterStackSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[19])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRetrievalFilterEntries<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[20])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[20])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter, nuint* pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearRetrievalFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[22])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyRetrievalFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfRetrievalFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushRetrievalFilter<TThis>(this TThis thisVtbl, InfoQueueFilter* pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[25])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter<TThis>(this TThis thisVtbl, ref InfoQueueFilter pFilter) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[25])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopRetrievalFilter<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[26])(@this);
    }

    /// <summary>To be documented.</summary>
    public static uint GetRetrievalFilterStackSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMessage<TThis>(this TThis thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, byte* pDescription) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage<TThis>(this TThis thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, ref byte pDescription) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage<TThis>(this TThis thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddApplicationMessage<TThis>(this TThis thisVtbl, MessageSeverity Severity, byte* pDescription) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage<TThis>(this TThis thisVtbl, MessageSeverity Severity, ref byte pDescription) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage<TThis>(this TThis thisVtbl, MessageSeverity Severity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnCategory<TThis>(this TThis thisVtbl, MessageCategory Category, int bEnable) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, int, int>)@this->LpVtbl[30])(@this, Category, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnSeverity<TThis>(this TThis thisVtbl, MessageSeverity Severity, int bEnable) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, int, int>)@this->LpVtbl[31])(@this, Severity, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnID<TThis>(this TThis thisVtbl, MessageID ID, int bEnable) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageID, int, int>)@this->LpVtbl[32])(@this, ID, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakOnCategory<TThis>(this TThis thisVtbl, MessageCategory Category) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, int>)@this->LpVtbl[33])(@this, Category);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakOnSeverity<TThis>(this TThis thisVtbl, MessageSeverity Severity) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, int>)@this->LpVtbl[34])(@this, Severity);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakOnID<TThis>(this TThis thisVtbl, MessageID ID) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageID, int>)@this->LpVtbl[35])(@this, ID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMuteDebugOutput<TThis>(this TThis thisVtbl, int bMute) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int, void>)@this->LpVtbl[36])(@this, bMute);
    }

    /// <summary>To be documented.</summary>
    public static int GetMuteDebugOutput<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback<TThis>(this TThis thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, uint* pCallbackCookie) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback<TThis>(this TThis thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, ref uint pCallbackCookie) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCallbackCookiePtr = &pCallbackCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback<T0, TThis>(this TThis thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, ref T0 pContext, uint* pCallbackCookie) where T0 : unmanaged where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContextPtr, pCallbackCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterMessageCallback<T0, TThis>(this TThis thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, ref T0 pContext, ref uint pCallbackCookie) where T0 : unmanaged where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            fixed (uint* pCallbackCookiePtr = &pCallbackCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContextPtr, pCallbackCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterMessageCallback<TThis>(this TThis thisVtbl, uint CallbackCookie) where TThis : IComVtbl<ID3D12InfoQueue1>
    {
        var @this = (ID3D12InfoQueue1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint, int>)@this->LpVtbl[39])(@this, CallbackCookie);
        return ret;
    }

}
