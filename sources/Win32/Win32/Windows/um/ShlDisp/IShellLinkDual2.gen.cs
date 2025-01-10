// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("317EE249-F12E-11D2-B1E4-00C04F8EEB3E")]
[NativeTypeName("struct IShellLinkDual2 : IShellLinkDual")]
[NativeInheritance("IShellLinkDual")]
public unsafe partial struct IShellLinkDual2 : IShellLinkDual2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellLinkDual2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellLinkDual2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellLinkDual2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellLinkDual2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellLinkDual2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IShellLinkDual2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IShellLinkDual2, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IShellLinkDual2,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort**, int>)((*lpVtbl)[7]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Path([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort*, int>)((*lpVtbl)[8]))(this, bs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Description([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort**, int>)((*lpVtbl)[9]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Description([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort*, int>)((*lpVtbl)[10]))(this, bs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort**, int>)((*lpVtbl)[11]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort*, int>)((*lpVtbl)[12]))(this, bs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Arguments([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort**, int>)((*lpVtbl)[13]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Arguments([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort*, int>)((*lpVtbl)[14]))(this, bs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Hotkey(int* piHK)
    {
        return ((delegate* unmanaged<IShellLinkDual2, int*, int>)((*lpVtbl)[15]))(this, piHK);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Hotkey(int iHK)
    {
        return ((delegate* unmanaged<IShellLinkDual2, int, int>)((*lpVtbl)[16]))(this, iHK);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ShowCommand(int* piShowCommand)
    {
        return ((delegate* unmanaged<IShellLinkDual2, int*, int>)((*lpVtbl)[17]))(
            this,
            piShowCommand
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ShowCommand(int iShowCommand)
    {
        return ((delegate* unmanaged<IShellLinkDual2, int, int>)((*lpVtbl)[18]))(
            this,
            iShowCommand
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Resolve(int fFlags)
    {
        return ((delegate* unmanaged<IShellLinkDual2, int, int>)((*lpVtbl)[19]))(this, fFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetIconLocation([NativeTypeName("BSTR *")] ushort** pbs, int* piIcon)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort**, int*, int>)((*lpVtbl)[20]))(
            this,
            pbs,
            piIcon
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetIconLocation([NativeTypeName("BSTR")] ushort* bs, int iIcon)
    {
        return ((delegate* unmanaged<IShellLinkDual2, ushort*, int, int>)((*lpVtbl)[21]))(
            this,
            bs,
            iIcon
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Save(VARIANT vWhere)
    {
        return ((delegate* unmanaged<IShellLinkDual2, VARIANT, int>)((*lpVtbl)[22]))(this, vWhere);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Target(FolderItem* ppfi)
    {
        return ((delegate* unmanaged<IShellLinkDual2, FolderItem*, int>)((*lpVtbl)[23]))(
            this,
            ppfi
        );
    }

    public interface Interface : IShellLinkDual.Interface
    {
        [VtblIndex(23)]
        HRESULT get_Target(FolderItem* ppfi);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Path;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Path;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Description;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Description;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_WorkingDirectory;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_WorkingDirectory;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Arguments;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Arguments;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Hotkey;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Hotkey;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ShowCommand;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ShowCommand;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Resolve;

        [NativeTypeName("HRESULT (BSTR *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int*, int> GetIconLocation;

        [NativeTypeName("HRESULT (BSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> SetIconLocation;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> Save;

        [NativeTypeName("HRESULT (FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItem*, int> get_Target;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellLinkDual2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellLinkDual2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellLinkDual"/> to <see cref = "IShellLinkDual2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellLinkDual"/> instance to be converted </param>
    public static explicit operator IShellLinkDual2(Silk.NET.Windows.IShellLinkDual value)
    {
        return new IShellLinkDual2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellLinkDual2"/> to <see cref = "Silk.NET.Windows.IShellLinkDual"/>.</summary>
    /// <param name = "value">The <see cref = "IShellLinkDual2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellLinkDual(IShellLinkDual2 value)
    {
        return new Silk.NET.Windows.IShellLinkDual(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellLinkDual2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellLinkDual2(Silk.NET.Windows.IDispatch value)
    {
        return new IShellLinkDual2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellLinkDual2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellLinkDual2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellLinkDual2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellLinkDual2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellLinkDual2(Silk.NET.Windows.IUnknown value)
    {
        return new IShellLinkDual2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellLinkDual2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellLinkDual2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellLinkDual2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
