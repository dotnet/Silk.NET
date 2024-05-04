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
    [Guid("e913c351-783d-48ca-a1d1-4f306284ad56")]
    [NativeName("Name", "ID3D12ShaderReflectionType")]
    public unsafe partial struct ID3D12ShaderReflectionType : IComVtbl<ID3D12ShaderReflectionType>
    {
        public static readonly Guid Guid = new("e913c351-783d-48ca-a1d1-4f306284ad56");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3D12ShaderReflectionType
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
        public readonly unsafe int GetDesc(ShaderTypeDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ShaderTypeDesc pDesc)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderTypeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)@this->LpVtbl[1])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetMemberTypeName(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, byte*>)@this->LpVtbl[3])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)]
        public readonly string GetMemberTypeNameS(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, string>)@this->LpVtbl[3])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsEqual(ID3D12ShaderReflectionType* pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsEqual(ref ID3D12ShaderReflectionType pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetSubType()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetBaseClass()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumInterfaces()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)@this->LpVtbl[8])(@this, uIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsOfType(ID3D12ShaderReflectionType* pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsOfType(ref ID3D12ShaderReflectionType pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ImplementsInterface(ID3D12ShaderReflectionType* pBase)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBase);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ImplementsInterface(ref ID3D12ShaderReflectionType pBase)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ShaderReflectionType* pBasePtr = &pBase)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsEqual<TI0>(ComPtr<TI0> pType) where TI0 : unmanaged, IComVtbl<ID3D12ShaderReflectionType>, IComVtbl<TI0>
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsEqual((ID3D12ShaderReflectionType*) pType.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsOfType<TI0>(ComPtr<TI0> pType) where TI0 : unmanaged, IComVtbl<ID3D12ShaderReflectionType>, IComVtbl<TI0>
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsOfType((ID3D12ShaderReflectionType*) pType.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int ImplementsInterface<TI0>(ComPtr<TI0> pBase) where TI0 : unmanaged, IComVtbl<ID3D12ShaderReflectionType>, IComVtbl<TI0>
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ImplementsInterface((ID3D12ShaderReflectionType*) pBase.Handle);
        }

    }
}
