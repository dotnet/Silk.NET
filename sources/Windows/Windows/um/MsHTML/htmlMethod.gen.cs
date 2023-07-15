// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlMethod.xml' path='doc/member[@name="htmlMethod"]/*'/>
public enum htmlMethod
{
    /// <include file='htmlMethod.xml' path='doc/member[@name="htmlMethod.htmlMethodNotSet"]/*'/>
    htmlMethodNotSet = 0,
    /// <include file='htmlMethod.xml' path='doc/member[@name="htmlMethod.htmlMethodGet"]/*'/>
    htmlMethodGet = 1,
    /// <include file='htmlMethod.xml' path='doc/member[@name="htmlMethod.htmlMethodPost"]/*'/>
    htmlMethodPost = 2,
    /// <include file='htmlMethod.xml' path='doc/member[@name="htmlMethod.htmlMethod_Max"]/*'/>
    htmlMethod_Max = 2147483647,
}