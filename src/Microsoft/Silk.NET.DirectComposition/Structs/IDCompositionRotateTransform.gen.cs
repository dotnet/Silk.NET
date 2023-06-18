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

namespace Silk.NET.DirectComposition
{
    [Guid("641ed83c-ae96-46c5-90dc-32774cc5c6d5")]
    [NativeName("Name", "IDCompositionRotateTransform")]
    public unsafe partial struct IDCompositionRotateTransform : IComVtbl<IDCompositionRotateTransform>, IComVtbl<IDCompositionTransform>, IComVtbl<IDCompositionTransform3D>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("641ed83c-ae96-46c5-90dc-32774cc5c6d5");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionTransform(IDCompositionRotateTransform val)
            => Unsafe.As<IDCompositionRotateTransform, IDCompositionTransform>(ref val);

        public static implicit operator IDCompositionTransform3D(IDCompositionRotateTransform val)
            => Unsafe.As<IDCompositionRotateTransform, IDCompositionTransform3D>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionRotateTransform val)
            => Unsafe.As<IDCompositionRotateTransform, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionRotateTransform val)
            => Unsafe.As<IDCompositionRotateTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionRotateTransform
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
            var @this = (IDCompositionRotateTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionRotateTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionRotateTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAngle(float angle)
        {
            var @this = (IDCompositionRotateTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, float, int>)@this->LpVtbl[4])(@this, angle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterX(float centerX)
        {
            var @this = (IDCompositionRotateTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, float, int>)@this->LpVtbl[6])(@this, centerX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterY(float centerY)
        {
            var @this = (IDCompositionRotateTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, float, int>)@this->LpVtbl[8])(@this, centerY);
            return ret;
        }

    }
}
