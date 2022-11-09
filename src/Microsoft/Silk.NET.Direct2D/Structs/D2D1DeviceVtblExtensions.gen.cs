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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1DeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Device> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Device> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceContext(this ComPtr<ID2D1Device> thisVtbl, DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceContext(this ComPtr<ID2D1Device> thisVtbl, DeviceContextOptions options, ref ID2D1DeviceContext* deviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1DeviceContext** deviceContextPtr = &deviceContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1PrintControl** printControlPtr = &printControl)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlPropertiesPtr, printControl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
        {
            fixed (ID2D1PrintControl** printControlPtr = &printControl)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlPropertiesPtr, printControlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlProperties, printControl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
        {
            fixed (ID2D1PrintControl** printControlPtr = &printControl)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlProperties, printControlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
        {
            fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlPropertiesPtr, printControl);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
        {
            fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
            {
                fixed (ID2D1PrintControl** printControlPtr = &printControl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTargetPtr, printControlPropertiesPtr, printControlPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlProperties, printControl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (ID2D1PrintControl** printControlPtr = &printControl)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlProperties, printControlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlPropertiesPtr, printControl);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
            {
                fixed (ID2D1PrintControl** printControlPtr = &printControl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTarget, printControlPropertiesPtr, printControlPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlProperties, printControl);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                fixed (ID2D1PrintControl** printControlPtr = &printControl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlProperties, printControlPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlPropertiesPtr, printControl);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICImagingFactory* wicFactoryPtr = &wicFactory)
        {
            fixed (IPrintDocumentPackageTarget* documentTargetPtr = &documentTarget)
            {
                fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
                {
                    fixed (ID2D1PrintControl** printControlPtr = &printControl)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactoryPtr, documentTargetPtr, printControlPropertiesPtr, printControlPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMaximumTextureMemory(this ComPtr<ID2D1Device> thisVtbl, ulong maximumInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device*, ulong, void>)@this->LpVtbl[6])(@this, maximumInBytes);
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMaximumTextureMemory(this ComPtr<ID2D1Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device*, ulong>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearResources(this ComPtr<ID2D1Device> thisVtbl, uint millisecondsSinceUse)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint, void>)@this->LpVtbl[8])(@this, millisecondsSinceUse);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Device> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1Device> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateDeviceContext<TI0>(this ComPtr<ID2D1Device> thisVtbl, DeviceContextOptions options, ref ComPtr<TI0> deviceContext) where TI0 : unmanaged, IComVtbl<ID2D1DeviceContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDeviceContext(options, (ID2D1DeviceContext**) deviceContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, Span<PrintControlProperties> printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, ref printControlProperties.GetPinnableReference(), printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, ref printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, Span<PrintControlProperties> printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, ref printControlProperties.GetPinnableReference(), ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, ref documentTarget.GetPinnableReference(), printControlProperties, printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(wicFactory, ref documentTarget, printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, ref documentTarget.GetPinnableReference(), printControlProperties, ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, Span<PrintControlProperties> printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, ref documentTarget.GetPinnableReference(), ref printControlProperties.GetPinnableReference(), printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(wicFactory, ref documentTarget, ref printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, IWICImagingFactory* wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, Span<PrintControlProperties> printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, ref documentTarget.GetPinnableReference(), ref printControlProperties.GetPinnableReference(), ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), documentTarget, printControlProperties, printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(ref wicFactory, documentTarget, printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, IPrintDocumentPackageTarget* documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), documentTarget, printControlProperties, ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, IPrintDocumentPackageTarget* documentTarget, Span<PrintControlProperties> printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), documentTarget, ref printControlProperties.GetPinnableReference(), printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, IPrintDocumentPackageTarget* documentTarget, ref PrintControlProperties printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(ref wicFactory, documentTarget, ref printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, IPrintDocumentPackageTarget* documentTarget, Span<PrintControlProperties> printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), documentTarget, ref printControlProperties.GetPinnableReference(), ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), ref documentTarget.GetPinnableReference(), printControlProperties, printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, PrintControlProperties* printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(ref wicFactory, ref documentTarget, printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), ref documentTarget.GetPinnableReference(), printControlProperties, ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, Span<PrintControlProperties> printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), ref documentTarget.GetPinnableReference(), ref printControlProperties.GetPinnableReference(), printControl);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePrintControl<TI0>(this ComPtr<ID2D1Device> thisVtbl, ref IWICImagingFactory wicFactory, ref IPrintDocumentPackageTarget documentTarget, ref PrintControlProperties printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(ref wicFactory, ref documentTarget, ref printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device> thisVtbl, Span<IWICImagingFactory> wicFactory, Span<IPrintDocumentPackageTarget> documentTarget, Span<PrintControlProperties> printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(ref wicFactory.GetPinnableReference(), ref documentTarget.GetPinnableReference(), ref printControlProperties.GetPinnableReference(), ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Device> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
