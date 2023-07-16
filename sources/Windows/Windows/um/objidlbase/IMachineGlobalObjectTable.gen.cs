// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMachineGlobalObjectTable.xml' path='doc/member[@name="IMachineGlobalObjectTable"]/*'/>
[Guid("26D709AC-F70B-4421-A96F-D2878FAFB00D")]
[NativeTypeName("struct IMachineGlobalObjectTable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMachineGlobalObjectTable : IMachineGlobalObjectTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMachineGlobalObjectTable));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable*, Guid*, void**, int> )(lpVtbl[0]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable*, uint> )(lpVtbl[1]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable*, uint> )(lpVtbl[2]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMachineGlobalObjectTable.xml' path='doc/member[@name="IMachineGlobalObjectTable.RegisterObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterObject([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* identifier, IUnknown* @object, MachineGlobalObjectTableRegistrationToken* token)
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable*, Guid*, ushort*, IUnknown*, MachineGlobalObjectTableRegistrationToken*, int> )(lpVtbl[3]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), clsid, identifier, @object, token);
    }

    /// <include file='IMachineGlobalObjectTable.xml' path='doc/member[@name="IMachineGlobalObjectTable.GetObjectW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetObjectW([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* identifier, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable*, Guid*, ushort*, Guid*, void**, int> )(lpVtbl[4]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), clsid, identifier, riid, ppv);
    }

    /// <include file='IMachineGlobalObjectTable.xml' path='doc/member[@name="IMachineGlobalObjectTable.RevokeObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RevokeObject(MachineGlobalObjectTableRegistrationToken token)
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken, int> )(lpVtbl[5]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterObject([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* identifier, IUnknown* @object, MachineGlobalObjectTableRegistrationToken* token);
        [VtblIndex(4)]
        HRESULT GetObjectW([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* identifier, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(5)]
        HRESULT RevokeObject(MachineGlobalObjectTableRegistrationToken token);
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
        [NativeTypeName("HRESULT (const IID &, LPCWSTR, IUnknown *, MachineGlobalObjectTableRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, IUnknown*, MachineGlobalObjectTableRegistrationToken*, int> RegisterObject;
        [NativeTypeName("HRESULT (const IID &, LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, void**, int> GetObjectW;
        [NativeTypeName("HRESULT (MachineGlobalObjectTableRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MachineGlobalObjectTableRegistrationToken, int> RevokeObject;
    }
}