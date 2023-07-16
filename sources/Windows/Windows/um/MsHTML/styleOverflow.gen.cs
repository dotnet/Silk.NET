// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow"]/*'/>
public enum styleOverflow
{
    /// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow.styleOverflowNotSet"]/*'/>
    styleOverflowNotSet = 0,
    /// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow.styleOverflowAuto"]/*'/>
    styleOverflowAuto = 1,
    /// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow.styleOverflowHidden"]/*'/>
    styleOverflowHidden = 2,
    /// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow.styleOverflowVisible"]/*'/>
    styleOverflowVisible = 3,
    /// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow.styleOverflowScroll"]/*'/>
    styleOverflowScroll = 4,
    /// <include file='styleOverflow.xml' path='doc/member[@name="styleOverflow.styleOverflow_Max"]/*'/>
    styleOverflow_Max = 2147483647,
}