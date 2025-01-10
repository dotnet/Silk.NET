// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F4AE-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLWindow3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLWindow3 : IHTMLWindow3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLWindow3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLWindow3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLWindow3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLWindow3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLWindow3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLWindow3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLWindow3, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLWindow3,
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
    public HRESULT get_screenLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow3, int*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_screenTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLWindow3, int*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT attachEvent(
        [NativeTypeName("BSTR")] ushort* @event,
        IDispatch pDisp,
        [NativeTypeName("VARIANT_BOOL *")] short* pfResult
    )
    {
        return ((delegate* unmanaged<IHTMLWindow3, ushort*, IDispatch, short*, int>)((*lpVtbl)[9]))(
            this,
            @event,
            pDisp,
            pfResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch pDisp)
    {
        return ((delegate* unmanaged<IHTMLWindow3, ushort*, IDispatch, int>)((*lpVtbl)[10]))(
            this,
            @event,
            pDisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT setTimeout(
        VARIANT* expression,
        [NativeTypeName("long")] int msec,
        VARIANT* language,
        [NativeTypeName("long *")] int* timerID
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow3, VARIANT*, int, VARIANT*, int*, int>)((*lpVtbl)[11])
        )(this, expression, msec, language, timerID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT setInterval(
        VARIANT* expression,
        [NativeTypeName("long")] int msec,
        VARIANT* language,
        [NativeTypeName("long *")] int* timerID
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow3, VARIANT*, int, VARIANT*, int*, int>)((*lpVtbl)[12])
        )(this, expression, msec, language, timerID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT print()
    {
        return ((delegate* unmanaged<IHTMLWindow3, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onbeforeprint(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow3, VARIANT, int>)((*lpVtbl)[14]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onbeforeprint(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow3, VARIANT*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onafterprint(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow3, VARIANT, int>)((*lpVtbl)[16]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onafterprint(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow3, VARIANT*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_clipboardData(IHTMLDataTransfer* p)
    {
        return ((delegate* unmanaged<IHTMLWindow3, IHTMLDataTransfer*, int>)((*lpVtbl)[18]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT showModelessDialog(
        [NativeTypeName("BSTR")] ushort* url,
        VARIANT* varArgIn,
        VARIANT* options,
        IHTMLWindow2* pDialog
    )
    {
        return (
            (delegate* unmanaged<IHTMLWindow3, ushort*, VARIANT*, VARIANT*, IHTMLWindow2*, int>)(
                (*lpVtbl)[19]
            )
        )(this, url, varArgIn, options, pDialog);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_screenLeft([NativeTypeName("long *")] int* p);

        [VtblIndex(8)]
        HRESULT get_screenTop([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT attachEvent(
            [NativeTypeName("BSTR")] ushort* @event,
            IDispatch pDisp,
            [NativeTypeName("VARIANT_BOOL *")] short* pfResult
        );

        [VtblIndex(10)]
        HRESULT detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch pDisp);

        [VtblIndex(11)]
        HRESULT setTimeout(
            VARIANT* expression,
            [NativeTypeName("long")] int msec,
            VARIANT* language,
            [NativeTypeName("long *")] int* timerID
        );

        [VtblIndex(12)]
        HRESULT setInterval(
            VARIANT* expression,
            [NativeTypeName("long")] int msec,
            VARIANT* language,
            [NativeTypeName("long *")] int* timerID
        );

        [VtblIndex(13)]
        HRESULT print();

        [VtblIndex(14)]
        HRESULT put_onbeforeprint(VARIANT v);

        [VtblIndex(15)]
        HRESULT get_onbeforeprint(VARIANT* p);

        [VtblIndex(16)]
        HRESULT put_onafterprint(VARIANT v);

        [VtblIndex(17)]
        HRESULT get_onafterprint(VARIANT* p);

        [VtblIndex(18)]
        HRESULT get_clipboardData(IHTMLDataTransfer* p);

        [VtblIndex(19)]
        HRESULT showModelessDialog(
            [NativeTypeName("BSTR")] ushort* url,
            VARIANT* varArgIn,
            VARIANT* options,
            IHTMLWindow2* pDialog
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
        public delegate* unmanaged<TSelf*, int*, int> get_screenLeft;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenTop;

        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch, short*, int> attachEvent;

        [NativeTypeName("HRESULT (BSTR, IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch, int> detachEvent;

        [NativeTypeName("HRESULT (VARIANT *, long, VARIANT *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int, VARIANT*, int*, int> setTimeout;

        [NativeTypeName("HRESULT (VARIANT *, long, VARIANT *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int, VARIANT*, int*, int> setInterval;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> print;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeprint;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeprint;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onafterprint;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onafterprint;

        [NativeTypeName("HRESULT (IHTMLDataTransfer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDataTransfer*, int> get_clipboardData;

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT *, VARIANT *, IHTMLWindow2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            VARIANT*,
            VARIANT*,
            IHTMLWindow2*,
            int> showModelessDialog;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLWindow3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLWindow3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLWindow3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLWindow3(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLWindow3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLWindow3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLWindow3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLWindow3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLWindow3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLWindow3(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLWindow3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLWindow3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLWindow3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLWindow3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
