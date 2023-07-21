// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfInputProcessorProfileSubstituteLayout.xml' path='doc/member[@name="ITfInputProcessorProfileSubstituteLayout"]/*' />
[Guid("4FD67194-1002-4513-BFF2-C0DDF6258552")]
[NativeTypeName("struct ITfInputProcessorProfileSubstituteLayout : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputProcessorProfileSubstituteLayout : ITfInputProcessorProfileSubstituteLayout.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfileSubstituteLayout));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, uint>)(lpVtbl[1]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, uint>)(lpVtbl[2]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfInputProcessorProfileSubstituteLayout.xml' path='doc/member[@name="ITfInputProcessorProfileSubstituteLayout.GetSubstituteKeyboardLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSubstituteKeyboardLayout([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL* phKL)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, Guid*, ushort, Guid*, HKL*, int>)(lpVtbl[3]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, phKL);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSubstituteKeyboardLayout([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL* phKL);
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

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, HKL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, HKL*, int> GetSubstituteKeyboardLayout;
    }
}
