// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError"]/*' />
[Guid("3EFAA426-272F-11D2-836F-0000F87A7782")]
[NativeTypeName("struct IXMLDOMParseError : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLDOMParseError : IXMLDOMParseError.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMParseError));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, uint>)(lpVtbl[1]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, uint>)(lpVtbl[2]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, uint*, int>)(lpVtbl[3]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_errorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_errorCode([NativeTypeName("long *")] int* errorCode)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[7]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), errorCode);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_url"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_url([NativeTypeName("BSTR *")] ushort** urlString)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, ushort**, int>)(lpVtbl[8]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), urlString);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_reason([NativeTypeName("BSTR *")] ushort** reasonString)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, ushort**, int>)(lpVtbl[9]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), reasonString);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_srcText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_srcText([NativeTypeName("BSTR *")] ushort** sourceString)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, ushort**, int>)(lpVtbl[10]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), sourceString);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_line"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_line([NativeTypeName("long *")] int* lineNumber)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[11]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), lineNumber);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_linepos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_linepos([NativeTypeName("long *")] int* linePosition)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[12]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), linePosition);
    }

    /// <include file='IXMLDOMParseError.xml' path='doc/member[@name="IXMLDOMParseError.get_filepos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_filepos([NativeTypeName("long *")] int* filePosition)
    {
        return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[13]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), filePosition);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_errorCode([NativeTypeName("long *")] int* errorCode);

        [VtblIndex(8)]
        HRESULT get_url([NativeTypeName("BSTR *")] ushort** urlString);

        [VtblIndex(9)]
        HRESULT get_reason([NativeTypeName("BSTR *")] ushort** reasonString);

        [VtblIndex(10)]
        HRESULT get_srcText([NativeTypeName("BSTR *")] ushort** sourceString);

        [VtblIndex(11)]
        HRESULT get_line([NativeTypeName("long *")] int* lineNumber);

        [VtblIndex(12)]
        HRESULT get_linepos([NativeTypeName("long *")] int* linePosition);

        [VtblIndex(13)]
        HRESULT get_filepos([NativeTypeName("long *")] int* filePosition);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_errorCode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_url;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_reason;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_srcText;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_line;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_linepos;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_filepos;
    }
}
