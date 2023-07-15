// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFProtectedEnvironmentAccess.xml' path='doc/member[@name="IMFProtectedEnvironmentAccess"]/*'/>
[Guid("EF5DC845-F0D9-4EC9-B00C-CB5183D38434")]
[NativeTypeName("struct IMFProtectedEnvironmentAccess : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFProtectedEnvironmentAccess : IMFProtectedEnvironmentAccess.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFProtectedEnvironmentAccess));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, Guid*, void**, int> )(lpVtbl[0]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint> )(lpVtbl[1]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint> )(lpVtbl[2]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFProtectedEnvironmentAccess.xml' path='doc/member[@name="IMFProtectedEnvironmentAccess.Call"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Call([NativeTypeName("UINT32")] uint inputLength, [NativeTypeName("const BYTE *")] byte* input, [NativeTypeName("UINT32")] uint outputLength, byte* output)
    {
        return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint, byte*, uint, byte*, int> )(lpVtbl[3]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this), inputLength, input, outputLength, output);
    }

    /// <include file='IMFProtectedEnvironmentAccess.xml' path='doc/member[@name="IMFProtectedEnvironmentAccess.ReadGRL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReadGRL([NativeTypeName("UINT32 *")] uint* outputLength, byte** output)
    {
        return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint*, byte**, int> )(lpVtbl[4]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this), outputLength, output);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Call([NativeTypeName("UINT32")] uint inputLength, [NativeTypeName("const BYTE *")] byte* input, [NativeTypeName("UINT32")] uint outputLength, byte* output);
        [VtblIndex(4)]
        HRESULT ReadGRL([NativeTypeName("UINT32 *")] uint* outputLength, byte** output);
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
        [NativeTypeName("HRESULT (UINT32, const BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, byte*, int> Call;
        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> ReadGRL;
    }
}