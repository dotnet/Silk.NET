// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_DUPLICATE_SYMBOL64.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL64"]/*'/>
public unsafe partial struct IMAGEHLP_DUPLICATE_SYMBOL64
{
    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL64.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL64.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL64.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL64.NumberOfDups"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfDups;
    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL64.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL64.Symbol"]/*'/>
    [NativeTypeName("PIMAGEHLP_SYMBOL64")]
    public IMAGEHLP_SYMBOL64* Symbol;
    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL64.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL64.SelectedSymbol"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SelectedSymbol;
}