// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFContentDecryptionModuleAccess.xml' path='doc/member[@name="IMFContentDecryptionModuleAccess"]/*'/>
[Guid("A853D1F4-E2A0-4303-9EDC-F1A68EE43136")]
[NativeTypeName("struct IMFContentDecryptionModuleAccess : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModuleAccess : IMFContentDecryptionModuleAccess.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptionModuleAccess));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleAccess*, Guid*, void**, int> )(lpVtbl[0]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleAccess*, uint> )(lpVtbl[1]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleAccess*, uint> )(lpVtbl[2]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentDecryptionModuleAccess.xml' path='doc/member[@name="IMFContentDecryptionModuleAccess.CreateContentDecryptionModule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateContentDecryptionModule(IPropertyStore* contentDecryptionModuleProperties, IMFContentDecryptionModule** contentDecryptionModule)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleAccess*, IPropertyStore*, IMFContentDecryptionModule**, int> )(lpVtbl[3]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), contentDecryptionModuleProperties, contentDecryptionModule);
    }

    /// <include file='IMFContentDecryptionModuleAccess.xml' path='doc/member[@name="IMFContentDecryptionModuleAccess.GetConfiguration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetConfiguration(IPropertyStore** configuration)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleAccess*, IPropertyStore**, int> )(lpVtbl[4]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <include file='IMFContentDecryptionModuleAccess.xml' path='doc/member[@name="IMFContentDecryptionModuleAccess.GetKeySystem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetKeySystem([NativeTypeName("LPWSTR *")] ushort** keySystem)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleAccess*, ushort**, int> )(lpVtbl[5]))((IMFContentDecryptionModuleAccess*)Unsafe.AsPointer(ref this), keySystem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateContentDecryptionModule(IPropertyStore* contentDecryptionModuleProperties, IMFContentDecryptionModule** contentDecryptionModule);
        [VtblIndex(4)]
        HRESULT GetConfiguration(IPropertyStore** configuration);
        [VtblIndex(5)]
        HRESULT GetKeySystem([NativeTypeName("LPWSTR *")] ushort** keySystem);
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
        [NativeTypeName("HRESULT (IPropertyStore *, IMFContentDecryptionModule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore*, IMFContentDecryptionModule**, int> CreateContentDecryptionModule;
        [NativeTypeName("HRESULT (IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore**, int> GetConfiguration;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetKeySystem;
    }
}