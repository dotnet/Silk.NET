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

namespace Silk.NET.DXGI
{
    [Guid("191cfac3-a341-470d-b26e-a864f428319c")]
    [NativeName("Name", "IDXGIOutputDuplication")]
    public unsafe partial struct IDXGIOutputDuplication : IComVtbl<IDXGIOutputDuplication>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("191cfac3-a341-470d-b26e-a864f428319c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIOutputDuplication val)
            => Unsafe.As<IDXGIOutputDuplication, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutputDuplication val)
            => Unsafe.As<IDXGIOutputDuplication, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIOutputDuplication
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
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe void GetDesc(OutduplDesc* pDesc)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesc(ref OutduplDesc pDesc)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (OutduplDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDescPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref IDXGIResource* ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)@this->LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref IDXGIResource* ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref Silk.NET.Maths.Box2D<int> pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref Silk.NET.Maths.Box2D<int> pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)@this->LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameMoveRects(uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int MapDesktopSurface(MappedRect* pLockedRect)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)@this->LpVtbl[12])(@this, pLockedRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapDesktopSurface(ref MappedRect pLockedRect)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MappedRect* pLockedRectPtr = &pLockedRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)@this->LpVtbl[12])(@this, pLockedRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnMapDesktopSurface()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseFrame()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame<TI0>(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref ComPtr<TI0> ppDesktopResource) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AcquireNextFrame(TimeoutInMilliseconds, pFrameInfo, (IDXGIResource**) ppDesktopResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AcquireNextFrame<TI0>(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref ComPtr<TI0> ppDesktopResource) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AcquireNextFrame(TimeoutInMilliseconds, ref pFrameInfo, (IDXGIResource**) ppDesktopResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
