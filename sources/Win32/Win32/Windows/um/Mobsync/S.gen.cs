// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class S
{
    [NativeTypeName(
        "#define S_SYNCMGR_MISSINGITEMS MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0201)"
    )]
    public const int S_SYNCMGR_MISSINGITEMS = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0201)))
    );

    [NativeTypeName("#define S_SYNCMGR_RETRYSYNC MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0202)")]
    public const int S_SYNCMGR_RETRYSYNC = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0202)))
    );

    [NativeTypeName(
        "#define S_SYNCMGR_CANCELITEM MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0203)"
    )]
    public const int S_SYNCMGR_CANCELITEM = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0203)))
    );

    [NativeTypeName("#define S_SYNCMGR_CANCELALL MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0204)")]
    public const int S_SYNCMGR_CANCELALL = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0204)))
    );

    [NativeTypeName(
        "#define S_SYNCMGR_ITEMDELETED MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0210)"
    )]
    public const int S_SYNCMGR_ITEMDELETED = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0210)))
    );

    [NativeTypeName("#define S_SYNCMGR_ENUMITEMS MAKE_SCODE(SEVERITY_SUCCESS,FACILITY_ITF,0x0211)")]
    public const int S_SYNCMGR_ENUMITEMS = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0211)))
    );
}
