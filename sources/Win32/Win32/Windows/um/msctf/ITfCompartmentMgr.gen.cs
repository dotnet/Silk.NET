// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7DCF57AC-18AD-438B-824D-979BFFB74B7C")]
[NativeTypeName("struct ITfCompartmentMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCompartmentMgr : ITfCompartmentMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCompartmentMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCompartmentMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfCompartmentMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCompartmentMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCompartment(
        [NativeTypeName("const GUID &")] Guid* rguid,
        ITfCompartment* ppcomp
    )
    {
        return (
            (delegate* unmanaged<ITfCompartmentMgr, Guid*, ITfCompartment*, int>)((*lpVtbl)[3])
        )(this, rguid, ppcomp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ClearCompartment(
        [NativeTypeName("TfClientId")] uint tid,
        [NativeTypeName("const GUID &")] Guid* rguid
    )
    {
        return ((delegate* unmanaged<ITfCompartmentMgr, uint, Guid*, int>)((*lpVtbl)[4]))(
            this,
            tid,
            rguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumCompartments(IEnumGUID* ppEnum)
    {
        return ((delegate* unmanaged<ITfCompartmentMgr, IEnumGUID*, int>)((*lpVtbl)[5]))(
            this,
            ppEnum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCompartment(
            [NativeTypeName("const GUID &")] Guid* rguid,
            ITfCompartment* ppcomp
        );

        [VtblIndex(4)]
        HRESULT ClearCompartment(
            [NativeTypeName("TfClientId")] uint tid,
            [NativeTypeName("const GUID &")] Guid* rguid
        );

        [VtblIndex(5)]
        HRESULT EnumCompartments(IEnumGUID* ppEnum);
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

        [NativeTypeName("HRESULT (const GUID &, ITfCompartment **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfCompartment*, int> GetCompartment;

        [NativeTypeName("HRESULT (TfClientId, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> ClearCompartment;

        [NativeTypeName("HRESULT (IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumGUID*, int> EnumCompartments;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfCompartmentMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfCompartmentMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfCompartmentMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfCompartmentMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfCompartmentMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfCompartmentMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfCompartmentMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfCompartmentMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
