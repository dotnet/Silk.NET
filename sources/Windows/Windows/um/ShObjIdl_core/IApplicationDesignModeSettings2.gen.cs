// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2"]/*' />
[Guid("490514E1-675A-4D6E-A58D-E54901B4CA2F")]
[NativeTypeName("struct IApplicationDesignModeSettings2 : IApplicationDesignModeSettings")]
[NativeInheritance("IApplicationDesignModeSettings")]
public unsafe partial struct IApplicationDesignModeSettings2 : IApplicationDesignModeSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationDesignModeSettings2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, uint>)(lpVtbl[1]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, uint>)(lpVtbl[2]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IApplicationDesignModeSettings.SetNativeDisplaySize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNativeDisplaySize(SIZE nativeDisplaySizePixels)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE, int>)(lpVtbl[3]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), nativeDisplaySizePixels);
    }

    /// <inheritdoc cref="IApplicationDesignModeSettings.SetScaleFactor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, DEVICE_SCALE_FACTOR, int>)(lpVtbl[4]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), scaleFactor);
    }

    /// <inheritdoc cref="IApplicationDesignModeSettings.SetApplicationViewState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetApplicationViewState(APPLICATION_VIEW_STATE viewState)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_STATE, int>)(lpVtbl[5]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewState);
    }

    /// <inheritdoc cref="IApplicationDesignModeSettings.ComputeApplicationSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ComputeApplicationSize(SIZE* applicationSizePixels)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE*, int>)(lpVtbl[6]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), applicationSizePixels);
    }

    /// <inheritdoc cref="IApplicationDesignModeSettings.IsApplicationViewStateSupported" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor, BOOL* supported)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_STATE, SIZE, DEVICE_SCALE_FACTOR, BOOL*, int>)(lpVtbl[7]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewState, nativeDisplaySizePixels, scaleFactor, supported);
    }

    /// <inheritdoc cref="IApplicationDesignModeSettings.TriggerEdgeGesture" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, EDGE_GESTURE_KIND, int>)(lpVtbl[8]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), edgeGestureKind);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.SetNativeDisplayOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetNativeDisplayOrientation(NATIVE_DISPLAY_ORIENTATION nativeDisplayOrientation)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, NATIVE_DISPLAY_ORIENTATION, int>)(lpVtbl[9]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), nativeDisplayOrientation);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.SetApplicationViewOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetApplicationViewOrientation(APPLICATION_VIEW_ORIENTATION viewOrientation)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_ORIENTATION, int>)(lpVtbl[10]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewOrientation);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.SetAdjacentDisplayEdges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetAdjacentDisplayEdges(ADJACENT_DISPLAY_EDGES adjacentDisplayEdges)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, ADJACENT_DISPLAY_EDGES, int>)(lpVtbl[11]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), adjacentDisplayEdges);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.SetIsOnLockScreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetIsOnLockScreen(BOOL isOnLockScreen)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, BOOL, int>)(lpVtbl[12]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), isOnLockScreen);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.SetApplicationViewMinWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetApplicationViewMinWidth(APPLICATION_VIEW_MIN_WIDTH viewMinWidth)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_MIN_WIDTH, int>)(lpVtbl[13]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewMinWidth);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.GetApplicationSizeBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetApplicationSizeBounds(SIZE* minApplicationSizePixels, SIZE* maxApplicationSizePixels)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE*, SIZE*, int>)(lpVtbl[14]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), minApplicationSizePixels, maxApplicationSizePixels);
    }

    /// <include file='IApplicationDesignModeSettings2.xml' path='doc/member[@name="IApplicationDesignModeSettings2.GetApplicationViewOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetApplicationViewOrientation(SIZE applicationSizePixels, APPLICATION_VIEW_ORIENTATION* viewOrientation)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE, APPLICATION_VIEW_ORIENTATION*, int>)(lpVtbl[15]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), applicationSizePixels, viewOrientation);
    }

    public interface Interface : IApplicationDesignModeSettings.Interface
    {
        [VtblIndex(9)]
        HRESULT SetNativeDisplayOrientation(NATIVE_DISPLAY_ORIENTATION nativeDisplayOrientation);

        [VtblIndex(10)]
        HRESULT SetApplicationViewOrientation(APPLICATION_VIEW_ORIENTATION viewOrientation);

        [VtblIndex(11)]
        HRESULT SetAdjacentDisplayEdges(ADJACENT_DISPLAY_EDGES adjacentDisplayEdges);

        [VtblIndex(12)]
        HRESULT SetIsOnLockScreen(BOOL isOnLockScreen);

        [VtblIndex(13)]
        HRESULT SetApplicationViewMinWidth(APPLICATION_VIEW_MIN_WIDTH viewMinWidth);

        [VtblIndex(14)]
        HRESULT GetApplicationSizeBounds(SIZE* minApplicationSizePixels, SIZE* maxApplicationSizePixels);

        [VtblIndex(15)]
        HRESULT GetApplicationViewOrientation(SIZE applicationSizePixels, APPLICATION_VIEW_ORIENTATION* viewOrientation);
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

        [NativeTypeName("HRESULT (SIZE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE, int> SetNativeDisplaySize;

        [NativeTypeName("HRESULT (DEVICE_SCALE_FACTOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEVICE_SCALE_FACTOR, int> SetScaleFactor;

        [NativeTypeName("HRESULT (APPLICATION_VIEW_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPLICATION_VIEW_STATE, int> SetApplicationViewState;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> ComputeApplicationSize;

        [NativeTypeName("HRESULT (APPLICATION_VIEW_STATE, SIZE, DEVICE_SCALE_FACTOR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPLICATION_VIEW_STATE, SIZE, DEVICE_SCALE_FACTOR, BOOL*, int> IsApplicationViewStateSupported;

        [NativeTypeName("HRESULT (EDGE_GESTURE_KIND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EDGE_GESTURE_KIND, int> TriggerEdgeGesture;

        [NativeTypeName("HRESULT (NATIVE_DISPLAY_ORIENTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, NATIVE_DISPLAY_ORIENTATION, int> SetNativeDisplayOrientation;

        [NativeTypeName("HRESULT (APPLICATION_VIEW_ORIENTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPLICATION_VIEW_ORIENTATION, int> SetApplicationViewOrientation;

        [NativeTypeName("HRESULT (ADJACENT_DISPLAY_EDGES) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ADJACENT_DISPLAY_EDGES, int> SetAdjacentDisplayEdges;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetIsOnLockScreen;

        [NativeTypeName("HRESULT (APPLICATION_VIEW_MIN_WIDTH) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPLICATION_VIEW_MIN_WIDTH, int> SetApplicationViewMinWidth;

        [NativeTypeName("HRESULT (SIZE *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, SIZE*, int> GetApplicationSizeBounds;

        [NativeTypeName("HRESULT (SIZE, APPLICATION_VIEW_ORIENTATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE, APPLICATION_VIEW_ORIENTATION*, int> GetApplicationViewOrientation;
    }
}
