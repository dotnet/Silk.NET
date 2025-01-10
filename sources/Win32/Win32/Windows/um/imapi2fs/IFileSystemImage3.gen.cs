// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7CFF842C-7E97-4807-8304-910DD8F7C051")]
[NativeTypeName("struct IFileSystemImage3 : IFileSystemImage2")]
[NativeInheritance("IFileSystemImage2")]
public unsafe partial struct IFileSystemImage3 : IFileSystemImage3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSystemImage3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSystemImage3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileSystemImage3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSystemImage3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFileSystemImage3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
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
            (delegate* unmanaged<IFileSystemImage3, Guid*, ushort**, uint, uint, int*, int>)(
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
                IFileSystemImage3,
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
    public HRESULT get_Root(IFsiDirectoryItem* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, IFsiDirectoryItem*, int>)((*lpVtbl)[7]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[8]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SessionStartBlock([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int, int>)((*lpVtbl)[9]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[10]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int, int>)((*lpVtbl)[11]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetMaxMediaBlocksFromDevice(IDiscRecorder2 discRecorder)
    {
        return ((delegate* unmanaged<IFileSystemImage3, IDiscRecorder2, int>)((*lpVtbl)[12]))(
            this,
            discRecorder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UsedBlocks([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[13]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[14]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_VolumeName([NativeTypeName("BSTR")] ushort* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort*, int>)((*lpVtbl)[15]))(
            this,
            newVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[16]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BootImageOptions(IBootOptions* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, IBootOptions*, int>)((*lpVtbl)[17]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_BootImageOptions(IBootOptions newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, IBootOptions, int>)((*lpVtbl)[18]))(
            this,
            newVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_FileCount([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[19]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DirectoryCount([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[20]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[21]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort*, int>)((*lpVtbl)[22]))(
            this,
            newVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ChangePoint([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[23]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, short*, int>)((*lpVtbl)[24]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, short, int>)((*lpVtbl)[25]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, short*, int>)((*lpVtbl)[26]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, short, int>)((*lpVtbl)[27]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_FileSystemsToCreate(FsiFileSystems* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, FsiFileSystems*, int>)((*lpVtbl)[28]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_FileSystemsToCreate(FsiFileSystems newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, FsiFileSystems, int>)((*lpVtbl)[29]))(
            this,
            newVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_FileSystemsSupported(FsiFileSystems* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, FsiFileSystems*, int>)((*lpVtbl)[30]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_UDFRevision([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int, int>)((*lpVtbl)[31]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_UDFRevision([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[32]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_UDFRevisionsSupported(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, SAFEARRAY**, int>)((*lpVtbl)[33]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT ChooseImageDefaults(IDiscRecorder2 discRecorder)
    {
        return ((delegate* unmanaged<IFileSystemImage3, IDiscRecorder2, int>)((*lpVtbl)[34]))(
            this,
            discRecorder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value)
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, IMAPI_MEDIA_PHYSICAL_TYPE, int>)((*lpVtbl)[35])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int, int>)((*lpVtbl)[36]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int*, int>)((*lpVtbl)[37]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_ISO9660InterchangeLevelsSupported(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, SAFEARRAY**, int>)((*lpVtbl)[38]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateResultImage(IFileSystemImageResult* resultStream)
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, IFileSystemImageResult*, int>)((*lpVtbl)[39])
        )(this, resultStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT Exists([NativeTypeName("BSTR")] ushort* fullPath, FsiItemType* itemType)
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, ushort*, FsiItemType*, int>)((*lpVtbl)[40])
        )(this, fullPath, itemType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[41]))(
            this,
            discIdentifier
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT IdentifyFileSystemsOnDisc(
        IDiscRecorder2 discRecorder,
        FsiFileSystems* fileSystems
    )
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, IDiscRecorder2, FsiFileSystems*, int>)(
                (*lpVtbl)[42]
            )
        )(this, discRecorder, fileSystems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetDefaultFileSystemForImport(
        FsiFileSystems fileSystems,
        FsiFileSystems* importDefault
    )
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, FsiFileSystems, FsiFileSystems*, int>)(
                (*lpVtbl)[43]
            )
        )(this, fileSystems, importDefault);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT ImportFileSystem(FsiFileSystems* importedFileSystem)
    {
        return ((delegate* unmanaged<IFileSystemImage3, FsiFileSystems*, int>)((*lpVtbl)[44]))(
            this,
            importedFileSystem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT ImportSpecificFileSystem(FsiFileSystems fileSystemToUse)
    {
        return ((delegate* unmanaged<IFileSystemImage3, FsiFileSystems, int>)((*lpVtbl)[45]))(
            this,
            fileSystemToUse
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT RollbackToChangePoint([NativeTypeName("LONG")] int changePoint)
    {
        return ((delegate* unmanaged<IFileSystemImage3, int, int>)((*lpVtbl)[46]))(
            this,
            changePoint
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT LockInChangePoint()
    {
        return ((delegate* unmanaged<IFileSystemImage3, int>)((*lpVtbl)[47]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT CreateDirectoryItem(
        [NativeTypeName("BSTR")] ushort* name,
        IFsiDirectoryItem* newItem
    )
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, ushort*, IFsiDirectoryItem*, int>)(
                (*lpVtbl)[48]
            )
        )(this, name, newItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT CreateFileItem([NativeTypeName("BSTR")] ushort* name, IFsiFileItem* newItem)
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, ushort*, IFsiFileItem*, int>)((*lpVtbl)[49])
        )(this, name, newItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[50]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[51]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, ushort**, int>)((*lpVtbl)[52]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, short*, int>)((*lpVtbl)[53]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, short, int>)((*lpVtbl)[54]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_MultisessionInterfaces(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, SAFEARRAY**, int>)((*lpVtbl)[55]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT put_MultisessionInterfaces(SAFEARRAY* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, SAFEARRAY*, int>)((*lpVtbl)[56]))(
            this,
            newVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_BootImageOptionsArray(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, SAFEARRAY**, int>)((*lpVtbl)[57]))(
            this,
            pVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_BootImageOptionsArray(SAFEARRAY* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3, SAFEARRAY*, int>)((*lpVtbl)[58]))(
            this,
            newVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_CreateRedundantUdfMetadataFiles(
        [NativeTypeName("VARIANT_BOOL *")] short* pVal
    )
    {
        return ((delegate* unmanaged<IFileSystemImage3, short*, int>)((*lpVtbl)[59]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_CreateRedundantUdfMetadataFiles(
        [NativeTypeName("VARIANT_BOOL")] short newVal
    )
    {
        return ((delegate* unmanaged<IFileSystemImage3, short, int>)((*lpVtbl)[60]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT ProbeSpecificFileSystem(
        FsiFileSystems fileSystemToProbe,
        [NativeTypeName("VARIANT_BOOL *")] short* isAppendable
    )
    {
        return (
            (delegate* unmanaged<IFileSystemImage3, FsiFileSystems, short*, int>)((*lpVtbl)[61])
        )(this, fileSystemToProbe, isAppendable);
    }

    public interface Interface : IFileSystemImage2.Interface
    {
        [VtblIndex(59)]
        HRESULT get_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal);

        [VtblIndex(60)]
        HRESULT put_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL")] short newVal);

        [VtblIndex(61)]
        HRESULT ProbeSpecificFileSystem(
            FsiFileSystems fileSystemToProbe,
            [NativeTypeName("VARIANT_BOOL *")] short* isAppendable
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

        [NativeTypeName("HRESULT (IFsiDirectoryItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFsiDirectoryItem*, int> get_Root;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SessionStartBlock;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SessionStartBlock;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeMediaBlocks;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_FreeMediaBlocks;

        [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2, int> SetMaxMediaBlocksFromDevice;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_UsedBlocks;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VolumeName;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_VolumeName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ImportedVolumeName;

        [NativeTypeName("HRESULT (IBootOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBootOptions*, int> get_BootImageOptions;

        [NativeTypeName("HRESULT (IBootOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBootOptions, int> put_BootImageOptions;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FileCount;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DirectoryCount;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_WorkingDirectory;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_WorkingDirectory;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ChangePoint;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_StrictFileSystemCompliance;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_StrictFileSystemCompliance;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_UseRestrictedCharacterSet;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_UseRestrictedCharacterSet;

        [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems*, int> get_FileSystemsToCreate;

        [NativeTypeName("HRESULT (FsiFileSystems) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, int> put_FileSystemsToCreate;

        [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems*, int> get_FileSystemsSupported;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_UDFRevision;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_UDFRevision;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_UDFRevisionsSupported;

        [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2, int> ChooseImageDefaults;

        [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MEDIA_PHYSICAL_TYPE,
            int> ChooseImageDefaultsForMediaType;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ISO9660InterchangeLevel;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ISO9660InterchangeLevel;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_ISO9660InterchangeLevelsSupported;

        [NativeTypeName("HRESULT (IFileSystemImageResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileSystemImageResult*, int> CreateResultImage;

        [NativeTypeName("HRESULT (BSTR, FsiItemType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, FsiItemType*, int> Exists;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> CalculateDiscIdentifier;

        [NativeTypeName("HRESULT (IDiscRecorder2 *, FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IDiscRecorder2,
            FsiFileSystems*,
            int> IdentifyFileSystemsOnDisc;

        [NativeTypeName("HRESULT (FsiFileSystems, FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            FsiFileSystems,
            FsiFileSystems*,
            int> GetDefaultFileSystemForImport;

        [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems*, int> ImportFileSystem;

        [NativeTypeName("HRESULT (FsiFileSystems) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, int> ImportSpecificFileSystem;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> RollbackToChangePoint;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockInChangePoint;

        [NativeTypeName("HRESULT (BSTR, IFsiDirectoryItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IFsiDirectoryItem*, int> CreateDirectoryItem;

        [NativeTypeName("HRESULT (BSTR, IFsiFileItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IFsiFileItem*, int> CreateFileItem;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VolumeNameUDF;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VolumeNameJoliet;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VolumeNameISO9660;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_StageFiles;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_StageFiles;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_MultisessionInterfaces;

        [NativeTypeName("HRESULT (SAFEARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY*, int> put_MultisessionInterfaces;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_BootImageOptionsArray;

        [NativeTypeName("HRESULT (SAFEARRAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY*, int> put_BootImageOptionsArray;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_CreateRedundantUdfMetadataFiles;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_CreateRedundantUdfMetadataFiles;

        [NativeTypeName("HRESULT (FsiFileSystems, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, short*, int> ProbeSpecificFileSystem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSystemImage3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSystemImage3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFileSystemImage2"/> to <see cref = "IFileSystemImage3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFileSystemImage2"/> instance to be converted </param>
    public static explicit operator IFileSystemImage3(Silk.NET.Windows.IFileSystemImage2 value)
    {
        return new IFileSystemImage3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSystemImage3"/> to <see cref = "Silk.NET.Windows.IFileSystemImage2"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSystemImage3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFileSystemImage2(IFileSystemImage3 value)
    {
        return new Silk.NET.Windows.IFileSystemImage2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFileSystemImage"/> to <see cref = "IFileSystemImage3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFileSystemImage"/> instance to be converted </param>
    public static explicit operator IFileSystemImage3(Silk.NET.Windows.IFileSystemImage value)
    {
        return new IFileSystemImage3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSystemImage3"/> to <see cref = "Silk.NET.Windows.IFileSystemImage"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSystemImage3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFileSystemImage(IFileSystemImage3 value)
    {
        return new Silk.NET.Windows.IFileSystemImage(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IFileSystemImage3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IFileSystemImage3(Silk.NET.Windows.IDispatch value)
    {
        return new IFileSystemImage3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSystemImage3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSystemImage3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IFileSystemImage3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSystemImage3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSystemImage3(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSystemImage3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSystemImage3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSystemImage3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSystemImage3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
