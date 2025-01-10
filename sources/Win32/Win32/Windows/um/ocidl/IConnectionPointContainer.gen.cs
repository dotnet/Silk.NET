// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IConnectionPointContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConnectionPointContainer
    : IConnectionPointContainer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionPointContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionPointContainer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionPointContainer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionPointContainer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumConnectionPoints(IEnumConnectionPoints* ppEnum)
    {
        return (
            (delegate* unmanaged<IConnectionPointContainer, IEnumConnectionPoints*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FindConnectionPoint(
        [NativeTypeName("const IID &")] Guid* riid,
        IConnectionPoint* ppCP
    )
    {
        return (
            (delegate* unmanaged<IConnectionPointContainer, Guid*, IConnectionPoint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, riid, ppCP);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumConnectionPoints(IEnumConnectionPoints* ppEnum);

        [VtblIndex(4)]
        HRESULT FindConnectionPoint(
            [NativeTypeName("const IID &")] Guid* riid,
            IConnectionPoint* ppCP
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

        [NativeTypeName("HRESULT (IEnumConnectionPoints **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumConnectionPoints*, int> EnumConnectionPoints;

        [NativeTypeName("HRESULT (const IID &, IConnectionPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IConnectionPoint*, int> FindConnectionPoint;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionPointContainer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionPointContainer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionPointContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionPointContainer(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionPointContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionPointContainer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionPointContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionPointContainer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
