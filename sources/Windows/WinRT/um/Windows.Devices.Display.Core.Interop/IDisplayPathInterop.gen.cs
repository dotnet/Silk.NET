// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IDisplayPathInterop.xml' path='doc/member[@name="IDisplayPathInterop"]/*'/>
[Guid("A6BA4205-E59E-4E71-B25B-4E436D21EE3D")]
[NativeTypeName("struct IDisplayPathInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDisplayPathInterop : IDisplayPathInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayPathInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDisplayPathInterop*, Guid*, void**, int> )(lpVtbl[0]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDisplayPathInterop*, uint> )(lpVtbl[1]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayPathInterop*, uint> )(lpVtbl[2]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDisplayPathInterop.xml' path='doc/member[@name="IDisplayPathInterop.CreateSourcePresentationHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSourcePresentationHandle(HANDLE* pValue)
    {
        return ((delegate* unmanaged<IDisplayPathInterop*, HANDLE*, int> )(lpVtbl[3]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this), pValue);
    }

    /// <include file='IDisplayPathInterop.xml' path='doc/member[@name="IDisplayPathInterop.GetSourceId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceId(uint* pSourceId)
    {
        return ((delegate* unmanaged<IDisplayPathInterop*, uint*, int> )(lpVtbl[4]))((IDisplayPathInterop*)Unsafe.AsPointer(ref this), pSourceId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSourcePresentationHandle(HANDLE* pValue);
        [VtblIndex(4)]
        HRESULT GetSourceId(uint* pSourceId);
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
        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> CreateSourcePresentationHandle;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSourceId;
    }
}