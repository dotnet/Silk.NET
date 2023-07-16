// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CARET_DIRECTION.xml' path='doc/member[@name="CARET_DIRECTION"]/*'/>
public enum CARET_DIRECTION
{
    /// <include file='CARET_DIRECTION.xml' path='doc/member[@name="CARET_DIRECTION.CARET_DIRECTION_INDETERMINATE"]/*'/>
    CARET_DIRECTION_INDETERMINATE = 0,
    /// <include file='CARET_DIRECTION.xml' path='doc/member[@name="CARET_DIRECTION.CARET_DIRECTION_SAME"]/*'/>
    CARET_DIRECTION_SAME = 1,
    /// <include file='CARET_DIRECTION.xml' path='doc/member[@name="CARET_DIRECTION.CARET_DIRECTION_BACKWARD"]/*'/>
    CARET_DIRECTION_BACKWARD = 2,
    /// <include file='CARET_DIRECTION.xml' path='doc/member[@name="CARET_DIRECTION.CARET_DIRECTION_FORWARD"]/*'/>
    CARET_DIRECTION_FORWARD = 3,
    /// <include file='CARET_DIRECTION.xml' path='doc/member[@name="CARET_DIRECTION.CARET_DIRECTION_Max"]/*'/>
    CARET_DIRECTION_Max = 2147483647,
}