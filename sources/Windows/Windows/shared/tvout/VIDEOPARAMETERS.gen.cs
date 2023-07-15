// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tvout.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS"]/*'/>
public unsafe partial struct VIDEOPARAMETERS
{
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.Guid"]/*'/>
    public Guid Guid;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwOffset;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwCommand"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwCommand;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwFlags;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwMode"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwMode;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwTVStandard"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwTVStandard;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwAvailableModes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwAvailableModes;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwAvailableTVStandard"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwAvailableTVStandard;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwFlickerFilter"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwFlickerFilter;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwOverScanX"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwOverScanX;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwOverScanY"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwOverScanY;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwMaxUnscaledX"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwMaxUnscaledX;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwMaxUnscaledY"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwMaxUnscaledY;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwPositionX"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwPositionX;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwPositionY"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwPositionY;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwBrightness"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwBrightness;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwContrast"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwContrast;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwCPType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwCPType;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwCPCommand"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwCPCommand;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwCPStandard"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwCPStandard;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.dwCPKey"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwCPKey;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.bCP_APSTriggerBits"]/*'/>
    [NativeTypeName("ULONG")]
    public uint bCP_APSTriggerBits;
    /// <include file='VIDEOPARAMETERS.xml' path='doc/member[@name="VIDEOPARAMETERS.bOEMCopyProtection"]/*'/>
    [NativeTypeName("UCHAR[256]")]
    public fixed byte bOEMCopyProtection[256];
}