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
    [NativeName("Name", "IDxcBlobEncoding")]
    public unsafe partial struct IDxcBlobEncoding
    {
        public static implicit operator IDxcBlob(IDxcBlobEncoding val)
            => Unsafe.As<IDxcBlobEncoding, IDxcBlob>(ref val);

        public readonly ref IDxcBlob AsBlob()
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                return ref *(IDxcBlob*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcBlobEncoding val)
            => Unsafe.As<IDxcBlobEncoding, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcBlobEncoding
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
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcBlobEncoding*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcBlobEncoding*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcBlobEncoding*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcBlobEncoding*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcBlobEncoding*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcBlobEncoding*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetBufferPointer()
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                void* ret = default;
                ret = ((delegate* cdecl<IDxcBlobEncoding*, void*>)LpVtbl[3])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetBufferSize()
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcBlobEncoding*, uint>)LpVtbl[4])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEncoding(int* pKnown, uint* pCodePage)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcBlobEncoding*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEncoding(int* pKnown, ref uint pCodePage)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                fixed (uint* pCodePagePtr = &pCodePage)
                {
                    ret = ((delegate* cdecl<IDxcBlobEncoding*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEncoding(ref int pKnown, uint* pCodePage)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                fixed (int* pKnownPtr = &pKnown)
                {
                    ret = ((delegate* cdecl<IDxcBlobEncoding*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetEncoding(ref int pKnown, ref uint pCodePage)
        {
            fixed (IDxcBlobEncoding* @this = &this)
            {
                int ret = default;
                fixed (int* pKnownPtr = &pKnown)
                {
                    fixed (uint* pCodePagePtr = &pCodePage)
                    {
                        ret = ((delegate* cdecl<IDxcBlobEncoding*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
                    }
                }
                return ret;
            }
        }

    }
}
