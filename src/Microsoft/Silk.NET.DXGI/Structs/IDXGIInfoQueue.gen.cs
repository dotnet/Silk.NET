// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGIInfoQueue")]
    public unsafe partial struct IDXGIInfoQueue
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIInfoQueue val)
            => Unsafe.As<IDXGIInfoQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGIInfoQueue
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
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMessageCountLimit(Guid Producer, ulong MessageCountLimit)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong, int>)LpVtbl[3])(@this, Producer, MessageCountLimit);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearStoredMessages(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ((delegate* cdecl<IDXGIInfoQueue*, Guid, void>)LpVtbl[4])(@this, Producer);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMessageA(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, uint* pMessageByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, uint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLength);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMessageA(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, ref uint pMessageByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pMessageByteLengthPtr = &pMessageByteLength)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, uint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessage, pMessageByteLengthPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMessageA(Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, uint* pMessageByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueMessage* pMessagePtr = &pMessage)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, uint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLength);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMessageA(Guid Producer, ulong MessageIndex, ref InfoQueueMessage pMessage, ref uint pMessageByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueMessage* pMessagePtr = &pMessage)
                {
                    fixed (uint* pMessageByteLengthPtr = &pMessageByteLength)
                    {
                        ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, uint*, int>)LpVtbl[5])(@this, Producer, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[6])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumStoredMessages(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[7])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumMessagesDiscardedByMessageCountLimit(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[8])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetMessageCountLimit(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[9])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumMessagesAllowedByStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[10])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetNumMessagesDeniedByStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, ulong>)LpVtbl[11])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddStorageFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddStorageFilterEntries(Guid Producer, ref InfoQueueFilter pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[12])(@this, Producer, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, uint* pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLength);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, ref uint pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, Producer, pFilter, pFilterByteLengthPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStorageFilter(Guid Producer, ref InfoQueueFilter pFilter, uint* pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLength);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetStorageFilter(Guid Producer, ref InfoQueueFilter pFilter, ref uint pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                    {
                        ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ((delegate* cdecl<IDXGIInfoQueue*, Guid, void>)LpVtbl[14])(@this, Producer);
            }
        }

        /// <summary>To be added.</summary>
        public int PushEmptyStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[15])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushDenyAllStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[16])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushCopyOfStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[17])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int PushStorageFilter(Guid Producer, InfoQueueFilter* pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushStorageFilter(Guid Producer, ref InfoQueueFilter pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[18])(@this, Producer, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void PopStorageFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ((delegate* cdecl<IDXGIInfoQueue*, Guid, void>)LpVtbl[19])(@this, Producer);
            }
        }

        /// <summary>To be added.</summary>
        public uint GetStorageFilterStackSize(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, uint>)LpVtbl[20])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddRetrievalFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddRetrievalFilterEntries(Guid Producer, ref InfoQueueFilter pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[21])(@this, Producer, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, uint* pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLength);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, ref uint pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[22])(@this, Producer, pFilter, pFilterByteLengthPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter, uint* pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLength);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter, ref uint pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                    {
                        ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, uint*, int>)LpVtbl[22])(@this, Producer, pFilterPtr, pFilterByteLengthPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearRetrievalFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ((delegate* cdecl<IDXGIInfoQueue*, Guid, void>)LpVtbl[23])(@this, Producer);
            }
        }

        /// <summary>To be added.</summary>
        public int PushEmptyRetrievalFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[24])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushDenyAllRetrievalFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[25])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushCopyOfRetrievalFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[26])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int PushRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PushRetrievalFilter(Guid Producer, ref InfoQueueFilter pFilter)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (InfoQueueFilter* pFilterPtr = &pFilter)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)LpVtbl[27])(@this, Producer, pFilterPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void PopRetrievalFilter(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ((delegate* cdecl<IDXGIInfoQueue*, Guid, void>)LpVtbl[28])(@this, Producer);
            }
        }

        /// <summary>To be added.</summary>
        public uint GetRetrievalFilterStackSize(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, uint>)LpVtbl[29])(@this, Producer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, byte* pDescription)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescription);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, ref byte pDescription)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (byte* pDescriptionPtr = &pDescription)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, string pDescription)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
            var pDescriptionPtr = (byte*) Marshal.StringToHGlobalAnsi(pDescription);
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, byte*, int>)LpVtbl[30])(@this, Producer, Category, Severity, ID, pDescriptionPtr);
            Marshal.FreeHGlobal((IntPtr)pDescriptionPtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddApplicationMessage(InfoQueueMessageSeverity Severity, byte* pDescription)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescription);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddApplicationMessage(InfoQueueMessageSeverity Severity, ref byte pDescription)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                fixed (byte* pDescriptionPtr = &pDescription)
                {
                    ret = ((delegate* cdecl<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddApplicationMessage(InfoQueueMessageSeverity Severity, string pDescription)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
            var pDescriptionPtr = (byte*) Marshal.StringToHGlobalAnsi(pDescription);
                ret = ((delegate* cdecl<IDXGIInfoQueue*, InfoQueueMessageSeverity, byte*, int>)LpVtbl[31])(@this, Severity, pDescriptionPtr);
            Marshal.FreeHGlobal((IntPtr)pDescriptionPtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category, int bEnable)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int, int>)LpVtbl[32])(@this, Producer, Category, bEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity, int bEnable)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int, int>)LpVtbl[33])(@this, Producer, Severity, bEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBreakOnID(Guid Producer, int ID, int bEnable)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int, int, int>)LpVtbl[34])(@this, Producer, ID, bEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, int>)LpVtbl[35])(@this, Producer, Category);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, int>)LpVtbl[36])(@this, Producer, Severity);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBreakOnID(Guid Producer, int ID)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int, int>)LpVtbl[37])(@this, Producer, ID);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void SetMuteDebugOutput(Guid Producer, int bMute)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                ((delegate* cdecl<IDXGIInfoQueue*, Guid, int, void>)LpVtbl[38])(@this, Producer, bMute);
            }
        }

        /// <summary>To be added.</summary>
        public int GetMuteDebugOutput(Guid Producer)
        {
            fixed (IDXGIInfoQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIInfoQueue*, Guid, int>)LpVtbl[39])(@this, Producer);
                return ret;
            }
        }

    }
}
