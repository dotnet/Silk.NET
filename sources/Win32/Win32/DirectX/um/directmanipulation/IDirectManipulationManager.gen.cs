// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("FBF5D3B4-70C7-4163-9322-5A6F660D6FBC")]
[NativeTypeName("struct IDirectManipulationManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationManager
    : IDirectManipulationManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate(HWND window)
    {
        return ((delegate* unmanaged<IDirectManipulationManager, HWND, int>)((*lpVtbl)[3]))(
            this,
            window
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate(HWND window)
    {
        return ((delegate* unmanaged<IDirectManipulationManager, HWND, int>)((*lpVtbl)[4]))(
            this,
            window
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterHitTestTarget(
        HWND window,
        HWND hitTestWindow,
        DIRECTMANIPULATION_HITTEST_TYPE type
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationManager,
                HWND,
                HWND,
                DIRECTMANIPULATION_HITTEST_TYPE,
                int>)((*lpVtbl)[5])
        )(this, window, hitTestWindow, type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProcessInput([NativeTypeName("const MSG *")] MSG* message, BOOL* handled)
    {
        return ((delegate* unmanaged<IDirectManipulationManager, MSG*, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            message,
            handled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdateManager([NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return (
            (delegate* unmanaged<IDirectManipulationManager, Guid*, void**, int>)((*lpVtbl)[7])
        )(this, riid, @object);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateViewport(
        IDirectManipulationFrameInfoProvider frameInfo,
        HWND window,
        [NativeTypeName("const IID &")] Guid* riid,
        void** @object
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationManager,
                IDirectManipulationFrameInfoProvider,
                HWND,
                Guid*,
                void**,
                int>)((*lpVtbl)[8])
        )(this, frameInfo, window, riid, @object);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateContent(
        IDirectManipulationFrameInfoProvider frameInfo,
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** @object
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationManager,
                IDirectManipulationFrameInfoProvider,
                Guid*,
                Guid*,
                void**,
                int>)((*lpVtbl)[9])
        )(this, frameInfo, clsid, riid, @object);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate(HWND window);

        [VtblIndex(4)]
        HRESULT Deactivate(HWND window);

        [VtblIndex(5)]
        HRESULT RegisterHitTestTarget(
            HWND window,
            HWND hitTestWindow,
            DIRECTMANIPULATION_HITTEST_TYPE type
        );

        [VtblIndex(6)]
        HRESULT ProcessInput([NativeTypeName("const MSG *")] MSG* message, BOOL* handled);

        [VtblIndex(7)]
        HRESULT GetUpdateManager([NativeTypeName("const IID &")] Guid* riid, void** @object);

        [VtblIndex(8)]
        HRESULT CreateViewport(
            IDirectManipulationFrameInfoProvider frameInfo,
            HWND window,
            [NativeTypeName("const IID &")] Guid* riid,
            void** @object
        );

        [VtblIndex(9)]
        HRESULT CreateContent(
            IDirectManipulationFrameInfoProvider frameInfo,
            [NativeTypeName("const IID &")] Guid* clsid,
            [NativeTypeName("const IID &")] Guid* riid,
            void** @object
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

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Activate;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Deactivate;

        [NativeTypeName(
            "HRESULT (HWND, HWND, DIRECTMANIPULATION_HITTEST_TYPE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HWND,
            DIRECTMANIPULATION_HITTEST_TYPE,
            int> RegisterHitTestTarget;

        [NativeTypeName("HRESULT (const MSG *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, BOOL*, int> ProcessInput;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetUpdateManager;

        [NativeTypeName(
            "HRESULT (IDirectManipulationFrameInfoProvider *, HWND, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationFrameInfoProvider,
            HWND,
            Guid*,
            void**,
            int> CreateViewport;

        [NativeTypeName(
            "HRESULT (IDirectManipulationFrameInfoProvider *, const IID &, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationFrameInfoProvider,
            Guid*,
            Guid*,
            void**,
            int> CreateContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationManager(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectManipulationManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectManipulationManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
