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
    public static unsafe int QueryInterface(this ComPtr<ID3D12InfoQueue1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12InfoQueue1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMessageCountLimit(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageCountLimit)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, int>)@this->LpVtbl[3])(@this, MessageCountLimit);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearStoredMessages(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, Message* pMessage, ref nuint pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, ref Message pMessage, nuint* pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Message* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, ref Message pMessage, ref nuint pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
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
    public static ulong GetNumMessagesAllowedByStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDeniedByStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessages(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumStoredMessagesAllowedByRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetNumMessagesDiscardedByMessageCountLimit(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMessageCountLimit(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, ulong>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddStorageFilterEntries(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
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
    public static void ClearStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[14])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[17])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[17])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[18])(@this);
    }

    /// <summary>To be documented.</summary>
    public static uint GetStorageFilterStackSize(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[19])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddRetrievalFilterEntries(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[20])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[20])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilter, pFilterByteLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
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
    public static void ClearRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[22])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int PushEmptyRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushCopyOfRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, int>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[25])(@this, pFilter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, ref InfoQueueFilter pFilter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InfoQueueFilter* pFilterPtr = &pFilter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, InfoQueueFilter*, int>)@this->LpVtbl[25])(@this, pFilterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PopRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, void>)@this->LpVtbl[26])(@this);
    }

    /// <summary>To be documented.</summary>
    public static uint GetRetrievalFilterStackSize(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddApplicationMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pDescriptionPtr = &pDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescriptionPtr);
        SilkMarshal.Free((nint)pDescriptionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnCategory(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageCategory Category, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, Silk.NET.Core.Bool32, int>)@this->LpVtbl[30])(@this, Category, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnSeverity(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageSeverity Severity, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, Silk.NET.Core.Bool32, int>)@this->LpVtbl[31])(@this, Severity, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBreakOnID(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageID ID, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageID, Silk.NET.Core.Bool32, int>)@this->LpVtbl[32])(@this, ID, bEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetBreakOnCategory(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageCategory Category)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageCategory, Silk.NET.Core.Bool32>)@this->LpVtbl[33])(@this, Category);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetBreakOnSeverity(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageSeverity Severity)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageSeverity, Silk.NET.Core.Bool32>)@this->LpVtbl[34])(@this, Severity);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetBreakOnID(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageID ID)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, MessageID, Silk.NET.Core.Bool32>)@this->LpVtbl[35])(@this, ID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMuteDebugOutput(this ComPtr<ID3D12InfoQueue1> thisVtbl, Silk.NET.Core.Bool32 bMute)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[36])(@this, bMute);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetMuteDebugOutput(this ComPtr<ID3D12InfoQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, Silk.NET.Core.Bool32>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, uint* pCallbackCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, ref uint pCallbackCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCallbackCookiePtr = &pCallbackCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback<T0>(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, ref T0 pContext, uint* pCallbackCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, PfnMessageFunc, MessageCallbackFlags, void*, uint*, int>)@this->LpVtbl[38])(@this, CallbackFunc, CallbackFilterFlags, pContextPtr, pCallbackCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterMessageCallback<T0>(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, ref T0 pContext, ref uint pCallbackCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static int UnregisterMessageCallback(this ComPtr<ID3D12InfoQueue1> thisVtbl, uint CallbackCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue1*, uint, int>)@this->LpVtbl[39])(@this, CallbackCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12InfoQueue1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, Message* pMessage, Span<nuint> pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMessageA(MessageIndex, pMessage, ref pMessageByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, Span<Message> pMessage, nuint* pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMessageA(MessageIndex, ref pMessage.GetPinnableReference(), pMessageByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetMessageA(this ComPtr<ID3D12InfoQueue1> thisVtbl, ulong MessageIndex, Span<Message> pMessage, Span<nuint> pMessageByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMessageA(MessageIndex, ref pMessage.GetPinnableReference(), ref pMessageByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddStorageFilterEntries(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddStorageFilterEntries(ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStorageFilter(pFilter, ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStorageFilter(ref pFilter.GetPinnableReference(), pFilterByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStorageFilter(ref pFilter.GetPinnableReference(), ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushStorageFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushStorageFilter(ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddRetrievalFilterEntries(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddRetrievalFilterEntries(ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, InfoQueueFilter* pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRetrievalFilter(pFilter, ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter, nuint* pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRetrievalFilter(ref pFilter.GetPinnableReference(), pFilterByteLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter, Span<nuint> pFilterByteLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRetrievalFilter(ref pFilter.GetPinnableReference(), ref pFilterByteLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushRetrievalFilter(this ComPtr<ID3D12InfoQueue1> thisVtbl, Span<InfoQueueFilter> pFilter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushRetrievalFilter(ref pFilter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDescription)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMessage(Category, Severity, ID, in pDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddApplicationMessage(this ComPtr<ID3D12InfoQueue1> thisVtbl, MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDescription)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddApplicationMessage(Severity, in pDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, void* pContext, Span<uint> pCallbackCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterMessageCallback(CallbackFunc, CallbackFilterFlags, pContext, ref pCallbackCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterMessageCallback<T0>(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, Span<T0> pContext, uint* pCallbackCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterMessageCallback(CallbackFunc, CallbackFilterFlags, ref pContext.GetPinnableReference(), pCallbackCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterMessageCallback<T0>(this ComPtr<ID3D12InfoQueue1> thisVtbl, PfnMessageFunc CallbackFunc, MessageCallbackFlags CallbackFilterFlags, Span<T0> pContext, Span<uint> pCallbackCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterMessageCallback(CallbackFunc, CallbackFilterFlags, ref pContext.GetPinnableReference(), ref pCallbackCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12InfoQueue1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
