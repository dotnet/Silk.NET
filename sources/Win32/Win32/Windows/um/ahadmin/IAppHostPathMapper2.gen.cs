// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0F80E901-8F4C-449A-BF90-13D5D082F187")]
[NativeTypeName("struct IAppHostPathMapper2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPathMapper2 : IAppHostPathMapper2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPathMapper2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostPathMapper2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostPathMapper2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostPathMapper2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MapPath(
        [NativeTypeName("BSTR")] ushort* bstrConfigPath,
        [NativeTypeName("BSTR")] ushort* bstrMappedPhysicalPath,
        [NativeTypeName("BSTR *")] ushort** pbstrNewPhysicalPath,
        HANDLE* phImpersonationToken
    )
    {
        return (
            (delegate* unmanaged<IAppHostPathMapper2, ushort*, ushort*, ushort**, HANDLE*, int>)(
                (*lpVtbl)[3]
            )
        )(this, bstrConfigPath, bstrMappedPhysicalPath, pbstrNewPhysicalPath, phImpersonationToken);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MapPath(
            [NativeTypeName("BSTR")] ushort* bstrConfigPath,
            [NativeTypeName("BSTR")] ushort* bstrMappedPhysicalPath,
            [NativeTypeName("BSTR *")] ushort** pbstrNewPhysicalPath,
            HANDLE* phImpersonationToken
        );
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

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort**, HANDLE*, int> MapPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostPathMapper2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostPathMapper2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostPathMapper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostPathMapper2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostPathMapper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPathMapper2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPathMapper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostPathMapper2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
