// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FAAB5CD0-8924-45AC-AD0F-A08FAE5D0324")]
[NativeTypeName("struct IFrameworkView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameworkView : IFrameworkView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameworkView));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameworkView, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFrameworkView, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameworkView, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFrameworkView, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFrameworkView, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFrameworkView, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Initialize(
        [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")]
            ICoreApplicationView applicationView
    )
    {
        return ((delegate* unmanaged<IFrameworkView, ICoreApplicationView, int>)((*lpVtbl)[6]))(
            this,
            applicationView
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetWindow(
        [NativeTypeName("ABI::Windows::UI::Core::ICoreWindow *")] ICoreWindow window
    )
    {
        return ((delegate* unmanaged<IFrameworkView, ICoreWindow, int>)((*lpVtbl)[7]))(
            this,
            window
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Load(HSTRING entryPoint)
    {
        return ((delegate* unmanaged<IFrameworkView, HSTRING, int>)((*lpVtbl)[8]))(
            this,
            entryPoint
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Run()
    {
        return ((delegate* unmanaged<IFrameworkView, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Uninitialize()
    {
        return ((delegate* unmanaged<IFrameworkView, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Initialize(
            [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")]
                ICoreApplicationView applicationView
        );

        [VtblIndex(7)]
        HRESULT SetWindow(
            [NativeTypeName("ABI::Windows::UI::Core::ICoreWindow *")] ICoreWindow window
        );

        [VtblIndex(8)]
        HRESULT Load(HSTRING entryPoint);

        [VtblIndex(9)]
        HRESULT Run();

        [VtblIndex(10)]
        HRESULT Uninitialize();
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
            "HRESULT (ABI::Windows::ApplicationModel::Core::ICoreApplicationView *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICoreApplicationView, int> Initialize;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreWindow *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICoreWindow, int> SetWindow;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> Load;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Run;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Uninitialize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFrameworkView"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFrameworkView(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFrameworkView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFrameworkView(Silk.NET.WinRT.IInspectable value)
    {
        return new IFrameworkView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameworkView"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameworkView"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFrameworkView value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFrameworkView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFrameworkView(Silk.NET.Windows.IUnknown value)
    {
        return new IFrameworkView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameworkView"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameworkView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFrameworkView value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
