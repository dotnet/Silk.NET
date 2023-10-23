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
    [Guid("d8f5b23f-d429-4a91-b55a-d2f45fd75b18")]
    [NativeName("Name", "IDCompositionRotateTransform3D")]
    public unsafe partial struct IDCompositionRotateTransform3D : IComVtbl<IDCompositionRotateTransform3D>, IComVtbl<IDCompositionTransform3D>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d8f5b23f-d429-4a91-b55a-d2f45fd75b18");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionTransform3D(IDCompositionRotateTransform3D val)
            => Unsafe.As<IDCompositionRotateTransform3D, IDCompositionTransform3D>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionRotateTransform3D val)
            => Unsafe.As<IDCompositionRotateTransform3D, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionRotateTransform3D val)
            => Unsafe.As<IDCompositionRotateTransform3D, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionRotateTransform3D
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
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAngle(float angle)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[4])(@this, angle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAxisX(float axisX)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[6])(@this, axisX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAxisY(float axisY)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[8])(@this, axisY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAxisZ(float axisZ)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[10])(@this, axisZ);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterX(float centerX)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[12])(@this, centerX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterY(float centerY)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[14])(@this, centerY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCenterZ(float centerZ)
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform3D*, float, int>)@this->LpVtbl[16])(@this, centerZ);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionRotateTransform3D*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
