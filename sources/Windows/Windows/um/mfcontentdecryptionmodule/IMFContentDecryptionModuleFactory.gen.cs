// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFContentDecryptionModuleFactory.xml' path='doc/member[@name="IMFContentDecryptionModuleFactory"]/*'/>
[Guid("7D5ABF16-4CBB-4E08-B977-9BA59049943E")]
[NativeTypeName("struct IMFContentDecryptionModuleFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModuleFactory : IMFContentDecryptionModuleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptionModuleFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, Guid*, void**, int> )(lpVtbl[0]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, uint> )(lpVtbl[1]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, uint> )(lpVtbl[2]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentDecryptionModuleFactory.xml' path='doc/member[@name="IMFContentDecryptionModuleFactory.IsTypeSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL IsTypeSupported([NativeTypeName("LPCWSTR")] ushort* keySystem, [NativeTypeName("LPCWSTR")] ushort* contentType)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, ushort*, ushort*, int> )(lpVtbl[3]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this), keySystem, contentType);
    }

    /// <include file='IMFContentDecryptionModuleFactory.xml' path='doc/member[@name="IMFContentDecryptionModuleFactory.CreateContentDecryptionModuleAccess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateContentDecryptionModuleAccess([NativeTypeName("LPCWSTR")] ushort* keySystem, IPropertyStore** configurations, [NativeTypeName("DWORD")] uint numConfigurations, IMFContentDecryptionModuleAccess** contentDecryptionModuleAccess)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, ushort*, IPropertyStore**, uint, IMFContentDecryptionModuleAccess**, int> )(lpVtbl[4]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this), keySystem, configurations, numConfigurations, contentDecryptionModuleAccess);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL IsTypeSupported([NativeTypeName("LPCWSTR")] ushort* keySystem, [NativeTypeName("LPCWSTR")] ushort* contentType);
        [VtblIndex(4)]
        HRESULT CreateContentDecryptionModuleAccess([NativeTypeName("LPCWSTR")] ushort* keySystem, IPropertyStore** configurations, [NativeTypeName("DWORD")] uint numConfigurations, IMFContentDecryptionModuleAccess** contentDecryptionModuleAccess);
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
        [NativeTypeName("BOOL (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> IsTypeSupported;
        [NativeTypeName("HRESULT (LPCWSTR, IPropertyStore **, DWORD, IMFContentDecryptionModuleAccess **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IPropertyStore**, uint, IMFContentDecryptionModuleAccess**, int> CreateContentDecryptionModuleAccess;
    }
}