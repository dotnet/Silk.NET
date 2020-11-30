// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("091f7a26-1c1f-4948-904b-e6e3a8a771d5")]
    [NativeName("Name", "IDxcAssembler")]
    public unsafe partial struct IDxcAssembler
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcAssembler val)
            => Unsafe.As<IDxcAssembler, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcAssembler
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
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AssembleToContainer(IDxcBlob* pShader, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AssembleToContainer(IDxcBlob* pShader, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AssembleToContainer(ref IDxcBlob pShader, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, ppResult);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AssembleToContainer(ref IDxcBlob pShader, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcAssembler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, ppResultPtr);
                }
            }
            return ret;
        }

    }
}
