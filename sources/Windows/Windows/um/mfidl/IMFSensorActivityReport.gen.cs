// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSensorActivityReport.xml' path='doc/member[@name="IMFSensorActivityReport"]/*'/>
[Guid("3E8C4BE1-A8C2-4528-90DE-2851BDE5FEAD")]
[NativeTypeName("struct IMFSensorActivityReport : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorActivityReport : IMFSensorActivityReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorActivityReport));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, Guid*, void**, int> )(lpVtbl[0]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, uint> )(lpVtbl[1]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, uint> )(lpVtbl[2]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorActivityReport.xml' path='doc/member[@name="IMFSensorActivityReport.GetFriendlyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFriendlyName([NativeTypeName("LPWSTR")] ushort* FriendlyName, [NativeTypeName("ULONG")] uint cchFriendlyName, [NativeTypeName("ULONG *")] uint* pcchWritten)
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, ushort*, uint, uint*, int> )(lpVtbl[3]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), FriendlyName, cchFriendlyName, pcchWritten);
    }

    /// <include file='IMFSensorActivityReport.xml' path='doc/member[@name="IMFSensorActivityReport.GetSymbolicLink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSymbolicLink([NativeTypeName("LPWSTR")] ushort* SymbolicLink, [NativeTypeName("ULONG")] uint cchSymbolicLink, [NativeTypeName("ULONG *")] uint* pcchWritten)
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, ushort*, uint, uint*, int> )(lpVtbl[4]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), SymbolicLink, cchSymbolicLink, pcchWritten);
    }

    /// <include file='IMFSensorActivityReport.xml' path='doc/member[@name="IMFSensorActivityReport.GetProcessCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProcessCount([NativeTypeName("ULONG *")] uint* pcCount)
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, uint*, int> )(lpVtbl[5]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IMFSensorActivityReport.xml' path='doc/member[@name="IMFSensorActivityReport.GetProcessActivity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProcessActivity([NativeTypeName("ULONG")] uint Index, IMFSensorProcessActivity** ppProcessActivity)
    {
        return ((delegate* unmanaged<IMFSensorActivityReport*, uint, IMFSensorProcessActivity**, int> )(lpVtbl[6]))((IMFSensorActivityReport*)Unsafe.AsPointer(ref this), Index, ppProcessActivity);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFriendlyName([NativeTypeName("LPWSTR")] ushort* FriendlyName, [NativeTypeName("ULONG")] uint cchFriendlyName, [NativeTypeName("ULONG *")] uint* pcchWritten);
        [VtblIndex(4)]
        HRESULT GetSymbolicLink([NativeTypeName("LPWSTR")] ushort* SymbolicLink, [NativeTypeName("ULONG")] uint cchSymbolicLink, [NativeTypeName("ULONG *")] uint* pcchWritten);
        [VtblIndex(5)]
        HRESULT GetProcessCount([NativeTypeName("ULONG *")] uint* pcCount);
        [VtblIndex(6)]
        HRESULT GetProcessActivity([NativeTypeName("ULONG")] uint Index, IMFSensorProcessActivity** ppProcessActivity);
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
        [NativeTypeName("HRESULT (LPWSTR, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetFriendlyName;
        [NativeTypeName("HRESULT (LPWSTR, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetSymbolicLink;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProcessCount;
        [NativeTypeName("HRESULT (ULONG, IMFSensorProcessActivity **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSensorProcessActivity**, int> GetProcessActivity;
    }
}