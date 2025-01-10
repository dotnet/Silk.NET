// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E0CE4877-9AAF-46B4-AD31-6A60B441C780")]
[NativeTypeName("struct IAppCaptureMetadataWriter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureMetadataWriter
    : IAppCaptureMetadataWriter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureMetadataWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddStringEvent(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
            AppCaptureMetadataPriority priority
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                HSTRING,
                HSTRING,
                AppCaptureMetadataPriority,
                int>)((*lpVtbl)[6])
        )(this, name, value, priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddInt32Event(
        HSTRING name,
        [NativeTypeName("INT32")] int value,
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
            AppCaptureMetadataPriority priority
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                HSTRING,
                int,
                AppCaptureMetadataPriority,
                int>)((*lpVtbl)[7])
        )(this, name, value, priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddDoubleEvent(
        HSTRING name,
        double value,
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
            AppCaptureMetadataPriority priority
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                HSTRING,
                double,
                AppCaptureMetadataPriority,
                int>)((*lpVtbl)[8])
        )(this, name, value, priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartStringState(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
            AppCaptureMetadataPriority priority
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                HSTRING,
                HSTRING,
                AppCaptureMetadataPriority,
                int>)((*lpVtbl)[9])
        )(this, name, value, priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StartInt32State(
        HSTRING name,
        [NativeTypeName("INT32")] int value,
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
            AppCaptureMetadataPriority priority
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                HSTRING,
                int,
                AppCaptureMetadataPriority,
                int>)((*lpVtbl)[10])
        )(this, name, value, priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartDoubleState(
        HSTRING name,
        double value,
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
            AppCaptureMetadataPriority priority
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                HSTRING,
                double,
                AppCaptureMetadataPriority,
                int>)((*lpVtbl)[11])
        )(this, name, value, priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopState(HSTRING name)
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, HSTRING, int>)((*lpVtbl)[12]))(
            this,
            name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StopAllStates()
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RemainingStorageBytesAvailable([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAppCaptureMetadataWriter, ulong*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_MetadataPurged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureMetadataWriter_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureMetadataWriter,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_MetadataPurged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAppCaptureMetadataWriter, EventRegistrationToken, int>)(
                (*lpVtbl)[16]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddStringEvent(
            HSTRING name,
            HSTRING value,
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
                AppCaptureMetadataPriority priority
        );

        [VtblIndex(7)]
        HRESULT AddInt32Event(
            HSTRING name,
            [NativeTypeName("INT32")] int value,
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
                AppCaptureMetadataPriority priority
        );

        [VtblIndex(8)]
        HRESULT AddDoubleEvent(
            HSTRING name,
            double value,
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
                AppCaptureMetadataPriority priority
        );

        [VtblIndex(9)]
        HRESULT StartStringState(
            HSTRING name,
            HSTRING value,
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
                AppCaptureMetadataPriority priority
        );

        [VtblIndex(10)]
        HRESULT StartInt32State(
            HSTRING name,
            [NativeTypeName("INT32")] int value,
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
                AppCaptureMetadataPriority priority
        );

        [VtblIndex(11)]
        HRESULT StartDoubleState(
            HSTRING name,
            double value,
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")]
                AppCaptureMetadataPriority priority
        );

        [VtblIndex(12)]
        HRESULT StopState(HSTRING name);

        [VtblIndex(13)]
        HRESULT StopAllStates();

        [VtblIndex(14)]
        HRESULT get_RemainingStorageBytesAvailable([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT add_MetadataPurged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureMetadataWriter_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_MetadataPurged(EventRegistrationToken token);
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            AppCaptureMetadataPriority,
            int> AddStringEvent;

        [NativeTypeName(
            "HRESULT (HSTRING, INT32, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            int,
            AppCaptureMetadataPriority,
            int> AddInt32Event;

        [NativeTypeName(
            "HRESULT (HSTRING, DOUBLE, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            double,
            AppCaptureMetadataPriority,
            int> AddDoubleEvent;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            AppCaptureMetadataPriority,
            int> StartStringState;

        [NativeTypeName(
            "HRESULT (HSTRING, INT32, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            int,
            AppCaptureMetadataPriority,
            int> StartInt32State;

        [NativeTypeName(
            "HRESULT (HSTRING, DOUBLE, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            double,
            AppCaptureMetadataPriority,
            int> StartDoubleState;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> StopState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopAllStates;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_RemainingStorageBytesAvailable;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureMetadataWriter_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MetadataPurged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MetadataPurged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppCaptureMetadataWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppCaptureMetadataWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppCaptureMetadataWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppCaptureMetadataWriter(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppCaptureMetadataWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureMetadataWriter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureMetadataWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppCaptureMetadataWriter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppCaptureMetadataWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppCaptureMetadataWriter(Silk.NET.Windows.IUnknown value)
    {
        return new IAppCaptureMetadataWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureMetadataWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureMetadataWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppCaptureMetadataWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
