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

namespace Silk.NET.Direct3D12
{
    [Guid("ec25f42d-7006-4f2b-b33e-02cc3375733f")]
    [NativeName("Name", "ID3D12FunctionParameterReflection")]
    public unsafe partial struct ID3D12FunctionParameterReflection : IComVtbl<ID3D12FunctionParameterReflection>
    {
        public static readonly Guid Guid = new("ec25f42d-7006-4f2b-b33e-02cc3375733f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3D12FunctionParameterReflection
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
        public readonly unsafe int GetDesc(ParameterDesc* pDesc)
        {
            var @this = (ID3D12FunctionParameterReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionParameterReflection*, ParameterDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ParameterDesc pDesc)
        {
            var @this = (ID3D12FunctionParameterReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ParameterDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionParameterReflection*, ParameterDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

    }
}
