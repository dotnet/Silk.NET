// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERCONTROLDETAILS_UNSIGNED.xml' path='doc/member[@name="MIXERCONTROLDETAILS_UNSIGNED"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS_UNSIGNED
{
    /// <include file='MIXERCONTROLDETAILS_UNSIGNED.xml' path='doc/member[@name="MIXERCONTROLDETAILS_UNSIGNED.dwValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwValue;
}
