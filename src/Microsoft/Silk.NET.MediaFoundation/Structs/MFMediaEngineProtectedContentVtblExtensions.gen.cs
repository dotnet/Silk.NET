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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFMediaEngineProtectedContentVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareResources(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkDeviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkDeviceContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ShareResources(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkDeviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkDeviceContextPtr = &pUnkDeviceContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkDeviceContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequiredProtections(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint*, int>)@this->LpVtbl[4])(@this, pFrameProtectionFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRequiredProtections(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint*, int>)@this->LpVtbl[4])(@this, pFrameProtectionFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOPMWindow(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, nint hwnd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, nint, int>)@this->LpVtbl[5])(@this, hwnd);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClr, pFrameProtectionFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr, pFrameProtectionFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
        {
            fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr, pFrameProtectionFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr, pFrameProtectionFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr, pFrameProtectionFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDstPtr, pBorderClrPtr, pFrameProtectionFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDstPtr, pBorderClrPtr, pFrameProtectionFlagsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr, pFrameProtectionFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr, pFrameProtectionFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDst, pBorderClrPtr, pFrameProtectionFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDst, pBorderClrPtr, pFrameProtectionFlagsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClr, pFrameProtectionFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClr, pFrameProtectionFlagsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClrPtr, pFrameProtectionFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClrPtr, pFrameProtectionFlagsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr, pFrameProtectionFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDst, pBorderClrPtr, pFrameProtectionFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDst, pBorderClrPtr, pFrameProtectionFlagsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClr, pFrameProtectionFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClr, pFrameProtectionFlagsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClrPtr, pFrameProtectionFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClrPtr, pFrameProtectionFlagsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClr, pFrameProtectionFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClr, pFrameProtectionFlagsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClrPtr, pFrameProtectionFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClrPtr, pFrameProtectionFlagsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClr, pFrameProtectionFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClr, pFrameProtectionFlagsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClrPtr, pFrameProtectionFlags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                    {
                        fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClrPtr, pFrameProtectionFlagsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetContentProtectionManager(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, IMFContentProtectionManager* pCPM)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int>)@this->LpVtbl[7])(@this, pCPM);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetContentProtectionManager(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ref IMFContentProtectionManager pCPM)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFContentProtectionManager* pCPMPtr = &pCPM)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int>)@this->LpVtbl[7])(@this, pCPMPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationCertificate(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbBlob, uint cbBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbBlob, cbBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationCertificate(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbBlob, uint cbBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBlobPtr = &pbBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbBlobPtr, cbBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationCertificate(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBlob, uint cbBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBlobPtr = (byte*) SilkMarshal.StringToPtr(pbBlob, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbBlobPtr, cbBlob);
        SilkMarshal.Free((nint)pbBlobPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int ShareResources<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pUnkDeviceContext) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ShareResources((Silk.NET.Core.Native.IUnknown*) pUnkDeviceContext.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ShareResources(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkDeviceContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ShareResources(ref pUnkDeviceContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRequiredProtections(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRequiredProtections(ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, pDst, pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, pDst, in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, pDst, in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr, ref pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr, pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr, ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, uint* pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), pFrameProtectionFlags);
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr, Span<uint> pFrameProtectionFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference(), ref pFrameProtectionFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetContentProtectionManager(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, Span<IMFContentProtectionManager> pCPM)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetContentProtectionManager(ref pCPM.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationCertificate(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbBlob, uint cbBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetApplicationCertificate(in pbBlob.GetPinnableReference(), cbBlob);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineProtectedContent> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
