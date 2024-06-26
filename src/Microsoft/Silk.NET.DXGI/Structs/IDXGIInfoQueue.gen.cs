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

namespace Silk.NET.DXGI
{
    [Guid("d67441c7-672a-476f-9e82-cd55b44949ce")]
    [NativeName("Name", "IDXGIInfoQueue")]
    public unsafe partial struct IDXGIInfoQueue : IComVtbl<IDXGIInfoQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d67441c7-672a-476f-9e82-cd55b44949ce");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIInfoQueue val)
            => Unsafe.As<IDXGIInfoQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIInfoQueue
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
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMessageCountLimit(Guid Producer, ulong MessageCountLimit)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, int>)@this->LpVtbl[3])(@this, Producer, MessageCountLimit);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStoredMessages(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[4])(@this, Producer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, ref nuint pMessageByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, nuint* pMessageByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)@this->LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMessageA(Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, ref nuint pMessageByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilters(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[6])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessages(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[7])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDiscardedByMessageCountLimit(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[8])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMessageCountLimit(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[9])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesAllowedByStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[10])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDeniedByStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)@this->LpVtbl[11])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddStorageFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, Producer, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddStorageFilterEntries(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[12])(@this, Producer, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(Guid Producer, ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStorageFilter(Guid Producer, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly void ClearStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[14])(@this, Producer);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[15])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushDenyAllStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[16])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[17])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushStorageFilter(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[18])(@this, Producer, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushStorageFilter(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[18])(@this, Producer, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[19])(@this, Producer);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetStorageFilterStackSize(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)@this->LpVtbl[20])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRetrievalFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[21])(@this, Producer, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddRetrievalFilterEntries(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[21])(@this, Producer, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)@this->LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly void ClearRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[23])(@this, Producer);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[24])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushDenyAllRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[25])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)@this->LpVtbl[26])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[27])(@this, Producer, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)@this->LpVtbl[27])(@this, Producer, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)@this->LpVtbl[28])(@this, Producer);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetRetrievalFilterStackSize(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)@this->LpVtbl[29])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)@this->LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddApplicationMessage(InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(InfoQueueMessageSeverity Severity, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)@this->LpVtbl[31])(@this, Severity, pDescriptionPtr);
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category, Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, Silk.NET.Core.Bool32, int>)@this->LpVtbl[32])(@this, Producer, Category, bEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity, Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, Silk.NET.Core.Bool32, int>)@this->LpVtbl[33])(@this, Producer, Severity, bEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnID(Guid Producer, int ID, Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, Silk.NET.Core.Bool32, int>)@this->LpVtbl[34])(@this, Producer, ID, bEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, Silk.NET.Core.Bool32>)@this->LpVtbl[35])(@this, Producer, Category);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, Silk.NET.Core.Bool32>)@this->LpVtbl[36])(@this, Producer, Severity);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetBreakOnID(Guid Producer, int ID)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, Silk.NET.Core.Bool32>)@this->LpVtbl[37])(@this, Producer, ID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMuteDebugOutput(Guid Producer, Silk.NET.Core.Bool32 bMute)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, Silk.NET.Core.Bool32, void>)@this->LpVtbl[38])(@this, Producer, bMute);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetMuteDebugOutput(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, Silk.NET.Core.Bool32>)@this->LpVtbl[39])(@this, Producer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
