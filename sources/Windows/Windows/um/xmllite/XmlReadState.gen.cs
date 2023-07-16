// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='XmlReadState.xml' path='doc/member[@name="XmlReadState"]/*'/>
public enum XmlReadState
{
    /// <include file='XmlReadState.xml' path='doc/member[@name="XmlReadState.XmlReadState_Initial"]/*'/>
    XmlReadState_Initial = 0,
    /// <include file='XmlReadState.xml' path='doc/member[@name="XmlReadState.XmlReadState_Interactive"]/*'/>
    XmlReadState_Interactive = 1,
    /// <include file='XmlReadState.xml' path='doc/member[@name="XmlReadState.XmlReadState_Error"]/*'/>
    XmlReadState_Error = 2,
    /// <include file='XmlReadState.xml' path='doc/member[@name="XmlReadState.XmlReadState_EndOfFile"]/*'/>
    XmlReadState_EndOfFile = 3,
    /// <include file='XmlReadState.xml' path='doc/member[@name="XmlReadState.XmlReadState_Closed"]/*'/>
    XmlReadState_Closed = 4,
}