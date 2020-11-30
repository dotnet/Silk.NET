// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [Guid("8e349d19-54db-4a56-9dc9-119d87bdb804")]
    [NativeName("Name", "ID3D12LibraryReflection")]
    public unsafe partial struct ID3D12LibraryReflection
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12LibraryReflection val)
            => Unsafe.As<ID3D12LibraryReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12LibraryReflection
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDesc(LibraryDesc* pDesc)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDesc(ref LibraryDesc pDesc)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (LibraryDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D12FunctionReflection* GetFunctionByIndex(int FunctionIndex)
        {
            var @this = (ID3D12LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12FunctionReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LibraryReflection*, int, ID3D12FunctionReflection*>)LpVtbl[4])(@this, FunctionIndex);
            return ret;
        }

    }
}
