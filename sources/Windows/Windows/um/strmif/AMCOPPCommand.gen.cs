// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand"]/*'/>
public unsafe partial struct AMCOPPCommand
{
    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.macKDI"]/*'/>
    public Guid macKDI;
    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.guidCommandID"]/*'/>
    public Guid guidCommandID;
    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.dwSequence"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSequence;
    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.cbSizeData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSizeData;
    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.CommandData"]/*'/>
    [NativeTypeName("BYTE[4056]")]
    public fixed byte CommandData[4056];
}