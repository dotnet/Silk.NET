// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPrintDocumentPackageTarget.xml' path='doc/member[@name="IPrintDocumentPackageTarget"]/*' />
[Guid("1B8EFEC4-3019-4C27-964E-367202156906")]
[NativeTypeName("struct IPrintDocumentPackageTarget : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPrintDocumentPackageTarget : IPrintDocumentPackageTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTarget));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget*, uint>)(lpVtbl[1]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget*, uint>)(lpVtbl[2]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDocumentPackageTarget.xml' path='doc/member[@name="IPrintDocumentPackageTarget.GetPackageTargetTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, Guid** targetTypes)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), targetCount, targetTypes);
    }

    /// <include file='IPrintDocumentPackageTarget.xml' path='doc/member[@name="IPrintDocumentPackageTarget.GetPackageTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, void** ppvTarget)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)(lpVtbl[4]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), guidTargetType, riid, ppvTarget);
    }

    /// <include file='IPrintDocumentPackageTarget.xml' path='doc/member[@name="IPrintDocumentPackageTarget.Cancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget*, int>)(lpVtbl[5]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, Guid** targetTypes);

        [VtblIndex(4)]
        HRESULT GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, void** ppvTarget);

        [VtblIndex(5)]
        HRESULT Cancel();
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

        [NativeTypeName("HRESULT (UINT32 *, GUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetPackageTargetTypes;

        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetPackageTarget;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Cancel;
    }
}
