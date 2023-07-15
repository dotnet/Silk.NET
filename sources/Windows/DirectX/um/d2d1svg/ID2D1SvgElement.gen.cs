// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D2D1_SVG_ATTRIBUTE_POD_TYPE;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement"]/*'/>
[Guid("AC7B67A6-183E-49C1-A823-0EBE40B0DB29")]
[NativeTypeName("struct ID2D1SvgElement : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgElement : ID2D1SvgElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgElement));

    public void** lpVtbl;
    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, float value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, &value, sizeof(float));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, float* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, value, sizeof(float));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, (uint)(sizeof(DXGI_RGBA)));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, (uint)(sizeof(DXGI_RGBA)));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_FILL_MODE value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, &value, sizeof(D2D1_FILL_MODE));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_FILL_MODE* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, value, sizeof(D2D1_FILL_MODE));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_DISPLAY value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, &value, sizeof(D2D1_SVG_DISPLAY));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_DISPLAY* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, value, sizeof(D2D1_SVG_DISPLAY));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_OVERFLOW value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, &value, sizeof(D2D1_SVG_OVERFLOW));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_OVERFLOW* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, value, sizeof(D2D1_SVG_OVERFLOW));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_JOIN value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, &value, sizeof(D2D1_SVG_LINE_JOIN));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_JOIN* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, value, sizeof(D2D1_SVG_LINE_JOIN));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_CAP value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, &value, sizeof(D2D1_SVG_LINE_CAP));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_CAP* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, value, sizeof(D2D1_SVG_LINE_CAP));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_VISIBILITY value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, &value, sizeof(D2D1_SVG_VISIBILITY));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_VISIBILITY* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, value, sizeof(D2D1_SVG_VISIBILITY));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, (uint)(sizeof(D2D_MATRIX_3X2_F)));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, (uint)(sizeof(D2D_MATRIX_3X2_F)));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_UNIT_TYPE value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, &value, sizeof(D2D1_SVG_UNIT_TYPE));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_UNIT_TYPE* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, value, sizeof(D2D1_SVG_UNIT_TYPE));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_EXTEND_MODE value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, &value, sizeof(D2D1_EXTEND_MODE));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_EXTEND_MODE* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, value, sizeof(D2D1_EXTEND_MODE));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_PRESERVE_ASPECT_RATIO &")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, (uint)(sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, (uint)(sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
    }

    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_LENGTH &")] D2D1_SVG_LENGTH* value)
    {
        return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, (uint)(sizeof(D2D1_SVG_LENGTH)));
    }

    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LENGTH* value)
    {
        return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, (uint)(sizeof(D2D1_SVG_LENGTH)));
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint> )(lpVtbl[1]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint> )(lpVtbl[2]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SvgElement*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetDocument(ID2D1SvgDocument** document)
    {
        ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgDocument**, void> )(lpVtbl[4]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), document);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetTagName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTagName([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, uint, int> )(lpVtbl[5]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetTagNameLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT32")]
    public uint GetTagNameLength()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint> )(lpVtbl[6]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.IsTextContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsTextContent()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, int> )(lpVtbl[7]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetParent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetParent(ID2D1SvgElement** parent)
    {
        ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement**, void> )(lpVtbl[8]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), parent);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.HasChildren"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public BOOL HasChildren()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, int> )(lpVtbl[9]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetFirstChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void GetFirstChild(ID2D1SvgElement** child)
    {
        ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement**, void> )(lpVtbl[10]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetLastChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetLastChild(ID2D1SvgElement** child)
    {
        ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement**, void> )(lpVtbl[11]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetPreviousChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPreviousChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int> )(lpVtbl[12]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, previousChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetNextChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int> )(lpVtbl[13]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, nextChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.InsertChildBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT InsertChildBefore(ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild = null)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int> )(lpVtbl[14]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, referenceChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.AppendChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AppendChild(ID2D1SvgElement* newChild)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, int> )(lpVtbl[15]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.ReplaceChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReplaceChild(ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int> )(lpVtbl[16]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, oldChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.RemoveChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RemoveChild(ID2D1SvgElement* oldChild)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ID2D1SvgElement*, int> )(lpVtbl[17]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), oldChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.CreateChild"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateChild([NativeTypeName("PCWSTR")] ushort* tagName, ID2D1SvgElement** newChild)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, ID2D1SvgElement**, int> )(lpVtbl[18]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), tagName, newChild);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.IsAttributeSpecified"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public BOOL IsAttributeSpecified([NativeTypeName("PCWSTR")] ushort* name, BOOL* inherited = null)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, BOOL*, int> )(lpVtbl[19]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, inherited);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetSpecifiedAttributeCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetSpecifiedAttributeCount()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint> )(lpVtbl[20]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetSpecifiedAttributeName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetSpecifiedAttributeName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount, BOOL* inherited = null)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint, ushort*, uint, BOOL*, int> )(lpVtbl[21]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, name, nameCount, inherited);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetSpecifiedAttributeNameLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetSpecifiedAttributeNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* nameLength, BOOL* inherited = null)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint, uint*, BOOL*, int> )(lpVtbl[22]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, nameLength, inherited);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.RemoveAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT RemoveAttribute([NativeTypeName("PCWSTR")] ushort* name)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, int> )(lpVtbl[23]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.SetTextValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetTextValue([NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, uint, int> )(lpVtbl[24]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetTextValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetTextValue([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, uint, int> )(lpVtbl[25]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetTextValueLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetTextValueLength()
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, uint> )(lpVtbl[26]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.SetAttributeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgAttribute* value)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, ID2D1SvgAttribute*, int> )(lpVtbl[27]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.SetAttributeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("const void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int> )(lpVtbl[28]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.SetAttributeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] ushort* value)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, int> )(lpVtbl[29]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetAttributeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const IID &")] Guid* riid, void** value)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, Guid*, void**, int> )(lpVtbl[30]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, riid, value);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetAttributeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int> )(lpVtbl[31]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetAttributeValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] ushort* value, [NativeTypeName("UINT32")] uint valueCount)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, uint, int> )(lpVtbl[32]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueCount);
    }

    /// <include file='ID2D1SvgElement.xml' path='doc/member[@name="ID2D1SvgElement.GetAttributeValueLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetAttributeValueLength([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32 *")] uint* valueLength)
    {
        return ((delegate* unmanaged<ID2D1SvgElement*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, uint*, int> )(lpVtbl[33]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, valueLength);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void GetDocument(ID2D1SvgDocument** document);
        [VtblIndex(5)]
        HRESULT GetTagName([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);
        [VtblIndex(6)]
        [return: NativeTypeName("UINT32")]
        uint GetTagNameLength();
        [VtblIndex(7)]
        BOOL IsTextContent();
        [VtblIndex(8)]
        void GetParent(ID2D1SvgElement** parent);
        [VtblIndex(9)]
        BOOL HasChildren();
        [VtblIndex(10)]
        void GetFirstChild(ID2D1SvgElement** child);
        [VtblIndex(11)]
        void GetLastChild(ID2D1SvgElement** child);
        [VtblIndex(12)]
        HRESULT GetPreviousChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild);
        [VtblIndex(13)]
        HRESULT GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild);
        [VtblIndex(14)]
        HRESULT InsertChildBefore(ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild = null);
        [VtblIndex(15)]
        HRESULT AppendChild(ID2D1SvgElement* newChild);
        [VtblIndex(16)]
        HRESULT ReplaceChild(ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild);
        [VtblIndex(17)]
        HRESULT RemoveChild(ID2D1SvgElement* oldChild);
        [VtblIndex(18)]
        HRESULT CreateChild([NativeTypeName("PCWSTR")] ushort* tagName, ID2D1SvgElement** newChild);
        [VtblIndex(19)]
        BOOL IsAttributeSpecified([NativeTypeName("PCWSTR")] ushort* name, BOOL* inherited = null);
        [VtblIndex(20)]
        [return: NativeTypeName("UINT32")]
        uint GetSpecifiedAttributeCount();
        [VtblIndex(21)]
        HRESULT GetSpecifiedAttributeName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount, BOOL* inherited = null);
        [VtblIndex(22)]
        HRESULT GetSpecifiedAttributeNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32 *")] uint* nameLength, BOOL* inherited = null);
        [VtblIndex(23)]
        HRESULT RemoveAttribute([NativeTypeName("PCWSTR")] ushort* name);
        [VtblIndex(24)]
        HRESULT SetTextValue([NativeTypeName("const WCHAR *")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);
        [VtblIndex(25)]
        HRESULT GetTextValue([NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);
        [VtblIndex(26)]
        [return: NativeTypeName("UINT32")]
        uint GetTextValueLength();
        [VtblIndex(27)]
        HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgAttribute* value);
        [VtblIndex(28)]
        HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, [NativeTypeName("const void *")] void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes);
        [VtblIndex(29)]
        HRESULT SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PCWSTR")] ushort* value);
        [VtblIndex(30)]
        HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const IID &")] Guid* riid, void** value);
        [VtblIndex(31)]
        HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, void* value, [NativeTypeName("UINT32")] uint valueSizeInBytes);
        [VtblIndex(32)]
        HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("PWSTR")] ushort* value, [NativeTypeName("UINT32")] uint valueCount);
        [VtblIndex(33)]
        HRESULT GetAttributeValueLength([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, [NativeTypeName("UINT32 *")] uint* valueLength);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;
        [NativeTypeName("void (ID2D1SvgDocument **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgDocument**, void> GetDocument;
        [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetTagName;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetTagNameLength;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsTextContent;
        [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement**, void> GetParent;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasChildren;
        [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement**, void> GetFirstChild;
        [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement**, void> GetLastChild;
        [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, ID2D1SvgElement**, int> GetPreviousChild;
        [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, ID2D1SvgElement**, int> GetNextChild;
        [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, ID2D1SvgElement*, int> InsertChildBefore;
        [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, int> AppendChild;
        [NativeTypeName("HRESULT (ID2D1SvgElement *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, ID2D1SvgElement*, int> ReplaceChild;
        [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, int> RemoveChild;
        [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ID2D1SvgElement**, int> CreateChild;
        [NativeTypeName("BOOL (PCWSTR, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> IsAttributeSpecified;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSpecifiedAttributeCount;
        [NativeTypeName("HRESULT (UINT32, PWSTR, UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, BOOL*, int> GetSpecifiedAttributeName;
        [NativeTypeName("HRESULT (UINT32, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, BOOL*, int> GetSpecifiedAttributeNameLength;
        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RemoveAttribute;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetTextValue;
        [NativeTypeName("HRESULT (PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetTextValue;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetTextValueLength;
        [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgAttribute *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ID2D1SvgAttribute*, int> SetAttributeValue13;
        [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_POD_TYPE, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int> SetAttributeValue14;
        [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, int> SetAttributeValue15;
        [NativeTypeName("HRESULT (PCWSTR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, void**, int> GetAttributeValue13;
        [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_POD_TYPE, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D2D1_SVG_ATTRIBUTE_POD_TYPE, void*, uint, int> GetAttributeValue14;
        [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, PWSTR, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, ushort*, uint, int> GetAttributeValue15;
        [NativeTypeName("HRESULT (PCWSTR, D2D1_SVG_ATTRIBUTE_STRING_TYPE, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D2D1_SVG_ATTRIBUTE_STRING_TYPE, uint*, int> GetAttributeValueLength;
    }
}