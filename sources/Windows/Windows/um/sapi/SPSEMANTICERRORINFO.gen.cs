// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPSEMANTICERRORINFO.xml' path='doc/member[@name="SPSEMANTICERRORINFO"]/*'/>
public unsafe partial struct SPSEMANTICERRORINFO
{
    /// <include file='SPSEMANTICERRORINFO.xml' path='doc/member[@name="SPSEMANTICERRORINFO.ulLineNumber"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulLineNumber;
    /// <include file='SPSEMANTICERRORINFO.xml' path='doc/member[@name="SPSEMANTICERRORINFO.pszScriptLine"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszScriptLine;
    /// <include file='SPSEMANTICERRORINFO.xml' path='doc/member[@name="SPSEMANTICERRORINFO.pszSource"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszSource;
    /// <include file='SPSEMANTICERRORINFO.xml' path='doc/member[@name="SPSEMANTICERRORINFO.pszDescription"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszDescription;
    /// <include file='SPSEMANTICERRORINFO.xml' path='doc/member[@name="SPSEMANTICERRORINFO.hrResultCode"]/*'/>
    public HRESULT hrResultCode;
}