// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable"]/*'/>
[Guid("3050F21E-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTable : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTable : IHTMLTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTable));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTable*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTable*, uint> )(lpVtbl[1]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTable*, uint> )(lpVtbl[2]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTable*, uint*, int> )(lpVtbl[3]))((IHTMLTable*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTable*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTable*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTable*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTable*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTable*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTable*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_cols"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_cols([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTable*, int, int> )(lpVtbl[7]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_cols"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_cols([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, int*, int> )(lpVtbl[8]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_border(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[9]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_border(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[10]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_frame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_frame([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort*, int> )(lpVtbl[11]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_frame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_frame([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort**, int> )(lpVtbl[12]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_rules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_rules([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort*, int> )(lpVtbl[13]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_rules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_rules([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort**, int> )(lpVtbl[14]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_cellSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_cellSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[15]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_cellSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_cellSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[16]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_cellPadding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_cellPadding(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[17]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_cellPadding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_cellPadding(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[18]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_background"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort*, int> )(lpVtbl[19]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_background"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort**, int> )(lpVtbl[20]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[21]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[22]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_borderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_borderColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[23]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_borderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_borderColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[24]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_borderColorLight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_borderColorLight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[25]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_borderColorLight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_borderColorLight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[26]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_borderColorDark"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_borderColorDark(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[27]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_borderColorDark"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_borderColorDark(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[28]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort*, int> )(lpVtbl[29]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort**, int> )(lpVtbl[30]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.refresh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT refresh()
    {
        return ((delegate* unmanaged<IHTMLTable*, int> )(lpVtbl[31]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_rows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_rows(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, IHTMLElementCollection**, int> )(lpVtbl[32]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[33]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[34]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[35]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[36]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_dataPageSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_dataPageSize([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTable*, int, int> )(lpVtbl[37]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_dataPageSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_dataPageSize([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, int*, int> )(lpVtbl[38]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.nextPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT nextPage()
    {
        return ((delegate* unmanaged<IHTMLTable*, int> )(lpVtbl[39]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.previousPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT previousPage()
    {
        return ((delegate* unmanaged<IHTMLTable*, int> )(lpVtbl[40]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_tHead"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_tHead(IHTMLTableSection** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, IHTMLTableSection**, int> )(lpVtbl[41]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_tFoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_tFoot(IHTMLTableSection** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, IHTMLTableSection**, int> )(lpVtbl[42]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_tBodies"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_tBodies(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, IHTMLElementCollection**, int> )(lpVtbl[43]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_caption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_caption(IHTMLTableCaption** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, IHTMLTableCaption**, int> )(lpVtbl[44]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.createTHead"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT createTHead(IDispatch** head)
    {
        return ((delegate* unmanaged<IHTMLTable*, IDispatch**, int> )(lpVtbl[45]))((IHTMLTable*)Unsafe.AsPointer(ref this), head);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.deleteTHead"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT deleteTHead()
    {
        return ((delegate* unmanaged<IHTMLTable*, int> )(lpVtbl[46]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.createTFoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT createTFoot(IDispatch** foot)
    {
        return ((delegate* unmanaged<IHTMLTable*, IDispatch**, int> )(lpVtbl[47]))((IHTMLTable*)Unsafe.AsPointer(ref this), foot);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.deleteTFoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT deleteTFoot()
    {
        return ((delegate* unmanaged<IHTMLTable*, int> )(lpVtbl[48]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.createCaption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT createCaption(IHTMLTableCaption** caption)
    {
        return ((delegate* unmanaged<IHTMLTable*, IHTMLTableCaption**, int> )(lpVtbl[49]))((IHTMLTable*)Unsafe.AsPointer(ref this), caption);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.deleteCaption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT deleteCaption()
    {
        return ((delegate* unmanaged<IHTMLTable*, int> )(lpVtbl[50]))((IHTMLTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.insertRow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row)
    {
        return ((delegate* unmanaged<IHTMLTable*, int, IDispatch**, int> )(lpVtbl[51]))((IHTMLTable*)Unsafe.AsPointer(ref this), index, row);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.deleteRow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT deleteRow([NativeTypeName("long")] int index = -1)
    {
        return ((delegate* unmanaged<IHTMLTable*, int, int> )(lpVtbl[52]))((IHTMLTable*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTable*, ushort**, int> )(lpVtbl[53]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.put_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT, int> )(lpVtbl[54]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTable.xml' path='doc/member[@name="IHTMLTable.get_onreadystatechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int> )(lpVtbl[55]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_cols([NativeTypeName("long")] int v);
        [VtblIndex(8)]
        HRESULT get_cols([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT put_border(VARIANT v);
        [VtblIndex(10)]
        HRESULT get_border(VARIANT* p);
        [VtblIndex(11)]
        HRESULT put_frame([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_frame([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_rules([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_rules([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_cellSpacing(VARIANT v);
        [VtblIndex(16)]
        HRESULT get_cellSpacing(VARIANT* p);
        [VtblIndex(17)]
        HRESULT put_cellPadding(VARIANT v);
        [VtblIndex(18)]
        HRESULT get_cellPadding(VARIANT* p);
        [VtblIndex(19)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(20)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(21)]
        HRESULT put_bgColor(VARIANT v);
        [VtblIndex(22)]
        HRESULT get_bgColor(VARIANT* p);
        [VtblIndex(23)]
        HRESULT put_borderColor(VARIANT v);
        [VtblIndex(24)]
        HRESULT get_borderColor(VARIANT* p);
        [VtblIndex(25)]
        HRESULT put_borderColorLight(VARIANT v);
        [VtblIndex(26)]
        HRESULT get_borderColorLight(VARIANT* p);
        [VtblIndex(27)]
        HRESULT put_borderColorDark(VARIANT v);
        [VtblIndex(28)]
        HRESULT get_borderColorDark(VARIANT* p);
        [VtblIndex(29)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(30)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(31)]
        HRESULT refresh();
        [VtblIndex(32)]
        HRESULT get_rows(IHTMLElementCollection** p);
        [VtblIndex(33)]
        HRESULT put_width(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_width(VARIANT* p);
        [VtblIndex(35)]
        HRESULT put_height(VARIANT v);
        [VtblIndex(36)]
        HRESULT get_height(VARIANT* p);
        [VtblIndex(37)]
        HRESULT put_dataPageSize([NativeTypeName("long")] int v);
        [VtblIndex(38)]
        HRESULT get_dataPageSize([NativeTypeName("long *")] int* p);
        [VtblIndex(39)]
        HRESULT nextPage();
        [VtblIndex(40)]
        HRESULT previousPage();
        [VtblIndex(41)]
        HRESULT get_tHead(IHTMLTableSection** p);
        [VtblIndex(42)]
        HRESULT get_tFoot(IHTMLTableSection** p);
        [VtblIndex(43)]
        HRESULT get_tBodies(IHTMLElementCollection** p);
        [VtblIndex(44)]
        HRESULT get_caption(IHTMLTableCaption** p);
        [VtblIndex(45)]
        HRESULT createTHead(IDispatch** head);
        [VtblIndex(46)]
        HRESULT deleteTHead();
        [VtblIndex(47)]
        HRESULT createTFoot(IDispatch** foot);
        [VtblIndex(48)]
        HRESULT deleteTFoot();
        [VtblIndex(49)]
        HRESULT createCaption(IHTMLTableCaption** caption);
        [VtblIndex(50)]
        HRESULT deleteCaption();
        [VtblIndex(51)]
        HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row);
        [VtblIndex(52)]
        HRESULT deleteRow([NativeTypeName("long")] int index = -1);
        [VtblIndex(53)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(54)]
        HRESULT put_onreadystatechange(VARIANT v);
        [VtblIndex(55)]
        HRESULT get_onreadystatechange(VARIANT* p);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_cols;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_cols;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_border;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_border;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_frame;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_frame;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rules;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rules;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_cellSpacing;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_cellSpacing;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_cellPadding;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_cellPadding;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorLight;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorLight;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorDark;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorDark;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> refresh;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_rows;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_dataPageSize;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_dataPageSize;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> nextPage;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> previousPage;
        [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableSection**, int> get_tHead;
        [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableSection**, int> get_tFoot;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_tBodies;
        [NativeTypeName("HRESULT (IHTMLTableCaption **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableCaption**, int> get_caption;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> createTHead;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteTHead;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> createTFoot;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteTFoot;
        [NativeTypeName("HRESULT (IHTMLTableCaption **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTableCaption**, int> createCaption;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deleteCaption;
        [NativeTypeName("HRESULT (long, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IDispatch**, int> insertRow;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> deleteRow;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;
    }
}