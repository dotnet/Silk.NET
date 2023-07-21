// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer"]/*' />
[Guid("7DC9D5F9-9ED9-44EC-9BBF-0600BB589FBB")]
[NativeTypeName("struct IMF2DBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMF2DBuffer : IMF2DBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMF2DBuffer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMF2DBuffer*, uint>)(lpVtbl[1]))((IMF2DBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMF2DBuffer*, uint>)(lpVtbl[2]))((IMF2DBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.Lock2D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock2D(byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, byte**, int*, int>)(lpVtbl[3]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), ppbScanline0, plPitch);
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.Unlock2D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock2D()
    {
        return ((delegate* unmanaged<IMF2DBuffer*, int>)(lpVtbl[4]))((IMF2DBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.GetScanline0AndPitch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetScanline0AndPitch(byte** pbScanline0, [NativeTypeName("LONG *")] int* plPitch)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, byte**, int*, int>)(lpVtbl[5]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pbScanline0, plPitch);
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.IsContiguousFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsContiguousFormat(BOOL* pfIsContiguous)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, BOOL*, int>)(lpVtbl[6]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pfIsContiguous);
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.GetContiguousLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetContiguousLength([NativeTypeName("DWORD *")] uint* pcbLength)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, uint*, int>)(lpVtbl[7]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pcbLength);
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.ContiguousCopyTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ContiguousCopyTo(byte* pbDestBuffer, [NativeTypeName("DWORD")] uint cbDestBuffer)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, byte*, uint, int>)(lpVtbl[8]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pbDestBuffer, cbDestBuffer);
    }

    /// <include file='IMF2DBuffer.xml' path='doc/member[@name="IMF2DBuffer.ContiguousCopyFrom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ContiguousCopyFrom([NativeTypeName("const BYTE *")] byte* pbSrcBuffer, [NativeTypeName("DWORD")] uint cbSrcBuffer)
    {
        return ((delegate* unmanaged<IMF2DBuffer*, byte*, uint, int>)(lpVtbl[9]))((IMF2DBuffer*)Unsafe.AsPointer(ref this), pbSrcBuffer, cbSrcBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Lock2D(byte** ppbScanline0, [NativeTypeName("LONG *")] int* plPitch);

        [VtblIndex(4)]
        HRESULT Unlock2D();

        [VtblIndex(5)]
        HRESULT GetScanline0AndPitch(byte** pbScanline0, [NativeTypeName("LONG *")] int* plPitch);

        [VtblIndex(6)]
        HRESULT IsContiguousFormat(BOOL* pfIsContiguous);

        [VtblIndex(7)]
        HRESULT GetContiguousLength([NativeTypeName("DWORD *")] uint* pcbLength);

        [VtblIndex(8)]
        HRESULT ContiguousCopyTo(byte* pbDestBuffer, [NativeTypeName("DWORD")] uint cbDestBuffer);

        [VtblIndex(9)]
        HRESULT ContiguousCopyFrom([NativeTypeName("const BYTE *")] byte* pbSrcBuffer, [NativeTypeName("DWORD")] uint cbSrcBuffer);
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
    }
}
