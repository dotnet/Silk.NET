// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1B25DA6E-8AA6-41E9-8251-4165F5985F49")]
[NativeTypeName("struct ILauncherUIOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherUIOptions : ILauncherUIOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherUIOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILauncherUIOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ILauncherUIOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILauncherUIOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ILauncherUIOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ILauncherUIOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InvocationPoint(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **"
        )]
            IReference<Point>** value
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, IReference<Point>**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InvocationPoint(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *"
        )]
            IReference<Point>* value
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, IReference<Point>*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SelectionRect(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **"
        )]
            IReference<Rect>** value
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, IReference<Rect>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SelectionRect(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *"
        )]
            IReference<Rect>* value
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, IReference<Rect>*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PreferredPlacement(
        [NativeTypeName("ABI::Windows::UI::Popups::Placement *")] Placement* value
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, Placement*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PreferredPlacement(
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement value
    )
    {
        return ((delegate* unmanaged<ILauncherUIOptions, Placement, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InvocationPoint(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **"
            )]
                IReference<Point>** value
        );

        [VtblIndex(7)]
        HRESULT put_InvocationPoint(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *"
            )]
                IReference<Point>* value
        );

        [VtblIndex(8)]
        HRESULT get_SelectionRect(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **"
            )]
                IReference<Rect>** value
        );

        [VtblIndex(9)]
        HRESULT put_SelectionRect(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *"
            )]
                IReference<Rect>* value
        );

        [VtblIndex(10)]
        HRESULT get_PreferredPlacement(
            [NativeTypeName("ABI::Windows::UI::Popups::Placement *")] Placement* value
        );

        [VtblIndex(11)]
        HRESULT put_PreferredPlacement(
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Point>**, int> get_InvocationPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Point>*, int> put_InvocationPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Rect>**, int> get_SelectionRect;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Rect>*, int> put_SelectionRect;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::Placement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Placement*, int> get_PreferredPlacement;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Placement, int> put_PreferredPlacement;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILauncherUIOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILauncherUIOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILauncherUIOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILauncherUIOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new ILauncherUIOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherUIOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherUIOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ILauncherUIOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILauncherUIOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILauncherUIOptions(Silk.NET.Windows.IUnknown value)
    {
        return new ILauncherUIOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherUIOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherUIOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILauncherUIOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
