// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051040A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLXMLHttpRequest : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLXMLHttpRequest : IHTMLXMLHttpRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLXMLHttpRequest));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLXMLHttpRequest, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IHTMLXMLHttpRequest, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLXMLHttpRequest,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, int*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_responseBody(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, VARIANT*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, ushort**, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_responseXML(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, IDispatch*, int>)((*lpVtbl)[10]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_status([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, int*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, ushort**, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onreadystatechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, VARIANT, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onreadystatechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, VARIANT*, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT abort()
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT open(
        [NativeTypeName("BSTR")] ushort* bstrMethod,
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        VARIANT varAsync,
        VARIANT varUser,
        VARIANT varPassword
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLXMLHttpRequest,
                ushort*,
                ushort*,
                VARIANT,
                VARIANT,
                VARIANT,
                int>)((*lpVtbl)[16])
        )(this, bstrMethod, bstrUrl, varAsync, varUser, varPassword);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT send(VARIANT varBody)
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, VARIANT, int>)((*lpVtbl)[17]))(
            this,
            varBody
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT getAllResponseHeaders(
        [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0000
    )
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, ushort**, int>)((*lpVtbl)[18]))(
            this,
            __MIDL__IHTMLXMLHttpRequest0000
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT getResponseHeader(
        [NativeTypeName("BSTR")] ushort* bstrHeader,
        [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0001
    )
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, ushort*, ushort**, int>)((*lpVtbl)[19]))(
            this,
            bstrHeader,
            __MIDL__IHTMLXMLHttpRequest0001
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT setRequestHeader(
        [NativeTypeName("BSTR")] ushort* bstrHeader,
        [NativeTypeName("BSTR")] ushort* bstrValue
    )
    {
        return ((delegate* unmanaged<IHTMLXMLHttpRequest, ushort*, ushort*, int>)((*lpVtbl)[20]))(
            this,
            bstrHeader,
            bstrValue
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_readyState([NativeTypeName("long *")] int* p);

        [VtblIndex(8)]
        HRESULT get_responseBody(VARIANT* p);

        [VtblIndex(9)]
        HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_responseXML(IDispatch* p);

        [VtblIndex(11)]
        HRESULT get_status([NativeTypeName("long *")] int* p);

        [VtblIndex(12)]
        HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_onreadystatechange(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_onreadystatechange(VARIANT* p);

        [VtblIndex(15)]
        HRESULT abort();

        [VtblIndex(16)]
        HRESULT open(
            [NativeTypeName("BSTR")] ushort* bstrMethod,
            [NativeTypeName("BSTR")] ushort* bstrUrl,
            VARIANT varAsync,
            VARIANT varUser,
            VARIANT varPassword
        );

        [VtblIndex(17)]
        HRESULT send(VARIANT varBody);

        [VtblIndex(18)]
        HRESULT getAllResponseHeaders(
            [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0000
        );

        [VtblIndex(19)]
        HRESULT getResponseHeader(
            [NativeTypeName("BSTR")] ushort* bstrHeader,
            [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0001
        );

        [VtblIndex(20)]
        HRESULT setRequestHeader(
            [NativeTypeName("BSTR")] ushort* bstrHeader,
            [NativeTypeName("BSTR")] ushort* bstrValue
        );
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_responseBody;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_responseText;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_responseXML;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_status;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_statusText;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onreadystatechange;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> abort;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int> open;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> send;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> getAllResponseHeaders;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> getResponseHeader;

        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> setRequestHeader;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLXMLHttpRequest"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLXMLHttpRequest(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLXMLHttpRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLXMLHttpRequest(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLXMLHttpRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLXMLHttpRequest"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLXMLHttpRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLXMLHttpRequest value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLXMLHttpRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLXMLHttpRequest(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLXMLHttpRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLXMLHttpRequest"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLXMLHttpRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLXMLHttpRequest value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
