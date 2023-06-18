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

public unsafe static class D2D1SvgElementVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgElement> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDocument(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgDocument** document)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)@this->LpVtbl[4])(@this, document);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTagName(this ComPtr<ID2D1SvgElement> thisVtbl, char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[5])(@this, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetTagNameLength(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTextContent(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetParent(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement** parent)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[8])(@this, parent);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasChildren(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Silk.NET.Core.Bool32>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFirstChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement** child)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[10])(@this, child);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetLastChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement** child)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[11])(@this, child);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreviousChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChild, previousChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNextChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChild, nextChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertChildBefore(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChild, referenceChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[15])(@this, newChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReplaceChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChild, oldChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveChild(this ComPtr<ID2D1SvgElement> thisVtbl, ID2D1SvgElement* oldChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[17])(@this, oldChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateChild(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ID2D1SvgElement** newChild)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagName, newChild);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsAttributeSpecified(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, int* inherited)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, name, inherited);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetSpecifiedAttributeCount(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeName(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, char* name, uint nameCount, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, name, nameCount, inherited);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecifiedAttributeNameLength(this ComPtr<ID2D1SvgElement> thisVtbl, uint index, uint* nameLength, int* inherited)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLength, inherited);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveAttribute(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)@this->LpVtbl[23])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[24])(@this, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextValue(this ComPtr<ID2D1SvgElement> thisVtbl, char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[25])(@this, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetTextValueLength(this ComPtr<ID2D1SvgElement> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, name, type, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValue(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, char* value, uint valueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, name, type, value, valueCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAttributeValueLength(this ComPtr<ID2D1SvgElement> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, uint* valueLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, name, type, valueLength);
        return ret;
    }

}
