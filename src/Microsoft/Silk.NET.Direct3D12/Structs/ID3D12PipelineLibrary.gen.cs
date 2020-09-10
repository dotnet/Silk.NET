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
    [NativeName("Name", "ID3D12PipelineLibrary")]
    public unsafe partial struct ID3D12PipelineLibrary
    {
        public ID3D12PipelineLibrary
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
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StorePipeline(char* pName, ID3D12PipelineState* pPipeline)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pName, pPipeline);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StorePipeline(char* pName, ref ID3D12PipelineState pPipeline)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pName, pPipelinePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StorePipeline(ref char pName, ID3D12PipelineState* pPipeline)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipeline);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int StorePipeline(ref char pName, ref ID3D12PipelineState pPipeline)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StorePipeline(string pName, ID3D12PipelineState* pPipeline)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipeline);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int StorePipeline(string pName, ref ID3D12PipelineState pPipeline)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineState);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineStatePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppPipelineStatePtr = &ppPipelineState)
                            {
                                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadGraphicsPipeline(string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineState);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineStatePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pNamePtr = &pName)
                {
                    fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppPipelineStatePtr = &ppPipelineState)
                            {
                                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadComputePipeline(string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* cdecl<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetSerializedSize()
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, uint>)LpVtbl[11])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Serialize(void* pData, uint DataSizeInBytes)
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12PipelineLibrary*, void*, uint, int>)LpVtbl[12])(@this, pData, DataSizeInBytes);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Serialize<T0>(ref T0 pData, uint DataSizeInBytes) where T0 : unmanaged
        {
            fixed (ID3D12PipelineLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12PipelineLibrary*, T0*, uint, int>)LpVtbl[12])(@this, pDataPtr, DataSizeInBytes);
                }
                return ret;
            }
        }

    }
}
