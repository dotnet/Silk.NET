// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGIDecodeSwapChain")]
    public unsafe partial struct IDXGIDecodeSwapChain
    {
        public IDXGIDecodeSwapChain
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
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint, uint, uint, int>)LpVtbl[3])(@this, BufferToPresent, SyncInterval, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetSourceRect(Silk.NET.Core.Runtime.Windows.TagRect* pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[4])(@this, pRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetSourceRect(ref Silk.NET.Core.Runtime.Windows.TagRect pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[4])(@this, pRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetTargetRect(Silk.NET.Core.Runtime.Windows.TagRect* pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[5])(@this, pRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetTargetRect(ref Silk.NET.Core.Runtime.Windows.TagRect pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[5])(@this, pRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetDestSize(uint Width, uint Height)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint, uint, int>)LpVtbl[6])(@this, Width, Height);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceRect(Silk.NET.Core.Runtime.Windows.TagRect* pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[7])(@this, pRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetSourceRect(ref Silk.NET.Core.Runtime.Windows.TagRect pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[7])(@this, pRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTargetRect(Silk.NET.Core.Runtime.Windows.TagRect* pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[8])(@this, pRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetTargetRect(ref Silk.NET.Core.Runtime.Windows.TagRect pRect)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, Silk.NET.Core.Runtime.Windows.TagRect*, int>)LpVtbl[8])(@this, pRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDestSize(uint* pWidth, uint* pHeight)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidth, pHeight);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDestSize(uint* pWidth, ref uint pHeight)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (uint* pHeightPtr = &pHeight)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidth, pHeightPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDestSize(ref uint pWidth, uint* pHeight)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (uint* pWidthPtr = &pWidth)
                {
                    ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidthPtr, pHeight);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDestSize(ref uint pWidth, ref uint pHeight)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                fixed (uint* pWidthPtr = &pWidth)
                {
                    fixed (uint* pHeightPtr = &pHeight)
                    {
                        ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, uint*, uint*, int>)LpVtbl[9])(@this, pWidthPtr, pHeightPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetColorSpace(MULTIPLANEOVERLAYYCbCrFLAGS ColorSpace)
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS, int>)LpVtbl[10])(@this, ColorSpace);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public MULTIPLANEOVERLAYYCbCrFLAGS GetColorSpace()
        {
            fixed (IDXGIDecodeSwapChain* @this = &this)
            {
                MULTIPLANEOVERLAYYCbCrFLAGS ret = default;
                ret = ((delegate* cdecl<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS>)LpVtbl[11])(@this);
                return ret;
            }
        }

    }
}
