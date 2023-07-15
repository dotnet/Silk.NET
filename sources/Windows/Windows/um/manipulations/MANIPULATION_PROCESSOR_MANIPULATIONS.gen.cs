// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS"]/*'/>
[Flags]
public enum MANIPULATION_PROCESSOR_MANIPULATIONS
{
    /// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS.MANIPULATION_NONE"]/*'/>
    MANIPULATION_NONE = 0,
    /// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS.MANIPULATION_TRANSLATE_X"]/*'/>
    MANIPULATION_TRANSLATE_X = 0x1,
    /// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS.MANIPULATION_TRANSLATE_Y"]/*'/>
    MANIPULATION_TRANSLATE_Y = 0x2,
    /// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS.MANIPULATION_SCALE"]/*'/>
    MANIPULATION_SCALE = 0x4,
    /// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS.MANIPULATION_ROTATE"]/*'/>
    MANIPULATION_ROTATE = 0x8,
    /// <include file='MANIPULATION_PROCESSOR_MANIPULATIONS.xml' path='doc/member[@name="MANIPULATION_PROCESSOR_MANIPULATIONS.MANIPULATION_ALL"]/*'/>
    MANIPULATION_ALL = 0xf,
}