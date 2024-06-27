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

namespace Silk.NET.WindowsCodecs
{
    [Guid("3aff9cce-be95-4303-b927-e7d16ff4a613")]
    [NativeName("Name", "IWICPlanarBitmapSourceTransform")]
    public unsafe partial struct IWICPlanarBitmapSourceTransform : IComVtbl<IWICPlanarBitmapSourceTransform>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3aff9cce-be95-4303-b927-e7d16ff4a613");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICPlanarBitmapSourceTransform val)
            => Unsafe.As<IWICPlanarBitmapSourceTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICPlanarBitmapSourceTransform
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
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfIsSupportedPtr = &pfIsSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
            {
                fixed (int* pfIsSupportedPtr = &pfIsSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
            {
                fixed (int* pfIsSupportedPtr = &pfIsSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
            {
                fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
            {
                fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                {
                    fixed (int* pfIsSupportedPtr = &pfIsSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (int* pfIsSupportedPtr = &pfIsSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                {
                    fixed (int* pfIsSupportedPtr = &pfIsSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    fixed (int* pfIsSupportedPtr = &pfIsSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                    {
                        fixed (int* pfIsSupportedPtr = &pfIsSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (int* pfIsSupportedPtr = &pfIsSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                {
                    fixed (int* pfIsSupportedPtr = &pfIsSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    fixed (int* pfIsSupportedPtr = &pfIsSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                {
                    fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                    {
                        fixed (int* pfIsSupportedPtr = &pfIsSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (int* pfIsSupportedPtr = &pfIsSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                    {
                        fixed (int* pfIsSupportedPtr = &pfIsSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupported);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                    {
                        fixed (int* pfIsSupportedPtr = &pfIsSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                    {
                        fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
                    {
                        fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
                        {
                            fixed (int* pfIsSupportedPtr = &pfIsSupported)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptionsPtr, cPlanes, pfIsSupportedPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapPlane* pDstPlanes, uint cPlanes)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BitmapPlane pDstPlanes, uint cPlanes)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPlane* pDstPlanesPtr = &pDstPlanes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanesPtr, cPlanes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapPlane* pDstPlanes, uint cPlanes)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSourcePtr, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BitmapPlane pDstPlanes, uint cPlanes)
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
            {
                fixed (BitmapPlane* pDstPlanesPtr = &pDstPlanes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSourcePtr, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanesPtr, cPlanes);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPlanarBitmapSourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
