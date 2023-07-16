// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE"]/*'/>
public enum PROPDESC_COLUMNINDEX_TYPE
{
    /// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE.PDCIT_NONE"]/*'/>
    PDCIT_NONE = 0,
    /// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE.PDCIT_ONDISK"]/*'/>
    PDCIT_ONDISK = 1,
    /// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE.PDCIT_INMEMORY"]/*'/>
    PDCIT_INMEMORY = 2,
    /// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE.PDCIT_ONDEMAND"]/*'/>
    PDCIT_ONDEMAND = 3,
    /// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE.PDCIT_ONDISKALL"]/*'/>
    PDCIT_ONDISKALL = 4,
    /// <include file='PROPDESC_COLUMNINDEX_TYPE.xml' path='doc/member[@name="PROPDESC_COLUMNINDEX_TYPE.PDCIT_ONDISKVECTOR"]/*'/>
    PDCIT_ONDISKVECTOR = 5,
}