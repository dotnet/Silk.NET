// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFByteStreamTimeSeek.xml' path='doc/member[@name="IMFByteStreamTimeSeek"]/*'/>
[Guid("64976BFA-FB61-4041-9069-8C9A5F659BEB")]
[NativeTypeName("struct IMFByteStreamTimeSeek : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFByteStreamTimeSeek : IMFByteStreamTimeSeek.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStreamTimeSeek));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek*, Guid*, void**, int> )(lpVtbl[0]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek*, uint> )(lpVtbl[1]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek*, uint> )(lpVtbl[2]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFByteStreamTimeSeek.xml' path='doc/member[@name="IMFByteStreamTimeSeek.IsTimeSeekSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsTimeSeekSupported(BOOL* pfTimeSeekIsSupported)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek*, BOOL*, int> )(lpVtbl[3]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), pfTimeSeekIsSupported);
    }

    /// <include file='IMFByteStreamTimeSeek.xml' path='doc/member[@name="IMFByteStreamTimeSeek.TimeSeek"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TimeSeek([NativeTypeName("QWORD")] ulong qwTimePosition)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek*, ulong, int> )(lpVtbl[4]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), qwTimePosition);
    }

    /// <include file='IMFByteStreamTimeSeek.xml' path='doc/member[@name="IMFByteStreamTimeSeek.GetTimeSeekResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration)
    {
        return ((delegate* unmanaged<IMFByteStreamTimeSeek*, ulong*, ulong*, ulong*, int> )(lpVtbl[5]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), pqwStartTime, pqwStopTime, pqwDuration);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsTimeSeekSupported(BOOL* pfTimeSeekIsSupported);
        [VtblIndex(4)]
        HRESULT TimeSeek([NativeTypeName("QWORD")] ulong qwTimePosition);
        [VtblIndex(5)]
        HRESULT GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration);
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
}