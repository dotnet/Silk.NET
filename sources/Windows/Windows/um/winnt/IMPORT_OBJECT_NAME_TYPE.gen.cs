// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMPORT_OBJECT_NAME_TYPE.xml' path='doc/member[@name="IMPORT_OBJECT_NAME_TYPE"]/*'/>
public enum IMPORT_OBJECT_NAME_TYPE
{
    /// <include file='IMPORT_OBJECT_NAME_TYPE.xml' path='doc/member[@name="IMPORT_OBJECT_NAME_TYPE.IMPORT_OBJECT_ORDINAL"]/*'/>
    IMPORT_OBJECT_ORDINAL = 0,
    /// <include file='IMPORT_OBJECT_NAME_TYPE.xml' path='doc/member[@name="IMPORT_OBJECT_NAME_TYPE.IMPORT_OBJECT_NAME"]/*'/>
    IMPORT_OBJECT_NAME = 1,
    /// <include file='IMPORT_OBJECT_NAME_TYPE.xml' path='doc/member[@name="IMPORT_OBJECT_NAME_TYPE.IMPORT_OBJECT_NAME_NO_PREFIX"]/*'/>
    IMPORT_OBJECT_NAME_NO_PREFIX = 2,
    /// <include file='IMPORT_OBJECT_NAME_TYPE.xml' path='doc/member[@name="IMPORT_OBJECT_NAME_TYPE.IMPORT_OBJECT_NAME_UNDECORATE"]/*'/>
    IMPORT_OBJECT_NAME_UNDECORATE = 3,
    /// <include file='IMPORT_OBJECT_NAME_TYPE.xml' path='doc/member[@name="IMPORT_OBJECT_NAME_TYPE.IMPORT_OBJECT_NAME_EXPORTAS"]/*'/>
    IMPORT_OBJECT_NAME_EXPORTAS = 4,
}