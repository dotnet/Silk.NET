// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaBuffer.xml' path='doc/member[@name="IMFMediaBuffer"]/*'/>
[Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
[NativeTypeName("struct IMFMediaBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaBuffer : IMFMediaBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaBuffer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, uint> )(lpVtbl[1]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, uint> )(lpVtbl[2]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaBuffer.xml' path='doc/member[@name="IMFMediaBuffer.Lock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock(byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, byte**, uint*, uint*, int> )(lpVtbl[3]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), ppbBuffer, pcbMaxLength, pcbCurrentLength);
    }

    /// <include file='IMFMediaBuffer.xml' path='doc/member[@name="IMFMediaBuffer.Unlock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, int> )(lpVtbl[4]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaBuffer.xml' path='doc/member[@name="IMFMediaBuffer.GetCurrentLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, uint*, int> )(lpVtbl[5]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), pcbCurrentLength);
    }

    /// <include file='IMFMediaBuffer.xml' path='doc/member[@name="IMFMediaBuffer.SetCurrentLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, uint, int> )(lpVtbl[6]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), cbCurrentLength);
    }

    /// <include file='IMFMediaBuffer.xml' path='doc/member[@name="IMFMediaBuffer.GetMaxLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer*, uint*, int> )(lpVtbl[7]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Lock(byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength);
        [VtblIndex(4)]
        HRESULT Unlock();
        [VtblIndex(5)]
        HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength);
        [VtblIndex(6)]
        HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength);
        [VtblIndex(7)]
        HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength);
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
        [NativeTypeName("HRESULT (BYTE **, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint*, int> Lock;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentLength;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentLength;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxLength;
    }
}