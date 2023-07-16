// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Gdiplus;
/// <include file='ConvertToEmfPlusFlags.xml' path='doc/member[@name="ConvertToEmfPlusFlags"]/*'/>
[Flags]
public enum ConvertToEmfPlusFlags
{
    /// <include file='ConvertToEmfPlusFlags.xml' path='doc/member[@name="ConvertToEmfPlusFlags.ConvertToEmfPlusFlagsDefault"]/*'/>
    ConvertToEmfPlusFlagsDefault = 0x00000000,
    /// <include file='ConvertToEmfPlusFlags.xml' path='doc/member[@name="ConvertToEmfPlusFlags.ConvertToEmfPlusFlagsRopUsed"]/*'/>
    ConvertToEmfPlusFlagsRopUsed = 0x00000001,
    /// <include file='ConvertToEmfPlusFlags.xml' path='doc/member[@name="ConvertToEmfPlusFlags.ConvertToEmfPlusFlagsText"]/*'/>
    ConvertToEmfPlusFlagsText = 0x00000002,
    /// <include file='ConvertToEmfPlusFlags.xml' path='doc/member[@name="ConvertToEmfPlusFlags.ConvertToEmfPlusFlagsInvalidRecord"]/*'/>
    ConvertToEmfPlusFlagsInvalidRecord = 0x00000004,
}