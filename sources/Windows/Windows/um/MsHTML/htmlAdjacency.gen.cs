// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlAdjacency.xml' path='doc/member[@name="htmlAdjacency"]/*'/>
public enum htmlAdjacency
{
    /// <include file='htmlAdjacency.xml' path='doc/member[@name="htmlAdjacency.htmlAdjacencyBeforeBegin"]/*'/>
    htmlAdjacencyBeforeBegin = 1,
    /// <include file='htmlAdjacency.xml' path='doc/member[@name="htmlAdjacency.htmlAdjacencyAfterBegin"]/*'/>
    htmlAdjacencyAfterBegin = 2,
    /// <include file='htmlAdjacency.xml' path='doc/member[@name="htmlAdjacency.htmlAdjacencyBeforeEnd"]/*'/>
    htmlAdjacencyBeforeEnd = 3,
    /// <include file='htmlAdjacency.xml' path='doc/member[@name="htmlAdjacency.htmlAdjacencyAfterEnd"]/*'/>
    htmlAdjacencyAfterEnd = 4,
    /// <include file='htmlAdjacency.xml' path='doc/member[@name="htmlAdjacency.htmlAdjacency_Max"]/*'/>
    htmlAdjacency_Max = 2147483647,
}