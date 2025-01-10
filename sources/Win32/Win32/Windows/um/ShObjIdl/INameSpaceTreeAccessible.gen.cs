// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71F312DE-43ED-4190-8477-E9536B82350B")]
[NativeTypeName("struct INameSpaceTreeAccessible : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeAccessible
    : INameSpaceTreeAccessible.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeAccessible));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INameSpaceTreeAccessible, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INameSpaceTreeAccessible, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeAccessible, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnGetDefaultAccessibilityAction(
        IShellItem psi,
        [NativeTypeName("BSTR *")] ushort** pbstrDefaultAction
    )
    {
        return (
            (delegate* unmanaged<INameSpaceTreeAccessible, IShellItem, ushort**, int>)((*lpVtbl)[3])
        )(this, psi, pbstrDefaultAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnDoDefaultAccessibilityAction(IShellItem psi)
    {
        return ((delegate* unmanaged<INameSpaceTreeAccessible, IShellItem, int>)((*lpVtbl)[4]))(
            this,
            psi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnGetAccessibilityRole(IShellItem psi, VARIANT* pvarRole)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeAccessible, IShellItem, VARIANT*, int>)((*lpVtbl)[5])
        )(this, psi, pvarRole);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnGetDefaultAccessibilityAction(
            IShellItem psi,
            [NativeTypeName("BSTR *")] ushort** pbstrDefaultAction
        );

        [VtblIndex(4)]
        HRESULT OnDoDefaultAccessibilityAction(IShellItem psi);

        [VtblIndex(5)]
        HRESULT OnGetAccessibilityRole(IShellItem psi, VARIANT* pvarRole);
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

        [NativeTypeName("HRESULT (IShellItem *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            ushort**,
            int> OnGetDefaultAccessibilityAction;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnDoDefaultAccessibilityAction;

        [NativeTypeName("HRESULT (IShellItem *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, VARIANT*, int> OnGetAccessibilityRole;
    }

    /// <summary>Initializes a new instance of the <see cref = "INameSpaceTreeAccessible"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INameSpaceTreeAccessible(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INameSpaceTreeAccessible"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeAccessible(Silk.NET.Windows.IUnknown value)
    {
        return new INameSpaceTreeAccessible(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeAccessible"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeAccessible"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INameSpaceTreeAccessible value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
