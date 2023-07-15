// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER"]/*'/>
public unsafe partial struct QACONTAINER
{
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pClientSite"]/*'/>
    public IOleClientSite* pClientSite;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pAdviseSink"]/*'/>
    public IAdviseSinkEx* pAdviseSink;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pPropertyNotifySink"]/*'/>
    public IPropertyNotifySink* pPropertyNotifySink;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pUnkEventSink"]/*'/>
    public IUnknown* pUnkEventSink;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.dwAmbientFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAmbientFlags;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.colorFore"]/*'/>
    [NativeTypeName("OLE_COLOR")]
    public uint colorFore;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.colorBack"]/*'/>
    [NativeTypeName("OLE_COLOR")]
    public uint colorBack;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pFont"]/*'/>
    public IFont* pFont;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pUndoMgr"]/*'/>
    public IOleUndoManager* pUndoMgr;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.dwAppearance"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAppearance;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.lcid"]/*'/>
    [NativeTypeName("LONG")]
    public int lcid;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.hpal"]/*'/>
    public HPALETTE hpal;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pBindHost"]/*'/>
    public IBindHost* pBindHost;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pOleControlSite"]/*'/>
    public IOleControlSite* pOleControlSite;
    /// <include file='QACONTAINER.xml' path='doc/member[@name="QACONTAINER.pServiceProvider"]/*'/>
    public IServiceProvider* pServiceProvider;
}