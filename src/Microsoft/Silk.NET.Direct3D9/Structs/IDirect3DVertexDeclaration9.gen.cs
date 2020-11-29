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

namespace Silk.NET.Direct3D9
{
    [Guid("dd13c59c-36fa-4098-a8fb-c7ed39dc8546")]
    [NativeName("Name", "IDirect3DVertexDeclaration9")]
    public unsafe partial struct IDirect3DVertexDeclaration9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVertexDeclaration9 val)
            => Unsafe.As<IDirect3DVertexDeclaration9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DVertexDeclaration9
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
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDeclaration(Vertexelement9* arg0, uint* pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, arg0, pNumElements);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDeclaration(Vertexelement9* arg0, ref uint pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pNumElementsPtr = &pNumElements)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, arg0, pNumElementsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDeclaration(ref Vertexelement9 arg0, uint* pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Vertexelement9* arg0Ptr = &arg0)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pNumElements);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDeclaration(ref Vertexelement9 arg0, ref uint pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Vertexelement9* arg0Ptr = &arg0)
            {
                fixed (uint* pNumElementsPtr = &pNumElements)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pNumElementsPtr);
                }
            }
            return ret;
        }

    }
}
