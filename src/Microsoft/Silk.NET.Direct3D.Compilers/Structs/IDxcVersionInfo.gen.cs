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
    [NativeName("Name", "IDxcVersionInfo")]
    public unsafe partial struct IDxcVersionInfo
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcVersionInfo val)
            => Unsafe.As<IDxcVersionInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcVersionInfo
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
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcVersionInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcVersionInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcVersionInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcVersionInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcVersionInfo*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcVersionInfo*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVersion(uint* pMajor, uint* pMinor)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcVersionInfo*, uint*, uint*, int>)LpVtbl[3])(@this, pMajor, pMinor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVersion(uint* pMajor, ref uint pMinor)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (uint* pMinorPtr = &pMinor)
                {
                    ret = ((delegate* cdecl<IDxcVersionInfo*, uint*, uint*, int>)LpVtbl[3])(@this, pMajor, pMinorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVersion(ref uint pMajor, uint* pMinor)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (uint* pMajorPtr = &pMajor)
                {
                    ret = ((delegate* cdecl<IDxcVersionInfo*, uint*, uint*, int>)LpVtbl[3])(@this, pMajorPtr, pMinor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVersion(ref uint pMajor, ref uint pMinor)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (uint* pMajorPtr = &pMajor)
                {
                    fixed (uint* pMinorPtr = &pMinor)
                    {
                        ret = ((delegate* cdecl<IDxcVersionInfo*, uint*, uint*, int>)LpVtbl[3])(@this, pMajorPtr, pMinorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFlags(uint* pFlags)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcVersionInfo*, uint*, int>)LpVtbl[4])(@this, pFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFlags(ref uint pFlags)
        {
            fixed (IDxcVersionInfo* @this = &this)
            {
                int ret = default;
                fixed (uint* pFlagsPtr = &pFlags)
                {
                    ret = ((delegate* cdecl<IDxcVersionInfo*, uint*, int>)LpVtbl[4])(@this, pFlagsPtr);
                }
                return ret;
            }
        }

    }
}
