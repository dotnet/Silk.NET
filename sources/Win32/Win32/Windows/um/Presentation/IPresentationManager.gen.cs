// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FB562F82-6292-470A-88B1-843661E7F20C")]
[NativeTypeName("struct IPresentationManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentationManager : IPresentationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPresentationManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPresentationManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPresentationManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddBufferFromResource(IUnknown resource, IPresentationBuffer* presentationBuffer)
    {
        return (
            (delegate* unmanaged<IPresentationManager, IUnknown, IPresentationBuffer*, int>)(
                (*lpVtbl)[3]
            )
        )(this, resource, presentationBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreatePresentationSurface(
        HANDLE compositionSurfaceHandle,
        IPresentationSurface* presentationSurface
    )
    {
        return (
            (delegate* unmanaged<IPresentationManager, HANDLE, IPresentationSurface*, int>)(
                (*lpVtbl)[4]
            )
        )(this, compositionSurfaceHandle, presentationSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNextPresentId()
    {
        return ((delegate* unmanaged<IPresentationManager, ulong>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTargetTime(SystemInterruptTime targetTime)
    {
        return (
            (delegate* unmanaged<IPresentationManager, SystemInterruptTime, int>)((*lpVtbl)[6])
        )(this, targetTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPreferredPresentDuration(
        SystemInterruptTime preferredDuration,
        SystemInterruptTime deviationTolerance
    )
    {
        return (
            (delegate* unmanaged<
                IPresentationManager,
                SystemInterruptTime,
                SystemInterruptTime,
                int>)((*lpVtbl)[7])
        )(this, preferredDuration, deviationTolerance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ForceVSyncInterrupt([NativeTypeName("boolean")] byte forceVsyncInterrupt)
    {
        return ((delegate* unmanaged<IPresentationManager, byte, int>)((*lpVtbl)[8]))(
            this,
            forceVsyncInterrupt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Present()
    {
        return ((delegate* unmanaged<IPresentationManager, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPresentRetiringFence([NativeTypeName("const IID &")] Guid* riid, void** fence)
    {
        return ((delegate* unmanaged<IPresentationManager, Guid*, void**, int>)((*lpVtbl)[10]))(
            this,
            riid,
            fence
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CancelPresentsFrom([NativeTypeName("UINT64")] ulong presentIdToCancelFrom)
    {
        return ((delegate* unmanaged<IPresentationManager, ulong, int>)((*lpVtbl)[11]))(
            this,
            presentIdToCancelFrom
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLostEvent(HANDLE* lostEventHandle)
    {
        return ((delegate* unmanaged<IPresentationManager, HANDLE*, int>)((*lpVtbl)[12]))(
            this,
            lostEventHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPresentStatisticsAvailableEvent(HANDLE* presentStatisticsAvailableEventHandle)
    {
        return ((delegate* unmanaged<IPresentationManager, HANDLE*, int>)((*lpVtbl)[13]))(
            this,
            presentStatisticsAvailableEventHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnablePresentStatisticsKind(
        PresentStatisticsKind presentStatisticsKind,
        [NativeTypeName("boolean")] byte enabled
    )
    {
        return (
            (delegate* unmanaged<IPresentationManager, PresentStatisticsKind, byte, int>)(
                (*lpVtbl)[14]
            )
        )(this, presentStatisticsKind, enabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetNextPresentStatistics(IPresentStatistics* nextPresentStatistics)
    {
        return (
            (delegate* unmanaged<IPresentationManager, IPresentStatistics*, int>)((*lpVtbl)[15])
        )(this, nextPresentStatistics);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddBufferFromResource(IUnknown resource, IPresentationBuffer* presentationBuffer);

        [VtblIndex(4)]
        HRESULT CreatePresentationSurface(
            HANDLE compositionSurfaceHandle,
            IPresentationSurface* presentationSurface
        );

        [VtblIndex(5)]
        [return: NativeTypeName("UINT64")]
        ulong GetNextPresentId();

        [VtblIndex(6)]
        HRESULT SetTargetTime(SystemInterruptTime targetTime);

        [VtblIndex(7)]
        HRESULT SetPreferredPresentDuration(
            SystemInterruptTime preferredDuration,
            SystemInterruptTime deviationTolerance
        );

        [VtblIndex(8)]
        HRESULT ForceVSyncInterrupt([NativeTypeName("boolean")] byte forceVsyncInterrupt);

        [VtblIndex(9)]
        HRESULT Present();

        [VtblIndex(10)]
        HRESULT GetPresentRetiringFence([NativeTypeName("const IID &")] Guid* riid, void** fence);

        [VtblIndex(11)]
        HRESULT CancelPresentsFrom([NativeTypeName("UINT64")] ulong presentIdToCancelFrom);

        [VtblIndex(12)]
        HRESULT GetLostEvent(HANDLE* lostEventHandle);

        [VtblIndex(13)]
        HRESULT GetPresentStatisticsAvailableEvent(HANDLE* presentStatisticsAvailableEventHandle);

        [VtblIndex(14)]
        HRESULT EnablePresentStatisticsKind(
            PresentStatisticsKind presentStatisticsKind,
            [NativeTypeName("boolean")] byte enabled
        );

        [VtblIndex(15)]
        HRESULT GetNextPresentStatistics(IPresentStatistics* nextPresentStatistics);
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

        [NativeTypeName("HRESULT (IUnknown *, IPresentationBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IPresentationBuffer*,
            int> AddBufferFromResource;

        [NativeTypeName("HRESULT (HANDLE, IPresentationSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HANDLE,
            IPresentationSurface*,
            int> CreatePresentationSurface;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetNextPresentId;

        [NativeTypeName("HRESULT (SystemInterruptTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SystemInterruptTime, int> SetTargetTime;

        [NativeTypeName(
            "HRESULT (SystemInterruptTime, SystemInterruptTime) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SystemInterruptTime,
            SystemInterruptTime,
            int> SetPreferredPresentDuration;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> ForceVSyncInterrupt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Present;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetPresentRetiringFence;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> CancelPresentsFrom;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetLostEvent;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetPresentStatisticsAvailableEvent;

        [NativeTypeName("HRESULT (PresentStatisticsKind, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            PresentStatisticsKind,
            byte,
            int> EnablePresentStatisticsKind;

        [NativeTypeName("HRESULT (IPresentStatistics **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPresentStatistics*, int> GetNextPresentStatistics;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPresentationManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPresentationManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPresentationManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPresentationManager(Silk.NET.Windows.IUnknown value)
    {
        return new IPresentationManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentationManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentationManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPresentationManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
