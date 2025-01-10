// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("35FE1BB8-A3A9-40FE-BBEC-EB569C9CCCA3")]
[NativeTypeName("struct IMFWorkQueueServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFWorkQueueServices : IMFWorkQueueServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFWorkQueueServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFWorkQueueServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServices, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[3]
            )
        )(this, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, IMFAsyncResult, int>)((*lpVtbl)[4]))(
            this,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServices, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[5]
            )
        )(this, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, IMFAsyncResult, int>)((*lpVtbl)[6]))(
            this,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTopologyWorkQueueMMCSSClass(
        [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
        [NativeTypeName("LPWSTR")] ushort* pwszClass,
        [NativeTypeName("DWORD *")] uint* pcchClass
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServices, uint, ushort*, uint*, int>)((*lpVtbl)[7])
        )(this, dwTopologyWorkQueueId, pwszClass, pcchClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTopologyWorkQueueMMCSSTaskId(
        [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
        [NativeTypeName("DWORD *")] uint* pdwTaskId
    )
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, uint, uint*, int>)((*lpVtbl)[8]))(
            this,
            dwTopologyWorkQueueId,
            pdwTaskId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueue,
        [NativeTypeName("LPCWSTR")] ushort* wszClass,
        [NativeTypeName("DWORD")] uint dwTaskId,
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<
                IMFWorkQueueServices,
                uint,
                ushort*,
                uint,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[9])
        )(this, dwPlatformWorkQueue, wszClass, dwTaskId, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EndRegisterPlatformWorkQueueWithMMCSS(
        IMFAsyncResult pResult,
        [NativeTypeName("DWORD *")] uint* pdwTaskId
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServices, IMFAsyncResult, uint*, int>)((*lpVtbl)[10])
        )(this, pResult, pdwTaskId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueue,
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServices, uint, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[11]
            )
        )(this, dwPlatformWorkQueue, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, IMFAsyncResult, int>)((*lpVtbl)[12]))(
            this,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPlaftormWorkQueueMMCSSClass(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
        [NativeTypeName("LPWSTR")] ushort* pwszClass,
        [NativeTypeName("DWORD *")] uint* pcchClass
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServices, uint, ushort*, uint*, int>)((*lpVtbl)[13])
        )(this, dwPlatformWorkQueueId, pwszClass, pcchClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetPlatformWorkQueueMMCSSTaskId(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
        [NativeTypeName("DWORD *")] uint* pdwTaskId
    )
    {
        return ((delegate* unmanaged<IMFWorkQueueServices, uint, uint*, int>)((*lpVtbl)[14]))(
            this,
            dwPlatformWorkQueueId,
            pdwTaskId
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(4)]
        HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult);

        [VtblIndex(5)]
        HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(6)]
        HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult);

        [VtblIndex(7)]
        HRESULT GetTopologyWorkQueueMMCSSClass(
            [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
            [NativeTypeName("LPWSTR")] ushort* pwszClass,
            [NativeTypeName("DWORD *")] uint* pcchClass
        );

        [VtblIndex(8)]
        HRESULT GetTopologyWorkQueueMMCSSTaskId(
            [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
            [NativeTypeName("DWORD *")] uint* pdwTaskId
        );

        [VtblIndex(9)]
        HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(
            [NativeTypeName("DWORD")] uint dwPlatformWorkQueue,
            [NativeTypeName("LPCWSTR")] ushort* wszClass,
            [NativeTypeName("DWORD")] uint dwTaskId,
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(10)]
        HRESULT EndRegisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult,
            [NativeTypeName("DWORD *")] uint* pdwTaskId
        );

        [VtblIndex(11)]
        HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(
            [NativeTypeName("DWORD")] uint dwPlatformWorkQueue,
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(12)]
        HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(IMFAsyncResult pResult);

        [VtblIndex(13)]
        HRESULT GetPlaftormWorkQueueMMCSSClass(
            [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
            [NativeTypeName("LPWSTR")] ushort* pwszClass,
            [NativeTypeName("DWORD *")] uint* pcchClass
        );

        [VtblIndex(14)]
        HRESULT GetPlatformWorkQueueMMCSSTaskId(
            [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
            [NativeTypeName("DWORD *")] uint* pdwTaskId
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

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginRegisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            int> EndRegisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginUnregisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            int> EndUnregisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint*,
            int> GetTopologyWorkQueueMMCSSClass;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetTopologyWorkQueueMMCSSTaskId;

        [NativeTypeName(
            "HRESULT (DWORD, LPCWSTR, DWORD, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint,
            IMFAsyncCallback,
            IUnknown,
            int> BeginRegisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            uint*,
            int> EndRegisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (DWORD, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFAsyncCallback,
            IUnknown,
            int> BeginUnregisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            int> EndUnregisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint*,
            int> GetPlaftormWorkQueueMMCSSClass;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetPlatformWorkQueueMMCSSTaskId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFWorkQueueServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFWorkQueueServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFWorkQueueServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFWorkQueueServices(Silk.NET.Windows.IUnknown value)
    {
        return new IMFWorkQueueServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFWorkQueueServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFWorkQueueServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFWorkQueueServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
