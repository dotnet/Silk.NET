// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO"]/*' />
public enum IMAGEHLP_SYMBOL_TYPE_INFO
{
    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_SYMTAG"]/*' />
    TI_GET_SYMTAG,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_SYMNAME"]/*' />
    TI_GET_SYMNAME,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_LENGTH"]/*' />
    TI_GET_LENGTH,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_TYPE"]/*' />
    TI_GET_TYPE,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_TYPEID"]/*' />
    TI_GET_TYPEID,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_BASETYPE"]/*' />
    TI_GET_BASETYPE,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_ARRAYINDEXTYPEID"]/*' />
    TI_GET_ARRAYINDEXTYPEID,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_FINDCHILDREN"]/*' />
    TI_FINDCHILDREN,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_DATAKIND"]/*' />
    TI_GET_DATAKIND,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_ADDRESSOFFSET"]/*' />
    TI_GET_ADDRESSOFFSET,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_OFFSET"]/*' />
    TI_GET_OFFSET,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VALUE"]/*' />
    TI_GET_VALUE,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_COUNT"]/*' />
    TI_GET_COUNT,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_CHILDRENCOUNT"]/*' />
    TI_GET_CHILDRENCOUNT,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_BITPOSITION"]/*' />
    TI_GET_BITPOSITION,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VIRTUALBASECLASS"]/*' />
    TI_GET_VIRTUALBASECLASS,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VIRTUALTABLESHAPEID"]/*' />
    TI_GET_VIRTUALTABLESHAPEID,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VIRTUALBASEPOINTEROFFSET"]/*' />
    TI_GET_VIRTUALBASEPOINTEROFFSET,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_CLASSPARENTID"]/*' />
    TI_GET_CLASSPARENTID,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_NESTED"]/*' />
    TI_GET_NESTED,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_SYMINDEX"]/*' />
    TI_GET_SYMINDEX,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_LEXICALPARENT"]/*' />
    TI_GET_LEXICALPARENT,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_ADDRESS"]/*' />
    TI_GET_ADDRESS,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_THISADJUST"]/*' />
    TI_GET_THISADJUST,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_UDTKIND"]/*' />
    TI_GET_UDTKIND,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_IS_EQUIV_TO"]/*' />
    TI_IS_EQUIV_TO,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_CALLING_CONVENTION"]/*' />
    TI_GET_CALLING_CONVENTION,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_IS_CLOSE_EQUIV_TO"]/*' />
    TI_IS_CLOSE_EQUIV_TO,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GTIEX_REQS_VALID"]/*' />
    TI_GTIEX_REQS_VALID,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VIRTUALBASEOFFSET"]/*' />
    TI_GET_VIRTUALBASEOFFSET,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VIRTUALBASEDISPINDEX"]/*' />
    TI_GET_VIRTUALBASEDISPINDEX,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_IS_REFERENCE"]/*' />
    TI_GET_IS_REFERENCE,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_INDIRECTVIRTUALBASECLASS"]/*' />
    TI_GET_INDIRECTVIRTUALBASECLASS,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_VIRTUALBASETABLETYPE"]/*' />
    TI_GET_VIRTUALBASETABLETYPE,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.TI_GET_OBJECTPOINTERTYPE"]/*' />
    TI_GET_OBJECTPOINTERTYPE,

    /// <include file='IMAGEHLP_SYMBOL_TYPE_INFO.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_TYPE_INFO.IMAGEHLP_SYMBOL_TYPE_INFO_MAX"]/*' />
    IMAGEHLP_SYMBOL_TYPE_INFO_MAX,
}
