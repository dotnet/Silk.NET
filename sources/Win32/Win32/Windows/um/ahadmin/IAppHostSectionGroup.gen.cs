// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0DD8A158-EBE6-4008-A1D9-B7ECC8F1104B")]
[NativeTypeName("struct IAppHostSectionGroup : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostSectionGroup : IAppHostSectionGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostSectionGroup));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostSectionGroup, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcSectionGroup)
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcSectionGroup
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT varIndex, IAppHostSectionGroup* ppSectionGroup)
    {
        return (
            (delegate* unmanaged<IAppHostSectionGroup, VARIANT, IAppHostSectionGroup*, int>)(
                (*lpVtbl)[4]
            )
        )(this, varIndex, ppSectionGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Sections(IAppHostSectionDefinitionCollection* ppSections)
    {
        return (
            (delegate* unmanaged<IAppHostSectionGroup, IAppHostSectionDefinitionCollection*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ppSections);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddSectionGroup(
        [NativeTypeName("BSTR")] ushort* bstrSectionGroupName,
        IAppHostSectionGroup* ppSectionGroup
    )
    {
        return (
            (delegate* unmanaged<IAppHostSectionGroup, ushort*, IAppHostSectionGroup*, int>)(
                (*lpVtbl)[6]
            )
        )(this, bstrSectionGroupName, ppSectionGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteSectionGroup(VARIANT varIndex)
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, VARIANT, int>)((*lpVtbl)[7]))(
            this,
            varIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, ushort**, int>)((*lpVtbl)[8]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbstrType)
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, ushort**, int>)((*lpVtbl)[9]))(
            this,
            pbstrType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Type([NativeTypeName("BSTR")] ushort* bstrType)
    {
        return ((delegate* unmanaged<IAppHostSectionGroup, ushort*, int>)((*lpVtbl)[10]))(
            this,
            bstrType
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcSectionGroup);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT varIndex, IAppHostSectionGroup* ppSectionGroup);

        [VtblIndex(5)]
        HRESULT get_Sections(IAppHostSectionDefinitionCollection* ppSections);

        [VtblIndex(6)]
        HRESULT AddSectionGroup(
            [NativeTypeName("BSTR")] ushort* bstrSectionGroupName,
            IAppHostSectionGroup* ppSectionGroup
        );

        [VtblIndex(7)]
        HRESULT DeleteSectionGroup(VARIANT varIndex);

        [VtblIndex(8)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(9)]
        HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbstrType);

        [VtblIndex(10)]
        HRESULT put_Type([NativeTypeName("BSTR")] ushort* bstrType);
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

        [NativeTypeName("HRESULT (VARIANT, IAppHostSectionGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IAppHostSectionGroup*, int> get_Item;

        [NativeTypeName(
            "HRESULT (IAppHostSectionDefinitionCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppHostSectionDefinitionCollection*, int> get_Sections;

        [NativeTypeName("HRESULT (BSTR, IAppHostSectionGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostSectionGroup*, int> AddSectionGroup;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> DeleteSectionGroup;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Type;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostSectionGroup"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostSectionGroup(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostSectionGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostSectionGroup(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostSectionGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostSectionGroup"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostSectionGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostSectionGroup value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
