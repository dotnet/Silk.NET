// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectManipulationFrameInfoProvider.xml' path='doc/member[@name="IDirectManipulationFrameInfoProvider"]/*'/>
[Guid("FB759DBA-6F4C-4C01-874E-19C8A05907F9")]
[NativeTypeName("struct IDirectManipulationFrameInfoProvider : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationFrameInfoProvider : IDirectManipulationFrameInfoProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationFrameInfoProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, uint> )(lpVtbl[1]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, uint> )(lpVtbl[2]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationFrameInfoProvider.xml' path='doc/member[@name="IDirectManipulationFrameInfoProvider.GetNextFrameInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNextFrameInfo([NativeTypeName("ULONGLONG *")] ulong* time, [NativeTypeName("ULONGLONG *")] ulong* processTime, [NativeTypeName("ULONGLONG *")] ulong* compositionTime)
    {
        return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, ulong*, ulong*, ulong*, int> )(lpVtbl[3]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this), time, processTime, compositionTime);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNextFrameInfo([NativeTypeName("ULONGLONG *")] ulong* time, [NativeTypeName("ULONGLONG *")] ulong* processTime, [NativeTypeName("ULONGLONG *")] ulong* compositionTime);
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
        [NativeTypeName("HRESULT (ULONGLONG *, ULONGLONG *, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, ulong*, int> GetNextFrameInfo;
    }
}