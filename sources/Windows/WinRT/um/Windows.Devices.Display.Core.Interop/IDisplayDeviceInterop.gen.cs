// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IDisplayDeviceInterop.xml' path='doc/member[@name="IDisplayDeviceInterop"]/*'/>
[Guid("64338358-366A-471B-BD56-DD8EF48E439B")]
[NativeTypeName("struct IDisplayDeviceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDisplayDeviceInterop : IDisplayDeviceInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayDeviceInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, Guid*, void**, int> )(lpVtbl[0]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, uint> )(lpVtbl[1]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, uint> )(lpVtbl[2]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDisplayDeviceInterop.xml' path='doc/member[@name="IDisplayDeviceInterop.CreateSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSharedHandle(IInspectable* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pSecurityAttributes, [NativeTypeName("DWORD")] uint Access, HSTRING Name, HANDLE* pHandle)
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, IInspectable*, SECURITY_ATTRIBUTES*, uint, HSTRING, HANDLE*, int> )(lpVtbl[3]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), pObject, pSecurityAttributes, Access, Name, pHandle);
    }

    /// <include file='IDisplayDeviceInterop.xml' path='doc/member[@name="IDisplayDeviceInterop.OpenSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenSharedHandle(HANDLE NTHandle, [NativeTypeName("IID")] Guid riid, void** ppvObj)
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, HANDLE, Guid, void**, int> )(lpVtbl[4]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSharedHandle(IInspectable* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pSecurityAttributes, [NativeTypeName("DWORD")] uint Access, HSTRING Name, HANDLE* pHandle);
        [VtblIndex(4)]
        HRESULT OpenSharedHandle(HANDLE NTHandle, [NativeTypeName("IID")] Guid riid, void** ppvObj);
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
        [NativeTypeName("HRESULT (IInspectable *, const SECURITY_ATTRIBUTES *, DWORD, HSTRING, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, SECURITY_ATTRIBUTES*, uint, HSTRING, HANDLE*, int> CreateSharedHandle;
        [NativeTypeName("HRESULT (HANDLE, IID, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid, void**, int> OpenSharedHandle;
    }
}