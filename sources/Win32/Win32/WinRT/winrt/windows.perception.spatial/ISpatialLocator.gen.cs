// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F6478925-9E0C-3BB6-997E-B64ECCA24CF4")]
[NativeTypeName("struct ISpatialLocator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialLocator : ISpatialLocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialLocator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialLocator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialLocator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialLocator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialLocator, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialLocator, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialLocator, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Locatability(
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLocatability *")]
            SpatialLocatability* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocator, SpatialLocatability*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_LocatabilityChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_LocatabilityChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged<ISpatialLocator, EventRegistrationToken, int>)((*lpVtbl)[8]))(
            this,
            cookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PositionalTrackingDeactivating(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_Windows__CPerception__CSpatial__CSpatialLocatorPositionalTrackingDeactivatingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PositionalTrackingDeactivating(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged<ISpatialLocator, EventRegistrationToken, int>)((*lpVtbl)[10]))(
            this,
            cookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryLocateAtTimestamp(
        [NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")]
            IPerceptionTimestamp timestamp,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocation **")]
            ISpatialLocation* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                IPerceptionTimestamp,
                ISpatialCoordinateSystem,
                ISpatialLocation*,
                int>)((*lpVtbl)[11])
        )(this, timestamp, coordinateSystem, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeading(
        [NativeTypeName(
            "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
        )]
            ISpatialLocatorAttachedFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialLocator, ISpatialLocatorAttachedFrameOfReference*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition,
        [NativeTypeName(
            "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
        )]
            ISpatialLocatorAttachedFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                Vector3,
                ISpatialLocatorAttachedFrameOfReference*,
                int>)((*lpVtbl)[13])
        )(this, relativePosition, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
            Quaternion relativeOrientation,
        [NativeTypeName(
            "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
        )]
            ISpatialLocatorAttachedFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                Vector3,
                Quaternion,
                ISpatialLocatorAttachedFrameOfReference*,
                int>)((*lpVtbl)[14])
        )(this, relativePosition, relativeOrientation, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
            Quaternion relativeOrientation,
        double relativeHeadingInRadians,
        [NativeTypeName(
            "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
        )]
            ISpatialLocatorAttachedFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                Vector3,
                Quaternion,
                double,
                ISpatialLocatorAttachedFrameOfReference*,
                int>)((*lpVtbl)[15])
        )(this, relativePosition, relativeOrientation, relativeHeadingInRadians, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocation(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")]
            ISpatialStationaryFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialLocator, ISpatialStationaryFrameOfReference*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")]
            ISpatialStationaryFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                Vector3,
                ISpatialStationaryFrameOfReference*,
                int>)((*lpVtbl)[17])
        )(this, relativePosition, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
            Quaternion relativeOrientation,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")]
            ISpatialStationaryFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                Vector3,
                Quaternion,
                ISpatialStationaryFrameOfReference*,
                int>)((*lpVtbl)[18])
        )(this, relativePosition, relativeOrientation, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
            Quaternion relativeOrientation,
        double relativeHeadingInRadians,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")]
            ISpatialStationaryFrameOfReference* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialLocator,
                Vector3,
                Quaternion,
                double,
                ISpatialStationaryFrameOfReference*,
                int>)((*lpVtbl)[19])
        )(this, relativePosition, relativeOrientation, relativeHeadingInRadians, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Locatability(
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLocatability *")]
                SpatialLocatability* value
        );

        [VtblIndex(7)]
        HRESULT add_LocatabilityChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(8)]
        HRESULT remove_LocatabilityChanged(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT add_PositionalTrackingDeactivating(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_Windows__CPerception__CSpatial__CSpatialLocatorPositionalTrackingDeactivatingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(10)]
        HRESULT remove_PositionalTrackingDeactivating(EventRegistrationToken cookie);

        [VtblIndex(11)]
        HRESULT TryLocateAtTimestamp(
            [NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")]
                IPerceptionTimestamp timestamp,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocation **")]
                ISpatialLocation* value
        );

        [VtblIndex(12)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeading(
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
            )]
                ISpatialLocatorAttachedFrameOfReference* value
        );

        [VtblIndex(13)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 relativePosition,
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
            )]
                ISpatialLocatorAttachedFrameOfReference* value
        );

        [VtblIndex(14)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 relativePosition,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
                Quaternion relativeOrientation,
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
            )]
                ISpatialLocatorAttachedFrameOfReference* value
        );

        [VtblIndex(15)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 relativePosition,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
                Quaternion relativeOrientation,
            double relativeHeadingInRadians,
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **"
            )]
                ISpatialLocatorAttachedFrameOfReference* value
        );

        [VtblIndex(16)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocation(
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **"
            )]
                ISpatialStationaryFrameOfReference* value
        );

        [VtblIndex(17)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 relativePosition,
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **"
            )]
                ISpatialStationaryFrameOfReference* value
        );

        [VtblIndex(18)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 relativePosition,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
                Quaternion relativeOrientation,
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **"
            )]
                ISpatialStationaryFrameOfReference* value
        );

        [VtblIndex(19)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 relativePosition,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
                Quaternion relativeOrientation,
            double relativeHeadingInRadians,
            [NativeTypeName(
                "ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **"
            )]
                ISpatialStationaryFrameOfReference* value
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
            "HRESULT (ABI::Windows::Perception::Spatial::SpatialLocatability *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpatialLocatability*, int> get_Locatability;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_LocatabilityChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_LocatabilityChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_Windows__CPerception__CSpatial__CSpatialLocatorPositionalTrackingDeactivatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PositionalTrackingDeactivating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_PositionalTrackingDeactivating;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::IPerceptionTimestamp *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::ISpatialLocation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPerceptionTimestamp,
            ISpatialCoordinateSystem,
            ISpatialLocation*,
            int> TryLocateAtTimestamp;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialLocatorAttachedFrameOfReference*,
            int> CreateAttachedFrameOfReferenceAtCurrentHeading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector3,
            ISpatialLocatorAttachedFrameOfReference*,
            int> CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector3,
            Quaternion,
            ISpatialLocatorAttachedFrameOfReference*,
            int> CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, DOUBLE, ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector3,
            Quaternion,
            double,
            ISpatialLocatorAttachedFrameOfReference*,
            int> CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialStationaryFrameOfReference*,
            int> CreateStationaryFrameOfReferenceAtCurrentLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector3,
            ISpatialStationaryFrameOfReference*,
            int> CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector3,
            Quaternion,
            ISpatialStationaryFrameOfReference*,
            int> CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, DOUBLE, ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector3,
            Quaternion,
            double,
            ISpatialStationaryFrameOfReference*,
            int> CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialLocator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialLocator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialLocator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialLocator(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialLocator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialLocator"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialLocator"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialLocator value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialLocator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialLocator(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialLocator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialLocator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialLocator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialLocator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
