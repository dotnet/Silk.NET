// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
    [NativeName("Name", "IDxcContainerBuilder")]
    public unsafe partial struct IDxcContainerBuilder
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerBuilder val)
            => Unsafe.As<IDxcContainerBuilder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcContainerBuilder
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
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Load(IDxcBlob* pDxilContainerHeader)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Load(ref IDxcBlob pDxilContainerHeader)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pDxilContainerHeaderPtr = &pDxilContainerHeader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AddPart(uint fourCC, IDxcBlob* pSource)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSource);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddPart(uint fourCC, ref IDxcBlob pSource)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSourcePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int RemovePart(uint fourCC)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, int>)LpVtbl[5])(@this, fourCC);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SerializeContainer(IDxcOperationResult** ppResult)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SerializeContainer(ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResultPtr);
            }
            return ret;
        }

    }
}
