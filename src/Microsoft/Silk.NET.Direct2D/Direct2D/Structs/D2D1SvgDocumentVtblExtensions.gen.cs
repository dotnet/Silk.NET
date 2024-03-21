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

public unsafe static class D2D1SvgDocumentVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgDocument> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgDocument> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgDocument> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgDocument> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgDocument> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgDocument> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int SetViewportSize(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Maths.Vector2D<float> viewportSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>, int>)@this->LpVtbl[4])(@this, viewportSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetViewportSize(this ComPtr<ID2D1SvgDocument> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetRoot(this ComPtr<ID2D1SvgDocument> thisVtbl, ID2D1SvgElement* root)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement*, int>)@this->LpVtbl[6])(@this, root);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRoot(this ComPtr<ID2D1SvgDocument> thisVtbl, ref ID2D1SvgElement root)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* rootPtr = &root)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement*, int>)@this->LpVtbl[6])(@this, rootPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRoot(this ComPtr<ID2D1SvgDocument> thisVtbl, ID2D1SvgElement** root)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement**, void>)@this->LpVtbl[7])(@this, root);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRoot(this ComPtr<ID2D1SvgDocument> thisVtbl, ref ID2D1SvgElement* root)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** rootPtr = &root)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement**, void>)@this->LpVtbl[7])(@this, rootPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ID2D1SvgElement** svgElement)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, id, svgElement);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ID2D1SvgElement* svgElement)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement** svgElementPtr = &svgElement)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, id, svgElementPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ID2D1SvgElement** svgElement)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* idPtr = &id)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, idPtr, svgElement);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ref ID2D1SvgElement* svgElement)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* idPtr = &id)
        {
            fixed (ID2D1SvgElement** svgElementPtr = &svgElement)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, idPtr, svgElementPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgElement** svgElement)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, byte*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, idPtr, svgElement);
        SilkMarshal.Free((nint)idPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgElement* svgElement)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
        fixed (ID2D1SvgElement** svgElementPtr = &svgElement)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, byte*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, idPtr, svgElementPtr);
        }
        SilkMarshal.Free((nint)idPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* outputXmlStream, ID2D1SvgElement* subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement*, int>)@this->LpVtbl[9])(@this, outputXmlStream, subtree);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* outputXmlStream, ref ID2D1SvgElement subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement* subtreePtr = &subtree)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement*, int>)@this->LpVtbl[9])(@this, outputXmlStream, subtreePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream outputXmlStream, ID2D1SvgElement* subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* outputXmlStreamPtr = &outputXmlStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement*, int>)@this->LpVtbl[9])(@this, outputXmlStreamPtr, subtree);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream outputXmlStream, ref ID2D1SvgElement subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* outputXmlStreamPtr = &outputXmlStream)
        {
            fixed (ID2D1SvgElement* subtreePtr = &subtree)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement*, int>)@this->LpVtbl[9])(@this, outputXmlStreamPtr, subtreePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* inputXmlStream, ID2D1SvgElement** subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement**, int>)@this->LpVtbl[10])(@this, inputXmlStream, subtree);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* inputXmlStream, ref ID2D1SvgElement* subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgElement** subtreePtr = &subtree)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement**, int>)@this->LpVtbl[10])(@this, inputXmlStream, subtreePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream inputXmlStream, ID2D1SvgElement** subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* inputXmlStreamPtr = &inputXmlStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement**, int>)@this->LpVtbl[10])(@this, inputXmlStreamPtr, subtree);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream inputXmlStream, ref ID2D1SvgElement* subtree)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* inputXmlStreamPtr = &inputXmlStream)
        {
            fixed (ID2D1SvgElement** subtreePtr = &subtree)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement**, int>)@this->LpVtbl[10])(@this, inputXmlStreamPtr, subtreePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, id, paint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgPaint** paintPtr = &paint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, id, paintPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* idPtr = &id)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, idPtr, paint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* idPtr = &id)
        {
            fixed (ID2D1SvgPaint** paintPtr = &paint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, idPtr, paintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, byte*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, idPtr, paint);
        SilkMarshal.Free((nint)idPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
        fixed (ID2D1SvgPaint** paintPtr = &paint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, byte*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, idPtr, paintPtr);
        }
        SilkMarshal.Free((nint)idPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, colorPtr, id, paint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (ID2D1SvgPaint** paintPtr = &paint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, colorPtr, id, paintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, colorPtr, idPtr, paint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            fixed (char* idPtr = &id)
            {
                fixed (ID2D1SvgPaint** paintPtr = &paint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, colorPtr, idPtr, paintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, byte*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, colorPtr, idPtr, paint);
        SilkMarshal.Free((nint)idPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            fixed (ID2D1SvgPaint** paintPtr = &paint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, byte*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, colorPtr, idPtr, paintPtr);
            }
        SilkMarshal.Free((nint)idPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgLength* dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)@this->LpVtbl[12])(@this, dashes, dashesCount, strokeDashArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgLength* dashes, uint dashesCount, ref ID2D1SvgStrokeDashArray* strokeDashArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgStrokeDashArray** strokeDashArrayPtr = &strokeDashArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)@this->LpVtbl[12])(@this, dashes, dashesCount, strokeDashArrayPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgLength dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SvgLength* dashesPtr = &dashes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)@this->LpVtbl[12])(@this, dashesPtr, dashesCount, strokeDashArray);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgLength dashes, uint dashesCount, ref ID2D1SvgStrokeDashArray* strokeDashArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SvgLength* dashesPtr = &dashes)
        {
            fixed (ID2D1SvgStrokeDashArray** strokeDashArrayPtr = &strokeDashArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)@this->LpVtbl[12])(@this, dashesPtr, dashesCount, strokeDashArrayPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, uint, ID2D1SvgPointCollection**, int>)@this->LpVtbl[13])(@this, points, pointsCount, pointCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, ref ID2D1SvgPointCollection* pointCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgPointCollection** pointCollectionPtr = &pointCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, uint, ID2D1SvgPointCollection**, int>)@this->LpVtbl[13])(@this, points, pointsCount, pointCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* pointsPtr = &points)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, uint, ID2D1SvgPointCollection**, int>)@this->LpVtbl[13])(@this, pointsPtr, pointsCount, pointCollection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> points, uint pointsCount, ref ID2D1SvgPointCollection* pointCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* pointsPtr = &points)
        {
            fixed (ID2D1SvgPointCollection** pointCollectionPtr = &pointCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, uint, ID2D1SvgPointCollection**, int>)@this->LpVtbl[13])(@this, pointsPtr, pointsCount, pointCollectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentData, segmentDataCount, commands, commandsCount, pathData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentData, segmentDataCount, commands, commandsCount, pathDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SvgPathCommand* commandsPtr = &commands)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentData, segmentDataCount, commandsPtr, commandsCount, pathData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SvgPathCommand* commandsPtr = &commands)
        {
            fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentData, segmentDataCount, commandsPtr, commandsCount, pathDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* segmentDataPtr = &segmentData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commands, commandsCount, pathData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* segmentDataPtr = &segmentData)
        {
            fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commands, commandsCount, pathDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* segmentDataPtr = &segmentData)
        {
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commandsPtr, commandsCount, pathData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* segmentDataPtr = &segmentData)
        {
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commandsPtr, commandsCount, pathDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetRoot<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, ComPtr<TI0> root) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetRoot((ID2D1SvgElement*) root.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetRoot(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<ID2D1SvgElement> root)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetRoot(ref root.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetRoot<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, ref ComPtr<TI0> root) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetRoot((ID2D1SvgElement**) root.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ComPtr<TI0> svgElement) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindElementById(id, (ID2D1SvgElement**) svgElement.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id, ID2D1SvgElement** svgElement)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindElementById(in id.GetPinnableReference(), svgElement);
    }

    /// <summary>To be documented.</summary>
    public static int FindElementById<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ref ComPtr<TI0> svgElement) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindElementById(in id, (ID2D1SvgElement**) svgElement.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindElementById(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id, ref ID2D1SvgElement* svgElement)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindElementById(in id.GetPinnableReference(), ref svgElement);
    }

    /// <summary>To be documented.</summary>
    public static int FindElementById<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ComPtr<TI0> svgElement) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindElementById(id, (ID2D1SvgElement**) svgElement.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* outputXmlStream, ComPtr<TI0> subtree) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Serialize(outputXmlStream, (ID2D1SvgElement*) subtree.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* outputXmlStream, Span<ID2D1SvgElement> subtree)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Serialize(outputXmlStream, ref subtree.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> outputXmlStream, ID2D1SvgElement* subtree)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Serialize(ref outputXmlStream.GetPinnableReference(), subtree);
    }

    /// <summary>To be documented.</summary>
    public static int Serialize<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream outputXmlStream, ComPtr<TI0> subtree) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Serialize(ref outputXmlStream, (ID2D1SvgElement*) subtree.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Serialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> outputXmlStream, Span<ID2D1SvgElement> subtree)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Serialize(ref outputXmlStream.GetPinnableReference(), ref subtree.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, Silk.NET.Core.Win32Extras.IStream* inputXmlStream, ref ComPtr<TI0> subtree) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Deserialize(inputXmlStream, (ID2D1SvgElement**) subtree.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> inputXmlStream, ID2D1SvgElement** subtree)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Deserialize(ref inputXmlStream.GetPinnableReference(), subtree);
    }

    /// <summary>To be documented.</summary>
    public static int Deserialize<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream inputXmlStream, ref ComPtr<TI0> subtree) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Deserialize(ref inputXmlStream, (ID2D1SvgElement**) subtree.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Deserialize(this ComPtr<ID2D1SvgDocument> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> inputXmlStream, ref ID2D1SvgElement* subtree)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Deserialize(ref inputXmlStream.GetPinnableReference(), ref subtree);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ComPtr<TI0> paint) where TI0 : unmanaged, IComVtbl<ID2D1SvgPaint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePaint(paintType, color, id, (ID2D1SvgPaint**) paint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, color, in id.GetPinnableReference(), paint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ref ComPtr<TI0> paint) where TI0 : unmanaged, IComVtbl<ID2D1SvgPaint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePaint(paintType, color, in id, (ID2D1SvgPaint**) paint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, color, in id.GetPinnableReference(), ref paint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ComPtr<TI0> paint) where TI0 : unmanaged, IComVtbl<ID2D1SvgPaint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePaint(paintType, color, id, (ID2D1SvgPaint**) paint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, in color.GetPinnableReference(), id, paint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ComPtr<TI0> paint) where TI0 : unmanaged, IComVtbl<ID2D1SvgPaint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePaint(paintType, in color, id, (ID2D1SvgPaint**) paint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, in color.GetPinnableReference(), id, ref paint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, in color.GetPinnableReference(), in id.GetPinnableReference(), paint);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePaint<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id, ref ComPtr<TI0> paint) where TI0 : unmanaged, IComVtbl<ID2D1SvgPaint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePaint(paintType, in color, in id, (ID2D1SvgPaint**) paint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, in color.GetPinnableReference(), in id.GetPinnableReference(), ref paint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgPaint** paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, in color.GetPinnableReference(), id, paint);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePaint<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ComPtr<TI0> paint) where TI0 : unmanaged, IComVtbl<ID2D1SvgPaint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePaint(paintType, in color, id, (ID2D1SvgPaint**) paint.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePaint(this ComPtr<ID2D1SvgDocument> thisVtbl, SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgPaint* paint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePaint(paintType, in color.GetPinnableReference(), id, ref paint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgLength* dashes, uint dashesCount, ref ComPtr<TI0> strokeDashArray) where TI0 : unmanaged, IComVtbl<ID2D1SvgStrokeDashArray>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeDashArray(dashes, dashesCount, (ID2D1SvgStrokeDashArray**) strokeDashArray.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgLength> dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeDashArray(in dashes.GetPinnableReference(), dashesCount, strokeDashArray);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStrokeDashArray<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgLength dashes, uint dashesCount, ref ComPtr<TI0> strokeDashArray) where TI0 : unmanaged, IComVtbl<ID2D1SvgStrokeDashArray>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeDashArray(in dashes, dashesCount, (ID2D1SvgStrokeDashArray**) strokeDashArray.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeDashArray(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgLength> dashes, uint dashesCount, ref ID2D1SvgStrokeDashArray* strokeDashArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeDashArray(in dashes.GetPinnableReference(), dashesCount, ref strokeDashArray);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, ref ComPtr<TI0> pointCollection) where TI0 : unmanaged, IComVtbl<ID2D1SvgPointCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePointCollection(points, pointsCount, (ID2D1SvgPointCollection**) pointCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePointCollection(in points.GetPinnableReference(), pointsCount, pointCollection);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePointCollection<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> points, uint pointsCount, ref ComPtr<TI0> pointCollection) where TI0 : unmanaged, IComVtbl<ID2D1SvgPointCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePointCollection(in points, pointsCount, (ID2D1SvgPointCollection**) pointCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePointCollection(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> points, uint pointsCount, ref ID2D1SvgPointCollection* pointCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePointCollection(in points.GetPinnableReference(), pointsCount, ref pointCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ref ComPtr<TI0> pathData) where TI0 : unmanaged, IComVtbl<ID2D1SvgPathData>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathData(segmentData, segmentDataCount, commands, commandsCount, (ID2D1SvgPathData**) pathData.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgPathCommand> commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePathData(segmentData, segmentDataCount, in commands.GetPinnableReference(), commandsCount, pathData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, ref ComPtr<TI0> pathData) where TI0 : unmanaged, IComVtbl<ID2D1SvgPathData>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathData(segmentData, segmentDataCount, in commands, commandsCount, (ID2D1SvgPathData**) pathData.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgPathCommand> commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePathData(segmentData, segmentDataCount, in commands.GetPinnableReference(), commandsCount, ref pathData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePathData(in segmentData.GetPinnableReference(), segmentDataCount, commands, commandsCount, pathData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ref ComPtr<TI0> pathData) where TI0 : unmanaged, IComVtbl<ID2D1SvgPathData>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathData(in segmentData, segmentDataCount, commands, commandsCount, (ID2D1SvgPathData**) pathData.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePathData(in segmentData.GetPinnableReference(), segmentDataCount, commands, commandsCount, ref pathData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgPathCommand> commands, uint commandsCount, ID2D1SvgPathData** pathData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePathData(in segmentData.GetPinnableReference(), segmentDataCount, in commands.GetPinnableReference(), commandsCount, pathData);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePathData<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, ref ComPtr<TI0> pathData) where TI0 : unmanaged, IComVtbl<ID2D1SvgPathData>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathData(in segmentData, segmentDataCount, in commands, commandsCount, (ID2D1SvgPathData**) pathData.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathData(this ComPtr<ID2D1SvgDocument> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgPathCommand> commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePathData(in segmentData.GetPinnableReference(), segmentDataCount, in commands.GetPinnableReference(), commandsCount, ref pathData);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SvgDocument> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
