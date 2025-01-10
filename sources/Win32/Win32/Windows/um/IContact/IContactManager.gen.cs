// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AD553D98-DEB1-474A-8E17-FC0C2075B738")]
[NativeTypeName("struct IContactManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContactManager : IContactManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        [NativeTypeName("LPCWSTR")] ushort* pszAppName,
        [NativeTypeName("LPCWSTR")] ushort* pszAppVersion
    )
    {
        return ((delegate* unmanaged<IContactManager, ushort*, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pszAppName,
            pszAppVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Load([NativeTypeName("LPCWSTR")] ushort* pszContactID, IContact* ppContact)
    {
        return ((delegate* unmanaged<IContactManager, ushort*, IContact*, int>)((*lpVtbl)[4]))(
            this,
            pszContactID,
            ppContact
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MergeContactIDs(
        [NativeTypeName("LPCWSTR")] ushort* pszNewContactID,
        [NativeTypeName("LPCWSTR")] ushort* pszOldContactID
    )
    {
        return ((delegate* unmanaged<IContactManager, ushort*, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pszNewContactID,
            pszOldContactID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMeContact(IContact* ppMeContact)
    {
        return ((delegate* unmanaged<IContactManager, IContact*, int>)((*lpVtbl)[6]))(
            this,
            ppMeContact
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMeContact(IContact pMeContact)
    {
        return ((delegate* unmanaged<IContactManager, IContact, int>)((*lpVtbl)[7]))(
            this,
            pMeContact
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetContactCollection(IContactCollection* ppContactCollection)
    {
        return ((delegate* unmanaged<IContactManager, IContactCollection*, int>)((*lpVtbl)[8]))(
            this,
            ppContactCollection
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            [NativeTypeName("LPCWSTR")] ushort* pszAppName,
            [NativeTypeName("LPCWSTR")] ushort* pszAppVersion
        );

        [VtblIndex(4)]
        HRESULT Load([NativeTypeName("LPCWSTR")] ushort* pszContactID, IContact* ppContact);

        [VtblIndex(5)]
        HRESULT MergeContactIDs(
            [NativeTypeName("LPCWSTR")] ushort* pszNewContactID,
            [NativeTypeName("LPCWSTR")] ushort* pszOldContactID
        );

        [VtblIndex(6)]
        HRESULT GetMeContact(IContact* ppMeContact);

        [VtblIndex(7)]
        HRESULT SetMeContact(IContact pMeContact);

        [VtblIndex(8)]
        HRESULT GetContactCollection(IContactCollection* ppContactCollection);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> Initialize;

        [NativeTypeName("HRESULT (LPCWSTR, IContact **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IContact*, int> Load;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> MergeContactIDs;

        [NativeTypeName("HRESULT (IContact **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IContact*, int> GetMeContact;

        [NativeTypeName("HRESULT (IContact *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IContact, int> SetMeContact;

        [NativeTypeName("HRESULT (IContactCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IContactCollection*, int> GetContactCollection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactManager(Silk.NET.Windows.IUnknown value)
    {
        return new IContactManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
