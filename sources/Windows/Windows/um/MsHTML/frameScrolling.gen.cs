// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='frameScrolling.xml' path='doc/member[@name="frameScrolling"]/*'/>
public enum frameScrolling
{
    /// <include file='frameScrolling.xml' path='doc/member[@name="frameScrolling.frameScrollingyes"]/*'/>
    frameScrollingyes = 1,
    /// <include file='frameScrolling.xml' path='doc/member[@name="frameScrolling.frameScrollingno"]/*'/>
    frameScrollingno = 2,
    /// <include file='frameScrolling.xml' path='doc/member[@name="frameScrolling.frameScrollingauto"]/*'/>
    frameScrollingauto = 4,
    /// <include file='frameScrolling.xml' path='doc/member[@name="frameScrolling.frameScrolling_Max"]/*'/>
    frameScrolling_Max = 2147483647,
}