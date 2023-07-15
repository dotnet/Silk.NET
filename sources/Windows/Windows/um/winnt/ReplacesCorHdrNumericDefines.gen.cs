// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines"]/*'/>
[Flags]
public enum ReplacesCorHdrNumericDefines
{
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_ILONLY"]/*'/>
    COMIMAGE_FLAGS_ILONLY = 0x00000001,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_32BITREQUIRED"]/*'/>
    COMIMAGE_FLAGS_32BITREQUIRED = 0x00000002,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_IL_LIBRARY"]/*'/>
    COMIMAGE_FLAGS_IL_LIBRARY = 0x00000004,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_STRONGNAMESIGNED"]/*'/>
    COMIMAGE_FLAGS_STRONGNAMESIGNED = 0x00000008,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_NATIVE_ENTRYPOINT"]/*'/>
    COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 0x00000010,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_TRACKDEBUGDATA"]/*'/>
    COMIMAGE_FLAGS_TRACKDEBUGDATA = 0x00010000,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_32BITPREFERRED"]/*'/>
    COMIMAGE_FLAGS_32BITPREFERRED = 0x00020000,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VERSION_MAJOR_V2"]/*'/>
    COR_VERSION_MAJOR_V2 = 2,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VERSION_MAJOR"]/*'/>
    COR_VERSION_MAJOR = COR_VERSION_MAJOR_V2,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VERSION_MINOR"]/*'/>
    COR_VERSION_MINOR = 5,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_DELETED_NAME_LENGTH"]/*'/>
    COR_DELETED_NAME_LENGTH = 8,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLEGAP_NAME_LENGTH"]/*'/>
    COR_VTABLEGAP_NAME_LENGTH = 8,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.NATIVE_TYPE_MAX_CB"]/*'/>
    NATIVE_TYPE_MAX_CB = 1,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE"]/*'/>
    COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 0xFF,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_MIH_METHODRVA"]/*'/>
    IMAGE_COR_MIH_METHODRVA = 0x01,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_MIH_EHRVA"]/*'/>
    IMAGE_COR_MIH_EHRVA = 0x02,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_MIH_BASICBLOCK"]/*'/>
    IMAGE_COR_MIH_BASICBLOCK = 0x08,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_32BIT"]/*'/>
    COR_VTABLE_32BIT = 0x01,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_64BIT"]/*'/>
    COR_VTABLE_64BIT = 0x02,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED"]/*'/>
    COR_VTABLE_FROM_UNMANAGED = 0x04,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN"]/*'/>
    COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 0x08,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_CALL_MOST_DERIVED"]/*'/>
    COR_VTABLE_CALL_MOST_DERIVED = 0x10,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_EATJ_THUNK_SIZE"]/*'/>
    IMAGE_COR_EATJ_THUNK_SIZE = 32,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.MAX_CLASS_NAME"]/*'/>
    MAX_CLASS_NAME = 1024,
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.MAX_PACKAGE_NAME"]/*'/>
    MAX_PACKAGE_NAME = 1024,
}