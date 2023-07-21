// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxManifestTargetDeviceFamiliesEnumerator.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamiliesEnumerator"]/*' />
[Guid("36537F36-27A4-4788-88C0-733819575017")]
[NativeTypeName("struct IAppxManifestTargetDeviceFamiliesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestTargetDeviceFamiliesEnumerator : IAppxManifestTargetDeviceFamiliesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestTargetDeviceFamiliesEnumerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestTargetDeviceFamiliesEnumerator.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamiliesEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestTargetDeviceFamily** targetDeviceFamily)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, IAppxManifestTargetDeviceFamily**, int>)(lpVtbl[3]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), targetDeviceFamily);
    }

    /// <include file='IAppxManifestTargetDeviceFamiliesEnumerator.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamiliesEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestTargetDeviceFamiliesEnumerator.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamiliesEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestTargetDeviceFamily** targetDeviceFamily);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
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

        [NativeTypeName("HRESULT (IAppxManifestTargetDeviceFamily **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestTargetDeviceFamily**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}
