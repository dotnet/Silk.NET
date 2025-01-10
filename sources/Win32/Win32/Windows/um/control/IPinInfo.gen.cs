// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868BD-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IPinInfo : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IPinInfo : IPinInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPinInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPinInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPinInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPinInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IPinInfo, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IPinInfo, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IPinInfo, Guid*, ushort**, uint, uint, int*, int>)((*lpVtbl)[5])
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
                IPinInfo,
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
    public HRESULT get_Pin(IUnknown* ppUnk)
    {
        return ((delegate* unmanaged<IPinInfo, IUnknown*, int>)((*lpVtbl)[7]))(this, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ConnectedTo(IDispatch* ppUnk)
    {
        return ((delegate* unmanaged<IPinInfo, IDispatch*, int>)((*lpVtbl)[8]))(this, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ConnectionMediaType(IDispatch* ppUnk)
    {
        return ((delegate* unmanaged<IPinInfo, IDispatch*, int>)((*lpVtbl)[9]))(this, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FilterInfo(IDispatch* ppUnk)
    {
        return ((delegate* unmanaged<IPinInfo, IDispatch*, int>)((*lpVtbl)[10]))(this, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** ppUnk)
    {
        return ((delegate* unmanaged<IPinInfo, ushort**, int>)((*lpVtbl)[11]))(this, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Direction([NativeTypeName("LONG *")] int* ppDirection)
    {
        return ((delegate* unmanaged<IPinInfo, int*, int>)((*lpVtbl)[12]))(this, ppDirection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PinID([NativeTypeName("BSTR *")] ushort** strPinID)
    {
        return ((delegate* unmanaged<IPinInfo, ushort**, int>)((*lpVtbl)[13]))(this, strPinID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_MediaTypes(IDispatch* ppUnk)
    {
        return ((delegate* unmanaged<IPinInfo, IDispatch*, int>)((*lpVtbl)[14]))(this, ppUnk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Connect(IUnknown pPin)
    {
        return ((delegate* unmanaged<IPinInfo, IUnknown, int>)((*lpVtbl)[15]))(this, pPin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ConnectDirect(IUnknown pPin)
    {
        return ((delegate* unmanaged<IPinInfo, IUnknown, int>)((*lpVtbl)[16]))(this, pPin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ConnectWithType(IUnknown pPin, IDispatch pMediaType)
    {
        return ((delegate* unmanaged<IPinInfo, IUnknown, IDispatch, int>)((*lpVtbl)[17]))(
            this,
            pPin,
            pMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IPinInfo, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Render()
    {
        return ((delegate* unmanaged<IPinInfo, int>)((*lpVtbl)[19]))(this);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Pin(IUnknown* ppUnk);

        [VtblIndex(8)]
        HRESULT get_ConnectedTo(IDispatch* ppUnk);

        [VtblIndex(9)]
        HRESULT get_ConnectionMediaType(IDispatch* ppUnk);

        [VtblIndex(10)]
        HRESULT get_FilterInfo(IDispatch* ppUnk);

        [VtblIndex(11)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** ppUnk);

        [VtblIndex(12)]
        HRESULT get_Direction([NativeTypeName("LONG *")] int* ppDirection);

        [VtblIndex(13)]
        HRESULT get_PinID([NativeTypeName("BSTR *")] ushort** strPinID);

        [VtblIndex(14)]
        HRESULT get_MediaTypes(IDispatch* ppUnk);

        [VtblIndex(15)]
        HRESULT Connect(IUnknown pPin);

        [VtblIndex(16)]
        HRESULT ConnectDirect(IUnknown pPin);

        [VtblIndex(17)]
        HRESULT ConnectWithType(IUnknown pPin, IDispatch pMediaType);

        [VtblIndex(18)]
        HRESULT Disconnect();

        [VtblIndex(19)]
        HRESULT Render();
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_Pin;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_ConnectedTo;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_ConnectionMediaType;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_FilterInfo;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Direction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_PinID;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_MediaTypes;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> Connect;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> ConnectDirect;

        [NativeTypeName("HRESULT (IUnknown *, IDispatch *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IDispatch, int> ConnectWithType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Render;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPinInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPinInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IPinInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IPinInfo(Silk.NET.Windows.IDispatch value)
    {
        return new IPinInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPinInfo"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IPinInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IPinInfo value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPinInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPinInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IPinInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPinInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPinInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPinInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
