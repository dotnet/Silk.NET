// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12InfoQueue")]
    public unsafe partial struct ID3D12InfoQueue
    {
        public ID3D12InfoQueue
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMessageCountLimit(ulong MessageCountLimit)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong, int>)LpVtbl[3])(@this, MessageCountLimit);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearStoredMessages()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12InfoQueue*, void>)LpVtbl[4])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, uint* pMessageByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, ref uint pMessageByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pMessageByteLengthPtr = &pMessageByteLength)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMessageA(ulong MessageIndex, ref Message pMessage, uint* pMessageByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (Message* pMessagePtr = &pMessage)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMessageA(ulong MessageIndex, ref Message pMessage, ref uint pMessageByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (Message* pMessagePtr = &pMessage)
                {
                    fixed (uint* pMessageByteLengthPtr = &pMessageByteLength)
                    {
                        ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong>)LpVtbl[6])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong>)LpVtbl[7])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumStoredMessages()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong>)LpVtbl[9])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong>)LpVtbl[10])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetMessageCountLimit()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, ulong>)LpVtbl[11])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddStorageFilterEntries(InfoQueueFilter* pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddStorageFilterEntries(ref InfoQueueFilter pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStorageFilter(InfoQueueFilter* pFilter, uint* pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLength);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStorageFilter(InfoQueueFilter* pFilter, ref uint pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStorageFilter(ref InfoQueueFilter pFilter, uint* pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetStorageFilter(ref InfoQueueFilter pFilter, ref uint pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                    {
                        ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearStorageFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12InfoQueue*, void>)LpVtbl[14])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public int PushEmptyStorageFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, int>)LpVtbl[15])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushCopyOfStorageFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, int>)LpVtbl[16])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int PushStorageFilter(InfoQueueFilter* pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushStorageFilter(ref InfoQueueFilter pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void PopStorageFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12InfoQueue*, void>)LpVtbl[18])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public uint GetStorageFilterStackSize()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, uint>)LpVtbl[19])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddRetrievalFilterEntries(InfoQueueFilter* pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddRetrievalFilterEntries(ref InfoQueueFilter pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, uint* pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLength);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, ref uint pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRetrievalFilter(ref InfoQueueFilter pFilter, uint* pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRetrievalFilter(ref InfoQueueFilter pFilter, ref uint pFilterByteLength)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                    {
                        ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12InfoQueue*, void>)LpVtbl[22])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public int PushEmptyRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, int>)LpVtbl[23])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushCopyOfRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, int>)LpVtbl[24])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int PushRetrievalFilter(InfoQueueFilter* pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushRetrievalFilter(ref InfoQueueFilter pFilter)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void PopRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12InfoQueue*, void>)LpVtbl[26])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public uint GetRetrievalFilterStackSize()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, uint>)LpVtbl[27])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, byte* pDescription)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescription);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, ref byte pDescription)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (byte* pDescriptionPtr = &pDescription)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, string pDescription)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
            var pDescriptionPtr = (byte*) Marshal.StringToHGlobalAnsi(pDescription);
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            Marshal.FreeHGlobal((IntPtr)pDescriptionPtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddApplicationMessage(MessageSeverity Severity, byte* pDescription)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescription);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddApplicationMessage(MessageSeverity Severity, ref byte pDescription)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                fixed (byte* pDescriptionPtr = &pDescription)
                {
                    ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddApplicationMessage(MessageSeverity Severity, string pDescription)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
            var pDescriptionPtr = (byte*) Marshal.StringToHGlobalAnsi(pDescription);
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            Marshal.FreeHGlobal((IntPtr)pDescriptionPtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBreakOnCategory(MessageCategory Category, int bEnable)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageCategory, int, int>)LpVtbl[30])(@this, Category, bEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBreakOnSeverity(MessageSeverity Severity, int bEnable)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageSeverity, int, int>)LpVtbl[31])(@this, Severity, bEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBreakOnID(MessageID ID, int bEnable)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageID, int, int>)LpVtbl[32])(@this, ID, bEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBreakOnCategory(MessageCategory Category)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageCategory, int>)LpVtbl[33])(@this, Category);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBreakOnSeverity(MessageSeverity Severity)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageSeverity, int>)LpVtbl[34])(@this, Severity);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBreakOnID(MessageID ID)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, MessageID, int>)LpVtbl[35])(@this, ID);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void SetMuteDebugOutput(int bMute)
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12InfoQueue*, int, void>)LpVtbl[36])(@this, bMute);
            }
        }

        /// <summary>To be added.</summary>
        public int GetMuteDebugOutput()
        {
            fixed (ID3D12InfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12InfoQueue*, int>)LpVtbl[37])(@this);
                return ret;
            }
        }

    }
}
