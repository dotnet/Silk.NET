// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA
{
    [NativeTypeName("DWORD")]
    public uint TaskIndex;

    [NativeTypeName("WCHAR[260]")]
    public _ClassName_e__FixedBuffer ClassName;

    [NativeTypeName("LONG")]
    public int BasePriority;

    [InlineArray(260)]
    public partial struct _ClassName_e__FixedBuffer
    {
        public ushort e0;
    }
}
