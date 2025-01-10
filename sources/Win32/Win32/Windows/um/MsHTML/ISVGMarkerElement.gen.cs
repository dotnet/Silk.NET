// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510525-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGMarkerElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGMarkerElement : ISVGMarkerElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGMarkerElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISVGMarkerElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGMarkerElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISVGMarkerElement, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISVGMarkerElement, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISVGMarkerElement,
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
    public HRESULT putref_refX(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength, int>)((*lpVtbl)[7]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_refX(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength*, int>)((*lpVtbl)[8]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_refY(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength, int>)((*lpVtbl)[9]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_refY(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength*, int>)((*lpVtbl)[10]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_markerUnits(ISVGAnimatedEnumeration v)
    {
        return (
            (delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedEnumeration, int>)((*lpVtbl)[11])
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_markerUnits(ISVGAnimatedEnumeration* p)
    {
        return (
            (delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedEnumeration*, int>)((*lpVtbl)[12])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_markerWidth(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength, int>)((*lpVtbl)[13]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_markerWidth(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength*, int>)((*lpVtbl)[14]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT putref_markerHeight(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength, int>)((*lpVtbl)[15]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_markerHeight(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedLength*, int>)((*lpVtbl)[16]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT putref_orientType(ISVGAnimatedEnumeration v)
    {
        return (
            (delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedEnumeration, int>)((*lpVtbl)[17])
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_orientType(ISVGAnimatedEnumeration* p)
    {
        return (
            (delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedEnumeration*, int>)((*lpVtbl)[18])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT putref_orientAngle(ISVGAnimatedAngle v)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedAngle, int>)((*lpVtbl)[19]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_orientAngle(ISVGAnimatedAngle* p)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAnimatedAngle*, int>)((*lpVtbl)[20]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT setOrientToAuto()
    {
        return ((delegate* unmanaged<ISVGMarkerElement, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT setOrientToAngle(ISVGAngle pSVGAngle)
    {
        return ((delegate* unmanaged<ISVGMarkerElement, ISVGAngle, int>)((*lpVtbl)[22]))(
            this,
            pSVGAngle
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_refX(ISVGAnimatedLength v);

        [VtblIndex(8)]
        HRESULT get_refX(ISVGAnimatedLength* p);

        [VtblIndex(9)]
        HRESULT putref_refY(ISVGAnimatedLength v);

        [VtblIndex(10)]
        HRESULT get_refY(ISVGAnimatedLength* p);

        [VtblIndex(11)]
        HRESULT putref_markerUnits(ISVGAnimatedEnumeration v);

        [VtblIndex(12)]
        HRESULT get_markerUnits(ISVGAnimatedEnumeration* p);

        [VtblIndex(13)]
        HRESULT putref_markerWidth(ISVGAnimatedLength v);

        [VtblIndex(14)]
        HRESULT get_markerWidth(ISVGAnimatedLength* p);

        [VtblIndex(15)]
        HRESULT putref_markerHeight(ISVGAnimatedLength v);

        [VtblIndex(16)]
        HRESULT get_markerHeight(ISVGAnimatedLength* p);

        [VtblIndex(17)]
        HRESULT putref_orientType(ISVGAnimatedEnumeration v);

        [VtblIndex(18)]
        HRESULT get_orientType(ISVGAnimatedEnumeration* p);

        [VtblIndex(19)]
        HRESULT putref_orientAngle(ISVGAnimatedAngle v);

        [VtblIndex(20)]
        HRESULT get_orientAngle(ISVGAnimatedAngle* p);

        [VtblIndex(21)]
        HRESULT setOrientToAuto();

        [VtblIndex(22)]
        HRESULT setOrientToAngle(ISVGAngle pSVGAngle);
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

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_refX;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_refX;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_refY;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_refY;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration, int> putref_markerUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> get_markerUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_markerWidth;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_markerWidth;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_markerHeight;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_markerHeight;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration, int> putref_orientType;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> get_orientType;

        [NativeTypeName("HRESULT (ISVGAnimatedAngle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedAngle, int> putref_orientAngle;

        [NativeTypeName("HRESULT (ISVGAnimatedAngle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedAngle*, int> get_orientAngle;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> setOrientToAuto;

        [NativeTypeName("HRESULT (ISVGAngle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAngle, int> setOrientToAngle;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGMarkerElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGMarkerElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGMarkerElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGMarkerElement(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGMarkerElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGMarkerElement"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGMarkerElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGMarkerElement value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGMarkerElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGMarkerElement(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGMarkerElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGMarkerElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGMarkerElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGMarkerElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
