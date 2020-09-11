// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12LibraryReflection")]
    public unsafe partial struct ID3D12LibraryReflection
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12LibraryReflection val)
            => Unsafe.As<ID3D12LibraryReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12LibraryReflection
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12LibraryReflection*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12LibraryReflection*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(LibraryDesc* pDesc)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref LibraryDesc pDesc)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                int ret = default;
                fixed (LibraryDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12FunctionReflection* GetFunctionByIndex(int FunctionIndex)
        {
            fixed (ID3D12LibraryReflection* @this = &this)
            {
                ID3D12FunctionReflection* ret = default;
                ret = ((delegate* cdecl<ID3D12LibraryReflection*, int, ID3D12FunctionReflection*>)LpVtbl[4])(@this, FunctionIndex);
                return ret;
            }
        }

    }
}
