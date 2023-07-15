// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC"]/*'/>
public unsafe partial struct FUNCDESC
{
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.memid"]/*'/>
    [NativeTypeName("MEMBERID")]
    public int memid;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.lprgscode"]/*'/>
    [NativeTypeName("SCODE *")]
    public int* lprgscode;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.lprgelemdescParam"]/*'/>
    public ELEMDESC* lprgelemdescParam;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.funckind"]/*'/>
    public FUNCKIND funckind;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.invkind"]/*'/>
    public INVOKEKIND invkind;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.callconv"]/*'/>
    public CALLCONV callconv;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.cParams"]/*'/>
    public short cParams;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.cParamsOpt"]/*'/>
    public short cParamsOpt;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.oVft"]/*'/>
    public short oVft;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.cScodes"]/*'/>
    public short cScodes;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.elemdescFunc"]/*'/>
    public ELEMDESC elemdescFunc;
    /// <include file='FUNCDESC.xml' path='doc/member[@name="FUNCDESC.wFuncFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wFuncFlags;
}