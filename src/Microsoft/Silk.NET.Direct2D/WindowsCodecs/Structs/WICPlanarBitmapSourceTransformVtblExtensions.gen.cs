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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICPlanarBitmapSourceTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfIsSupportedPtr = &pfIsSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapPlaneDescription* pPlaneDescriptionsPtr = &pPlaneDescriptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptionsPtr, cPlanes, pfIsSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatsPtr = &pguidDstFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormatsPtr, pPlaneDescriptions, cPlanes, pfIsSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, uint*, uint*, BitmapTransformOptions, PlanarOptions, Guid*, BitmapPlaneDescription*, uint, int*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidDstFormats, ref BitmapPlaneDescription pPlaneDescriptions, uint cPlanes, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapPlane* pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BitmapPlane pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapPlane* pDstPlanesPtr = &pDstPlanes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanesPtr, cPlanes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapPlane* pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, BitmapTransformOptions, PlanarOptions, BitmapPlane*, uint, int>)@this->LpVtbl[4])(@this, prcSourcePtr, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BitmapPlane pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
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
    public static int QueryInterface<TI0>(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(puiWidth, ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), puiHeight, dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, pguidDstFormats, ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, BitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), pPlaneDescriptions, cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportTransform(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidDstFormats, Span<BitmapPlaneDescription> pPlaneDescriptions, uint cPlanes, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference(), dstTransform, dstPlanarOptions, in pguidDstFormats.GetPinnableReference(), ref pPlaneDescriptions.GetPinnableReference(), cPlanes, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapPlane> pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, in pDstPlanes.GetPinnableReference(), cPlanes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapPlane* pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prcSource.GetPinnableReference(), uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prcSource, uint uiWidth, uint uiHeight, BitmapTransformOptions dstTransform, PlanarOptions dstPlanarOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BitmapPlane> pDstPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prcSource.GetPinnableReference(), uiWidth, uiHeight, dstTransform, dstPlanarOptions, in pDstPlanes.GetPinnableReference(), cPlanes);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICPlanarBitmapSourceTransform> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
