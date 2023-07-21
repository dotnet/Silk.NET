// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFSignedLibrary.xml' path='doc/member[@name="IMFSignedLibrary"]/*' />
[Guid("4A724BCA-FF6A-4C07-8E0D-7A358421CF06")]
[NativeTypeName("struct IMFSignedLibrary : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSignedLibrary : IMFSignedLibrary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSignedLibrary));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSignedLibrary*, Guid*, void**, int>)(lpVtbl[0]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSignedLibrary*, uint>)(lpVtbl[1]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSignedLibrary*, uint>)(lpVtbl[2]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSignedLibrary.xml' path='doc/member[@name="IMFSignedLibrary.GetProcedureAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetProcedureAddress([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("PVOID *")] void** address)
    {
        return ((delegate* unmanaged<IMFSignedLibrary*, sbyte*, void**, int>)(lpVtbl[3]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this), name, address);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetProcedureAddress([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("PVOID *")] void** address);
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

        [NativeTypeName("HRESULT (LPCSTR, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, void**, int> GetProcedureAddress;
    }
}
