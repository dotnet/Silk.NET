// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='BINDPTR.xml' path='doc/member[@name="BINDPTR"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct BINDPTR
{
    /// <include file='BINDPTR.xml' path='doc/member[@name="BINDPTR.lpfuncdesc"]/*'/>
    [FieldOffset(0)]
    public FUNCDESC* lpfuncdesc;
    /// <include file='BINDPTR.xml' path='doc/member[@name="BINDPTR.lpvardesc"]/*'/>
    [FieldOffset(0)]
    public VARDESC* lpvardesc;
    /// <include file='BINDPTR.xml' path='doc/member[@name="BINDPTR.lptcomp"]/*'/>
    [FieldOffset(0)]
    public ITypeComp* lptcomp;
}