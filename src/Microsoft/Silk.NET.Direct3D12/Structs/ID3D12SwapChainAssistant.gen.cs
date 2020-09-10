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
    [NativeName("Name", "ID3D12SwapChainAssistant")]
    public unsafe partial struct ID3D12SwapChainAssistant
    {
        public ID3D12SwapChainAssistant
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
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ValueTuple<ulong,long> GetLUID()
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                ValueTuple<ulong,long> ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, ValueTuple<ulong,long>>)LpVtbl[3])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChainObject(Guid* riid, void** ppv)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppv);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChainObject(Guid* riid, ref void* ppv)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riid, ppvPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChainObject(ref Guid riid, void** ppv)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppv);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChainObject(ref Guid riid, ref void* ppv)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, int>)LpVtbl[4])(@this, riidPtr, ppvPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    fixed (Guid* riidQueuePtr = &riidQueue)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    fixed (Guid* riidQueuePtr = &riidQueue)
                    {
                        fixed (void** ppvQueuePtr = &ppvQueue)
                        {
                            ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (Guid* riidQueuePtr = &riidQueue)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (Guid* riidQueuePtr = &riidQueue)
                    {
                        fixed (void** ppvQueuePtr = &ppvQueue)
                        {
                            ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        fixed (void** ppvQueuePtr = &ppvQueue)
                        {
                            ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        fixed (Guid* riidQueuePtr = &riidQueue)
                        {
                            ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentResourceAndCommandQueue(ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue)
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        fixed (Guid* riidQueuePtr = &riidQueue)
                        {
                            fixed (void** ppvQueuePtr = &ppvQueue)
                            {
                                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int InsertImplicitSync()
        {
            fixed (ID3D12SwapChainAssistant* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12SwapChainAssistant*, int>)LpVtbl[6])(@this);
                return ret;
            }
        }

    }
}
