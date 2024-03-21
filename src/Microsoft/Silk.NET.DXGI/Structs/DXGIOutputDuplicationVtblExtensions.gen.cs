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

namespace Silk.NET.DXGI;

public unsafe static class DXGIOutputDuplicationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIOutputDuplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIOutputDuplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesc(this ComPtr<IDXGIOutputDuplication> thisVtbl, OutduplDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDesc);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesc(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref OutduplDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        fixed (OutduplDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref IDXGIResource* ppDesktopResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, IDXGIResource** ppDesktopResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref IDXGIResource* ppDesktopResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
        {
            fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, ref Silk.NET.Maths.Box2D<int> pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, ref Silk.NET.Maths.Box2D<int> pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
        {
            fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequiredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
        {
            fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequiredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
        {
            fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
        {
            fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
        {
            fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
        {
            fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
            {
                fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapDesktopSurface(this ComPtr<IDXGIOutputDuplication> thisVtbl, MappedRect* pLockedRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)@this->LpVtbl[12])(@this, pLockedRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapDesktopSurface(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref MappedRect pLockedRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MappedRect* pLockedRectPtr = &pLockedRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)@this->LpVtbl[12])(@this, pLockedRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnMapDesktopSurface(this ComPtr<IDXGIOutputDuplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<Guid> riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesc(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<OutduplDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref ComPtr<TI0> ppDesktopResource) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, pFrameInfo, (IDXGIResource**) ppDesktopResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, Span<OutduplFrameInfo> pFrameInfo, IDXGIResource** ppDesktopResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo.GetPinnableReference(), ppDesktopResource);
    }

    /// <summary>To be documented.</summary>
    public static int AcquireNextFrame<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref ComPtr<TI0> ppDesktopResource) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo, (IDXGIResource**) ppDesktopResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint TimeoutInMilliseconds, Span<OutduplFrameInfo> pFrameInfo, ref IDXGIResource* ppDesktopResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo.GetPinnableReference(), ref ppDesktopResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, Span<uint> pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameDirtyRects(DirtyRectsBufferSize, pDirtyRectsBuffer, ref pDirtyRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, Span<Silk.NET.Maths.Box2D<int>> pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameDirtyRects(DirtyRectsBufferSize, ref pDirtyRectsBuffer.GetPinnableReference(), pDirtyRectsBufferSizeRequired);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, Span<Silk.NET.Maths.Box2D<int>> pDirtyRectsBuffer, Span<uint> pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameDirtyRects(DirtyRectsBufferSize, ref pDirtyRectsBuffer.GetPinnableReference(), ref pDirtyRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, Span<uint> pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameMoveRects(MoveRectsBufferSize, pMoveRectBuffer, ref pMoveRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, Span<OutduplMoveRect> pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameMoveRects(MoveRectsBufferSize, ref pMoveRectBuffer.GetPinnableReference(), pMoveRectsBufferSizeRequired);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameMoveRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint MoveRectsBufferSize, Span<OutduplMoveRect> pMoveRectBuffer, Span<uint> pMoveRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameMoveRects(MoveRectsBufferSize, ref pMoveRectBuffer.GetPinnableReference(), ref pMoveRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired.GetPinnableReference(), pPointerShapeInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired.GetPinnableReference(), ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), pPointerShapeBufferSizeRequired, pPointerShapeInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), pPointerShapeBufferSizeRequired, ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), ref pPointerShapeBufferSizeRequired.GetPinnableReference(), pPointerShapeInfo);
    }

    /// <summary>To be documented.</summary>
    public static int GetFramePointerShape<T0>(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), ref pPointerShapeBufferSizeRequired.GetPinnableReference(), ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapDesktopSurface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Span<MappedRect> pLockedRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapDesktopSurface(ref pLockedRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetParent<TI0>(this ComPtr<IDXGIOutputDuplication> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
