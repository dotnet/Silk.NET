// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [Guid("189819f1-1db6-4b57-be54-1821339b85f7")]
    [NativeName("Name", "ID3D12Device")]
    public unsafe partial struct ID3D12Device
    {
        public static implicit operator ID3D12Object(ID3D12Device val)
            => Unsafe.As<ID3D12Device, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Device val)
            => Unsafe.As<ID3D12Device, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Device
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetName(string Name)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetNodeCount()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, Guid* riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riid, ppCommandQueuePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, ref Guid riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueue);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, ref Guid riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueue);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, Guid* riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, ref Guid riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueue);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, ref Guid riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riid, ppCommandAllocator);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, ref void* ppCommandAllocator)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riid, ppCommandAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, ref Guid riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riidPtr, ppCommandAllocator);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, ref Guid riid, ref void* ppCommandAllocator)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riidPtr, ppCommandAllocatorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandListPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandList);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCommandListPtr = &ppCommandList)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandListPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Feature, void*, uint, int>)LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int CheckFeatureSupport<T0>(Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pFeatureSupportDataPtr = &pFeatureSupportData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, Feature, T0*, uint, int>)LpVtbl[13])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetDescriptorHandleIncrementSize(DescriptorHeapType DescriptorHeapType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, DescriptorHeapType, uint>)LpVtbl[15])(@this, DescriptorHeapType);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, uint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, void*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, uint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, void*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, uint blobLengthInBytes, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, void*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, uint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, void*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, uint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, T0*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, uint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, T0*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, uint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, T0*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignature);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, uint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, T0*, uint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateConstantBufferView(ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)LpVtbl[17])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be added.</summary>
        public readonly void CreateConstantBufferView(ref ConstantBufferViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ConstantBufferViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)LpVtbl[17])(@this, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateShaderResourceView(ref ID3D12Resource pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void CreateShaderResourceView(ref ID3D12Resource pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDesc, DestDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void CreateUnorderedAccessView(ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
                {
                    fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDescPtr, DestDescriptor);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateRenderTargetView(ref ID3D12Resource pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void CreateRenderTargetView(ref ID3D12Resource pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateDepthStencilView(ref ID3D12Resource pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void CreateDepthStencilView(ref ID3D12Resource pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CreateSampler(SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, SamplerDesc*, CpuDescriptorHandle, void>)LpVtbl[22])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be added.</summary>
        public readonly void CreateSampler(ref SamplerDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SamplerDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, SamplerDesc*, CpuDescriptorHandle, void>)LpVtbl[22])(@this, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                    {
                        fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void CopyDescriptorsSimple(uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ResourceAllocationInfo ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, uint, ResourceDesc*, ResourceAllocationInfo>)LpVtbl[25])(@this, visibleMask, numResourceDescs, pResourceDescs);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ResourceAllocationInfo ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, uint, ResourceDesc*, ResourceAllocationInfo>)LpVtbl[25])(@this, visibleMask, numResourceDescs, pResourceDescsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly HeapProperties GetCustomHeapProperties(uint nodeMask, HeapType heapType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                HeapProperties ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, HeapType, HeapProperties>)LpVtbl[26])(@this, nodeMask, heapType);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, string Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
            }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, string Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, string Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* NamePtr = &Name)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* NamePtr = &Name)
                    {
                        fixed (void** pHandlePtr = &pHandle)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, string Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, void** ppvObj)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riid, ppvObj);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, ref void* ppvObj)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riid, ppvObjPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, ref Guid riid, void** ppvObj)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riidPtr, ppvObj);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, ref Guid riid, ref void* ppvObj)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riidPtr, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* NTHandlePtr = &NTHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, T0*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riid, ppvObj);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* NTHandlePtr = &NTHandle)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, T0*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riid, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, ref Guid riid, void** ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* NTHandlePtr = &NTHandle)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, T0*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, ref Guid riid, ref void* ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* NTHandlePtr = &NTHandle)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, T0*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandleByName(char* Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, char*, uint, void**, int>)LpVtbl[33])(@this, Name, Access, pNTHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandleByName(char* Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, char*, uint, void**, int>)LpVtbl[33])(@this, Name, Access, pNTHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandleByName(ref char Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, char*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandleByName(ref char Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pNTHandlePtr = &pNTHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, char*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandleByName(string Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, byte*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int OpenSharedHandleByName(string Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, byte*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
            }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, ID3D12Pageable**, int>)LpVtbl[34])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, ref ID3D12Pageable* ppObjects)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, ID3D12Pageable**, int>)LpVtbl[34])(@this, NumObjects, ppObjectsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Evict(uint NumObjects, ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, ID3D12Pageable**, int>)LpVtbl[35])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Evict(uint NumObjects, ref ID3D12Pageable* ppObjects)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, uint, ID3D12Pageable**, int>)LpVtbl[35])(@this, NumObjects, ppObjectsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, ref void* ppFence)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riid, ppFencePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, ref Guid riid, void** ppFence)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFence);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, ref Guid riid, ref void* ppFence)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppFencePtr = &ppFence)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDeviceRemovedReason()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, int>)LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetStablePowerState(int Enable)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, int, int>)LpVtbl[40])(@this, Enable);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                            {
                                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly ValueTuple<ulong,long> GetAdapterLuid()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ValueTuple<ulong,long> ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12Device*, ValueTuple<ulong,long>>)LpVtbl[43])(@this);
            return ret;
        }

    }
}
