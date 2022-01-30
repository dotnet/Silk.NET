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
    [Guid("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb")]
    [NativeName("Name", "IDirect3DDevice9")]
    public unsafe partial struct IDirect3DDevice9
    {
        public static readonly Guid Guid = new("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDevice9 val)
            => Unsafe.As<IDirect3DDevice9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDevice9
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
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TestCooperativeLevel()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAvailableTextureMem()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EvictManagedResources()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDirect3D(IDirect3D9** ppD3D9)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDirect3D(ref IDirect3D9* ppD3D9)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3D9** ppD3D9Ptr = &ppD3D9)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9Ptr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9Ptr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9Ptr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceCaps(Caps9* pCaps)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCaps);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCaps);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceCaps(ref Caps9 pCaps)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Caps9* pCapsPtr = &pCaps)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCapsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCapsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayMode(uint iSwapChain, Displaymode* pMode)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pMode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pMode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pMode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayMode(uint iSwapChain, ref Displaymode pMode)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pModePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pModePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pModePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(DeviceCreationParameters* pParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParameters);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParameters);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParameters);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCreationParameters(ref DeviceCreationParameters pParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DeviceCreationParameters* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParametersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParametersPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParametersPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCursorProperties(uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pCursorBitmapPtr = &pCursorBitmap)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCursorPosition(int X, int Y, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDirect3DDevice9*, int, int, uint, void>)LpVtbl[11])(@this, X, Y, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int, uint, void>)LpVtbl[11])(@this, X, Y, Flags);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int, uint, void>)LpVtbl[11])(@this, X, Y, Flags);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly int ShowCursor(int bShow)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, int, int>)LpVtbl[12])(@this, bShow);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int>)LpVtbl[12])(@this, bShow);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int>)LpVtbl[12])(@this, bShow);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChain(uint iSwapChain, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumberOfSwapChains()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(PresentParameters* pPresentationParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParameters);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParameters);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParameters);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref PresentParameters pPresentationParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParametersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParametersPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParametersPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present(ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRasterStatus(uint iSwapChain, RasterStatus* pRasterStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatus);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatus);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatus);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRasterStatus(uint iSwapChain, ref RasterStatus pRasterStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDialogBoxMode(int bEnableDialogs)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, int, int>)LpVtbl[20])(@this, bEnableDialogs);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int>)LpVtbl[20])(@this, bEnableDialogs);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int>)LpVtbl[20])(@this, bEnableDialogs);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGammaRamp(uint iSwapChain, uint Flags, Gammaramp* pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGammaRamp(uint iSwapChain, uint Flags, ref Gammaramp pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Gammaramp* pRampPtr = &pRamp)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetGammaRamp(uint iSwapChain, Gammaramp* pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRamp);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRamp);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRamp);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetGammaRamp(uint iSwapChain, ref Gammaramp pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Gammaramp* pRampPtr = &pRamp)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRampPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRampPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRampPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
            {
                fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrontBufferData(uint iSwapChain, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill(IDirect3DSurface9* pSurface, Silk.NET.Maths.Rectangle<int>* pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurface, pRect, color);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurface, pRect, color);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurface, pRect, color);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill(IDirect3DSurface9* pSurface, ref Silk.NET.Maths.Rectangle<int> pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurface, pRectPtr, color);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurface, pRectPtr, color);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurface, pRectPtr, color);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ColorFill(ref IDirect3DSurface9 pSurface, Silk.NET.Maths.Rectangle<int>* pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRect, color);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRect, color);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRect, color);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ColorFill(ref IDirect3DSurface9 pSurface, ref Silk.NET.Maths.Rectangle<int> pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9* ppRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppRenderTargetPtr = &ppRenderTarget)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencil);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencil);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencil);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDepthStencilSurface(ref IDirect3DSurface9 pNewZStencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pNewZStencilPtr = &pNewZStencil)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencilPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencilPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencilPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDepthStencilSurface(ref IDirect3DSurface9* ppZStencilSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppZStencilSurfacePtr = &ppZStencilSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurfacePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginScene()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[41])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndScene()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clear(uint Count, Rect* pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Clear(uint Count, ref Rect pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Rect* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransform(Transformstatetype State, System.Numerics.Matrix4x4* pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[44])(@this, State, pMatrix);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[44])(@this, State, pMatrix);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[44])(@this, State, pMatrix);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransform(Transformstatetype State, ref System.Numerics.Matrix4x4 pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[44])(@this, State, pMatrixPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[44])(@this, State, pMatrixPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[44])(@this, State, pMatrixPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTransform(Transformstatetype State, System.Numerics.Matrix4x4* pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[45])(@this, State, pMatrix);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[45])(@this, State, pMatrix);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[45])(@this, State, pMatrix);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTransform(Transformstatetype State, ref System.Numerics.Matrix4x4 pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[45])(@this, State, pMatrixPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[45])(@this, State, pMatrixPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[45])(@this, State, pMatrixPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MultiplyTransform(Transformstatetype arg0, System.Numerics.Matrix4x4* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[46])(@this, arg0, arg1);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[46])(@this, arg0, arg1);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[46])(@this, arg0, arg1);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MultiplyTransform(Transformstatetype arg0, ref System.Numerics.Matrix4x4 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (System.Numerics.Matrix4x4* arg1Ptr = &arg1)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[46])(@this, arg0, arg1Ptr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[46])(@this, arg0, arg1Ptr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, System.Numerics.Matrix4x4*, int>)LpVtbl[46])(@this, arg0, arg1Ptr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetViewport(Viewport9* pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewport);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewport);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewport);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetViewport(ref Viewport9 pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Viewport9* pViewportPtr = &pViewport)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewportPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewportPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewportPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetViewport(Viewport9* pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewport);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewport);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewport);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetViewport(ref Viewport9 pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Viewport9* pViewportPtr = &pViewport)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewportPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewportPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewportPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMaterial(Material9* pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterial);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterial);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterial);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaterial(ref Material9 pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Material9* pMaterialPtr = &pMaterial)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterialPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterialPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterialPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaterial(Material9* pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterial);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterial);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterial);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaterial(ref Material9 pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Material9* pMaterialPtr = &pMaterial)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterialPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterialPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterialPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLight(uint Index, Light9* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLight(uint Index, ref Light9 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Light9* arg1Ptr = &arg1)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1Ptr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1Ptr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1Ptr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLight(uint Index, Light9* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLight(uint Index, ref Light9 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Light9* arg1Ptr = &arg1)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1Ptr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1Ptr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1Ptr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LightEnable(uint Index, int Enable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int, int>)LpVtbl[53])(@this, Index, Enable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int, int>)LpVtbl[53])(@this, Index, Enable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int, int>)LpVtbl[53])(@this, Index, Enable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLightEnable(uint Index, int* pEnable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLightEnable(uint Index, ref int pEnable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pEnablePtr = &pEnable)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnablePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnablePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnablePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClipPlane(uint Index, float* pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlane);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlane);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlane);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClipPlane(uint Index, ref float pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pPlanePtr = &pPlane)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlanePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlanePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlanePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClipPlane(uint Index, float* pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlane);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlane);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlane);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClipPlane(uint Index, ref float pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pPlanePtr = &pPlane)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlanePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlanePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlanePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderState(Renderstatetype State, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Renderstatetype, uint, int>)LpVtbl[57])(@this, State, Value);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Renderstatetype, uint, int>)LpVtbl[57])(@this, State, Value);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint, int>)LpVtbl[57])(@this, State, Value);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRenderState(Renderstatetype State, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRenderState(Renderstatetype State, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValuePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateBlock(Stateblocktype Type, IDirect3DStateBlock9** ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSB);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSB);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSB);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateBlock(Stateblocktype Type, ref IDirect3DStateBlock9* ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSBPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSBPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSBPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginStateBlock()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[60])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndStateBlock(IDirect3DStateBlock9** ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSB);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSB);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSB);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndStateBlock(ref IDirect3DStateBlock9* ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSBPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSBPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSBPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClipStatus(Clipstatus9* pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatus);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatus);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatus);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClipStatus(ref Clipstatus9 pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatusPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatusPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatusPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClipStatus(Clipstatus9* pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatus);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatus);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatus);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClipStatus(ref Clipstatus9 pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatusPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatusPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatusPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTexture(uint Stage, IDirect3DBaseTexture9** ppTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexture);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexture);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexture);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTexture(uint Stage, ref IDirect3DBaseTexture9* ppTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9** ppTexturePtr = &ppTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexturePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexturePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexturePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTexture(uint Stage, IDirect3DBaseTexture9* pTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexture);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexture);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexture);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTexture(uint Stage, ref IDirect3DBaseTexture9 pTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DBaseTexture9* pTexturePtr = &pTexture)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexturePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexturePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexturePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextureStageState(uint Stage, Texturestagestatetype Type, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextureStageState(uint Stage, Texturestagestatetype Type, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValuePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextureStageState(uint Stage, Texturestagestatetype Type, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Texturestagestatetype, uint, int>)LpVtbl[67])(@this, Stage, Type, Value);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Texturestagestatetype, uint, int>)LpVtbl[67])(@this, Stage, Type, Value);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint, int>)LpVtbl[67])(@this, Stage, Type, Value);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSamplerState(uint Sampler, Samplerstatetype Type, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSamplerState(uint Sampler, Samplerstatetype Type, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValuePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSamplerState(uint Sampler, Samplerstatetype Type, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Samplerstatetype, uint, int>)LpVtbl[69])(@this, Sampler, Type, Value);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Samplerstatetype, uint, int>)LpVtbl[69])(@this, Sampler, Type, Value);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint, int>)LpVtbl[69])(@this, Sampler, Type, Value);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateDevice(uint* pNumPasses)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPasses);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPasses);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPasses);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateDevice(ref uint pNumPasses)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumPassesPtr = &pNumPasses)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPassesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPassesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPassesPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPaletteEntries(uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntries);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntries);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntries);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPaletteEntries(uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPaletteEntries(uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntries);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntries);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntries);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPaletteEntries(uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentTexturePalette(uint PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int>)LpVtbl[73])(@this, PaletteNumber);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int>)LpVtbl[73])(@this, PaletteNumber);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)LpVtbl[73])(@this, PaletteNumber);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTexturePalette(uint* PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumber);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumber);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumber);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentTexturePalette(ref uint PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* PaletteNumberPtr = &PaletteNumber)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumberPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumberPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumberPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetScissorRect(Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[75])(@this, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[75])(@this, pRect);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[75])(@this, pRect);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetScissorRect(ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[75])(@this, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[75])(@this, pRectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[75])(@this, pRectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetScissorRect(Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[76])(@this, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[76])(@this, pRect);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[76])(@this, pRect);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetScissorRect(ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[76])(@this, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[76])(@this, pRectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[76])(@this, pRectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSoftwareVertexProcessing(int bSoftware)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, int, int>)LpVtbl[77])(@this, bSoftware);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int>)LpVtbl[77])(@this, bSoftware);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int>)LpVtbl[77])(@this, bSoftware);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSoftwareVertexProcessing()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[78])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNPatchMode(float nSegments)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, float, int>)LpVtbl[79])(@this, nSegments);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, float, int>)LpVtbl[79])(@this, nSegments);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, float, int>)LpVtbl[79])(@this, nSegments);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetNPatchMode()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, float>)LpVtbl[80])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawPrimitive(Primitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, uint, int>)LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, uint, int>)LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, int>)LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawIndexedPrimitive(Primitivetype arg0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, int, uint, uint, uint, uint, int>)LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, int, uint, uint, uint, uint, int>)LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, int, uint, uint, uint, uint, int>)LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawPrimitiveUP(Primitivetype PrimitiveType, uint PrimitiveCount, void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawPrimitiveUP<T0>(Primitivetype PrimitiveType, uint PrimitiveCount, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pIndexDataPtr = &pIndexData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawIndexedPrimitiveUP<T0, T1>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, ref T1 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pIndexDataPtr = &pIndexData)
            {
                fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
            {
                fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration(Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDecl);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDecl);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDecl);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration(Vertexelement9* pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration(ref Vertexelement9 pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexDeclaration(ref Vertexelement9 pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
            {
                fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDecl);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDecl);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDecl);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexDeclaration(ref IDirect3DVertexDeclaration9 pDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9* pDeclPtr = &pDecl)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDeclPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDeclPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDeclPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDecl);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDecl);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDecl);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexDeclaration(ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDeclPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDeclPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDeclPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFVF(uint FVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int>)LpVtbl[89])(@this, FVF);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int>)LpVtbl[89])(@this, FVF);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)LpVtbl[89])(@this, FVF);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFVF(uint* pFVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVF);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVF);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVF);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFVF(ref uint pFVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFVFPtr = &pFVF)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVFPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVFPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVFPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader(uint* pFunction, IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader(uint* pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader(ref uint pFunction, IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShader);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShader);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShader);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader(ref uint pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShader(IDirect3DVertexShader9* pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShader(ref IDirect3DVertexShader9 pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexShader9* pShaderPtr = &pShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShader(IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShader(ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9* pStreamDataPtr = &pStreamData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStridePtr = &pStride)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStridePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStridePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStridePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStride);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStride);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStride);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
            {
                fixed (uint* pStridePtr = &pStride)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStridePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStridePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStridePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStride);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStride);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStride);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pStridePtr = &pStride)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStridePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStridePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStridePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStride);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStride);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStride);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
                {
                    fixed (uint* pStridePtr = &pStride)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStridePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStridePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStridePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStreamSourceFreq(uint StreamNumber, uint Setting)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint, int>)LpVtbl[102])(@this, StreamNumber, Setting);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int>)LpVtbl[102])(@this, StreamNumber, Setting);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, int>)LpVtbl[102])(@this, StreamNumber, Setting);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, pSetting);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, pSetting);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, pSetting);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStreamSourceFreq(uint StreamNumber, ref uint pSetting)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSettingPtr = &pSetting)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, pSettingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, pSettingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, pSettingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetIndices(IDirect3DIndexBuffer9* pIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIndices(ref IDirect3DIndexBuffer9 pIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9* pIndexDataPtr = &pIndexData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIndices(IDirect3DIndexBuffer9** ppIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIndices(ref IDirect3DIndexBuffer9* ppIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexDataPtr = &ppIndexData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader(uint* pFunction, IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader(uint* pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader(ref uint pFunction, IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShader);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShader);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShader);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader(ref uint pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShader(IDirect3DPixelShader9* pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShader(ref IDirect3DPixelShader9 pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DPixelShader9* pShaderPtr = &pShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShader(IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShader(ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, float* pNumSegs, RectpatchInfo* pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, float* pNumSegs, ref RectpatchInfo pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, ref float pNumSegs, RectpatchInfo* pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawRectPatch(uint Handle, ref float pNumSegs, ref RectpatchInfo pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, float* pNumSegs, TripatchInfo* pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, float* pNumSegs, ref TripatchInfo pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, ref float pNumSegs, TripatchInfo* pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DrawTriPatch(uint Handle, ref float pNumSegs, ref TripatchInfo pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeletePatch(uint Handle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, uint, int>)LpVtbl[117])(@this, Handle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int>)LpVtbl[117])(@this, Handle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)LpVtbl[117])(@this, Handle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQuery(Querytype Type, IDirect3DQuery9** ppQuery)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQuery);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQuery);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQuery);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQuery(Querytype Type, ref IDirect3DQuery9* ppQuery)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DQuery9** ppQueryPtr = &ppQuery)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQueryPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQueryPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQueryPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
