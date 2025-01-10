// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    public static void PropVariantInit(PROPVARIANT* pvar)
    {
        NativeMemory.Fill(pvar, (uint)(sizeof(PROPVARIANT)), 0);
    }

    [DllImport("ole32", ExactSpelling = true)]
    public static extern SERIALIZEDPROPERTYVALUE* StgConvertVariantToProperty(
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvar,
        ushort CodePage,
        SERIALIZEDPROPERTYVALUE* pprop,
        [NativeTypeName("ULONG *")] uint* pcb,
        [NativeTypeName("PROPID")] uint pid,
        [NativeTypeName("BOOLEAN")] byte fReserved,
        [NativeTypeName("ULONG *")] uint* pcIndirect
    );

    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte StgConvertPropertyToVariant(
        [NativeTypeName("const SERIALIZEDPROPERTYVALUE *")] SERIALIZEDPROPERTYVALUE* pprop,
        ushort CodePage,
        PROPVARIANT* pvar,
        [NativeTypeName("PMemoryAllocator*")] void* pma
    );

    [NativeTypeName("#define PIDDI_THUMBNAIL 0x00000002L")]
    public const int PIDDI_THUMBNAIL = 0x00000002;

    [NativeTypeName("#define PIDSI_TITLE 0x00000002L")]
    public const int PIDSI_TITLE = 0x00000002;

    [NativeTypeName("#define PIDSI_SUBJECT 0x00000003L")]
    public const int PIDSI_SUBJECT = 0x00000003;

    [NativeTypeName("#define PIDSI_AUTHOR 0x00000004L")]
    public const int PIDSI_AUTHOR = 0x00000004;

    [NativeTypeName("#define PIDSI_KEYWORDS 0x00000005L")]
    public const int PIDSI_KEYWORDS = 0x00000005;

    [NativeTypeName("#define PIDSI_COMMENTS 0x00000006L")]
    public const int PIDSI_COMMENTS = 0x00000006;

    [NativeTypeName("#define PIDSI_TEMPLATE 0x00000007L")]
    public const int PIDSI_TEMPLATE = 0x00000007;

    [NativeTypeName("#define PIDSI_LASTAUTHOR 0x00000008L")]
    public const int PIDSI_LASTAUTHOR = 0x00000008;

    [NativeTypeName("#define PIDSI_REVNUMBER 0x00000009L")]
    public const int PIDSI_REVNUMBER = 0x00000009;

    [NativeTypeName("#define PIDSI_EDITTIME 0x0000000aL")]
    public const int PIDSI_EDITTIME = 0x0000000a;

    [NativeTypeName("#define PIDSI_LASTPRINTED 0x0000000bL")]
    public const int PIDSI_LASTPRINTED = 0x0000000b;

    [NativeTypeName("#define PIDSI_CREATE_DTM 0x0000000cL")]
    public const int PIDSI_CREATE_DTM = 0x0000000c;

    [NativeTypeName("#define PIDSI_LASTSAVE_DTM 0x0000000dL")]
    public const int PIDSI_LASTSAVE_DTM = 0x0000000d;

    [NativeTypeName("#define PIDSI_PAGECOUNT 0x0000000eL")]
    public const int PIDSI_PAGECOUNT = 0x0000000e;

    [NativeTypeName("#define PIDSI_WORDCOUNT 0x0000000fL")]
    public const int PIDSI_WORDCOUNT = 0x0000000f;

    [NativeTypeName("#define PIDSI_CHARCOUNT 0x00000010L")]
    public const int PIDSI_CHARCOUNT = 0x00000010;

    [NativeTypeName("#define PIDSI_THUMBNAIL 0x00000011L")]
    public const int PIDSI_THUMBNAIL = 0x00000011;

    [NativeTypeName("#define PIDSI_APPNAME 0x00000012L")]
    public const int PIDSI_APPNAME = 0x00000012;

    [NativeTypeName("#define PIDSI_DOC_SECURITY 0x00000013L")]
    public const int PIDSI_DOC_SECURITY = 0x00000013;

    [NativeTypeName("#define PIDDSI_CATEGORY 0x00000002")]
    public const int PIDDSI_CATEGORY = 0x00000002;

    [NativeTypeName("#define PIDDSI_PRESFORMAT 0x00000003")]
    public const int PIDDSI_PRESFORMAT = 0x00000003;

    [NativeTypeName("#define PIDDSI_BYTECOUNT 0x00000004")]
    public const int PIDDSI_BYTECOUNT = 0x00000004;

    [NativeTypeName("#define PIDDSI_LINECOUNT 0x00000005")]
    public const int PIDDSI_LINECOUNT = 0x00000005;

    [NativeTypeName("#define PIDDSI_PARCOUNT 0x00000006")]
    public const int PIDDSI_PARCOUNT = 0x00000006;

    [NativeTypeName("#define PIDDSI_SLIDECOUNT 0x00000007")]
    public const int PIDDSI_SLIDECOUNT = 0x00000007;

    [NativeTypeName("#define PIDDSI_NOTECOUNT 0x00000008")]
    public const int PIDDSI_NOTECOUNT = 0x00000008;

    [NativeTypeName("#define PIDDSI_HIDDENCOUNT 0x00000009")]
    public const int PIDDSI_HIDDENCOUNT = 0x00000009;

    [NativeTypeName("#define PIDDSI_MMCLIPCOUNT 0x0000000A")]
    public const int PIDDSI_MMCLIPCOUNT = 0x0000000A;

    [NativeTypeName("#define PIDDSI_SCALE 0x0000000B")]
    public const int PIDDSI_SCALE = 0x0000000B;

    [NativeTypeName("#define PIDDSI_HEADINGPAIR 0x0000000C")]
    public const int PIDDSI_HEADINGPAIR = 0x0000000C;

    [NativeTypeName("#define PIDDSI_DOCPARTS 0x0000000D")]
    public const int PIDDSI_DOCPARTS = 0x0000000D;

    [NativeTypeName("#define PIDDSI_MANAGER 0x0000000E")]
    public const int PIDDSI_MANAGER = 0x0000000E;

    [NativeTypeName("#define PIDDSI_COMPANY 0x0000000F")]
    public const int PIDDSI_COMPANY = 0x0000000F;

    [NativeTypeName("#define PIDDSI_LINKSDIRTY 0x00000010")]
    public const int PIDDSI_LINKSDIRTY = 0x00000010;

    [NativeTypeName("#define PIDMSI_EDITOR 0x00000002L")]
    public const int PIDMSI_EDITOR = 0x00000002;

    [NativeTypeName("#define PIDMSI_SUPPLIER 0x00000003L")]
    public const int PIDMSI_SUPPLIER = 0x00000003;

    [NativeTypeName("#define PIDMSI_SOURCE 0x00000004L")]
    public const int PIDMSI_SOURCE = 0x00000004;

    [NativeTypeName("#define PIDMSI_SEQUENCE_NO 0x00000005L")]
    public const int PIDMSI_SEQUENCE_NO = 0x00000005;

    [NativeTypeName("#define PIDMSI_PROJECT 0x00000006L")]
    public const int PIDMSI_PROJECT = 0x00000006;

    [NativeTypeName("#define PIDMSI_STATUS 0x00000007L")]
    public const int PIDMSI_STATUS = 0x00000007;

    [NativeTypeName("#define PIDMSI_OWNER 0x00000008L")]
    public const int PIDMSI_OWNER = 0x00000008;

    [NativeTypeName("#define PIDMSI_RATING 0x00000009L")]
    public const int PIDMSI_RATING = 0x00000009;

    [NativeTypeName("#define PIDMSI_PRODUCTION 0x0000000AL")]
    public const int PIDMSI_PRODUCTION = 0x0000000A;

    [NativeTypeName("#define PIDMSI_COPYRIGHT 0x0000000BL")]
    public const int PIDMSI_COPYRIGHT = 0x0000000B;
}
