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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe void GetDesc<TThis>(this TThis thisVtbl, OutduplDesc* pDesc) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDesc);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesc<TThis>(this TThis thisVtbl, ref OutduplDesc pDesc) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        fixed (OutduplDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref IDXGIResource* ppDesktopResource) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, IDXGIResource** ppDesktopResource) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref IDXGIResource* ppDesktopResource) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Rectangle<int>* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Rectangle<int>* pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, ref Silk.NET.Maths.Rectangle<int> pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, ref Silk.NET.Maths.Rectangle<int> pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
        {
            fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequiredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
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
    public static unsafe int MapDesktopSurface<TThis>(this TThis thisVtbl, MappedRect* pLockedRect) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)@this->LpVtbl[12])(@this, pLockedRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapDesktopSurface<TThis>(this TThis thisVtbl, ref MappedRect pLockedRect) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (MappedRect* pLockedRectPtr = &pLockedRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)@this->LpVtbl[12])(@this, pLockedRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnMapDesktopSurface<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseFrame<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesc<TThis>(this TThis thisVtbl, Span<OutduplDesc> pDesc) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TI0, TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref ComPtr<TI0> ppDesktopResource) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, pFrameInfo, (IDXGIResource**) ppDesktopResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, Span<OutduplFrameInfo> pFrameInfo, IDXGIResource** ppDesktopResource) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo.GetPinnableReference(), ppDesktopResource);
    }

    /// <summary>To be documented.</summary>
    public static int AcquireNextFrame<TI0, TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref ComPtr<TI0> ppDesktopResource) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo, (IDXGIResource**) ppDesktopResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AcquireNextFrame<TThis>(this TThis thisVtbl, uint TimeoutInMilliseconds, Span<OutduplFrameInfo> pFrameInfo, ref IDXGIResource* ppDesktopResource) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo.GetPinnableReference(), ref ppDesktopResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, Silk.NET.Maths.Rectangle<int>* pDirtyRectsBuffer, Span<uint> pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameDirtyRects(DirtyRectsBufferSize, pDirtyRectsBuffer, ref pDirtyRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, Span<Silk.NET.Maths.Rectangle<int>> pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameDirtyRects(DirtyRectsBufferSize, ref pDirtyRectsBuffer.GetPinnableReference(), pDirtyRectsBufferSizeRequired);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameDirtyRects<TThis>(this TThis thisVtbl, uint DirtyRectsBufferSize, Span<Silk.NET.Maths.Rectangle<int>> pDirtyRectsBuffer, Span<uint> pDirtyRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameDirtyRects(DirtyRectsBufferSize, ref pDirtyRectsBuffer.GetPinnableReference(), ref pDirtyRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, Span<uint> pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameMoveRects(MoveRectsBufferSize, pMoveRectBuffer, ref pMoveRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, Span<OutduplMoveRect> pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameMoveRects(MoveRectsBufferSize, ref pMoveRectBuffer.GetPinnableReference(), pMoveRectsBufferSizeRequired);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameMoveRects<TThis>(this TThis thisVtbl, uint MoveRectsBufferSize, Span<OutduplMoveRect> pMoveRectBuffer, Span<uint> pMoveRectsBufferSizeRequired) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameMoveRects(MoveRectsBufferSize, ref pMoveRectBuffer.GetPinnableReference(), ref pMoveRectsBufferSizeRequired.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired.GetPinnableReference(), pPointerShapeInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, void* pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired.GetPinnableReference(), ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), pPointerShapeBufferSizeRequired, pPointerShapeInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), pPointerShapeBufferSizeRequired, ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), ref pPointerShapeBufferSizeRequired.GetPinnableReference(), pPointerShapeInfo);
    }

    /// <summary>To be documented.</summary>
    public static int GetFramePointerShape<T0, TThis>(this TThis thisVtbl, uint PointerShapeBufferSize, Span<T0> pPointerShapeBuffer, Span<uint> pPointerShapeBufferSizeRequired, Span<OutduplPointerShapeInfo> pPointerShapeInfo) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFramePointerShape(PointerShapeBufferSize, ref pPointerShapeBuffer.GetPinnableReference(), ref pPointerShapeBufferSizeRequired.GetPinnableReference(), ref pPointerShapeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapDesktopSurface<TThis>(this TThis thisVtbl, Span<MappedRect> pLockedRect) where TThis : IComVtbl<IDXGIOutputDuplication>
    {
        var @this = (IDXGIOutputDuplication*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MapDesktopSurface(ref pLockedRect.GetPinnableReference());
    }

}
