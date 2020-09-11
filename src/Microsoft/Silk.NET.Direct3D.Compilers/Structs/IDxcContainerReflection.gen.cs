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
    [NativeName("Name", "IDxcContainerReflection")]
    public unsafe partial struct IDxcContainerReflection
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerReflection val)
            => Unsafe.As<IDxcContainerReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcContainerReflection
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
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Load(IDxcBlob* pContainer)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Load(ref IDxcBlob pContainer)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pContainerPtr = &pContainer)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainerPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartCount(uint* pResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPartCount(ref uint pResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (uint* pResultPtr = &pResult)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartKind(uint idx, uint* pResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPartKind(uint idx, ref uint pResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (uint* pResultPtr = &pResult)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartContent(uint idx, IDxcBlob** ppResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartContent(uint idx, ref IDxcBlob* ppResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindFirstPartKind(uint kind, uint* pResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int FindFirstPartKind(uint kind, ref uint pResult)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (uint* pResultPtr = &pResult)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartReflection(uint idx, Guid* iid, void** ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartReflection(uint idx, Guid* iid, ref void* ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartReflection(uint idx, ref Guid iid, void** ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* iidPtr = &iid)
                {
                    ret = ((delegate* cdecl<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPartReflection(uint idx, ref Guid iid, ref void* ppvObject)
        {
            fixed (IDxcContainerReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

    }
}
