// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00020410-0000-0000-C000-000000000046")]
[NativeTypeName("struct ITypeChangeEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITypeChangeEvents : ITypeChangeEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeChangeEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeChangeEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITypeChangeEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeChangeEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RequestTypeChange(
        CHANGEKIND changeKind,
        ITypeInfo pTInfoBefore,
        [NativeTypeName("LPOLESTR")] ushort* pStrName,
        int* pfCancel
    )
    {
        return (
            (delegate* unmanaged<ITypeChangeEvents, CHANGEKIND, ITypeInfo, ushort*, int*, int>)(
                (*lpVtbl)[3]
            )
        )(this, changeKind, pTInfoBefore, pStrName, pfCancel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AfterTypeChange(
        CHANGEKIND changeKind,
        ITypeInfo pTInfoAfter,
        [NativeTypeName("LPOLESTR")] ushort* pStrName
    )
    {
        return (
            (delegate* unmanaged<ITypeChangeEvents, CHANGEKIND, ITypeInfo, ushort*, int>)(
                (*lpVtbl)[4]
            )
        )(this, changeKind, pTInfoAfter, pStrName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RequestTypeChange(
            CHANGEKIND changeKind,
            ITypeInfo pTInfoBefore,
            [NativeTypeName("LPOLESTR")] ushort* pStrName,
            int* pfCancel
        );

        [VtblIndex(4)]
        HRESULT AfterTypeChange(
            CHANGEKIND changeKind,
            ITypeInfo pTInfoAfter,
            [NativeTypeName("LPOLESTR")] ushort* pStrName
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

        [NativeTypeName(
            "HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR, INT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CHANGEKIND,
            ITypeInfo,
            ushort*,
            int*,
            int> RequestTypeChange;

        [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CHANGEKIND, ITypeInfo, ushort*, int> AfterTypeChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITypeChangeEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITypeChangeEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITypeChangeEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITypeChangeEvents(Silk.NET.Windows.IUnknown value)
    {
        return new ITypeChangeEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITypeChangeEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITypeChangeEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITypeChangeEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
