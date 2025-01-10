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

[Guid("923CCAAC-61E1-4385-B726-017AF189882A")]
[NativeTypeName("struct IDirectManipulationViewport2 : IDirectManipulationViewport")]
[NativeInheritance("IDirectManipulationViewport")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationViewport2
    : IDirectManipulationViewport2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationViewport2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, uint, int>)((*lpVtbl)[5]))(
            this,
            pointerId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReleaseContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, uint, int>)((*lpVtbl)[6]))(
            this,
            pointerId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReleaseAllContacts()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStatus(DIRECTMANIPULATION_STATUS* status)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, DIRECTMANIPULATION_STATUS*, int>)(
                (*lpVtbl)[8]
            )
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTag(
        [NativeTypeName("const IID &")] Guid* riid,
        void** @object,
        [NativeTypeName("UINT32 *")] uint* id
    )
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, Guid*, void**, uint*, int>)(
                (*lpVtbl)[9]
            )
        )(this, riid, @object, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, IUnknown, uint, int>)((*lpVtbl)[10])
        )(this, @object, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetViewportRect(RECT* viewport)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, RECT*, int>)((*lpVtbl)[11]))(
            this,
            viewport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetViewportRect([NativeTypeName("const RECT *")] RECT* viewport)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, RECT*, int>)((*lpVtbl)[12]))(
            this,
            viewport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ZoomToRect(
        [NativeTypeName("const float")] float left,
        [NativeTypeName("const float")] float top,
        [NativeTypeName("const float")] float right,
        [NativeTypeName("const float")] float bottom,
        BOOL animate
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                float,
                float,
                float,
                float,
                BOOL,
                int>)((*lpVtbl)[13])
        )(this, left, top, right, bottom, animate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetViewportTransform(
        [NativeTypeName("const float *")] float* matrix,
        [NativeTypeName("DWORD")] uint pointCount
    )
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, float*, uint, int>)((*lpVtbl)[14])
        )(this, matrix, pointCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SyncDisplayTransform(
        [NativeTypeName("const float *")] float* matrix,
        [NativeTypeName("DWORD")] uint pointCount
    )
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, float*, uint, int>)((*lpVtbl)[15])
        )(this, matrix, pointCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPrimaryContent([NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, Guid*, void**, int>)((*lpVtbl)[16])
        )(this, riid, @object);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddContent(IDirectManipulationContent content)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, IDirectManipulationContent, int>)(
                (*lpVtbl)[17]
            )
        )(this, content);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveContent(IDirectManipulationContent content)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, IDirectManipulationContent, int>)(
                (*lpVtbl)[18]
            )
        )(this, content);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_VIEWPORT_OPTIONS,
                int>)((*lpVtbl)[19])
        )(this, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_CONFIGURATION,
                int>)((*lpVtbl)[20])
        )(this, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_CONFIGURATION,
                int>)((*lpVtbl)[21])
        )(this, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_CONFIGURATION,
                int>)((*lpVtbl)[22])
        )(this, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_GESTURE_CONFIGURATION,
                int>)((*lpVtbl)[23])
        )(this, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_MOTION_TYPES,
                int>)((*lpVtbl)[24])
        )(this, enabledTypes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT AddEventHandler(
        HWND window,
        IDirectManipulationViewportEventHandler eventHandler,
        [NativeTypeName("DWORD *")] uint* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewport2,
                HWND,
                IDirectManipulationViewportEventHandler,
                uint*,
                int>)((*lpVtbl)[25])
        )(this, window, eventHandler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT RemoveEventHandler([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, uint, int>)((*lpVtbl)[26]))(
            this,
            cookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, DIRECTMANIPULATION_INPUT_MODE, int>)(
                (*lpVtbl)[27]
            )
        )(this, mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, DIRECTMANIPULATION_INPUT_MODE, int>)(
                (*lpVtbl)[28]
            )
        )(this, mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, int>)((*lpVtbl)[29]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Abandon()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, int>)((*lpVtbl)[30]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT AddBehavior(IUnknown behavior, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewport2, IUnknown, uint*, int>)((*lpVtbl)[31])
        )(this, behavior, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT RemoveBehavior([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, uint, int>)((*lpVtbl)[32]))(
            this,
            cookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RemoveAllBehaviors()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2, int>)((*lpVtbl)[33]))(this);
    }

    public interface Interface : IDirectManipulationViewport.Interface
    {
        [VtblIndex(31)]
        HRESULT AddBehavior(IUnknown behavior, [NativeTypeName("DWORD *")] uint* cookie);

        [VtblIndex(32)]
        HRESULT RemoveBehavior([NativeTypeName("DWORD")] uint cookie);

        [VtblIndex(33)]
        HRESULT RemoveAllBehaviors();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Enable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disable;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetContact;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ReleaseContact;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseAllContacts;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (const IID &, void **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, uint*, int> GetTag;

        [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> SetTag;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetViewportRect;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetViewportRect;

        [NativeTypeName(
            "HRESULT (const float, const float, const float, const float, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float, float, float, float, BOOL, int> ZoomToRect;

        [NativeTypeName("HRESULT (const float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> SetViewportTransform;

        [NativeTypeName("HRESULT (const float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> SyncDisplayTransform;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetPrimaryContent;

        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent, int> AddContent;

        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent, int> RemoveContent;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_VIEWPORT_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DIRECTMANIPULATION_VIEWPORT_OPTIONS,
            int> SetViewportOptions;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_CONFIGURATION, int> AddConfiguration;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DIRECTMANIPULATION_CONFIGURATION,
            int> RemoveConfiguration;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DIRECTMANIPULATION_CONFIGURATION,
            int> ActivateConfiguration;

        [NativeTypeName(
            "HRESULT (DIRECTMANIPULATION_GESTURE_CONFIGURATION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DIRECTMANIPULATION_GESTURE_CONFIGURATION,
            int> SetManualGesture;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_MOTION_TYPES) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_MOTION_TYPES, int> SetChaining;

        [NativeTypeName(
            "HRESULT (HWND, IDirectManipulationViewportEventHandler *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IDirectManipulationViewportEventHandler,
            uint*,
            int> AddEventHandler;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveEventHandler;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_INPUT_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_INPUT_MODE, int> SetInputMode;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_INPUT_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_INPUT_MODE, int> SetUpdateMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abandon;

        [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint*, int> AddBehavior;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveBehavior;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllBehaviors;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationViewport2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationViewport2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirectManipulationViewport"/> to <see cref = "IDirectManipulationViewport2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirectManipulationViewport"/> instance to be converted </param>
    public static explicit operator IDirectManipulationViewport2(
        Silk.NET.DirectX.IDirectManipulationViewport value
    )
    {
        return new IDirectManipulationViewport2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationViewport2"/> to <see cref = "Silk.NET.DirectX.IDirectManipulationViewport"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationViewport2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirectManipulationViewport(
        IDirectManipulationViewport2 value
    )
    {
        return new Silk.NET.DirectX.IDirectManipulationViewport(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationViewport2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationViewport2(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectManipulationViewport2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationViewport2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationViewport2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectManipulationViewport2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
