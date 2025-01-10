// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051052C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGPatternElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGPatternElement : ISVGPatternElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGPatternElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGPatternElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISVGPatternElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGPatternElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGPatternElement, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISVGPatternElement, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISVGPatternElement,
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
    public HRESULT putref_patternUnits(ISVGAnimatedEnumeration v)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, ISVGAnimatedEnumeration, int>)((*lpVtbl)[7])
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_patternUnits(ISVGAnimatedEnumeration* p)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, ISVGAnimatedEnumeration*, int>)((*lpVtbl)[8])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_patternContentUnits(ISVGAnimatedEnumeration v)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, ISVGAnimatedEnumeration, int>)((*lpVtbl)[9])
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_patternContentUnits(ISVGAnimatedEnumeration* p)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, ISVGAnimatedEnumeration*, int>)((*lpVtbl)[10])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_patternTransform(ISVGAnimatedTransformList v)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, ISVGAnimatedTransformList, int>)((*lpVtbl)[11])
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_patternTransform(ISVGAnimatedTransformList* p)
    {
        return (
            (delegate* unmanaged<ISVGPatternElement, ISVGAnimatedTransformList*, int>)(
                (*lpVtbl)[12]
            )
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_x(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength, int>)((*lpVtbl)[13]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_x(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength*, int>)((*lpVtbl)[14]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT putref_y(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength, int>)((*lpVtbl)[15]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_y(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength*, int>)((*lpVtbl)[16]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT putref_width(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength, int>)((*lpVtbl)[17]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_width(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength*, int>)((*lpVtbl)[18]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT putref_height(ISVGAnimatedLength v)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength, int>)((*lpVtbl)[19]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_height(ISVGAnimatedLength* p)
    {
        return ((delegate* unmanaged<ISVGPatternElement, ISVGAnimatedLength*, int>)((*lpVtbl)[20]))(
            this,
            p
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_patternUnits(ISVGAnimatedEnumeration v);

        [VtblIndex(8)]
        HRESULT get_patternUnits(ISVGAnimatedEnumeration* p);

        [VtblIndex(9)]
        HRESULT putref_patternContentUnits(ISVGAnimatedEnumeration v);

        [VtblIndex(10)]
        HRESULT get_patternContentUnits(ISVGAnimatedEnumeration* p);

        [VtblIndex(11)]
        HRESULT putref_patternTransform(ISVGAnimatedTransformList v);

        [VtblIndex(12)]
        HRESULT get_patternTransform(ISVGAnimatedTransformList* p);

        [VtblIndex(13)]
        HRESULT putref_x(ISVGAnimatedLength v);

        [VtblIndex(14)]
        HRESULT get_x(ISVGAnimatedLength* p);

        [VtblIndex(15)]
        HRESULT putref_y(ISVGAnimatedLength v);

        [VtblIndex(16)]
        HRESULT get_y(ISVGAnimatedLength* p);

        [VtblIndex(17)]
        HRESULT putref_width(ISVGAnimatedLength v);

        [VtblIndex(18)]
        HRESULT get_width(ISVGAnimatedLength* p);

        [VtblIndex(19)]
        HRESULT putref_height(ISVGAnimatedLength v);

        [VtblIndex(20)]
        HRESULT get_height(ISVGAnimatedLength* p);
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

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration, int> putref_patternUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> get_patternUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration, int> putref_patternContentUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> get_patternContentUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedTransformList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedTransformList, int> putref_patternTransform;

        [NativeTypeName("HRESULT (ISVGAnimatedTransformList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedTransformList*, int> get_patternTransform;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_width;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_width;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_height;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_height;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGPatternElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGPatternElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGPatternElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGPatternElement(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGPatternElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGPatternElement"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGPatternElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGPatternElement value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGPatternElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGPatternElement(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGPatternElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGPatternElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGPatternElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGPatternElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
