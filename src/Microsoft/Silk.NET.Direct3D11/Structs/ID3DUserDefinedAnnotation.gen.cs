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

namespace Silk.NET.Direct3D11
{
    [Guid("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab")]
    [NativeName("Name", "ID3DUserDefinedAnnotation")]
    public unsafe partial struct ID3DUserDefinedAnnotation : IComVtbl<ID3DUserDefinedAnnotation>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DUserDefinedAnnotation val)
            => Unsafe.As<ID3DUserDefinedAnnotation, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DUserDefinedAnnotation
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
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)@this->LpVtbl[3])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndEvent()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)@this->LpVtbl[5])(@this, Name);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetStatus()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Silk.NET.Core.Bool32>)@this->LpVtbl[6])(@this);
            return ret;
        }

    }
}
