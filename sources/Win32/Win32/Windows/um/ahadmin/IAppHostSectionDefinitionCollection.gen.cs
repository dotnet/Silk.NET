// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B7D381EE-8860-47A1-8AF4-1F33B2B1F325")]
[NativeTypeName("struct IAppHostSectionDefinitionCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostSectionDefinitionCollection
    : IAppHostSectionDefinitionCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostSectionDefinitionCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppHostSectionDefinitionCollection, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppHostSectionDefinitionCollection, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostSectionDefinitionCollection, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcCount)
    {
        return (
            (delegate* unmanaged<IAppHostSectionDefinitionCollection, uint*, int>)((*lpVtbl)[3])
        )(this, pcCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT varIndex, IAppHostSectionDefinition* ppConfigSection)
    {
        return (
            (delegate* unmanaged<
                IAppHostSectionDefinitionCollection,
                VARIANT,
                IAppHostSectionDefinition*,
                int>)((*lpVtbl)[4])
        )(this, varIndex, ppConfigSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddSection(
        [NativeTypeName("BSTR")] ushort* bstrSectionName,
        IAppHostSectionDefinition* ppConfigSection
    )
    {
        return (
            (delegate* unmanaged<
                IAppHostSectionDefinitionCollection,
                ushort*,
                IAppHostSectionDefinition*,
                int>)((*lpVtbl)[5])
        )(this, bstrSectionName, ppConfigSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteSection(VARIANT varIndex)
    {
        return (
            (delegate* unmanaged<IAppHostSectionDefinitionCollection, VARIANT, int>)((*lpVtbl)[6])
        )(this, varIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT varIndex, IAppHostSectionDefinition* ppConfigSection);

        [VtblIndex(5)]
        HRESULT AddSection(
            [NativeTypeName("BSTR")] ushort* bstrSectionName,
            IAppHostSectionDefinition* ppConfigSection
        );

        [VtblIndex(6)]
        HRESULT DeleteSection(VARIANT varIndex);
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

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostSectionDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IAppHostSectionDefinition*, int> get_Item;

        [NativeTypeName("HRESULT (BSTR, IAppHostSectionDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostSectionDefinition*, int> AddSection;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> DeleteSection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostSectionDefinitionCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostSectionDefinitionCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostSectionDefinitionCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostSectionDefinitionCollection(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppHostSectionDefinitionCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostSectionDefinitionCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostSectionDefinitionCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppHostSectionDefinitionCollection value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
