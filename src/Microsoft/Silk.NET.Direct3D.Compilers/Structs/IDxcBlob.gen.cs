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

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "IDxcBlob")]
    public unsafe partial struct IDxcBlob
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcBlob val)
            => Unsafe.As<IDxcBlob, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcBlob* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcBlob
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
            fixed (IDxcBlob* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcBlob*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcBlob* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcBlob*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcBlob* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcBlob*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcBlob* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcBlob*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcBlob* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcBlob*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcBlob* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcBlob*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetBufferPointer()
        {
            fixed (IDxcBlob* @this = &this)
            {
                void* ret = default;
                ret = ((delegate* cdecl<IDxcBlob*, void*>)LpVtbl[3])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetBufferSize()
        {
            fixed (IDxcBlob* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcBlob*, uint>)LpVtbl[4])(@this);
                return ret;
            }
        }

    }
}
