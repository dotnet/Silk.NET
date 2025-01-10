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

[Guid("EF874EA1-5CFF-4B68-9E30-A1519D08BA03")]
[NativeTypeName("struct ICompositionObject2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionObject2 : ICompositionObject2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionObject2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionObject2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionObject2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionObject2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionObject2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionObject2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionObject2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Comment(HSTRING* value)
    {
        return ((delegate* unmanaged<ICompositionObject2, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Comment(HSTRING value)
    {
        return ((delegate* unmanaged<ICompositionObject2, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ImplicitAnimations(
        [NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")]
            IImplicitAnimationCollection* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionObject2, IImplicitAnimationCollection*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ImplicitAnimations(
        [NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection *")]
            IImplicitAnimationCollection value
    )
    {
        return (
            (delegate* unmanaged<ICompositionObject2, IImplicitAnimationCollection, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StartAnimationGroup(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")]
            ICompositionAnimationBase value
    )
    {
        return (
            (delegate* unmanaged<ICompositionObject2, ICompositionAnimationBase, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StopAnimationGroup(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")]
            ICompositionAnimationBase value
    )
    {
        return (
            (delegate* unmanaged<ICompositionObject2, ICompositionAnimationBase, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Comment(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Comment(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ImplicitAnimations(
            [NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")]
                IImplicitAnimationCollection* value
        );

        [VtblIndex(9)]
        HRESULT put_ImplicitAnimations(
            [NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection *")]
                IImplicitAnimationCollection value
        );

        [VtblIndex(10)]
        HRESULT StartAnimationGroup(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")]
                ICompositionAnimationBase value
        );

        [VtblIndex(11)]
        HRESULT StopAnimationGroup(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")]
                ICompositionAnimationBase value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Comment;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Comment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IImplicitAnimationCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImplicitAnimationCollection*,
            int> get_ImplicitAnimations;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IImplicitAnimationCollection *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImplicitAnimationCollection,
            int> put_ImplicitAnimations;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionAnimationBase *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionAnimationBase, int> StartAnimationGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionAnimationBase *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionAnimationBase, int> StopAnimationGroup;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionObject2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionObject2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionObject2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionObject2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionObject2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionObject2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionObject2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionObject2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionObject2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionObject2(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionObject2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionObject2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionObject2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionObject2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
