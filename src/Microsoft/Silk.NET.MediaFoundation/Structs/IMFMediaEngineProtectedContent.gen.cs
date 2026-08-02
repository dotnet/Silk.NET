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

namespace Silk.NET.MediaFoundation
{
    [Guid("9f8021e8-9c8c-487e-bb5c-79aa4779938c")]
    [NativeName("Name", "IMFMediaEngineProtectedContent")]
    public unsafe partial struct IMFMediaEngineProtectedContent : IComVtbl<IMFMediaEngineProtectedContent>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9f8021e8-9c8c-487e-bb5c-79aa4779938c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineProtectedContent val)
            => Unsafe.As<IMFMediaEngineProtectedContent, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineProtectedContent
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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareResources(Silk.NET.Core.Native.IUnknown* pUnkDeviceContext)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkDeviceContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ShareResources(ref Silk.NET.Core.Native.IUnknown pUnkDeviceContext)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkDeviceContextPtr = &pUnkDeviceContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkDeviceContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRequiredProtections(uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint*, int>)@this->LpVtbl[4])(@this, pFrameProtectionFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRequiredProtections(ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, uint*, int>)@this->LpVtbl[4])(@this, pFrameProtectionFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOPMWindow(nint hwnd)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, nint, int>)@this->LpVtbl[5])(@this, hwnd);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFrameProtectionFlagsPtr = &pFrameProtectionFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClr, pFrameProtectionFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr, pFrameProtectionFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr, pFrameProtectionFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr, pFrameProtectionFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, uint*, int>)@this->LpVtbl[6])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int SetContentProtectionManager(IMFContentProtectionManager* pCPM)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int>)@this->LpVtbl[7])(@this, pCPM);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetContentProtectionManager(ref IMFContentProtectionManager pCPM)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFContentProtectionManager* pCPMPtr = &pCPM)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int>)@this->LpVtbl[7])(@this, pCPMPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetApplicationCertificate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbBlob, uint cbBlob)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbBlob, cbBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationCertificate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbBlob, uint cbBlob)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBlobPtr = &pbBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbBlobPtr, cbBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationCertificate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBlob, uint cbBlob)
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBlobPtr = (byte*) SilkMarshal.StringToPtr(pbBlob, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineProtectedContent*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbBlobPtr, cbBlob);
            SilkMarshal.Free((nint)pbBlobPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ShareResources<TI0>(ComPtr<TI0> pUnkDeviceContext) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ShareResources((Silk.NET.Core.Native.IUnknown*) pUnkDeviceContext.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, uint* pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr, pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr, ref uint pFrameProtectionFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr, ref pFrameProtectionFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineProtectedContent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
