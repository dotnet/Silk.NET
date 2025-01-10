// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000013A-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPropertySetStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertySetStorage : IPropertySetStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertySetStorage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertySetStorage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertySetStorage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertySetStorage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Create(
        [NativeTypeName("const IID &")] Guid* rfmtid,
        [NativeTypeName("const CLSID *")] Guid* pclsid,
        [NativeTypeName("DWORD")] uint grfFlags,
        [NativeTypeName("DWORD")] uint grfMode,
        IPropertyStorage* ppprstg
    )
    {
        return (
            (delegate* unmanaged<
                IPropertySetStorage,
                Guid*,
                Guid*,
                uint,
                uint,
                IPropertyStorage*,
                int>)((*lpVtbl)[3])
        )(this, rfmtid, pclsid, grfFlags, grfMode, ppprstg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Open(
        [NativeTypeName("const IID &")] Guid* rfmtid,
        [NativeTypeName("DWORD")] uint grfMode,
        IPropertyStorage* ppprstg
    )
    {
        return (
            (delegate* unmanaged<IPropertySetStorage, Guid*, uint, IPropertyStorage*, int>)(
                (*lpVtbl)[4]
            )
        )(this, rfmtid, grfMode, ppprstg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Delete([NativeTypeName("const IID &")] Guid* rfmtid)
    {
        return ((delegate* unmanaged<IPropertySetStorage, Guid*, int>)((*lpVtbl)[5]))(this, rfmtid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Enum(IEnumSTATPROPSETSTG* ppenum)
    {
        return (
            (delegate* unmanaged<IPropertySetStorage, IEnumSTATPROPSETSTG*, int>)((*lpVtbl)[6])
        )(this, ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Create(
            [NativeTypeName("const IID &")] Guid* rfmtid,
            [NativeTypeName("const CLSID *")] Guid* pclsid,
            [NativeTypeName("DWORD")] uint grfFlags,
            [NativeTypeName("DWORD")] uint grfMode,
            IPropertyStorage* ppprstg
        );

        [VtblIndex(4)]
        HRESULT Open(
            [NativeTypeName("const IID &")] Guid* rfmtid,
            [NativeTypeName("DWORD")] uint grfMode,
            IPropertyStorage* ppprstg
        );

        [VtblIndex(5)]
        HRESULT Delete([NativeTypeName("const IID &")] Guid* rfmtid);

        [VtblIndex(6)]
        HRESULT Enum(IEnumSTATPROPSETSTG* ppenum);
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

        [NativeTypeName(
            "HRESULT (const IID &, const CLSID *, DWORD, DWORD, IPropertyStorage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint, uint, IPropertyStorage*, int> Create;

        [NativeTypeName(
            "HRESULT (const IID &, DWORD, IPropertyStorage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, IPropertyStorage*, int> Open;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Delete;

        [NativeTypeName("HRESULT (IEnumSTATPROPSETSTG **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATPROPSETSTG*, int> Enum;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertySetStorage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertySetStorage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertySetStorage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertySetStorage(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertySetStorage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertySetStorage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertySetStorage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertySetStorage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
