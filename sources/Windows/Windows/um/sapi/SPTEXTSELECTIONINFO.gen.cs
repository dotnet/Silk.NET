// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPTEXTSELECTIONINFO.xml' path='doc/member[@name="SPTEXTSELECTIONINFO"]/*'/>
public partial struct SPTEXTSELECTIONINFO
{
    /// <include file='SPTEXTSELECTIONINFO.xml' path='doc/member[@name="SPTEXTSELECTIONINFO.ulStartActiveOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulStartActiveOffset;
    /// <include file='SPTEXTSELECTIONINFO.xml' path='doc/member[@name="SPTEXTSELECTIONINFO.cchActiveChars"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cchActiveChars;
    /// <include file='SPTEXTSELECTIONINFO.xml' path='doc/member[@name="SPTEXTSELECTIONINFO.ulStartSelection"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulStartSelection;
    /// <include file='SPTEXTSELECTIONINFO.xml' path='doc/member[@name="SPTEXTSELECTIONINFO.cchSelection"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cchSelection;
}