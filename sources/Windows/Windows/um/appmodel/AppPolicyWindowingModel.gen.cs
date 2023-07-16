// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AppPolicyWindowingModel.xml' path='doc/member[@name="AppPolicyWindowingModel"]/*'/>
public enum AppPolicyWindowingModel
{
    /// <include file='AppPolicyWindowingModel.xml' path='doc/member[@name="AppPolicyWindowingModel.AppPolicyWindowingModel_None"]/*'/>
    AppPolicyWindowingModel_None = 0,
    /// <include file='AppPolicyWindowingModel.xml' path='doc/member[@name="AppPolicyWindowingModel.AppPolicyWindowingModel_Universal"]/*'/>
    AppPolicyWindowingModel_Universal = 1,
    /// <include file='AppPolicyWindowingModel.xml' path='doc/member[@name="AppPolicyWindowingModel.AppPolicyWindowingModel_ClassicDesktop"]/*'/>
    AppPolicyWindowingModel_ClassicDesktop = 2,
    /// <include file='AppPolicyWindowingModel.xml' path='doc/member[@name="AppPolicyWindowingModel.AppPolicyWindowingModel_ClassicPhone"]/*'/>
    AppPolicyWindowingModel_ClassicPhone = 3,
}