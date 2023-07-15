// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO"]/*'/>
public unsafe partial struct PIN_INFO
{
    /// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO.pFilter"]/*'/>
    public IBaseFilter* pFilter;
    /// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO.dir"]/*'/>
    public PIN_DIRECTION dir;
    /// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO.achName"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort achName[128];
}