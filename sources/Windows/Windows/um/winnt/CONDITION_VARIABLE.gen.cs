// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONDITION_VARIABLE.xml' path='doc/member[@name="CONDITION_VARIABLE"]/*' />
public unsafe partial struct CONDITION_VARIABLE
{
    /// <include file='CONDITION_VARIABLE.xml' path='doc/member[@name="CONDITION_VARIABLE.Ptr"]/*' />
    [NativeTypeName("PVOID")]
    public void* Ptr;
}
