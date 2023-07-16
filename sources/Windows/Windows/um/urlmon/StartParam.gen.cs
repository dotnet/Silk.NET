// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='StartParam.xml' path='doc/member[@name="StartParam"]/*'/>
public unsafe partial struct StartParam
{
    /// <include file='StartParam.xml' path='doc/member[@name="StartParam.iid"]/*'/>
    [NativeTypeName("IID")]
    public Guid iid;
    /// <include file='StartParam.xml' path='doc/member[@name="StartParam.pIBindCtx"]/*'/>
    public IBindCtx* pIBindCtx;
    /// <include file='StartParam.xml' path='doc/member[@name="StartParam.pItf"]/*'/>
    public IUnknown* pItf;
}