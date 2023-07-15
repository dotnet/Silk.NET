// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ELEMENT_ADJACENCY.xml' path='doc/member[@name="ELEMENT_ADJACENCY"]/*'/>
public enum ELEMENT_ADJACENCY
{
    /// <include file='ELEMENT_ADJACENCY.xml' path='doc/member[@name="ELEMENT_ADJACENCY.ELEM_ADJ_BeforeBegin"]/*'/>
    ELEM_ADJ_BeforeBegin = 0,
    /// <include file='ELEMENT_ADJACENCY.xml' path='doc/member[@name="ELEMENT_ADJACENCY.ELEM_ADJ_AfterBegin"]/*'/>
    ELEM_ADJ_AfterBegin = 1,
    /// <include file='ELEMENT_ADJACENCY.xml' path='doc/member[@name="ELEMENT_ADJACENCY.ELEM_ADJ_BeforeEnd"]/*'/>
    ELEM_ADJ_BeforeEnd = 2,
    /// <include file='ELEMENT_ADJACENCY.xml' path='doc/member[@name="ELEMENT_ADJACENCY.ELEM_ADJ_AfterEnd"]/*'/>
    ELEM_ADJ_AfterEnd = 3,
    /// <include file='ELEMENT_ADJACENCY.xml' path='doc/member[@name="ELEMENT_ADJACENCY.ELEMENT_ADJACENCY_Max"]/*'/>
    ELEMENT_ADJACENCY_Max = 2147483647,
}