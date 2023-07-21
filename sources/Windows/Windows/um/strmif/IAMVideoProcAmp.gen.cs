// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMVideoProcAmp.xml' path='doc/member[@name="IAMVideoProcAmp"]/*' />
[Guid("C6E13360-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMVideoProcAmp : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMVideoProcAmp : IAMVideoProcAmp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMVideoProcAmp));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMVideoProcAmp*, Guid*, void**, int>)(lpVtbl[0]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMVideoProcAmp*, uint>)(lpVtbl[1]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMVideoProcAmp*, uint>)(lpVtbl[2]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMVideoProcAmp.xml' path='doc/member[@name="IAMVideoProcAmp.GetRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRange([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* pMin, [NativeTypeName("long *")] int* pMax, [NativeTypeName("long *")] int* pSteppingDelta, [NativeTypeName("long *")] int* pDefault, [NativeTypeName("long *")] int* pCapsFlags)
    {
        return ((delegate* unmanaged<IAMVideoProcAmp*, int, int*, int*, int*, int*, int*, int>)(lpVtbl[3]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), Property, pMin, pMax, pSteppingDelta, pDefault, pCapsFlags);
    }

    /// <include file='IAMVideoProcAmp.xml' path='doc/member[@name="IAMVideoProcAmp.Set"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Set([NativeTypeName("long")] int Property, [NativeTypeName("long")] int lValue, [NativeTypeName("long")] int Flags)
    {
        return ((delegate* unmanaged<IAMVideoProcAmp*, int, int, int, int>)(lpVtbl[4]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), Property, lValue, Flags);
    }

    /// <include file='IAMVideoProcAmp.xml' path='doc/member[@name="IAMVideoProcAmp.Get"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Get([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* lValue, [NativeTypeName("long *")] int* Flags)
    {
        return ((delegate* unmanaged<IAMVideoProcAmp*, int, int*, int*, int>)(lpVtbl[5]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), Property, lValue, Flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRange([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* pMin, [NativeTypeName("long *")] int* pMax, [NativeTypeName("long *")] int* pSteppingDelta, [NativeTypeName("long *")] int* pDefault, [NativeTypeName("long *")] int* pCapsFlags);

        [VtblIndex(4)]
        HRESULT Set([NativeTypeName("long")] int Property, [NativeTypeName("long")] int lValue, [NativeTypeName("long")] int Flags);

        [VtblIndex(5)]
        HRESULT Get([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* lValue, [NativeTypeName("long *")] int* Flags);
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

        [NativeTypeName("HRESULT (long, long *, long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int*, int*, int*, int*, int> GetRange;

        [NativeTypeName("HRESULT (long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int> Set;

        [NativeTypeName("HRESULT (long, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int*, int> Get;
    }
}
