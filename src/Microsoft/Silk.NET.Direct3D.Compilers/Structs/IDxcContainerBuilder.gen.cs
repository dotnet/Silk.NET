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
    [NativeName("Name", "IDxcContainerBuilder")]
    public unsafe partial struct IDxcContainerBuilder
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerBuilder val)
            => Unsafe.As<IDxcContainerBuilder, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcContainerBuilder
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
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Load(IDxcBlob* pDxilContainerHeader)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Load(ref IDxcBlob pDxilContainerHeader)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pDxilContainerHeaderPtr = &pDxilContainerHeader)
                {
                    ret = ((delegate* cdecl<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddPart(uint fourCC, IDxcBlob* pSource)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSource);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddPart(uint fourCC, ref IDxcBlob pSource)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pSourcePtr = &pSource)
                {
                    ret = ((delegate* cdecl<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSourcePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RemovePart(uint fourCC)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, uint, int>)LpVtbl[5])(@this, fourCC);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SerializeContainer(IDxcOperationResult** ppResult)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SerializeContainer(ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcContainerBuilder* @this = &this)
            {
                int ret = default;
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResultPtr);
                }
                return ret;
            }
        }

    }
}
