// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMF2DBuffer2.xml' path='doc/member[@name="IMF2DBuffer2"]/*'/>
[Guid("33AE5EA6-4316-436F-8DDD-D73D22F829EC")]
[NativeTypeName("struct IMF2DBuffer2 : IMF2DBuffer")]
[NativeInheritance("IMF2DBuffer")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMF2DBuffer2 : IMF2DBuffer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMF2DBuffer2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, Guid*, void**, int> )(lpVtbl[0]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, uint> )(lpVtbl[1]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, uint> )(lpVtbl[2]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMF2DBuffer.Lock2D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock2D(byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, byte**, int*, int> )(lpVtbl[3]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), ppbScanline0, plPitch);
    }

    /// <inheritdoc cref = "IMF2DBuffer.Unlock2D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock2D()
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, int> )(lpVtbl[4]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMF2DBuffer.GetScanline0AndPitch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetScanline0AndPitch(byte** pbScanline0, [NativeTypeName("LONG *")] int* plPitch)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, byte**, int*, int> )(lpVtbl[5]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pbScanline0, plPitch);
    }

    /// <inheritdoc cref = "IMF2DBuffer.IsContiguousFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsContiguousFormat(BOOL* pfIsContiguous)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, BOOL*, int> )(lpVtbl[6]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pfIsContiguous);
    }

    /// <inheritdoc cref = "IMF2DBuffer.GetContiguousLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetContiguousLength([NativeTypeName("DWORD *")] uint* pcbLength)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, uint*, int> )(lpVtbl[7]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pcbLength);
    }

    /// <inheritdoc cref = "IMF2DBuffer.ContiguousCopyTo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ContiguousCopyTo(byte* pbDestBuffer, [NativeTypeName("DWORD")] uint cbDestBuffer)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, byte*, uint, int> )(lpVtbl[8]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pbDestBuffer, cbDestBuffer);
    }

    /// <inheritdoc cref = "IMF2DBuffer.ContiguousCopyFrom"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ContiguousCopyFrom([NativeTypeName("const BYTE *")] byte* pbSrcBuffer, [NativeTypeName("DWORD")] uint cbSrcBuffer)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, byte*, uint, int> )(lpVtbl[9]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pbSrcBuffer, cbSrcBuffer);
    }

    /// <include file='IMF2DBuffer2.xml' path='doc/member[@name="IMF2DBuffer2.Lock2DSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Lock2DSize(MF2DBuffer_LockFlags lockFlags, byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch, byte** ppbBufferStart, [NativeTypeName("DWORD *")] uint* pcbBufferLength)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, MF2DBuffer_LockFlags, byte**, int*, byte**, uint*, int> )(lpVtbl[10]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), lockFlags, ppbScanline0, plPitch, ppbBufferStart, pcbBufferLength);
    }

    /// <include file='IMF2DBuffer2.xml' path='doc/member[@name="IMF2DBuffer2.Copy2DTo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Copy2DTo(IMF2DBuffer2* pDestBuffer)
    {
        return ((delegate* unmanaged<IMF2DBuffer2*, IMF2DBuffer2*, int> )(lpVtbl[11]))((IMF2DBuffer2*)Unsafe.AsPointer(ref this), pDestBuffer);
    }

    public interface Interface : IMF2DBuffer.Interface
    {
        [VtblIndex(10)]
        HRESULT Lock2DSize(MF2DBuffer_LockFlags lockFlags, byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch, byte** ppbBufferStart, [NativeTypeName("DWORD *")] uint* pcbBufferLength);
        [VtblIndex(11)]
        HRESULT Copy2DTo(IMF2DBuffer2* pDestBuffer);
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
        [NativeTypeName("HRESULT (BYTE **, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int*, int> Lock2D;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock2D;
        [NativeTypeName("HRESULT (BYTE **, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int*, int> GetScanline0AndPitch;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsContiguousFormat;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetContiguousLength;
        [NativeTypeName("HRESULT (BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> ContiguousCopyTo;
        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> ContiguousCopyFrom;
        [NativeTypeName("HRESULT (MF2DBuffer_LockFlags, BYTE **, LONG *, BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF2DBuffer_LockFlags, byte**, int*, byte**, uint*, int> Lock2DSize;
        [NativeTypeName("HRESULT (IMF2DBuffer2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMF2DBuffer2*, int> Copy2DTo;
    }
}