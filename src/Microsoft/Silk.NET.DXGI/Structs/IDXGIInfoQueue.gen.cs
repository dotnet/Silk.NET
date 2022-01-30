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
    public unsafe partial struct IDXGIInfoQueue
    {
        public static readonly Guid Guid = new("d67441c7-672a-476f-9e82-cd55b44949ce");

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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMessageCountLimit(Guid Producer, ulong MessageCountLimit)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, int>)LpVtbl[3])(@this, Producer, MessageCountLimit);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, int>)LpVtbl[3])(@this, Producer, MessageCountLimit);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong, int>)LpVtbl[3])(@this, Producer, MessageCountLimit);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStoredMessages(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)LpVtbl[4])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)LpVtbl[4])(@this, Producer);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, void>)LpVtbl[4])(@this, Producer);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, ref nuint pMessageByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilters(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[6])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[6])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[6])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessages(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[7])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[7])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[7])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDiscardedByMessageCountLimit(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[8])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[8])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[8])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMessageCountLimit(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[9])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[9])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[9])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesAllowedByStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[10])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[10])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[10])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDeniedByStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[11])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[11])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[11])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddStorageFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddStorageFilterEntries(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)LpVtbl[14])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)LpVtbl[14])(@this, Producer);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, void>)LpVtbl[14])(@this, Producer);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[15])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[15])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[15])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushDenyAllStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[16])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[16])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[16])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[17])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[17])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[17])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushStorageFilter(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushStorageFilter(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopStorageFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)LpVtbl[19])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)LpVtbl[19])(@this, Producer);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, void>)LpVtbl[19])(@this, Producer);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetStorageFilterStackSize(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, uint>)LpVtbl[20])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)LpVtbl[20])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, uint>)LpVtbl[20])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRetrievalFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddRetrievalFilterEntries(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)LpVtbl[23])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)LpVtbl[23])(@this, Producer);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, void>)LpVtbl[23])(@this, Producer);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[24])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[24])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[24])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushDenyAllRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[25])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[25])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[25])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[26])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[26])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[26])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopRetrievalFilter(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void>)LpVtbl[28])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, void>)LpVtbl[28])(@this, Producer);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, void>)LpVtbl[28])(@this, Producer);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetRetrievalFilterStackSize(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, uint>)LpVtbl[29])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, uint>)LpVtbl[29])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, uint>)LpVtbl[29])(@this, Producer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, byte* pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, ref byte pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            }
            #endif
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddApplicationMessage(InfoQueueMessageSeverity Severity, byte* pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescription);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescription);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescription);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(InfoQueueMessageSeverity Severity, ref byte pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(InfoQueueMessageSeverity Severity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
            }
            #endif
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category, int bEnable)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int, int>)LpVtbl[32])(@this, Producer, Category, bEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int, int>)LpVtbl[32])(@this, Producer, Category, bEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int, int>)LpVtbl[32])(@this, Producer, Category, bEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity, int bEnable)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int, int>)LpVtbl[33])(@this, Producer, Severity, bEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int, int>)LpVtbl[33])(@this, Producer, Severity, bEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int, int>)LpVtbl[33])(@this, Producer, Severity, bEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnID(Guid Producer, int ID, int bEnable)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, int, int>)LpVtbl[34])(@this, Producer, ID, bEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, int, int>)LpVtbl[34])(@this, Producer, ID, bEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int, int, int>)LpVtbl[34])(@this, Producer, ID, bEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int>)LpVtbl[35])(@this, Producer, Category);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int>)LpVtbl[35])(@this, Producer, Category);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int>)LpVtbl[35])(@this, Producer, Category);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int>)LpVtbl[36])(@this, Producer, Severity);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int>)LpVtbl[36])(@this, Producer, Severity);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int>)LpVtbl[36])(@this, Producer, Severity);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakOnID(Guid Producer, int ID)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, int>)LpVtbl[37])(@this, Producer, ID);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, int>)LpVtbl[37])(@this, Producer, ID);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int, int>)LpVtbl[37])(@this, Producer, ID);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMuteDebugOutput(Guid Producer, int bMute)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, void>)LpVtbl[38])(@this, Producer, bMute);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int, void>)LpVtbl[38])(@this, Producer, bMute);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int, void>)LpVtbl[38])(@this, Producer, bMute);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMuteDebugOutput(Guid Producer)
        {
            var @this = (IDXGIInfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int>)LpVtbl[39])(@this, Producer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIInfoQueue*, Guid, int>)LpVtbl[39])(@this, Producer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIInfoQueue*, Guid, int>)LpVtbl[39])(@this, Producer);
            }
            #endif
            return ret;
        }

    }
}
