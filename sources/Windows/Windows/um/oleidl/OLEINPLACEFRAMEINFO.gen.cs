// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLEINPLACEFRAMEINFO.xml' path='doc/member[@name="OLEINPLACEFRAMEINFO"]/*'/>
public partial struct OLEINPLACEFRAMEINFO
{
    /// <include file='OLEINPLACEFRAMEINFO.xml' path='doc/member[@name="OLEINPLACEFRAMEINFO.cb"]/*'/>
    public uint cb;
    /// <include file='OLEINPLACEFRAMEINFO.xml' path='doc/member[@name="OLEINPLACEFRAMEINFO.fMDIApp"]/*'/>
    public BOOL fMDIApp;
    /// <include file='OLEINPLACEFRAMEINFO.xml' path='doc/member[@name="OLEINPLACEFRAMEINFO.hwndFrame"]/*'/>
    public HWND hwndFrame;
    /// <include file='OLEINPLACEFRAMEINFO.xml' path='doc/member[@name="OLEINPLACEFRAMEINFO.haccel"]/*'/>
    public HACCEL haccel;
    /// <include file='OLEINPLACEFRAMEINFO.xml' path='doc/member[@name="OLEINPLACEFRAMEINFO.cAccelEntries"]/*'/>
    public uint cAccelEntries;
}