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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGIOutputDuplication")]
    public unsafe partial struct IDXGIOutputDuplication
    {
        public IDXGIOutputDuplication
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
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pUnknown)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pUnknown)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDesc(OutduplDesc* pDesc)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                ((delegate* cdecl<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDesc);
            }
        }

        /// <summary>To be added.</summary>
        public void GetDesc(ref OutduplDesc pDesc)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                fixed (OutduplDesc* pDescPtr = &pDesc)
                {
                    ((delegate* cdecl<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDescPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref IDXGIResource* ppDesktopResource)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref IDXGIResource* ppDesktopResource)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
                {
                    fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResourcePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Core.Runtime.Windows.TagRect* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Core.Runtime.Windows.TagRect* pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref Silk.NET.Core.Runtime.Windows.TagRect pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref Silk.NET.Core.Runtime.Windows.TagRect pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
                {
                    fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequiredPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameMoveRects(uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
                {
                    fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequiredPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
                {
                    fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (T0* pPointerShapeBufferPtr = &pPointerShapeBuffer)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, T0*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (T0* pPointerShapeBufferPtr = &pPointerShapeBuffer)
                {
                    fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, T0*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (T0* pPointerShapeBufferPtr = &pPointerShapeBuffer)
                {
                    fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
                    {
                        ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, T0*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (T0* pPointerShapeBufferPtr = &pPointerShapeBuffer)
                {
                    fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
                    {
                        fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                        {
                            ret = ((delegate* cdecl<IDXGIOutputDuplication*, uint, T0*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int MapDesktopSurface(MappedRect* pLockedRect)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int MapDesktopSurface(ref MappedRect pLockedRect)
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                fixed (MappedRect* pLockedRectPtr = &pLockedRect)
                {
                    ret = ((delegate* cdecl<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int UnMapDesktopSurface()
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, int>)LpVtbl[13])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReleaseFrame()
        {
            fixed (IDXGIOutputDuplication* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutputDuplication*, int>)LpVtbl[14])(@this);
                return ret;
            }
        }

    }
}
