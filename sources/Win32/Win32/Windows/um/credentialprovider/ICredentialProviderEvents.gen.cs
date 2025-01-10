// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("34201E5A-A787-41A3-A5A4-BD6DCF2A854E")]
[NativeTypeName("struct ICredentialProviderEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICredentialProviderEvents
    : ICredentialProviderEvents.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CredentialsChanged([NativeTypeName("UINT_PTR")] nuint upAdviseContext)
    {
        return ((delegate* unmanaged<ICredentialProviderEvents, nuint, int>)((*lpVtbl)[3]))(
            this,
            upAdviseContext
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CredentialsChanged([NativeTypeName("UINT_PTR")] nuint upAdviseContext);
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

        [NativeTypeName("HRESULT (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> CredentialsChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderEvents(Silk.NET.Windows.IUnknown value)
    {
        return new ICredentialProviderEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICredentialProviderEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
