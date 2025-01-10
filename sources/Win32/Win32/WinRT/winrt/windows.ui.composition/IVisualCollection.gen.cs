// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8B745505-FD3E-4A98-84A8-E949468C6BCB")]
[NativeTypeName("struct IVisualCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVisualCollection : IVisualCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisualCollection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVisualCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVisualCollection, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVisualCollection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVisualCollection, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Count([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IVisualCollection, int*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertAbove(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild,
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual sibling
    )
    {
        return ((delegate* unmanaged<IVisualCollection, IVisual, IVisual, int>)((*lpVtbl)[7]))(
            this,
            newChild,
            sibling
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertAtBottom(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild
    )
    {
        return ((delegate* unmanaged<IVisualCollection, IVisual, int>)((*lpVtbl)[8]))(
            this,
            newChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertAtTop(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild
    )
    {
        return ((delegate* unmanaged<IVisualCollection, IVisual, int>)((*lpVtbl)[9]))(
            this,
            newChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertBelow(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild,
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual sibling
    )
    {
        return ((delegate* unmanaged<IVisualCollection, IVisual, IVisual, int>)((*lpVtbl)[10]))(
            this,
            newChild,
            sibling
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Remove(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual child
    )
    {
        return ((delegate* unmanaged<IVisualCollection, IVisual, int>)((*lpVtbl)[11]))(this, child);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged<IVisualCollection, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Count([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT InsertAbove(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild,
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual sibling
        );

        [VtblIndex(8)]
        HRESULT InsertAtBottom(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild
        );

        [VtblIndex(9)]
        HRESULT InsertAtTop(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild
        );

        [VtblIndex(10)]
        HRESULT InsertBelow(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual newChild,
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual sibling
        );

        [VtblIndex(11)]
        HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual child);

        [VtblIndex(12)]
        HRESULT RemoveAll();
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, IVisual, int> InsertAbove;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, int> InsertAtBottom;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, int> InsertAtTop;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, IVisual, int> InsertBelow;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAll;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVisualCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVisualCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVisualCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVisualCollection(Silk.NET.WinRT.IInspectable value)
    {
        return new IVisualCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisualCollection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVisualCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVisualCollection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVisualCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVisualCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IVisualCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisualCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVisualCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVisualCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
