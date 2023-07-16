// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFileSystemImage3.xml' path='doc/member[@name="IFileSystemImage3"]/*'/>
[Guid("7CFF842C-7E97-4807-8304-910DD8F7C051")]
[NativeTypeName("struct IFileSystemImage3 : IFileSystemImage2")]
[NativeInheritance("IFileSystemImage2")]
public unsafe partial struct IFileSystemImage3 : IFileSystemImage3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSystemImage3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, Guid*, void**, int> )(lpVtbl[0]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSystemImage3*, uint> )(lpVtbl[1]))((IFileSystemImage3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSystemImage3*, uint> )(lpVtbl[2]))((IFileSystemImage3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, uint*, int> )(lpVtbl[3]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_Root"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Root(IFsiDirectoryItem** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IFsiDirectoryItem**, int> )(lpVtbl[7]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_SessionStartBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[8]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_SessionStartBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SessionStartBlock([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int, int> )(lpVtbl[9]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_FreeMediaBlocks"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[10]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_FreeMediaBlocks"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int, int> )(lpVtbl[11]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.SetMaxMediaBlocksFromDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetMaxMediaBlocksFromDevice(IDiscRecorder2* discRecorder)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IDiscRecorder2*, int> )(lpVtbl[12]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discRecorder);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_UsedBlocks"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UsedBlocks([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[13]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_VolumeName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[14]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_VolumeName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_VolumeName([NativeTypeName("BSTR")] ushort* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort*, int> )(lpVtbl[15]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_ImportedVolumeName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[16]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_BootImageOptions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BootImageOptions(IBootOptions** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IBootOptions**, int> )(lpVtbl[17]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_BootImageOptions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_BootImageOptions(IBootOptions* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IBootOptions*, int> )(lpVtbl[18]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_FileCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_FileCount([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[19]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_DirectoryCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DirectoryCount([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[20]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_WorkingDirectory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[21]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_WorkingDirectory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort*, int> )(lpVtbl[22]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_ChangePoint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ChangePoint([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[23]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_StrictFileSystemCompliance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short*, int> )(lpVtbl[24]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_StrictFileSystemCompliance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short, int> )(lpVtbl[25]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_UseRestrictedCharacterSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short*, int> )(lpVtbl[26]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_UseRestrictedCharacterSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short, int> )(lpVtbl[27]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_FileSystemsToCreate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_FileSystemsToCreate(FsiFileSystems* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems*, int> )(lpVtbl[28]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_FileSystemsToCreate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_FileSystemsToCreate(FsiFileSystems newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, int> )(lpVtbl[29]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_FileSystemsSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_FileSystemsSupported(FsiFileSystems* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems*, int> )(lpVtbl[30]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_UDFRevision"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_UDFRevision([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int, int> )(lpVtbl[31]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_UDFRevision"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_UDFRevision([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[32]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_UDFRevisionsSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_UDFRevisionsSupported(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int> )(lpVtbl[33]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.ChooseImageDefaults"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT ChooseImageDefaults(IDiscRecorder2* discRecorder)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IDiscRecorder2*, int> )(lpVtbl[34]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discRecorder);
    }

    /// <inheritdoc cref = "IFileSystemImage.ChooseImageDefaultsForMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IMAPI_MEDIA_PHYSICAL_TYPE, int> )(lpVtbl[35]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_ISO9660InterchangeLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int, int> )(lpVtbl[36]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_ISO9660InterchangeLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int*, int> )(lpVtbl[37]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_ISO9660InterchangeLevelsSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_ISO9660InterchangeLevelsSupported(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int> )(lpVtbl[38]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.CreateResultImage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateResultImage(IFileSystemImageResult** resultStream)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IFileSystemImageResult**, int> )(lpVtbl[39]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), resultStream);
    }

    /// <inheritdoc cref = "IFileSystemImage.Exists"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT Exists([NativeTypeName("BSTR")] ushort* fullPath, FsiItemType* itemType)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort*, FsiItemType*, int> )(lpVtbl[40]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fullPath, itemType);
    }

    /// <inheritdoc cref = "IFileSystemImage.CalculateDiscIdentifier"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[41]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discIdentifier);
    }

    /// <inheritdoc cref = "IFileSystemImage.IdentifyFileSystemsOnDisc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT IdentifyFileSystemsOnDisc(IDiscRecorder2* discRecorder, FsiFileSystems* fileSystems)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, IDiscRecorder2*, FsiFileSystems*, int> )(lpVtbl[42]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), discRecorder, fileSystems);
    }

    /// <inheritdoc cref = "IFileSystemImage.GetDefaultFileSystemForImport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetDefaultFileSystemForImport(FsiFileSystems fileSystems, FsiFileSystems* importDefault)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, FsiFileSystems*, int> )(lpVtbl[43]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fileSystems, importDefault);
    }

    /// <inheritdoc cref = "IFileSystemImage.ImportFileSystem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT ImportFileSystem(FsiFileSystems* importedFileSystem)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems*, int> )(lpVtbl[44]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), importedFileSystem);
    }

    /// <inheritdoc cref = "IFileSystemImage.ImportSpecificFileSystem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT ImportSpecificFileSystem(FsiFileSystems fileSystemToUse)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, int> )(lpVtbl[45]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fileSystemToUse);
    }

    /// <inheritdoc cref = "IFileSystemImage.RollbackToChangePoint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT RollbackToChangePoint([NativeTypeName("LONG")] int changePoint)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int, int> )(lpVtbl[46]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), changePoint);
    }

    /// <inheritdoc cref = "IFileSystemImage.LockInChangePoint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT LockInChangePoint()
    {
        return ((delegate* unmanaged<IFileSystemImage3*, int> )(lpVtbl[47]))((IFileSystemImage3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IFileSystemImage.CreateDirectoryItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT CreateDirectoryItem([NativeTypeName("BSTR")] ushort* name, IFsiDirectoryItem** newItem)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort*, IFsiDirectoryItem**, int> )(lpVtbl[48]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), name, newItem);
    }

    /// <inheritdoc cref = "IFileSystemImage.CreateFileItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT CreateFileItem([NativeTypeName("BSTR")] ushort* name, IFsiFileItem** newItem)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort*, IFsiFileItem**, int> )(lpVtbl[49]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), name, newItem);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_VolumeNameUDF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[50]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_VolumeNameJoliet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[51]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_VolumeNameISO9660"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, ushort**, int> )(lpVtbl[52]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_StageFiles"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short*, int> )(lpVtbl[53]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_StageFiles"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short, int> )(lpVtbl[54]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.get_MultisessionInterfaces"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_MultisessionInterfaces(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int> )(lpVtbl[55]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage.put_MultisessionInterfaces"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT put_MultisessionInterfaces(SAFEARRAY* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY*, int> )(lpVtbl[56]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFileSystemImage2.get_BootImageOptionsArray"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_BootImageOptionsArray(SAFEARRAY** pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY**, int> )(lpVtbl[57]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFileSystemImage2.put_BootImageOptionsArray"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_BootImageOptionsArray(SAFEARRAY* newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, SAFEARRAY*, int> )(lpVtbl[58]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <include file='IFileSystemImage3.xml' path='doc/member[@name="IFileSystemImage3.get_CreateRedundantUdfMetadataFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short*, int> )(lpVtbl[59]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFileSystemImage3.xml' path='doc/member[@name="IFileSystemImage3.put_CreateRedundantUdfMetadataFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, short, int> )(lpVtbl[60]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <include file='IFileSystemImage3.xml' path='doc/member[@name="IFileSystemImage3.ProbeSpecificFileSystem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT ProbeSpecificFileSystem(FsiFileSystems fileSystemToProbe, [NativeTypeName("VARIANT_BOOL *")] short* isAppendable)
    {
        return ((delegate* unmanaged<IFileSystemImage3*, FsiFileSystems, short*, int> )(lpVtbl[61]))((IFileSystemImage3*)Unsafe.AsPointer(ref this), fileSystemToProbe, isAppendable);
    }

    public interface Interface : IFileSystemImage2.Interface
    {
        [VtblIndex(59)]
        HRESULT get_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal);
        [VtblIndex(60)]
        HRESULT put_CreateRedundantUdfMetadataFiles([NativeTypeName("VARIANT_BOOL")] short newVal);
        [VtblIndex(61)]
        HRESULT ProbeSpecificFileSystem(FsiFileSystems fileSystemToProbe, [NativeTypeName("VARIANT_BOOL *")] short* isAppendable);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (IFsiDirectoryItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFsiDirectoryItem**, int> get_Root;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SessionStartBlock;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SessionStartBlock;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeMediaBlocks;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_FreeMediaBlocks;
        [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, int> SetMaxMediaBlocksFromDevice;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_UsedBlocks;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VolumeName;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_VolumeName;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ImportedVolumeName;
        [NativeTypeName("HRESULT (IBootOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBootOptions**, int> get_BootImageOptions;
        [NativeTypeName("HRESULT (IBootOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBootOptions*, int> put_BootImageOptions;
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
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, int> ChooseImageDefaults;
        [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_MEDIA_PHYSICAL_TYPE, int> ChooseImageDefaultsForMediaType;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ISO9660InterchangeLevel;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ISO9660InterchangeLevel;
        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_ISO9660InterchangeLevelsSupported;
        [NativeTypeName("HRESULT (IFileSystemImageResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileSystemImageResult**, int> CreateResultImage;
        [NativeTypeName("HRESULT (BSTR, FsiItemType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, FsiItemType*, int> Exists;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> CalculateDiscIdentifier;
        [NativeTypeName("HRESULT (IDiscRecorder2 *, FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, FsiFileSystems*, int> IdentifyFileSystemsOnDisc;
        [NativeTypeName("HRESULT (FsiFileSystems, FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, FsiFileSystems*, int> GetDefaultFileSystemForImport;
        [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems*, int> ImportFileSystem;
        [NativeTypeName("HRESULT (FsiFileSystems) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, int> ImportSpecificFileSystem;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> RollbackToChangePoint;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockInChangePoint;
        [NativeTypeName("HRESULT (BSTR, IFsiDirectoryItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IFsiDirectoryItem**, int> CreateDirectoryItem;
        [NativeTypeName("HRESULT (BSTR, IFsiFileItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IFsiFileItem**, int> CreateFileItem;
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
}