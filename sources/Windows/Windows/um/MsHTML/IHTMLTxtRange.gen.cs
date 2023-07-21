// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange"]/*' />
[Guid("3050F220-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTxtRange : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTxtRange : IHTMLTxtRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTxtRange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, uint>)(lpVtbl[1]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, uint>)(lpVtbl[2]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, uint*, int>)(lpVtbl[3]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.get_htmlText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_htmlText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort**, int>)(lpVtbl[7]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.put_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int>)(lpVtbl[8]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.get_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort**, int>)(lpVtbl[9]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.parentElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT parentElement(IHTMLElement** parent)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), parent);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.duplicate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT duplicate(IHTMLTxtRange** Duplicate)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLTxtRange**, int>)(lpVtbl[11]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Duplicate);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.inRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT inRange(IHTMLTxtRange* Range, [NativeTypeName("VARIANT_BOOL *")] short* InRange)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLTxtRange*, short*, int>)(lpVtbl[12]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Range, InRange);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.isEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT isEqual(IHTMLTxtRange* Range, [NativeTypeName("VARIANT_BOOL *")] short* IsEqual)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLTxtRange*, short*, int>)(lpVtbl[13]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Range, IsEqual);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.scrollIntoView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT scrollIntoView([NativeTypeName("VARIANT_BOOL")] short fStart = -1)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, short, int>)(lpVtbl[14]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), fStart);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.collapse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT collapse([NativeTypeName("VARIANT_BOOL")] short Start = -1)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, short, int>)(lpVtbl[15]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Start);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.expand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT expand([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("VARIANT_BOOL *")] short* Success)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[16]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Success);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.move"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT move([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int*, int>)(lpVtbl[17]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Count, ActualCount);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.moveStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT moveStart([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int*, int>)(lpVtbl[18]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Count, ActualCount);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.moveEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT moveEnd([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int*, int>)(lpVtbl[19]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Unit, Count, ActualCount);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.select"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT select()
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, int>)(lpVtbl[20]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.pasteHTML"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT pasteHTML([NativeTypeName("BSTR")] ushort* html)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int>)(lpVtbl[21]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), html);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.moveToElementText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT moveToElementText(IHTMLElement* element)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, IHTMLElement*, int>)(lpVtbl[22]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), element);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.setEndPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT setEndPoint([NativeTypeName("BSTR")] ushort* how, IHTMLTxtRange* SourceRange)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, IHTMLTxtRange*, int>)(lpVtbl[23]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), how, SourceRange);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.compareEndPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT compareEndPoints([NativeTypeName("BSTR")] ushort* how, IHTMLTxtRange* SourceRange, [NativeTypeName("long *")] int* ret)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, IHTMLTxtRange*, int*, int>)(lpVtbl[24]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), how, SourceRange, ret);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.findText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT findText([NativeTypeName("BSTR")] ushort* String, [NativeTypeName("long")] int count, [NativeTypeName("long")] int Flags, [NativeTypeName("VARIANT_BOOL *")] short* Success)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, int, int, short*, int>)(lpVtbl[25]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), String, count, Flags, Success);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.moveToPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT moveToPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, int, int, int>)(lpVtbl[26]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), x, y);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.getBookmark"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT getBookmark([NativeTypeName("BSTR *")] ushort** Boolmark)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort**, int>)(lpVtbl[27]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Boolmark);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.moveToBookmark"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT moveToBookmark([NativeTypeName("BSTR")] ushort* Bookmark, [NativeTypeName("VARIANT_BOOL *")] short* Success)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[28]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), Bookmark, Success);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.queryCommandSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[29]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.queryCommandEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[30]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.queryCommandState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[31]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.queryCommandIndeterm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[32]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.queryCommandText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, ushort**, int>)(lpVtbl[33]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.queryCommandValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, VARIANT*, int>)(lpVtbl[34]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.execCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short, VARIANT, short*, int>)(lpVtbl[35]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
    }

    /// <include file='IHTMLTxtRange.xml' path='doc/member[@name="IHTMLTxtRange.execCommandShowHelp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged<IHTMLTxtRange*, ushort*, short*, int>)(lpVtbl[36]))((IHTMLTxtRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_htmlText([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT put_text([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(9)]
        HRESULT get_text([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT parentElement(IHTMLElement** parent);

        [VtblIndex(11)]
        HRESULT duplicate(IHTMLTxtRange** Duplicate);

        [VtblIndex(12)]
        HRESULT inRange(IHTMLTxtRange* Range, [NativeTypeName("VARIANT_BOOL *")] short* InRange);

        [VtblIndex(13)]
        HRESULT isEqual(IHTMLTxtRange* Range, [NativeTypeName("VARIANT_BOOL *")] short* IsEqual);

        [VtblIndex(14)]
        HRESULT scrollIntoView([NativeTypeName("VARIANT_BOOL")] short fStart = -1);

        [VtblIndex(15)]
        HRESULT collapse([NativeTypeName("VARIANT_BOOL")] short Start = -1);

        [VtblIndex(16)]
        HRESULT expand([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("VARIANT_BOOL *")] short* Success);

        [VtblIndex(17)]
        HRESULT move([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount);

        [VtblIndex(18)]
        HRESULT moveStart([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount);

        [VtblIndex(19)]
        HRESULT moveEnd([NativeTypeName("BSTR")] ushort* Unit, [NativeTypeName("long")] int Count, [NativeTypeName("long *")] int* ActualCount);

        [VtblIndex(20)]
        HRESULT select();

        [VtblIndex(21)]
        HRESULT pasteHTML([NativeTypeName("BSTR")] ushort* html);

        [VtblIndex(22)]
        HRESULT moveToElementText(IHTMLElement* element);

        [VtblIndex(23)]
        HRESULT setEndPoint([NativeTypeName("BSTR")] ushort* how, IHTMLTxtRange* SourceRange);

        [VtblIndex(24)]
        HRESULT compareEndPoints([NativeTypeName("BSTR")] ushort* how, IHTMLTxtRange* SourceRange, [NativeTypeName("long *")] int* ret);

        [VtblIndex(25)]
        HRESULT findText([NativeTypeName("BSTR")] ushort* String, [NativeTypeName("long")] int count, [NativeTypeName("long")] int Flags, [NativeTypeName("VARIANT_BOOL *")] short* Success);

        [VtblIndex(26)]
        HRESULT moveToPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y);

        [VtblIndex(27)]
        HRESULT getBookmark([NativeTypeName("BSTR *")] ushort** Boolmark);

        [VtblIndex(28)]
        HRESULT moveToBookmark([NativeTypeName("BSTR")] ushort* Bookmark, [NativeTypeName("VARIANT_BOOL *")] short* Success);

        [VtblIndex(29)]
        HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(30)]
        HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(31)]
        HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(32)]
        HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(33)]
        HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText);

        [VtblIndex(34)]
        HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue);

        [VtblIndex(35)]
        HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(36)]
        HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_htmlText;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> parentElement;

        [NativeTypeName("HRESULT (IHTMLTxtRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange**, int> duplicate;

        [NativeTypeName("HRESULT (IHTMLTxtRange *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange*, short*, int> inRange;

        [NativeTypeName("HRESULT (IHTMLTxtRange *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange*, short*, int> isEqual;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> scrollIntoView;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> collapse;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> expand;

        [NativeTypeName("HRESULT (BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> move;

        [NativeTypeName("HRESULT (BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> moveStart;

        [NativeTypeName("HRESULT (BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> moveEnd;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> select;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> pasteHTML;

        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> moveToElementText;

        [NativeTypeName("HRESULT (BSTR, IHTMLTxtRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLTxtRange*, int> setEndPoint;

        [NativeTypeName("HRESULT (BSTR, IHTMLTxtRange *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLTxtRange*, int*, int> compareEndPoints;

        [NativeTypeName("HRESULT (BSTR, long, long, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int, short*, int> findText;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> moveToPoint;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> getBookmark;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> moveToBookmark;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandSupported;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandEnabled;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandState;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandIndeterm;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> queryCommandText;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> queryCommandValue;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, VARIANT, short*, int> execCommand;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> execCommandShowHelp;
    }
}
