// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("ED8C108D-4349-11D2-91A4-00C04F7969E8")]
[NativeTypeName("struct IXMLHttpRequest : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLHttpRequest : IXMLHttpRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLHttpRequest));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXMLHttpRequest, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLHttpRequest, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
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
            (delegate* unmanaged<IXMLHttpRequest, Guid*, ushort**, uint, uint, int*, int>)(
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
                IXMLHttpRequest,
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
    public HRESULT open(
        [NativeTypeName("BSTR")] ushort* bstrMethod,
        [NativeTypeName("BSTR")] ushort* bstrUrl,
        VARIANT varAsync,
        VARIANT bstrUser,
        VARIANT bstrPassword
    )
    {
        return (
            (delegate* unmanaged<
                IXMLHttpRequest,
                ushort*,
                ushort*,
                VARIANT,
                VARIANT,
                VARIANT,
                int>)((*lpVtbl)[7])
        )(this, bstrMethod, bstrUrl, varAsync, bstrUser, bstrPassword);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setRequestHeader(
        [NativeTypeName("BSTR")] ushort* bstrHeader,
        [NativeTypeName("BSTR")] ushort* bstrValue
    )
    {
        return ((delegate* unmanaged<IXMLHttpRequest, ushort*, ushort*, int>)((*lpVtbl)[8]))(
            this,
            bstrHeader,
            bstrValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT getResponseHeader(
        [NativeTypeName("BSTR")] ushort* bstrHeader,
        [NativeTypeName("BSTR *")] ushort** pbstrValue
    )
    {
        return ((delegate* unmanaged<IXMLHttpRequest, ushort*, ushort**, int>)((*lpVtbl)[9]))(
            this,
            bstrHeader,
            pbstrValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** pbstrHeaders)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, ushort**, int>)((*lpVtbl)[10]))(
            this,
            pbstrHeaders
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT send(VARIANT varBody)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, VARIANT, int>)((*lpVtbl)[11]))(this, varBody);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT abort()
    {
        return ((delegate* unmanaged<IXMLHttpRequest, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_status([NativeTypeName("long *")] int* plStatus)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, int*, int>)((*lpVtbl)[13]))(this, plStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** pbstrStatus)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, ushort**, int>)((*lpVtbl)[14]))(
            this,
            pbstrStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_responseXML(IDispatch* ppBody)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, IDispatch*, int>)((*lpVtbl)[15]))(
            this,
            ppBody
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** pbstrBody)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, ushort**, int>)((*lpVtbl)[16]))(
            this,
            pbstrBody
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_responseBody(VARIANT* pvarBody)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, VARIANT*, int>)((*lpVtbl)[17]))(
            this,
            pvarBody
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_responseStream(VARIANT* pvarBody)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, VARIANT*, int>)((*lpVtbl)[18]))(
            this,
            pvarBody
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* plState)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, int*, int>)((*lpVtbl)[19]))(this, plState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_onreadystatechange(IDispatch pReadyStateSink)
    {
        return ((delegate* unmanaged<IXMLHttpRequest, IDispatch, int>)((*lpVtbl)[20]))(
            this,
            pReadyStateSink
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT open(
            [NativeTypeName("BSTR")] ushort* bstrMethod,
            [NativeTypeName("BSTR")] ushort* bstrUrl,
            VARIANT varAsync,
            VARIANT bstrUser,
            VARIANT bstrPassword
        );

        [VtblIndex(8)]
        HRESULT setRequestHeader(
            [NativeTypeName("BSTR")] ushort* bstrHeader,
            [NativeTypeName("BSTR")] ushort* bstrValue
        );

        [VtblIndex(9)]
        HRESULT getResponseHeader(
            [NativeTypeName("BSTR")] ushort* bstrHeader,
            [NativeTypeName("BSTR *")] ushort** pbstrValue
        );

        [VtblIndex(10)]
        HRESULT getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** pbstrHeaders);

        [VtblIndex(11)]
        HRESULT send(VARIANT varBody);

        [VtblIndex(12)]
        HRESULT abort();

        [VtblIndex(13)]
        HRESULT get_status([NativeTypeName("long *")] int* plStatus);

        [VtblIndex(14)]
        HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** pbstrStatus);

        [VtblIndex(15)]
        HRESULT get_responseXML(IDispatch* ppBody);

        [VtblIndex(16)]
        HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** pbstrBody);

        [VtblIndex(17)]
        HRESULT get_responseBody(VARIANT* pvarBody);

        [VtblIndex(18)]
        HRESULT get_responseStream(VARIANT* pvarBody);

        [VtblIndex(19)]
        HRESULT get_readyState([NativeTypeName("long *")] int* plState);

        [VtblIndex(20)]
        HRESULT put_onreadystatechange(IDispatch pReadyStateSink);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int> open;

        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> setRequestHeader;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> getResponseHeader;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> getAllResponseHeaders;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> send;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> abort;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_status;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_statusText;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_responseXML;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_responseText;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_responseBody;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_responseStream;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;

        [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int> put_onreadystatechange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXMLHttpRequest"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXMLHttpRequest(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IXMLHttpRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IXMLHttpRequest(Silk.NET.Windows.IDispatch value)
    {
        return new IXMLHttpRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLHttpRequest"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLHttpRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IXMLHttpRequest value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXMLHttpRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXMLHttpRequest(Silk.NET.Windows.IUnknown value)
    {
        return new IXMLHttpRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLHttpRequest"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLHttpRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXMLHttpRequest value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
