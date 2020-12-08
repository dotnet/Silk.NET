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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c")]
    [NativeName("Name", "IDxcContainerReflection")]
    public unsafe partial struct IDxcContainerReflection
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerReflection val)
            => Unsafe.As<IDxcContainerReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcContainerReflection
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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pContainer)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pContainer)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pContainerPtr = &pContainer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartCount(uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPartCount(ref uint pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartKind(uint idx, uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPartKind(uint idx, ref uint pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartContent(uint idx, IDxcBlob** ppResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartContent(uint idx, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFirstPartKind(uint kind, uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFirstPartKind(uint kind, ref uint pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, Guid* iid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, Guid* iid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, ref Guid iid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, ref Guid iid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

    }
}
