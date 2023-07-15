// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AppPolicyClrCompat.xml' path='doc/member[@name="AppPolicyClrCompat"]/*'/>
public enum AppPolicyClrCompat
{
    /// <include file='AppPolicyClrCompat.xml' path='doc/member[@name="AppPolicyClrCompat.AppPolicyClrCompat_Other"]/*'/>
    AppPolicyClrCompat_Other = 0,
    /// <include file='AppPolicyClrCompat.xml' path='doc/member[@name="AppPolicyClrCompat.AppPolicyClrCompat_ClassicDesktop"]/*'/>
    AppPolicyClrCompat_ClassicDesktop = 1,
    /// <include file='AppPolicyClrCompat.xml' path='doc/member[@name="AppPolicyClrCompat.AppPolicyClrCompat_Universal"]/*'/>
    AppPolicyClrCompat_Universal = 2,
    /// <include file='AppPolicyClrCompat.xml' path='doc/member[@name="AppPolicyClrCompat.AppPolicyClrCompat_PackagedDesktop"]/*'/>
    AppPolicyClrCompat_PackagedDesktop = 3,
}