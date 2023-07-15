// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.GUID;
using static TerraFX.Interop.Windows.STORAGE_IDENTIFIER_TYPE;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmParameterBlock"]/*'/>
    [return: NativeTypeName("PVOID")]
    public static void* DeviceDsmParameterBlock([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
    {
        return (void*)((nuint)(Input) + Input->ParameterBlockOffset);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmDataSetRanges"]/*'/>
    [return: NativeTypeName("PDEVICE_DSM_RANGE")]
    public static DEVICE_DATA_SET_RANGE* DeviceDsmDataSetRanges([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
    {
        return (DEVICE_DATA_SET_RANGE*)((nuint)(Input) + Input->DataSetRangesOffset);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmInitializeInput"]/*'/>
    public static void DeviceDsmInitializeInput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Parameters, [NativeTypeName("DWORD")] uint ParameterBlockLength)
    {
        uint Bytes = 28;
        Unsafe.InitBlockUnaligned((Input), 0, (InputLength));
        Input->Size = unchecked(Bytes);
        Input->Action = Definition->Action;
        Input->Flags = Flags;
        if (ParameterBlockLength == 0)
        {
            goto Cleanup;
        }

        unchecked(Bytes) = unchecked(((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
        Input->ParameterBlockOffset = unchecked(Bytes);
        Input->ParameterBlockLength = ParameterBlockLength;
        if (Parameters == null)
        {
            goto Cleanup;
        }

        Unsafe.CopyBlockUnaligned((DeviceDsmParameterBlock(Input)), (Parameters), (Input->ParameterBlockLength));
        Cleanup:
            return;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmValidateInput"]/*'/>
    [return: NativeTypeName("BOOLEAN")]
    public static byte DeviceDsmValidateInput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength)
    {
        uint Max = 0;
        uint Min = 0;
        byte Valid = 0;
        if (Definition->Action != Input->Action)
        {
            goto Cleanup;
        }

        if (Definition->ParameterBlockLength != 0)
        {
            Min = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES)));
            Max = InputLength;
            if (Input->ParameterBlockOffset < Min || Input->ParameterBlockOffset > Max || (Input->ParameterBlockOffset % Definition->ParameterBlockAlignment) != 0)
            {
                goto Cleanup;
            }

            Min = Definition->ParameterBlockLength;
            Max = InputLength - Input->ParameterBlockOffset;
            if (Input->ParameterBlockLength < Min || Input->ParameterBlockLength > Max)
            {
                goto Cleanup;
            }
        }

        if ((Input->Flags & 0x00000001) == 0)
        {
            Min = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES)));
            Max = InputLength;
            if (Input->DataSetRangesOffset < Min || Input->DataSetRangesOffset > Max || (Input->DataSetRangesOffset % 8) != 0)
            {
                goto Cleanup;
            }

            Min = unchecked((uint)(sizeof(DEVICE_DATA_SET_RANGE)));
            Max = InputLength - Input->DataSetRangesOffset;
            if (Input->DataSetRangesLength < Min || Input->DataSetRangesLength > Max || (Input->DataSetRangesLength % Min) != 0)
            {
                goto Cleanup;
            }

            if ((Definition->SingleRange) != 0 && Input->DataSetRangesLength != Min)
            {
                goto Cleanup;
            }
        }
        else
        {
            if (Input->DataSetRangesOffset != 0 || Input->DataSetRangesLength != 0)
            {
                goto Cleanup;
            }
        }

        if (Input->ParameterBlockOffset < Input->DataSetRangesOffset && Input->ParameterBlockOffset + Input->ParameterBlockLength > Input->DataSetRangesOffset)
        {
            goto Cleanup;
        }

        if (Input->DataSetRangesOffset < Input->ParameterBlockOffset && Input->DataSetRangesOffset + Input->DataSetRangesLength > Input->ParameterBlockOffset)
        {
            goto Cleanup;
        }

        Valid = 1;
        Cleanup:
            return Valid;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmOutputBlock"]/*'/>
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows6.2")]
    public static void* DeviceDsmOutputBlock([NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output)
    {
        return (void*)((nuint)(Output) + Output->OutputBlockOffset);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmGetOutputLength"]/*'/>
    [return: NativeTypeName("DWORD")]
    public static uint DeviceDsmGetOutputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint OutputBlockLength)
    {
        uint Bytes = 0;
        if (Definition->HasOutput == 0)
        {
            goto Cleanup;
        }

        Bytes = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT)));
        if (Definition->OutputBlockLength == 0)
        {
            goto Cleanup;
        }

        if (Definition->OutputBlockLength > OutputBlockLength)
        {
            OutputBlockLength = Definition->OutputBlockLength;
        }

        Bytes = (((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
        Bytes += OutputBlockLength;
        Cleanup:
            return Bytes;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmValidateOutputLength"]/*'/>
    [return: NativeTypeName("BOOLEAN")]
    public static byte DeviceDsmValidateOutputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint OutputLength)
    {
        uint Bytes = DeviceDsmGetOutputLength(Definition, 0);
        return (byte)((OutputLength >= Bytes) ? 1 : 0);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmGetOutputBlockLength"]/*'/>
    [return: NativeTypeName("DWORD")]
    public static uint DeviceDsmGetOutputBlockLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint OutputLength)
    {
        uint Bytes = 0;
        if (Definition->OutputBlockLength == 0)
        {
            goto Cleanup;
        }

        Bytes = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT)));
        Bytes = (((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
        Bytes = OutputLength - Bytes;
        Cleanup:
            return Bytes;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmInitializeOutput"]/*'/>
    [SupportedOSPlatform("windows6.2")]
    public static void DeviceDsmInitializeOutput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output, [NativeTypeName("DWORD")] uint OutputLength, [NativeTypeName("DWORD")] uint Flags)
    {
        uint Bytes = 36;
        Unsafe.InitBlockUnaligned((Output), 0, (OutputLength));
        Output->Size = unchecked(Bytes);
        Output->Action = Definition->Action;
        Output->Flags = Flags;
        if (Definition->OutputBlockLength != 0)
        {
            unchecked(Bytes) = unchecked(((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
            Output->OutputBlockOffset = unchecked(Bytes);
            Output->OutputBlockLength = unchecked(OutputLength - Bytes);
        }

        return;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceDsmValidateOutput"]/*'/>
    [return: NativeTypeName("BOOLEAN")]
    [SupportedOSPlatform("windows6.2")]
    public static byte DeviceDsmValidateOutput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output, [NativeTypeName("DWORD")] uint OutputLength)
    {
        uint Max = 0;
        uint Min = 0;
        byte Valid = 0;
        if (Definition->Action != Output->Action)
        {
            goto Cleanup;
        }

        if (Definition->HasOutput == 0)
        {
            goto Cleanup;
        }

        if (Definition->OutputBlockLength != 0)
        {
            Min = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT)));
            Max = OutputLength;
            if (Output->OutputBlockOffset < Min || Output->OutputBlockOffset > Max || (Output->OutputBlockOffset % Definition->OutputBlockAlignment) != 0)
            {
                goto Cleanup;
            }

            Min = Definition->OutputBlockLength;
            Max = OutputLength - Output->OutputBlockOffset;
            if (Output->OutputBlockLength < Min || Output->OutputBlockLength > Max)
            {
                goto Cleanup;
            }
        }
        else
        {
            if (Output->OutputBlockOffset != 0 || Output->OutputBlockLength != 0)
            {
                goto Cleanup;
            }
        }

        Valid = 1;
        Cleanup:
            return Valid;
    }

    [NativeTypeName("#define DiskClassGuid GUID_DEVINTERFACE_DISK")]
    public static ref readonly Guid DiskClassGuid => ref GUID_DEVINTERFACE_DISK;

    [NativeTypeName("#define CdRomClassGuid GUID_DEVINTERFACE_CDROM")]
    public static ref readonly Guid CdRomClassGuid => ref GUID_DEVINTERFACE_CDROM;

    [NativeTypeName("#define PartitionClassGuid GUID_DEVINTERFACE_PARTITION")]
    public static ref readonly Guid PartitionClassGuid => ref GUID_DEVINTERFACE_PARTITION;

    [NativeTypeName("#define TapeClassGuid GUID_DEVINTERFACE_TAPE")]
    public static ref readonly Guid TapeClassGuid => ref GUID_DEVINTERFACE_TAPE;

    [NativeTypeName("#define WriteOnceDiskClassGuid GUID_DEVINTERFACE_WRITEONCEDISK")]
    public static ref readonly Guid WriteOnceDiskClassGuid => ref GUID_DEVINTERFACE_WRITEONCEDISK;

    [NativeTypeName("#define VolumeClassGuid GUID_DEVINTERFACE_VOLUME")]
    public static ref readonly Guid VolumeClassGuid => ref GUID_DEVINTERFACE_VOLUME;

    [NativeTypeName("#define MediumChangerClassGuid GUID_DEVINTERFACE_MEDIUMCHANGER")]
    public static ref readonly Guid MediumChangerClassGuid => ref GUID_DEVINTERFACE_MEDIUMCHANGER;

    [NativeTypeName("#define FloppyClassGuid GUID_DEVINTERFACE_FLOPPY")]
    public static ref readonly Guid FloppyClassGuid => ref GUID_DEVINTERFACE_FLOPPY;

    [NativeTypeName("#define CdChangerClassGuid GUID_DEVINTERFACE_CDCHANGER")]
    public static ref readonly Guid CdChangerClassGuid => ref GUID_DEVINTERFACE_CDCHANGER;

    [NativeTypeName("#define StoragePortClassGuid GUID_DEVINTERFACE_STORAGEPORT")]
    public static ref readonly Guid StoragePortClassGuid => ref GUID_DEVINTERFACE_STORAGEPORT;

    [NativeTypeName("#define HiddenVolumeClassGuid GUID_DEVINTERFACE_HIDDEN_VOLUME")]
    public static ref readonly Guid HiddenVolumeClassGuid => ref GUID_DEVINTERFACE_HIDDEN_VOLUME;

    [NativeTypeName("#define METHOD_BUFFERED 0")]
    public const int METHOD_BUFFERED = 0;
    [NativeTypeName("#define METHOD_IN_DIRECT 1")]
    public const int METHOD_IN_DIRECT = 1;
    [NativeTypeName("#define METHOD_OUT_DIRECT 2")]
    public const int METHOD_OUT_DIRECT = 2;
    [NativeTypeName("#define METHOD_NEITHER 3")]
    public const int METHOD_NEITHER = 3;
    [NativeTypeName("#define METHOD_DIRECT_TO_HARDWARE METHOD_IN_DIRECT")]
    public const int METHOD_DIRECT_TO_HARDWARE = 1;
    [NativeTypeName("#define METHOD_DIRECT_FROM_HARDWARE METHOD_OUT_DIRECT")]
    public const int METHOD_DIRECT_FROM_HARDWARE = 2;
    [NativeTypeName("#define OBSOLETE_IOCTL_STORAGE_RESET_BUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0400, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
    public const int OBSOLETE_IOCTL_STORAGE_RESET_BUS = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0400) << 2) | (0));
    [NativeTypeName("#define OBSOLETE_IOCTL_STORAGE_RESET_DEVICE CTL_CODE(IOCTL_STORAGE_BASE, 0x0401, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
    public const int OBSOLETE_IOCTL_STORAGE_RESET_DEVICE = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0401) << 2) | (0));
    [NativeTypeName("#define RECOVERED_WRITES_VALID 0x00000001")]
    public const int RECOVERED_WRITES_VALID = 0x00000001;
    [NativeTypeName("#define UNRECOVERED_WRITES_VALID 0x00000002")]
    public const int UNRECOVERED_WRITES_VALID = 0x00000002;
    [NativeTypeName("#define RECOVERED_READS_VALID 0x00000004")]
    public const int RECOVERED_READS_VALID = 0x00000004;
    [NativeTypeName("#define UNRECOVERED_READS_VALID 0x00000008")]
    public const int UNRECOVERED_READS_VALID = 0x00000008;
    [NativeTypeName("#define WRITE_COMPRESSION_INFO_VALID 0x00000010")]
    public const int WRITE_COMPRESSION_INFO_VALID = 0x00000010;
    [NativeTypeName("#define MEDIA_ERASEABLE 0x00000001")]
    public const int MEDIA_ERASEABLE = 0x00000001;
    [NativeTypeName("#define MEDIA_WRITE_ONCE 0x00000002")]
    public const int MEDIA_WRITE_ONCE = 0x00000002;
    [NativeTypeName("#define MEDIA_READ_ONLY 0x00000004")]
    public const int MEDIA_READ_ONLY = 0x00000004;
    [NativeTypeName("#define MEDIA_READ_WRITE 0x00000008")]
    public const int MEDIA_READ_WRITE = 0x00000008;
    [NativeTypeName("#define MEDIA_WRITE_PROTECTED 0x00000100")]
    public const int MEDIA_WRITE_PROTECTED = 0x00000100;
    [NativeTypeName("#define MEDIA_CURRENTLY_MOUNTED 0x80000000")]
    public const uint MEDIA_CURRENTLY_MOUNTED = 0x80000000;
    [NativeTypeName("#define SRB_TYPE_SCSI_REQUEST_BLOCK 0")]
    public const int SRB_TYPE_SCSI_REQUEST_BLOCK = 0;
    [NativeTypeName("#define SRB_TYPE_STORAGE_REQUEST_BLOCK 1")]
    public const int SRB_TYPE_STORAGE_REQUEST_BLOCK = 1;
    [NativeTypeName("#define StorageIdTypeNAA StorageIdTypeFCPHName")]
    public const STORAGE_IDENTIFIER_TYPE StorageIdTypeNAA = StorageIdTypeFCPHName;
    [NativeTypeName("#define DeviceDsmActionFlag_NonDestructive (0x80000000)")]
    public const uint DeviceDsmActionFlag_NonDestructive = (0x80000000);
    [NativeTypeName("#define DEVICEDUMP_STRUCTURE_VERSION_V1 1")]
    public const int DEVICEDUMP_STRUCTURE_VERSION_V1 = 1;
    [NativeTypeName("#define DEVICEDUMP_MAX_IDSTRING 32")]
    public const int DEVICEDUMP_MAX_IDSTRING = 32;
    [NativeTypeName("#define DDUMP_FLAG_DATA_READ_FROM_DEVICE 0x0001")]
    public const int DDUMP_FLAG_DATA_READ_FROM_DEVICE = 0x0001;
    [NativeTypeName("#define CDB_SIZE 16")]
    public const int CDB_SIZE = 16;
    [NativeTypeName("#define TELEMETRY_COMMAND_SIZE 16")]
    public const int TELEMETRY_COMMAND_SIZE = 16;
    [NativeTypeName("#define DEVICEDUMP_CAP_PRIVATE_SECTION 0x00000001")]
    public const int DEVICEDUMP_CAP_PRIVATE_SECTION = 0x00000001;
    [NativeTypeName("#define DEVICEDUMP_CAP_RESTRICTED_SECTION 0x00000002")]
    public const int DEVICEDUMP_CAP_RESTRICTED_SECTION = 0x00000002;
    [NativeTypeName("#define STORATTRIBUTE_NONE 0")]
    public const int STORATTRIBUTE_NONE = 0;
    [NativeTypeName("#define STORATTRIBUTE_MANAGEMENT_STATE 1")]
    public const int STORATTRIBUTE_MANAGEMENT_STATE = 1;
    [NativeTypeName("#define SCM_MAX_SYMLINK_LEN_IN_CHARS 256")]
    public const int SCM_MAX_SYMLINK_LEN_IN_CHARS = 256;
    [NativeTypeName("#define SCM_REGION_SPA_UNKNOWN MAXDWORD64")]
    public const ulong SCM_REGION_SPA_UNKNOWN = ((ulong)(~((ulong)(0))));
    [NativeTypeName("#define SCM_PD_FIRMWARE_REVISION_LENGTH_BYTES 32")]
    public const int SCM_PD_FIRMWARE_REVISION_LENGTH_BYTES = 32;
    [NativeTypeName("#define SCM_PD_MEMORY_SIZE_UNKNOWN MAXDWORD64")]
    public const ulong SCM_PD_MEMORY_SIZE_UNKNOWN = ((ulong)(~((ulong)(0))));
    [NativeTypeName("#define SCM_PD_PROPERTY_NAME_LENGTH_IN_CHARS 128")]
    public const int SCM_PD_PROPERTY_NAME_LENGTH_IN_CHARS = 128;
    [NativeTypeName("#define SCM_PD_MAX_OPERATIONAL_STATUS 16")]
    public const int SCM_PD_MAX_OPERATIONAL_STATUS = 16;
    [NativeTypeName("#define SCM_PD_FIRMWARE_LAST_DOWNLOAD 0x1")]
    public const int SCM_PD_FIRMWARE_LAST_DOWNLOAD = 0x1;
    [NativeTypeName("#define OBSOLETE_DISK_GET_WRITE_CACHE_STATE CTL_CODE(IOCTL_DISK_BASE, 0x0037, METHOD_BUFFERED, FILE_READ_ACCESS)")]
    public const int OBSOLETE_DISK_GET_WRITE_CACHE_STATE = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0037) << 2) | (0));
    [NativeTypeName("#define PARTIITON_OS_DATA 0x29")]
    public const int PARTIITON_OS_DATA = 0x29;
    [NativeTypeName("#define VALID_NTFT 0xC0")]
    public const int VALID_NTFT = 0xC0;
    [NativeTypeName("#define HIST_NO_OF_BUCKETS 24")]
    public const int HIST_NO_OF_BUCKETS = 24;
    [NativeTypeName("#define HISTOGRAM_BUCKET_SIZE sizeof(HISTOGRAM_BUCKET)")]
    public const uint HISTOGRAM_BUCKET_SIZE = 8;
    [NativeTypeName("#define DISK_HISTOGRAM_SIZE sizeof(DISK_HISTOGRAM)")]
    public const uint DISK_HISTOGRAM_SIZE = 72;
    [NativeTypeName("#define DISK_LOGGING_START 0")]
    public const int DISK_LOGGING_START = 0;
    [NativeTypeName("#define DISK_LOGGING_STOP 1")]
    public const int DISK_LOGGING_STOP = 1;
    [NativeTypeName("#define DISK_LOGGING_DUMP 2")]
    public const int DISK_LOGGING_DUMP = 2;
    [NativeTypeName("#define DISK_BINNING 3")]
    public const int DISK_BINNING = 3;
    [NativeTypeName("#define CAP_ATA_ID_CMD 1")]
    public const int CAP_ATA_ID_CMD = 1;
    [NativeTypeName("#define CAP_ATAPI_ID_CMD 2")]
    public const int CAP_ATAPI_ID_CMD = 2;
    [NativeTypeName("#define CAP_SMART_CMD 4")]
    public const int CAP_SMART_CMD = 4;
    [NativeTypeName("#define ATAPI_ID_CMD 0xA1")]
    public const int ATAPI_ID_CMD = 0xA1;
    [NativeTypeName("#define IDENTIFY_BUFFER_SIZE 512")]
    public const int IDENTIFY_BUFFER_SIZE = 512;
    [NativeTypeName("#define SAVE_ATTRIBUTE_VALUES 0xD3")]
    public const int SAVE_ATTRIBUTE_VALUES = 0xD3;
    [NativeTypeName("#define EXECUTE_OFFLINE_DIAGS 0xD4")]
    public const int EXECUTE_OFFLINE_DIAGS = 0xD4;
    [NativeTypeName("#define DISABLE_SMART 0xD9")]
    public const int DISABLE_SMART = 0xD9;
    [NativeTypeName("#define RETURN_SMART_STATUS 0xDA")]
    public const int RETURN_SMART_STATUS = 0xDA;
    [NativeTypeName("#define DISK_ATTRIBUTE_OFFLINE 0x0000000000000001")]
    public const int DISK_ATTRIBUTE_OFFLINE = 0x0000000000000001;
    [NativeTypeName("#define DISK_ATTRIBUTE_READ_ONLY 0x0000000000000002")]
    public const int DISK_ATTRIBUTE_READ_ONLY = 0x0000000000000002;
    [NativeTypeName("#define VENDOR_ID_LENGTH 8")]
    public const int VENDOR_ID_LENGTH = 8;
    [NativeTypeName("#define REVISION_LENGTH 4")]
    public const int REVISION_LENGTH = 4;
    [NativeTypeName("#define LOCK_UNLOCK_IEPORT 0x01")]
    public const int LOCK_UNLOCK_IEPORT = 0x01;
    [NativeTypeName("#define LOCK_UNLOCK_DOOR 0x02")]
    public const int LOCK_UNLOCK_DOOR = 0x02;
    [NativeTypeName("#define LOCK_UNLOCK_KEYPAD 0x04")]
    public const int LOCK_UNLOCK_KEYPAD = 0x04;
    [NativeTypeName("#define LOCK_ELEMENT 0")]
    public const int LOCK_ELEMENT = 0;
    [NativeTypeName("#define UNLOCK_ELEMENT 1")]
    public const int UNLOCK_ELEMENT = 1;
    [NativeTypeName("#define EXTEND_IEPORT 2")]
    public const int EXTEND_IEPORT = 2;
    [NativeTypeName("#define RETRACT_IEPORT 3")]
    public const int RETRACT_IEPORT = 3;
    [NativeTypeName("#define SEARCH_ALL 0x0")]
    public const int SEARCH_ALL = 0x0;
    [NativeTypeName("#define SEARCH_PRIMARY 0x1")]
    public const int SEARCH_PRIMARY = 0x1;
    [NativeTypeName("#define SEARCH_ALTERNATE 0x2")]
    public const int SEARCH_ALTERNATE = 0x2;
    [NativeTypeName("#define SEARCH_ALL_NO_SEQ 0x4")]
    public const int SEARCH_ALL_NO_SEQ = 0x4;
    [NativeTypeName("#define SEARCH_PRI_NO_SEQ 0x5")]
    public const int SEARCH_PRI_NO_SEQ = 0x5;
    [NativeTypeName("#define SEARCH_ALT_NO_SEQ 0x6")]
    public const int SEARCH_ALT_NO_SEQ = 0x6;
    [NativeTypeName("#define ASSERT_PRIMARY 0x8")]
    public const int ASSERT_PRIMARY = 0x8;
    [NativeTypeName("#define ASSERT_ALTERNATE 0x9")]
    public const int ASSERT_ALTERNATE = 0x9;
    [NativeTypeName("#define REPLACE_PRIMARY 0xA")]
    public const int REPLACE_PRIMARY = 0xA;
    [NativeTypeName("#define REPLACE_ALTERNATE 0xB")]
    public const int REPLACE_ALTERNATE = 0xB;
    [NativeTypeName("#define UNDEFINE_PRIMARY 0xC")]
    public const int UNDEFINE_PRIMARY = 0xC;
    [NativeTypeName("#define UNDEFINE_ALTERNATE 0xD")]
    public const int UNDEFINE_ALTERNATE = 0xD;
    [NativeTypeName("#define VOLUME_IS_DIRTY (0x00000001)")]
    public const int VOLUME_IS_DIRTY = (0x00000001);
    [NativeTypeName("#define VOLUME_UPGRADE_SCHEDULED (0x00000002)")]
    public const int VOLUME_UPGRADE_SCHEDULED = (0x00000002);
    [NativeTypeName("#define VOLUME_SESSION_OPEN (0x00000004)")]
    public const int VOLUME_SESSION_OPEN = (0x00000004);
    [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_NTFS 1")]
    public const int FILESYSTEM_STATISTICS_TYPE_NTFS = 1;
    [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_FAT 2")]
    public const int FILESYSTEM_STATISTICS_TYPE_FAT = 2;
    [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_EXFAT 3")]
    public const int FILESYSTEM_STATISTICS_TYPE_EXFAT = 3;
    [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_REFS 4")]
    public const int FILESYSTEM_STATISTICS_TYPE_REFS = 4;
    [NativeTypeName("#define ENCRYPTION_FORMAT_DEFAULT (0x01)")]
    public const int ENCRYPTION_FORMAT_DEFAULT = (0x01);
    [NativeTypeName("#define ENCRYPTED_DATA_INFO_SPARSE_FILE 1")]
    public const int ENCRYPTED_DATA_INFO_SPARSE_FILE = 1;
    [NativeTypeName("#define COPYFILE_SIS_LINK 0x0001")]
    public const int COPYFILE_SIS_LINK = 0x0001;
    [NativeTypeName("#define COPYFILE_SIS_REPLACE 0x0002")]
    public const int COPYFILE_SIS_REPLACE = 0x0002;
    [NativeTypeName("#define COPYFILE_SIS_FLAGS 0x0003")]
    public const int COPYFILE_SIS_FLAGS = 0x0003;
    [NativeTypeName("#define OPLOCK_LEVEL_CACHE_READ (0x00000001)")]
    public const int OPLOCK_LEVEL_CACHE_READ = (0x00000001);
    [NativeTypeName("#define OPLOCK_LEVEL_CACHE_HANDLE (0x00000002)")]
    public const int OPLOCK_LEVEL_CACHE_HANDLE = (0x00000002);
    [NativeTypeName("#define OPLOCK_LEVEL_CACHE_WRITE (0x00000004)")]
    public const int OPLOCK_LEVEL_CACHE_WRITE = (0x00000004);
    [NativeTypeName("#define REQUEST_OPLOCK_INPUT_FLAG_REQUEST (0x00000001)")]
    public const int REQUEST_OPLOCK_INPUT_FLAG_REQUEST = (0x00000001);
    [NativeTypeName("#define REQUEST_OPLOCK_INPUT_FLAG_ACK (0x00000002)")]
    public const int REQUEST_OPLOCK_INPUT_FLAG_ACK = (0x00000002);
    [NativeTypeName("#define REQUEST_OPLOCK_INPUT_FLAG_COMPLETE_ACK_ON_CLOSE (0x00000004)")]
    public const int REQUEST_OPLOCK_INPUT_FLAG_COMPLETE_ACK_ON_CLOSE = (0x00000004);
    [NativeTypeName("#define REQUEST_OPLOCK_CURRENT_VERSION 1")]
    public const int REQUEST_OPLOCK_CURRENT_VERSION = 1;
    [NativeTypeName("#define REQUEST_OPLOCK_OUTPUT_FLAG_ACK_REQUIRED (0x00000001)")]
    public const int REQUEST_OPLOCK_OUTPUT_FLAG_ACK_REQUIRED = (0x00000001);
    [NativeTypeName("#define REQUEST_OPLOCK_OUTPUT_FLAG_MODES_PROVIDED (0x00000002)")]
    public const int REQUEST_OPLOCK_OUTPUT_FLAG_MODES_PROVIDED = (0x00000002);
    [NativeTypeName("#define SD_GLOBAL_CHANGE_TYPE_MACHINE_SID 1")]
    public const int SD_GLOBAL_CHANGE_TYPE_MACHINE_SID = 1;
    [NativeTypeName("#define SD_GLOBAL_CHANGE_TYPE_QUERY_STATS (1 << 16)")]
    public const int SD_GLOBAL_CHANGE_TYPE_QUERY_STATS = (1 << 16);
    [NativeTypeName("#define SD_GLOBAL_CHANGE_TYPE_ENUM_SDS (2 << 16)")]
    public const int SD_GLOBAL_CHANGE_TYPE_ENUM_SDS = (2 << 16);
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_PAGE_FILE 0x00000001")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_PAGE_FILE = 0x00000001;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_DENY_DEFRAG_SET 0x00000002")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_DENY_DEFRAG_SET = 0x00000002;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_FS_SYSTEM_FILE 0x00000004")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_FS_SYSTEM_FILE = 0x00000004;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_TXF_SYSTEM_FILE 0x00000008")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_TXF_SYSTEM_FILE = 0x00000008;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_MASK 0xff000000")]
    public const uint LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_MASK = 0xff000000;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_DATA 0x01000000")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_DATA = 0x01000000;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_INDEX 0x02000000")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_INDEX = 0x02000000;
    [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_SYSTEM 0x03000000")]
    public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_SYSTEM = 0x03000000;
    [NativeTypeName("#define CSV_MGMTLOCK_CHECK_VOLUME_REDIRECTED 0x00000001")]
    public const int CSV_MGMTLOCK_CHECK_VOLUME_REDIRECTED = 0x00000001;
    [NativeTypeName("#define CSV_NAMESPACE_INFO_V1 (sizeof(CSV_NAMESPACE_INFO))")]
    public const uint CSV_NAMESPACE_INFO_V1 = (24);
    [NativeTypeName("#define CSV_INVALID_DEVICE_NUMBER 0xFFFFFFFF")]
    public const uint CSV_INVALID_DEVICE_NUMBER = 0xFFFFFFFF;
    [NativeTypeName("#define CSV_QUERY_MDS_PATH_V2_VERSION_1 1")]
    public const int CSV_QUERY_MDS_PATH_V2_VERSION_1 = 1;
    [NativeTypeName("#define CSV_QUERY_MDS_PATH_FLAG_STORAGE_ON_THIS_NODE_IS_CONNECTED 0x1")]
    public const int CSV_QUERY_MDS_PATH_FLAG_STORAGE_ON_THIS_NODE_IS_CONNECTED = 0x1;
    [NativeTypeName("#define CSV_QUERY_MDS_PATH_FLAG_CSV_DIRECT_IO_ENABLED 0x2")]
    public const int CSV_QUERY_MDS_PATH_FLAG_CSV_DIRECT_IO_ENABLED = 0x2;
    [NativeTypeName("#define CSV_QUERY_MDS_PATH_FLAG_SMB_BYPASS_CSV_ENABLED 0x4")]
    public const int CSV_QUERY_MDS_PATH_FLAG_SMB_BYPASS_CSV_ENABLED = 0x4;
    [NativeTypeName("#define CHECKSUM_TYPE_UNCHANGED (-1)")]
    public const int CHECKSUM_TYPE_UNCHANGED = (-1);
    [NativeTypeName("#define CHECKSUM_TYPE_NONE (0)")]
    public const int CHECKSUM_TYPE_NONE = (0);
    [NativeTypeName("#define CHECKSUM_TYPE_CRC32 (1)")]
    public const int CHECKSUM_TYPE_CRC32 = (1);
    [NativeTypeName("#define CHECKSUM_TYPE_CRC64 (2)")]
    public const int CHECKSUM_TYPE_CRC64 = (2);
    [NativeTypeName("#define CHECKSUM_TYPE_ECC (3)")]
    public const int CHECKSUM_TYPE_ECC = (3);
    [NativeTypeName("#define CHECKSUM_TYPE_FIRST_UNUSED_TYPE (4)")]
    public const int CHECKSUM_TYPE_FIRST_UNUSED_TYPE = (4);
    [NativeTypeName("#define OFFLOAD_READ_FLAG_ALL_ZERO_BEYOND_CURRENT_RANGE (1)")]
    public const int OFFLOAD_READ_FLAG_ALL_ZERO_BEYOND_CURRENT_RANGE = (1);
    [NativeTypeName("#define VALID_WRITE_USN_REASON_MASK (USN_REASON_DATA_OVERWRITE |        \\\r\n                                         USN_REASON_CLOSE)")]
    public const uint VALID_WRITE_USN_REASON_MASK = ((0x00000001) | (0x80000000));
    [NativeTypeName("#define DUPLICATE_EXTENTS_DATA_EX_SOURCE_ATOMIC 0x00000001")]
    public const int DUPLICATE_EXTENTS_DATA_EX_SOURCE_ATOMIC = 0x00000001;
    [NativeTypeName("#define DUPLICATE_EXTENTS_DATA_EX_ASYNC 0x00000002")]
    public const int DUPLICATE_EXTENTS_DATA_EX_ASYNC = 0x00000002;
    [NativeTypeName("#define ASYNC_DUPLICATE_EXTENTS_STATUS_V1 sizeof(ASYNC_DUPLICATE_EXTENTS_STATUS)")]
    public const uint ASYNC_DUPLICATE_EXTENTS_STATUS_V1 = 40;
    [NativeTypeName("#define REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V0 0")]
    public const int REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V0 = 0;
    [NativeTypeName("#define REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V1 1")]
    public const int REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V1 = 1;
    [NativeTypeName("#define REFS_SMR_VOLUME_GC_PARAMETERS_VERSION_V1 1")]
    public const int REFS_SMR_VOLUME_GC_PARAMETERS_VERSION_V1 = 1;
    [NativeTypeName("#define STREAMS_INVALID_ID (0)")]
    public const int STREAMS_INVALID_ID = (0);
    [NativeTypeName("#define STREAMS_MAX_ID (MAXWORD  )")]
    public const int STREAMS_MAX_ID = (0xffff);
    [NativeTypeName("#define STREAMS_ASSOCIATE_ID_CLEAR (0x1)")]
    public const int STREAMS_ASSOCIATE_ID_CLEAR = (0x1);
    [NativeTypeName("#define STREAMS_ASSOCIATE_ID_SET (0x2)")]
    public const int STREAMS_ASSOCIATE_ID_SET = (0x2);
    [NativeTypeName("#define DAX_ALLOC_ALIGNMENT_FLAG_MANDATORY (0x00000001)")]
    public const int DAX_ALLOC_ALIGNMENT_FLAG_MANDATORY = (0x00000001);
    [NativeTypeName("#define DAX_ALLOC_ALIGNMENT_FLAG_FALLBACK_SPECIFIED (0x00000002)")]
    public const int DAX_ALLOC_ALIGNMENT_FLAG_FALLBACK_SPECIFIED = (0x00000002);
    [NativeTypeName("#define WOF_CURRENT_VERSION (0x00000001)")]
    public const int WOF_CURRENT_VERSION = (0x00000001);
    [NativeTypeName("#define WOF_PROVIDER_WIM (0x00000001)")]
    public const int WOF_PROVIDER_WIM = (0x00000001);
    [NativeTypeName("#define WOF_PROVIDER_FILE (0x00000002)")]
    public const int WOF_PROVIDER_FILE = (0x00000002);
    [NativeTypeName("#define WOF_PROVIDER_CLOUD (0x00000003)")]
    public const int WOF_PROVIDER_CLOUD = (0x00000003);
    [NativeTypeName("#define WIM_PROVIDER_HASH_SIZE 20")]
    public const int WIM_PROVIDER_HASH_SIZE = 20;
    [NativeTypeName("#define WIM_PROVIDER_CURRENT_VERSION (0x00000001)")]
    public const int WIM_PROVIDER_CURRENT_VERSION = (0x00000001);
    [NativeTypeName("#define WIM_PROVIDER_EXTERNAL_FLAG_NOT_ACTIVE (0x00000001)")]
    public const int WIM_PROVIDER_EXTERNAL_FLAG_NOT_ACTIVE = (0x00000001);
    [NativeTypeName("#define WIM_PROVIDER_EXTERNAL_FLAG_SUSPENDED (0x00000002)")]
    public const int WIM_PROVIDER_EXTERNAL_FLAG_SUSPENDED = (0x00000002);
    [NativeTypeName("#define WIM_BOOT_OS_WIM (0x00000001)")]
    public const int WIM_BOOT_OS_WIM = (0x00000001);
    [NativeTypeName("#define WIM_BOOT_NOT_OS_WIM (0x00000000)")]
    public const int WIM_BOOT_NOT_OS_WIM = (0x00000000);
    [NativeTypeName("#define PROJFS_PROTOCOL_VERSION 3")]
    public const int PROJFS_PROTOCOL_VERSION = 3;
    [NativeTypeName("#define IRP_EXT_TRACK_OFFSET_HEADER_VALIDATION_VALUE 'TO'")]
    public const int IRP_EXT_TRACK_OFFSET_HEADER_VALIDATION_VALUE = 0x544F;
    [NativeTypeName("#define EFS_TRACKED_OFFSET_HEADER_FLAG 0x0001")]
    public const int EFS_TRACKED_OFFSET_HEADER_FLAG = 0x0001;
    [NativeTypeName("#define SPACES_TRACKED_OFFSET_HEADER_FLAG 0x0002")]
    public const int SPACES_TRACKED_OFFSET_HEADER_FLAG = 0x0002;
}