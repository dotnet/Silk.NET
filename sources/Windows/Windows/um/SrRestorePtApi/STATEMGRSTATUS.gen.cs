// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='STATEMGRSTATUS.xml' path='doc/member[@name="STATEMGRSTATUS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct STATEMGRSTATUS
{
    /// <include file='STATEMGRSTATUS.xml' path='doc/member[@name="STATEMGRSTATUS.nStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nStatus;
    /// <include file='STATEMGRSTATUS.xml' path='doc/member[@name="STATEMGRSTATUS.llSequenceNumber"]/*'/>
    [NativeTypeName("INT64")]
    public long llSequenceNumber;
}