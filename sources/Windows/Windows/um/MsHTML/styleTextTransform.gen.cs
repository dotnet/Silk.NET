// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform"]/*'/>
public enum styleTextTransform
{
    /// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform.styleTextTransformNotSet"]/*'/>
    styleTextTransformNotSet = 0,
    /// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform.styleTextTransformCapitalize"]/*'/>
    styleTextTransformCapitalize = 1,
    /// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform.styleTextTransformLowercase"]/*'/>
    styleTextTransformLowercase = 2,
    /// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform.styleTextTransformUppercase"]/*'/>
    styleTextTransformUppercase = 3,
    /// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform.styleTextTransformNone"]/*'/>
    styleTextTransformNone = 4,
    /// <include file='styleTextTransform.xml' path='doc/member[@name="styleTextTransform.styleTextTransform_Max"]/*'/>
    styleTextTransform_Max = 2147483647,
}