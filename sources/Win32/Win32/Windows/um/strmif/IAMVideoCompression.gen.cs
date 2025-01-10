// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C6E13343-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMVideoCompression : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMVideoCompression : IAMVideoCompression.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMVideoCompression));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMVideoCompression, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMVideoCompression, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMVideoCompression, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_KeyFrameRate([NativeTypeName("long")] int KeyFrameRate)
    {
        return ((delegate* unmanaged<IAMVideoCompression, int, int>)((*lpVtbl)[3]))(
            this,
            KeyFrameRate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_KeyFrameRate([NativeTypeName("long *")] int* pKeyFrameRate)
    {
        return ((delegate* unmanaged<IAMVideoCompression, int*, int>)((*lpVtbl)[4]))(
            this,
            pKeyFrameRate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_PFramesPerKeyFrame([NativeTypeName("long")] int PFramesPerKeyFrame)
    {
        return ((delegate* unmanaged<IAMVideoCompression, int, int>)((*lpVtbl)[5]))(
            this,
            PFramesPerKeyFrame
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PFramesPerKeyFrame([NativeTypeName("long *")] int* pPFramesPerKeyFrame)
    {
        return ((delegate* unmanaged<IAMVideoCompression, int*, int>)((*lpVtbl)[6]))(
            this,
            pPFramesPerKeyFrame
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Quality(double Quality)
    {
        return ((delegate* unmanaged<IAMVideoCompression, double, int>)((*lpVtbl)[7]))(
            this,
            Quality
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Quality(double* pQuality)
    {
        return ((delegate* unmanaged<IAMVideoCompression, double*, int>)((*lpVtbl)[8]))(
            this,
            pQuality
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_WindowSize([NativeTypeName("DWORDLONG")] ulong WindowSize)
    {
        return ((delegate* unmanaged<IAMVideoCompression, ulong, int>)((*lpVtbl)[9]))(
            this,
            WindowSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WindowSize([NativeTypeName("DWORDLONG *")] ulong* pWindowSize)
    {
        return ((delegate* unmanaged<IAMVideoCompression, ulong*, int>)((*lpVtbl)[10]))(
            this,
            pWindowSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInfo(
        [NativeTypeName("LPWSTR")] ushort* pszVersion,
        int* pcbVersion,
        [NativeTypeName("LPWSTR")] ushort* pszDescription,
        int* pcbDescription,
        [NativeTypeName("long *")] int* pDefaultKeyFrameRate,
        [NativeTypeName("long *")] int* pDefaultPFramesPerKey,
        double* pDefaultQuality,
        [NativeTypeName("long *")] int* pCapabilities
    )
    {
        return (
            (delegate* unmanaged<
                IAMVideoCompression,
                ushort*,
                int*,
                ushort*,
                int*,
                int*,
                int*,
                double*,
                int*,
                int>)((*lpVtbl)[11])
        )(
            this,
            pszVersion,
            pcbVersion,
            pszDescription,
            pcbDescription,
            pDefaultKeyFrameRate,
            pDefaultPFramesPerKey,
            pDefaultQuality,
            pCapabilities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OverrideKeyFrame([NativeTypeName("long")] int FrameNumber)
    {
        return ((delegate* unmanaged<IAMVideoCompression, int, int>)((*lpVtbl)[12]))(
            this,
            FrameNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OverrideFrameSize(
        [NativeTypeName("long")] int FrameNumber,
        [NativeTypeName("long")] int Size
    )
    {
        return ((delegate* unmanaged<IAMVideoCompression, int, int, int>)((*lpVtbl)[13]))(
            this,
            FrameNumber,
            Size
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT put_KeyFrameRate([NativeTypeName("long")] int KeyFrameRate);

        [VtblIndex(4)]
        HRESULT get_KeyFrameRate([NativeTypeName("long *")] int* pKeyFrameRate);

        [VtblIndex(5)]
        HRESULT put_PFramesPerKeyFrame([NativeTypeName("long")] int PFramesPerKeyFrame);

        [VtblIndex(6)]
        HRESULT get_PFramesPerKeyFrame([NativeTypeName("long *")] int* pPFramesPerKeyFrame);

        [VtblIndex(7)]
        HRESULT put_Quality(double Quality);

        [VtblIndex(8)]
        HRESULT get_Quality(double* pQuality);

        [VtblIndex(9)]
        HRESULT put_WindowSize([NativeTypeName("DWORDLONG")] ulong WindowSize);

        [VtblIndex(10)]
        HRESULT get_WindowSize([NativeTypeName("DWORDLONG *")] ulong* pWindowSize);

        [VtblIndex(11)]
        HRESULT GetInfo(
            [NativeTypeName("LPWSTR")] ushort* pszVersion,
            int* pcbVersion,
            [NativeTypeName("LPWSTR")] ushort* pszDescription,
            int* pcbDescription,
            [NativeTypeName("long *")] int* pDefaultKeyFrameRate,
            [NativeTypeName("long *")] int* pDefaultPFramesPerKey,
            double* pDefaultQuality,
            [NativeTypeName("long *")] int* pCapabilities
        );

        [VtblIndex(12)]
        HRESULT OverrideKeyFrame([NativeTypeName("long")] int FrameNumber);

        [VtblIndex(13)]
        HRESULT OverrideFrameSize(
            [NativeTypeName("long")] int FrameNumber,
            [NativeTypeName("long")] int Size
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

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_KeyFrameRate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_KeyFrameRate;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_PFramesPerKeyFrame;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PFramesPerKeyFrame;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Quality;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Quality;

        [NativeTypeName("HRESULT (DWORDLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> put_WindowSize;

        [NativeTypeName("HRESULT (DWORDLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_WindowSize;

        [NativeTypeName(
            "HRESULT (LPWSTR, int *, LPWSTR, int *, long *, long *, double *, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int*,
            ushort*,
            int*,
            int*,
            int*,
            double*,
            int*,
            int> GetInfo;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> OverrideKeyFrame;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> OverrideFrameSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMVideoCompression"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMVideoCompression(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMVideoCompression"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMVideoCompression(Silk.NET.Windows.IUnknown value)
    {
        return new IAMVideoCompression(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMVideoCompression"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMVideoCompression"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMVideoCompression value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
