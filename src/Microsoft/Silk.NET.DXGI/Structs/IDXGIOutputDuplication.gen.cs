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
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
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
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesc(OutduplDesc* pDesc)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)@this->LpVtbl[7])(@this, pDesc);
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
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Maths.Box2D<int>* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Box2D<int>*, uint*, int>)@this->LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
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
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)@this->LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
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

    }
}
