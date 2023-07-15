// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SecHandle.xml' path='doc/member[@name="SecHandle"]/*'/>
public partial struct SecHandle
{
    /// <include file='SecHandle.xml' path='doc/member[@name="SecHandle.dwLower"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwLower;
    /// <include file='SecHandle.xml' path='doc/member[@name="SecHandle.dwUpper"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwUpper;
}