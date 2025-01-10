// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AC412946-E1AC-5230-944A-C60873DCF4A9")]
[NativeTypeName("struct IAppWindowFrameStyle : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowFrameStyle : IAppWindowFrameStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowFrameStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppWindowFrameStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppWindowFrameStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppWindowFrameStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppWindowFrameStyle, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppWindowFrameStyle, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppWindowFrameStyle, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFrameStyle(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle *")]
            AppWindowFrameStyle* result
    )
    {
        return (
            (delegate* unmanaged<IAppWindowFrameStyle, AppWindowFrameStyle*, int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFrameStyle(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle")]
            AppWindowFrameStyle frameStyle
    )
    {
        return (
            (delegate* unmanaged<IAppWindowFrameStyle, AppWindowFrameStyle, int>)((*lpVtbl)[7])
        )(this, frameStyle);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetFrameStyle(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle *")]
                AppWindowFrameStyle* result
        );

        [VtblIndex(7)]
        HRESULT SetFrameStyle(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle")]
                AppWindowFrameStyle frameStyle
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
            "HRESULT (ABI::Windows::UI::WindowManagement::AppWindowFrameStyle *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppWindowFrameStyle*, int> GetFrameStyle;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::AppWindowFrameStyle) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppWindowFrameStyle, int> SetFrameStyle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppWindowFrameStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppWindowFrameStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppWindowFrameStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppWindowFrameStyle(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppWindowFrameStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindowFrameStyle"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindowFrameStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppWindowFrameStyle value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppWindowFrameStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppWindowFrameStyle(Silk.NET.Windows.IUnknown value)
    {
        return new IAppWindowFrameStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindowFrameStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindowFrameStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppWindowFrameStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
