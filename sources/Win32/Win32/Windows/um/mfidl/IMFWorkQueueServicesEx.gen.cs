// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("96BF961B-40FE-42F1-BA9D-320238B49700")]
[NativeTypeName("struct IMFWorkQueueServicesEx : IMFWorkQueueServices")]
[NativeInheritance("IMFWorkQueueServices")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFWorkQueueServicesEx : IMFWorkQueueServicesEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFWorkQueueServicesEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<IMFWorkQueueServicesEx, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[3]
            )
        )(this, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, IMFAsyncResult, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IMFWorkQueueServicesEx, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[5]
            )
        )(this, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, IMFAsyncResult, int>)((*lpVtbl)[6]))(
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
            (delegate* unmanaged<IMFWorkQueueServicesEx, uint, ushort*, uint*, int>)((*lpVtbl)[7])
        )(this, dwTopologyWorkQueueId, pwszClass, pcchClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTopologyWorkQueueMMCSSTaskId(
        [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
        [NativeTypeName("DWORD *")] uint* pdwTaskId
    )
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, uint, uint*, int>)((*lpVtbl)[8]))(
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
                IMFWorkQueueServicesEx,
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
            (delegate* unmanaged<IMFWorkQueueServicesEx, IMFAsyncResult, uint*, int>)((*lpVtbl)[10])
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
            (delegate* unmanaged<IMFWorkQueueServicesEx, uint, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[11]
            )
        )(this, dwPlatformWorkQueue, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, IMFAsyncResult, int>)((*lpVtbl)[12]))(
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
            (delegate* unmanaged<IMFWorkQueueServicesEx, uint, ushort*, uint*, int>)((*lpVtbl)[13])
        )(this, dwPlatformWorkQueueId, pwszClass, pcchClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetPlatformWorkQueueMMCSSTaskId(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
        [NativeTypeName("DWORD *")] uint* pdwTaskId
    )
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, uint, uint*, int>)((*lpVtbl)[14]))(
            this,
            dwPlatformWorkQueueId,
            pdwTaskId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTopologyWorkQueueMMCSSPriority(
        [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
        [NativeTypeName("LONG *")] int* plPriority
    )
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, uint, int*, int>)((*lpVtbl)[15]))(
            this,
            dwTopologyWorkQueueId,
            plPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueue,
        [NativeTypeName("LPCWSTR")] ushort* wszClass,
        [NativeTypeName("DWORD")] uint dwTaskId,
        [NativeTypeName("LONG")] int lPriority,
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<
                IMFWorkQueueServicesEx,
                uint,
                ushort*,
                uint,
                int,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[16])
        )(this, dwPlatformWorkQueue, wszClass, dwTaskId, lPriority, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPlatformWorkQueueMMCSSPriority(
        [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
        [NativeTypeName("LONG *")] int* plPriority
    )
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx, uint, int*, int>)((*lpVtbl)[17]))(
            this,
            dwPlatformWorkQueueId,
            plPriority
        );
    }

    public interface Interface : IMFWorkQueueServices.Interface
    {
        [VtblIndex(15)]
        HRESULT GetTopologyWorkQueueMMCSSPriority(
            [NativeTypeName("DWORD")] uint dwTopologyWorkQueueId,
            [NativeTypeName("LONG *")] int* plPriority
        );

        [VtblIndex(16)]
        HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx(
            [NativeTypeName("DWORD")] uint dwPlatformWorkQueue,
            [NativeTypeName("LPCWSTR")] ushort* wszClass,
            [NativeTypeName("DWORD")] uint dwTaskId,
            [NativeTypeName("LONG")] int lPriority,
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(17)]
        HRESULT GetPlatformWorkQueueMMCSSPriority(
            [NativeTypeName("DWORD")] uint dwPlatformWorkQueueId,
            [NativeTypeName("LONG *")] int* plPriority
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

        [NativeTypeName("HRESULT (DWORD, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> GetTopologyWorkQueueMMCSSPriority;

        [NativeTypeName(
            "HRESULT (DWORD, LPCWSTR, DWORD, LONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint,
            int,
            IMFAsyncCallback,
            IUnknown,
            int> BeginRegisterPlatformWorkQueueWithMMCSSEx;

        [NativeTypeName("HRESULT (DWORD, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> GetPlatformWorkQueueMMCSSPriority;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFWorkQueueServicesEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFWorkQueueServicesEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFWorkQueueServices"/> to <see cref = "IMFWorkQueueServicesEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFWorkQueueServices"/> instance to be converted </param>
    public static explicit operator IMFWorkQueueServicesEx(
        Silk.NET.Windows.IMFWorkQueueServices value
    )
    {
        return new IMFWorkQueueServicesEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFWorkQueueServicesEx"/> to <see cref = "Silk.NET.Windows.IMFWorkQueueServices"/>.</summary>
    /// <param name = "value">The <see cref = "IMFWorkQueueServicesEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFWorkQueueServices(
        IMFWorkQueueServicesEx value
    )
    {
        return new Silk.NET.Windows.IMFWorkQueueServices(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFWorkQueueServicesEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFWorkQueueServicesEx(Silk.NET.Windows.IUnknown value)
    {
        return new IMFWorkQueueServicesEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFWorkQueueServicesEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFWorkQueueServicesEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFWorkQueueServicesEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
