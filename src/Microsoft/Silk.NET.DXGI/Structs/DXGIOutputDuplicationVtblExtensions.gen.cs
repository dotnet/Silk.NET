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
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
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
    public static unsafe int GetParent(this ComPtr<IDXGIOutputDuplication> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesc(this ComPtr<IDXGIOutputDuplication> thisVtbl, OutduplDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDesc);
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
    public static unsafe int GetFrameDirtyRects(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
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
    public static unsafe int GetFramePointerShape(this ComPtr<IDXGIOutputDuplication> thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
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

}
