// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Direct3D9
{
    [Guid("dd13c59c-36fa-4098-a8fb-c7ed39dc8546")]
    [NativeName("Name", "IDirect3DVertexDeclaration9")]
    public unsafe partial struct IDirect3DVertexDeclaration9
    {
        public static readonly Guid Guid = new("dd13c59c-36fa-4098-a8fb-c7ed39dc8546");

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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeclaration(Vertexelement9* pElement, uint* pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElement, pNumElements);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElement, pNumElements);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElement, pNumElements);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeclaration(Vertexelement9* pElement, ref uint pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumElementsPtr = &pNumElements)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElement, pNumElementsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElement, pNumElementsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElement, pNumElementsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeclaration(ref Vertexelement9 pElement, uint* pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pElementPtr = &pElement)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElementPtr, pNumElements);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElementPtr, pNumElements);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElementPtr, pNumElements);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeclaration(ref Vertexelement9 pElement, ref uint pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pElementPtr = &pElement)
            {
                fixed (uint* pNumElementsPtr = &pNumElements)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElementPtr, pNumElementsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElementPtr, pNumElementsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)LpVtbl[4])(@this, pElementPtr, pNumElementsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
