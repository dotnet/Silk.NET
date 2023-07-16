// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDirectWriterLock.xml' path='doc/member[@name="IDirectWriterLock"]/*'/>
[Guid("0E6D4D92-6738-11CF-9608-00AA00680DB4")]
[NativeTypeName("struct IDirectWriterLock : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectWriterLock : IDirectWriterLock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectWriterLock));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectWriterLock*, Guid*, void**, int> )(lpVtbl[0]))((IDirectWriterLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectWriterLock*, uint> )(lpVtbl[1]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectWriterLock*, uint> )(lpVtbl[2]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectWriterLock.xml' path='doc/member[@name="IDirectWriterLock.WaitForWriteAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT WaitForWriteAccess([NativeTypeName("DWORD")] uint dwTimeout)
    {
        return ((delegate* unmanaged<IDirectWriterLock*, uint, int> )(lpVtbl[3]))((IDirectWriterLock*)Unsafe.AsPointer(ref this), dwTimeout);
    }

    /// <include file='IDirectWriterLock.xml' path='doc/member[@name="IDirectWriterLock.ReleaseWriteAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReleaseWriteAccess()
    {
        return ((delegate* unmanaged<IDirectWriterLock*, int> )(lpVtbl[4]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectWriterLock.xml' path='doc/member[@name="IDirectWriterLock.HaveWriteAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HaveWriteAccess()
    {
        return ((delegate* unmanaged<IDirectWriterLock*, int> )(lpVtbl[5]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT WaitForWriteAccess([NativeTypeName("DWORD")] uint dwTimeout);
        [VtblIndex(4)]
        HRESULT ReleaseWriteAccess();
        [VtblIndex(5)]
        HRESULT HaveWriteAccess();
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
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitForWriteAccess;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseWriteAccess;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HaveWriteAccess;
    }
}