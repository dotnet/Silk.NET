// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSIPATCHDATATYPE.xml' path='doc/member[@name="MSIPATCHDATATYPE"]/*'/>
public enum MSIPATCHDATATYPE
{
    /// <include file='MSIPATCHDATATYPE.xml' path='doc/member[@name="MSIPATCHDATATYPE.MSIPATCH_DATATYPE_PATCHFILE"]/*'/>
    MSIPATCH_DATATYPE_PATCHFILE = 0,
    /// <include file='MSIPATCHDATATYPE.xml' path='doc/member[@name="MSIPATCHDATATYPE.MSIPATCH_DATATYPE_XMLPATH"]/*'/>
    MSIPATCH_DATATYPE_XMLPATH = 1,
    /// <include file='MSIPATCHDATATYPE.xml' path='doc/member[@name="MSIPATCHDATATYPE.MSIPATCH_DATATYPE_XMLBLOB"]/*'/>
    MSIPATCH_DATATYPE_XMLBLOB = 2,
}