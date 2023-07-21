// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxContentGroupMapWriter.xml' path='doc/member[@name="IAppxContentGroupMapWriter"]/*' />
[Guid("D07AB776-A9DE-4798-8C14-3DB31E687C78")]
[NativeTypeName("struct IAppxContentGroupMapWriter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxContentGroupMapWriter : IAppxContentGroupMapWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxContentGroupMapWriter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxContentGroupMapWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxContentGroupMapWriter*, uint>)(lpVtbl[1]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxContentGroupMapWriter*, uint>)(lpVtbl[2]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxContentGroupMapWriter.xml' path='doc/member[@name="IAppxContentGroupMapWriter.AddAutomaticGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddAutomaticGroup([NativeTypeName("LPCWSTR")] ushort* groupName)
    {
        return ((delegate* unmanaged<IAppxContentGroupMapWriter*, ushort*, int>)(lpVtbl[3]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this), groupName);
    }

    /// <include file='IAppxContentGroupMapWriter.xml' path='doc/member[@name="IAppxContentGroupMapWriter.AddAutomaticFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddAutomaticFile([NativeTypeName("LPCWSTR")] ushort* fileName)
    {
        return ((delegate* unmanaged<IAppxContentGroupMapWriter*, ushort*, int>)(lpVtbl[4]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this), fileName);
    }

    /// <include file='IAppxContentGroupMapWriter.xml' path='doc/member[@name="IAppxContentGroupMapWriter.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IAppxContentGroupMapWriter*, int>)(lpVtbl[5]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddAutomaticGroup([NativeTypeName("LPCWSTR")] ushort* groupName);

        [VtblIndex(4)]
        HRESULT AddAutomaticFile([NativeTypeName("LPCWSTR")] ushort* fileName);

        [VtblIndex(5)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddAutomaticGroup;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddAutomaticFile;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}
