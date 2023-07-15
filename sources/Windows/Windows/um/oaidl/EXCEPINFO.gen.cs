// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO"]/*'/>
public unsafe partial struct EXCEPINFO
{
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.wCode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wCode;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.wReserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.bstrSource"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* bstrSource;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.bstrDescription"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* bstrDescription;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.bstrHelpFile"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* bstrHelpFile;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.dwHelpContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHelpContext;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.pvReserved"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pvReserved;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.pfnDeferredFillIn"]/*'/>
    [NativeTypeName("HRESULT (*)(struct tagEXCEPINFO *) __attribute__((stdcall))")]
    public delegate* unmanaged<EXCEPINFO*, HRESULT> pfnDeferredFillIn;
    /// <include file='EXCEPINFO.xml' path='doc/member[@name="EXCEPINFO.scode"]/*'/>
    [NativeTypeName("SCODE")]
    public int scode;
}