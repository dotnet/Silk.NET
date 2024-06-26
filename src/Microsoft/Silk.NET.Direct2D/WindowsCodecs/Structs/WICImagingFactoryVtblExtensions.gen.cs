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

public unsafe static class WICImagingFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImagingFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImagingFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICImagingFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICImagingFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFilenamePtr = &wzFilename)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFilenamePtr = &wzFilename)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFilenamePtr = &wzFilename)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFilenamePtr = &wzFilename)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        SilkMarshal.Free((nint)wzFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
        fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
        }
        SilkMarshal.Free((nint)wzFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
        }
        SilkMarshal.Free((nint)wzFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
        }
        SilkMarshal.Free((nint)wzFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendor, metadataOptions, ppIDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendor, metadataOptions, ppIDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendorPtr, metadataOptions, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendor, metadataOptions, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendor, metadataOptions, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendorPtr, metadataOptions, ppIDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendor, metadataOptions, ppIDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendor, metadataOptions, ppIDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendorPtr, metadataOptions, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentInfo(this ComPtr<IWICImagingFactory> thisVtbl, Guid* clsidComponent, IWICComponentInfo** ppIInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponent, ppIInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentInfo(this ComPtr<IWICImagingFactory> thisVtbl, Guid* clsidComponent, ref IWICComponentInfo* ppIInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICComponentInfo** ppIInfoPtr = &ppIInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponent, ppIInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentInfo(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid clsidComponent, IWICComponentInfo** ppIInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidComponentPtr = &clsidComponent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponentPtr, ppIInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentInfo(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid clsidComponent, ref IWICComponentInfo* ppIInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidComponentPtr = &clsidComponent)
        {
            fixed (IWICComponentInfo** ppIInfoPtr = &ppIInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponentPtr, ppIInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendor, ppIDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendor, ppIDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendorPtr, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendorPtr, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendor, ppIDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendor, ppIDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendor, ppIEncoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendor, ppIEncoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendorPtr, ppIEncoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendorPtr, ppIEncoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendor, ppIEncoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendor, ppIEncoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIEncoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIEncoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePalette(this ComPtr<IWICImagingFactory> thisVtbl, IWICPalette** ppIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICPalette**, int>)@this->LpVtbl[9])(@this, ppIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePalette(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICPalette* ppIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette** ppIPalettePtr = &ppIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICPalette**, int>)@this->LpVtbl[9])(@this, ppIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFormatConverter(this ComPtr<IWICImagingFactory> thisVtbl, IWICFormatConverter** ppIFormatConverter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICFormatConverter**, int>)@this->LpVtbl[10])(@this, ppIFormatConverter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFormatConverter(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICFormatConverter* ppIFormatConverter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICFormatConverter** ppIFormatConverterPtr = &ppIFormatConverter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICFormatConverter**, int>)@this->LpVtbl[10])(@this, ppIFormatConverterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapScaler(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapScaler** ppIBitmapScaler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapScaler**, int>)@this->LpVtbl[11])(@this, ppIBitmapScaler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapScaler(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapScaler* ppIBitmapScaler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapScaler** ppIBitmapScalerPtr = &ppIBitmapScaler)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapScaler**, int>)@this->LpVtbl[11])(@this, ppIBitmapScalerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapClipper(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapClipper** ppIBitmapClipper)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapClipper**, int>)@this->LpVtbl[12])(@this, ppIBitmapClipper);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapClipper(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapClipper* ppIBitmapClipper)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapClipper** ppIBitmapClipperPtr = &ppIBitmapClipper)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapClipper**, int>)@this->LpVtbl[12])(@this, ppIBitmapClipperPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFlipRotator(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapFlipRotator** ppIBitmapFlipRotator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFlipRotator**, int>)@this->LpVtbl[13])(@this, ppIBitmapFlipRotator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFlipRotator(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapFlipRotator* ppIBitmapFlipRotator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFlipRotator** ppIBitmapFlipRotatorPtr = &ppIBitmapFlipRotator)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFlipRotator**, int>)@this->LpVtbl[13])(@this, ppIBitmapFlipRotatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IWICImagingFactory> thisVtbl, IWICStream** ppIWICStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICStream**, int>)@this->LpVtbl[14])(@this, ppIWICStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStream(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICStream* ppIWICStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICStream** ppIWICStreamPtr = &ppIWICStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICStream**, int>)@this->LpVtbl[14])(@this, ppIWICStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<IWICImagingFactory> thisVtbl, IWICColorContext** ppIWICColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorContext**, int>)@this->LpVtbl[15])(@this, ppIWICColorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICColorContext* ppIWICColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIWICColorContextPtr = &ppIWICColorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorContext**, int>)@this->LpVtbl[15])(@this, ppIWICColorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorTransformer(this ComPtr<IWICImagingFactory> thisVtbl, IWICColorTransform** ppIWICColorTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorTransform**, int>)@this->LpVtbl[16])(@this, ppIWICColorTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorTransformer(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICColorTransform* ppIWICColorTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorTransform** ppIWICColorTransformPtr = &ppIWICColorTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorTransform**, int>)@this->LpVtbl[16])(@this, ppIWICColorTransformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormat, option, ppIBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormatPtr, option, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormatPtr, option, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapSource* pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSource, option, ppIBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapSource* pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSource, option, ppIBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSourcePtr, option, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSourcePtr, option, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSource, x, y, width, height, ppIBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSource, x, y, width, height, ppIBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSourcePtr, x, y, width, height, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSourcePtr, x, y, width, height, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
        }
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBuffer, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFormatPtr = &pixelFormat)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
            }
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, void* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalette, options, ppIBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalette, options, ppIBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, ref T0 hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hPalettePtr = &hPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalettePtr, options, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, ref T0 hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hPalettePtr = &hPalette)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalettePtr, options, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hBitmap, void* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hBitmapPtr = &hBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalette, options, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hBitmapPtr = &hBitmap)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalette, options, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0, T1>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hBitmap, ref T1 hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hBitmapPtr = &hBitmap)
        {
            fixed (void* hPalettePtr = &hPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalettePtr, options, ppIBitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0, T1>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hBitmap, ref T1 hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hBitmapPtr = &hBitmap)
        {
            fixed (void* hPalettePtr = &hPalette)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalettePtr, options, ppIBitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON(this ComPtr<IWICImagingFactory> thisVtbl, void* hIcon, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIcon, ppIBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON(this ComPtr<IWICImagingFactory> thisVtbl, void* hIcon, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIcon, ppIBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON<T0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hIcon, IWICBitmap** ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hIconPtr = &hIcon)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIconPtr, ppIBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON<T0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hIcon, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hIconPtr = &hIcon)
        {
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIconPtr, ppIBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentEnumerator(this ComPtr<IWICImagingFactory> thisVtbl, uint componentTypes, uint options, Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[23])(@this, componentTypes, options, ppIEnumUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentEnumerator(this ComPtr<IWICImagingFactory> thisVtbl, uint componentTypes, uint options, ref Silk.NET.Core.Win32Extras.IEnumUnknown* ppIEnumUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumUnknownPtr = &ppIEnumUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[23])(@this, componentTypes, options, ppIEnumUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoder, ppIFastEncoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapDecoder* pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoder, ppIFastEncoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapDecoder pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoder* pIDecoderPtr = &pIDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoderPtr, ppIFastEncoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapDecoder pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoder* pIDecoderPtr = &pIDecoder)
        {
            fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoderPtr, ppIFastEncoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoder, ppIFastEncoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode(this ComPtr<IWICImagingFactory> thisVtbl, IWICBitmapFrameDecode* pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoder, ppIFastEncoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapFrameDecode pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameDecode* pIFrameDecoderPtr = &pIFrameDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoderPtr, ppIFastEncoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapFrameDecode pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameDecode* pIFrameDecoderPtr = &pIFrameDecoder)
        {
            fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoderPtr, ppIFastEncoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendor, ppIQueryWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendor, ppIQueryWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendorPtr, ppIQueryWriter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendorPtr, ppIQueryWriterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendor, ppIQueryWriter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
        {
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendor, ppIQueryWriterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendorPtr, ppIQueryWriter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendorPtr, ppIQueryWriterPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendor, ppIQueryWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendor, ppIQueryWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendorPtr, ppIQueryWriter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendorPtr, ppIQueryWriterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendor, ppIQueryWriter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
        {
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendor, ppIQueryWriterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendorPtr, ppIQueryWriter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
        {
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendorPtr, ppIQueryWriterPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFilename(wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor.GetPinnableReference(), dwDesiredAccess, metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor.GetPinnableReference(), dwDesiredAccess, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(in wzFilename.GetPinnableReference(), pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFilename(in wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(in wzFilename.GetPinnableReference(), pguidVendor, dwDesiredAccess, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(in wzFilename.GetPinnableReference(), in pguidVendor.GetPinnableReference(), dwDesiredAccess, metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoderFromFilename<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFilename(in wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(in wzFilename.GetPinnableReference(), in pguidVendor.GetPinnableReference(), dwDesiredAccess, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFilename(wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor.GetPinnableReference(), dwDesiredAccess, metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoderFromFilename<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFilename(this ComPtr<IWICImagingFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor.GetPinnableReference(), dwDesiredAccess, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI1> ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidVendor, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromStream(pIStream, in pguidVendor.GetPinnableReference(), metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoderFromStream<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI1> ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromStream(pIStream, in pguidVendor.GetPinnableReference(), metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidVendor, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromStream(ref pIStream.GetPinnableReference(), pguidVendor, metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromStream(ref pIStream, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromStream(ref pIStream.GetPinnableReference(), pguidVendor, metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromStream(ref pIStream.GetPinnableReference(), in pguidVendor.GetPinnableReference(), metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoderFromStream<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromStream(ref pIStream, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromStream(this ComPtr<IWICImagingFactory> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromStream(ref pIStream.GetPinnableReference(), in pguidVendor.GetPinnableReference(), metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFileHandle(hFile, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFileHandle(hFile, in pguidVendor.GetPinnableReference(), metadataOptions, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoderFromFileHandle<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoderFromFileHandle(hFile, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoderFromFileHandle(this ComPtr<IWICImagingFactory> thisVtbl, nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoderFromFileHandle(hFile, in pguidVendor.GetPinnableReference(), metadataOptions, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateComponentInfo<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, out ComPtr<TI0> ppIInfo) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIInfo = default;
        return @this->CreateComponentInfo(SilkMarshal.GuidPtrOf<TI0>(), (IWICComponentInfo**) ppIInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentInfo(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> clsidComponent, IWICComponentInfo** ppIInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComponentInfo(ref clsidComponent.GetPinnableReference(), ppIInfo);
    }

    /// <summary>To be documented.</summary>
    public static int CreateComponentInfo<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid clsidComponent, ref ComPtr<TI0> ppIInfo) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateComponentInfo(ref clsidComponent, (IWICComponentInfo**) ppIInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComponentInfo(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> clsidComponent, ref IWICComponentInfo* ppIInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComponentInfo(ref clsidComponent.GetPinnableReference(), ref ppIInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, out ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIDecoder = default;
        return @this->CreateDecoder(guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoder(guidContainerFormat, in pguidVendor.GetPinnableReference(), ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoder(guidContainerFormat, in pguidVendor, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoder(guidContainerFormat, in pguidVendor.GetPinnableReference(), ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoder(ref guidContainerFormat.GetPinnableReference(), pguidVendor, ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, out ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIDecoder = default;
        return @this->CreateDecoder(ref guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoder(ref guidContainerFormat.GetPinnableReference(), pguidVendor, ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoder(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecoder(ref guidContainerFormat, in pguidVendor, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecoder(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ref ppIDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, out ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIEncoder = default;
        return @this->CreateEncoder(guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEncoder(guidContainerFormat, in pguidVendor.GetPinnableReference(), ppIEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEncoder(guidContainerFormat, in pguidVendor, (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEncoder(guidContainerFormat, in pguidVendor.GetPinnableReference(), ref ppIEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEncoder(ref guidContainerFormat.GetPinnableReference(), pguidVendor, ppIEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEncoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, out ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIEncoder = default;
        return @this->CreateEncoder(ref guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEncoder(ref guidContainerFormat.GetPinnableReference(), pguidVendor, ref ppIEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEncoder(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ppIEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEncoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEncoder(ref guidContainerFormat, in pguidVendor, (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEncoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEncoder(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ref ppIEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePalette<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePalette((IWICPalette**) ppIPalette.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFormatConverter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIFormatConverter) where TI0 : unmanaged, IComVtbl<IWICFormatConverter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFormatConverter((IWICFormatConverter**) ppIFormatConverter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapScaler<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIBitmapScaler) where TI0 : unmanaged, IComVtbl<IWICBitmapScaler>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapScaler((IWICBitmapScaler**) ppIBitmapScaler.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapClipper<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIBitmapClipper) where TI0 : unmanaged, IComVtbl<IWICBitmapClipper>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapClipper((IWICBitmapClipper**) ppIBitmapClipper.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFlipRotator<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIBitmapFlipRotator) where TI0 : unmanaged, IComVtbl<IWICBitmapFlipRotator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFlipRotator((IWICBitmapFlipRotator**) ppIBitmapFlipRotator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateStream<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIWICStream) where TI0 : unmanaged, IComVtbl<IWICStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStream((IWICStream**) ppIWICStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorContext<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIWICColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorContext((IWICColorContext**) ppIWICColorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateColorTransformer<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref ComPtr<TI0> ppIWICColorTransform) where TI0 : unmanaged, IComVtbl<IWICColorTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateColorTransformer((IWICColorTransform**) ppIWICColorTransform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(uiWidth, uiHeight, pixelFormat, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), option, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmap<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmap(uiWidth, uiHeight, ref pixelFormat, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmap(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), option, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromSource<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIBitmapSource, BitmapCreateCacheOption option, ref ComPtr<TI1> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromSource((IWICBitmapSource*) pIBitmapSource.Handle, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromSource((IWICBitmapSource*) pIBitmapSource.Handle, option, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromSource(ref pIBitmapSource.GetPinnableReference(), option, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromSource<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromSource(ref pIBitmapSource, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSource(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromSource(ref pIBitmapSource.GetPinnableReference(), option, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromSourceRect<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIBitmapSource, uint x, uint y, uint width, uint height, ref ComPtr<TI1> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromSourceRect((IWICBitmapSource*) pIBitmapSource.Handle, x, y, width, height, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromSourceRect((IWICBitmapSource*) pIBitmapSource.Handle, x, y, width, height, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromSourceRect(ref pIBitmapSource.GetPinnableReference(), x, y, width, height, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromSourceRect<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromSourceRect(ref pIBitmapSource, x, y, width, height, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromSourceRect(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromSourceRect(ref pIBitmapSource.GetPinnableReference(), x, y, width, height, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference(), ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, ref pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference(), ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference(), ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromMemory<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, ref pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference(), ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromMemory<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromMemory(this ComPtr<IWICImagingFactory> thisVtbl, uint uiWidth, uint uiHeight, Span<Guid> pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromHBITMAP(hBitmap, hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, Span<T0> hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHBITMAP(hBitmap, ref hPalette.GetPinnableReference(), options, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0, TI0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, ref T0 hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromHBITMAP(hBitmap, ref hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hBitmap, Span<T0> hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHBITMAP(hBitmap, ref hPalette.GetPinnableReference(), options, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, Span<T0> hBitmap, void* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHBITMAP(ref hBitmap.GetPinnableReference(), hPalette, options, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0, TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromHBITMAP(ref hBitmap, hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0>(this ComPtr<IWICImagingFactory> thisVtbl, Span<T0> hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHBITMAP(ref hBitmap.GetPinnableReference(), hPalette, options, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0, T1>(this ComPtr<IWICImagingFactory> thisVtbl, Span<T0> hBitmap, Span<T1> hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHBITMAP(ref hBitmap.GetPinnableReference(), ref hPalette.GetPinnableReference(), options, ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromHBITMAP<T0, T1, TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hBitmap, ref T1 hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromHBITMAP(ref hBitmap, ref hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHBITMAP<T0, T1>(this ComPtr<IWICImagingFactory> thisVtbl, Span<T0> hBitmap, Span<T1> hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHBITMAP(ref hBitmap.GetPinnableReference(), ref hPalette.GetPinnableReference(), options, ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, void* hIcon, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromHICON(hIcon, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON<T0>(this ComPtr<IWICImagingFactory> thisVtbl, Span<T0> hIcon, IWICBitmap** ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHICON(ref hIcon.GetPinnableReference(), ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapFromHICON<T0, TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref T0 hIcon, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapFromHICON(ref hIcon, (IWICBitmap**) ppIBitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromHICON<T0>(this ComPtr<IWICImagingFactory> thisVtbl, Span<T0> hIcon, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateBitmapFromHICON(ref hIcon.GetPinnableReference(), ref ppIBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFastMetadataEncoderFromDecoder<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIDecoder, ref ComPtr<TI1> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFastMetadataEncoderFromDecoder((IWICBitmapDecoder*) pIDecoder.Handle, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFastMetadataEncoderFromDecoder((IWICBitmapDecoder*) pIDecoder.Handle, ref ppIFastEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapDecoder> pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFastMetadataEncoderFromDecoder(ref pIDecoder.GetPinnableReference(), ppIFastEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFastMetadataEncoderFromDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapDecoder pIDecoder, ref ComPtr<TI0> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFastMetadataEncoderFromDecoder(ref pIDecoder, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromDecoder(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapDecoder> pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFastMetadataEncoderFromDecoder(ref pIDecoder.GetPinnableReference(), ref ppIFastEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFastMetadataEncoderFromFrameDecode<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIFrameDecoder, ref ComPtr<TI1> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFastMetadataEncoderFromFrameDecode((IWICBitmapFrameDecode*) pIFrameDecoder.Handle, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFastMetadataEncoderFromFrameDecode((IWICBitmapFrameDecode*) pIFrameDecoder.Handle, ref ppIFastEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapFrameDecode> pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFastMetadataEncoderFromFrameDecode(ref pIFrameDecoder.GetPinnableReference(), ppIFastEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFastMetadataEncoderFromFrameDecode<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICBitmapFrameDecode pIFrameDecoder, ref ComPtr<TI0> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFastMetadataEncoderFromFrameDecode(ref pIFrameDecoder, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFastMetadataEncoderFromFrameDecode(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICBitmapFrameDecode> pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFastMetadataEncoderFromFrameDecode(ref pIFrameDecoder.GetPinnableReference(), ref ppIFastEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIQueryWriter = default;
        return @this->CreateQueryWriter(guidMetadataFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriter(guidMetadataFormat, in pguidVendor.GetPinnableReference(), ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQueryWriter(guidMetadataFormat, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriter(guidMetadataFormat, in pguidVendor.GetPinnableReference(), ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriter(ref guidMetadataFormat.GetPinnableReference(), pguidVendor, ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryWriter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIQueryWriter = default;
        return @this->CreateQueryWriter(ref guidMetadataFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriter(ref guidMetadataFormat.GetPinnableReference(), pguidVendor, ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriter(ref guidMetadataFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryWriter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQueryWriter(ref guidMetadataFormat, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriter(this ComPtr<IWICImagingFactory> thisVtbl, Span<Guid> guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriter(ref guidMetadataFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryWriterFromReader<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIQueryReader, out ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIQueryWriter = default;
        return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, SilkMarshal.GuidPtrOf<TI1>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, pguidVendor, ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriterFromReader(pIQueryReader, in pguidVendor.GetPinnableReference(), ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryWriterFromReader<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriterFromReader(pIQueryReader, in pguidVendor.GetPinnableReference(), ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, in pguidVendor, ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICMetadataQueryReader> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriterFromReader(ref pIQueryReader.GetPinnableReference(), pguidVendor, ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryWriterFromReader<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppIQueryWriter = default;
        return @this->CreateQueryWriterFromReader(ref pIQueryReader, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICMetadataQueryReader> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriterFromReader(ref pIQueryReader.GetPinnableReference(), pguidVendor, ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICMetadataQueryReader> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriterFromReader(ref pIQueryReader.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryWriterFromReader<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQueryWriterFromReader(ref pIQueryReader, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryWriterFromReader(this ComPtr<IWICImagingFactory> thisVtbl, Span<IWICMetadataQueryReader> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryWriterFromReader(ref pIQueryReader.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ref ppIQueryWriter);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICImagingFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateComponentInfo<TI0>(this ComPtr<IWICImagingFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateComponentInfo(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDecoder(guidContainerFormat, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDecoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDecoder(ref guidContainerFormat, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateEncoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateEncoder(guidContainerFormat, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateEncoder<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateEncoder(ref guidContainerFormat, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateQueryWriter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, Guid* guidMetadataFormat) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryWriter(guidMetadataFormat, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateQueryWriter<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref Guid guidMetadataFormat) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryWriter(ref guidMetadataFormat, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateQueryWriterFromReader<TI0, TI1>(this ComPtr<IWICImagingFactory> thisVtbl, ComPtr<TI0> pIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryWriterFromReader(pIQueryReader, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateQueryWriterFromReader<TI0>(this ComPtr<IWICImagingFactory> thisVtbl, ref IWICMetadataQueryReader pIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryWriterFromReader(ref pIQueryReader, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
