// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PRIORITY_HINT.xml' path='doc/member[@name="PRIORITY_HINT"]/*'/>
public enum PRIORITY_HINT
{
    /// <include file='PRIORITY_HINT.xml' path='doc/member[@name="PRIORITY_HINT.IoPriorityHintVeryLow"]/*'/>
    IoPriorityHintVeryLow = 0,
    /// <include file='PRIORITY_HINT.xml' path='doc/member[@name="PRIORITY_HINT.IoPriorityHintLow"]/*'/>
    IoPriorityHintLow,
    /// <include file='PRIORITY_HINT.xml' path='doc/member[@name="PRIORITY_HINT.IoPriorityHintNormal"]/*'/>
    IoPriorityHintNormal,
    /// <include file='PRIORITY_HINT.xml' path='doc/member[@name="PRIORITY_HINT.MaximumIoPriorityHintType"]/*'/>
    MaximumIoPriorityHintType,
}