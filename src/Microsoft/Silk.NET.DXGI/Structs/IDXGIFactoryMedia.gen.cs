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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (SwapChainDesc1* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
        {
            var @this = (IDXGIFactoryMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
            fixed (T0* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
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
                fixed (T0* hSurfacePtr = &hSurface)
                {
                    fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                    {
                        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                        {
                            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                            {
                                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, T0*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
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
