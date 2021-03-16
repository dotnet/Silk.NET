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

namespace Silk.NET.DXGI
{
    [Guid("2633066b-4514-4c7a-8fd8-12ea98059d18")]
    [NativeName("Name", "IDXGIDecodeSwapChain")]
    public unsafe partial struct IDXGIDecodeSwapChain
    {
        public static readonly Guid Guid = new("2633066b-4514-4c7a-8fd8-12ea98059d18");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDecodeSwapChain val)
            => Unsafe.As<IDXGIDecodeSwapChain, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIDecodeSwapChain
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
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, uint, uint, uint, int>)LpVtbl[3])(@this, BufferToPresent, SyncInterval, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceRect(Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[4])(@this, pRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceRect(ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[4])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTargetRect(Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, pRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTargetRect(ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDestSize(uint Width, uint Height)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, uint, uint, int>)LpVtbl[6])(@this, Width, Height);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceRect(Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[7])(@this, pRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceRect(ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[7])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetRect(Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[8])(@this, pRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTargetRect(ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[8])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestSize(uint* pWidth, uint* pHeight)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidth, pHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestSize(uint* pWidth, ref uint pHeight)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pHeightPtr = &pHeight)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidth, pHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestSize(ref uint pWidth, uint* pHeight)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWidthPtr = &pWidth)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidthPtr, pHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDestSize(ref uint pWidth, ref uint pHeight)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWidthPtr = &pWidth)
            {
                fixed (uint* pHeightPtr = &pHeight)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidthPtr, pHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColorSpace(MULTIPLANEOVERLAYYCbCrFLAGS ColorSpace)
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS, int>)LpVtbl[10])(@this, ColorSpace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly MULTIPLANEOVERLAYYCbCrFLAGS GetColorSpace()
        {
            var @this = (IDXGIDecodeSwapChain*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            MULTIPLANEOVERLAYYCbCrFLAGS ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS>)LpVtbl[11])(@this);
            return ret;
        }

    }
}
