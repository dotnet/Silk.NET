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

namespace Silk.NET.Direct3D11
{
    [Guid("1fbad429-66ab-41cc-9617-667ac10e4459")]
    [NativeName("Name", "ID3D11ShaderTraceFactory")]
    public unsafe partial struct ID3D11ShaderTraceFactory
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ShaderTraceFactory val)
            => Unsafe.As<ID3D11ShaderTraceFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ShaderTraceFactory
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
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(Silk.NET.Core.Native.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTrace);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(Silk.NET.Core.Native.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTracePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(Silk.NET.Core.Native.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTrace);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(Silk.NET.Core.Native.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
            {
                fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTracePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTrace);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
            {
                fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTracePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
            {
                fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDescPtr, ppShaderTrace);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateShaderTrace(ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
        {
            var @this = (ID3D11ShaderTraceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
            {
                fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
                {
                    fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)LpVtbl[3])(@this, pShaderPtr, pTraceDescPtr, ppShaderTracePtr);
                    }
                }
            }
            return ret;
        }

    }
}
