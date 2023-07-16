// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class STG
{
    [NativeTypeName("#define STG_E_INVALIDFUNCTION _HRESULT_TYPEDEF_(0x80030001L)")]
    public const int STG_E_INVALIDFUNCTION = unchecked((int)(0x80030001));
    [NativeTypeName("#define STG_E_FILENOTFOUND _HRESULT_TYPEDEF_(0x80030002L)")]
    public const int STG_E_FILENOTFOUND = unchecked((int)(0x80030002));
    [NativeTypeName("#define STG_E_PATHNOTFOUND _HRESULT_TYPEDEF_(0x80030003L)")]
    public const int STG_E_PATHNOTFOUND = unchecked((int)(0x80030003));
    [NativeTypeName("#define STG_E_TOOMANYOPENFILES _HRESULT_TYPEDEF_(0x80030004L)")]
    public const int STG_E_TOOMANYOPENFILES = unchecked((int)(0x80030004));
    [NativeTypeName("#define STG_E_ACCESSDENIED _HRESULT_TYPEDEF_(0x80030005L)")]
    public const int STG_E_ACCESSDENIED = unchecked((int)(0x80030005));
    [NativeTypeName("#define STG_E_INVALIDHANDLE _HRESULT_TYPEDEF_(0x80030006L)")]
    public const int STG_E_INVALIDHANDLE = unchecked((int)(0x80030006));
    [NativeTypeName("#define STG_E_INSUFFICIENTMEMORY _HRESULT_TYPEDEF_(0x80030008L)")]
    public const int STG_E_INSUFFICIENTMEMORY = unchecked((int)(0x80030008));
    [NativeTypeName("#define STG_E_INVALIDPOINTER _HRESULT_TYPEDEF_(0x80030009L)")]
    public const int STG_E_INVALIDPOINTER = unchecked((int)(0x80030009));
    [NativeTypeName("#define STG_E_NOMOREFILES _HRESULT_TYPEDEF_(0x80030012L)")]
    public const int STG_E_NOMOREFILES = unchecked((int)(0x80030012));
    [NativeTypeName("#define STG_E_DISKISWRITEPROTECTED _HRESULT_TYPEDEF_(0x80030013L)")]
    public const int STG_E_DISKISWRITEPROTECTED = unchecked((int)(0x80030013));
    [NativeTypeName("#define STG_E_SEEKERROR _HRESULT_TYPEDEF_(0x80030019L)")]
    public const int STG_E_SEEKERROR = unchecked((int)(0x80030019));
    [NativeTypeName("#define STG_E_WRITEFAULT _HRESULT_TYPEDEF_(0x8003001DL)")]
    public const int STG_E_WRITEFAULT = unchecked((int)(0x8003001D));
    [NativeTypeName("#define STG_E_READFAULT _HRESULT_TYPEDEF_(0x8003001EL)")]
    public const int STG_E_READFAULT = unchecked((int)(0x8003001E));
    [NativeTypeName("#define STG_E_SHAREVIOLATION _HRESULT_TYPEDEF_(0x80030020L)")]
    public const int STG_E_SHAREVIOLATION = unchecked((int)(0x80030020));
    [NativeTypeName("#define STG_E_LOCKVIOLATION _HRESULT_TYPEDEF_(0x80030021L)")]
    public const int STG_E_LOCKVIOLATION = unchecked((int)(0x80030021));
    [NativeTypeName("#define STG_E_FILEALREADYEXISTS _HRESULT_TYPEDEF_(0x80030050L)")]
    public const int STG_E_FILEALREADYEXISTS = unchecked((int)(0x80030050));
    [NativeTypeName("#define STG_E_INVALIDPARAMETER _HRESULT_TYPEDEF_(0x80030057L)")]
    public const int STG_E_INVALIDPARAMETER = unchecked((int)(0x80030057));
    [NativeTypeName("#define STG_E_MEDIUMFULL _HRESULT_TYPEDEF_(0x80030070L)")]
    public const int STG_E_MEDIUMFULL = unchecked((int)(0x80030070));
    [NativeTypeName("#define STG_E_PROPSETMISMATCHED _HRESULT_TYPEDEF_(0x800300F0L)")]
    public const int STG_E_PROPSETMISMATCHED = unchecked((int)(0x800300F0));
    [NativeTypeName("#define STG_E_ABNORMALAPIEXIT _HRESULT_TYPEDEF_(0x800300FAL)")]
    public const int STG_E_ABNORMALAPIEXIT = unchecked((int)(0x800300FA));
    [NativeTypeName("#define STG_E_INVALIDHEADER _HRESULT_TYPEDEF_(0x800300FBL)")]
    public const int STG_E_INVALIDHEADER = unchecked((int)(0x800300FB));
    [NativeTypeName("#define STG_E_INVALIDNAME _HRESULT_TYPEDEF_(0x800300FCL)")]
    public const int STG_E_INVALIDNAME = unchecked((int)(0x800300FC));
    [NativeTypeName("#define STG_E_UNKNOWN _HRESULT_TYPEDEF_(0x800300FDL)")]
    public const int STG_E_UNKNOWN = unchecked((int)(0x800300FD));
    [NativeTypeName("#define STG_E_UNIMPLEMENTEDFUNCTION _HRESULT_TYPEDEF_(0x800300FEL)")]
    public const int STG_E_UNIMPLEMENTEDFUNCTION = unchecked((int)(0x800300FE));
    [NativeTypeName("#define STG_E_INVALIDFLAG _HRESULT_TYPEDEF_(0x800300FFL)")]
    public const int STG_E_INVALIDFLAG = unchecked((int)(0x800300FF));
    [NativeTypeName("#define STG_E_INUSE _HRESULT_TYPEDEF_(0x80030100L)")]
    public const int STG_E_INUSE = unchecked((int)(0x80030100));
    [NativeTypeName("#define STG_E_NOTCURRENT _HRESULT_TYPEDEF_(0x80030101L)")]
    public const int STG_E_NOTCURRENT = unchecked((int)(0x80030101));
    [NativeTypeName("#define STG_E_REVERTED _HRESULT_TYPEDEF_(0x80030102L)")]
    public const int STG_E_REVERTED = unchecked((int)(0x80030102));
    [NativeTypeName("#define STG_E_CANTSAVE _HRESULT_TYPEDEF_(0x80030103L)")]
    public const int STG_E_CANTSAVE = unchecked((int)(0x80030103));
    [NativeTypeName("#define STG_E_OLDFORMAT _HRESULT_TYPEDEF_(0x80030104L)")]
    public const int STG_E_OLDFORMAT = unchecked((int)(0x80030104));
    [NativeTypeName("#define STG_E_OLDDLL _HRESULT_TYPEDEF_(0x80030105L)")]
    public const int STG_E_OLDDLL = unchecked((int)(0x80030105));
    [NativeTypeName("#define STG_E_SHAREREQUIRED _HRESULT_TYPEDEF_(0x80030106L)")]
    public const int STG_E_SHAREREQUIRED = unchecked((int)(0x80030106));
    [NativeTypeName("#define STG_E_NOTFILEBASEDSTORAGE _HRESULT_TYPEDEF_(0x80030107L)")]
    public const int STG_E_NOTFILEBASEDSTORAGE = unchecked((int)(0x80030107));
    [NativeTypeName("#define STG_E_EXTANTMARSHALLINGS _HRESULT_TYPEDEF_(0x80030108L)")]
    public const int STG_E_EXTANTMARSHALLINGS = unchecked((int)(0x80030108));
    [NativeTypeName("#define STG_E_DOCFILECORRUPT _HRESULT_TYPEDEF_(0x80030109L)")]
    public const int STG_E_DOCFILECORRUPT = unchecked((int)(0x80030109));
    [NativeTypeName("#define STG_E_BADBASEADDRESS _HRESULT_TYPEDEF_(0x80030110L)")]
    public const int STG_E_BADBASEADDRESS = unchecked((int)(0x80030110));
    [NativeTypeName("#define STG_E_DOCFILETOOLARGE _HRESULT_TYPEDEF_(0x80030111L)")]
    public const int STG_E_DOCFILETOOLARGE = unchecked((int)(0x80030111));
    [NativeTypeName("#define STG_E_NOTSIMPLEFORMAT _HRESULT_TYPEDEF_(0x80030112L)")]
    public const int STG_E_NOTSIMPLEFORMAT = unchecked((int)(0x80030112));
    [NativeTypeName("#define STG_E_INCOMPLETE _HRESULT_TYPEDEF_(0x80030201L)")]
    public const int STG_E_INCOMPLETE = unchecked((int)(0x80030201));
    [NativeTypeName("#define STG_E_TERMINATED _HRESULT_TYPEDEF_(0x80030202L)")]
    public const int STG_E_TERMINATED = unchecked((int)(0x80030202));
    [NativeTypeName("#define STG_S_CONVERTED _HRESULT_TYPEDEF_(0x00030200L)")]
    public const int STG_S_CONVERTED = ((int)(0x00030200));
    [NativeTypeName("#define STG_S_BLOCK _HRESULT_TYPEDEF_(0x00030201L)")]
    public const int STG_S_BLOCK = ((int)(0x00030201));
    [NativeTypeName("#define STG_S_RETRYNOW _HRESULT_TYPEDEF_(0x00030202L)")]
    public const int STG_S_RETRYNOW = ((int)(0x00030202));
    [NativeTypeName("#define STG_S_MONITORING _HRESULT_TYPEDEF_(0x00030203L)")]
    public const int STG_S_MONITORING = ((int)(0x00030203));
    [NativeTypeName("#define STG_S_MULTIPLEOPENS _HRESULT_TYPEDEF_(0x00030204L)")]
    public const int STG_S_MULTIPLEOPENS = ((int)(0x00030204));
    [NativeTypeName("#define STG_S_CONSOLIDATIONFAILED _HRESULT_TYPEDEF_(0x00030205L)")]
    public const int STG_S_CONSOLIDATIONFAILED = ((int)(0x00030205));
    [NativeTypeName("#define STG_S_CANNOTCONSOLIDATE _HRESULT_TYPEDEF_(0x00030206L)")]
    public const int STG_S_CANNOTCONSOLIDATE = ((int)(0x00030206));
    [NativeTypeName("#define STG_S_POWER_CYCLE_REQUIRED _HRESULT_TYPEDEF_(0x00030207L)")]
    public const int STG_S_POWER_CYCLE_REQUIRED = ((int)(0x00030207));
    [NativeTypeName("#define STG_E_FIRMWARE_SLOT_INVALID _HRESULT_TYPEDEF_(0x80030208L)")]
    public const int STG_E_FIRMWARE_SLOT_INVALID = unchecked((int)(0x80030208));
    [NativeTypeName("#define STG_E_FIRMWARE_IMAGE_INVALID _HRESULT_TYPEDEF_(0x80030209L)")]
    public const int STG_E_FIRMWARE_IMAGE_INVALID = unchecked((int)(0x80030209));
    [NativeTypeName("#define STG_E_DEVICE_UNRESPONSIVE _HRESULT_TYPEDEF_(0x8003020AL)")]
    public const int STG_E_DEVICE_UNRESPONSIVE = unchecked((int)(0x8003020A));
    [NativeTypeName("#define STG_E_STATUS_COPY_PROTECTION_FAILURE _HRESULT_TYPEDEF_(0x80030305L)")]
    public const int STG_E_STATUS_COPY_PROTECTION_FAILURE = unchecked((int)(0x80030305));
    [NativeTypeName("#define STG_E_CSS_AUTHENTICATION_FAILURE _HRESULT_TYPEDEF_(0x80030306L)")]
    public const int STG_E_CSS_AUTHENTICATION_FAILURE = unchecked((int)(0x80030306));
    [NativeTypeName("#define STG_E_CSS_KEY_NOT_PRESENT _HRESULT_TYPEDEF_(0x80030307L)")]
    public const int STG_E_CSS_KEY_NOT_PRESENT = unchecked((int)(0x80030307));
    [NativeTypeName("#define STG_E_CSS_KEY_NOT_ESTABLISHED _HRESULT_TYPEDEF_(0x80030308L)")]
    public const int STG_E_CSS_KEY_NOT_ESTABLISHED = unchecked((int)(0x80030308));
    [NativeTypeName("#define STG_E_CSS_SCRAMBLED_SECTOR _HRESULT_TYPEDEF_(0x80030309L)")]
    public const int STG_E_CSS_SCRAMBLED_SECTOR = unchecked((int)(0x80030309));
    [NativeTypeName("#define STG_E_CSS_REGION_MISMATCH _HRESULT_TYPEDEF_(0x8003030AL)")]
    public const int STG_E_CSS_REGION_MISMATCH = unchecked((int)(0x8003030A));
    [NativeTypeName("#define STG_E_RESETS_EXHAUSTED _HRESULT_TYPEDEF_(0x8003030BL)")]
    public const int STG_E_RESETS_EXHAUSTED = unchecked((int)(0x8003030B));
}