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

namespace Silk.NET.Direct2D
{
    [Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838")]
    [NativeName("Name", "ID2D1GdiInteropRenderTarget")]
    public unsafe partial struct ID2D1GdiInteropRenderTarget : IComVtbl<ID2D1GdiInteropRenderTarget>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e0db51c3-6f77-4bae-b3d5-e47509b35838");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1GdiInteropRenderTarget val)
            => Unsafe.As<ID2D1GdiInteropRenderTarget, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1GdiInteropRenderTarget
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
            var @this = (ID2D1GdiInteropRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1GdiInteropRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1GdiInteropRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDC(DCInitializeMode mode, nint* hdc)
        {
            var @this = (ID2D1GdiInteropRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, DCInitializeMode, nint*, int>)@this->LpVtbl[3])(@this, mode, hdc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseDC([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* update)
        {
            var @this = (ID2D1GdiInteropRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[4])(@this, update);
            return ret;
        }

    }
}
