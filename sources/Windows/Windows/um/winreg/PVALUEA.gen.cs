// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PVALUEA.xml' path='doc/member[@name="PVALUEA"]/*' />
public unsafe partial struct PVALUEA
{
    /// <include file='PVALUEA.xml' path='doc/member[@name="PVALUEA.pv_valuename"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pv_valuename;

    /// <include file='PVALUEA.xml' path='doc/member[@name="PVALUEA.pv_valuelen"]/*' />
    public int pv_valuelen;

    /// <include file='PVALUEA.xml' path='doc/member[@name="PVALUEA.pv_value_context"]/*' />
    [NativeTypeName("LPVOID")]
    public void* pv_value_context;

    /// <include file='PVALUEA.xml' path='doc/member[@name="PVALUEA.pv_type"]/*' />
    [NativeTypeName("DWORD")]
    public uint pv_type;
}
