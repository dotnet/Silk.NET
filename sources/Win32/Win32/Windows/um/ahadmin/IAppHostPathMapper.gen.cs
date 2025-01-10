// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E7927575-5CC3-403B-822E-328A6B904BEE")]
[NativeTypeName("struct IAppHostPathMapper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPathMapper : IAppHostPathMapper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPathMapper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostPathMapper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostPathMapper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostPathMapper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MapPath(
        [NativeTypeName("BSTR")] ushort* bstrConfigPath,
        [NativeTypeName("BSTR")] ushort* bstrMappedPhysicalPath,
        [NativeTypeName("BSTR *")] ushort** pbstrNewPhysicalPath
    )
    {
        return (
            (delegate* unmanaged<IAppHostPathMapper, ushort*, ushort*, ushort**, int>)((*lpVtbl)[3])
        )(this, bstrConfigPath, bstrMappedPhysicalPath, pbstrNewPhysicalPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MapPath(
            [NativeTypeName("BSTR")] ushort* bstrConfigPath,
            [NativeTypeName("BSTR")] ushort* bstrMappedPhysicalPath,
            [NativeTypeName("BSTR *")] ushort** pbstrNewPhysicalPath
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

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort**, int> MapPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostPathMapper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostPathMapper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostPathMapper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostPathMapper(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostPathMapper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPathMapper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPathMapper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostPathMapper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
