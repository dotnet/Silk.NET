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
    [Guid("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12")]
    [NativeName("Name", "IDXGIFactoryMedia")]
    public unsafe partial struct IDXGIFactoryMedia
    {
        public static readonly Guid Guid = new("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIFactoryMedia val)
            => Unsafe.As<IDXGIFactoryMedia, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIFactoryMedia
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
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (void* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                                {
            #if NET5_0_OR_GREATER
                                    ret = ((delegate* unmanaged<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                    }
                                    else
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

    }
}
