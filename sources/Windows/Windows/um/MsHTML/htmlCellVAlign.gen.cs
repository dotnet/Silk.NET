// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign"]/*'/>
public enum htmlCellVAlign
{
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlignNotSet"]/*'/>
    htmlCellVAlignNotSet = 0,
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlignTop"]/*'/>
    htmlCellVAlignTop = 1,
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlignMiddle"]/*'/>
    htmlCellVAlignMiddle = 2,
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlignBottom"]/*'/>
    htmlCellVAlignBottom = 3,
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlignBaseline"]/*'/>
    htmlCellVAlignBaseline = 4,
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlignCenter"]/*'/>
    htmlCellVAlignCenter = htmlCellVAlignMiddle,
    /// <include file='htmlCellVAlign.xml' path='doc/member[@name="htmlCellVAlign.htmlCellVAlign_Max"]/*'/>
    htmlCellVAlign_Max = 2147483647,
}