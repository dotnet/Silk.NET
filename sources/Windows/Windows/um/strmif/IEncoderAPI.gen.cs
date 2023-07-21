// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI"]/*' />
[Guid("70423839-6ACC-4B23-B079-21DBF08156A5")]
[NativeTypeName("struct IEncoderAPI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEncoderAPI : IEncoderAPI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEncoderAPI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, void**, int>)(lpVtbl[0]))((IEncoderAPI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEncoderAPI*, uint>)(lpVtbl[1]))((IEncoderAPI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEncoderAPI*, uint>)(lpVtbl[2]))((IEncoderAPI*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, int>)(lpVtbl[3]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api);
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.IsAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsAvailable([NativeTypeName("const GUID *")] Guid* Api)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, int>)(lpVtbl[4]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api);
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.GetParameterRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.GetParameterValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.GetDefaultValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[7]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.GetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[8]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
    }

    /// <include file='IEncoderAPI.xml' path='doc/member[@name="IEncoderAPI.SetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
    {
        return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[9]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api);

        [VtblIndex(4)]
        HRESULT IsAvailable([NativeTypeName("const GUID *")] Guid* Api);

        [VtblIndex(5)]
        HRESULT GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta);

        [VtblIndex(6)]
        HRESULT GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount);

        [VtblIndex(7)]
        HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value);

        [VtblIndex(8)]
        HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value);

        [VtblIndex(9)]
        HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value);
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

        [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsSupported;

        [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsAvailable;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, VARIANT*, VARIANT*, int> GetParameterRange;

        [NativeTypeName("HRESULT (const GUID *, VARIANT **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT**, uint*, int> GetParameterValues;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> GetDefaultValue;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> GetValue;

        [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> SetValue;
    }
}
