// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_DEVINFO_LIST_DETAIL_DATA_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public Guid ClassGuid;
    public HANDLE RemoteMachineHandle;

    [NativeTypeName("WCHAR[263]")]
    public _RemoteMachineName_e__FixedBuffer RemoteMachineName;

    [InlineArray(263)]
    public partial struct _RemoteMachineName_e__FixedBuffer
    {
        public ushort e0;
    }
}
