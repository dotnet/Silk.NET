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
    [Guid("16cdff07-c503-419c-83f2-0965c7af1fa6")]
    [NativeName("Name", "IDCompositionMatrixTransform")]
    public unsafe partial struct IDCompositionMatrixTransform : IComVtbl<IDCompositionMatrixTransform>, IComVtbl<IDCompositionTransform>, IComVtbl<IDCompositionTransform3D>, IComVtbl<IDCompositionEffect>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("16cdff07-c503-419c-83f2-0965c7af1fa6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionTransform(IDCompositionMatrixTransform val)
            => Unsafe.As<IDCompositionMatrixTransform, IDCompositionTransform>(ref val);

        public static implicit operator IDCompositionTransform3D(IDCompositionMatrixTransform val)
            => Unsafe.As<IDCompositionMatrixTransform, IDCompositionTransform3D>(ref val);

        public static implicit operator IDCompositionEffect(IDCompositionMatrixTransform val)
            => Unsafe.As<IDCompositionMatrixTransform, IDCompositionEffect>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionMatrixTransform val)
            => Unsafe.As<IDCompositionMatrixTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionMatrixTransform
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
            var @this = (IDCompositionMatrixTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionMatrixTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionMatrixTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMatrix(Silk.NET.Maths.Matrix3X2<float>* matrix)
        {
            var @this = (IDCompositionMatrixTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[3])(@this, matrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMatrixElement(int row, int column, float value)
        {
            var @this = (IDCompositionMatrixTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, int, int, float, int>)@this->LpVtbl[5])(@this, row, column, value);
            return ret;
        }

    }
}
