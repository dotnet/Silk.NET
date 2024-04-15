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
    [Guid("0742a90b-c387-483f-b946-30a7e4e61458")]
    [NativeName("Name", "ID3D12InfoQueue")]
    public unsafe partial struct ID3D12InfoQueue : IComVtbl<ID3D12InfoQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0742a90b-c387-483f-b946-30a7e4e61458");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12InfoQueue val)
            => Unsafe.As<ID3D12InfoQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12InfoQueue
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
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMessageCountLimit(ulong MessageCountLimit)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong, int>)@this->LpVtbl[3])(@this, MessageCountLimit);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStoredMessages()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, ref nuint pMessageByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, ref Message pMessage, nuint* pMessageByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Message* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMessageA(ulong MessageIndex, ref Message pMessage, ref nuint pMessageByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Message* pMessagePtr = &pMessage)
            {
                fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong, Message*, nuint*, int>)@this->LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesAllowedByStorageFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDeniedByStorageFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessages()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMessageCountLimit()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, ulong>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddStorageFilterEntries(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddStorageFilterEntries(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilter, pFilterByteLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStorageFilter(ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStorageFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, void>)@this->LpVtbl[14])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyStorageFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, int>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfStorageFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, int>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushStorageFilter(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[17])(@this, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushStorageFilter(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[17])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopStorageFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, void>)@this->LpVtbl[18])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetStorageFilterStackSize()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, uint>)@this->LpVtbl[19])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRetrievalFilterEntries(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[20])(@this, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddRetrievalFilterEntries(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[20])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilter, pFilterByteLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRetrievalFilter(ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRetrievalFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, void>)@this->LpVtbl[22])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyRetrievalFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, int>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfRetrievalFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, int>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushRetrievalFilter(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[25])(@this, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushRetrievalFilter(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, InfoQueueFilter*, int>)@this->LpVtbl[25])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopRetrievalFilter()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, void>)@this->LpVtbl[26])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetRetrievalFilterStackSize()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, uint>)@this->LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)@this->LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddApplicationMessage(MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(MessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageSeverity, byte*, int>)@this->LpVtbl[29])(@this, Severity, pDescriptionPtr);
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnCategory(MessageCategory Category, Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageCategory, Silk.NET.Core.Bool32, int>)@this->LpVtbl[30])(@this, Category, bEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnSeverity(MessageSeverity Severity, Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageSeverity, Silk.NET.Core.Bool32, int>)@this->LpVtbl[31])(@this, Severity, bEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnID(MessageID ID, Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageID, Silk.NET.Core.Bool32, int>)@this->LpVtbl[32])(@this, ID, bEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetBreakOnCategory(MessageCategory Category)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageCategory, Silk.NET.Core.Bool32>)@this->LpVtbl[33])(@this, Category);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetBreakOnSeverity(MessageSeverity Severity)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageSeverity, Silk.NET.Core.Bool32>)@this->LpVtbl[34])(@this, Severity);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetBreakOnID(MessageID ID)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, MessageID, Silk.NET.Core.Bool32>)@this->LpVtbl[35])(@this, ID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMuteDebugOutput(Silk.NET.Core.Bool32 bMute)
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[36])(@this, bMute);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetMuteDebugOutput()
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12InfoQueue*, Silk.NET.Core.Bool32>)@this->LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
