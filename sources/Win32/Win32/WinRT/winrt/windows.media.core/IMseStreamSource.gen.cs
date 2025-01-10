// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B0B4198D-02F4-4923-88DD-81BC3F360FFA")]
[NativeTypeName("struct IMseStreamSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMseStreamSource : IMseStreamSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMseStreamSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMseStreamSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMseStreamSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMseStreamSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMseStreamSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMseStreamSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Opened(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMseStreamSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Opened(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMseStreamSource, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Ended(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMseStreamSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Ended(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMseStreamSource, EventRegistrationToken, int>)((*lpVtbl)[9]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Closed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMseStreamSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMseStreamSource, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SourceBuffers(
        [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")]
            IMseSourceBufferList* value
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, IMseSourceBufferList*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ActiveSourceBuffers(
        [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")]
            IMseSourceBufferList* value
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, IMseSourceBufferList*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ReadyState(
        [NativeTypeName("ABI::Windows::Media::Core::MseReadyState *")] MseReadyState* value
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, MseReadyState*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Duration(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IReference<TimeSpan>** value
    )
    {
        return (
            (delegate* unmanaged<IMseStreamSource, IReference<TimeSpan>**, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Duration(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *"
        )]
            IReference<TimeSpan>* value
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, IReference<TimeSpan>*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddSourceBuffer(
        HSTRING mimeType,
        [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer **")] IMseSourceBuffer* buffer
    )
    {
        return (
            (delegate* unmanaged<IMseStreamSource, HSTRING, IMseSourceBuffer*, int>)((*lpVtbl)[17])
        )(this, mimeType, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveSourceBuffer(
        [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer *")] IMseSourceBuffer buffer
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, IMseSourceBuffer, int>)((*lpVtbl)[18]))(
            this,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EndOfStream(
        [NativeTypeName("ABI::Windows::Media::Core::MseEndOfStreamStatus")]
            MseEndOfStreamStatus status
    )
    {
        return ((delegate* unmanaged<IMseStreamSource, MseEndOfStreamStatus, int>)((*lpVtbl)[19]))(
            this,
            status
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Opened(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_Opened(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Ended(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_Ended(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_Closed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_SourceBuffers(
            [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")]
                IMseSourceBufferList* value
        );

        [VtblIndex(13)]
        HRESULT get_ActiveSourceBuffers(
            [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBufferList **")]
                IMseSourceBufferList* value
        );

        [VtblIndex(14)]
        HRESULT get_ReadyState(
            [NativeTypeName("ABI::Windows::Media::Core::MseReadyState *")] MseReadyState* value
        );

        [VtblIndex(15)]
        HRESULT get_Duration(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IReference<TimeSpan>** value
        );

        [VtblIndex(16)]
        HRESULT put_Duration(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *"
            )]
                IReference<TimeSpan>* value
        );

        [VtblIndex(17)]
        HRESULT AddSourceBuffer(
            HSTRING mimeType,
            [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer **")]
                IMseSourceBuffer* buffer
        );

        [VtblIndex(18)]
        HRESULT RemoveSourceBuffer(
            [NativeTypeName("ABI::Windows::Media::Core::IMseSourceBuffer *")]
                IMseSourceBuffer buffer
        );

        [VtblIndex(19)]
        HRESULT EndOfStream(
            [NativeTypeName("ABI::Windows::Media::Core::MseEndOfStreamStatus")]
                MseEndOfStreamStatus status
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Opened;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Opened;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Ended;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Ended;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMseStreamSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMseSourceBufferList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMseSourceBufferList*, int> get_SourceBuffers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMseSourceBufferList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMseSourceBufferList*, int> get_ActiveSourceBuffers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::MseReadyState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MseReadyState*, int> get_ReadyState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>**, int> get_Duration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>*, int> put_Duration;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Media::Core::IMseSourceBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IMseSourceBuffer*, int> AddSourceBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMseSourceBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMseSourceBuffer, int> RemoveSourceBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::MseEndOfStreamStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MseEndOfStreamStatus, int> EndOfStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMseStreamSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMseStreamSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMseStreamSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMseStreamSource(Silk.NET.WinRT.IInspectable value)
    {
        return new IMseStreamSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMseStreamSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMseStreamSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMseStreamSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMseStreamSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMseStreamSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMseStreamSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMseStreamSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMseStreamSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMseStreamSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
