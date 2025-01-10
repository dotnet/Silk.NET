// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IWpfApplicationPreloadUtil : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfApplicationPreloadUtil : IWpfApplicationPreloadUtil.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWpfApplicationPreloadUtil*, uint>)((*lpVtbl)[0]))(
            (IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWpfApplicationPreloadUtil*, uint>)((*lpVtbl)[1]))(
            (IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetApplicationPreloadInfo(
        [NativeTypeName("PCWSTR")] ushort* pszConfigPath,
        BOOL* pfEnabled,
        [NativeTypeName("BSTR *")] ushort** pbstrType,
        SAFEARRAY** psaPreloadValues
    )
    {
        return (
            (delegate* unmanaged<
                IWpfApplicationPreloadUtil*,
                ushort*,
                BOOL*,
                ushort**,
                SAFEARRAY**,
                int>)((*lpVtbl)[2])
        )(
            (IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this),
            pszConfigPath,
            pfEnabled,
            pbstrType,
            psaPreloadValues
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportApplicationPreloadFailure(
        [NativeTypeName("PCWSTR")] ushort* pszConfigPath,
        HRESULT hrFailureCode,
        [NativeTypeName("PCWSTR")] ushort* pszErrorString
    )
    {
        return (
            (delegate* unmanaged<IWpfApplicationPreloadUtil*, ushort*, HRESULT, ushort*, int>)(
                (*lpVtbl)[3]
            )
        )(
            (IWpfApplicationPreloadUtil*)Unsafe.AsPointer(ref this),
            pszConfigPath,
            hrFailureCode,
            pszErrorString
        );
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetApplicationPreloadInfo(
            [NativeTypeName("PCWSTR")] ushort* pszConfigPath,
            BOOL* pfEnabled,
            [NativeTypeName("BSTR *")] ushort** pbstrType,
            SAFEARRAY** psaPreloadValues
        );

        [VtblIndex(3)]
        HRESULT ReportApplicationPreloadFailure(
            [NativeTypeName("PCWSTR")] ushort* pszConfigPath,
            HRESULT hrFailureCode,
            [NativeTypeName("PCWSTR")] ushort* pszErrorString
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, BOOL *, BSTR *, SAFEARRAY **)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            BOOL*,
            ushort**,
            SAFEARRAY**,
            int> GetApplicationPreloadInfo;

        [NativeTypeName("HRESULT (PCWSTR, HRESULT, PCWSTR)")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            HRESULT,
            ushort*,
            int> ReportApplicationPreloadFailure;
    }
}
