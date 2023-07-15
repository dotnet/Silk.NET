// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput"]/*'/>
public unsafe partial struct AMCOPPStatusInput
{
    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.rApp"]/*'/>
    public Guid rApp;
    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.guidStatusRequestID"]/*'/>
    public Guid guidStatusRequestID;
    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.dwSequence"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSequence;
    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.cbSizeData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSizeData;
    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.StatusData"]/*'/>
    [NativeTypeName("BYTE[4056]")]
    public fixed byte StatusData[4056];
}