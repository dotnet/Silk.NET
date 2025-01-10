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

[Guid("64976BFA-FB61-4041-9069-8C9A5F659BEB")]
[NativeTypeName("struct IMFByteStreamTimeSeek : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFByteStreamTimeSeek : IMFByteStreamTimeSeek.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStreamTimeSeek));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFByteStreamTimeSeek, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsTimeSeekSupported(BOOL* pfTimeSeekIsSupported)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            pfTimeSeekIsSupported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TimeSeek([NativeTypeName("QWORD")] ulong qwTimePosition)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek, ulong, int>)((*lpVtbl)[4]))(
            this,
            qwTimePosition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTimeSeekResult(
        [NativeTypeName("QWORD *")] ulong* pqwStartTime,
        [NativeTypeName("QWORD *")] ulong* pqwStopTime,
        [NativeTypeName("QWORD *")] ulong* pqwDuration
    )
    {
        return (
            (delegate* unmanaged<IMFByteStreamTimeSeek, ulong*, ulong*, ulong*, int>)((*lpVtbl)[5])
        )(this, pqwStartTime, pqwStopTime, pqwDuration);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsTimeSeekSupported(BOOL* pfTimeSeekIsSupported);

        [VtblIndex(4)]
        HRESULT TimeSeek([NativeTypeName("QWORD")] ulong qwTimePosition);

        [VtblIndex(5)]
        HRESULT GetTimeSeekResult(
            [NativeTypeName("QWORD *")] ulong* pqwStartTime,
            [NativeTypeName("QWORD *")] ulong* pqwStopTime,
            [NativeTypeName("QWORD *")] ulong* pqwDuration
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsTimeSeekSupported;

        [NativeTypeName("HRESULT (QWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> TimeSeek;

        [NativeTypeName("HRESULT (QWORD *, QWORD *, QWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, ulong*, int> GetTimeSeekResult;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFByteStreamTimeSeek"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFByteStreamTimeSeek(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFByteStreamTimeSeek"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFByteStreamTimeSeek(Silk.NET.Windows.IUnknown value)
    {
        return new IMFByteStreamTimeSeek(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStreamTimeSeek"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStreamTimeSeek"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFByteStreamTimeSeek value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
