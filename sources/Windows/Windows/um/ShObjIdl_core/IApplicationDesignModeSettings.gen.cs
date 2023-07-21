// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings"]/*' />
[Guid("2A3DEE9A-E31D-46D6-8508-BCC597DB3557")]
[NativeTypeName("struct IApplicationDesignModeSettings : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationDesignModeSettings : IApplicationDesignModeSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationDesignModeSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, uint>)(lpVtbl[1]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, uint>)(lpVtbl[2]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings.SetNativeDisplaySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNativeDisplaySize(SIZE nativeDisplaySizePixels)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, SIZE, int>)(lpVtbl[3]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), nativeDisplaySizePixels);
    }

    /// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings.SetScaleFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, DEVICE_SCALE_FACTOR, int>)(lpVtbl[4]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), scaleFactor);
    }

    /// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings.SetApplicationViewState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetApplicationViewState(APPLICATION_VIEW_STATE viewState)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, APPLICATION_VIEW_STATE, int>)(lpVtbl[5]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), viewState);
    }

    /// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings.ComputeApplicationSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ComputeApplicationSize(SIZE* applicationSizePixels)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, SIZE*, int>)(lpVtbl[6]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), applicationSizePixels);
    }

    /// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings.IsApplicationViewStateSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor, BOOL* supported)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, APPLICATION_VIEW_STATE, SIZE, DEVICE_SCALE_FACTOR, BOOL*, int>)(lpVtbl[7]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), viewState, nativeDisplaySizePixels, scaleFactor, supported);
    }

    /// <include file='IApplicationDesignModeSettings.xml' path='doc/member[@name="IApplicationDesignModeSettings.TriggerEdgeGesture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind)
    {
        return ((delegate* unmanaged<IApplicationDesignModeSettings*, EDGE_GESTURE_KIND, int>)(lpVtbl[8]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), edgeGestureKind);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetNativeDisplaySize(SIZE nativeDisplaySizePixels);

        [VtblIndex(4)]
        HRESULT SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor);

        [VtblIndex(5)]
        HRESULT SetApplicationViewState(APPLICATION_VIEW_STATE viewState);

        [VtblIndex(6)]
        HRESULT ComputeApplicationSize(SIZE* applicationSizePixels);

        [VtblIndex(7)]
        HRESULT IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor, BOOL* supported);

        [VtblIndex(8)]
        HRESULT TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind);
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
    }
}
