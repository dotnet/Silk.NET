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
    public static unsafe int QueryInterface(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIInfoQueue> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIInfoQueue> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDXGIInfoQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIInfoQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMessageCountLimit(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageCountLimit)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, int>)@this->LpVtbl[3])(@this, Producer, MessageCountLimit);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearStoredMessages(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[4])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, ref nuint pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, nuint* pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, ref nuint pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
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
    public static ulong GetNumStoredMessagesAllowedByRetrievalFilters(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[6])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessages(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[7])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDiscardedByMessageCountLimit(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[8])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMessageCountLimit(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[9])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesAllowedByStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[10])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDeniedByStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[11])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddStorageFilterEntries(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
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
    public static void ClearStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[14])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[15])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushDenyAllStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[16])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[17])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[18])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[18])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[19])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static uint GetStorageFilterStackSize(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)@this->LpVtbl[20])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRetrievalFilterEntries(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[21])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[21])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
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
    public static void ClearRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[23])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[24])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushDenyAllRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[25])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[26])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[27])(@this, Producer, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[27])(@this, Producer, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[28])(@this, Producer);
    }

    /// <summary>To be documented.</summary>
    public static uint GetRetrievalFilterStackSize(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)@this->LpVtbl[29])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddApplicationMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnCategory(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageCategory Category, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, Silk.NET.Core.Bool32, int>)@this->LpVtbl[32])(@this, Producer, Category, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnSeverity(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageSeverity Severity, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, Silk.NET.Core.Bool32, int>)@this->LpVtbl[33])(@this, Producer, Severity, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnID(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, int ID, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, Silk.NET.Core.Bool32, int>)@this->LpVtbl[34])(@this, Producer, ID, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetBreakOnCategory(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageCategory Category)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, Silk.NET.Core.Bool32>)@this->LpVtbl[35])(@this, Producer, Category);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetBreakOnSeverity(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageSeverity Severity)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, Silk.NET.Core.Bool32>)@this->LpVtbl[36])(@this, Producer, Severity);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetBreakOnID(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, int ID)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, Silk.NET.Core.Bool32>)@this->LpVtbl[37])(@this, Producer, ID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMuteDebugOutput(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Silk.NET.Core.Bool32 bMute)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, Silk.NET.Core.Bool32, void>)@this->LpVtbl[38])(@this, Producer, bMute);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetMuteDebugOutput(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, Silk.NET.Core.Bool32>)@this->LpVtbl[39])(@this, Producer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIInfoQueue> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIInfoQueue> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIInfoQueue> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, Span<nuint> pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMessageA(Producer, MessageIndex, pMessage, ref pMessageByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, Span<InfoQueueMessage> pMessage, nuint* pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMessageA(Producer, MessageIndex, ref pMessage.GetPinnableReference(), pMessageByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, ulong MessageIndex, Span<InfoQueueMessage> pMessage, Span<nuint> pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMessageA(Producer, MessageIndex, ref pMessage.GetPinnableReference(), ref pMessageByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddStorageFilterEntries(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStorageFilter(Producer, pFilter, ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStorageFilter(Producer, ref pFilter.GetPinnableReference(), pFilterByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStorageFilter(Producer, ref pFilter.GetPinnableReference(), ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushStorageFilter(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddRetrievalFilterEntries(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueFilter* pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRetrievalFilter(Producer, pFilter, ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRetrievalFilter(Producer, ref pFilter.GetPinnableReference(), pFilterByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRetrievalFilter(Producer, ref pFilter.GetPinnableReference(), ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushRetrievalFilter(Producer, ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDescription)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMessage(Producer, Category, Severity, ID, in pDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage(this ComPtr<IDXGIInfoQueue> thisVtbl, InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDescription)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddApplicationMessage(Severity, in pDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIInfoQueue> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
