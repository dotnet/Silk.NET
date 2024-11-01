// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_MESSAGE_ID")]
    public enum MessageID : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UNKNOWN")]
        MessageIDUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"DeviceIasetvertexbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD")]
        MessageIDDeviceIasetvertexbuffersHazard = 0x1,
        [Obsolete("Deprecated in favour of \"DeviceIasetindexbufferHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD")]
        MessageIDDeviceIasetindexbufferHazard = 0x2,
        [Obsolete("Deprecated in favour of \"DeviceVssetshaderresourcesHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceVssetshaderresourcesHazard = 0x3,
        [Obsolete("Deprecated in favour of \"DeviceVssetconstantbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceVssetconstantbuffersHazard = 0x4,
        [Obsolete("Deprecated in favour of \"DeviceGssetshaderresourcesHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceGssetshaderresourcesHazard = 0x5,
        [Obsolete("Deprecated in favour of \"DeviceGssetconstantbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceGssetconstantbuffersHazard = 0x6,
        [Obsolete("Deprecated in favour of \"DevicePssetshaderresourcesHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD")]
        MessageIDDevicePssetshaderresourcesHazard = 0x7,
        [Obsolete("Deprecated in favour of \"DevicePssetconstantbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDevicePssetconstantbuffersHazard = 0x8,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD")]
        MessageIDDeviceOmsetrendertargetsHazard = 0x9,
        [Obsolete("Deprecated in favour of \"DeviceSosettargetsHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD")]
        MessageIDDeviceSosettargetsHazard = 0xA,
        [Obsolete("Deprecated in favour of \"StringFromApplication\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_STRING_FROM_APPLICATION")]
        MessageIDStringFromApplication = 0xB,
        [Obsolete("Deprecated in favour of \"CorruptedThis\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_THIS")]
        MessageIDCorruptedThis = 0xC,
        [Obsolete("Deprecated in favour of \"CorruptedParameter1\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER1")]
        MessageIDCorruptedParameter1 = 0xD,
        [Obsolete("Deprecated in favour of \"CorruptedParameter2\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER2")]
        MessageIDCorruptedParameter2 = 0xE,
        [Obsolete("Deprecated in favour of \"CorruptedParameter3\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER3")]
        MessageIDCorruptedParameter3 = 0xF,
        [Obsolete("Deprecated in favour of \"CorruptedParameter4\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER4")]
        MessageIDCorruptedParameter4 = 0x10,
        [Obsolete("Deprecated in favour of \"CorruptedParameter5\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER5")]
        MessageIDCorruptedParameter5 = 0x11,
        [Obsolete("Deprecated in favour of \"CorruptedParameter6\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER6")]
        MessageIDCorruptedParameter6 = 0x12,
        [Obsolete("Deprecated in favour of \"CorruptedParameter7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER7")]
        MessageIDCorruptedParameter7 = 0x13,
        [Obsolete("Deprecated in favour of \"CorruptedParameter8\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER8")]
        MessageIDCorruptedParameter8 = 0x14,
        [Obsolete("Deprecated in favour of \"CorruptedParameter9\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER9")]
        MessageIDCorruptedParameter9 = 0x15,
        [Obsolete("Deprecated in favour of \"CorruptedParameter10\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER10")]
        MessageIDCorruptedParameter10 = 0x16,
        [Obsolete("Deprecated in favour of \"CorruptedParameter11\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER11")]
        MessageIDCorruptedParameter11 = 0x17,
        [Obsolete("Deprecated in favour of \"CorruptedParameter12\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER12")]
        MessageIDCorruptedParameter12 = 0x18,
        [Obsolete("Deprecated in favour of \"CorruptedParameter13\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER13")]
        MessageIDCorruptedParameter13 = 0x19,
        [Obsolete("Deprecated in favour of \"CorruptedParameter14\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER14")]
        MessageIDCorruptedParameter14 = 0x1A,
        [Obsolete("Deprecated in favour of \"CorruptedParameter15\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER15")]
        MessageIDCorruptedParameter15 = 0x1B,
        [Obsolete("Deprecated in favour of \"CorruptedMultithreading\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_MULTITHREADING")]
        MessageIDCorruptedMultithreading = 0x1C,
        [Obsolete("Deprecated in favour of \"MessageReportingOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY")]
        MessageIDMessageReportingOutofmemory = 0x1D,
        [Obsolete("Deprecated in favour of \"IasetinputlayoutUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT")]
        MessageIDIasetinputlayoutUnbinddeletingobject = 0x1E,
        [Obsolete("Deprecated in favour of \"IasetvertexbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDIasetvertexbuffersUnbinddeletingobject = 0x1F,
        [Obsolete("Deprecated in favour of \"IasetindexbufferUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT")]
        MessageIDIasetindexbufferUnbinddeletingobject = 0x20,
        [Obsolete("Deprecated in favour of \"VssetshaderUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDVssetshaderUnbinddeletingobject = 0x21,
        [Obsolete("Deprecated in favour of \"VssetshaderresourcesUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDVssetshaderresourcesUnbinddeletingobject = 0x22,
        [Obsolete("Deprecated in favour of \"VssetconstantbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDVssetconstantbuffersUnbinddeletingobject = 0x23,
        [Obsolete("Deprecated in favour of \"VssetsamplersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDVssetsamplersUnbinddeletingobject = 0x24,
        [Obsolete("Deprecated in favour of \"GssetshaderUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDGssetshaderUnbinddeletingobject = 0x25,
        [Obsolete("Deprecated in favour of \"GssetshaderresourcesUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDGssetshaderresourcesUnbinddeletingobject = 0x26,
        [Obsolete("Deprecated in favour of \"GssetconstantbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDGssetconstantbuffersUnbinddeletingobject = 0x27,
        [Obsolete("Deprecated in favour of \"GssetsamplersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDGssetsamplersUnbinddeletingobject = 0x28,
        [Obsolete("Deprecated in favour of \"SosettargetsUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT")]
        MessageIDSosettargetsUnbinddeletingobject = 0x29,
        [Obsolete("Deprecated in favour of \"PssetshaderUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDPssetshaderUnbinddeletingobject = 0x2A,
        [Obsolete("Deprecated in favour of \"PssetshaderresourcesUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDPssetshaderresourcesUnbinddeletingobject = 0x2B,
        [Obsolete("Deprecated in favour of \"PssetconstantbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDPssetconstantbuffersUnbinddeletingobject = 0x2C,
        [Obsolete("Deprecated in favour of \"PssetsamplersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDPssetsamplersUnbinddeletingobject = 0x2D,
        [Obsolete("Deprecated in favour of \"RssetstateUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT")]
        MessageIDRssetstateUnbinddeletingobject = 0x2E,
        [Obsolete("Deprecated in favour of \"OmsetblendstateUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT")]
        MessageIDOmsetblendstateUnbinddeletingobject = 0x2F,
        [Obsolete("Deprecated in favour of \"OmsetdepthstencilstateUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT")]
        MessageIDOmsetdepthstencilstateUnbinddeletingobject = 0x30,
        [Obsolete("Deprecated in favour of \"OmsetrendertargetsUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT")]
        MessageIDOmsetrendertargetsUnbinddeletingobject = 0x31,
        [Obsolete("Deprecated in favour of \"SetpredicationUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT")]
        MessageIDSetpredicationUnbinddeletingobject = 0x32,
        [Obsolete("Deprecated in favour of \"GetprivatedataMoredata\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETPRIVATEDATA_MOREDATA")]
        MessageIDGetprivatedataMoredata = 0x33,
        [Obsolete("Deprecated in favour of \"SetprivatedataInvalidfreedata\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA")]
        MessageIDSetprivatedataInvalidfreedata = 0x34,
        [Obsolete("Deprecated in favour of \"SetprivatedataInvalidiunknown\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN")]
        MessageIDSetprivatedataInvalidiunknown = 0x35,
        [Obsolete("Deprecated in favour of \"SetprivatedataInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS")]
        MessageIDSetprivatedataInvalidflags = 0x36,
        [Obsolete("Deprecated in favour of \"SetprivatedataChangingparams\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS")]
        MessageIDSetprivatedataChangingparams = 0x37,
        [Obsolete("Deprecated in favour of \"SetprivatedataOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY")]
        MessageIDSetprivatedataOutofmemory = 0x38,
        [Obsolete("Deprecated in favour of \"CreatebufferUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT")]
        MessageIDCreatebufferUnrecognizedformat = 0x39,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidsamples\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES")]
        MessageIDCreatebufferInvalidsamples = 0x3A,
        [Obsolete("Deprecated in favour of \"CreatebufferUnrecognizedusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE")]
        MessageIDCreatebufferUnrecognizedusage = 0x3B,
        [Obsolete("Deprecated in favour of \"CreatebufferUnrecognizedbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatebufferUnrecognizedbindflags = 0x3C,
        [Obsolete("Deprecated in favour of \"CreatebufferUnrecognizedcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatebufferUnrecognizedcpuaccessflags = 0x3D,
        [Obsolete("Deprecated in favour of \"CreatebufferUnrecognizedmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatebufferUnrecognizedmiscflags = 0x3E,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatebufferInvalidcpuaccessflags = 0x3F,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS")]
        MessageIDCreatebufferInvalidbindflags = 0x40,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidinitialdata\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA")]
        MessageIDCreatebufferInvalidinitialdata = 0x41,
        [Obsolete("Deprecated in favour of \"CreatebufferInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS")]
        MessageIDCreatebufferInvaliddimensions = 0x42,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidmiplevels\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS")]
        MessageIDCreatebufferInvalidmiplevels = 0x43,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS")]
        MessageIDCreatebufferInvalidmiscflags = 0x44,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN")]
        MessageIDCreatebufferInvalidargReturn = 0x45,
        [Obsolete("Deprecated in favour of \"CreatebufferOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN")]
        MessageIDCreatebufferOutofmemoryReturn = 0x46,
        [Obsolete("Deprecated in favour of \"CreatebufferNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_NULLDESC")]
        MessageIDCreatebufferNulldesc = 0x47,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidconstantbufferbindings\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS")]
        MessageIDCreatebufferInvalidconstantbufferbindings = 0x48,
        [Obsolete("Deprecated in favour of \"CreatebufferLargeallocation\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION")]
        MessageIDCreatebufferLargeallocation = 0x49,
        [Obsolete("Deprecated in favour of \"Createtexture1DUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT")]
        MessageIDCreatetexture1DUnrecognizedformat = 0x4A,
        [Obsolete("Deprecated in favour of \"Createtexture1DUnsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT")]
        MessageIDCreatetexture1DUnsupportedformat = 0x4B,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidsamples\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES")]
        MessageIDCreatetexture1DInvalidsamples = 0x4C,
        [Obsolete("Deprecated in favour of \"Createtexture1DUnrecognizedusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE")]
        MessageIDCreatetexture1DUnrecognizedusage = 0x4D,
        [Obsolete("Deprecated in favour of \"Createtexture1DUnrecognizedbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatetexture1DUnrecognizedbindflags = 0x4E,
        [Obsolete("Deprecated in favour of \"Createtexture1DUnrecognizedcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatetexture1DUnrecognizedcpuaccessflags = 0x4F,
        [Obsolete("Deprecated in favour of \"Createtexture1DUnrecognizedmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatetexture1DUnrecognizedmiscflags = 0x50,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatetexture1DInvalidcpuaccessflags = 0x51,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS")]
        MessageIDCreatetexture1DInvalidbindflags = 0x52,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidinitialdata\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA")]
        MessageIDCreatetexture1DInvalidinitialdata = 0x53,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS")]
        MessageIDCreatetexture1DInvaliddimensions = 0x54,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidmiplevels\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS")]
        MessageIDCreatetexture1DInvalidmiplevels = 0x55,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS")]
        MessageIDCreatetexture1DInvalidmiscflags = 0x56,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN")]
        MessageIDCreatetexture1DInvalidargReturn = 0x57,
        [Obsolete("Deprecated in favour of \"Createtexture1DOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN")]
        MessageIDCreatetexture1DOutofmemoryReturn = 0x58,
        [Obsolete("Deprecated in favour of \"Createtexture1DNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_NULLDESC")]
        MessageIDCreatetexture1DNulldesc = 0x59,
        [Obsolete("Deprecated in favour of \"Createtexture1DLargeallocation\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION")]
        MessageIDCreatetexture1DLargeallocation = 0x5A,
        [Obsolete("Deprecated in favour of \"Createtexture2DUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT")]
        MessageIDCreatetexture2DUnrecognizedformat = 0x5B,
        [Obsolete("Deprecated in favour of \"Createtexture2DUnsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT")]
        MessageIDCreatetexture2DUnsupportedformat = 0x5C,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidsamples\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES")]
        MessageIDCreatetexture2DInvalidsamples = 0x5D,
        [Obsolete("Deprecated in favour of \"Createtexture2DUnrecognizedusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE")]
        MessageIDCreatetexture2DUnrecognizedusage = 0x5E,
        [Obsolete("Deprecated in favour of \"Createtexture2DUnrecognizedbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatetexture2DUnrecognizedbindflags = 0x5F,
        [Obsolete("Deprecated in favour of \"Createtexture2DUnrecognizedcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatetexture2DUnrecognizedcpuaccessflags = 0x60,
        [Obsolete("Deprecated in favour of \"Createtexture2DUnrecognizedmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatetexture2DUnrecognizedmiscflags = 0x61,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatetexture2DInvalidcpuaccessflags = 0x62,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS")]
        MessageIDCreatetexture2DInvalidbindflags = 0x63,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidinitialdata\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA")]
        MessageIDCreatetexture2DInvalidinitialdata = 0x64,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS")]
        MessageIDCreatetexture2DInvaliddimensions = 0x65,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidmiplevels\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS")]
        MessageIDCreatetexture2DInvalidmiplevels = 0x66,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS")]
        MessageIDCreatetexture2DInvalidmiscflags = 0x67,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN")]
        MessageIDCreatetexture2DInvalidargReturn = 0x68,
        [Obsolete("Deprecated in favour of \"Createtexture2DOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN")]
        MessageIDCreatetexture2DOutofmemoryReturn = 0x69,
        [Obsolete("Deprecated in favour of \"Createtexture2DNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_NULLDESC")]
        MessageIDCreatetexture2DNulldesc = 0x6A,
        [Obsolete("Deprecated in favour of \"Createtexture2DLargeallocation\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION")]
        MessageIDCreatetexture2DLargeallocation = 0x6B,
        [Obsolete("Deprecated in favour of \"Createtexture3DUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT")]
        MessageIDCreatetexture3DUnrecognizedformat = 0x6C,
        [Obsolete("Deprecated in favour of \"Createtexture3DUnsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT")]
        MessageIDCreatetexture3DUnsupportedformat = 0x6D,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidsamples\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES")]
        MessageIDCreatetexture3DInvalidsamples = 0x6E,
        [Obsolete("Deprecated in favour of \"Createtexture3DUnrecognizedusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE")]
        MessageIDCreatetexture3DUnrecognizedusage = 0x6F,
        [Obsolete("Deprecated in favour of \"Createtexture3DUnrecognizedbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatetexture3DUnrecognizedbindflags = 0x70,
        [Obsolete("Deprecated in favour of \"Createtexture3DUnrecognizedcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatetexture3DUnrecognizedcpuaccessflags = 0x71,
        [Obsolete("Deprecated in favour of \"Createtexture3DUnrecognizedmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatetexture3DUnrecognizedmiscflags = 0x72,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidcpuaccessflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatetexture3DInvalidcpuaccessflags = 0x73,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidbindflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS")]
        MessageIDCreatetexture3DInvalidbindflags = 0x74,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidinitialdata\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA")]
        MessageIDCreatetexture3DInvalidinitialdata = 0x75,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS")]
        MessageIDCreatetexture3DInvaliddimensions = 0x76,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidmiplevels\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS")]
        MessageIDCreatetexture3DInvalidmiplevels = 0x77,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS")]
        MessageIDCreatetexture3DInvalidmiscflags = 0x78,
        [Obsolete("Deprecated in favour of \"Createtexture3DInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN")]
        MessageIDCreatetexture3DInvalidargReturn = 0x79,
        [Obsolete("Deprecated in favour of \"Createtexture3DOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN")]
        MessageIDCreatetexture3DOutofmemoryReturn = 0x7A,
        [Obsolete("Deprecated in favour of \"Createtexture3DNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_NULLDESC")]
        MessageIDCreatetexture3DNulldesc = 0x7B,
        [Obsolete("Deprecated in favour of \"Createtexture3DLargeallocation\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION")]
        MessageIDCreatetexture3DLargeallocation = 0x7C,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateshaderresourceviewUnrecognizedformat = 0x7D,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvaliddesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC")]
        MessageIDCreateshaderresourceviewInvaliddesc = 0x7E,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT")]
        MessageIDCreateshaderresourceviewInvalidformat = 0x7F,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateshaderresourceviewInvaliddimensions = 0x80,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE")]
        MessageIDCreateshaderresourceviewInvalidresource = 0x81,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS")]
        MessageIDCreateshaderresourceviewToomanyobjects = 0x82,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN")]
        MessageIDCreateshaderresourceviewInvalidargReturn = 0x83,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreateshaderresourceviewOutofmemoryReturn = 0x84,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreaterendertargetviewUnrecognizedformat = 0x85,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewUnsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT")]
        MessageIDCreaterendertargetviewUnsupportedformat = 0x86,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvaliddesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC")]
        MessageIDCreaterendertargetviewInvaliddesc = 0x87,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT")]
        MessageIDCreaterendertargetviewInvalidformat = 0x88,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS")]
        MessageIDCreaterendertargetviewInvaliddimensions = 0x89,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE")]
        MessageIDCreaterendertargetviewInvalidresource = 0x8A,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS")]
        MessageIDCreaterendertargetviewToomanyobjects = 0x8B,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN")]
        MessageIDCreaterendertargetviewInvalidargReturn = 0x8C,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreaterendertargetviewOutofmemoryReturn = 0x8D,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreatedepthstencilviewUnrecognizedformat = 0x8E,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvaliddesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC")]
        MessageIDCreatedepthstencilviewInvaliddesc = 0x8F,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT")]
        MessageIDCreatedepthstencilviewInvalidformat = 0x90,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS")]
        MessageIDCreatedepthstencilviewInvaliddimensions = 0x91,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE")]
        MessageIDCreatedepthstencilviewInvalidresource = 0x92,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS")]
        MessageIDCreatedepthstencilviewToomanyobjects = 0x93,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN")]
        MessageIDCreatedepthstencilviewInvalidargReturn = 0x94,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatedepthstencilviewOutofmemoryReturn = 0x95,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY")]
        MessageIDCreateinputlayoutOutofmemory = 0x96,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutToomanyelements\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS")]
        MessageIDCreateinputlayoutToomanyelements = 0x97,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT")]
        MessageIDCreateinputlayoutInvalidformat = 0x98,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutIncompatibleformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT")]
        MessageIDCreateinputlayoutIncompatibleformat = 0x99,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidslot\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT")]
        MessageIDCreateinputlayoutInvalidslot = 0x9A,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidinputslotclass\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS")]
        MessageIDCreateinputlayoutInvalidinputslotclass = 0x9B,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutSteprateslotclassmismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH")]
        MessageIDCreateinputlayoutSteprateslotclassmismatch = 0x9C,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidslotclasschange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE")]
        MessageIDCreateinputlayoutInvalidslotclasschange = 0x9D,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidstepratechange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE")]
        MessageIDCreateinputlayoutInvalidstepratechange = 0x9E,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidalignment\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT")]
        MessageIDCreateinputlayoutInvalidalignment = 0x9F,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutDuplicatesemantic\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC")]
        MessageIDCreateinputlayoutDuplicatesemantic = 0xA0,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutUnparseableinputsignature\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE")]
        MessageIDCreateinputlayoutUnparseableinputsignature = 0xA1,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutNullsemantic\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC")]
        MessageIDCreateinputlayoutNullsemantic = 0xA2,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutMissingelement\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT")]
        MessageIDCreateinputlayoutMissingelement = 0xA3,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC")]
        MessageIDCreateinputlayoutNulldesc = 0xA4,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY")]
        MessageIDCreatevertexshaderOutofmemory = 0xA5,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatevertexshaderInvalidshaderbytecode = 0xA6,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatevertexshaderInvalidshadertype = 0xA7,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY")]
        MessageIDCreategeometryshaderOutofmemory = 0xA8,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderInvalidshaderbytecode = 0xA9,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderInvalidshadertype = 0xAA,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY")]
        MessageIDCreategeometryshaderwithstreamoutputOutofmemory = 0xAB,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshaderbytecode = 0xAC,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshadertype = 0xAD,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidnumentries\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumentries = 0xAE,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOutputstreamstrideunused\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputstreamstrideunused = 0xAF,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputUnexpecteddecl\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpecteddecl = 0xB0,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputExpecteddecl\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL")]
        MessageIDCreategeometryshaderwithstreamoutputExpecteddecl = 0xB1,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOutputslot0Expected\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputslot0Expected = 0xB2,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidoutputslot\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputslot = 0xB3,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOnlyoneelementperslot\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputOnlyoneelementperslot = 0xB4,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidcomponentcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidcomponentcount = 0xB5,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 0xB6,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidgapdefinition\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidgapdefinition = 0xB7,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputRepeatedoutput\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT")]
        MessageIDCreategeometryshaderwithstreamoutputRepeatedoutput = 0xB8,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidoutputstreamstride\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 0xB9,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputMissingsemantic\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputMissingsemantic = 0xBA,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputMaskmismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH")]
        MessageIDCreategeometryshaderwithstreamoutputMaskmismatch = 0xBB,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputCanthaveonlygaps\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS")]
        MessageIDCreategeometryshaderwithstreamoutputCanthaveonlygaps = 0xBC,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputDecltoocomplex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX")]
        MessageIDCreategeometryshaderwithstreamoutputDecltoocomplex = 0xBD,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputMissingoutputsignature\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE")]
        MessageIDCreategeometryshaderwithstreamoutputMissingoutputsignature = 0xBE,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY")]
        MessageIDCreatepixelshaderOutofmemory = 0xBF,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatepixelshaderInvalidshaderbytecode = 0xC0,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatepixelshaderInvalidshadertype = 0xC1,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidfillmode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE")]
        MessageIDCreaterasterizerstateInvalidfillmode = 0xC2,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidcullmode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE")]
        MessageIDCreaterasterizerstateInvalidcullmode = 0xC3,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvaliddepthbiasclamp\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP")]
        MessageIDCreaterasterizerstateInvaliddepthbiasclamp = 0xC4,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidslopescaleddepthbias\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS")]
        MessageIDCreaterasterizerstateInvalidslopescaleddepthbias = 0xC5,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS")]
        MessageIDCreaterasterizerstateToomanyobjects = 0xC6,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC")]
        MessageIDCreaterasterizerstateNulldesc = 0xC7,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvaliddepthwritemask\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK")]
        MessageIDCreatedepthstencilstateInvaliddepthwritemask = 0xC8,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvaliddepthfunc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC")]
        MessageIDCreatedepthstencilstateInvaliddepthfunc = 0xC9,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilfailop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfailop = 0xCA,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilzfailop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilzfailop = 0xCB,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilpassop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilpassop = 0xCC,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilfunc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfunc = 0xCD,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilfailop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfailop = 0xCE,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilzfailop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilzfailop = 0xCF,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilpassop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilpassop = 0xD0,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilfunc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfunc = 0xD1,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS")]
        MessageIDCreatedepthstencilstateToomanyobjects = 0xD2,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC")]
        MessageIDCreatedepthstencilstateNulldesc = 0xD3,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidsrcblend\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND")]
        MessageIDCreateblendstateInvalidsrcblend = 0xD4,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvaliddestblend\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND")]
        MessageIDCreateblendstateInvaliddestblend = 0xD5,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidblendop\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP")]
        MessageIDCreateblendstateInvalidblendop = 0xD6,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidsrcblendalpha\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA")]
        MessageIDCreateblendstateInvalidsrcblendalpha = 0xD7,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvaliddestblendalpha\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA")]
        MessageIDCreateblendstateInvaliddestblendalpha = 0xD8,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidblendopalpha\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA")]
        MessageIDCreateblendstateInvalidblendopalpha = 0xD9,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidrendertargetwritemask\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK")]
        MessageIDCreateblendstateInvalidrendertargetwritemask = 0xDA,
        [Obsolete("Deprecated in favour of \"CreateblendstateToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS")]
        MessageIDCreateblendstateToomanyobjects = 0xDB,
        [Obsolete("Deprecated in favour of \"CreateblendstateNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC")]
        MessageIDCreateblendstateNulldesc = 0xDC,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidfilter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER")]
        MessageIDCreatesamplerstateInvalidfilter = 0xDD,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidaddressu\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU")]
        MessageIDCreatesamplerstateInvalidaddressu = 0xDE,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidaddressv\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV")]
        MessageIDCreatesamplerstateInvalidaddressv = 0xDF,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidaddressw\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW")]
        MessageIDCreatesamplerstateInvalidaddressw = 0xE0,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidmiplodbias\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS")]
        MessageIDCreatesamplerstateInvalidmiplodbias = 0xE1,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidmaxanisotropy\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY")]
        MessageIDCreatesamplerstateInvalidmaxanisotropy = 0xE2,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidcomparisonfunc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC")]
        MessageIDCreatesamplerstateInvalidcomparisonfunc = 0xE3,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidminlod\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD")]
        MessageIDCreatesamplerstateInvalidminlod = 0xE4,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateInvalidmaxlod\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD")]
        MessageIDCreatesamplerstateInvalidmaxlod = 0xE5,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS")]
        MessageIDCreatesamplerstateToomanyobjects = 0xE6,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC")]
        MessageIDCreatesamplerstateNulldesc = 0xE7,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateInvalidquery\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY")]
        MessageIDCreatequeryorpredicateInvalidquery = 0xE8,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateInvalidmiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS")]
        MessageIDCreatequeryorpredicateInvalidmiscflags = 0xE9,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateUnexpectedmiscflag\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG")]
        MessageIDCreatequeryorpredicateUnexpectedmiscflag = 0xEA,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC")]
        MessageIDCreatequeryorpredicateNulldesc = 0xEB,
        [Obsolete("Deprecated in favour of \"DeviceIasetprimitivetopologyTopologyUnrecognized\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED")]
        MessageIDDeviceIasetprimitivetopologyTopologyUnrecognized = 0xEC,
        [Obsolete("Deprecated in favour of \"DeviceIasetprimitivetopologyTopologyUndefined\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED")]
        MessageIDDeviceIasetprimitivetopologyTopologyUndefined = 0xED,
        [Obsolete("Deprecated in favour of \"IasetvertexbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER")]
        MessageIDIasetvertexbuffersInvalidbuffer = 0xEE,
        [Obsolete("Deprecated in favour of \"DeviceIasetvertexbuffersOffsetTooLarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE")]
        MessageIDDeviceIasetvertexbuffersOffsetTooLarge = 0xEF,
        [Obsolete("Deprecated in favour of \"DeviceIasetvertexbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceIasetvertexbuffersBuffersEmpty = 0xF0,
        [Obsolete("Deprecated in favour of \"IasetindexbufferInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER")]
        MessageIDIasetindexbufferInvalidbuffer = 0xF1,
        [Obsolete("Deprecated in favour of \"DeviceIasetindexbufferFormatInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID")]
        MessageIDDeviceIasetindexbufferFormatInvalid = 0xF2,
        [Obsolete("Deprecated in favour of \"DeviceIasetindexbufferOffsetTooLarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE")]
        MessageIDDeviceIasetindexbufferOffsetTooLarge = 0xF3,
        [Obsolete("Deprecated in favour of \"DeviceIasetindexbufferOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED")]
        MessageIDDeviceIasetindexbufferOffsetUnaligned = 0xF4,
        [Obsolete("Deprecated in favour of \"DeviceVssetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceVssetshaderresourcesViewsEmpty = 0xF5,
        [Obsolete("Deprecated in favour of \"VssetconstantbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDVssetconstantbuffersInvalidbuffer = 0xF6,
        [Obsolete("Deprecated in favour of \"DeviceVssetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceVssetconstantbuffersBuffersEmpty = 0xF7,
        [Obsolete("Deprecated in favour of \"DeviceVssetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceVssetsamplersSamplersEmpty = 0xF8,
        [Obsolete("Deprecated in favour of \"DeviceGssetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceGssetshaderresourcesViewsEmpty = 0xF9,
        [Obsolete("Deprecated in favour of \"GssetconstantbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDGssetconstantbuffersInvalidbuffer = 0xFA,
        [Obsolete("Deprecated in favour of \"DeviceGssetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceGssetconstantbuffersBuffersEmpty = 0xFB,
        [Obsolete("Deprecated in favour of \"DeviceGssetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceGssetsamplersSamplersEmpty = 0xFC,
        [Obsolete("Deprecated in favour of \"SosettargetsInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER")]
        MessageIDSosettargetsInvalidbuffer = 0xFD,
        [Obsolete("Deprecated in favour of \"DeviceSosettargetsOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED")]
        MessageIDDeviceSosettargetsOffsetUnaligned = 0xFE,
        [Obsolete("Deprecated in favour of \"DevicePssetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDevicePssetshaderresourcesViewsEmpty = 0xFF,
        [Obsolete("Deprecated in favour of \"PssetconstantbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDPssetconstantbuffersInvalidbuffer = 0x100,
        [Obsolete("Deprecated in favour of \"DevicePssetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDevicePssetconstantbuffersBuffersEmpty = 0x101,
        [Obsolete("Deprecated in favour of \"DevicePssetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDevicePssetsamplersSamplersEmpty = 0x102,
        [Obsolete("Deprecated in favour of \"DeviceRssetviewportsInvalidviewport\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT")]
        MessageIDDeviceRssetviewportsInvalidviewport = 0x103,
        [Obsolete("Deprecated in favour of \"DeviceRssetscissorrectsInvalidscissor\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR")]
        MessageIDDeviceRssetscissorrectsInvalidscissor = 0x104,
        [Obsolete("Deprecated in favour of \"ClearrendertargetviewDenormflush\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH")]
        MessageIDClearrendertargetviewDenormflush = 0x105,
        [Obsolete("Deprecated in favour of \"CleardepthstencilviewDenormflush\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH")]
        MessageIDCleardepthstencilviewDenormflush = 0x106,
        [Obsolete("Deprecated in favour of \"CleardepthstencilviewInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID")]
        MessageIDCleardepthstencilviewInvalid = 0x107,
        [Obsolete("Deprecated in favour of \"DeviceIagetvertexbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceIagetvertexbuffersBuffersEmpty = 0x108,
        [Obsolete("Deprecated in favour of \"DeviceVsgetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceVsgetshaderresourcesViewsEmpty = 0x109,
        [Obsolete("Deprecated in favour of \"DeviceVsgetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceVsgetconstantbuffersBuffersEmpty = 0x10A,
        [Obsolete("Deprecated in favour of \"DeviceVsgetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceVsgetsamplersSamplersEmpty = 0x10B,
        [Obsolete("Deprecated in favour of \"DeviceGsgetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceGsgetshaderresourcesViewsEmpty = 0x10C,
        [Obsolete("Deprecated in favour of \"DeviceGsgetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceGsgetconstantbuffersBuffersEmpty = 0x10D,
        [Obsolete("Deprecated in favour of \"DeviceGsgetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceGsgetsamplersSamplersEmpty = 0x10E,
        [Obsolete("Deprecated in favour of \"DeviceSogettargetsBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY")]
        MessageIDDeviceSogettargetsBuffersEmpty = 0x10F,
        [Obsolete("Deprecated in favour of \"DevicePsgetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDevicePsgetshaderresourcesViewsEmpty = 0x110,
        [Obsolete("Deprecated in favour of \"DevicePsgetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDevicePsgetconstantbuffersBuffersEmpty = 0x111,
        [Obsolete("Deprecated in favour of \"DevicePsgetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDevicePsgetsamplersSamplersEmpty = 0x112,
        [Obsolete("Deprecated in favour of \"DeviceRsgetviewportsViewportsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY")]
        MessageIDDeviceRsgetviewportsViewportsEmpty = 0x113,
        [Obsolete("Deprecated in favour of \"DeviceRsgetscissorrectsRectsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY")]
        MessageIDDeviceRsgetscissorrectsRectsEmpty = 0x114,
        [Obsolete("Deprecated in favour of \"DeviceGeneratemipsResourceInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID")]
        MessageIDDeviceGeneratemipsResourceInvalid = 0x115,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionInvaliddestinationsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE")]
        MessageIDCopysubresourceregionInvaliddestinationsubresource = 0x116,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionInvalidsourcesubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE")]
        MessageIDCopysubresourceregionInvalidsourcesubresource = 0x117,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionInvalidsourcebox\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX")]
        MessageIDCopysubresourceregionInvalidsourcebox = 0x118,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionInvalidsource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE")]
        MessageIDCopysubresourceregionInvalidsource = 0x119,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionInvaliddestinationstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE")]
        MessageIDCopysubresourceregionInvaliddestinationstate = 0x11A,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionInvalidsourcestate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE")]
        MessageIDCopysubresourceregionInvalidsourcestate = 0x11B,
        [Obsolete("Deprecated in favour of \"CopyresourceInvalidsource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE")]
        MessageIDCopyresourceInvalidsource = 0x11C,
        [Obsolete("Deprecated in favour of \"CopyresourceInvaliddestinationstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE")]
        MessageIDCopyresourceInvaliddestinationstate = 0x11D,
        [Obsolete("Deprecated in favour of \"CopyresourceInvalidsourcestate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE")]
        MessageIDCopyresourceInvalidsourcestate = 0x11E,
        [Obsolete("Deprecated in favour of \"UpdatesubresourceInvaliddestinationsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE")]
        MessageIDUpdatesubresourceInvaliddestinationsubresource = 0x11F,
        [Obsolete("Deprecated in favour of \"UpdatesubresourceInvaliddestinationbox\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX")]
        MessageIDUpdatesubresourceInvaliddestinationbox = 0x120,
        [Obsolete("Deprecated in favour of \"UpdatesubresourceInvaliddestinationstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE")]
        MessageIDUpdatesubresourceInvaliddestinationstate = 0x121,
        [Obsolete("Deprecated in favour of \"DeviceResolvesubresourceDestinationInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID")]
        MessageIDDeviceResolvesubresourceDestinationInvalid = 0x122,
        [Obsolete("Deprecated in favour of \"DeviceResolvesubresourceDestinationSubresourceInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID")]
        MessageIDDeviceResolvesubresourceDestinationSubresourceInvalid = 0x123,
        [Obsolete("Deprecated in favour of \"DeviceResolvesubresourceSourceInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID")]
        MessageIDDeviceResolvesubresourceSourceInvalid = 0x124,
        [Obsolete("Deprecated in favour of \"DeviceResolvesubresourceSourceSubresourceInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID")]
        MessageIDDeviceResolvesubresourceSourceSubresourceInvalid = 0x125,
        [Obsolete("Deprecated in favour of \"DeviceResolvesubresourceFormatInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID")]
        MessageIDDeviceResolvesubresourceFormatInvalid = 0x126,
        [Obsolete("Deprecated in favour of \"BufferMapInvalidmaptype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE")]
        MessageIDBufferMapInvalidmaptype = 0x127,
        [Obsolete("Deprecated in favour of \"BufferMapInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS")]
        MessageIDBufferMapInvalidflags = 0x128,
        [Obsolete("Deprecated in favour of \"BufferMapAlreadymapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED")]
        MessageIDBufferMapAlreadymapped = 0x129,
        [Obsolete("Deprecated in favour of \"BufferMapDeviceremovedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN")]
        MessageIDBufferMapDeviceremovedReturn = 0x12A,
        [Obsolete("Deprecated in favour of \"BufferUnmapNotmapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED")]
        MessageIDBufferUnmapNotmapped = 0x12B,
        [Obsolete("Deprecated in favour of \"Texture1DMapInvalidmaptype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE")]
        MessageIDTexture1DMapInvalidmaptype = 0x12C,
        [Obsolete("Deprecated in favour of \"Texture1DMapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE")]
        MessageIDTexture1DMapInvalidsubresource = 0x12D,
        [Obsolete("Deprecated in favour of \"Texture1DMapInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS")]
        MessageIDTexture1DMapInvalidflags = 0x12E,
        [Obsolete("Deprecated in favour of \"Texture1DMapAlreadymapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED")]
        MessageIDTexture1DMapAlreadymapped = 0x12F,
        [Obsolete("Deprecated in favour of \"Texture1DMapDeviceremovedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN")]
        MessageIDTexture1DMapDeviceremovedReturn = 0x130,
        [Obsolete("Deprecated in favour of \"Texture1DUnmapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDTexture1DUnmapInvalidsubresource = 0x131,
        [Obsolete("Deprecated in favour of \"Texture1DUnmapNotmapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED")]
        MessageIDTexture1DUnmapNotmapped = 0x132,
        [Obsolete("Deprecated in favour of \"Texture2DMapInvalidmaptype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE")]
        MessageIDTexture2DMapInvalidmaptype = 0x133,
        [Obsolete("Deprecated in favour of \"Texture2DMapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE")]
        MessageIDTexture2DMapInvalidsubresource = 0x134,
        [Obsolete("Deprecated in favour of \"Texture2DMapInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS")]
        MessageIDTexture2DMapInvalidflags = 0x135,
        [Obsolete("Deprecated in favour of \"Texture2DMapAlreadymapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED")]
        MessageIDTexture2DMapAlreadymapped = 0x136,
        [Obsolete("Deprecated in favour of \"Texture2DMapDeviceremovedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN")]
        MessageIDTexture2DMapDeviceremovedReturn = 0x137,
        [Obsolete("Deprecated in favour of \"Texture2DUnmapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDTexture2DUnmapInvalidsubresource = 0x138,
        [Obsolete("Deprecated in favour of \"Texture2DUnmapNotmapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED")]
        MessageIDTexture2DUnmapNotmapped = 0x139,
        [Obsolete("Deprecated in favour of \"Texture3DMapInvalidmaptype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE")]
        MessageIDTexture3DMapInvalidmaptype = 0x13A,
        [Obsolete("Deprecated in favour of \"Texture3DMapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE")]
        MessageIDTexture3DMapInvalidsubresource = 0x13B,
        [Obsolete("Deprecated in favour of \"Texture3DMapInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS")]
        MessageIDTexture3DMapInvalidflags = 0x13C,
        [Obsolete("Deprecated in favour of \"Texture3DMapAlreadymapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED")]
        MessageIDTexture3DMapAlreadymapped = 0x13D,
        [Obsolete("Deprecated in favour of \"Texture3DMapDeviceremovedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN")]
        MessageIDTexture3DMapDeviceremovedReturn = 0x13E,
        [Obsolete("Deprecated in favour of \"Texture3DUnmapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDTexture3DUnmapInvalidsubresource = 0x13F,
        [Obsolete("Deprecated in favour of \"Texture3DUnmapNotmapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED")]
        MessageIDTexture3DUnmapNotmapped = 0x140,
        [Obsolete("Deprecated in favour of \"CheckformatsupportFormatDeprecated\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED")]
        MessageIDCheckformatsupportFormatDeprecated = 0x141,
        [Obsolete("Deprecated in favour of \"CheckmultisamplequalitylevelsFormatDeprecated\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED")]
        MessageIDCheckmultisamplequalitylevelsFormatDeprecated = 0x142,
        [Obsolete("Deprecated in favour of \"SetexceptionmodeUnrecognizedflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS")]
        MessageIDSetexceptionmodeUnrecognizedflags = 0x143,
        [Obsolete("Deprecated in favour of \"SetexceptionmodeInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN")]
        MessageIDSetexceptionmodeInvalidargReturn = 0x144,
        [Obsolete("Deprecated in favour of \"SetexceptionmodeDeviceremovedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN")]
        MessageIDSetexceptionmodeDeviceremovedReturn = 0x145,
        [Obsolete("Deprecated in favour of \"RefSimulatingInfinitelyFastHardware\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE")]
        MessageIDRefSimulatingInfinitelyFastHardware = 0x146,
        [Obsolete("Deprecated in favour of \"RefThreadingMode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_THREADING_MODE")]
        MessageIDRefThreadingMode = 0x147,
        [Obsolete("Deprecated in favour of \"RefUmdriverException\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_UMDRIVER_EXCEPTION")]
        MessageIDRefUmdriverException = 0x148,
        [Obsolete("Deprecated in favour of \"RefKmdriverException\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_KMDRIVER_EXCEPTION")]
        MessageIDRefKmdriverException = 0x149,
        [Obsolete("Deprecated in favour of \"RefHardwareException\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_HARDWARE_EXCEPTION")]
        MessageIDRefHardwareException = 0x14A,
        [Obsolete("Deprecated in favour of \"RefAccessingIndexableTempOutOfRange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE")]
        MessageIDRefAccessingIndexableTempOutOfRange = 0x14B,
        [Obsolete("Deprecated in favour of \"RefProblemParsingShader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER")]
        MessageIDRefProblemParsingShader = 0x14C,
        [Obsolete("Deprecated in favour of \"RefOutOfMemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_OUT_OF_MEMORY")]
        MessageIDRefOutOfMemory = 0x14D,
        [Obsolete("Deprecated in favour of \"RefInfo\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_INFO")]
        MessageIDRefInfo = 0x14E,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexposOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW")]
        MessageIDDeviceDrawVertexposOverflow = 0x14F,
        [Obsolete("Deprecated in favour of \"DeviceDrawindexedIndexposOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW")]
        MessageIDDeviceDrawindexedIndexposOverflow = 0x150,
        [Obsolete("Deprecated in favour of \"DeviceDrawinstancedVertexposOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW")]
        MessageIDDeviceDrawinstancedVertexposOverflow = 0x151,
        [Obsolete("Deprecated in favour of \"DeviceDrawinstancedInstanceposOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW")]
        MessageIDDeviceDrawinstancedInstanceposOverflow = 0x152,
        [Obsolete("Deprecated in favour of \"DeviceDrawindexedinstancedInstanceposOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW")]
        MessageIDDeviceDrawindexedinstancedInstanceposOverflow = 0x153,
        [Obsolete("Deprecated in favour of \"DeviceDrawindexedinstancedIndexposOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW")]
        MessageIDDeviceDrawindexedinstancedIndexposOverflow = 0x154,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexShaderNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET")]
        MessageIDDeviceDrawVertexShaderNotSet = 0x155,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageSemanticnameNotFound\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND")]
        MessageIDDeviceShaderLinkageSemanticnameNotFound = 0x156,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageRegisterindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX")]
        MessageIDDeviceShaderLinkageRegisterindex = 0x157,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageComponenttype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE")]
        MessageIDDeviceShaderLinkageComponenttype = 0x158,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageRegistermask\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK")]
        MessageIDDeviceShaderLinkageRegistermask = 0x159,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageSystemvalue\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE")]
        MessageIDDeviceShaderLinkageSystemvalue = 0x15A,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageNeverwrittenAlwaysreads\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS")]
        MessageIDDeviceShaderLinkageNeverwrittenAlwaysreads = 0x15B,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexBufferNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET")]
        MessageIDDeviceDrawVertexBufferNotSet = 0x15C,
        [Obsolete("Deprecated in favour of \"DeviceDrawInputlayoutNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET")]
        MessageIDDeviceDrawInputlayoutNotSet = 0x15D,
        [Obsolete("Deprecated in favour of \"DeviceDrawConstantBufferNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET")]
        MessageIDDeviceDrawConstantBufferNotSet = 0x15E,
        [Obsolete("Deprecated in favour of \"DeviceDrawConstantBufferTooSmall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL")]
        MessageIDDeviceDrawConstantBufferTooSmall = 0x15F,
        [Obsolete("Deprecated in favour of \"DeviceDrawSamplerNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET")]
        MessageIDDeviceDrawSamplerNotSet = 0x160,
        [Obsolete("Deprecated in favour of \"DeviceDrawShaderresourceviewNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET")]
        MessageIDDeviceDrawShaderresourceviewNotSet = 0x161,
        [Obsolete("Deprecated in favour of \"DeviceDrawViewDimensionMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH")]
        MessageIDDeviceDrawViewDimensionMismatch = 0x162,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexBufferStrideTooSmall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL")]
        MessageIDDeviceDrawVertexBufferStrideTooSmall = 0x163,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexBufferTooSmall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL")]
        MessageIDDeviceDrawVertexBufferTooSmall = 0x164,
        [Obsolete("Deprecated in favour of \"DeviceDrawIndexBufferNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET")]
        MessageIDDeviceDrawIndexBufferNotSet = 0x165,
        [Obsolete("Deprecated in favour of \"DeviceDrawIndexBufferFormatInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID")]
        MessageIDDeviceDrawIndexBufferFormatInvalid = 0x166,
        [Obsolete("Deprecated in favour of \"DeviceDrawIndexBufferTooSmall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL")]
        MessageIDDeviceDrawIndexBufferTooSmall = 0x167,
        [Obsolete("Deprecated in favour of \"DeviceDrawGSInputPrimitiveMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH")]
        MessageIDDeviceDrawGSInputPrimitiveMismatch = 0x168,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceReturnTypeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH")]
        MessageIDDeviceDrawResourceReturnTypeMismatch = 0x169,
        [Obsolete("Deprecated in favour of \"DeviceDrawPositionNotPresent\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT")]
        MessageIDDeviceDrawPositionNotPresent = 0x16A,
        [Obsolete("Deprecated in favour of \"DeviceDrawOutputStreamNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET")]
        MessageIDDeviceDrawOutputStreamNotSet = 0x16B,
        [Obsolete("Deprecated in favour of \"DeviceDrawBoundResourceMapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED")]
        MessageIDDeviceDrawBoundResourceMapped = 0x16C,
        [Obsolete("Deprecated in favour of \"DeviceDrawInvalidPrimitivetopology\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY")]
        MessageIDDeviceDrawInvalidPrimitivetopology = 0x16D,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawVertexOffsetUnaligned = 0x16E,
        [Obsolete("Deprecated in favour of \"DeviceDrawVertexStrideUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED")]
        MessageIDDeviceDrawVertexStrideUnaligned = 0x16F,
        [Obsolete("Deprecated in favour of \"DeviceDrawIndexOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawIndexOffsetUnaligned = 0x170,
        [Obsolete("Deprecated in favour of \"DeviceDrawOutputStreamOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawOutputStreamOffsetUnaligned = 0x171,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceFormatLDUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatLDUnsupported = 0x172,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceFormatSampleUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatSampleUnsupported = 0x173,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceFormatSampleCUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatSampleCUnsupported = 0x174,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceMultisampleUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED")]
        MessageIDDeviceDrawResourceMultisampleUnsupported = 0x175,
        [Obsolete("Deprecated in favour of \"DeviceDrawSOTargetsBoundWithoutSource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE")]
        MessageIDDeviceDrawSOTargetsBoundWithoutSource = 0x176,
        [Obsolete("Deprecated in favour of \"DeviceDrawSOStrideLargerThanBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER")]
        MessageIDDeviceDrawSOStrideLargerThanBuffer = 0x177,
        [Obsolete("Deprecated in favour of \"DeviceDrawOMRenderTargetDoesNotSupportBlending\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING")]
        MessageIDDeviceDrawOMRenderTargetDoesNotSupportBlending = 0x178,
        [Obsolete("Deprecated in favour of \"DeviceDrawOMDualSourceBlendingCanOnlyHaveRenderTarget0\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0")]
        MessageIDDeviceDrawOMDualSourceBlendingCanOnlyHaveRenderTarget0 = 0x179,
        [Obsolete("Deprecated in favour of \"DeviceRemovalProcessATFault\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT")]
        MessageIDDeviceRemovalProcessATFault = 0x17A,
        [Obsolete("Deprecated in favour of \"DeviceRemovalProcessPossiblyATFault\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT")]
        MessageIDDeviceRemovalProcessPossiblyATFault = 0x17B,
        [Obsolete("Deprecated in favour of \"DeviceRemovalProcessNotATFault\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT")]
        MessageIDDeviceRemovalProcessNotATFault = 0x17C,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedResourceInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN")]
        MessageIDDeviceOpenSharedResourceInvalidargReturn = 0x17D,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedResourceOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN")]
        MessageIDDeviceOpenSharedResourceOutofmemoryReturn = 0x17E,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedResourceBadinterfaceReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN")]
        MessageIDDeviceOpenSharedResourceBadinterfaceReturn = 0x17F,
        [Obsolete("Deprecated in favour of \"DeviceDrawViewportNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET")]
        MessageIDDeviceDrawViewportNotSet = 0x180,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutTrailingDigitInSemantic\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreateinputlayoutTrailingDigitInSemantic = 0x181,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputTrailingDigitInSemantic\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 0x182,
        [Obsolete("Deprecated in favour of \"DeviceRssetviewportsDenormflush\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH")]
        MessageIDDeviceRssetviewportsDenormflush = 0x183,
        [Obsolete("Deprecated in favour of \"OmsetrendertargetsInvalidview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW")]
        MessageIDOmsetrendertargetsInvalidview = 0x184,
        [Obsolete("Deprecated in favour of \"DeviceSettextfiltersizeInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS")]
        MessageIDDeviceSettextfiltersizeInvaliddimensions = 0x185,
        [Obsolete("Deprecated in favour of \"DeviceDrawSamplerMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH")]
        MessageIDDeviceDrawSamplerMismatch = 0x186,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutTypeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH")]
        MessageIDCreateinputlayoutTypeMismatch = 0x187,
        [Obsolete("Deprecated in favour of \"BlendstateGetdescLegacy\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY")]
        MessageIDBlendstateGetdescLegacy = 0x188,
        [Obsolete("Deprecated in favour of \"ShaderresourceviewGetdescLegacy\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY")]
        MessageIDShaderresourceviewGetdescLegacy = 0x189,
        [Obsolete("Deprecated in favour of \"CreatequeryOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN")]
        MessageIDCreatequeryOutofmemoryReturn = 0x18A,
        [Obsolete("Deprecated in favour of \"CreatepredicateOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN")]
        MessageIDCreatepredicateOutofmemoryReturn = 0x18B,
        [Obsolete("Deprecated in favour of \"CreatecounterOutofrangeCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER")]
        MessageIDCreatecounterOutofrangeCounter = 0x18C,
        [Obsolete("Deprecated in favour of \"CreatecounterSimultaneousActiveCountersExhausted\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED")]
        MessageIDCreatecounterSimultaneousActiveCountersExhausted = 0x18D,
        [Obsolete("Deprecated in favour of \"CreatecounterUnsupportedWellknownCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER")]
        MessageIDCreatecounterUnsupportedWellknownCounter = 0x18E,
        [Obsolete("Deprecated in favour of \"CreatecounterOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN")]
        MessageIDCreatecounterOutofmemoryReturn = 0x18F,
        [Obsolete("Deprecated in favour of \"CreatecounterNonexclusiveReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN")]
        MessageIDCreatecounterNonexclusiveReturn = 0x190,
        [Obsolete("Deprecated in favour of \"CreatecounterNulldesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_NULLDESC")]
        MessageIDCreatecounterNulldesc = 0x191,
        [Obsolete("Deprecated in favour of \"CheckcounterOutofrangeCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER")]
        MessageIDCheckcounterOutofrangeCounter = 0x192,
        [Obsolete("Deprecated in favour of \"CheckcounterUnsupportedWellknownCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER")]
        MessageIDCheckcounterUnsupportedWellknownCounter = 0x193,
        [Obsolete("Deprecated in favour of \"SetpredicationInvalidPredicateState\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE")]
        MessageIDSetpredicationInvalidPredicateState = 0x194,
        [Obsolete("Deprecated in favour of \"QueryBeginUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED")]
        MessageIDQueryBeginUnsupported = 0x195,
        [Obsolete("Deprecated in favour of \"PredicateBeginDuringPredication\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION")]
        MessageIDPredicateBeginDuringPredication = 0x196,
        [Obsolete("Deprecated in favour of \"QueryBeginDuplicate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_DUPLICATE")]
        MessageIDQueryBeginDuplicate = 0x197,
        [Obsolete("Deprecated in favour of \"QueryBeginAbandoningPreviousResults\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS")]
        MessageIDQueryBeginAbandoningPreviousResults = 0x198,
        [Obsolete("Deprecated in favour of \"PredicateEndDuringPredication\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION")]
        MessageIDPredicateEndDuringPredication = 0x199,
        [Obsolete("Deprecated in favour of \"QueryEndAbandoningPreviousResults\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS")]
        MessageIDQueryEndAbandoningPreviousResults = 0x19A,
        [Obsolete("Deprecated in favour of \"QueryEndWithoutBegin\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN")]
        MessageIDQueryEndWithoutBegin = 0x19B,
        [Obsolete("Deprecated in favour of \"QueryGetdataInvalidDatasize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE")]
        MessageIDQueryGetdataInvalidDatasize = 0x19C,
        [Obsolete("Deprecated in favour of \"QueryGetdataInvalidFlags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS")]
        MessageIDQueryGetdataInvalidFlags = 0x19D,
        [Obsolete("Deprecated in favour of \"QueryGetdataInvalidCall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL")]
        MessageIDQueryGetdataInvalidCall = 0x19E,
        [Obsolete("Deprecated in favour of \"DeviceDrawPSOutputTypeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH")]
        MessageIDDeviceDrawPSOutputTypeMismatch = 0x19F,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceFormatGatherUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatGatherUnsupported = 0x1A0,
        [Obsolete("Deprecated in favour of \"DeviceDrawInvalidUseOfCenterMultisamplePattern\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN")]
        MessageIDDeviceDrawInvalidUseOfCenterMultisamplePattern = 0x1A1,
        [Obsolete("Deprecated in favour of \"DeviceIasetvertexbuffersStrideTooLarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE")]
        MessageIDDeviceIasetvertexbuffersStrideTooLarge = 0x1A2,
        [Obsolete("Deprecated in favour of \"DeviceIasetvertexbuffersInvalidrange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE")]
        MessageIDDeviceIasetvertexbuffersInvalidrange = 0x1A3,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutEmptyLayout\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT")]
        MessageIDCreateinputlayoutEmptyLayout = 0x1A4,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceSampleCountMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH")]
        MessageIDDeviceDrawResourceSampleCountMismatch = 0x1A5,
        [Obsolete("Deprecated in favour of \"LiveObjectSummary\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY")]
        MessageIDLiveObjectSummary = 0x1A6,
        [Obsolete("Deprecated in favour of \"LiveBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BUFFER")]
        MessageIDLiveBuffer = 0x1A7,
        [Obsolete("Deprecated in favour of \"LiveTexture1D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE1D")]
        MessageIDLiveTexture1D = 0x1A8,
        [Obsolete("Deprecated in favour of \"LiveTexture2D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE2D")]
        MessageIDLiveTexture2D = 0x1A9,
        [Obsolete("Deprecated in favour of \"LiveTexture3D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE3D")]
        MessageIDLiveTexture3D = 0x1AA,
        [Obsolete("Deprecated in favour of \"LiveShaderresourceview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW")]
        MessageIDLiveShaderresourceview = 0x1AB,
        [Obsolete("Deprecated in favour of \"LiveRendertargetview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW")]
        MessageIDLiveRendertargetview = 0x1AC,
        [Obsolete("Deprecated in favour of \"LiveDepthstencilview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW")]
        MessageIDLiveDepthstencilview = 0x1AD,
        [Obsolete("Deprecated in favour of \"LiveVertexshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VERTEXSHADER")]
        MessageIDLiveVertexshader = 0x1AE,
        [Obsolete("Deprecated in favour of \"LiveGeometryshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER")]
        MessageIDLiveGeometryshader = 0x1AF,
        [Obsolete("Deprecated in favour of \"LivePixelshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PIXELSHADER")]
        MessageIDLivePixelshader = 0x1B0,
        [Obsolete("Deprecated in favour of \"LiveInputlayout\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT")]
        MessageIDLiveInputlayout = 0x1B1,
        [Obsolete("Deprecated in favour of \"LiveSampler\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SAMPLER")]
        MessageIDLiveSampler = 0x1B2,
        [Obsolete("Deprecated in favour of \"LiveBlendstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BLENDSTATE")]
        MessageIDLiveBlendstate = 0x1B3,
        [Obsolete("Deprecated in favour of \"LiveDepthstencilstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE")]
        MessageIDLiveDepthstencilstate = 0x1B4,
        [Obsolete("Deprecated in favour of \"LiveRasterizerstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE")]
        MessageIDLiveRasterizerstate = 0x1B5,
        [Obsolete("Deprecated in favour of \"LiveQuery\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_QUERY")]
        MessageIDLiveQuery = 0x1B6,
        [Obsolete("Deprecated in favour of \"LivePredicate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PREDICATE")]
        MessageIDLivePredicate = 0x1B7,
        [Obsolete("Deprecated in favour of \"LiveCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COUNTER")]
        MessageIDLiveCounter = 0x1B8,
        [Obsolete("Deprecated in favour of \"LiveDevice\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICE")]
        MessageIDLiveDevice = 0x1B9,
        [Obsolete("Deprecated in favour of \"LiveSwapchain\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SWAPCHAIN")]
        MessageIDLiveSwapchain = 0x1BA,
        [Obsolete("Deprecated in favour of \"D3D10MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10_MESSAGES_END")]
        MessageIDD3D10MessagesEnd = 0x1BB,
        [Obsolete("Deprecated in favour of \"D3D10L9MessagesStart\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10L9_MESSAGES_START")]
        MessageIDD3D10L9MessagesStart = 0x100000,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateStencilNoTwoSided\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED")]
        MessageIDCreatedepthstencilstateStencilNoTwoSided = 0x100001,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateDepthBiasClampNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED")]
        MessageIDCreaterasterizerstateDepthBiasClampNotSupported = 0x100002,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateNoComparisonSupport\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT")]
        MessageIDCreatesamplerstateNoComparisonSupport = 0x100003,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateExcessiveAnisotropy\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY")]
        MessageIDCreatesamplerstateExcessiveAnisotropy = 0x100004,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateBorderOutOfRange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE")]
        MessageIDCreatesamplerstateBorderOutOfRange = 0x100005,
        [Obsolete("Deprecated in favour of \"VssetsamplersNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED")]
        MessageIDVssetsamplersNotSupported = 0x100006,
        [Obsolete("Deprecated in favour of \"VssetsamplersTooManySamplers\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS")]
        MessageIDVssetsamplersTooManySamplers = 0x100007,
        [Obsolete("Deprecated in favour of \"PssetsamplersTooManySamplers\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS")]
        MessageIDPssetsamplersTooManySamplers = 0x100008,
        [Obsolete("Deprecated in favour of \"CreateresourceNoArrays\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS")]
        MessageIDCreateresourceNoArrays = 0x100009,
        [Obsolete("Deprecated in favour of \"CreateresourceNoVBAndIBBind\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND")]
        MessageIDCreateresourceNoVBAndIBBind = 0x10000A,
        [Obsolete("Deprecated in favour of \"CreateresourceNoTexture1D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D")]
        MessageIDCreateresourceNoTexture1D = 0x10000B,
        [Obsolete("Deprecated in favour of \"CreateresourceDimensionOutOfRange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE")]
        MessageIDCreateresourceDimensionOutOfRange = 0x10000C,
        [Obsolete("Deprecated in favour of \"CreateresourceNotBindableAsShaderResource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE")]
        MessageIDCreateresourceNotBindableAsShaderResource = 0x10000D,
        [Obsolete("Deprecated in favour of \"OmsetrendertargetsTooManyRenderTargets\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS")]
        MessageIDOmsetrendertargetsTooManyRenderTargets = 0x10000E,
        [Obsolete("Deprecated in favour of \"OmsetrendertargetsNoDifferingBitDepths\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS")]
        MessageIDOmsetrendertargetsNoDifferingBitDepths = 0x10000F,
        [Obsolete("Deprecated in favour of \"IasetvertexbuffersBadBufferIndex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX")]
        MessageIDIasetvertexbuffersBadBufferIndex = 0x100010,
        [Obsolete("Deprecated in favour of \"DeviceRssetviewportsTooManyViewports\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS")]
        MessageIDDeviceRssetviewportsTooManyViewports = 0x100011,
        [Obsolete("Deprecated in favour of \"DeviceIasetprimitivetopologyAdjacencyUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED")]
        MessageIDDeviceIasetprimitivetopologyAdjacencyUnsupported = 0x100012,
        [Obsolete("Deprecated in favour of \"DeviceRssetscissorrectsTooManyScissors\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS")]
        MessageIDDeviceRssetscissorrectsTooManyScissors = 0x100013,
        [Obsolete("Deprecated in favour of \"CopyresourceOnlyTexture2DWithinGpuMemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY")]
        MessageIDCopyresourceOnlyTexture2DWithinGpuMemory = 0x100014,
        [Obsolete("Deprecated in favour of \"CopyresourceNoTexture3DReadback\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK")]
        MessageIDCopyresourceNoTexture3DReadback = 0x100015,
        [Obsolete("Deprecated in favour of \"CopyresourceNoTextureOnlyReadback\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK")]
        MessageIDCopyresourceNoTextureOnlyReadback = 0x100016,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutUnsupportedFormat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT")]
        MessageIDCreateinputlayoutUnsupportedFormat = 0x100017,
        [Obsolete("Deprecated in favour of \"CreateblendstateNoAlphaToCoverage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE")]
        MessageIDCreateblendstateNoAlphaToCoverage = 0x100018,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateDepthClipEnableMustBETrue\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE")]
        MessageIDCreaterasterizerstateDepthClipEnableMustBETrue = 0x100019,
        [Obsolete("Deprecated in favour of \"DrawindexedStartindexlocationMustBEPositive\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE")]
        MessageIDDrawindexedStartindexlocationMustBEPositive = 0x10001A,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewMustUseLowestLod\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD")]
        MessageIDCreateshaderresourceviewMustUseLowestLod = 0x10001B,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateMinlodMustNotBEFractional\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL")]
        MessageIDCreatesamplerstateMinlodMustNotBEFractional = 0x10001C,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateMaxlodMustBEFltMax\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX")]
        MessageIDCreatesamplerstateMaxlodMustBEFltMax = 0x10001D,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewFirstarraysliceMustBEZero\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO")]
        MessageIDCreateshaderresourceviewFirstarraysliceMustBEZero = 0x10001E,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewCubesMustHave6Sides\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES")]
        MessageIDCreateshaderresourceviewCubesMustHave6Sides = 0x10001F,
        [Obsolete("Deprecated in favour of \"CreateresourceNotBindableAsRenderTarget\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET")]
        MessageIDCreateresourceNotBindableAsRenderTarget = 0x100020,
        [Obsolete("Deprecated in favour of \"CreateresourceNoDwordIndexBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER")]
        MessageIDCreateresourceNoDwordIndexBuffer = 0x100021,
        [Obsolete("Deprecated in favour of \"CreateresourceMsaaPrecludesShaderResource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE")]
        MessageIDCreateresourceMsaaPrecludesShaderResource = 0x100022,
        [Obsolete("Deprecated in favour of \"CreateresourcePresentationPrecludesShaderResource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE")]
        MessageIDCreateresourcePresentationPrecludesShaderResource = 0x100023,
        [Obsolete("Deprecated in favour of \"CreateblendstateNoIndependentBlendEnable\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE")]
        MessageIDCreateblendstateNoIndependentBlendEnable = 0x100024,
        [Obsolete("Deprecated in favour of \"CreateblendstateNoIndependentWriteMasks\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS")]
        MessageIDCreateblendstateNoIndependentWriteMasks = 0x100025,
        [Obsolete("Deprecated in favour of \"CreateresourceNoStreamOut\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT")]
        MessageIDCreateresourceNoStreamOut = 0x100026,
        [Obsolete("Deprecated in favour of \"CreateresourceOnlyVBIBForBuffers\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS")]
        MessageIDCreateresourceOnlyVBIBForBuffers = 0x100027,
        [Obsolete("Deprecated in favour of \"CreateresourceNoAutogenForVolumes\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES")]
        MessageIDCreateresourceNoAutogenForVolumes = 0x100028,
        [Obsolete("Deprecated in favour of \"CreateresourceDxgiFormatR8G8B8A8CannotBEShared\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED")]
        MessageIDCreateresourceDxgiFormatR8G8B8A8CannotBEShared = 0x100029,
        [Obsolete("Deprecated in favour of \"VsshaderresourcesNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED")]
        MessageIDVsshaderresourcesNotSupported = 0x10002A,
        [Obsolete("Deprecated in favour of \"GeometryShaderNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED")]
        MessageIDGeometryShaderNotSupported = 0x10002B,
        [Obsolete("Deprecated in favour of \"StreamOutNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED")]
        MessageIDStreamOutNotSupported = 0x10002C,
        [Obsolete("Deprecated in favour of \"TextFilterNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED")]
        MessageIDTextFilterNotSupported = 0x10002D,
        [Obsolete("Deprecated in favour of \"CreateblendstateNoSeparateAlphaBlend\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND")]
        MessageIDCreateblendstateNoSeparateAlphaBlend = 0x10002E,
        [Obsolete("Deprecated in favour of \"CreateblendstateNoMrtBlend\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND")]
        MessageIDCreateblendstateNoMrtBlend = 0x10002F,
        [Obsolete("Deprecated in favour of \"CreateblendstateOperationNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED")]
        MessageIDCreateblendstateOperationNotSupported = 0x100030,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateNoMirroronce\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE")]
        MessageIDCreatesamplerstateNoMirroronce = 0x100031,
        [Obsolete("Deprecated in favour of \"DrawinstancedNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED")]
        MessageIDDrawinstancedNotSupported = 0x100032,
        [Obsolete("Deprecated in favour of \"DrawindexedinstancedNotSupportedBelow93\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3")]
        MessageIDDrawindexedinstancedNotSupportedBelow93 = 0x100033,
        [Obsolete("Deprecated in favour of \"DrawindexedPointlistUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED")]
        MessageIDDrawindexedPointlistUnsupported = 0x100034,
        [Obsolete("Deprecated in favour of \"SetblendstateSampleMaskCannotBEZero\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO")]
        MessageIDSetblendstateSampleMaskCannotBEZero = 0x100035,
        [Obsolete("Deprecated in favour of \"CreateresourceDimensionExceedsFeatureLevelDefinition\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION")]
        MessageIDCreateresourceDimensionExceedsFeatureLevelDefinition = 0x100036,
        [Obsolete("Deprecated in favour of \"CreateresourceOnlySingleMipLevelDepthStencilSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED")]
        MessageIDCreateresourceOnlySingleMipLevelDepthStencilSupported = 0x100037,
        [Obsolete("Deprecated in favour of \"DeviceRssetscissorrectsNegativescissor\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR")]
        MessageIDDeviceRssetscissorrectsNegativescissor = 0x100038,
        [Obsolete("Deprecated in favour of \"SlotZeroMustBED3D10InputPerVertexData\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA")]
        MessageIDSlotZeroMustBED3D10InputPerVertexData = 0x100039,
        [Obsolete("Deprecated in favour of \"CreateresourceNonPow2Mipmap\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP")]
        MessageIDCreateresourceNonPow2Mipmap = 0x10003A,
        [Obsolete("Deprecated in favour of \"CreatesamplerstateBorderNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED")]
        MessageIDCreatesamplerstateBorderNotSupported = 0x10003B,
        [Obsolete("Deprecated in favour of \"OmsetrendertargetsNoSrgbMrt\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT")]
        MessageIDOmsetrendertargetsNoSrgbMrt = 0x10003C,
        [Obsolete("Deprecated in favour of \"CopyresourceNo3DMismatchedUpdates\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES")]
        MessageIDCopyresourceNo3DMismatchedUpdates = 0x10003D,
        [Obsolete("Deprecated in favour of \"D3D10L9MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10L9_MESSAGES_END")]
        MessageIDD3D10L9MessagesEnd = 0x10003E,
        [Obsolete("Deprecated in favour of \"D3D11MessagesStart\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_MESSAGES_START")]
        MessageIDD3D11MessagesStart = 0x200000,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS")]
        MessageIDCreatedepthstencilviewInvalidflags = 0x200001,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatevertexshaderInvalidclasslinkage = 0x200002,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreategeometryshaderInvalidclasslinkage = 0x200003,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidnumstreams\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTREAMS")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumstreams = 0x200004,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 0x200005,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputUnexpectedstreams\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTREAMS")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedstreams = 0x200006,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCLASSLINKAGE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidclasslinkage = 0x200007,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatepixelshaderInvalidclasslinkage = 0x200008,
        [Obsolete("Deprecated in favour of \"CreatedeferredcontextInvalidCommandlistflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_COMMANDLISTFLAGS")]
        MessageIDCreatedeferredcontextInvalidCommandlistflags = 0x200009,
        [Obsolete("Deprecated in favour of \"CreatedeferredcontextSinglethreaded\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_SINGLETHREADED")]
        MessageIDCreatedeferredcontextSinglethreaded = 0x20000A,
        [Obsolete("Deprecated in favour of \"CreatedeferredcontextInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALIDARG_RETURN")]
        MessageIDCreatedeferredcontextInvalidargReturn = 0x20000B,
        [Obsolete("Deprecated in favour of \"CreatedeferredcontextInvalidCallReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_CALL_RETURN")]
        MessageIDCreatedeferredcontextInvalidCallReturn = 0x20000C,
        [Obsolete("Deprecated in favour of \"CreatedeferredcontextOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_OUTOFMEMORY_RETURN")]
        MessageIDCreatedeferredcontextOutofmemoryReturn = 0x20000D,
        [Obsolete("Deprecated in favour of \"FinishdisplaylistOnimmediatecontext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_ONIMMEDIATECONTEXT")]
        MessageIDFinishdisplaylistOnimmediatecontext = 0x20000E,
        [Obsolete("Deprecated in favour of \"FinishdisplaylistOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_OUTOFMEMORY_RETURN")]
        MessageIDFinishdisplaylistOutofmemoryReturn = 0x20000F,
        [Obsolete("Deprecated in favour of \"FinishdisplaylistInvalidCallReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_INVALID_CALL_RETURN")]
        MessageIDFinishdisplaylistInvalidCallReturn = 0x200010,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstream = 0x200011,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputUnexpectedentries\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedentries = 0x200012,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputUnexpectedstrides\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedstrides = 0x200013,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidnumstrides\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumstrides = 0x200014,
        [Obsolete("Deprecated in favour of \"DeviceHssetshaderresourcesHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceHssetshaderresourcesHazard = 0x200015,
        [Obsolete("Deprecated in favour of \"DeviceHssetconstantbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceHssetconstantbuffersHazard = 0x200016,
        [Obsolete("Deprecated in favour of \"HssetshaderresourcesUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDHssetshaderresourcesUnbinddeletingobject = 0x200017,
        [Obsolete("Deprecated in favour of \"HssetconstantbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDHssetconstantbuffersUnbinddeletingobject = 0x200018,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidcall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCALL")]
        MessageIDCreatehullshaderInvalidcall = 0x200019,
        [Obsolete("Deprecated in favour of \"CreatehullshaderOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY")]
        MessageIDCreatehullshaderOutofmemory = 0x20001A,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatehullshaderInvalidshaderbytecode = 0x20001B,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatehullshaderInvalidshadertype = 0x20001C,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatehullshaderInvalidclasslinkage = 0x20001D,
        [Obsolete("Deprecated in favour of \"DeviceHssetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceHssetshaderresourcesViewsEmpty = 0x20001E,
        [Obsolete("Deprecated in favour of \"HssetconstantbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDHssetconstantbuffersInvalidbuffer = 0x20001F,
        [Obsolete("Deprecated in favour of \"DeviceHssetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceHssetconstantbuffersBuffersEmpty = 0x200020,
        [Obsolete("Deprecated in favour of \"DeviceHssetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceHssetsamplersSamplersEmpty = 0x200021,
        [Obsolete("Deprecated in favour of \"DeviceHsgetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceHsgetshaderresourcesViewsEmpty = 0x200022,
        [Obsolete("Deprecated in favour of \"DeviceHsgetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceHsgetconstantbuffersBuffersEmpty = 0x200023,
        [Obsolete("Deprecated in favour of \"DeviceHsgetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceHsgetsamplersSamplersEmpty = 0x200024,
        [Obsolete("Deprecated in favour of \"DeviceDssetshaderresourcesHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceDssetshaderresourcesHazard = 0x200025,
        [Obsolete("Deprecated in favour of \"DeviceDssetconstantbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceDssetconstantbuffersHazard = 0x200026,
        [Obsolete("Deprecated in favour of \"DssetshaderresourcesUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDDssetshaderresourcesUnbinddeletingobject = 0x200027,
        [Obsolete("Deprecated in favour of \"DssetconstantbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDDssetconstantbuffersUnbinddeletingobject = 0x200028,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidcall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCALL")]
        MessageIDCreatedomainshaderInvalidcall = 0x200029,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY")]
        MessageIDCreatedomainshaderOutofmemory = 0x20002A,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatedomainshaderInvalidshaderbytecode = 0x20002B,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatedomainshaderInvalidshadertype = 0x20002C,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatedomainshaderInvalidclasslinkage = 0x20002D,
        [Obsolete("Deprecated in favour of \"DeviceDssetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceDssetshaderresourcesViewsEmpty = 0x20002E,
        [Obsolete("Deprecated in favour of \"DssetconstantbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDDssetconstantbuffersInvalidbuffer = 0x20002F,
        [Obsolete("Deprecated in favour of \"DeviceDssetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceDssetconstantbuffersBuffersEmpty = 0x200030,
        [Obsolete("Deprecated in favour of \"DeviceDssetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceDssetsamplersSamplersEmpty = 0x200031,
        [Obsolete("Deprecated in favour of \"DeviceDsgetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceDsgetshaderresourcesViewsEmpty = 0x200032,
        [Obsolete("Deprecated in favour of \"DeviceDsgetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceDsgetconstantbuffersBuffersEmpty = 0x200033,
        [Obsolete("Deprecated in favour of \"DeviceDsgetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceDsgetsamplersSamplersEmpty = 0x200034,
        [Obsolete("Deprecated in favour of \"DeviceDrawHSXorDSMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_XOR_DS_MISMATCH")]
        MessageIDDeviceDrawHSXorDSMismatch = 0x200035,
        [Obsolete("Deprecated in favour of \"DeferredContextRemovalProcessATFault\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEFERRED_CONTEXT_REMOVAL_PROCESS_AT_FAULT")]
        MessageIDDeferredContextRemovalProcessATFault = 0x200036,
        [Obsolete("Deprecated in favour of \"DeviceDrawindirectInvalidArgBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_INVALID_ARG_BUFFER")]
        MessageIDDeviceDrawindirectInvalidArgBuffer = 0x200037,
        [Obsolete("Deprecated in favour of \"DeviceDrawindirectOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawindirectOffsetUnaligned = 0x200038,
        [Obsolete("Deprecated in favour of \"DeviceDrawindirectOffsetOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_OVERFLOW")]
        MessageIDDeviceDrawindirectOffsetOverflow = 0x200039,
        [Obsolete("Deprecated in favour of \"ResourceMapInvalidmaptype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDMAPTYPE")]
        MessageIDResourceMapInvalidmaptype = 0x20003A,
        [Obsolete("Deprecated in favour of \"ResourceMapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDSUBRESOURCE")]
        MessageIDResourceMapInvalidsubresource = 0x20003B,
        [Obsolete("Deprecated in favour of \"ResourceMapInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDFLAGS")]
        MessageIDResourceMapInvalidflags = 0x20003C,
        [Obsolete("Deprecated in favour of \"ResourceMapAlreadymapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_ALREADYMAPPED")]
        MessageIDResourceMapAlreadymapped = 0x20003D,
        [Obsolete("Deprecated in favour of \"ResourceMapDeviceremovedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_DEVICEREMOVED_RETURN")]
        MessageIDResourceMapDeviceremovedReturn = 0x20003E,
        [Obsolete("Deprecated in favour of \"ResourceMapOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_OUTOFMEMORY_RETURN")]
        MessageIDResourceMapOutofmemoryReturn = 0x20003F,
        [Obsolete("Deprecated in favour of \"ResourceMapWithoutInitialDiscard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_WITHOUT_INITIAL_DISCARD")]
        MessageIDResourceMapWithoutInitialDiscard = 0x200040,
        [Obsolete("Deprecated in favour of \"ResourceUnmapInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDResourceUnmapInvalidsubresource = 0x200041,
        [Obsolete("Deprecated in favour of \"ResourceUnmapNotmapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED")]
        MessageIDResourceUnmapNotmapped = 0x200042,
        [Obsolete("Deprecated in favour of \"DeviceDrawRasterizingControlPoints\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RASTERIZING_CONTROL_POINTS")]
        MessageIDDeviceDrawRasterizingControlPoints = 0x200043,
        [Obsolete("Deprecated in favour of \"DeviceIasetprimitivetopologyTopologyUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNSUPPORTED")]
        MessageIDDeviceIasetprimitivetopologyTopologyUnsupported = 0x200044,
        [Obsolete("Deprecated in favour of \"DeviceDrawHSDSSignatureMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_SIGNATURE_MISMATCH")]
        MessageIDDeviceDrawHSDSSignatureMismatch = 0x200045,
        [Obsolete("Deprecated in favour of \"DeviceDrawHullShaderInputTopologyMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH")]
        MessageIDDeviceDrawHullShaderInputTopologyMismatch = 0x200046,
        [Obsolete("Deprecated in favour of \"DeviceDrawHSDSControlPointCountMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_CONTROL_POINT_COUNT_MISMATCH")]
        MessageIDDeviceDrawHSDSControlPointCountMismatch = 0x200047,
        [Obsolete("Deprecated in favour of \"DeviceDrawHSDSTessellatorDomainMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_TESSELLATOR_DOMAIN_MISMATCH")]
        MessageIDDeviceDrawHSDSTessellatorDomainMismatch = 0x200048,
        [Obsolete("Deprecated in favour of \"CreateContext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CONTEXT")]
        MessageIDCreateContext = 0x200049,
        [Obsolete("Deprecated in favour of \"LiveContext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CONTEXT")]
        MessageIDLiveContext = 0x20004A,
        [Obsolete("Deprecated in favour of \"DestroyContext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CONTEXT")]
        MessageIDDestroyContext = 0x20004B,
        [Obsolete("Deprecated in favour of \"CreateBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_BUFFER")]
        MessageIDCreateBuffer = 0x20004C,
        [Obsolete("Deprecated in favour of \"LiveBufferWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BUFFER_WIN7")]
        MessageIDLiveBufferWin7 = 0x20004D,
        [Obsolete("Deprecated in favour of \"DestroyBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_BUFFER")]
        MessageIDDestroyBuffer = 0x20004E,
        [Obsolete("Deprecated in favour of \"CreateTexture1D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE1D")]
        MessageIDCreateTexture1D = 0x20004F,
        [Obsolete("Deprecated in favour of \"LiveTexture1DWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE1D_WIN7")]
        MessageIDLiveTexture1DWin7 = 0x200050,
        [Obsolete("Deprecated in favour of \"DestroyTexture1D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE1D")]
        MessageIDDestroyTexture1D = 0x200051,
        [Obsolete("Deprecated in favour of \"CreateTexture2D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE2D")]
        MessageIDCreateTexture2D = 0x200052,
        [Obsolete("Deprecated in favour of \"LiveTexture2DWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE2D_WIN7")]
        MessageIDLiveTexture2DWin7 = 0x200053,
        [Obsolete("Deprecated in favour of \"DestroyTexture2D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE2D")]
        MessageIDDestroyTexture2D = 0x200054,
        [Obsolete("Deprecated in favour of \"CreateTexture3D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE3D")]
        MessageIDCreateTexture3D = 0x200055,
        [Obsolete("Deprecated in favour of \"LiveTexture3DWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE3D_WIN7")]
        MessageIDLiveTexture3DWin7 = 0x200056,
        [Obsolete("Deprecated in favour of \"DestroyTexture3D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE3D")]
        MessageIDDestroyTexture3D = 0x200057,
        [Obsolete("Deprecated in favour of \"CreateShaderresourceview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SHADERRESOURCEVIEW")]
        MessageIDCreateShaderresourceview = 0x200058,
        [Obsolete("Deprecated in favour of \"LiveShaderresourceviewWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW_WIN7")]
        MessageIDLiveShaderresourceviewWin7 = 0x200059,
        [Obsolete("Deprecated in favour of \"DestroyShaderresourceview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SHADERRESOURCEVIEW")]
        MessageIDDestroyShaderresourceview = 0x20005A,
        [Obsolete("Deprecated in favour of \"CreateRendertargetview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_RENDERTARGETVIEW")]
        MessageIDCreateRendertargetview = 0x20005B,
        [Obsolete("Deprecated in favour of \"LiveRendertargetviewWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW_WIN7")]
        MessageIDLiveRendertargetviewWin7 = 0x20005C,
        [Obsolete("Deprecated in favour of \"DestroyRendertargetview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_RENDERTARGETVIEW")]
        MessageIDDestroyRendertargetview = 0x20005D,
        [Obsolete("Deprecated in favour of \"CreateDepthstencilview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILVIEW")]
        MessageIDCreateDepthstencilview = 0x20005E,
        [Obsolete("Deprecated in favour of \"LiveDepthstencilviewWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW_WIN7")]
        MessageIDLiveDepthstencilviewWin7 = 0x20005F,
        [Obsolete("Deprecated in favour of \"DestroyDepthstencilview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILVIEW")]
        MessageIDDestroyDepthstencilview = 0x200060,
        [Obsolete("Deprecated in favour of \"CreateVertexshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VERTEXSHADER")]
        MessageIDCreateVertexshader = 0x200061,
        [Obsolete("Deprecated in favour of \"LiveVertexshaderWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VERTEXSHADER_WIN7")]
        MessageIDLiveVertexshaderWin7 = 0x200062,
        [Obsolete("Deprecated in favour of \"DestroyVertexshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VERTEXSHADER")]
        MessageIDDestroyVertexshader = 0x200063,
        [Obsolete("Deprecated in favour of \"CreateHullshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_HULLSHADER")]
        MessageIDCreateHullshader = 0x200064,
        [Obsolete("Deprecated in favour of \"LiveHullshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_HULLSHADER")]
        MessageIDLiveHullshader = 0x200065,
        [Obsolete("Deprecated in favour of \"DestroyHullshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_HULLSHADER")]
        MessageIDDestroyHullshader = 0x200066,
        [Obsolete("Deprecated in favour of \"CreateDomainshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DOMAINSHADER")]
        MessageIDCreateDomainshader = 0x200067,
        [Obsolete("Deprecated in favour of \"LiveDomainshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DOMAINSHADER")]
        MessageIDLiveDomainshader = 0x200068,
        [Obsolete("Deprecated in favour of \"DestroyDomainshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DOMAINSHADER")]
        MessageIDDestroyDomainshader = 0x200069,
        [Obsolete("Deprecated in favour of \"CreateGeometryshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_GEOMETRYSHADER")]
        MessageIDCreateGeometryshader = 0x20006A,
        [Obsolete("Deprecated in favour of \"LiveGeometryshaderWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER_WIN7")]
        MessageIDLiveGeometryshaderWin7 = 0x20006B,
        [Obsolete("Deprecated in favour of \"DestroyGeometryshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_GEOMETRYSHADER")]
        MessageIDDestroyGeometryshader = 0x20006C,
        [Obsolete("Deprecated in favour of \"CreatePixelshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PIXELSHADER")]
        MessageIDCreatePixelshader = 0x20006D,
        [Obsolete("Deprecated in favour of \"LivePixelshaderWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PIXELSHADER_WIN7")]
        MessageIDLivePixelshaderWin7 = 0x20006E,
        [Obsolete("Deprecated in favour of \"DestroyPixelshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PIXELSHADER")]
        MessageIDDestroyPixelshader = 0x20006F,
        [Obsolete("Deprecated in favour of \"CreateInputlayout\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_INPUTLAYOUT")]
        MessageIDCreateInputlayout = 0x200070,
        [Obsolete("Deprecated in favour of \"LiveInputlayoutWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT_WIN7")]
        MessageIDLiveInputlayoutWin7 = 0x200071,
        [Obsolete("Deprecated in favour of \"DestroyInputlayout\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_INPUTLAYOUT")]
        MessageIDDestroyInputlayout = 0x200072,
        [Obsolete("Deprecated in favour of \"CreateSampler\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SAMPLER")]
        MessageIDCreateSampler = 0x200073,
        [Obsolete("Deprecated in favour of \"LiveSamplerWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SAMPLER_WIN7")]
        MessageIDLiveSamplerWin7 = 0x200074,
        [Obsolete("Deprecated in favour of \"DestroySampler\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SAMPLER")]
        MessageIDDestroySampler = 0x200075,
        [Obsolete("Deprecated in favour of \"CreateBlendstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_BLENDSTATE")]
        MessageIDCreateBlendstate = 0x200076,
        [Obsolete("Deprecated in favour of \"LiveBlendstateWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BLENDSTATE_WIN7")]
        MessageIDLiveBlendstateWin7 = 0x200077,
        [Obsolete("Deprecated in favour of \"DestroyBlendstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_BLENDSTATE")]
        MessageIDDestroyBlendstate = 0x200078,
        [Obsolete("Deprecated in favour of \"CreateDepthstencilstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILSTATE")]
        MessageIDCreateDepthstencilstate = 0x200079,
        [Obsolete("Deprecated in favour of \"LiveDepthstencilstateWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE_WIN7")]
        MessageIDLiveDepthstencilstateWin7 = 0x20007A,
        [Obsolete("Deprecated in favour of \"DestroyDepthstencilstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILSTATE")]
        MessageIDDestroyDepthstencilstate = 0x20007B,
        [Obsolete("Deprecated in favour of \"CreateRasterizerstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_RASTERIZERSTATE")]
        MessageIDCreateRasterizerstate = 0x20007C,
        [Obsolete("Deprecated in favour of \"LiveRasterizerstateWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE_WIN7")]
        MessageIDLiveRasterizerstateWin7 = 0x20007D,
        [Obsolete("Deprecated in favour of \"DestroyRasterizerstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_RASTERIZERSTATE")]
        MessageIDDestroyRasterizerstate = 0x20007E,
        [Obsolete("Deprecated in favour of \"CreateQuery\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_QUERY")]
        MessageIDCreateQuery = 0x20007F,
        [Obsolete("Deprecated in favour of \"LiveQueryWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_QUERY_WIN7")]
        MessageIDLiveQueryWin7 = 0x200080,
        [Obsolete("Deprecated in favour of \"DestroyQuery\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_QUERY")]
        MessageIDDestroyQuery = 0x200081,
        [Obsolete("Deprecated in favour of \"CreatePredicate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PREDICATE")]
        MessageIDCreatePredicate = 0x200082,
        [Obsolete("Deprecated in favour of \"LivePredicateWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PREDICATE_WIN7")]
        MessageIDLivePredicateWin7 = 0x200083,
        [Obsolete("Deprecated in favour of \"DestroyPredicate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PREDICATE")]
        MessageIDDestroyPredicate = 0x200084,
        [Obsolete("Deprecated in favour of \"CreateCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COUNTER")]
        MessageIDCreateCounter = 0x200085,
        [Obsolete("Deprecated in favour of \"DestroyCounter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COUNTER")]
        MessageIDDestroyCounter = 0x200086,
        [Obsolete("Deprecated in favour of \"CreateCommandlist\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COMMANDLIST")]
        MessageIDCreateCommandlist = 0x200087,
        [Obsolete("Deprecated in favour of \"LiveCommandlist\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COMMANDLIST")]
        MessageIDLiveCommandlist = 0x200088,
        [Obsolete("Deprecated in favour of \"DestroyCommandlist\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COMMANDLIST")]
        MessageIDDestroyCommandlist = 0x200089,
        [Obsolete("Deprecated in favour of \"CreateClassinstance\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CLASSINSTANCE")]
        MessageIDCreateClassinstance = 0x20008A,
        [Obsolete("Deprecated in favour of \"LiveClassinstance\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CLASSINSTANCE")]
        MessageIDLiveClassinstance = 0x20008B,
        [Obsolete("Deprecated in favour of \"DestroyClassinstance\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CLASSINSTANCE")]
        MessageIDDestroyClassinstance = 0x20008C,
        [Obsolete("Deprecated in favour of \"CreateClasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CLASSLINKAGE")]
        MessageIDCreateClasslinkage = 0x20008D,
        [Obsolete("Deprecated in favour of \"LiveClasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CLASSLINKAGE")]
        MessageIDLiveClasslinkage = 0x20008E,
        [Obsolete("Deprecated in favour of \"DestroyClasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CLASSLINKAGE")]
        MessageIDDestroyClasslinkage = 0x20008F,
        [Obsolete("Deprecated in favour of \"LiveDeviceWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICE_WIN7")]
        MessageIDLiveDeviceWin7 = 0x200090,
        [Obsolete("Deprecated in favour of \"LiveObjectSummaryWin7\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY_WIN7")]
        MessageIDLiveObjectSummaryWin7 = 0x200091,
        [Obsolete("Deprecated in favour of \"CreateComputeshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COMPUTESHADER")]
        MessageIDCreateComputeshader = 0x200092,
        [Obsolete("Deprecated in favour of \"LiveComputeshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COMPUTESHADER")]
        MessageIDLiveComputeshader = 0x200093,
        [Obsolete("Deprecated in favour of \"DestroyComputeshader\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COMPUTESHADER")]
        MessageIDDestroyComputeshader = 0x200094,
        [Obsolete("Deprecated in favour of \"CreateUnorderedaccessview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_UNORDEREDACCESSVIEW")]
        MessageIDCreateUnorderedaccessview = 0x200095,
        [Obsolete("Deprecated in favour of \"LiveUnorderedaccessview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_UNORDEREDACCESSVIEW")]
        MessageIDLiveUnorderedaccessview = 0x200096,
        [Obsolete("Deprecated in favour of \"DestroyUnorderedaccessview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_UNORDEREDACCESSVIEW")]
        MessageIDDestroyUnorderedaccessview = 0x200097,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInterfacesFeaturelevel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACES_FEATURELEVEL")]
        MessageIDDeviceSetshaderInterfacesFeaturelevel = 0x200098,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInterfaceCountMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACE_COUNT_MISMATCH")]
        MessageIDDeviceSetshaderInterfaceCountMismatch = 0x200099,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInvalidInstance\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE")]
        MessageIDDeviceSetshaderInvalidInstance = 0x20009A,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInvalidInstanceIndex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_INDEX")]
        MessageIDDeviceSetshaderInvalidInstanceIndex = 0x20009B,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInvalidInstanceType\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_TYPE")]
        MessageIDDeviceSetshaderInvalidInstanceType = 0x20009C,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInvalidInstanceData\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_DATA")]
        MessageIDDeviceSetshaderInvalidInstanceData = 0x20009D,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderUnboundInstanceData\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_UNBOUND_INSTANCE_DATA")]
        MessageIDDeviceSetshaderUnboundInstanceData = 0x20009E,
        [Obsolete("Deprecated in favour of \"DeviceSetshaderInstanceDataBindings\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INSTANCE_DATA_BINDINGS")]
        MessageIDDeviceSetshaderInstanceDataBindings = 0x20009F,
        [Obsolete("Deprecated in favour of \"DeviceCreateshaderClasslinkageFull\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATESHADER_CLASSLINKAGE_FULL")]
        MessageIDDeviceCreateshaderClasslinkageFull = 0x2000A0,
        [Obsolete("Deprecated in favour of \"DeviceCheckfeaturesupportUnrecognizedFeature\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_UNRECOGNIZED_FEATURE")]
        MessageIDDeviceCheckfeaturesupportUnrecognizedFeature = 0x2000A1,
        [Obsolete("Deprecated in favour of \"DeviceCheckfeaturesupportMismatchedDataSize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE")]
        MessageIDDeviceCheckfeaturesupportMismatchedDataSize = 0x2000A2,
        [Obsolete("Deprecated in favour of \"DeviceCheckfeaturesupportInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_INVALIDARG_RETURN")]
        MessageIDDeviceCheckfeaturesupportInvalidargReturn = 0x2000A3,
        [Obsolete("Deprecated in favour of \"DeviceCssetshaderresourcesHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceCssetshaderresourcesHazard = 0x2000A4,
        [Obsolete("Deprecated in favour of \"DeviceCssetconstantbuffersHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceCssetconstantbuffersHazard = 0x2000A5,
        [Obsolete("Deprecated in favour of \"CssetshaderresourcesUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDCssetshaderresourcesUnbinddeletingobject = 0x2000A6,
        [Obsolete("Deprecated in favour of \"CssetconstantbuffersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDCssetconstantbuffersUnbinddeletingobject = 0x2000A7,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderInvalidcall\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCALL")]
        MessageIDCreatecomputeshaderInvalidcall = 0x2000A8,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY")]
        MessageIDCreatecomputeshaderOutofmemory = 0x2000A9,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatecomputeshaderInvalidshaderbytecode = 0x2000AA,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERTYPE")]
        MessageIDCreatecomputeshaderInvalidshadertype = 0x2000AB,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatecomputeshaderInvalidclasslinkage = 0x2000AC,
        [Obsolete("Deprecated in favour of \"DeviceCssetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceCssetshaderresourcesViewsEmpty = 0x2000AD,
        [Obsolete("Deprecated in favour of \"CssetconstantbuffersInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDCssetconstantbuffersInvalidbuffer = 0x2000AE,
        [Obsolete("Deprecated in favour of \"DeviceCssetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceCssetconstantbuffersBuffersEmpty = 0x2000AF,
        [Obsolete("Deprecated in favour of \"DeviceCssetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceCssetsamplersSamplersEmpty = 0x2000B0,
        [Obsolete("Deprecated in favour of \"DeviceCsgetshaderresourcesViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceCsgetshaderresourcesViewsEmpty = 0x2000B1,
        [Obsolete("Deprecated in favour of \"DeviceCsgetconstantbuffersBuffersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceCsgetconstantbuffersBuffersEmpty = 0x2000B2,
        [Obsolete("Deprecated in favour of \"DeviceCsgetsamplersSamplersEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceCsgetsamplersSamplersEmpty = 0x2000B3,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoublefloatopsnotsupported = 0x2000B4,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoublefloatopsnotsupported = 0x2000B5,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoublefloatopsnotsupported = 0x2000B6,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoublefloatopsnotsupported = 0x2000B7,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 0x2000B8,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoublefloatopsnotsupported = 0x2000B9,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoublefloatopsnotsupported = 0x2000BA,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidstructurestride\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSTRUCTURESTRIDE")]
        MessageIDCreatebufferInvalidstructurestride = 0x2000BB,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFLAGS")]
        MessageIDCreateshaderresourceviewInvalidflags = 0x2000BC,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE")]
        MessageIDCreateunorderedaccessviewInvalidresource = 0x2000BD,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvaliddesc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC")]
        MessageIDCreateunorderedaccessviewInvaliddesc = 0x2000BE,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT")]
        MessageIDCreateunorderedaccessviewInvalidformat = 0x2000BF,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvaliddimensions\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateunorderedaccessviewInvaliddimensions = 0x2000C0,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateunorderedaccessviewUnrecognizedformat = 0x2000C1,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsandunorderedaccessviewsHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_HAZARD")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsHazard = 0x2000C2,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsandunorderedaccessviewsOverlappingOldSlots\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_OVERLAPPING_OLD_SLOTS")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsOverlappingOldSlots = 0x2000C3,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsandunorderedaccessviewsNoOp\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NO_OP")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsNoOp = 0x2000C4,
        [Obsolete("Deprecated in favour of \"CssetunorderedaccessviewsUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT")]
        MessageIDCssetunorderedaccessviewsUnbinddeletingobject = 0x2000C5,
        [Obsolete("Deprecated in favour of \"PssetunorderedaccessviewsUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT")]
        MessageIDPssetunorderedaccessviewsUnbinddeletingobject = 0x2000C6,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDARG_RETURN")]
        MessageIDCreateunorderedaccessviewInvalidargReturn = 0x2000C7,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreateunorderedaccessviewOutofmemoryReturn = 0x2000C8,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_TOOMANYOBJECTS")]
        MessageIDCreateunorderedaccessviewToomanyobjects = 0x2000C9,
        [Obsolete("Deprecated in favour of \"DeviceCssetunorderedaccessviewsHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_HAZARD")]
        MessageIDDeviceCssetunorderedaccessviewsHazard = 0x2000CA,
        [Obsolete("Deprecated in favour of \"ClearunorderedaccessviewDenormflush\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_DENORMFLUSH")]
        MessageIDClearunorderedaccessviewDenormflush = 0x2000CB,
        [Obsolete("Deprecated in favour of \"DeviceCssetunorderedaccesssViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSS_VIEWS_EMPTY")]
        MessageIDDeviceCssetunorderedaccesssViewsEmpty = 0x2000CC,
        [Obsolete("Deprecated in favour of \"DeviceCsgetunorderedaccesssViewsEmpty\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETUNORDEREDACCESSS_VIEWS_EMPTY")]
        MessageIDDeviceCsgetunorderedaccesssViewsEmpty = 0x2000CD,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS")]
        MessageIDCreateunorderedaccessviewInvalidflags = 0x2000CE,
        [Obsolete("Deprecated in favour of \"CreateshaderresesourceviewToomanyobjects\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESESOURCEVIEW_TOOMANYOBJECTS")]
        MessageIDCreateshaderresesourceviewToomanyobjects = 0x2000CF,
        [Obsolete("Deprecated in favour of \"DeviceDispatchindirectInvalidArgBuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_INVALID_ARG_BUFFER")]
        MessageIDDeviceDispatchindirectInvalidArgBuffer = 0x2000D0,
        [Obsolete("Deprecated in favour of \"DeviceDispatchindirectOffsetUnaligned\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_UNALIGNED")]
        MessageIDDeviceDispatchindirectOffsetUnaligned = 0x2000D1,
        [Obsolete("Deprecated in favour of \"DeviceDispatchindirectOffsetOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_OVERFLOW")]
        MessageIDDeviceDispatchindirectOffsetOverflow = 0x2000D2,
        [Obsolete("Deprecated in favour of \"DeviceSetresourceminlodInvalidcontext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDCONTEXT")]
        MessageIDDeviceSetresourceminlodInvalidcontext = 0x2000D3,
        [Obsolete("Deprecated in favour of \"DeviceSetresourceminlodInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDRESOURCE")]
        MessageIDDeviceSetresourceminlodInvalidresource = 0x2000D4,
        [Obsolete("Deprecated in favour of \"DeviceSetresourceminlodInvalidminlod\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDMINLOD")]
        MessageIDDeviceSetresourceminlodInvalidminlod = 0x2000D5,
        [Obsolete("Deprecated in favour of \"DeviceGetresourceminlodInvalidcontext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDCONTEXT")]
        MessageIDDeviceGetresourceminlodInvalidcontext = 0x2000D6,
        [Obsolete("Deprecated in favour of \"DeviceGetresourceminlodInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDRESOURCE")]
        MessageIDDeviceGetresourceminlodInvalidresource = 0x2000D7,
        [Obsolete("Deprecated in favour of \"OmsetdepthstencilUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETDEPTHSTENCIL_UNBINDDELETINGOBJECT")]
        MessageIDOmsetdepthstencilUnbinddeletingobject = 0x2000D8,
        [Obsolete("Deprecated in favour of \"CleardepthstencilviewDepthReadonly\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DEPTH_READONLY")]
        MessageIDCleardepthstencilviewDepthReadonly = 0x2000D9,
        [Obsolete("Deprecated in favour of \"CleardepthstencilviewStencilReadonly\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_STENCIL_READONLY")]
        MessageIDCleardepthstencilviewStencilReadonly = 0x2000DA,
        [Obsolete("Deprecated in favour of \"CheckfeaturesupportFormatDeprecated\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFEATURESUPPORT_FORMAT_DEPRECATED")]
        MessageIDCheckfeaturesupportFormatDeprecated = 0x2000DB,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewReturnTypeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RETURN_TYPE_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewReturnTypeMismatch = 0x2000DC,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET")]
        MessageIDDeviceUnorderedaccessviewNotSet = 0x2000DD,
        [Obsolete("Deprecated in favour of \"DeviceDrawUnorderedaccessviewRendertargetviewOverlap\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_UNORDEREDACCESSVIEW_RENDERTARGETVIEW_OVERLAP")]
        MessageIDDeviceDrawUnorderedaccessviewRendertargetviewOverlap = 0x2000DE,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewDimensionMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_DIMENSION_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewDimensionMismatch = 0x2000DF,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAppendUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_APPEND_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAppendUnsupported = 0x2000E0,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicsUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMICS_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicsUnsupported = 0x2000E1,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewStructureStrideMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_STRUCTURE_STRIDE_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewStructureStrideMismatch = 0x2000E2,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewBufferTypeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_BUFFER_TYPE_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewBufferTypeMismatch = 0x2000E3,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewRawUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RAW_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewRawUnsupported = 0x2000E4,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewFormatLDUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_LD_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewFormatLDUnsupported = 0x2000E5,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewFormatStoreUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_STORE_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewFormatStoreUnsupported = 0x2000E6,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicAddUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_ADD_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicAddUnsupported = 0x2000E7,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicBitwiseOpsUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_BITWISE_OPS_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicBitwiseOpsUnsupported = 0x2000E8,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicCmpstoreCmpexchangeUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_CMPSTORE_CMPEXCHANGE_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicCmpstoreCmpexchangeUnsupported = 0x2000E9,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicExchangeUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_EXCHANGE_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicExchangeUnsupported = 0x2000EA,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicSignedMinmaxUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_SIGNED_MINMAX_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicSignedMinmaxUnsupported = 0x2000EB,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewAtomicUnsignedMinmaxUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_UNSIGNED_MINMAX_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicUnsignedMinmaxUnsupported = 0x2000EC,
        [Obsolete("Deprecated in favour of \"DeviceDispatchBoundResourceMapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_BOUND_RESOURCE_MAPPED")]
        MessageIDDeviceDispatchBoundResourceMapped = 0x2000ED,
        [Obsolete("Deprecated in favour of \"DeviceDispatchThreadgroupcountOverflow\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_OVERFLOW")]
        MessageIDDeviceDispatchThreadgroupcountOverflow = 0x2000EE,
        [Obsolete("Deprecated in favour of \"DeviceDispatchThreadgroupcountZero\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_ZERO")]
        MessageIDDeviceDispatchThreadgroupcountZero = 0x2000EF,
        [Obsolete("Deprecated in favour of \"DeviceShaderresourceviewStructureStrideMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_STRUCTURE_STRIDE_MISMATCH")]
        MessageIDDeviceShaderresourceviewStructureStrideMismatch = 0x2000F0,
        [Obsolete("Deprecated in favour of \"DeviceShaderresourceviewBufferTypeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_BUFFER_TYPE_MISMATCH")]
        MessageIDDeviceShaderresourceviewBufferTypeMismatch = 0x2000F1,
        [Obsolete("Deprecated in favour of \"DeviceShaderresourceviewRawUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_RAW_UNSUPPORTED")]
        MessageIDDeviceShaderresourceviewRawUnsupported = 0x2000F2,
        [Obsolete("Deprecated in favour of \"DeviceDispatchUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_UNSUPPORTED")]
        MessageIDDeviceDispatchUnsupported = 0x2000F3,
        [Obsolete("Deprecated in favour of \"DeviceDispatchindirectUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_UNSUPPORTED")]
        MessageIDDeviceDispatchindirectUnsupported = 0x2000F4,
        [Obsolete("Deprecated in favour of \"CopystructurecountInvalidoffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDOFFSET")]
        MessageIDCopystructurecountInvalidoffset = 0x2000F5,
        [Obsolete("Deprecated in favour of \"CopystructurecountLargeoffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_LARGEOFFSET")]
        MessageIDCopystructurecountLargeoffset = 0x2000F6,
        [Obsolete("Deprecated in favour of \"CopystructurecountInvaliddestinationstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDDESTINATIONSTATE")]
        MessageIDCopystructurecountInvaliddestinationstate = 0x2000F7,
        [Obsolete("Deprecated in favour of \"CopystructurecountInvalidsourcestate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDSOURCESTATE")]
        MessageIDCopystructurecountInvalidsourcestate = 0x2000F8,
        [Obsolete("Deprecated in favour of \"CheckformatsupportFormatNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_NOT_SUPPORTED")]
        MessageIDCheckformatsupportFormatNotSupported = 0x2000F9,
        [Obsolete("Deprecated in favour of \"DeviceCssetunorderedaccessviewsInvalidview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDVIEW")]
        MessageIDDeviceCssetunorderedaccessviewsInvalidview = 0x2000FA,
        [Obsolete("Deprecated in favour of \"DeviceCssetunorderedaccessviewsInvalidoffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDOFFSET")]
        MessageIDDeviceCssetunorderedaccessviewsInvalidoffset = 0x2000FB,
        [Obsolete("Deprecated in favour of \"DeviceCssetunorderedaccessviewsToomanyviews\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_TOOMANYVIEWS")]
        MessageIDDeviceCssetunorderedaccessviewsToomanyviews = 0x2000FC,
        [Obsolete("Deprecated in favour of \"ClearunorderedaccessviewfloatInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_INVALIDFORMAT")]
        MessageIDClearunorderedaccessviewfloatInvalidformat = 0x2000FD,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewCounterUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_COUNTER_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewCounterUnsupported = 0x2000FE,
        [Obsolete("Deprecated in favour of \"RefWarning\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING")]
        MessageIDRefWarning = 0x2000FF,
        [Obsolete("Deprecated in favour of \"DeviceDrawPixelShaderWithoutRtvOrDsv\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_PIXEL_SHADER_WITHOUT_RTV_OR_DSV")]
        MessageIDDeviceDrawPixelShaderWithoutRtvOrDsv = 0x200100,
        [Obsolete("Deprecated in favour of \"ShaderAbort\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_ABORT")]
        MessageIDShaderAbort = 0x200101,
        [Obsolete("Deprecated in favour of \"ShaderMessage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_MESSAGE")]
        MessageIDShaderMessage = 0x200102,
        [Obsolete("Deprecated in favour of \"ShaderError\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_ERROR")]
        MessageIDShaderError = 0x200103,
        [Obsolete("Deprecated in favour of \"OfferresourcesInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDRESOURCE")]
        MessageIDOfferresourcesInvalidresource = 0x200104,
        [Obsolete("Deprecated in favour of \"HssetsamplersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDHssetsamplersUnbinddeletingobject = 0x200105,
        [Obsolete("Deprecated in favour of \"DssetsamplersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDDssetsamplersUnbinddeletingobject = 0x200106,
        [Obsolete("Deprecated in favour of \"CssetsamplersUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDCssetsamplersUnbinddeletingobject = 0x200107,
        [Obsolete("Deprecated in favour of \"HssetshaderUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDHssetshaderUnbinddeletingobject = 0x200108,
        [Obsolete("Deprecated in favour of \"DssetshaderUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDDssetshaderUnbinddeletingobject = 0x200109,
        [Obsolete("Deprecated in favour of \"CssetshaderUnbinddeletingobject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDCssetshaderUnbinddeletingobject = 0x20010A,
        [Obsolete("Deprecated in favour of \"EnqueueseteventInvalidargReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_INVALIDARG_RETURN")]
        MessageIDEnqueueseteventInvalidargReturn = 0x20010B,
        [Obsolete("Deprecated in favour of \"EnqueueseteventOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_OUTOFMEMORY_RETURN")]
        MessageIDEnqueueseteventOutofmemoryReturn = 0x20010C,
        [Obsolete("Deprecated in favour of \"EnqueueseteventAccessdeniedReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_ACCESSDENIED_RETURN")]
        MessageIDEnqueueseteventAccessdeniedReturn = 0x20010D,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsandunorderedaccessviewsNumuavsInvalidrange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NUMUAVS_INVALIDRANGE")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsNumuavsInvalidrange = 0x20010E,
        [Obsolete("Deprecated in favour of \"UseOfZeroRefcountObject\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT")]
        MessageIDUseOfZeroRefcountObject = 0x20010F,
        [Obsolete("Deprecated in favour of \"D3D11MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_MESSAGES_END")]
        MessageIDD3D11MessagesEnd = 0x200110,
        [Obsolete("Deprecated in favour of \"D3D111MessagesStart\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_1_MESSAGES_START")]
        MessageIDD3D111MessagesStart = 0x300000,
        [Obsolete("Deprecated in favour of \"CreateVideodecoder\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEODECODER")]
        MessageIDCreateVideodecoder = 0x300001,
        [Obsolete("Deprecated in favour of \"CreateVideoprocessorenum\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSORENUM")]
        MessageIDCreateVideoprocessorenum = 0x300002,
        [Obsolete("Deprecated in favour of \"CreateVideoprocessor\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSOR")]
        MessageIDCreateVideoprocessor = 0x300003,
        [Obsolete("Deprecated in favour of \"CreateDecoderoutputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DECODEROUTPUTVIEW")]
        MessageIDCreateDecoderoutputview = 0x300004,
        [Obsolete("Deprecated in favour of \"CreateProcessorinputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PROCESSORINPUTVIEW")]
        MessageIDCreateProcessorinputview = 0x300005,
        [Obsolete("Deprecated in favour of \"CreateProcessoroutputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PROCESSOROUTPUTVIEW")]
        MessageIDCreateProcessoroutputview = 0x300006,
        [Obsolete("Deprecated in favour of \"CreateDevicecontextstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEVICECONTEXTSTATE")]
        MessageIDCreateDevicecontextstate = 0x300007,
        [Obsolete("Deprecated in favour of \"LiveVideodecoder\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEODECODER")]
        MessageIDLiveVideodecoder = 0x300008,
        [Obsolete("Deprecated in favour of \"LiveVideoprocessorenum\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSORENUM")]
        MessageIDLiveVideoprocessorenum = 0x300009,
        [Obsolete("Deprecated in favour of \"LiveVideoprocessor\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSOR")]
        MessageIDLiveVideoprocessor = 0x30000A,
        [Obsolete("Deprecated in favour of \"LiveDecoderoutputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DECODEROUTPUTVIEW")]
        MessageIDLiveDecoderoutputview = 0x30000B,
        [Obsolete("Deprecated in favour of \"LiveProcessorinputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PROCESSORINPUTVIEW")]
        MessageIDLiveProcessorinputview = 0x30000C,
        [Obsolete("Deprecated in favour of \"LiveProcessoroutputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PROCESSOROUTPUTVIEW")]
        MessageIDLiveProcessoroutputview = 0x30000D,
        [Obsolete("Deprecated in favour of \"LiveDevicecontextstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICECONTEXTSTATE")]
        MessageIDLiveDevicecontextstate = 0x30000E,
        [Obsolete("Deprecated in favour of \"DestroyVideodecoder\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEODECODER")]
        MessageIDDestroyVideodecoder = 0x30000F,
        [Obsolete("Deprecated in favour of \"DestroyVideoprocessorenum\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSORENUM")]
        MessageIDDestroyVideoprocessorenum = 0x300010,
        [Obsolete("Deprecated in favour of \"DestroyVideoprocessor\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSOR")]
        MessageIDDestroyVideoprocessor = 0x300011,
        [Obsolete("Deprecated in favour of \"DestroyDecoderoutputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DECODEROUTPUTVIEW")]
        MessageIDDestroyDecoderoutputview = 0x300012,
        [Obsolete("Deprecated in favour of \"DestroyProcessorinputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PROCESSORINPUTVIEW")]
        MessageIDDestroyProcessorinputview = 0x300013,
        [Obsolete("Deprecated in favour of \"DestroyProcessoroutputview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PROCESSOROUTPUTVIEW")]
        MessageIDDestroyProcessoroutputview = 0x300014,
        [Obsolete("Deprecated in favour of \"DestroyDevicecontextstate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEVICECONTEXTSTATE")]
        MessageIDDestroyDevicecontextstate = 0x300015,
        [Obsolete("Deprecated in favour of \"CreatedevicecontextstateInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFLAGS")]
        MessageIDCreatedevicecontextstateInvalidflags = 0x300016,
        [Obsolete("Deprecated in favour of \"CreatedevicecontextstateInvalidfeaturelevel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFEATURELEVEL")]
        MessageIDCreatedevicecontextstateInvalidfeaturelevel = 0x300017,
        [Obsolete("Deprecated in favour of \"CreatedevicecontextstateFeaturelevelsNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_FEATURELEVELS_NOT_SUPPORTED")]
        MessageIDCreatedevicecontextstateFeaturelevelsNotSupported = 0x300018,
        [Obsolete("Deprecated in favour of \"CreatedevicecontextstateInvalidrefiid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDREFIID")]
        MessageIDCreatedevicecontextstateInvalidrefiid = 0x300019,
        [Obsolete("Deprecated in favour of \"DeviceDiscardviewInvalidview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISCARDVIEW_INVALIDVIEW")]
        MessageIDDeviceDiscardviewInvalidview = 0x30001A,
        [Obsolete("Deprecated in favour of \"Copysubresourceregion1Invalidcopyflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION1_INVALIDCOPYFLAGS")]
        MessageIDCopysubresourceregion1Invalidcopyflags = 0x30001B,
        [Obsolete("Deprecated in favour of \"Updatesubresource1Invalidcopyflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE1_INVALIDCOPYFLAGS")]
        MessageIDUpdatesubresource1Invalidcopyflags = 0x30001C,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidforcedsamplecount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT")]
        MessageIDCreaterasterizerstateInvalidforcedsamplecount = 0x30001D,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideodecoderOutofmemoryReturn = 0x30001E,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_NULLPARAM")]
        MessageIDCreatevideodecoderNullparam = 0x30001F,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_INVALIDFORMAT")]
        MessageIDCreatevideodecoderInvalidformat = 0x300020,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderZerowidthheight\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_ZEROWIDTHHEIGHT")]
        MessageIDCreatevideodecoderZerowidthheight = 0x300021,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderDriverInvalidbuffersize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERSIZE")]
        MessageIDCreatevideodecoderDriverInvalidbuffersize = 0x300022,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderDriverInvalidbufferusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERUSAGE")]
        MessageIDCreatevideodecoderDriverInvalidbufferusage = 0x300023,
        [Obsolete("Deprecated in favour of \"GetvideodecoderprofilecountOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILECOUNT_OUTOFMEMORY")]
        MessageIDGetvideodecoderprofilecountOutofmemory = 0x300024,
        [Obsolete("Deprecated in favour of \"GetvideodecoderprofileNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_NULLPARAM")]
        MessageIDGetvideodecoderprofileNullparam = 0x300025,
        [Obsolete("Deprecated in favour of \"GetvideodecoderprofileInvalidindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_INVALIDINDEX")]
        MessageIDGetvideodecoderprofileInvalidindex = 0x300026,
        [Obsolete("Deprecated in favour of \"GetvideodecoderprofileOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_OUTOFMEMORY_RETURN")]
        MessageIDGetvideodecoderprofileOutofmemoryReturn = 0x300027,
        [Obsolete("Deprecated in favour of \"CheckvideodecoderformatNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_NULLPARAM")]
        MessageIDCheckvideodecoderformatNullparam = 0x300028,
        [Obsolete("Deprecated in favour of \"CheckvideodecoderformatOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_OUTOFMEMORY_RETURN")]
        MessageIDCheckvideodecoderformatOutofmemoryReturn = 0x300029,
        [Obsolete("Deprecated in favour of \"GetvideodecoderconfigcountNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_NULLPARAM")]
        MessageIDGetvideodecoderconfigcountNullparam = 0x30002A,
        [Obsolete("Deprecated in favour of \"GetvideodecoderconfigcountOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_OUTOFMEMORY_RETURN")]
        MessageIDGetvideodecoderconfigcountOutofmemoryReturn = 0x30002B,
        [Obsolete("Deprecated in favour of \"GetvideodecoderconfigNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_NULLPARAM")]
        MessageIDGetvideodecoderconfigNullparam = 0x30002C,
        [Obsolete("Deprecated in favour of \"GetvideodecoderconfigInvalidindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_INVALIDINDEX")]
        MessageIDGetvideodecoderconfigInvalidindex = 0x30002D,
        [Obsolete("Deprecated in favour of \"GetvideodecoderconfigOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_OUTOFMEMORY_RETURN")]
        MessageIDGetvideodecoderconfigOutofmemoryReturn = 0x30002E,
        [Obsolete("Deprecated in favour of \"GetdecodercreationparamsNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERCREATIONPARAMS_NULLPARAM")]
        MessageIDGetdecodercreationparamsNullparam = 0x30002F,
        [Obsolete("Deprecated in favour of \"GetdecoderdriverhandleNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERDRIVERHANDLE_NULLPARAM")]
        MessageIDGetdecoderdriverhandleNullparam = 0x300030,
        [Obsolete("Deprecated in favour of \"GetdecoderbufferNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_NULLPARAM")]
        MessageIDGetdecoderbufferNullparam = 0x300031,
        [Obsolete("Deprecated in favour of \"GetdecoderbufferInvalidbuffer\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDBUFFER")]
        MessageIDGetdecoderbufferInvalidbuffer = 0x300032,
        [Obsolete("Deprecated in favour of \"GetdecoderbufferInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDTYPE")]
        MessageIDGetdecoderbufferInvalidtype = 0x300033,
        [Obsolete("Deprecated in favour of \"GetdecoderbufferLocked\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_LOCKED")]
        MessageIDGetdecoderbufferLocked = 0x300034,
        [Obsolete("Deprecated in favour of \"ReleasedecoderbufferNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NULLPARAM")]
        MessageIDReleasedecoderbufferNullparam = 0x300035,
        [Obsolete("Deprecated in favour of \"ReleasedecoderbufferInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_INVALIDTYPE")]
        MessageIDReleasedecoderbufferInvalidtype = 0x300036,
        [Obsolete("Deprecated in favour of \"ReleasedecoderbufferNotlocked\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NOTLOCKED")]
        MessageIDReleasedecoderbufferNotlocked = 0x300037,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_NULLPARAM")]
        MessageIDDecoderbeginframeNullparam = 0x300038,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_HAZARD")]
        MessageIDDecoderbeginframeHazard = 0x300039,
        [Obsolete("Deprecated in favour of \"DecoderendframeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERENDFRAME_NULLPARAM")]
        MessageIDDecoderendframeNullparam = 0x30003A,
        [Obsolete("Deprecated in favour of \"SubmitdecoderbuffersNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_NULLPARAM")]
        MessageIDSubmitdecoderbuffersNullparam = 0x30003B,
        [Obsolete("Deprecated in favour of \"SubmitdecoderbuffersInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_INVALIDTYPE")]
        MessageIDSubmitdecoderbuffersInvalidtype = 0x30003C,
        [Obsolete("Deprecated in favour of \"DecoderextensionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODEREXTENSION_NULLPARAM")]
        MessageIDDecoderextensionNullparam = 0x30003D,
        [Obsolete("Deprecated in favour of \"DecoderextensionInvalidresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODEREXTENSION_INVALIDRESOURCE")]
        MessageIDDecoderextensionInvalidresource = 0x30003E,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessorenumeratorOutofmemoryReturn = 0x30003F,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_NULLPARAM")]
        MessageIDCreatevideoprocessorenumeratorNullparam = 0x300040,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorInvalidframeformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDFRAMEFORMAT")]
        MessageIDCreatevideoprocessorenumeratorInvalidframeformat = 0x300041,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorInvalidusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDUSAGE")]
        MessageIDCreatevideoprocessorenumeratorInvalidusage = 0x300042,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorInvalidinputframerate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDINPUTFRAMERATE")]
        MessageIDCreatevideoprocessorenumeratorInvalidinputframerate = 0x300043,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorInvalidoutputframerate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDOUTPUTFRAMERATE")]
        MessageIDCreatevideoprocessorenumeratorInvalidoutputframerate = 0x300044,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorenumeratorInvalidwidthheight\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDWIDTHHEIGHT")]
        MessageIDCreatevideoprocessorenumeratorInvalidwidthheight = 0x300045,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorcontentdescNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCONTENTDESC_NULLPARAM")]
        MessageIDGetvideoprocessorcontentdescNullparam = 0x300046,
        [Obsolete("Deprecated in favour of \"CheckvideoprocessorformatNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMAT_NULLPARAM")]
        MessageIDCheckvideoprocessorformatNullparam = 0x300047,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorcapsNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCAPS_NULLPARAM")]
        MessageIDGetvideoprocessorcapsNullparam = 0x300048,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorrateconversioncapsNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_NULLPARAM")]
        MessageIDGetvideoprocessorrateconversioncapsNullparam = 0x300049,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorrateconversioncapsInvalidindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_INVALIDINDEX")]
        MessageIDGetvideoprocessorrateconversioncapsInvalidindex = 0x30004A,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorcustomrateNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_NULLPARAM")]
        MessageIDGetvideoprocessorcustomrateNullparam = 0x30004B,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorcustomrateInvalidindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_INVALIDINDEX")]
        MessageIDGetvideoprocessorcustomrateInvalidindex = 0x30004C,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorfilterrangeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_NULLPARAM")]
        MessageIDGetvideoprocessorfilterrangeNullparam = 0x30004D,
        [Obsolete("Deprecated in favour of \"GetvideoprocessorfilterrangeUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_UNSUPPORTED")]
        MessageIDGetvideoprocessorfilterrangeUnsupported = 0x30004E,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessorOutofmemoryReturn = 0x30004F,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_NULLPARAM")]
        MessageIDCreatevideoprocessorNullparam = 0x300050,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputtargetrectNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTTARGETRECT_NULLPARAM")]
        MessageIDVideoprocessorsetoutputtargetrectNullparam = 0x300051,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputbackgroundcolorNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_NULLPARAM")]
        MessageIDVideoprocessorsetoutputbackgroundcolorNullparam = 0x300052,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputbackgroundcolorInvalidalpha\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_INVALIDALPHA")]
        MessageIDVideoprocessorsetoutputbackgroundcolorInvalidalpha = 0x300053,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputcolorspaceNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputcolorspaceNullparam = 0x300054,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputalphafillmodeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputalphafillmodeNullparam = 0x300055,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputalphafillmodeUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_UNSUPPORTED")]
        MessageIDVideoprocessorsetoutputalphafillmodeUnsupported = 0x300056,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputalphafillmodeInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetoutputalphafillmodeInvalidstream = 0x300057,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputalphafillmodeInvalidfillmode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDFILLMODE")]
        MessageIDVideoprocessorsetoutputalphafillmodeInvalidfillmode = 0x300058,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputconstrictionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_NULLPARAM")]
        MessageIDVideoprocessorsetoutputconstrictionNullparam = 0x300059,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputstereomodeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputstereomodeNullparam = 0x30005A,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputstereomodeUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_UNSUPPORTED")]
        MessageIDVideoprocessorsetoutputstereomodeUnsupported = 0x30005B,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputextensionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorsetoutputextensionNullparam = 0x30005C,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputtargetrectNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTTARGETRECT_NULLPARAM")]
        MessageIDVideoprocessorgetoutputtargetrectNullparam = 0x30005D,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputbackgroundcolorNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTBACKGROUNDCOLOR_NULLPARAM")]
        MessageIDVideoprocessorgetoutputbackgroundcolorNullparam = 0x30005E,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputcolorspaceNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputcolorspaceNullparam = 0x30005F,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputalphafillmodeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTALPHAFILLMODE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputalphafillmodeNullparam = 0x300060,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputconstrictionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCONSTRICTION_NULLPARAM")]
        MessageIDVideoprocessorgetoutputconstrictionNullparam = 0x300061,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputconstrictionUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_UNSUPPORTED")]
        MessageIDVideoprocessorsetoutputconstrictionUnsupported = 0x300062,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputconstrictionInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_INVALIDSIZE")]
        MessageIDVideoprocessorsetoutputconstrictionInvalidsize = 0x300063,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputstereomodeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSTEREOMODE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputstereomodeNullparam = 0x300064,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputextensionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorgetoutputextensionNullparam = 0x300065,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamframeformatNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamframeformatNullparam = 0x300066,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamframeformatInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDFORMAT")]
        MessageIDVideoprocessorsetstreamframeformatInvalidformat = 0x300067,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamframeformatInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamframeformatInvalidstream = 0x300068,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamcolorspaceNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorsetstreamcolorspaceNullparam = 0x300069,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamcolorspaceInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamcolorspaceInvalidstream = 0x30006A,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamoutputrateNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_NULLPARAM")]
        MessageIDVideoprocessorsetstreamoutputrateNullparam = 0x30006B,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamoutputrateInvalidrate\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDRATE")]
        MessageIDVideoprocessorsetstreamoutputrateInvalidrate = 0x30006C,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamoutputrateInvalidflag\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDFLAG")]
        MessageIDVideoprocessorsetstreamoutputrateInvalidflag = 0x30006D,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamoutputrateInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamoutputrateInvalidstream = 0x30006E,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamsourcerectNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamsourcerectNullparam = 0x30006F,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamsourcerectInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamsourcerectInvalidstream = 0x300070,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamsourcerectInvalidrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDRECT")]
        MessageIDVideoprocessorsetstreamsourcerectInvalidrect = 0x300071,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamdestrectNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamdestrectNullparam = 0x300072,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamdestrectInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamdestrectInvalidstream = 0x300073,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamdestrectInvalidrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDRECT")]
        MessageIDVideoprocessorsetstreamdestrectInvalidrect = 0x300074,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamalphaNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_NULLPARAM")]
        MessageIDVideoprocessorsetstreamalphaNullparam = 0x300075,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamalphaInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamalphaInvalidstream = 0x300076,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamalphaInvalidalpha\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDALPHA")]
        MessageIDVideoprocessorsetstreamalphaInvalidalpha = 0x300077,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampaletteNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_NULLPARAM")]
        MessageIDVideoprocessorsetstreampaletteNullparam = 0x300078,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampaletteInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreampaletteInvalidstream = 0x300079,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampaletteInvalidcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDCOUNT")]
        MessageIDVideoprocessorsetstreampaletteInvalidcount = 0x30007A,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampaletteInvalidalpha\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDALPHA")]
        MessageIDVideoprocessorsetstreampaletteInvalidalpha = 0x30007B,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampixelaspectratioNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_NULLPARAM")]
        MessageIDVideoprocessorsetstreampixelaspectratioNullparam = 0x30007C,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampixelaspectratioInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreampixelaspectratioInvalidstream = 0x30007D,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampixelaspectratioInvalidratio\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDRATIO")]
        MessageIDVideoprocessorsetstreampixelaspectratioInvalidratio = 0x30007E,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamlumakeyNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_NULLPARAM")]
        MessageIDVideoprocessorsetstreamlumakeyNullparam = 0x30007F,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamlumakeyInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamlumakeyInvalidstream = 0x300080,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamlumakeyInvalidrange\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDRANGE")]
        MessageIDVideoprocessorsetstreamlumakeyInvalidrange = 0x300081,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamlumakeyUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamlumakeyUnsupported = 0x300082,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamstereoformatNullparam = 0x300083,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamstereoformatInvalidstream = 0x300084,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatUnsupported = 0x300085,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatFlipunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FLIPUNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatFlipunsupported = 0x300086,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatMonooffsetunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_MONOOFFSETUNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatMonooffsetunsupported = 0x300087,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatFormatunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FORMATUNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatFormatunsupported = 0x300088,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamstereoformatInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDFORMAT")]
        MessageIDVideoprocessorsetstreamstereoformatInvalidformat = 0x300089,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamautoprocessingmodeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_NULLPARAM")]
        MessageIDVideoprocessorsetstreamautoprocessingmodeNullparam = 0x30008A,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamautoprocessingmodeInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamautoprocessingmodeInvalidstream = 0x30008B,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamfilterNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_NULLPARAM")]
        MessageIDVideoprocessorsetstreamfilterNullparam = 0x30008C,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamfilterInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamfilterInvalidstream = 0x30008D,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamfilterInvalidfilter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDFILTER")]
        MessageIDVideoprocessorsetstreamfilterInvalidfilter = 0x30008E,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamfilterUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamfilterUnsupported = 0x30008F,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamfilterInvalidlevel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDLEVEL")]
        MessageIDVideoprocessorsetstreamfilterInvalidlevel = 0x300090,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamextensionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorsetstreamextensionNullparam = 0x300091,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamextensionInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamextensionInvalidstream = 0x300092,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamframeformatNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamframeformatNullparam = 0x300093,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamcolorspaceNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorgetstreamcolorspaceNullparam = 0x300094,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamoutputrateNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_NULLPARAM")]
        MessageIDVideoprocessorgetstreamoutputrateNullparam = 0x300095,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamsourcerectNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamsourcerectNullparam = 0x300096,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamdestrectNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamdestrectNullparam = 0x300097,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamalphaNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_NULLPARAM")]
        MessageIDVideoprocessorgetstreamalphaNullparam = 0x300098,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreampaletteNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_NULLPARAM")]
        MessageIDVideoprocessorgetstreampaletteNullparam = 0x300099,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreampixelaspectratioNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_NULLPARAM")]
        MessageIDVideoprocessorgetstreampixelaspectratioNullparam = 0x30009A,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamlumakeyNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_NULLPARAM")]
        MessageIDVideoprocessorgetstreamlumakeyNullparam = 0x30009B,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamstereoformatNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamstereoformatNullparam = 0x30009C,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamautoprocessingmodeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_NULLPARAM")]
        MessageIDVideoprocessorgetstreamautoprocessingmodeNullparam = 0x30009D,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamfilterNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_NULLPARAM")]
        MessageIDVideoprocessorgetstreamfilterNullparam = 0x30009E,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamextensionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorgetstreamextensionNullparam = 0x30009F,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamextensionInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamextensionInvalidstream = 0x3000A0,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NULLPARAM")]
        MessageIDVideoprocessorbltNullparam = 0x3000A1,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidstreamcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSTREAMCOUNT")]
        MessageIDVideoprocessorbltInvalidstreamcount = 0x3000A2,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltTargetrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_TARGETRECT")]
        MessageIDVideoprocessorbltTargetrect = 0x3000A3,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidoutput\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDOUTPUT")]
        MessageIDVideoprocessorbltInvalidoutput = 0x3000A4,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidpastframes\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDPASTFRAMES")]
        MessageIDVideoprocessorbltInvalidpastframes = 0x3000A5,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidfutureframes\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDFUTUREFRAMES")]
        MessageIDVideoprocessorbltInvalidfutureframes = 0x3000A6,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidsourcerect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSOURCERECT")]
        MessageIDVideoprocessorbltInvalidsourcerect = 0x3000A7,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvaliddestrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDDESTRECT")]
        MessageIDVideoprocessorbltInvaliddestrect = 0x3000A8,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidinputresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDINPUTRESOURCE")]
        MessageIDVideoprocessorbltInvalidinputresource = 0x3000A9,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidarraysize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAYSIZE")]
        MessageIDVideoprocessorbltInvalidarraysize = 0x3000AA,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidarray\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAY")]
        MessageIDVideoprocessorbltInvalidarray = 0x3000AB,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltRightexpected\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTEXPECTED")]
        MessageIDVideoprocessorbltRightexpected = 0x3000AC,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltRightnotexpected\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTNOTEXPECTED")]
        MessageIDVideoprocessorbltRightnotexpected = 0x3000AD,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltStereonotenabled\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_STEREONOTENABLED")]
        MessageIDVideoprocessorbltStereonotenabled = 0x3000AE,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInvalidrightresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDRIGHTRESOURCE")]
        MessageIDVideoprocessorbltInvalidrightresource = 0x3000AF,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltNostereostreams\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NOSTEREOSTREAMS")]
        MessageIDVideoprocessorbltNostereostreams = 0x3000B0,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltInputhazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INPUTHAZARD")]
        MessageIDVideoprocessorbltInputhazard = 0x3000B1,
        [Obsolete("Deprecated in favour of \"VideoprocessorbltOutputhazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_OUTPUTHAZARD")]
        MessageIDVideoprocessorbltOutputhazard = 0x3000B2,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideodecoderoutputviewOutofmemoryReturn = 0x3000B3,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_NULLPARAM")]
        MessageIDCreatevideodecoderoutputviewNullparam = 0x3000B4,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDTYPE")]
        MessageIDCreatevideodecoderoutputviewInvalidtype = 0x3000B5,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewInvalidbind\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDBIND")]
        MessageIDCreatevideodecoderoutputviewInvalidbind = 0x3000B6,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewUnsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEDFORMAT")]
        MessageIDCreatevideodecoderoutputviewUnsupportedformat = 0x3000B7,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewInvalidmip\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDMIP")]
        MessageIDCreatevideodecoderoutputviewInvalidmip = 0x3000B8,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewUnsupportemip\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEMIP")]
        MessageIDCreatevideodecoderoutputviewUnsupportemip = 0x3000B9,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewInvalidarraysize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAYSIZE")]
        MessageIDCreatevideodecoderoutputviewInvalidarraysize = 0x3000BA,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewInvalidarray\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAY")]
        MessageIDCreatevideodecoderoutputviewInvalidarray = 0x3000BB,
        [Obsolete("Deprecated in favour of \"CreatevideodecoderoutputviewInvaliddimension\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDDIMENSION")]
        MessageIDCreatevideodecoderoutputviewInvaliddimension = 0x3000BC,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessorinputviewOutofmemoryReturn = 0x3000BD,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_NULLPARAM")]
        MessageIDCreatevideoprocessorinputviewNullparam = 0x3000BE,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDTYPE")]
        MessageIDCreatevideoprocessorinputviewInvalidtype = 0x3000BF,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidbind\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDBIND")]
        MessageIDCreatevideoprocessorinputviewInvalidbind = 0x3000C0,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidmisc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMISC")]
        MessageIDCreatevideoprocessorinputviewInvalidmisc = 0x3000C1,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDUSAGE")]
        MessageIDCreatevideoprocessorinputviewInvalidusage = 0x3000C2,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFORMAT")]
        MessageIDCreatevideoprocessorinputviewInvalidformat = 0x3000C3,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidfourcc\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFOURCC")]
        MessageIDCreatevideoprocessorinputviewInvalidfourcc = 0x3000C4,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidmip\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMIP")]
        MessageIDCreatevideoprocessorinputviewInvalidmip = 0x3000C5,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewUnsupportedmip\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_UNSUPPORTEDMIP")]
        MessageIDCreatevideoprocessorinputviewUnsupportedmip = 0x3000C6,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidarraysize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAYSIZE")]
        MessageIDCreatevideoprocessorinputviewInvalidarraysize = 0x3000C7,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidarray\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAY")]
        MessageIDCreatevideoprocessorinputviewInvalidarray = 0x3000C8,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvaliddimension\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDDIMENSION")]
        MessageIDCreatevideoprocessorinputviewInvaliddimension = 0x3000C9,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessoroutputviewOutofmemoryReturn = 0x3000CA,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_NULLPARAM")]
        MessageIDCreatevideoprocessoroutputviewNullparam = 0x3000CB,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDTYPE")]
        MessageIDCreatevideoprocessoroutputviewInvalidtype = 0x3000CC,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvalidbind\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDBIND")]
        MessageIDCreatevideoprocessoroutputviewInvalidbind = 0x3000CD,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvalidformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDFORMAT")]
        MessageIDCreatevideoprocessoroutputviewInvalidformat = 0x3000CE,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvalidmip\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMIP")]
        MessageIDCreatevideoprocessoroutputviewInvalidmip = 0x3000CF,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewUnsupportedmip\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDMIP")]
        MessageIDCreatevideoprocessoroutputviewUnsupportedmip = 0x3000D0,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewUnsupportedarray\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDARRAY")]
        MessageIDCreatevideoprocessoroutputviewUnsupportedarray = 0x3000D1,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvalidarray\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDARRAY")]
        MessageIDCreatevideoprocessoroutputviewInvalidarray = 0x3000D2,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvaliddimension\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDDIMENSION")]
        MessageIDCreatevideoprocessoroutputviewInvaliddimension = 0x3000D3,
        [Obsolete("Deprecated in favour of \"DeviceDrawInvalidUseOfForcedSampleCount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_FORCED_SAMPLE_COUNT")]
        MessageIDDeviceDrawInvalidUseOfForcedSampleCount = 0x3000D4,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidlogicops\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS")]
        MessageIDCreateblendstateInvalidlogicops = 0x3000D5,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvaliddarraywithdecoder\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDARRAYWITHDECODER")]
        MessageIDCreateshaderresourceviewInvaliddarraywithdecoder = 0x3000D6,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvaliddarraywithdecoder\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDARRAYWITHDECODER")]
        MessageIDCreateunorderedaccessviewInvaliddarraywithdecoder = 0x3000D7,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvaliddarraywithdecoder\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDARRAYWITHDECODER")]
        MessageIDCreaterendertargetviewInvaliddarraywithdecoder = 0x3000D8,
        [Obsolete("Deprecated in favour of \"DeviceLockedoutInterface\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_LOCKEDOUT_INTERFACE")]
        MessageIDDeviceLockedoutInterface = 0x3000D9,
        [Obsolete("Deprecated in favour of \"RefWarningAtomicInconsistent\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_ATOMIC_INCONSISTENT")]
        MessageIDRefWarningAtomicInconsistent = 0x3000DA,
        [Obsolete("Deprecated in favour of \"RefWarningReadingUninitializedResource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_READING_UNINITIALIZED_RESOURCE")]
        MessageIDRefWarningReadingUninitializedResource = 0x3000DB,
        [Obsolete("Deprecated in favour of \"RefWarningRawHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_RAW_HAZARD")]
        MessageIDRefWarningRawHazard = 0x3000DC,
        [Obsolete("Deprecated in favour of \"RefWarningWarHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_WAR_HAZARD")]
        MessageIDRefWarningWarHazard = 0x3000DD,
        [Obsolete("Deprecated in favour of \"RefWarningWawHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_WAW_HAZARD")]
        MessageIDRefWarningWawHazard = 0x3000DE,
        [Obsolete("Deprecated in favour of \"CreatecryptosessionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECRYPTOSESSION_NULLPARAM")]
        MessageIDCreatecryptosessionNullparam = 0x3000DF,
        [Obsolete("Deprecated in favour of \"CreatecryptosessionOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECRYPTOSESSION_OUTOFMEMORY_RETURN")]
        MessageIDCreatecryptosessionOutofmemoryReturn = 0x3000E0,
        [Obsolete("Deprecated in favour of \"GetcryptotypeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOTYPE_NULLPARAM")]
        MessageIDGetcryptotypeNullparam = 0x3000E1,
        [Obsolete("Deprecated in favour of \"GetdecoderprofileNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERPROFILE_NULLPARAM")]
        MessageIDGetdecoderprofileNullparam = 0x3000E2,
        [Obsolete("Deprecated in favour of \"GetcryptosessioncertificatesizeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATESIZE_NULLPARAM")]
        MessageIDGetcryptosessioncertificatesizeNullparam = 0x3000E3,
        [Obsolete("Deprecated in favour of \"GetcryptosessioncertificateNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_NULLPARAM")]
        MessageIDGetcryptosessioncertificateNullparam = 0x3000E4,
        [Obsolete("Deprecated in favour of \"GetcryptosessioncertificateWrongsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_WRONGSIZE")]
        MessageIDGetcryptosessioncertificateWrongsize = 0x3000E5,
        [Obsolete("Deprecated in favour of \"GetcryptosessionhandleWrongsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_WRONGSIZE")]
        MessageIDGetcryptosessionhandleWrongsize = 0x3000E6,
        [Obsolete("Deprecated in favour of \"NegotiatecrpytosessionkeyexchangeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_NULLPARAM")]
        MessageIDNegotiatecrpytosessionkeyexchangeNullparam = 0x3000E7,
        [Obsolete("Deprecated in favour of \"EncryptionbltUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_UNSUPPORTED")]
        MessageIDEncryptionbltUnsupported = 0x3000E8,
        [Obsolete("Deprecated in favour of \"EncryptionbltNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_NULLPARAM")]
        MessageIDEncryptionbltNullparam = 0x3000E9,
        [Obsolete("Deprecated in favour of \"EncryptionbltSrcWrongdevice\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_WRONGDEVICE")]
        MessageIDEncryptionbltSrcWrongdevice = 0x3000EA,
        [Obsolete("Deprecated in favour of \"EncryptionbltDstWrongdevice\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_WRONGDEVICE")]
        MessageIDEncryptionbltDstWrongdevice = 0x3000EB,
        [Obsolete("Deprecated in favour of \"EncryptionbltFormatMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_FORMAT_MISMATCH")]
        MessageIDEncryptionbltFormatMismatch = 0x3000EC,
        [Obsolete("Deprecated in favour of \"EncryptionbltSizeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SIZE_MISMATCH")]
        MessageIDEncryptionbltSizeMismatch = 0x3000ED,
        [Obsolete("Deprecated in favour of \"EncryptionbltSrcMultisampled\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MULTISAMPLED")]
        MessageIDEncryptionbltSrcMultisampled = 0x3000EE,
        [Obsolete("Deprecated in favour of \"EncryptionbltDstNotStaging\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_NOT_STAGING")]
        MessageIDEncryptionbltDstNotStaging = 0x3000EF,
        [Obsolete("Deprecated in favour of \"EncryptionbltSrcMapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MAPPED")]
        MessageIDEncryptionbltSrcMapped = 0x3000F0,
        [Obsolete("Deprecated in favour of \"EncryptionbltDstMapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_MAPPED")]
        MessageIDEncryptionbltDstMapped = 0x3000F1,
        [Obsolete("Deprecated in favour of \"EncryptionbltSrcOffered\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_OFFERED")]
        MessageIDEncryptionbltSrcOffered = 0x3000F2,
        [Obsolete("Deprecated in favour of \"EncryptionbltDstOffered\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_OFFERED")]
        MessageIDEncryptionbltDstOffered = 0x3000F3,
        [Obsolete("Deprecated in favour of \"EncryptionbltSrcContentUndefined\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_CONTENT_UNDEFINED")]
        MessageIDEncryptionbltSrcContentUndefined = 0x3000F4,
        [Obsolete("Deprecated in favour of \"DecryptionbltUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_UNSUPPORTED")]
        MessageIDDecryptionbltUnsupported = 0x3000F5,
        [Obsolete("Deprecated in favour of \"DecryptionbltNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_NULLPARAM")]
        MessageIDDecryptionbltNullparam = 0x3000F6,
        [Obsolete("Deprecated in favour of \"DecryptionbltSrcWrongdevice\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_WRONGDEVICE")]
        MessageIDDecryptionbltSrcWrongdevice = 0x3000F7,
        [Obsolete("Deprecated in favour of \"DecryptionbltDstWrongdevice\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_WRONGDEVICE")]
        MessageIDDecryptionbltDstWrongdevice = 0x3000F8,
        [Obsolete("Deprecated in favour of \"DecryptionbltFormatMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_FORMAT_MISMATCH")]
        MessageIDDecryptionbltFormatMismatch = 0x3000F9,
        [Obsolete("Deprecated in favour of \"DecryptionbltSizeMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SIZE_MISMATCH")]
        MessageIDDecryptionbltSizeMismatch = 0x3000FA,
        [Obsolete("Deprecated in favour of \"DecryptionbltDstMultisampled\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MULTISAMPLED")]
        MessageIDDecryptionbltDstMultisampled = 0x3000FB,
        [Obsolete("Deprecated in favour of \"DecryptionbltSrcNotStaging\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_NOT_STAGING")]
        MessageIDDecryptionbltSrcNotStaging = 0x3000FC,
        [Obsolete("Deprecated in favour of \"DecryptionbltDstNotRenderTarget\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_NOT_RENDER_TARGET")]
        MessageIDDecryptionbltDstNotRenderTarget = 0x3000FD,
        [Obsolete("Deprecated in favour of \"DecryptionbltSrcMapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_MAPPED")]
        MessageIDDecryptionbltSrcMapped = 0x3000FE,
        [Obsolete("Deprecated in favour of \"DecryptionbltDstMapped\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MAPPED")]
        MessageIDDecryptionbltDstMapped = 0x3000FF,
        [Obsolete("Deprecated in favour of \"DecryptionbltSrcOffered\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_OFFERED")]
        MessageIDDecryptionbltSrcOffered = 0x300100,
        [Obsolete("Deprecated in favour of \"DecryptionbltDstOffered\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_OFFERED")]
        MessageIDDecryptionbltDstOffered = 0x300101,
        [Obsolete("Deprecated in favour of \"DecryptionbltSrcContentUndefined\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_CONTENT_UNDEFINED")]
        MessageIDDecryptionbltSrcContentUndefined = 0x300102,
        [Obsolete("Deprecated in favour of \"StartsessionkeyrefreshNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_NULLPARAM")]
        MessageIDStartsessionkeyrefreshNullparam = 0x300103,
        [Obsolete("Deprecated in favour of \"StartsessionkeyrefreshInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_INVALIDSIZE")]
        MessageIDStartsessionkeyrefreshInvalidsize = 0x300104,
        [Obsolete("Deprecated in favour of \"FinishsessionkeyrefreshNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHSESSIONKEYREFRESH_NULLPARAM")]
        MessageIDFinishsessionkeyrefreshNullparam = 0x300105,
        [Obsolete("Deprecated in favour of \"GetencryptionbltkeyNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_NULLPARAM")]
        MessageIDGetencryptionbltkeyNullparam = 0x300106,
        [Obsolete("Deprecated in favour of \"GetencryptionbltkeyInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_INVALIDSIZE")]
        MessageIDGetencryptionbltkeyInvalidsize = 0x300107,
        [Obsolete("Deprecated in favour of \"GetcontentprotectioncapsNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCONTENTPROTECTIONCAPS_NULLPARAM")]
        MessageIDGetcontentprotectioncapsNullparam = 0x300108,
        [Obsolete("Deprecated in favour of \"CheckcryptokeyexchangeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_NULLPARAM")]
        MessageIDCheckcryptokeyexchangeNullparam = 0x300109,
        [Obsolete("Deprecated in favour of \"CheckcryptokeyexchangeInvalidindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_INVALIDINDEX")]
        MessageIDCheckcryptokeyexchangeInvalidindex = 0x30010A,
        [Obsolete("Deprecated in favour of \"CreateauthenticatedchannelNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_NULLPARAM")]
        MessageIDCreateauthenticatedchannelNullparam = 0x30010B,
        [Obsolete("Deprecated in favour of \"CreateauthenticatedchannelUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_UNSUPPORTED")]
        MessageIDCreateauthenticatedchannelUnsupported = 0x30010C,
        [Obsolete("Deprecated in favour of \"CreateauthenticatedchannelInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_INVALIDTYPE")]
        MessageIDCreateauthenticatedchannelInvalidtype = 0x30010D,
        [Obsolete("Deprecated in favour of \"CreateauthenticatedchannelOutofmemoryReturn\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_OUTOFMEMORY_RETURN")]
        MessageIDCreateauthenticatedchannelOutofmemoryReturn = 0x30010E,
        [Obsolete("Deprecated in favour of \"GetauthenticatedchannelcertificatesizeInvalidchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_INVALIDCHANNEL")]
        MessageIDGetauthenticatedchannelcertificatesizeInvalidchannel = 0x30010F,
        [Obsolete("Deprecated in favour of \"GetauthenticatedchannelcertificatesizeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_NULLPARAM")]
        MessageIDGetauthenticatedchannelcertificatesizeNullparam = 0x300110,
        [Obsolete("Deprecated in favour of \"GetauthenticatedchannelcertificateInvalidchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_INVALIDCHANNEL")]
        MessageIDGetauthenticatedchannelcertificateInvalidchannel = 0x300111,
        [Obsolete("Deprecated in favour of \"GetauthenticatedchannelcertificateNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_NULLPARAM")]
        MessageIDGetauthenticatedchannelcertificateNullparam = 0x300112,
        [Obsolete("Deprecated in favour of \"GetauthenticatedchannelcertificateWrongsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_WRONGSIZE")]
        MessageIDGetauthenticatedchannelcertificateWrongsize = 0x300113,
        [Obsolete("Deprecated in favour of \"NegotiateauthenticatedchannelkeyexchangeInvalidchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDCHANNEL")]
        MessageIDNegotiateauthenticatedchannelkeyexchangeInvalidchannel = 0x300114,
        [Obsolete("Deprecated in favour of \"NegotiateauthenticatedchannelkeyexchangeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_NULLPARAM")]
        MessageIDNegotiateauthenticatedchannelkeyexchangeNullparam = 0x300115,
        [Obsolete("Deprecated in favour of \"QueryauthenticatedchannelNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_NULLPARAM")]
        MessageIDQueryauthenticatedchannelNullparam = 0x300116,
        [Obsolete("Deprecated in favour of \"QueryauthenticatedchannelWrongchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGCHANNEL")]
        MessageIDQueryauthenticatedchannelWrongchannel = 0x300117,
        [Obsolete("Deprecated in favour of \"QueryauthenticatedchannelUnsupportedquery\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_UNSUPPORTEDQUERY")]
        MessageIDQueryauthenticatedchannelUnsupportedquery = 0x300118,
        [Obsolete("Deprecated in favour of \"QueryauthenticatedchannelWrongsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGSIZE")]
        MessageIDQueryauthenticatedchannelWrongsize = 0x300119,
        [Obsolete("Deprecated in favour of \"QueryauthenticatedchannelInvalidprocessindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_INVALIDPROCESSINDEX")]
        MessageIDQueryauthenticatedchannelInvalidprocessindex = 0x30011A,
        [Obsolete("Deprecated in favour of \"ConfigureauthenticatedchannelNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_NULLPARAM")]
        MessageIDConfigureauthenticatedchannelNullparam = 0x30011B,
        [Obsolete("Deprecated in favour of \"ConfigureauthenticatedchannelWrongchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGCHANNEL")]
        MessageIDConfigureauthenticatedchannelWrongchannel = 0x30011C,
        [Obsolete("Deprecated in favour of \"ConfigureauthenticatedchannelUnsupportedconfigure\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_UNSUPPORTEDCONFIGURE")]
        MessageIDConfigureauthenticatedchannelUnsupportedconfigure = 0x30011D,
        [Obsolete("Deprecated in favour of \"ConfigureauthenticatedchannelWrongsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGSIZE")]
        MessageIDConfigureauthenticatedchannelWrongsize = 0x30011E,
        [Obsolete("Deprecated in favour of \"ConfigureauthenticatedchannelInvalidprocessidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_INVALIDPROCESSIDTYPE")]
        MessageIDConfigureauthenticatedchannelInvalidprocessidtype = 0x30011F,
        [Obsolete("Deprecated in favour of \"VssetconstantbuffersInvalidbufferoffsetorcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDVssetconstantbuffersInvalidbufferoffsetorcount = 0x300120,
        [Obsolete("Deprecated in favour of \"DssetconstantbuffersInvalidbufferoffsetorcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDDssetconstantbuffersInvalidbufferoffsetorcount = 0x300121,
        [Obsolete("Deprecated in favour of \"HssetconstantbuffersInvalidbufferoffsetorcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDHssetconstantbuffersInvalidbufferoffsetorcount = 0x300122,
        [Obsolete("Deprecated in favour of \"GssetconstantbuffersInvalidbufferoffsetorcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDGssetconstantbuffersInvalidbufferoffsetorcount = 0x300123,
        [Obsolete("Deprecated in favour of \"PssetconstantbuffersInvalidbufferoffsetorcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDPssetconstantbuffersInvalidbufferoffsetorcount = 0x300124,
        [Obsolete("Deprecated in favour of \"CssetconstantbuffersInvalidbufferoffsetorcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDCssetconstantbuffersInvalidbufferoffsetorcount = 0x300125,
        [Obsolete("Deprecated in favour of \"NegotiatecrpytosessionkeyexchangeInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_INVALIDSIZE")]
        MessageIDNegotiatecrpytosessionkeyexchangeInvalidsize = 0x300126,
        [Obsolete("Deprecated in favour of \"NegotiateauthenticatedchannelkeyexchangeInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDSIZE")]
        MessageIDNegotiateauthenticatedchannelkeyexchangeInvalidsize = 0x300127,
        [Obsolete("Deprecated in favour of \"OfferresourcesInvalidpriority\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDPRIORITY")]
        MessageIDOfferresourcesInvalidpriority = 0x300128,
        [Obsolete("Deprecated in favour of \"GetcryptosessionhandleOutofmemory\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_OUTOFMEMORY")]
        MessageIDGetcryptosessionhandleOutofmemory = 0x300129,
        [Obsolete("Deprecated in favour of \"AcquirehandleforcaptureNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_NULLPARAM")]
        MessageIDAcquirehandleforcaptureNullparam = 0x30012A,
        [Obsolete("Deprecated in favour of \"AcquirehandleforcaptureInvalidtype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDTYPE")]
        MessageIDAcquirehandleforcaptureInvalidtype = 0x30012B,
        [Obsolete("Deprecated in favour of \"AcquirehandleforcaptureInvalidbind\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDBIND")]
        MessageIDAcquirehandleforcaptureInvalidbind = 0x30012C,
        [Obsolete("Deprecated in favour of \"AcquirehandleforcaptureInvalidarray\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDARRAY")]
        MessageIDAcquirehandleforcaptureInvalidarray = 0x30012D,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamrotationNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_NULLPARAM")]
        MessageIDVideoprocessorsetstreamrotationNullparam = 0x30012E,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamrotationInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamrotationInvalidstream = 0x30012F,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamrotationInvalid\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALID")]
        MessageIDVideoprocessorsetstreamrotationInvalid = 0x300130,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamrotationUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamrotationUnsupported = 0x300131,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamrotationNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_NULLPARAM")]
        MessageIDVideoprocessorgetstreamrotationNullparam = 0x300132,
        [Obsolete("Deprecated in favour of \"DeviceClearviewInvalidview\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDVIEW")]
        MessageIDDeviceClearviewInvalidview = 0x300133,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoubleextensionsnotsupported = 0x300134,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderShaderextensionsnotsupported = 0x300135,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoubleextensionsnotsupported = 0x300136,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderShaderextensionsnotsupported = 0x300137,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoubleextensionsnotsupported = 0x300138,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderShaderextensionsnotsupported = 0x300139,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoubleextensionsnotsupported = 0x30013A,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderShaderextensionsnotsupported = 0x30013B,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 0x30013C,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputShaderextensionsnotsupported = 0x30013D,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoubleextensionsnotsupported = 0x30013E,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderShaderextensionsnotsupported = 0x30013F,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoubleextensionsnotsupported = 0x300140,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderShaderextensionsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderShaderextensionsnotsupported = 0x300141,
        [Obsolete("Deprecated in favour of \"DeviceShaderLinkageMinprecision\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_MINPRECISION")]
        MessageIDDeviceShaderLinkageMinprecision = 0x300142,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamalphaUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamalphaUnsupported = 0x300143,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreampixelaspectratioUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreampixelaspectratioUnsupported = 0x300144,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderUavsnotsupported = 0x300145,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderUavsnotsupported = 0x300146,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderUavsnotsupported = 0x300147,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderUavsnotsupported = 0x300148,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 0x300149,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderUavsnotsupported = 0x30014A,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderUavsnotsupported = 0x30014B,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsandunorderedaccessviewsInvalidoffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_INVALIDOFFSET")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsInvalidoffset = 0x30014C,
        [Obsolete("Deprecated in favour of \"DeviceOmsetrendertargetsandunorderedaccessviewsToomanyviews\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_TOOMANYVIEWS")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsToomanyviews = 0x30014D,
        [Obsolete("Deprecated in favour of \"DeviceClearviewNotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_NOTSUPPORTED")]
        MessageIDDeviceClearviewNotsupported = 0x30014E,
        [Obsolete("Deprecated in favour of \"SwapdevicecontextstateNotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_SWAPDEVICECONTEXTSTATE_NOTSUPPORTED")]
        MessageIDSwapdevicecontextstateNotsupported = 0x30014F,
        [Obsolete("Deprecated in favour of \"UpdatesubresourcePreferupdatesubresource1\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_PREFERUPDATESUBRESOURCE1")]
        MessageIDUpdatesubresourcePreferupdatesubresource1 = 0x300150,
        [Obsolete("Deprecated in favour of \"GetdcInaccessible\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDC_INACCESSIBLE")]
        MessageIDGetdcInaccessible = 0x300151,
        [Obsolete("Deprecated in favour of \"DeviceClearviewInvalidrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDRECT")]
        MessageIDDeviceClearviewInvalidrect = 0x300152,
        [Obsolete("Deprecated in favour of \"DeviceDrawSampleMaskIgnoredOnFL9\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLE_MASK_IGNORED_ON_FL9")]
        MessageIDDeviceDrawSampleMaskIgnoredOnFL9 = 0x300153,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedResource1NotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_NOT_SUPPORTED")]
        MessageIDDeviceOpenSharedResource1NotSupported = 0x300154,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedResourceByNameNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BY_NAME_NOT_SUPPORTED")]
        MessageIDDeviceOpenSharedResourceByNameNotSupported = 0x300155,
        [Obsolete("Deprecated in favour of \"EnqueueseteventNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_NOT_SUPPORTED")]
        MessageIDEnqueueseteventNotSupported = 0x300156,
        [Obsolete("Deprecated in favour of \"OfferreleaseNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRELEASE_NOT_SUPPORTED")]
        MessageIDOfferreleaseNotSupported = 0x300157,
        [Obsolete("Deprecated in favour of \"OfferresourcesInaccessible\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INACCESSIBLE")]
        MessageIDOfferresourcesInaccessible = 0x300158,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessorinputviewInvalidmsaa\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMSAA")]
        MessageIDCreatevideoprocessorinputviewInvalidmsaa = 0x300159,
        [Obsolete("Deprecated in favour of \"CreatevideoprocessoroutputviewInvalidmsaa\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMSAA")]
        MessageIDCreatevideoprocessoroutputviewInvalidmsaa = 0x30015A,
        [Obsolete("Deprecated in favour of \"DeviceClearviewInvalidsourcerect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT")]
        MessageIDDeviceClearviewInvalidsourcerect = 0x30015B,
        [Obsolete("Deprecated in favour of \"DeviceClearviewEmptyrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT")]
        MessageIDDeviceClearviewEmptyrect = 0x30015C,
        [Obsolete("Deprecated in favour of \"UpdatesubresourceEmptydestbox\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_EMPTYDESTBOX")]
        MessageIDUpdatesubresourceEmptydestbox = 0x30015D,
        [Obsolete("Deprecated in favour of \"CopysubresourceregionEmptysourcebox\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_EMPTYSOURCEBOX")]
        MessageIDCopysubresourceregionEmptysourcebox = 0x30015E,
        [Obsolete("Deprecated in favour of \"DeviceDrawOMRenderTargetDoesNotSupportLogicOps\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS")]
        MessageIDDeviceDrawOMRenderTargetDoesNotSupportLogicOps = 0x30015F,
        [Obsolete("Deprecated in favour of \"DeviceDrawDepthstencilviewNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_DEPTHSTENCILVIEW_NOT_SET")]
        MessageIDDeviceDrawDepthstencilviewNotSet = 0x300160,
        [Obsolete("Deprecated in favour of \"DeviceDrawRendertargetviewNotSet\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET")]
        MessageIDDeviceDrawRendertargetviewNotSet = 0x300161,
        [Obsolete("Deprecated in favour of \"DeviceDrawRendertargetviewNotSetDueToFlipPresent\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET_DUE_TO_FLIP_PRESENT")]
        MessageIDDeviceDrawRendertargetviewNotSetDueToFlipPresent = 0x300162,
        [Obsolete("Deprecated in favour of \"DeviceUnorderedaccessviewNotSetDueToFlipPresent\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET_DUE_TO_FLIP_PRESENT")]
        MessageIDDeviceUnorderedaccessviewNotSetDueToFlipPresent = 0x300163,
        [Obsolete("Deprecated in favour of \"GetdatafornewhardwarekeyNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDATAFORNEWHARDWAREKEY_NULLPARAM")]
        MessageIDGetdatafornewhardwarekeyNullparam = 0x300164,
        [Obsolete("Deprecated in favour of \"CheckcryptosessionstatusNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOSESSIONSTATUS_NULLPARAM")]
        MessageIDCheckcryptosessionstatusNullparam = 0x300165,
        [Obsolete("Deprecated in favour of \"GetcryptosessionprivatedatasizeNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_NULLPARAM")]
        MessageIDGetcryptosessionprivatedatasizeNullparam = 0x300166,
        [Obsolete("Deprecated in favour of \"GetvideodecodercapsNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_NULLPARAM")]
        MessageIDGetvideodecodercapsNullparam = 0x300167,
        [Obsolete("Deprecated in favour of \"GetvideodecodercapsZerowidthheight\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_ZEROWIDTHHEIGHT")]
        MessageIDGetvideodecodercapsZerowidthheight = 0x300168,
        [Obsolete("Deprecated in favour of \"CheckvideodecoderdownsamplingNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_NULLPARAM")]
        MessageIDCheckvideodecoderdownsamplingNullparam = 0x300169,
        [Obsolete("Deprecated in favour of \"CheckvideodecoderdownsamplingInvalidcolorspace\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE")]
        MessageIDCheckvideodecoderdownsamplingInvalidcolorspace = 0x30016A,
        [Obsolete("Deprecated in favour of \"CheckvideodecoderdownsamplingZerowidthheight\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT")]
        MessageIDCheckvideodecoderdownsamplingZerowidthheight = 0x30016B,
        [Obsolete("Deprecated in favour of \"VideodecoderenabledownsamplingNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_NULLPARAM")]
        MessageIDVideodecoderenabledownsamplingNullparam = 0x30016C,
        [Obsolete("Deprecated in favour of \"VideodecoderenabledownsamplingUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_UNSUPPORTED")]
        MessageIDVideodecoderenabledownsamplingUnsupported = 0x30016D,
        [Obsolete("Deprecated in favour of \"VideodecoderupdatedownsamplingNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_NULLPARAM")]
        MessageIDVideodecoderupdatedownsamplingNullparam = 0x30016E,
        [Obsolete("Deprecated in favour of \"VideodecoderupdatedownsamplingUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_UNSUPPORTED")]
        MessageIDVideodecoderupdatedownsamplingUnsupported = 0x30016F,
        [Obsolete("Deprecated in favour of \"CheckvideoprocessorformatconversionNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMATCONVERSION_NULLPARAM")]
        MessageIDCheckvideoprocessorformatconversionNullparam = 0x300170,
        [Obsolete("Deprecated in favour of \"Videoprocessorsetoutputcolorspace1Nullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorsetoutputcolorspace1Nullparam = 0x300171,
        [Obsolete("Deprecated in favour of \"Videoprocessorgetoutputcolorspace1Nullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorgetoutputcolorspace1Nullparam = 0x300172,
        [Obsolete("Deprecated in favour of \"Videoprocessorsetstreamcolorspace1Nullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorsetstreamcolorspace1Nullparam = 0x300173,
        [Obsolete("Deprecated in favour of \"Videoprocessorsetstreamcolorspace1Invalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamcolorspace1Invalidstream = 0x300174,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreammirrorNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_NULLPARAM")]
        MessageIDVideoprocessorsetstreammirrorNullparam = 0x300175,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreammirrorInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreammirrorInvalidstream = 0x300176,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreammirrorUnsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreammirrorUnsupported = 0x300177,
        [Obsolete("Deprecated in favour of \"Videoprocessorgetstreamcolorspace1Nullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorgetstreamcolorspace1Nullparam = 0x300178,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreammirrorNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_NULLPARAM")]
        MessageIDVideoprocessorgetstreammirrorNullparam = 0x300179,
        [Obsolete("Deprecated in favour of \"RecommendvideodecoderdownsamplingNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_NULLPARAM")]
        MessageIDRecommendvideodecoderdownsamplingNullparam = 0x30017A,
        [Obsolete("Deprecated in favour of \"RecommendvideodecoderdownsamplingInvalidcolorspace\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE")]
        MessageIDRecommendvideodecoderdownsamplingInvalidcolorspace = 0x30017B,
        [Obsolete("Deprecated in favour of \"RecommendvideodecoderdownsamplingZerowidthheight\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT")]
        MessageIDRecommendvideodecoderdownsamplingZerowidthheight = 0x30017C,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputshaderusageNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSHADERUSAGE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputshaderusageNullparam = 0x30017D,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputshaderusageNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSHADERUSAGE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputshaderusageNullparam = 0x30017E,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetbehaviorhintsNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_NULLPARAM")]
        MessageIDVideoprocessorgetbehaviorhintsNullparam = 0x30017F,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetbehaviorhintsInvalidstreamcount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSTREAMCOUNT")]
        MessageIDVideoprocessorgetbehaviorhintsInvalidstreamcount = 0x300180,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetbehaviorhintsTargetrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_TARGETRECT")]
        MessageIDVideoprocessorgetbehaviorhintsTargetrect = 0x300181,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetbehaviorhintsInvalidsourcerect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSOURCERECT")]
        MessageIDVideoprocessorgetbehaviorhintsInvalidsourcerect = 0x300182,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetbehaviorhintsInvaliddestrect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDDESTRECT")]
        MessageIDVideoprocessorgetbehaviorhintsInvaliddestrect = 0x300183,
        [Obsolete("Deprecated in favour of \"GetcryptosessionprivatedatasizeInvalidKeyExchangeType\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_INVALID_KEY_EXCHANGE_TYPE")]
        MessageIDGetcryptosessionprivatedatasizeInvalidKeyExchangeType = 0x300184,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedResource1AccessDenied\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_ACCESS_DENIED")]
        MessageIDDeviceOpenSharedResource1AccessDenied = 0x300185,
        [Obsolete("Deprecated in favour of \"D3D111MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_1_MESSAGES_END")]
        MessageIDD3D111MessagesEnd = 0x300186,
        [Obsolete("Deprecated in favour of \"D3D112MessagesStart\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_2_MESSAGES_START")]
        MessageIDD3D112MessagesStart = 0x300187,
        [Obsolete("Deprecated in favour of \"CreatebufferInvalidusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDUSAGE")]
        MessageIDCreatebufferInvalidusage = 0x300188,
        [Obsolete("Deprecated in favour of \"Createtexture1DInvalidusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDUSAGE")]
        MessageIDCreatetexture1DInvalidusage = 0x300189,
        [Obsolete("Deprecated in favour of \"Createtexture2DInvalidusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDUSAGE")]
        MessageIDCreatetexture2DInvalidusage = 0x30018A,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutLevel9SteprateNot1\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_STEPRATE_NOT_1")]
        MessageIDCreateinputlayoutLevel9SteprateNot1 = 0x30018B,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutLevel9InstancingNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_INSTANCING_NOT_SUPPORTED")]
        MessageIDCreateinputlayoutLevel9InstancingNotSupported = 0x30018C,
        [Obsolete("Deprecated in favour of \"UpdatetilemappingsInvalidParameter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDUpdatetilemappingsInvalidParameter = 0x30018D,
        [Obsolete("Deprecated in favour of \"CopytilemappingsInvalidParameter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDCopytilemappingsInvalidParameter = 0x30018E,
        [Obsolete("Deprecated in favour of \"CopytilesInvalidParameter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYTILES_INVALID_PARAMETER")]
        MessageIDCopytilesInvalidParameter = 0x30018F,
        [Obsolete("Deprecated in favour of \"UpdatetilesInvalidParameter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATETILES_INVALID_PARAMETER")]
        MessageIDUpdatetilesInvalidParameter = 0x300190,
        [Obsolete("Deprecated in favour of \"ResizetilepoolInvalidParameter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESIZETILEPOOL_INVALID_PARAMETER")]
        MessageIDResizetilepoolInvalidParameter = 0x300191,
        [Obsolete("Deprecated in favour of \"TiledresourcebarrierInvalidParameter\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TILEDRESOURCEBARRIER_INVALID_PARAMETER")]
        MessageIDTiledresourcebarrierInvalidParameter = 0x300192,
        [Obsolete("Deprecated in favour of \"NullTileMappingAccessWarning\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_WARNING")]
        MessageIDNullTileMappingAccessWarning = 0x300193,
        [Obsolete("Deprecated in favour of \"NullTileMappingAccessError\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_ERROR")]
        MessageIDNullTileMappingAccessError = 0x300194,
        [Obsolete("Deprecated in favour of \"DirtyTileMappingAccess\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DIRTY_TILE_MAPPING_ACCESS")]
        MessageIDDirtyTileMappingAccess = 0x300195,
        [Obsolete("Deprecated in favour of \"DuplicateTileMappingsInCoveredArea\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DUPLICATE_TILE_MAPPINGS_IN_COVERED_AREA")]
        MessageIDDuplicateTileMappingsInCoveredArea = 0x300196,
        [Obsolete("Deprecated in favour of \"TileMappingsInCoveredAreaDuplicatedOutside\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_IN_COVERED_AREA_DUPLICATED_OUTSIDE")]
        MessageIDTileMappingsInCoveredAreaDuplicatedOutside = 0x300197,
        [Obsolete("Deprecated in favour of \"TileMappingsSharedBetweenIncompatibleResources\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INCOMPATIBLE_RESOURCES")]
        MessageIDTileMappingsSharedBetweenIncompatibleResources = 0x300198,
        [Obsolete("Deprecated in favour of \"TileMappingsSharedBetweenInputAndOutput\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INPUT_AND_OUTPUT")]
        MessageIDTileMappingsSharedBetweenInputAndOutput = 0x300199,
        [Obsolete("Deprecated in favour of \"CheckmultisamplequalitylevelsInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_INVALIDFLAGS")]
        MessageIDCheckmultisamplequalitylevelsInvalidflags = 0x30019A,
        [Obsolete("Deprecated in favour of \"GetresourcetilingNontiledResource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_GETRESOURCETILING_NONTILED_RESOURCE")]
        MessageIDGetresourcetilingNontiledResource = 0x30019B,
        [Obsolete("Deprecated in favour of \"ResizetilepoolShrinkWithMappingsStillDefinedPastEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_RESIZETILEPOOL_SHRINK_WITH_MAPPINGS_STILL_DEFINED_PAST_END")]
        MessageIDResizetilepoolShrinkWithMappingsStillDefinedPastEnd = 0x30019C,
        [Obsolete("Deprecated in favour of \"NeedToCallTiledresourcebarrier\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEED_TO_CALL_TILEDRESOURCEBARRIER")]
        MessageIDNeedToCallTiledresourcebarrier = 0x30019D,
        [Obsolete("Deprecated in favour of \"CreatedeviceInvalidargs\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICE_INVALIDARGS")]
        MessageIDCreatedeviceInvalidargs = 0x30019E,
        [Obsolete("Deprecated in favour of \"CreatedeviceWarning\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICE_WARNING")]
        MessageIDCreatedeviceWarning = 0x30019F,
        [Obsolete("Deprecated in favour of \"ClearunorderedaccessviewuintHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWUINT_HAZARD")]
        MessageIDClearunorderedaccessviewuintHazard = 0x3001A0,
        [Obsolete("Deprecated in favour of \"ClearunorderedaccessviewfloatHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_HAZARD")]
        MessageIDClearunorderedaccessviewfloatHazard = 0x3001A1,
        [Obsolete("Deprecated in favour of \"TiledResourceTier1BufferTextureMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TILED_RESOURCE_TIER_1_BUFFER_TEXTURE_MISMATCH")]
        MessageIDTiledResourceTier1BufferTextureMismatch = 0x3001A2,
        [Obsolete("Deprecated in favour of \"CreateCryptosession\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CRYPTOSESSION")]
        MessageIDCreateCryptosession = 0x3001A3,
        [Obsolete("Deprecated in favour of \"CreateAuthenticatedchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_AUTHENTICATEDCHANNEL")]
        MessageIDCreateAuthenticatedchannel = 0x3001A4,
        [Obsolete("Deprecated in favour of \"LiveCryptosession\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CRYPTOSESSION")]
        MessageIDLiveCryptosession = 0x3001A5,
        [Obsolete("Deprecated in favour of \"LiveAuthenticatedchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_AUTHENTICATEDCHANNEL")]
        MessageIDLiveAuthenticatedchannel = 0x3001A6,
        [Obsolete("Deprecated in favour of \"DestroyCryptosession\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CRYPTOSESSION")]
        MessageIDDestroyCryptosession = 0x3001A7,
        [Obsolete("Deprecated in favour of \"DestroyAuthenticatedchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_AUTHENTICATEDCHANNEL")]
        MessageIDDestroyAuthenticatedchannel = 0x3001A8,
        [Obsolete("Deprecated in favour of \"D3D112MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_2_MESSAGES_END")]
        MessageIDD3D112MessagesEnd = 0x3001A9,
        [Obsolete("Deprecated in favour of \"D3D113MessagesStart\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_3_MESSAGES_START")]
        MessageIDD3D113MessagesStart = 0x3001AA,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidConservativerastermode\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE")]
        MessageIDCreaterasterizerstateInvalidConservativerastermode = 0x3001AB,
        [Obsolete("Deprecated in favour of \"DeviceDrawInvalidSystemvalue\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_SYSTEMVALUE")]
        MessageIDDeviceDrawInvalidSystemvalue = 0x3001AC,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateInvalidcontexttype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDCONTEXTTYPE")]
        MessageIDCreatequeryorpredicateInvalidcontexttype = 0x3001AD,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateDecodenotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_DECODENOTSUPPORTED")]
        MessageIDCreatequeryorpredicateDecodenotsupported = 0x3001AE,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateEncodenotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_ENCODENOTSUPPORTED")]
        MessageIDCreatequeryorpredicateEncodenotsupported = 0x3001AF,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANEINDEX")]
        MessageIDCreateshaderresourceviewInvalidplaneindex = 0x3001B0,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidvideoplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANEINDEX")]
        MessageIDCreateshaderresourceviewInvalidvideoplaneindex = 0x3001B1,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewAmbiguousvideoplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        MessageIDCreateshaderresourceviewAmbiguousvideoplaneindex = 0x3001B2,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANEINDEX")]
        MessageIDCreaterendertargetviewInvalidplaneindex = 0x3001B3,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidvideoplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANEINDEX")]
        MessageIDCreaterendertargetviewInvalidvideoplaneindex = 0x3001B4,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewAmbiguousvideoplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        MessageIDCreaterendertargetviewAmbiguousvideoplaneindex = 0x3001B5,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANEINDEX")]
        MessageIDCreateunorderedaccessviewInvalidplaneindex = 0x3001B6,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidvideoplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANEINDEX")]
        MessageIDCreateunorderedaccessviewInvalidvideoplaneindex = 0x3001B7,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewAmbiguousvideoplaneindex\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        MessageIDCreateunorderedaccessviewAmbiguousvideoplaneindex = 0x3001B8,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidscandataoffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSCANDATAOFFSET")]
        MessageIDJpegdecodeInvalidscandataoffset = 0x3001B9,
        [Obsolete("Deprecated in favour of \"JpegdecodeNotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_NOTSUPPORTED")]
        MessageIDJpegdecodeNotsupported = 0x3001BA,
        [Obsolete("Deprecated in favour of \"JpegdecodeDimensionstoolarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DIMENSIONSTOOLARGE")]
        MessageIDJpegdecodeDimensionstoolarge = 0x3001BB,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidcomponents\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOMPONENTS")]
        MessageIDJpegdecodeInvalidcomponents = 0x3001BC,
        [Obsolete("Deprecated in favour of \"JpegdecodeDestinationnot2D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTINATIONNOT2D")]
        MessageIDJpegdecodeDestinationnot2D = 0x3001BD,
        [Obsolete("Deprecated in favour of \"JpegdecodeTiledresourcesunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_TILEDRESOURCESUNSUPPORTED")]
        MessageIDJpegdecodeTiledresourcesunsupported = 0x3001BE,
        [Obsolete("Deprecated in favour of \"JpegdecodeGuardrectsunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_GUARDRECTSUNSUPPORTED")]
        MessageIDJpegdecodeGuardrectsunsupported = 0x3001BF,
        [Obsolete("Deprecated in favour of \"JpegdecodeFormatunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_FORMATUNSUPPORTED")]
        MessageIDJpegdecodeFormatunsupported = 0x3001C0,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSUBRESOURCE")]
        MessageIDJpegdecodeInvalidsubresource = 0x3001C1,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidmiplevel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDMIPLEVEL")]
        MessageIDJpegdecodeInvalidmiplevel = 0x3001C2,
        [Obsolete("Deprecated in favour of \"JpegdecodeEmptydestbox\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_EMPTYDESTBOX")]
        MessageIDJpegdecodeEmptydestbox = 0x3001C3,
        [Obsolete("Deprecated in favour of \"JpegdecodeDestboxnot2D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOT2D")]
        MessageIDJpegdecodeDestboxnot2D = 0x3001C4,
        [Obsolete("Deprecated in favour of \"JpegdecodeDestboxnotsub\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOTSUB")]
        MessageIDJpegdecodeDestboxnotsub = 0x3001C5,
        [Obsolete("Deprecated in favour of \"JpegdecodeDestboxesintersect\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXESINTERSECT")]
        MessageIDJpegdecodeDestboxesintersect = 0x3001C6,
        [Obsolete("Deprecated in favour of \"JpegdecodeXsubsamplemismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEMISMATCH")]
        MessageIDJpegdecodeXsubsamplemismatch = 0x3001C7,
        [Obsolete("Deprecated in favour of \"JpegdecodeYsubsamplemismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEMISMATCH")]
        MessageIDJpegdecodeYsubsamplemismatch = 0x3001C8,
        [Obsolete("Deprecated in favour of \"JpegdecodeXsubsampleodd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEODD")]
        MessageIDJpegdecodeXsubsampleodd = 0x3001C9,
        [Obsolete("Deprecated in favour of \"JpegdecodeYsubsampleodd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEODD")]
        MessageIDJpegdecodeYsubsampleodd = 0x3001CA,
        [Obsolete("Deprecated in favour of \"JpegdecodeOutputdimensionstoolarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_OUTPUTDIMENSIONSTOOLARGE")]
        MessageIDJpegdecodeOutputdimensionstoolarge = 0x3001CB,
        [Obsolete("Deprecated in favour of \"JpegdecodeNonpow2Scaleunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_NONPOW2SCALEUNSUPPORTED")]
        MessageIDJpegdecodeNonpow2Scaleunsupported = 0x3001CC,
        [Obsolete("Deprecated in favour of \"JpegdecodeFractionaldownscaletolarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_FRACTIONALDOWNSCALETOLARGE")]
        MessageIDJpegdecodeFractionaldownscaletolarge = 0x3001CD,
        [Obsolete("Deprecated in favour of \"JpegdecodeChromasizemismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_CHROMASIZEMISMATCH")]
        MessageIDJpegdecodeChromasizemismatch = 0x3001CE,
        [Obsolete("Deprecated in favour of \"JpegdecodeLumachromasizemismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_LUMACHROMASIZEMISMATCH")]
        MessageIDJpegdecodeLumachromasizemismatch = 0x3001CF,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidnumdestinations\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDNUMDESTINATIONS")]
        MessageIDJpegdecodeInvalidnumdestinations = 0x3001D0,
        [Obsolete("Deprecated in favour of \"JpegdecodeSubboxunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_SUBBOXUNSUPPORTED")]
        MessageIDJpegdecodeSubboxunsupported = 0x3001D1,
        [Obsolete("Deprecated in favour of \"Jpegdecode1Destunsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_1DESTUNSUPPORTEDFORMAT")]
        MessageIDJpegdecode1Destunsupportedformat = 0x3001D2,
        [Obsolete("Deprecated in favour of \"Jpegdecode3Destunsupportedformat\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_3DESTUNSUPPORTEDFORMAT")]
        MessageIDJpegdecode3Destunsupportedformat = 0x3001D3,
        [Obsolete("Deprecated in favour of \"JpegdecodeScaleunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_SCALEUNSUPPORTED")]
        MessageIDJpegdecodeScaleunsupported = 0x3001D4,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidsourcesize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSOURCESIZE")]
        MessageIDJpegdecodeInvalidsourcesize = 0x3001D5,
        [Obsolete("Deprecated in favour of \"JpegdecodeInvalidcopyflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOPYFLAGS")]
        MessageIDJpegdecodeInvalidcopyflags = 0x3001D6,
        [Obsolete("Deprecated in favour of \"JpegdecodeHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_HAZARD")]
        MessageIDJpegdecodeHazard = 0x3001D7,
        [Obsolete("Deprecated in favour of \"JpegdecodeUnsupportedsrcbufferusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERUSAGE")]
        MessageIDJpegdecodeUnsupportedsrcbufferusage = 0x3001D8,
        [Obsolete("Deprecated in favour of \"JpegdecodeUnsupportedsrcbuffermiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERMISCFLAGS")]
        MessageIDJpegdecodeUnsupportedsrcbuffermiscflags = 0x3001D9,
        [Obsolete("Deprecated in favour of \"JpegdecodeUnsupporteddsttextureusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDDSTTEXTUREUSAGE")]
        MessageIDJpegdecodeUnsupporteddsttextureusage = 0x3001DA,
        [Obsolete("Deprecated in favour of \"JpegdecodeBackbuffernotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_BACKBUFFERNOTSUPPORTED")]
        MessageIDJpegdecodeBackbuffernotsupported = 0x3001DB,
        [Obsolete("Deprecated in favour of \"JpegdecodeUnsupprtedcopyflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPRTEDCOPYFLAGS")]
        MessageIDJpegdecodeUnsupprtedcopyflags = 0x3001DC,
        [Obsolete("Deprecated in favour of \"JpegencodeNotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_NOTSUPPORTED")]
        MessageIDJpegencodeNotsupported = 0x3001DD,
        [Obsolete("Deprecated in favour of \"JpegencodeInvalidscandataoffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSCANDATAOFFSET")]
        MessageIDJpegencodeInvalidscandataoffset = 0x3001DE,
        [Obsolete("Deprecated in favour of \"JpegencodeInvalidcomponents\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDCOMPONENTS")]
        MessageIDJpegencodeInvalidcomponents = 0x3001DF,
        [Obsolete("Deprecated in favour of \"JpegencodeSourcenot2D\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_SOURCENOT2D")]
        MessageIDJpegencodeSourcenot2D = 0x3001E0,
        [Obsolete("Deprecated in favour of \"JpegencodeTiledresourcesunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_TILEDRESOURCESUNSUPPORTED")]
        MessageIDJpegencodeTiledresourcesunsupported = 0x3001E1,
        [Obsolete("Deprecated in favour of \"JpegencodeGuardrectsunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_GUARDRECTSUNSUPPORTED")]
        MessageIDJpegencodeGuardrectsunsupported = 0x3001E2,
        [Obsolete("Deprecated in favour of \"JpegencodeXsubsamplemismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_XSUBSAMPLEMISMATCH")]
        MessageIDJpegencodeXsubsamplemismatch = 0x3001E3,
        [Obsolete("Deprecated in favour of \"JpegencodeYsubsamplemismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_YSUBSAMPLEMISMATCH")]
        MessageIDJpegencodeYsubsamplemismatch = 0x3001E4,
        [Obsolete("Deprecated in favour of \"JpegencodeFormatunsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_FORMATUNSUPPORTED")]
        MessageIDJpegencodeFormatunsupported = 0x3001E5,
        [Obsolete("Deprecated in favour of \"JpegencodeInvalidsubresource\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSUBRESOURCE")]
        MessageIDJpegencodeInvalidsubresource = 0x3001E6,
        [Obsolete("Deprecated in favour of \"JpegencodeInvalidmiplevel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDMIPLEVEL")]
        MessageIDJpegencodeInvalidmiplevel = 0x3001E7,
        [Obsolete("Deprecated in favour of \"JpegencodeDimensionstoolarge\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_DIMENSIONSTOOLARGE")]
        MessageIDJpegencodeDimensionstoolarge = 0x3001E8,
        [Obsolete("Deprecated in favour of \"JpegencodeHazard\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_HAZARD")]
        MessageIDJpegencodeHazard = 0x3001E9,
        [Obsolete("Deprecated in favour of \"JpegencodeUnsupporteddstbufferusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERUSAGE")]
        MessageIDJpegencodeUnsupporteddstbufferusage = 0x3001EA,
        [Obsolete("Deprecated in favour of \"JpegencodeUnsupporteddstbuffermiscflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERMISCFLAGS")]
        MessageIDJpegencodeUnsupporteddstbuffermiscflags = 0x3001EB,
        [Obsolete("Deprecated in favour of \"JpegencodeUnsupportedsrctextureusage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDSRCTEXTUREUSAGE")]
        MessageIDJpegencodeUnsupportedsrctextureusage = 0x3001EC,
        [Obsolete("Deprecated in favour of \"JpegencodeBackbuffernotsupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_BACKBUFFERNOTSUPPORTED")]
        MessageIDJpegencodeBackbuffernotsupported = 0x3001ED,
        [Obsolete("Deprecated in favour of \"CreatequeryorpredicateUnsupportedcontextttypeforquery\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNSUPPORTEDCONTEXTTTYPEFORQUERY")]
        MessageIDCreatequeryorpredicateUnsupportedcontextttypeforquery = 0x3001EE,
        [Obsolete("Deprecated in favour of \"Flush1Invalidcontexttype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_FLUSH1_INVALIDCONTEXTTYPE")]
        MessageIDFlush1Invalidcontexttype = 0x3001EF,
        [Obsolete("Deprecated in favour of \"DeviceSethardwareprotectionInvalidcontext\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETHARDWAREPROTECTION_INVALIDCONTEXT")]
        MessageIDDeviceSethardwareprotectionInvalidcontext = 0x3001F0,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputhdrmetadataNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorsetoutputhdrmetadataNullparam = 0x3001F1,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetoutputhdrmetadataInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorsetoutputhdrmetadataInvalidsize = 0x3001F2,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputhdrmetadataNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorgetoutputhdrmetadataNullparam = 0x3001F3,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetoutputhdrmetadataInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorgetoutputhdrmetadataInvalidsize = 0x3001F4,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamhdrmetadataNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorsetstreamhdrmetadataNullparam = 0x3001F5,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamhdrmetadataInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamhdrmetadataInvalidstream = 0x3001F6,
        [Obsolete("Deprecated in favour of \"VideoprocessorsetstreamhdrmetadataInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorsetstreamhdrmetadataInvalidsize = 0x3001F7,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamhdrmetadataNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorgetstreamhdrmetadataNullparam = 0x3001F8,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamhdrmetadataInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamhdrmetadataInvalidstream = 0x3001F9,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamhdrmetadataInvalidsize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorgetstreamhdrmetadataInvalidsize = 0x3001FA,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamframeformatInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamframeformatInvalidstream = 0x3001FB,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamcolorspaceInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamcolorspaceInvalidstream = 0x3001FC,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamoutputrateInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamoutputrateInvalidstream = 0x3001FD,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamsourcerectInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamsourcerectInvalidstream = 0x3001FE,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamdestrectInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamdestrectInvalidstream = 0x3001FF,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamalphaInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamalphaInvalidstream = 0x300200,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreampaletteInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreampaletteInvalidstream = 0x300201,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreampixelaspectratioInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreampixelaspectratioInvalidstream = 0x300202,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamlumakeyInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamlumakeyInvalidstream = 0x300203,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamstereoformatInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamstereoformatInvalidstream = 0x300204,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamautoprocessingmodeInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamautoprocessingmodeInvalidstream = 0x300205,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamfilterInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamfilterInvalidstream = 0x300206,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreamrotationInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamrotationInvalidstream = 0x300207,
        [Obsolete("Deprecated in favour of \"Videoprocessorgetstreamcolorspace1Invalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamcolorspace1Invalidstream = 0x300208,
        [Obsolete("Deprecated in favour of \"VideoprocessorgetstreammirrorInvalidstream\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreammirrorInvalidstream = 0x300209,
        [Obsolete("Deprecated in favour of \"CreateFence\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_FENCE")]
        MessageIDCreateFence = 0x30020A,
        [Obsolete("Deprecated in favour of \"LiveFence\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_FENCE")]
        MessageIDLiveFence = 0x30020B,
        [Obsolete("Deprecated in favour of \"DestroyFence\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_FENCE")]
        MessageIDDestroyFence = 0x30020C,
        [Obsolete("Deprecated in favour of \"CreateSynchronizedchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SYNCHRONIZEDCHANNEL")]
        MessageIDCreateSynchronizedchannel = 0x30020D,
        [Obsolete("Deprecated in favour of \"LiveSynchronizedchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SYNCHRONIZEDCHANNEL")]
        MessageIDLiveSynchronizedchannel = 0x30020E,
        [Obsolete("Deprecated in favour of \"DestroySynchronizedchannel\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SYNCHRONIZEDCHANNEL")]
        MessageIDDestroySynchronizedchannel = 0x30020F,
        [Obsolete("Deprecated in favour of \"CreatefenceInvalidflags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEFENCE_INVALIDFLAGS")]
        MessageIDCreatefenceInvalidflags = 0x300210,
        [Obsolete("Deprecated in favour of \"D3D113MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_3_MESSAGES_END")]
        MessageIDD3D113MessagesEnd = 0x300211,
        [Obsolete("Deprecated in favour of \"D3D115MessagesStart\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_5_MESSAGES_START")]
        MessageIDD3D115MessagesStart = 0x300212,
        [Obsolete("Deprecated in favour of \"NegotiatecryptosessionkeyexchangemtInvalidkeyexchangetype\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_INVALIDKEYEXCHANGETYPE")]
        MessageIDNegotiatecryptosessionkeyexchangemtInvalidkeyexchangetype = 0x300213,
        [Obsolete("Deprecated in favour of \"NegotiatecryptosessionkeyexchangemtNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_NOT_SUPPORTED")]
        MessageIDNegotiatecryptosessionkeyexchangemtNotSupported = 0x300214,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeInvalidHistogramComponentCount\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT_COUNT")]
        MessageIDDecoderbeginframeInvalidHistogramComponentCount = 0x300215,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeInvalidHistogramComponent\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT")]
        MessageIDDecoderbeginframeInvalidHistogramComponent = 0x300216,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeInvalidHistogramBufferSize\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_SIZE")]
        MessageIDDecoderbeginframeInvalidHistogramBufferSize = 0x300217,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeInvalidHistogramBufferUsage\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_USAGE")]
        MessageIDDecoderbeginframeInvalidHistogramBufferUsage = 0x300218,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeInvalidHistogramBufferMiscFlags\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_MISC_FLAGS")]
        MessageIDDecoderbeginframeInvalidHistogramBufferMiscFlags = 0x300219,
        [Obsolete("Deprecated in favour of \"DecoderbeginframeInvalidHistogramBufferOffset\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_OFFSET")]
        MessageIDDecoderbeginframeInvalidHistogramBufferOffset = 0x30021A,
        [Obsolete("Deprecated in favour of \"CreateTrackedworkload\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKEDWORKLOAD")]
        MessageIDCreateTrackedworkload = 0x30021B,
        [Obsolete("Deprecated in favour of \"LiveTrackedworkload\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TRACKEDWORKLOAD")]
        MessageIDLiveTrackedworkload = 0x30021C,
        [Obsolete("Deprecated in favour of \"DestroyTrackedworkload\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD")]
        MessageIDDestroyTrackedworkload = 0x30021D,
        [Obsolete("Deprecated in favour of \"CreateTrackedWorkloadNullparam\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_NULLPARAM")]
        MessageIDCreateTrackedWorkloadNullparam = 0x30021E,
        [Obsolete("Deprecated in favour of \"CreateTrackedWorkloadInvalidMaxInstances\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_MAX_INSTANCES")]
        MessageIDCreateTrackedWorkloadInvalidMaxInstances = 0x30021F,
        [Obsolete("Deprecated in favour of \"CreateTrackedWorkloadInvalidDeadlineType\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_DEADLINE_TYPE")]
        MessageIDCreateTrackedWorkloadInvalidDeadlineType = 0x300220,
        [Obsolete("Deprecated in favour of \"CreateTrackedWorkloadInvalidEngineType\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_ENGINE_TYPE")]
        MessageIDCreateTrackedWorkloadInvalidEngineType = 0x300221,
        [Obsolete("Deprecated in favour of \"MultipleTrackedWorkloads\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS")]
        MessageIDMultipleTrackedWorkloads = 0x300222,
        [Obsolete("Deprecated in favour of \"MultipleTrackedWorkloadPairs\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS")]
        MessageIDMultipleTrackedWorkloadPairs = 0x300223,
        [Obsolete("Deprecated in favour of \"IncompleteTrackedWorkloadPair\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR")]
        MessageIDIncompleteTrackedWorkloadPair = 0x300224,
        [Obsolete("Deprecated in favour of \"OutOfOrderTrackedWorkloadPair\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR")]
        MessageIDOutOfOrderTrackedWorkloadPair = 0x300225,
        [Obsolete("Deprecated in favour of \"CannotAddTrackedWorkload\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD")]
        MessageIDCannotAddTrackedWorkload = 0x300226,
        [Obsolete("Deprecated in favour of \"TrackedWorkloadNotSupported\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED")]
        MessageIDTrackedWorkloadNotSupported = 0x300227,
        [Obsolete("Deprecated in favour of \"TrackedWorkloadEngineTypeNotFound\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_ENGINE_TYPE_NOT_FOUND")]
        MessageIDTrackedWorkloadEngineTypeNotFound = 0x300228,
        [Obsolete("Deprecated in favour of \"NoTrackedWorkloadSlotAvailable\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_NO_TRACKED_WORKLOAD_SLOT_AVAILABLE")]
        MessageIDNoTrackedWorkloadSlotAvailable = 0x300229,
        [Obsolete("Deprecated in favour of \"EndTrackedWorkloadInvalidArg\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_END_TRACKED_WORKLOAD_INVALID_ARG")]
        MessageIDEndTrackedWorkloadInvalidArg = 0x30022A,
        [Obsolete("Deprecated in favour of \"TrackedWorkloadDisjointFailure\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_DISJOINT_FAILURE")]
        MessageIDTrackedWorkloadDisjointFailure = 0x30022B,
        [Obsolete("Deprecated in favour of \"DeviceDrawResourceFormatAndWriteMaskMismatch\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_AND_WRITE_MASK_MISMATCH")]
        MessageIDDeviceDrawResourceFormatAndWriteMaskMismatch = 0x30022C,
        [Obsolete("Deprecated in favour of \"D3D115MessagesEnd\"")]
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_5_MESSAGES_END")]
        MessageIDD3D115MessagesEnd = 0x30022D,
        [NativeName("Name", "D3D11_MESSAGE_ID_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD")]
        DeviceIasetvertexbuffersHazard = 0x1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD")]
        DeviceIasetindexbufferHazard = 0x2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD")]
        DeviceVssetshaderresourcesHazard = 0x3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD")]
        DeviceVssetconstantbuffersHazard = 0x4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD")]
        DeviceGssetshaderresourcesHazard = 0x5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD")]
        DeviceGssetconstantbuffersHazard = 0x6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD")]
        DevicePssetshaderresourcesHazard = 0x7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD")]
        DevicePssetconstantbuffersHazard = 0x8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD")]
        DeviceOmsetrendertargetsHazard = 0x9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD")]
        DeviceSosettargetsHazard = 0xA,
        [NativeName("Name", "D3D11_MESSAGE_ID_STRING_FROM_APPLICATION")]
        StringFromApplication = 0xB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_THIS")]
        CorruptedThis = 0xC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER1")]
        CorruptedParameter1 = 0xD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER2")]
        CorruptedParameter2 = 0xE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER3")]
        CorruptedParameter3 = 0xF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER4")]
        CorruptedParameter4 = 0x10,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER5")]
        CorruptedParameter5 = 0x11,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER6")]
        CorruptedParameter6 = 0x12,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER7")]
        CorruptedParameter7 = 0x13,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER8")]
        CorruptedParameter8 = 0x14,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER9")]
        CorruptedParameter9 = 0x15,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER10")]
        CorruptedParameter10 = 0x16,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER11")]
        CorruptedParameter11 = 0x17,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER12")]
        CorruptedParameter12 = 0x18,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER13")]
        CorruptedParameter13 = 0x19,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER14")]
        CorruptedParameter14 = 0x1A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER15")]
        CorruptedParameter15 = 0x1B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_MULTITHREADING")]
        CorruptedMultithreading = 0x1C,
        [NativeName("Name", "D3D11_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY")]
        MessageReportingOutofmemory = 0x1D,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT")]
        IasetinputlayoutUnbinddeletingobject = 0x1E,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT")]
        IasetvertexbuffersUnbinddeletingobject = 0x1F,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT")]
        IasetindexbufferUnbinddeletingobject = 0x20,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT")]
        VssetshaderUnbinddeletingobject = 0x21,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        VssetshaderresourcesUnbinddeletingobject = 0x22,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        VssetconstantbuffersUnbinddeletingobject = 0x23,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        VssetsamplersUnbinddeletingobject = 0x24,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT")]
        GssetshaderUnbinddeletingobject = 0x25,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        GssetshaderresourcesUnbinddeletingobject = 0x26,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        GssetconstantbuffersUnbinddeletingobject = 0x27,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        GssetsamplersUnbinddeletingobject = 0x28,
        [NativeName("Name", "D3D11_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT")]
        SosettargetsUnbinddeletingobject = 0x29,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT")]
        PssetshaderUnbinddeletingobject = 0x2A,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        PssetshaderresourcesUnbinddeletingobject = 0x2B,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        PssetconstantbuffersUnbinddeletingobject = 0x2C,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        PssetsamplersUnbinddeletingobject = 0x2D,
        [NativeName("Name", "D3D11_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT")]
        RssetstateUnbinddeletingobject = 0x2E,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT")]
        OmsetblendstateUnbinddeletingobject = 0x2F,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT")]
        OmsetdepthstencilstateUnbinddeletingobject = 0x30,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT")]
        OmsetrendertargetsUnbinddeletingobject = 0x31,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT")]
        SetpredicationUnbinddeletingobject = 0x32,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETPRIVATEDATA_MOREDATA")]
        GetprivatedataMoredata = 0x33,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA")]
        SetprivatedataInvalidfreedata = 0x34,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN")]
        SetprivatedataInvalidiunknown = 0x35,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS")]
        SetprivatedataInvalidflags = 0x36,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS")]
        SetprivatedataChangingparams = 0x37,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY")]
        SetprivatedataOutofmemory = 0x38,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT")]
        CreatebufferUnrecognizedformat = 0x39,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES")]
        CreatebufferInvalidsamples = 0x3A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE")]
        CreatebufferUnrecognizedusage = 0x3B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS")]
        CreatebufferUnrecognizedbindflags = 0x3C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS")]
        CreatebufferUnrecognizedcpuaccessflags = 0x3D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS")]
        CreatebufferUnrecognizedmiscflags = 0x3E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS")]
        CreatebufferInvalidcpuaccessflags = 0x3F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS")]
        CreatebufferInvalidbindflags = 0x40,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA")]
        CreatebufferInvalidinitialdata = 0x41,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS")]
        CreatebufferInvaliddimensions = 0x42,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS")]
        CreatebufferInvalidmiplevels = 0x43,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS")]
        CreatebufferInvalidmiscflags = 0x44,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN")]
        CreatebufferInvalidargReturn = 0x45,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN")]
        CreatebufferOutofmemoryReturn = 0x46,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_NULLDESC")]
        CreatebufferNulldesc = 0x47,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS")]
        CreatebufferInvalidconstantbufferbindings = 0x48,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION")]
        CreatebufferLargeallocation = 0x49,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT")]
        Createtexture1DUnrecognizedformat = 0x4A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT")]
        Createtexture1DUnsupportedformat = 0x4B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES")]
        Createtexture1DInvalidsamples = 0x4C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE")]
        Createtexture1DUnrecognizedusage = 0x4D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS")]
        Createtexture1DUnrecognizedbindflags = 0x4E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS")]
        Createtexture1DUnrecognizedcpuaccessflags = 0x4F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS")]
        Createtexture1DUnrecognizedmiscflags = 0x50,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS")]
        Createtexture1DInvalidcpuaccessflags = 0x51,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS")]
        Createtexture1DInvalidbindflags = 0x52,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA")]
        Createtexture1DInvalidinitialdata = 0x53,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS")]
        Createtexture1DInvaliddimensions = 0x54,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS")]
        Createtexture1DInvalidmiplevels = 0x55,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS")]
        Createtexture1DInvalidmiscflags = 0x56,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN")]
        Createtexture1DInvalidargReturn = 0x57,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN")]
        Createtexture1DOutofmemoryReturn = 0x58,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_NULLDESC")]
        Createtexture1DNulldesc = 0x59,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION")]
        Createtexture1DLargeallocation = 0x5A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT")]
        Createtexture2DUnrecognizedformat = 0x5B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT")]
        Createtexture2DUnsupportedformat = 0x5C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES")]
        Createtexture2DInvalidsamples = 0x5D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE")]
        Createtexture2DUnrecognizedusage = 0x5E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS")]
        Createtexture2DUnrecognizedbindflags = 0x5F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS")]
        Createtexture2DUnrecognizedcpuaccessflags = 0x60,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS")]
        Createtexture2DUnrecognizedmiscflags = 0x61,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS")]
        Createtexture2DInvalidcpuaccessflags = 0x62,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS")]
        Createtexture2DInvalidbindflags = 0x63,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA")]
        Createtexture2DInvalidinitialdata = 0x64,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS")]
        Createtexture2DInvaliddimensions = 0x65,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS")]
        Createtexture2DInvalidmiplevels = 0x66,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS")]
        Createtexture2DInvalidmiscflags = 0x67,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN")]
        Createtexture2DInvalidargReturn = 0x68,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN")]
        Createtexture2DOutofmemoryReturn = 0x69,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_NULLDESC")]
        Createtexture2DNulldesc = 0x6A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION")]
        Createtexture2DLargeallocation = 0x6B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT")]
        Createtexture3DUnrecognizedformat = 0x6C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT")]
        Createtexture3DUnsupportedformat = 0x6D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES")]
        Createtexture3DInvalidsamples = 0x6E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE")]
        Createtexture3DUnrecognizedusage = 0x6F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS")]
        Createtexture3DUnrecognizedbindflags = 0x70,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS")]
        Createtexture3DUnrecognizedcpuaccessflags = 0x71,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS")]
        Createtexture3DUnrecognizedmiscflags = 0x72,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS")]
        Createtexture3DInvalidcpuaccessflags = 0x73,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS")]
        Createtexture3DInvalidbindflags = 0x74,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA")]
        Createtexture3DInvalidinitialdata = 0x75,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS")]
        Createtexture3DInvaliddimensions = 0x76,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS")]
        Createtexture3DInvalidmiplevels = 0x77,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS")]
        Createtexture3DInvalidmiscflags = 0x78,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN")]
        Createtexture3DInvalidargReturn = 0x79,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN")]
        Createtexture3DOutofmemoryReturn = 0x7A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_NULLDESC")]
        Createtexture3DNulldesc = 0x7B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION")]
        Createtexture3DLargeallocation = 0x7C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT")]
        CreateshaderresourceviewUnrecognizedformat = 0x7D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC")]
        CreateshaderresourceviewInvaliddesc = 0x7E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT")]
        CreateshaderresourceviewInvalidformat = 0x7F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS")]
        CreateshaderresourceviewInvaliddimensions = 0x80,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE")]
        CreateshaderresourceviewInvalidresource = 0x81,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS")]
        CreateshaderresourceviewToomanyobjects = 0x82,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN")]
        CreateshaderresourceviewInvalidargReturn = 0x83,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN")]
        CreateshaderresourceviewOutofmemoryReturn = 0x84,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT")]
        CreaterendertargetviewUnrecognizedformat = 0x85,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT")]
        CreaterendertargetviewUnsupportedformat = 0x86,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC")]
        CreaterendertargetviewInvaliddesc = 0x87,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT")]
        CreaterendertargetviewInvalidformat = 0x88,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS")]
        CreaterendertargetviewInvaliddimensions = 0x89,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE")]
        CreaterendertargetviewInvalidresource = 0x8A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS")]
        CreaterendertargetviewToomanyobjects = 0x8B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN")]
        CreaterendertargetviewInvalidargReturn = 0x8C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN")]
        CreaterendertargetviewOutofmemoryReturn = 0x8D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT")]
        CreatedepthstencilviewUnrecognizedformat = 0x8E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC")]
        CreatedepthstencilviewInvaliddesc = 0x8F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT")]
        CreatedepthstencilviewInvalidformat = 0x90,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS")]
        CreatedepthstencilviewInvaliddimensions = 0x91,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE")]
        CreatedepthstencilviewInvalidresource = 0x92,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS")]
        CreatedepthstencilviewToomanyobjects = 0x93,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN")]
        CreatedepthstencilviewInvalidargReturn = 0x94,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN")]
        CreatedepthstencilviewOutofmemoryReturn = 0x95,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY")]
        CreateinputlayoutOutofmemory = 0x96,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS")]
        CreateinputlayoutToomanyelements = 0x97,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT")]
        CreateinputlayoutInvalidformat = 0x98,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT")]
        CreateinputlayoutIncompatibleformat = 0x99,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT")]
        CreateinputlayoutInvalidslot = 0x9A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS")]
        CreateinputlayoutInvalidinputslotclass = 0x9B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH")]
        CreateinputlayoutSteprateslotclassmismatch = 0x9C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE")]
        CreateinputlayoutInvalidslotclasschange = 0x9D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE")]
        CreateinputlayoutInvalidstepratechange = 0x9E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT")]
        CreateinputlayoutInvalidalignment = 0x9F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC")]
        CreateinputlayoutDuplicatesemantic = 0xA0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE")]
        CreateinputlayoutUnparseableinputsignature = 0xA1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC")]
        CreateinputlayoutNullsemantic = 0xA2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT")]
        CreateinputlayoutMissingelement = 0xA3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC")]
        CreateinputlayoutNulldesc = 0xA4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY")]
        CreatevertexshaderOutofmemory = 0xA5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE")]
        CreatevertexshaderInvalidshaderbytecode = 0xA6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE")]
        CreatevertexshaderInvalidshadertype = 0xA7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY")]
        CreategeometryshaderOutofmemory = 0xA8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE")]
        CreategeometryshaderInvalidshaderbytecode = 0xA9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE")]
        CreategeometryshaderInvalidshadertype = 0xAA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY")]
        CreategeometryshaderwithstreamoutputOutofmemory = 0xAB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE")]
        CreategeometryshaderwithstreamoutputInvalidshaderbytecode = 0xAC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        CreategeometryshaderwithstreamoutputInvalidshadertype = 0xAD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES")]
        CreategeometryshaderwithstreamoutputInvalidnumentries = 0xAE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED")]
        CreategeometryshaderwithstreamoutputOutputstreamstrideunused = 0xAF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL")]
        CreategeometryshaderwithstreamoutputUnexpecteddecl = 0xB0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL")]
        CreategeometryshaderwithstreamoutputExpecteddecl = 0xB1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED")]
        CreategeometryshaderwithstreamoutputOutputslot0Expected = 0xB2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT")]
        CreategeometryshaderwithstreamoutputInvalidoutputslot = 0xB3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT")]
        CreategeometryshaderwithstreamoutputOnlyoneelementperslot = 0xB4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT")]
        CreategeometryshaderwithstreamoutputInvalidcomponentcount = 0xB5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT")]
        CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 0xB6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION")]
        CreategeometryshaderwithstreamoutputInvalidgapdefinition = 0xB7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT")]
        CreategeometryshaderwithstreamoutputRepeatedoutput = 0xB8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE")]
        CreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 0xB9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC")]
        CreategeometryshaderwithstreamoutputMissingsemantic = 0xBA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH")]
        CreategeometryshaderwithstreamoutputMaskmismatch = 0xBB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS")]
        CreategeometryshaderwithstreamoutputCanthaveonlygaps = 0xBC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX")]
        CreategeometryshaderwithstreamoutputDecltoocomplex = 0xBD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE")]
        CreategeometryshaderwithstreamoutputMissingoutputsignature = 0xBE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY")]
        CreatepixelshaderOutofmemory = 0xBF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE")]
        CreatepixelshaderInvalidshaderbytecode = 0xC0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE")]
        CreatepixelshaderInvalidshadertype = 0xC1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE")]
        CreaterasterizerstateInvalidfillmode = 0xC2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE")]
        CreaterasterizerstateInvalidcullmode = 0xC3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP")]
        CreaterasterizerstateInvaliddepthbiasclamp = 0xC4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS")]
        CreaterasterizerstateInvalidslopescaleddepthbias = 0xC5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS")]
        CreaterasterizerstateToomanyobjects = 0xC6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC")]
        CreaterasterizerstateNulldesc = 0xC7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK")]
        CreatedepthstencilstateInvaliddepthwritemask = 0xC8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC")]
        CreatedepthstencilstateInvaliddepthfunc = 0xC9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP")]
        CreatedepthstencilstateInvalidfrontfacestencilfailop = 0xCA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP")]
        CreatedepthstencilstateInvalidfrontfacestencilzfailop = 0xCB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP")]
        CreatedepthstencilstateInvalidfrontfacestencilpassop = 0xCC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC")]
        CreatedepthstencilstateInvalidfrontfacestencilfunc = 0xCD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP")]
        CreatedepthstencilstateInvalidbackfacestencilfailop = 0xCE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP")]
        CreatedepthstencilstateInvalidbackfacestencilzfailop = 0xCF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP")]
        CreatedepthstencilstateInvalidbackfacestencilpassop = 0xD0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC")]
        CreatedepthstencilstateInvalidbackfacestencilfunc = 0xD1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS")]
        CreatedepthstencilstateToomanyobjects = 0xD2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC")]
        CreatedepthstencilstateNulldesc = 0xD3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND")]
        CreateblendstateInvalidsrcblend = 0xD4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND")]
        CreateblendstateInvaliddestblend = 0xD5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP")]
        CreateblendstateInvalidblendop = 0xD6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA")]
        CreateblendstateInvalidsrcblendalpha = 0xD7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA")]
        CreateblendstateInvaliddestblendalpha = 0xD8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA")]
        CreateblendstateInvalidblendopalpha = 0xD9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK")]
        CreateblendstateInvalidrendertargetwritemask = 0xDA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS")]
        CreateblendstateToomanyobjects = 0xDB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC")]
        CreateblendstateNulldesc = 0xDC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER")]
        CreatesamplerstateInvalidfilter = 0xDD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU")]
        CreatesamplerstateInvalidaddressu = 0xDE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV")]
        CreatesamplerstateInvalidaddressv = 0xDF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW")]
        CreatesamplerstateInvalidaddressw = 0xE0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS")]
        CreatesamplerstateInvalidmiplodbias = 0xE1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY")]
        CreatesamplerstateInvalidmaxanisotropy = 0xE2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC")]
        CreatesamplerstateInvalidcomparisonfunc = 0xE3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD")]
        CreatesamplerstateInvalidminlod = 0xE4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD")]
        CreatesamplerstateInvalidmaxlod = 0xE5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS")]
        CreatesamplerstateToomanyobjects = 0xE6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC")]
        CreatesamplerstateNulldesc = 0xE7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY")]
        CreatequeryorpredicateInvalidquery = 0xE8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS")]
        CreatequeryorpredicateInvalidmiscflags = 0xE9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG")]
        CreatequeryorpredicateUnexpectedmiscflag = 0xEA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC")]
        CreatequeryorpredicateNulldesc = 0xEB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED")]
        DeviceIasetprimitivetopologyTopologyUnrecognized = 0xEC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED")]
        DeviceIasetprimitivetopologyTopologyUndefined = 0xED,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER")]
        IasetvertexbuffersInvalidbuffer = 0xEE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE")]
        DeviceIasetvertexbuffersOffsetTooLarge = 0xEF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY")]
        DeviceIasetvertexbuffersBuffersEmpty = 0xF0,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER")]
        IasetindexbufferInvalidbuffer = 0xF1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID")]
        DeviceIasetindexbufferFormatInvalid = 0xF2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE")]
        DeviceIasetindexbufferOffsetTooLarge = 0xF3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED")]
        DeviceIasetindexbufferOffsetUnaligned = 0xF4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceVssetshaderresourcesViewsEmpty = 0xF5,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        VssetconstantbuffersInvalidbuffer = 0xF6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceVssetconstantbuffersBuffersEmpty = 0xF7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceVssetsamplersSamplersEmpty = 0xF8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceGssetshaderresourcesViewsEmpty = 0xF9,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        GssetconstantbuffersInvalidbuffer = 0xFA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceGssetconstantbuffersBuffersEmpty = 0xFB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceGssetsamplersSamplersEmpty = 0xFC,
        [NativeName("Name", "D3D11_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER")]
        SosettargetsInvalidbuffer = 0xFD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED")]
        DeviceSosettargetsOffsetUnaligned = 0xFE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY")]
        DevicePssetshaderresourcesViewsEmpty = 0xFF,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        PssetconstantbuffersInvalidbuffer = 0x100,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DevicePssetconstantbuffersBuffersEmpty = 0x101,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY")]
        DevicePssetsamplersSamplersEmpty = 0x102,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT")]
        DeviceRssetviewportsInvalidviewport = 0x103,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR")]
        DeviceRssetscissorrectsInvalidscissor = 0x104,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH")]
        ClearrendertargetviewDenormflush = 0x105,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH")]
        CleardepthstencilviewDenormflush = 0x106,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID")]
        CleardepthstencilviewInvalid = 0x107,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY")]
        DeviceIagetvertexbuffersBuffersEmpty = 0x108,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceVsgetshaderresourcesViewsEmpty = 0x109,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceVsgetconstantbuffersBuffersEmpty = 0x10A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceVsgetsamplersSamplersEmpty = 0x10B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceGsgetshaderresourcesViewsEmpty = 0x10C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceGsgetconstantbuffersBuffersEmpty = 0x10D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceGsgetsamplersSamplersEmpty = 0x10E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY")]
        DeviceSogettargetsBuffersEmpty = 0x10F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY")]
        DevicePsgetshaderresourcesViewsEmpty = 0x110,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DevicePsgetconstantbuffersBuffersEmpty = 0x111,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY")]
        DevicePsgetsamplersSamplersEmpty = 0x112,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY")]
        DeviceRsgetviewportsViewportsEmpty = 0x113,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY")]
        DeviceRsgetscissorrectsRectsEmpty = 0x114,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID")]
        DeviceGeneratemipsResourceInvalid = 0x115,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE")]
        CopysubresourceregionInvaliddestinationsubresource = 0x116,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE")]
        CopysubresourceregionInvalidsourcesubresource = 0x117,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX")]
        CopysubresourceregionInvalidsourcebox = 0x118,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE")]
        CopysubresourceregionInvalidsource = 0x119,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE")]
        CopysubresourceregionInvaliddestinationstate = 0x11A,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE")]
        CopysubresourceregionInvalidsourcestate = 0x11B,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE")]
        CopyresourceInvalidsource = 0x11C,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE")]
        CopyresourceInvaliddestinationstate = 0x11D,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE")]
        CopyresourceInvalidsourcestate = 0x11E,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE")]
        UpdatesubresourceInvaliddestinationsubresource = 0x11F,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX")]
        UpdatesubresourceInvaliddestinationbox = 0x120,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE")]
        UpdatesubresourceInvaliddestinationstate = 0x121,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID")]
        DeviceResolvesubresourceDestinationInvalid = 0x122,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID")]
        DeviceResolvesubresourceDestinationSubresourceInvalid = 0x123,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID")]
        DeviceResolvesubresourceSourceInvalid = 0x124,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID")]
        DeviceResolvesubresourceSourceSubresourceInvalid = 0x125,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID")]
        DeviceResolvesubresourceFormatInvalid = 0x126,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE")]
        BufferMapInvalidmaptype = 0x127,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS")]
        BufferMapInvalidflags = 0x128,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED")]
        BufferMapAlreadymapped = 0x129,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN")]
        BufferMapDeviceremovedReturn = 0x12A,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED")]
        BufferUnmapNotmapped = 0x12B,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE")]
        Texture1DMapInvalidmaptype = 0x12C,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE")]
        Texture1DMapInvalidsubresource = 0x12D,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS")]
        Texture1DMapInvalidflags = 0x12E,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED")]
        Texture1DMapAlreadymapped = 0x12F,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN")]
        Texture1DMapDeviceremovedReturn = 0x130,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE")]
        Texture1DUnmapInvalidsubresource = 0x131,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED")]
        Texture1DUnmapNotmapped = 0x132,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE")]
        Texture2DMapInvalidmaptype = 0x133,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE")]
        Texture2DMapInvalidsubresource = 0x134,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS")]
        Texture2DMapInvalidflags = 0x135,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED")]
        Texture2DMapAlreadymapped = 0x136,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN")]
        Texture2DMapDeviceremovedReturn = 0x137,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE")]
        Texture2DUnmapInvalidsubresource = 0x138,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED")]
        Texture2DUnmapNotmapped = 0x139,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE")]
        Texture3DMapInvalidmaptype = 0x13A,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE")]
        Texture3DMapInvalidsubresource = 0x13B,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS")]
        Texture3DMapInvalidflags = 0x13C,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED")]
        Texture3DMapAlreadymapped = 0x13D,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN")]
        Texture3DMapDeviceremovedReturn = 0x13E,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE")]
        Texture3DUnmapInvalidsubresource = 0x13F,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED")]
        Texture3DUnmapNotmapped = 0x140,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED")]
        CheckformatsupportFormatDeprecated = 0x141,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED")]
        CheckmultisamplequalitylevelsFormatDeprecated = 0x142,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS")]
        SetexceptionmodeUnrecognizedflags = 0x143,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN")]
        SetexceptionmodeInvalidargReturn = 0x144,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN")]
        SetexceptionmodeDeviceremovedReturn = 0x145,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE")]
        RefSimulatingInfinitelyFastHardware = 0x146,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_THREADING_MODE")]
        RefThreadingMode = 0x147,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_UMDRIVER_EXCEPTION")]
        RefUmdriverException = 0x148,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_KMDRIVER_EXCEPTION")]
        RefKmdriverException = 0x149,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_HARDWARE_EXCEPTION")]
        RefHardwareException = 0x14A,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE")]
        RefAccessingIndexableTempOutOfRange = 0x14B,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER")]
        RefProblemParsingShader = 0x14C,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_OUT_OF_MEMORY")]
        RefOutOfMemory = 0x14D,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_INFO")]
        RefInfo = 0x14E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW")]
        DeviceDrawVertexposOverflow = 0x14F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW")]
        DeviceDrawindexedIndexposOverflow = 0x150,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW")]
        DeviceDrawinstancedVertexposOverflow = 0x151,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW")]
        DeviceDrawinstancedInstanceposOverflow = 0x152,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW")]
        DeviceDrawindexedinstancedInstanceposOverflow = 0x153,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW")]
        DeviceDrawindexedinstancedIndexposOverflow = 0x154,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET")]
        DeviceDrawVertexShaderNotSet = 0x155,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND")]
        DeviceShaderLinkageSemanticnameNotFound = 0x156,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX")]
        DeviceShaderLinkageRegisterindex = 0x157,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE")]
        DeviceShaderLinkageComponenttype = 0x158,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK")]
        DeviceShaderLinkageRegistermask = 0x159,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE")]
        DeviceShaderLinkageSystemvalue = 0x15A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS")]
        DeviceShaderLinkageNeverwrittenAlwaysreads = 0x15B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET")]
        DeviceDrawVertexBufferNotSet = 0x15C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET")]
        DeviceDrawInputlayoutNotSet = 0x15D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET")]
        DeviceDrawConstantBufferNotSet = 0x15E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL")]
        DeviceDrawConstantBufferTooSmall = 0x15F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET")]
        DeviceDrawSamplerNotSet = 0x160,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET")]
        DeviceDrawShaderresourceviewNotSet = 0x161,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH")]
        DeviceDrawViewDimensionMismatch = 0x162,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL")]
        DeviceDrawVertexBufferStrideTooSmall = 0x163,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL")]
        DeviceDrawVertexBufferTooSmall = 0x164,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET")]
        DeviceDrawIndexBufferNotSet = 0x165,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID")]
        DeviceDrawIndexBufferFormatInvalid = 0x166,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL")]
        DeviceDrawIndexBufferTooSmall = 0x167,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH")]
        DeviceDrawGSInputPrimitiveMismatch = 0x168,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH")]
        DeviceDrawResourceReturnTypeMismatch = 0x169,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT")]
        DeviceDrawPositionNotPresent = 0x16A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET")]
        DeviceDrawOutputStreamNotSet = 0x16B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED")]
        DeviceDrawBoundResourceMapped = 0x16C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY")]
        DeviceDrawInvalidPrimitivetopology = 0x16D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED")]
        DeviceDrawVertexOffsetUnaligned = 0x16E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED")]
        DeviceDrawVertexStrideUnaligned = 0x16F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED")]
        DeviceDrawIndexOffsetUnaligned = 0x170,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED")]
        DeviceDrawOutputStreamOffsetUnaligned = 0x171,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED")]
        DeviceDrawResourceFormatLDUnsupported = 0x172,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED")]
        DeviceDrawResourceFormatSampleUnsupported = 0x173,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED")]
        DeviceDrawResourceFormatSampleCUnsupported = 0x174,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED")]
        DeviceDrawResourceMultisampleUnsupported = 0x175,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE")]
        DeviceDrawSOTargetsBoundWithoutSource = 0x176,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER")]
        DeviceDrawSOStrideLargerThanBuffer = 0x177,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING")]
        DeviceDrawOMRenderTargetDoesNotSupportBlending = 0x178,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0")]
        DeviceDrawOMDualSourceBlendingCanOnlyHaveRenderTarget0 = 0x179,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT")]
        DeviceRemovalProcessATFault = 0x17A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT")]
        DeviceRemovalProcessPossiblyATFault = 0x17B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT")]
        DeviceRemovalProcessNotATFault = 0x17C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN")]
        DeviceOpenSharedResourceInvalidargReturn = 0x17D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN")]
        DeviceOpenSharedResourceOutofmemoryReturn = 0x17E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN")]
        DeviceOpenSharedResourceBadinterfaceReturn = 0x17F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET")]
        DeviceDrawViewportNotSet = 0x180,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC")]
        CreateinputlayoutTrailingDigitInSemantic = 0x181,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC")]
        CreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 0x182,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH")]
        DeviceRssetviewportsDenormflush = 0x183,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW")]
        OmsetrendertargetsInvalidview = 0x184,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS")]
        DeviceSettextfiltersizeInvaliddimensions = 0x185,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH")]
        DeviceDrawSamplerMismatch = 0x186,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH")]
        CreateinputlayoutTypeMismatch = 0x187,
        [NativeName("Name", "D3D11_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY")]
        BlendstateGetdescLegacy = 0x188,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY")]
        ShaderresourceviewGetdescLegacy = 0x189,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN")]
        CreatequeryOutofmemoryReturn = 0x18A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN")]
        CreatepredicateOutofmemoryReturn = 0x18B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER")]
        CreatecounterOutofrangeCounter = 0x18C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED")]
        CreatecounterSimultaneousActiveCountersExhausted = 0x18D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER")]
        CreatecounterUnsupportedWellknownCounter = 0x18E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN")]
        CreatecounterOutofmemoryReturn = 0x18F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN")]
        CreatecounterNonexclusiveReturn = 0x190,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_NULLDESC")]
        CreatecounterNulldesc = 0x191,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER")]
        CheckcounterOutofrangeCounter = 0x192,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER")]
        CheckcounterUnsupportedWellknownCounter = 0x193,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE")]
        SetpredicationInvalidPredicateState = 0x194,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED")]
        QueryBeginUnsupported = 0x195,
        [NativeName("Name", "D3D11_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION")]
        PredicateBeginDuringPredication = 0x196,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_DUPLICATE")]
        QueryBeginDuplicate = 0x197,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS")]
        QueryBeginAbandoningPreviousResults = 0x198,
        [NativeName("Name", "D3D11_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION")]
        PredicateEndDuringPredication = 0x199,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS")]
        QueryEndAbandoningPreviousResults = 0x19A,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN")]
        QueryEndWithoutBegin = 0x19B,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE")]
        QueryGetdataInvalidDatasize = 0x19C,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS")]
        QueryGetdataInvalidFlags = 0x19D,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL")]
        QueryGetdataInvalidCall = 0x19E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH")]
        DeviceDrawPSOutputTypeMismatch = 0x19F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED")]
        DeviceDrawResourceFormatGatherUnsupported = 0x1A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN")]
        DeviceDrawInvalidUseOfCenterMultisamplePattern = 0x1A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE")]
        DeviceIasetvertexbuffersStrideTooLarge = 0x1A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE")]
        DeviceIasetvertexbuffersInvalidrange = 0x1A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT")]
        CreateinputlayoutEmptyLayout = 0x1A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH")]
        DeviceDrawResourceSampleCountMismatch = 0x1A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY")]
        LiveObjectSummary = 0x1A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BUFFER")]
        LiveBuffer = 0x1A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE1D")]
        LiveTexture1D = 0x1A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE2D")]
        LiveTexture2D = 0x1A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE3D")]
        LiveTexture3D = 0x1AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW")]
        LiveShaderresourceview = 0x1AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW")]
        LiveRendertargetview = 0x1AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW")]
        LiveDepthstencilview = 0x1AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VERTEXSHADER")]
        LiveVertexshader = 0x1AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER")]
        LiveGeometryshader = 0x1AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PIXELSHADER")]
        LivePixelshader = 0x1B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT")]
        LiveInputlayout = 0x1B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SAMPLER")]
        LiveSampler = 0x1B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BLENDSTATE")]
        LiveBlendstate = 0x1B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE")]
        LiveDepthstencilstate = 0x1B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE")]
        LiveRasterizerstate = 0x1B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_QUERY")]
        LiveQuery = 0x1B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PREDICATE")]
        LivePredicate = 0x1B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COUNTER")]
        LiveCounter = 0x1B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICE")]
        LiveDevice = 0x1B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SWAPCHAIN")]
        LiveSwapchain = 0x1BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10_MESSAGES_END")]
        D3D10MessagesEnd = 0x1BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10L9_MESSAGES_START")]
        D3D10L9MessagesStart = 0x100000,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED")]
        CreatedepthstencilstateStencilNoTwoSided = 0x100001,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED")]
        CreaterasterizerstateDepthBiasClampNotSupported = 0x100002,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT")]
        CreatesamplerstateNoComparisonSupport = 0x100003,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY")]
        CreatesamplerstateExcessiveAnisotropy = 0x100004,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE")]
        CreatesamplerstateBorderOutOfRange = 0x100005,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED")]
        VssetsamplersNotSupported = 0x100006,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS")]
        VssetsamplersTooManySamplers = 0x100007,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS")]
        PssetsamplersTooManySamplers = 0x100008,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS")]
        CreateresourceNoArrays = 0x100009,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND")]
        CreateresourceNoVBAndIBBind = 0x10000A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D")]
        CreateresourceNoTexture1D = 0x10000B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE")]
        CreateresourceDimensionOutOfRange = 0x10000C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE")]
        CreateresourceNotBindableAsShaderResource = 0x10000D,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS")]
        OmsetrendertargetsTooManyRenderTargets = 0x10000E,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS")]
        OmsetrendertargetsNoDifferingBitDepths = 0x10000F,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX")]
        IasetvertexbuffersBadBufferIndex = 0x100010,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS")]
        DeviceRssetviewportsTooManyViewports = 0x100011,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED")]
        DeviceIasetprimitivetopologyAdjacencyUnsupported = 0x100012,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS")]
        DeviceRssetscissorrectsTooManyScissors = 0x100013,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY")]
        CopyresourceOnlyTexture2DWithinGpuMemory = 0x100014,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK")]
        CopyresourceNoTexture3DReadback = 0x100015,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK")]
        CopyresourceNoTextureOnlyReadback = 0x100016,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT")]
        CreateinputlayoutUnsupportedFormat = 0x100017,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE")]
        CreateblendstateNoAlphaToCoverage = 0x100018,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE")]
        CreaterasterizerstateDepthClipEnableMustBETrue = 0x100019,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE")]
        DrawindexedStartindexlocationMustBEPositive = 0x10001A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD")]
        CreateshaderresourceviewMustUseLowestLod = 0x10001B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL")]
        CreatesamplerstateMinlodMustNotBEFractional = 0x10001C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX")]
        CreatesamplerstateMaxlodMustBEFltMax = 0x10001D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO")]
        CreateshaderresourceviewFirstarraysliceMustBEZero = 0x10001E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES")]
        CreateshaderresourceviewCubesMustHave6Sides = 0x10001F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET")]
        CreateresourceNotBindableAsRenderTarget = 0x100020,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER")]
        CreateresourceNoDwordIndexBuffer = 0x100021,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE")]
        CreateresourceMsaaPrecludesShaderResource = 0x100022,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE")]
        CreateresourcePresentationPrecludesShaderResource = 0x100023,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE")]
        CreateblendstateNoIndependentBlendEnable = 0x100024,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS")]
        CreateblendstateNoIndependentWriteMasks = 0x100025,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT")]
        CreateresourceNoStreamOut = 0x100026,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS")]
        CreateresourceOnlyVBIBForBuffers = 0x100027,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES")]
        CreateresourceNoAutogenForVolumes = 0x100028,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED")]
        CreateresourceDxgiFormatR8G8B8A8CannotBEShared = 0x100029,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED")]
        VsshaderresourcesNotSupported = 0x10002A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED")]
        GeometryShaderNotSupported = 0x10002B,
        [NativeName("Name", "D3D11_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED")]
        StreamOutNotSupported = 0x10002C,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED")]
        TextFilterNotSupported = 0x10002D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND")]
        CreateblendstateNoSeparateAlphaBlend = 0x10002E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND")]
        CreateblendstateNoMrtBlend = 0x10002F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED")]
        CreateblendstateOperationNotSupported = 0x100030,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE")]
        CreatesamplerstateNoMirroronce = 0x100031,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED")]
        DrawinstancedNotSupported = 0x100032,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3")]
        DrawindexedinstancedNotSupportedBelow93 = 0x100033,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED")]
        DrawindexedPointlistUnsupported = 0x100034,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO")]
        SetblendstateSampleMaskCannotBEZero = 0x100035,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION")]
        CreateresourceDimensionExceedsFeatureLevelDefinition = 0x100036,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED")]
        CreateresourceOnlySingleMipLevelDepthStencilSupported = 0x100037,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR")]
        DeviceRssetscissorrectsNegativescissor = 0x100038,
        [NativeName("Name", "D3D11_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA")]
        SlotZeroMustBED3D10InputPerVertexData = 0x100039,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP")]
        CreateresourceNonPow2Mipmap = 0x10003A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED")]
        CreatesamplerstateBorderNotSupported = 0x10003B,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT")]
        OmsetrendertargetsNoSrgbMrt = 0x10003C,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES")]
        CopyresourceNo3DMismatchedUpdates = 0x10003D,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10L9_MESSAGES_END")]
        D3D10L9MessagesEnd = 0x10003E,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_MESSAGES_START")]
        D3D11MessagesStart = 0x200000,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS")]
        CreatedepthstencilviewInvalidflags = 0x200001,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE")]
        CreatevertexshaderInvalidclasslinkage = 0x200002,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE")]
        CreategeometryshaderInvalidclasslinkage = 0x200003,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTREAMS")]
        CreategeometryshaderwithstreamoutputInvalidnumstreams = 0x200004,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER")]
        CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 0x200005,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTREAMS")]
        CreategeometryshaderwithstreamoutputUnexpectedstreams = 0x200006,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCLASSLINKAGE")]
        CreategeometryshaderwithstreamoutputInvalidclasslinkage = 0x200007,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE")]
        CreatepixelshaderInvalidclasslinkage = 0x200008,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_COMMANDLISTFLAGS")]
        CreatedeferredcontextInvalidCommandlistflags = 0x200009,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_SINGLETHREADED")]
        CreatedeferredcontextSinglethreaded = 0x20000A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALIDARG_RETURN")]
        CreatedeferredcontextInvalidargReturn = 0x20000B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_CALL_RETURN")]
        CreatedeferredcontextInvalidCallReturn = 0x20000C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_OUTOFMEMORY_RETURN")]
        CreatedeferredcontextOutofmemoryReturn = 0x20000D,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_ONIMMEDIATECONTEXT")]
        FinishdisplaylistOnimmediatecontext = 0x20000E,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_OUTOFMEMORY_RETURN")]
        FinishdisplaylistOutofmemoryReturn = 0x20000F,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_INVALID_CALL_RETURN")]
        FinishdisplaylistInvalidCallReturn = 0x200010,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM")]
        CreategeometryshaderwithstreamoutputInvalidstream = 0x200011,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES")]
        CreategeometryshaderwithstreamoutputUnexpectedentries = 0x200012,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES")]
        CreategeometryshaderwithstreamoutputUnexpectedstrides = 0x200013,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES")]
        CreategeometryshaderwithstreamoutputInvalidnumstrides = 0x200014,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_HAZARD")]
        DeviceHssetshaderresourcesHazard = 0x200015,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_HAZARD")]
        DeviceHssetconstantbuffersHazard = 0x200016,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        HssetshaderresourcesUnbinddeletingobject = 0x200017,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        HssetconstantbuffersUnbinddeletingobject = 0x200018,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCALL")]
        CreatehullshaderInvalidcall = 0x200019,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY")]
        CreatehullshaderOutofmemory = 0x20001A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE")]
        CreatehullshaderInvalidshaderbytecode = 0x20001B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE")]
        CreatehullshaderInvalidshadertype = 0x20001C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE")]
        CreatehullshaderInvalidclasslinkage = 0x20001D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceHssetshaderresourcesViewsEmpty = 0x20001E,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        HssetconstantbuffersInvalidbuffer = 0x20001F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceHssetconstantbuffersBuffersEmpty = 0x200020,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceHssetsamplersSamplersEmpty = 0x200021,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceHsgetshaderresourcesViewsEmpty = 0x200022,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceHsgetconstantbuffersBuffersEmpty = 0x200023,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceHsgetsamplersSamplersEmpty = 0x200024,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_HAZARD")]
        DeviceDssetshaderresourcesHazard = 0x200025,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_HAZARD")]
        DeviceDssetconstantbuffersHazard = 0x200026,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        DssetshaderresourcesUnbinddeletingobject = 0x200027,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        DssetconstantbuffersUnbinddeletingobject = 0x200028,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCALL")]
        CreatedomainshaderInvalidcall = 0x200029,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY")]
        CreatedomainshaderOutofmemory = 0x20002A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE")]
        CreatedomainshaderInvalidshaderbytecode = 0x20002B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE")]
        CreatedomainshaderInvalidshadertype = 0x20002C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE")]
        CreatedomainshaderInvalidclasslinkage = 0x20002D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceDssetshaderresourcesViewsEmpty = 0x20002E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        DssetconstantbuffersInvalidbuffer = 0x20002F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceDssetconstantbuffersBuffersEmpty = 0x200030,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceDssetsamplersSamplersEmpty = 0x200031,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceDsgetshaderresourcesViewsEmpty = 0x200032,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceDsgetconstantbuffersBuffersEmpty = 0x200033,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceDsgetsamplersSamplersEmpty = 0x200034,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_XOR_DS_MISMATCH")]
        DeviceDrawHSXorDSMismatch = 0x200035,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEFERRED_CONTEXT_REMOVAL_PROCESS_AT_FAULT")]
        DeferredContextRemovalProcessATFault = 0x200036,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_INVALID_ARG_BUFFER")]
        DeviceDrawindirectInvalidArgBuffer = 0x200037,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_UNALIGNED")]
        DeviceDrawindirectOffsetUnaligned = 0x200038,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_OVERFLOW")]
        DeviceDrawindirectOffsetOverflow = 0x200039,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDMAPTYPE")]
        ResourceMapInvalidmaptype = 0x20003A,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDSUBRESOURCE")]
        ResourceMapInvalidsubresource = 0x20003B,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDFLAGS")]
        ResourceMapInvalidflags = 0x20003C,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_ALREADYMAPPED")]
        ResourceMapAlreadymapped = 0x20003D,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_DEVICEREMOVED_RETURN")]
        ResourceMapDeviceremovedReturn = 0x20003E,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_OUTOFMEMORY_RETURN")]
        ResourceMapOutofmemoryReturn = 0x20003F,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_WITHOUT_INITIAL_DISCARD")]
        ResourceMapWithoutInitialDiscard = 0x200040,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_UNMAP_INVALIDSUBRESOURCE")]
        ResourceUnmapInvalidsubresource = 0x200041,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED")]
        ResourceUnmapNotmapped = 0x200042,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RASTERIZING_CONTROL_POINTS")]
        DeviceDrawRasterizingControlPoints = 0x200043,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNSUPPORTED")]
        DeviceIasetprimitivetopologyTopologyUnsupported = 0x200044,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_SIGNATURE_MISMATCH")]
        DeviceDrawHSDSSignatureMismatch = 0x200045,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH")]
        DeviceDrawHullShaderInputTopologyMismatch = 0x200046,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_CONTROL_POINT_COUNT_MISMATCH")]
        DeviceDrawHSDSControlPointCountMismatch = 0x200047,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_TESSELLATOR_DOMAIN_MISMATCH")]
        DeviceDrawHSDSTessellatorDomainMismatch = 0x200048,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CONTEXT")]
        CreateContext = 0x200049,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CONTEXT")]
        LiveContext = 0x20004A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CONTEXT")]
        DestroyContext = 0x20004B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_BUFFER")]
        CreateBuffer = 0x20004C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BUFFER_WIN7")]
        LiveBufferWin7 = 0x20004D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_BUFFER")]
        DestroyBuffer = 0x20004E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE1D")]
        CreateTexture1D = 0x20004F,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE1D_WIN7")]
        LiveTexture1DWin7 = 0x200050,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE1D")]
        DestroyTexture1D = 0x200051,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE2D")]
        CreateTexture2D = 0x200052,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE2D_WIN7")]
        LiveTexture2DWin7 = 0x200053,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE2D")]
        DestroyTexture2D = 0x200054,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE3D")]
        CreateTexture3D = 0x200055,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE3D_WIN7")]
        LiveTexture3DWin7 = 0x200056,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE3D")]
        DestroyTexture3D = 0x200057,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SHADERRESOURCEVIEW")]
        CreateShaderresourceview = 0x200058,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW_WIN7")]
        LiveShaderresourceviewWin7 = 0x200059,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SHADERRESOURCEVIEW")]
        DestroyShaderresourceview = 0x20005A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_RENDERTARGETVIEW")]
        CreateRendertargetview = 0x20005B,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW_WIN7")]
        LiveRendertargetviewWin7 = 0x20005C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_RENDERTARGETVIEW")]
        DestroyRendertargetview = 0x20005D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILVIEW")]
        CreateDepthstencilview = 0x20005E,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW_WIN7")]
        LiveDepthstencilviewWin7 = 0x20005F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILVIEW")]
        DestroyDepthstencilview = 0x200060,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VERTEXSHADER")]
        CreateVertexshader = 0x200061,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VERTEXSHADER_WIN7")]
        LiveVertexshaderWin7 = 0x200062,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VERTEXSHADER")]
        DestroyVertexshader = 0x200063,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_HULLSHADER")]
        CreateHullshader = 0x200064,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_HULLSHADER")]
        LiveHullshader = 0x200065,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_HULLSHADER")]
        DestroyHullshader = 0x200066,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DOMAINSHADER")]
        CreateDomainshader = 0x200067,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DOMAINSHADER")]
        LiveDomainshader = 0x200068,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DOMAINSHADER")]
        DestroyDomainshader = 0x200069,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_GEOMETRYSHADER")]
        CreateGeometryshader = 0x20006A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER_WIN7")]
        LiveGeometryshaderWin7 = 0x20006B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_GEOMETRYSHADER")]
        DestroyGeometryshader = 0x20006C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PIXELSHADER")]
        CreatePixelshader = 0x20006D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PIXELSHADER_WIN7")]
        LivePixelshaderWin7 = 0x20006E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PIXELSHADER")]
        DestroyPixelshader = 0x20006F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_INPUTLAYOUT")]
        CreateInputlayout = 0x200070,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT_WIN7")]
        LiveInputlayoutWin7 = 0x200071,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_INPUTLAYOUT")]
        DestroyInputlayout = 0x200072,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SAMPLER")]
        CreateSampler = 0x200073,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SAMPLER_WIN7")]
        LiveSamplerWin7 = 0x200074,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SAMPLER")]
        DestroySampler = 0x200075,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_BLENDSTATE")]
        CreateBlendstate = 0x200076,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BLENDSTATE_WIN7")]
        LiveBlendstateWin7 = 0x200077,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_BLENDSTATE")]
        DestroyBlendstate = 0x200078,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILSTATE")]
        CreateDepthstencilstate = 0x200079,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE_WIN7")]
        LiveDepthstencilstateWin7 = 0x20007A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILSTATE")]
        DestroyDepthstencilstate = 0x20007B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_RASTERIZERSTATE")]
        CreateRasterizerstate = 0x20007C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE_WIN7")]
        LiveRasterizerstateWin7 = 0x20007D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_RASTERIZERSTATE")]
        DestroyRasterizerstate = 0x20007E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_QUERY")]
        CreateQuery = 0x20007F,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_QUERY_WIN7")]
        LiveQueryWin7 = 0x200080,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_QUERY")]
        DestroyQuery = 0x200081,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PREDICATE")]
        CreatePredicate = 0x200082,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PREDICATE_WIN7")]
        LivePredicateWin7 = 0x200083,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PREDICATE")]
        DestroyPredicate = 0x200084,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COUNTER")]
        CreateCounter = 0x200085,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COUNTER")]
        DestroyCounter = 0x200086,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COMMANDLIST")]
        CreateCommandlist = 0x200087,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COMMANDLIST")]
        LiveCommandlist = 0x200088,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COMMANDLIST")]
        DestroyCommandlist = 0x200089,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CLASSINSTANCE")]
        CreateClassinstance = 0x20008A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CLASSINSTANCE")]
        LiveClassinstance = 0x20008B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CLASSINSTANCE")]
        DestroyClassinstance = 0x20008C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CLASSLINKAGE")]
        CreateClasslinkage = 0x20008D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CLASSLINKAGE")]
        LiveClasslinkage = 0x20008E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CLASSLINKAGE")]
        DestroyClasslinkage = 0x20008F,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICE_WIN7")]
        LiveDeviceWin7 = 0x200090,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY_WIN7")]
        LiveObjectSummaryWin7 = 0x200091,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COMPUTESHADER")]
        CreateComputeshader = 0x200092,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COMPUTESHADER")]
        LiveComputeshader = 0x200093,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COMPUTESHADER")]
        DestroyComputeshader = 0x200094,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_UNORDEREDACCESSVIEW")]
        CreateUnorderedaccessview = 0x200095,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_UNORDEREDACCESSVIEW")]
        LiveUnorderedaccessview = 0x200096,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_UNORDEREDACCESSVIEW")]
        DestroyUnorderedaccessview = 0x200097,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACES_FEATURELEVEL")]
        DeviceSetshaderInterfacesFeaturelevel = 0x200098,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACE_COUNT_MISMATCH")]
        DeviceSetshaderInterfaceCountMismatch = 0x200099,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE")]
        DeviceSetshaderInvalidInstance = 0x20009A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_INDEX")]
        DeviceSetshaderInvalidInstanceIndex = 0x20009B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_TYPE")]
        DeviceSetshaderInvalidInstanceType = 0x20009C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_DATA")]
        DeviceSetshaderInvalidInstanceData = 0x20009D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_UNBOUND_INSTANCE_DATA")]
        DeviceSetshaderUnboundInstanceData = 0x20009E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INSTANCE_DATA_BINDINGS")]
        DeviceSetshaderInstanceDataBindings = 0x20009F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATESHADER_CLASSLINKAGE_FULL")]
        DeviceCreateshaderClasslinkageFull = 0x2000A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_UNRECOGNIZED_FEATURE")]
        DeviceCheckfeaturesupportUnrecognizedFeature = 0x2000A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE")]
        DeviceCheckfeaturesupportMismatchedDataSize = 0x2000A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_INVALIDARG_RETURN")]
        DeviceCheckfeaturesupportInvalidargReturn = 0x2000A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_HAZARD")]
        DeviceCssetshaderresourcesHazard = 0x2000A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_HAZARD")]
        DeviceCssetconstantbuffersHazard = 0x2000A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        CssetshaderresourcesUnbinddeletingobject = 0x2000A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        CssetconstantbuffersUnbinddeletingobject = 0x2000A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCALL")]
        CreatecomputeshaderInvalidcall = 0x2000A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY")]
        CreatecomputeshaderOutofmemory = 0x2000A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE")]
        CreatecomputeshaderInvalidshaderbytecode = 0x2000AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERTYPE")]
        CreatecomputeshaderInvalidshadertype = 0x2000AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE")]
        CreatecomputeshaderInvalidclasslinkage = 0x2000AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceCssetshaderresourcesViewsEmpty = 0x2000AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        CssetconstantbuffersInvalidbuffer = 0x2000AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceCssetconstantbuffersBuffersEmpty = 0x2000AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceCssetsamplersSamplersEmpty = 0x2000B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETSHADERRESOURCES_VIEWS_EMPTY")]
        DeviceCsgetshaderresourcesViewsEmpty = 0x2000B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        DeviceCsgetconstantbuffersBuffersEmpty = 0x2000B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETSAMPLERS_SAMPLERS_EMPTY")]
        DeviceCsgetsamplersSamplersEmpty = 0x2000B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatevertexshaderDoublefloatopsnotsupported = 0x2000B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatehullshaderDoublefloatopsnotsupported = 0x2000B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatedomainshaderDoublefloatopsnotsupported = 0x2000B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreategeometryshaderDoublefloatopsnotsupported = 0x2000B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 0x2000B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatepixelshaderDoublefloatopsnotsupported = 0x2000B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatecomputeshaderDoublefloatopsnotsupported = 0x2000BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSTRUCTURESTRIDE")]
        CreatebufferInvalidstructurestride = 0x2000BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFLAGS")]
        CreateshaderresourceviewInvalidflags = 0x2000BC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE")]
        CreateunorderedaccessviewInvalidresource = 0x2000BD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC")]
        CreateunorderedaccessviewInvaliddesc = 0x2000BE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT")]
        CreateunorderedaccessviewInvalidformat = 0x2000BF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS")]
        CreateunorderedaccessviewInvaliddimensions = 0x2000C0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT")]
        CreateunorderedaccessviewUnrecognizedformat = 0x2000C1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_HAZARD")]
        DeviceOmsetrendertargetsandunorderedaccessviewsHazard = 0x2000C2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_OVERLAPPING_OLD_SLOTS")]
        DeviceOmsetrendertargetsandunorderedaccessviewsOverlappingOldSlots = 0x2000C3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NO_OP")]
        DeviceOmsetrendertargetsandunorderedaccessviewsNoOp = 0x2000C4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT")]
        CssetunorderedaccessviewsUnbinddeletingobject = 0x2000C5,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT")]
        PssetunorderedaccessviewsUnbinddeletingobject = 0x2000C6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDARG_RETURN")]
        CreateunorderedaccessviewInvalidargReturn = 0x2000C7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_OUTOFMEMORY_RETURN")]
        CreateunorderedaccessviewOutofmemoryReturn = 0x2000C8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_TOOMANYOBJECTS")]
        CreateunorderedaccessviewToomanyobjects = 0x2000C9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_HAZARD")]
        DeviceCssetunorderedaccessviewsHazard = 0x2000CA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_DENORMFLUSH")]
        ClearunorderedaccessviewDenormflush = 0x2000CB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSS_VIEWS_EMPTY")]
        DeviceCssetunorderedaccesssViewsEmpty = 0x2000CC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETUNORDEREDACCESSS_VIEWS_EMPTY")]
        DeviceCsgetunorderedaccesssViewsEmpty = 0x2000CD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS")]
        CreateunorderedaccessviewInvalidflags = 0x2000CE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESESOURCEVIEW_TOOMANYOBJECTS")]
        CreateshaderresesourceviewToomanyobjects = 0x2000CF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_INVALID_ARG_BUFFER")]
        DeviceDispatchindirectInvalidArgBuffer = 0x2000D0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_UNALIGNED")]
        DeviceDispatchindirectOffsetUnaligned = 0x2000D1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_OVERFLOW")]
        DeviceDispatchindirectOffsetOverflow = 0x2000D2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDCONTEXT")]
        DeviceSetresourceminlodInvalidcontext = 0x2000D3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDRESOURCE")]
        DeviceSetresourceminlodInvalidresource = 0x2000D4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDMINLOD")]
        DeviceSetresourceminlodInvalidminlod = 0x2000D5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDCONTEXT")]
        DeviceGetresourceminlodInvalidcontext = 0x2000D6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDRESOURCE")]
        DeviceGetresourceminlodInvalidresource = 0x2000D7,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETDEPTHSTENCIL_UNBINDDELETINGOBJECT")]
        OmsetdepthstencilUnbinddeletingobject = 0x2000D8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DEPTH_READONLY")]
        CleardepthstencilviewDepthReadonly = 0x2000D9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_STENCIL_READONLY")]
        CleardepthstencilviewStencilReadonly = 0x2000DA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFEATURESUPPORT_FORMAT_DEPRECATED")]
        CheckfeaturesupportFormatDeprecated = 0x2000DB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RETURN_TYPE_MISMATCH")]
        DeviceUnorderedaccessviewReturnTypeMismatch = 0x2000DC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET")]
        DeviceUnorderedaccessviewNotSet = 0x2000DD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_UNORDEREDACCESSVIEW_RENDERTARGETVIEW_OVERLAP")]
        DeviceDrawUnorderedaccessviewRendertargetviewOverlap = 0x2000DE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_DIMENSION_MISMATCH")]
        DeviceUnorderedaccessviewDimensionMismatch = 0x2000DF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_APPEND_UNSUPPORTED")]
        DeviceUnorderedaccessviewAppendUnsupported = 0x2000E0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMICS_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicsUnsupported = 0x2000E1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_STRUCTURE_STRIDE_MISMATCH")]
        DeviceUnorderedaccessviewStructureStrideMismatch = 0x2000E2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_BUFFER_TYPE_MISMATCH")]
        DeviceUnorderedaccessviewBufferTypeMismatch = 0x2000E3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RAW_UNSUPPORTED")]
        DeviceUnorderedaccessviewRawUnsupported = 0x2000E4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_LD_UNSUPPORTED")]
        DeviceUnorderedaccessviewFormatLDUnsupported = 0x2000E5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_STORE_UNSUPPORTED")]
        DeviceUnorderedaccessviewFormatStoreUnsupported = 0x2000E6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_ADD_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicAddUnsupported = 0x2000E7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_BITWISE_OPS_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicBitwiseOpsUnsupported = 0x2000E8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_CMPSTORE_CMPEXCHANGE_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicCmpstoreCmpexchangeUnsupported = 0x2000E9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_EXCHANGE_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicExchangeUnsupported = 0x2000EA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_SIGNED_MINMAX_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicSignedMinmaxUnsupported = 0x2000EB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_UNSIGNED_MINMAX_UNSUPPORTED")]
        DeviceUnorderedaccessviewAtomicUnsignedMinmaxUnsupported = 0x2000EC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_BOUND_RESOURCE_MAPPED")]
        DeviceDispatchBoundResourceMapped = 0x2000ED,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_OVERFLOW")]
        DeviceDispatchThreadgroupcountOverflow = 0x2000EE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_ZERO")]
        DeviceDispatchThreadgroupcountZero = 0x2000EF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_STRUCTURE_STRIDE_MISMATCH")]
        DeviceShaderresourceviewStructureStrideMismatch = 0x2000F0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_BUFFER_TYPE_MISMATCH")]
        DeviceShaderresourceviewBufferTypeMismatch = 0x2000F1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_RAW_UNSUPPORTED")]
        DeviceShaderresourceviewRawUnsupported = 0x2000F2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_UNSUPPORTED")]
        DeviceDispatchUnsupported = 0x2000F3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_UNSUPPORTED")]
        DeviceDispatchindirectUnsupported = 0x2000F4,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDOFFSET")]
        CopystructurecountInvalidoffset = 0x2000F5,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_LARGEOFFSET")]
        CopystructurecountLargeoffset = 0x2000F6,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDDESTINATIONSTATE")]
        CopystructurecountInvaliddestinationstate = 0x2000F7,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDSOURCESTATE")]
        CopystructurecountInvalidsourcestate = 0x2000F8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_NOT_SUPPORTED")]
        CheckformatsupportFormatNotSupported = 0x2000F9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDVIEW")]
        DeviceCssetunorderedaccessviewsInvalidview = 0x2000FA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDOFFSET")]
        DeviceCssetunorderedaccessviewsInvalidoffset = 0x2000FB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_TOOMANYVIEWS")]
        DeviceCssetunorderedaccessviewsToomanyviews = 0x2000FC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_INVALIDFORMAT")]
        ClearunorderedaccessviewfloatInvalidformat = 0x2000FD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_COUNTER_UNSUPPORTED")]
        DeviceUnorderedaccessviewCounterUnsupported = 0x2000FE,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING")]
        RefWarning = 0x2000FF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_PIXEL_SHADER_WITHOUT_RTV_OR_DSV")]
        DeviceDrawPixelShaderWithoutRtvOrDsv = 0x200100,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_ABORT")]
        ShaderAbort = 0x200101,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_MESSAGE")]
        ShaderMessage = 0x200102,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_ERROR")]
        ShaderError = 0x200103,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDRESOURCE")]
        OfferresourcesInvalidresource = 0x200104,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        HssetsamplersUnbinddeletingobject = 0x200105,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        DssetsamplersUnbinddeletingobject = 0x200106,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        CssetsamplersUnbinddeletingobject = 0x200107,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSHADER_UNBINDDELETINGOBJECT")]
        HssetshaderUnbinddeletingobject = 0x200108,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSHADER_UNBINDDELETINGOBJECT")]
        DssetshaderUnbinddeletingobject = 0x200109,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSHADER_UNBINDDELETINGOBJECT")]
        CssetshaderUnbinddeletingobject = 0x20010A,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_INVALIDARG_RETURN")]
        EnqueueseteventInvalidargReturn = 0x20010B,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_OUTOFMEMORY_RETURN")]
        EnqueueseteventOutofmemoryReturn = 0x20010C,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_ACCESSDENIED_RETURN")]
        EnqueueseteventAccessdeniedReturn = 0x20010D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NUMUAVS_INVALIDRANGE")]
        DeviceOmsetrendertargetsandunorderedaccessviewsNumuavsInvalidrange = 0x20010E,
        [NativeName("Name", "D3D11_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT")]
        UseOfZeroRefcountObject = 0x20010F,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_MESSAGES_END")]
        D3D11MessagesEnd = 0x200110,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_1_MESSAGES_START")]
        D3D111MessagesStart = 0x300000,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEODECODER")]
        CreateVideodecoder = 0x300001,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSORENUM")]
        CreateVideoprocessorenum = 0x300002,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSOR")]
        CreateVideoprocessor = 0x300003,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DECODEROUTPUTVIEW")]
        CreateDecoderoutputview = 0x300004,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PROCESSORINPUTVIEW")]
        CreateProcessorinputview = 0x300005,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PROCESSOROUTPUTVIEW")]
        CreateProcessoroutputview = 0x300006,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEVICECONTEXTSTATE")]
        CreateDevicecontextstate = 0x300007,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEODECODER")]
        LiveVideodecoder = 0x300008,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSORENUM")]
        LiveVideoprocessorenum = 0x300009,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSOR")]
        LiveVideoprocessor = 0x30000A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DECODEROUTPUTVIEW")]
        LiveDecoderoutputview = 0x30000B,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PROCESSORINPUTVIEW")]
        LiveProcessorinputview = 0x30000C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PROCESSOROUTPUTVIEW")]
        LiveProcessoroutputview = 0x30000D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICECONTEXTSTATE")]
        LiveDevicecontextstate = 0x30000E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEODECODER")]
        DestroyVideodecoder = 0x30000F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSORENUM")]
        DestroyVideoprocessorenum = 0x300010,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSOR")]
        DestroyVideoprocessor = 0x300011,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DECODEROUTPUTVIEW")]
        DestroyDecoderoutputview = 0x300012,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PROCESSORINPUTVIEW")]
        DestroyProcessorinputview = 0x300013,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PROCESSOROUTPUTVIEW")]
        DestroyProcessoroutputview = 0x300014,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEVICECONTEXTSTATE")]
        DestroyDevicecontextstate = 0x300015,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFLAGS")]
        CreatedevicecontextstateInvalidflags = 0x300016,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFEATURELEVEL")]
        CreatedevicecontextstateInvalidfeaturelevel = 0x300017,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_FEATURELEVELS_NOT_SUPPORTED")]
        CreatedevicecontextstateFeaturelevelsNotSupported = 0x300018,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDREFIID")]
        CreatedevicecontextstateInvalidrefiid = 0x300019,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISCARDVIEW_INVALIDVIEW")]
        DeviceDiscardviewInvalidview = 0x30001A,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION1_INVALIDCOPYFLAGS")]
        Copysubresourceregion1Invalidcopyflags = 0x30001B,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE1_INVALIDCOPYFLAGS")]
        Updatesubresource1Invalidcopyflags = 0x30001C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT")]
        CreaterasterizerstateInvalidforcedsamplecount = 0x30001D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_OUTOFMEMORY_RETURN")]
        CreatevideodecoderOutofmemoryReturn = 0x30001E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_NULLPARAM")]
        CreatevideodecoderNullparam = 0x30001F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_INVALIDFORMAT")]
        CreatevideodecoderInvalidformat = 0x300020,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_ZEROWIDTHHEIGHT")]
        CreatevideodecoderZerowidthheight = 0x300021,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERSIZE")]
        CreatevideodecoderDriverInvalidbuffersize = 0x300022,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERUSAGE")]
        CreatevideodecoderDriverInvalidbufferusage = 0x300023,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILECOUNT_OUTOFMEMORY")]
        GetvideodecoderprofilecountOutofmemory = 0x300024,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_NULLPARAM")]
        GetvideodecoderprofileNullparam = 0x300025,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_INVALIDINDEX")]
        GetvideodecoderprofileInvalidindex = 0x300026,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_OUTOFMEMORY_RETURN")]
        GetvideodecoderprofileOutofmemoryReturn = 0x300027,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_NULLPARAM")]
        CheckvideodecoderformatNullparam = 0x300028,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_OUTOFMEMORY_RETURN")]
        CheckvideodecoderformatOutofmemoryReturn = 0x300029,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_NULLPARAM")]
        GetvideodecoderconfigcountNullparam = 0x30002A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_OUTOFMEMORY_RETURN")]
        GetvideodecoderconfigcountOutofmemoryReturn = 0x30002B,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_NULLPARAM")]
        GetvideodecoderconfigNullparam = 0x30002C,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_INVALIDINDEX")]
        GetvideodecoderconfigInvalidindex = 0x30002D,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_OUTOFMEMORY_RETURN")]
        GetvideodecoderconfigOutofmemoryReturn = 0x30002E,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERCREATIONPARAMS_NULLPARAM")]
        GetdecodercreationparamsNullparam = 0x30002F,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERDRIVERHANDLE_NULLPARAM")]
        GetdecoderdriverhandleNullparam = 0x300030,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_NULLPARAM")]
        GetdecoderbufferNullparam = 0x300031,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDBUFFER")]
        GetdecoderbufferInvalidbuffer = 0x300032,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDTYPE")]
        GetdecoderbufferInvalidtype = 0x300033,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_LOCKED")]
        GetdecoderbufferLocked = 0x300034,
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NULLPARAM")]
        ReleasedecoderbufferNullparam = 0x300035,
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_INVALIDTYPE")]
        ReleasedecoderbufferInvalidtype = 0x300036,
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NOTLOCKED")]
        ReleasedecoderbufferNotlocked = 0x300037,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_NULLPARAM")]
        DecoderbeginframeNullparam = 0x300038,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_HAZARD")]
        DecoderbeginframeHazard = 0x300039,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERENDFRAME_NULLPARAM")]
        DecoderendframeNullparam = 0x30003A,
        [NativeName("Name", "D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_NULLPARAM")]
        SubmitdecoderbuffersNullparam = 0x30003B,
        [NativeName("Name", "D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_INVALIDTYPE")]
        SubmitdecoderbuffersInvalidtype = 0x30003C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODEREXTENSION_NULLPARAM")]
        DecoderextensionNullparam = 0x30003D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODEREXTENSION_INVALIDRESOURCE")]
        DecoderextensionInvalidresource = 0x30003E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_OUTOFMEMORY_RETURN")]
        CreatevideoprocessorenumeratorOutofmemoryReturn = 0x30003F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_NULLPARAM")]
        CreatevideoprocessorenumeratorNullparam = 0x300040,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDFRAMEFORMAT")]
        CreatevideoprocessorenumeratorInvalidframeformat = 0x300041,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDUSAGE")]
        CreatevideoprocessorenumeratorInvalidusage = 0x300042,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDINPUTFRAMERATE")]
        CreatevideoprocessorenumeratorInvalidinputframerate = 0x300043,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDOUTPUTFRAMERATE")]
        CreatevideoprocessorenumeratorInvalidoutputframerate = 0x300044,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDWIDTHHEIGHT")]
        CreatevideoprocessorenumeratorInvalidwidthheight = 0x300045,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCONTENTDESC_NULLPARAM")]
        GetvideoprocessorcontentdescNullparam = 0x300046,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMAT_NULLPARAM")]
        CheckvideoprocessorformatNullparam = 0x300047,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCAPS_NULLPARAM")]
        GetvideoprocessorcapsNullparam = 0x300048,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_NULLPARAM")]
        GetvideoprocessorrateconversioncapsNullparam = 0x300049,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_INVALIDINDEX")]
        GetvideoprocessorrateconversioncapsInvalidindex = 0x30004A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_NULLPARAM")]
        GetvideoprocessorcustomrateNullparam = 0x30004B,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_INVALIDINDEX")]
        GetvideoprocessorcustomrateInvalidindex = 0x30004C,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_NULLPARAM")]
        GetvideoprocessorfilterrangeNullparam = 0x30004D,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_UNSUPPORTED")]
        GetvideoprocessorfilterrangeUnsupported = 0x30004E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_OUTOFMEMORY_RETURN")]
        CreatevideoprocessorOutofmemoryReturn = 0x30004F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_NULLPARAM")]
        CreatevideoprocessorNullparam = 0x300050,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTTARGETRECT_NULLPARAM")]
        VideoprocessorsetoutputtargetrectNullparam = 0x300051,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_NULLPARAM")]
        VideoprocessorsetoutputbackgroundcolorNullparam = 0x300052,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_INVALIDALPHA")]
        VideoprocessorsetoutputbackgroundcolorInvalidalpha = 0x300053,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE_NULLPARAM")]
        VideoprocessorsetoutputcolorspaceNullparam = 0x300054,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_NULLPARAM")]
        VideoprocessorsetoutputalphafillmodeNullparam = 0x300055,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_UNSUPPORTED")]
        VideoprocessorsetoutputalphafillmodeUnsupported = 0x300056,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDSTREAM")]
        VideoprocessorsetoutputalphafillmodeInvalidstream = 0x300057,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDFILLMODE")]
        VideoprocessorsetoutputalphafillmodeInvalidfillmode = 0x300058,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_NULLPARAM")]
        VideoprocessorsetoutputconstrictionNullparam = 0x300059,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_NULLPARAM")]
        VideoprocessorsetoutputstereomodeNullparam = 0x30005A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_UNSUPPORTED")]
        VideoprocessorsetoutputstereomodeUnsupported = 0x30005B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTEXTENSION_NULLPARAM")]
        VideoprocessorsetoutputextensionNullparam = 0x30005C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTTARGETRECT_NULLPARAM")]
        VideoprocessorgetoutputtargetrectNullparam = 0x30005D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTBACKGROUNDCOLOR_NULLPARAM")]
        VideoprocessorgetoutputbackgroundcolorNullparam = 0x30005E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE_NULLPARAM")]
        VideoprocessorgetoutputcolorspaceNullparam = 0x30005F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTALPHAFILLMODE_NULLPARAM")]
        VideoprocessorgetoutputalphafillmodeNullparam = 0x300060,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCONSTRICTION_NULLPARAM")]
        VideoprocessorgetoutputconstrictionNullparam = 0x300061,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_UNSUPPORTED")]
        VideoprocessorsetoutputconstrictionUnsupported = 0x300062,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_INVALIDSIZE")]
        VideoprocessorsetoutputconstrictionInvalidsize = 0x300063,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSTEREOMODE_NULLPARAM")]
        VideoprocessorgetoutputstereomodeNullparam = 0x300064,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTEXTENSION_NULLPARAM")]
        VideoprocessorgetoutputextensionNullparam = 0x300065,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_NULLPARAM")]
        VideoprocessorsetstreamframeformatNullparam = 0x300066,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDFORMAT")]
        VideoprocessorsetstreamframeformatInvalidformat = 0x300067,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDSTREAM")]
        VideoprocessorsetstreamframeformatInvalidstream = 0x300068,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_NULLPARAM")]
        VideoprocessorsetstreamcolorspaceNullparam = 0x300069,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_INVALIDSTREAM")]
        VideoprocessorsetstreamcolorspaceInvalidstream = 0x30006A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_NULLPARAM")]
        VideoprocessorsetstreamoutputrateNullparam = 0x30006B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDRATE")]
        VideoprocessorsetstreamoutputrateInvalidrate = 0x30006C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDFLAG")]
        VideoprocessorsetstreamoutputrateInvalidflag = 0x30006D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDSTREAM")]
        VideoprocessorsetstreamoutputrateInvalidstream = 0x30006E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_NULLPARAM")]
        VideoprocessorsetstreamsourcerectNullparam = 0x30006F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDSTREAM")]
        VideoprocessorsetstreamsourcerectInvalidstream = 0x300070,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDRECT")]
        VideoprocessorsetstreamsourcerectInvalidrect = 0x300071,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_NULLPARAM")]
        VideoprocessorsetstreamdestrectNullparam = 0x300072,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDSTREAM")]
        VideoprocessorsetstreamdestrectInvalidstream = 0x300073,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDRECT")]
        VideoprocessorsetstreamdestrectInvalidrect = 0x300074,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_NULLPARAM")]
        VideoprocessorsetstreamalphaNullparam = 0x300075,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDSTREAM")]
        VideoprocessorsetstreamalphaInvalidstream = 0x300076,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDALPHA")]
        VideoprocessorsetstreamalphaInvalidalpha = 0x300077,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_NULLPARAM")]
        VideoprocessorsetstreampaletteNullparam = 0x300078,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDSTREAM")]
        VideoprocessorsetstreampaletteInvalidstream = 0x300079,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDCOUNT")]
        VideoprocessorsetstreampaletteInvalidcount = 0x30007A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDALPHA")]
        VideoprocessorsetstreampaletteInvalidalpha = 0x30007B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_NULLPARAM")]
        VideoprocessorsetstreampixelaspectratioNullparam = 0x30007C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDSTREAM")]
        VideoprocessorsetstreampixelaspectratioInvalidstream = 0x30007D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDRATIO")]
        VideoprocessorsetstreampixelaspectratioInvalidratio = 0x30007E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_NULLPARAM")]
        VideoprocessorsetstreamlumakeyNullparam = 0x30007F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDSTREAM")]
        VideoprocessorsetstreamlumakeyInvalidstream = 0x300080,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDRANGE")]
        VideoprocessorsetstreamlumakeyInvalidrange = 0x300081,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_UNSUPPORTED")]
        VideoprocessorsetstreamlumakeyUnsupported = 0x300082,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_NULLPARAM")]
        VideoprocessorsetstreamstereoformatNullparam = 0x300083,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDSTREAM")]
        VideoprocessorsetstreamstereoformatInvalidstream = 0x300084,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_UNSUPPORTED")]
        VideoprocessorsetstreamstereoformatUnsupported = 0x300085,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FLIPUNSUPPORTED")]
        VideoprocessorsetstreamstereoformatFlipunsupported = 0x300086,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_MONOOFFSETUNSUPPORTED")]
        VideoprocessorsetstreamstereoformatMonooffsetunsupported = 0x300087,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FORMATUNSUPPORTED")]
        VideoprocessorsetstreamstereoformatFormatunsupported = 0x300088,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDFORMAT")]
        VideoprocessorsetstreamstereoformatInvalidformat = 0x300089,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_NULLPARAM")]
        VideoprocessorsetstreamautoprocessingmodeNullparam = 0x30008A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM")]
        VideoprocessorsetstreamautoprocessingmodeInvalidstream = 0x30008B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_NULLPARAM")]
        VideoprocessorsetstreamfilterNullparam = 0x30008C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDSTREAM")]
        VideoprocessorsetstreamfilterInvalidstream = 0x30008D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDFILTER")]
        VideoprocessorsetstreamfilterInvalidfilter = 0x30008E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_UNSUPPORTED")]
        VideoprocessorsetstreamfilterUnsupported = 0x30008F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDLEVEL")]
        VideoprocessorsetstreamfilterInvalidlevel = 0x300090,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_NULLPARAM")]
        VideoprocessorsetstreamextensionNullparam = 0x300091,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_INVALIDSTREAM")]
        VideoprocessorsetstreamextensionInvalidstream = 0x300092,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_NULLPARAM")]
        VideoprocessorgetstreamframeformatNullparam = 0x300093,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_NULLPARAM")]
        VideoprocessorgetstreamcolorspaceNullparam = 0x300094,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_NULLPARAM")]
        VideoprocessorgetstreamoutputrateNullparam = 0x300095,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_NULLPARAM")]
        VideoprocessorgetstreamsourcerectNullparam = 0x300096,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_NULLPARAM")]
        VideoprocessorgetstreamdestrectNullparam = 0x300097,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_NULLPARAM")]
        VideoprocessorgetstreamalphaNullparam = 0x300098,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_NULLPARAM")]
        VideoprocessorgetstreampaletteNullparam = 0x300099,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_NULLPARAM")]
        VideoprocessorgetstreampixelaspectratioNullparam = 0x30009A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_NULLPARAM")]
        VideoprocessorgetstreamlumakeyNullparam = 0x30009B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_NULLPARAM")]
        VideoprocessorgetstreamstereoformatNullparam = 0x30009C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_NULLPARAM")]
        VideoprocessorgetstreamautoprocessingmodeNullparam = 0x30009D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_NULLPARAM")]
        VideoprocessorgetstreamfilterNullparam = 0x30009E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_NULLPARAM")]
        VideoprocessorgetstreamextensionNullparam = 0x30009F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_INVALIDSTREAM")]
        VideoprocessorgetstreamextensionInvalidstream = 0x3000A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NULLPARAM")]
        VideoprocessorbltNullparam = 0x3000A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSTREAMCOUNT")]
        VideoprocessorbltInvalidstreamcount = 0x3000A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_TARGETRECT")]
        VideoprocessorbltTargetrect = 0x3000A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDOUTPUT")]
        VideoprocessorbltInvalidoutput = 0x3000A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDPASTFRAMES")]
        VideoprocessorbltInvalidpastframes = 0x3000A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDFUTUREFRAMES")]
        VideoprocessorbltInvalidfutureframes = 0x3000A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSOURCERECT")]
        VideoprocessorbltInvalidsourcerect = 0x3000A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDDESTRECT")]
        VideoprocessorbltInvaliddestrect = 0x3000A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDINPUTRESOURCE")]
        VideoprocessorbltInvalidinputresource = 0x3000A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAYSIZE")]
        VideoprocessorbltInvalidarraysize = 0x3000AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAY")]
        VideoprocessorbltInvalidarray = 0x3000AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTEXPECTED")]
        VideoprocessorbltRightexpected = 0x3000AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTNOTEXPECTED")]
        VideoprocessorbltRightnotexpected = 0x3000AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_STEREONOTENABLED")]
        VideoprocessorbltStereonotenabled = 0x3000AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDRIGHTRESOURCE")]
        VideoprocessorbltInvalidrightresource = 0x3000AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NOSTEREOSTREAMS")]
        VideoprocessorbltNostereostreams = 0x3000B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INPUTHAZARD")]
        VideoprocessorbltInputhazard = 0x3000B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_OUTPUTHAZARD")]
        VideoprocessorbltOutputhazard = 0x3000B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_OUTOFMEMORY_RETURN")]
        CreatevideodecoderoutputviewOutofmemoryReturn = 0x3000B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_NULLPARAM")]
        CreatevideodecoderoutputviewNullparam = 0x3000B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDTYPE")]
        CreatevideodecoderoutputviewInvalidtype = 0x3000B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDBIND")]
        CreatevideodecoderoutputviewInvalidbind = 0x3000B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEDFORMAT")]
        CreatevideodecoderoutputviewUnsupportedformat = 0x3000B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDMIP")]
        CreatevideodecoderoutputviewInvalidmip = 0x3000B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEMIP")]
        CreatevideodecoderoutputviewUnsupportemip = 0x3000B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAYSIZE")]
        CreatevideodecoderoutputviewInvalidarraysize = 0x3000BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAY")]
        CreatevideodecoderoutputviewInvalidarray = 0x3000BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDDIMENSION")]
        CreatevideodecoderoutputviewInvaliddimension = 0x3000BC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_OUTOFMEMORY_RETURN")]
        CreatevideoprocessorinputviewOutofmemoryReturn = 0x3000BD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_NULLPARAM")]
        CreatevideoprocessorinputviewNullparam = 0x3000BE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDTYPE")]
        CreatevideoprocessorinputviewInvalidtype = 0x3000BF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDBIND")]
        CreatevideoprocessorinputviewInvalidbind = 0x3000C0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMISC")]
        CreatevideoprocessorinputviewInvalidmisc = 0x3000C1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDUSAGE")]
        CreatevideoprocessorinputviewInvalidusage = 0x3000C2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFORMAT")]
        CreatevideoprocessorinputviewInvalidformat = 0x3000C3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFOURCC")]
        CreatevideoprocessorinputviewInvalidfourcc = 0x3000C4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMIP")]
        CreatevideoprocessorinputviewInvalidmip = 0x3000C5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_UNSUPPORTEDMIP")]
        CreatevideoprocessorinputviewUnsupportedmip = 0x3000C6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAYSIZE")]
        CreatevideoprocessorinputviewInvalidarraysize = 0x3000C7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAY")]
        CreatevideoprocessorinputviewInvalidarray = 0x3000C8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDDIMENSION")]
        CreatevideoprocessorinputviewInvaliddimension = 0x3000C9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_OUTOFMEMORY_RETURN")]
        CreatevideoprocessoroutputviewOutofmemoryReturn = 0x3000CA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_NULLPARAM")]
        CreatevideoprocessoroutputviewNullparam = 0x3000CB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDTYPE")]
        CreatevideoprocessoroutputviewInvalidtype = 0x3000CC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDBIND")]
        CreatevideoprocessoroutputviewInvalidbind = 0x3000CD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDFORMAT")]
        CreatevideoprocessoroutputviewInvalidformat = 0x3000CE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMIP")]
        CreatevideoprocessoroutputviewInvalidmip = 0x3000CF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDMIP")]
        CreatevideoprocessoroutputviewUnsupportedmip = 0x3000D0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDARRAY")]
        CreatevideoprocessoroutputviewUnsupportedarray = 0x3000D1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDARRAY")]
        CreatevideoprocessoroutputviewInvalidarray = 0x3000D2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDDIMENSION")]
        CreatevideoprocessoroutputviewInvaliddimension = 0x3000D3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_FORCED_SAMPLE_COUNT")]
        DeviceDrawInvalidUseOfForcedSampleCount = 0x3000D4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS")]
        CreateblendstateInvalidlogicops = 0x3000D5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDARRAYWITHDECODER")]
        CreateshaderresourceviewInvaliddarraywithdecoder = 0x3000D6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDARRAYWITHDECODER")]
        CreateunorderedaccessviewInvaliddarraywithdecoder = 0x3000D7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDARRAYWITHDECODER")]
        CreaterendertargetviewInvaliddarraywithdecoder = 0x3000D8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_LOCKEDOUT_INTERFACE")]
        DeviceLockedoutInterface = 0x3000D9,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_ATOMIC_INCONSISTENT")]
        RefWarningAtomicInconsistent = 0x3000DA,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_READING_UNINITIALIZED_RESOURCE")]
        RefWarningReadingUninitializedResource = 0x3000DB,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_RAW_HAZARD")]
        RefWarningRawHazard = 0x3000DC,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_WAR_HAZARD")]
        RefWarningWarHazard = 0x3000DD,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_WAW_HAZARD")]
        RefWarningWawHazard = 0x3000DE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECRYPTOSESSION_NULLPARAM")]
        CreatecryptosessionNullparam = 0x3000DF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECRYPTOSESSION_OUTOFMEMORY_RETURN")]
        CreatecryptosessionOutofmemoryReturn = 0x3000E0,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOTYPE_NULLPARAM")]
        GetcryptotypeNullparam = 0x3000E1,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERPROFILE_NULLPARAM")]
        GetdecoderprofileNullparam = 0x3000E2,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATESIZE_NULLPARAM")]
        GetcryptosessioncertificatesizeNullparam = 0x3000E3,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_NULLPARAM")]
        GetcryptosessioncertificateNullparam = 0x3000E4,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_WRONGSIZE")]
        GetcryptosessioncertificateWrongsize = 0x3000E5,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_WRONGSIZE")]
        GetcryptosessionhandleWrongsize = 0x3000E6,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_NULLPARAM")]
        NegotiatecrpytosessionkeyexchangeNullparam = 0x3000E7,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_UNSUPPORTED")]
        EncryptionbltUnsupported = 0x3000E8,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_NULLPARAM")]
        EncryptionbltNullparam = 0x3000E9,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_WRONGDEVICE")]
        EncryptionbltSrcWrongdevice = 0x3000EA,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_WRONGDEVICE")]
        EncryptionbltDstWrongdevice = 0x3000EB,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_FORMAT_MISMATCH")]
        EncryptionbltFormatMismatch = 0x3000EC,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SIZE_MISMATCH")]
        EncryptionbltSizeMismatch = 0x3000ED,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MULTISAMPLED")]
        EncryptionbltSrcMultisampled = 0x3000EE,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_NOT_STAGING")]
        EncryptionbltDstNotStaging = 0x3000EF,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MAPPED")]
        EncryptionbltSrcMapped = 0x3000F0,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_MAPPED")]
        EncryptionbltDstMapped = 0x3000F1,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_OFFERED")]
        EncryptionbltSrcOffered = 0x3000F2,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_OFFERED")]
        EncryptionbltDstOffered = 0x3000F3,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_CONTENT_UNDEFINED")]
        EncryptionbltSrcContentUndefined = 0x3000F4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_UNSUPPORTED")]
        DecryptionbltUnsupported = 0x3000F5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_NULLPARAM")]
        DecryptionbltNullparam = 0x3000F6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_WRONGDEVICE")]
        DecryptionbltSrcWrongdevice = 0x3000F7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_WRONGDEVICE")]
        DecryptionbltDstWrongdevice = 0x3000F8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_FORMAT_MISMATCH")]
        DecryptionbltFormatMismatch = 0x3000F9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SIZE_MISMATCH")]
        DecryptionbltSizeMismatch = 0x3000FA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MULTISAMPLED")]
        DecryptionbltDstMultisampled = 0x3000FB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_NOT_STAGING")]
        DecryptionbltSrcNotStaging = 0x3000FC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_NOT_RENDER_TARGET")]
        DecryptionbltDstNotRenderTarget = 0x3000FD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_MAPPED")]
        DecryptionbltSrcMapped = 0x3000FE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MAPPED")]
        DecryptionbltDstMapped = 0x3000FF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_OFFERED")]
        DecryptionbltSrcOffered = 0x300100,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_OFFERED")]
        DecryptionbltDstOffered = 0x300101,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_CONTENT_UNDEFINED")]
        DecryptionbltSrcContentUndefined = 0x300102,
        [NativeName("Name", "D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_NULLPARAM")]
        StartsessionkeyrefreshNullparam = 0x300103,
        [NativeName("Name", "D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_INVALIDSIZE")]
        StartsessionkeyrefreshInvalidsize = 0x300104,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHSESSIONKEYREFRESH_NULLPARAM")]
        FinishsessionkeyrefreshNullparam = 0x300105,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_NULLPARAM")]
        GetencryptionbltkeyNullparam = 0x300106,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_INVALIDSIZE")]
        GetencryptionbltkeyInvalidsize = 0x300107,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCONTENTPROTECTIONCAPS_NULLPARAM")]
        GetcontentprotectioncapsNullparam = 0x300108,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_NULLPARAM")]
        CheckcryptokeyexchangeNullparam = 0x300109,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_INVALIDINDEX")]
        CheckcryptokeyexchangeInvalidindex = 0x30010A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_NULLPARAM")]
        CreateauthenticatedchannelNullparam = 0x30010B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_UNSUPPORTED")]
        CreateauthenticatedchannelUnsupported = 0x30010C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_INVALIDTYPE")]
        CreateauthenticatedchannelInvalidtype = 0x30010D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_OUTOFMEMORY_RETURN")]
        CreateauthenticatedchannelOutofmemoryReturn = 0x30010E,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_INVALIDCHANNEL")]
        GetauthenticatedchannelcertificatesizeInvalidchannel = 0x30010F,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_NULLPARAM")]
        GetauthenticatedchannelcertificatesizeNullparam = 0x300110,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_INVALIDCHANNEL")]
        GetauthenticatedchannelcertificateInvalidchannel = 0x300111,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_NULLPARAM")]
        GetauthenticatedchannelcertificateNullparam = 0x300112,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_WRONGSIZE")]
        GetauthenticatedchannelcertificateWrongsize = 0x300113,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDCHANNEL")]
        NegotiateauthenticatedchannelkeyexchangeInvalidchannel = 0x300114,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_NULLPARAM")]
        NegotiateauthenticatedchannelkeyexchangeNullparam = 0x300115,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_NULLPARAM")]
        QueryauthenticatedchannelNullparam = 0x300116,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGCHANNEL")]
        QueryauthenticatedchannelWrongchannel = 0x300117,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_UNSUPPORTEDQUERY")]
        QueryauthenticatedchannelUnsupportedquery = 0x300118,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGSIZE")]
        QueryauthenticatedchannelWrongsize = 0x300119,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_INVALIDPROCESSINDEX")]
        QueryauthenticatedchannelInvalidprocessindex = 0x30011A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_NULLPARAM")]
        ConfigureauthenticatedchannelNullparam = 0x30011B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGCHANNEL")]
        ConfigureauthenticatedchannelWrongchannel = 0x30011C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_UNSUPPORTEDCONFIGURE")]
        ConfigureauthenticatedchannelUnsupportedconfigure = 0x30011D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGSIZE")]
        ConfigureauthenticatedchannelWrongsize = 0x30011E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_INVALIDPROCESSIDTYPE")]
        ConfigureauthenticatedchannelInvalidprocessidtype = 0x30011F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        VssetconstantbuffersInvalidbufferoffsetorcount = 0x300120,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        DssetconstantbuffersInvalidbufferoffsetorcount = 0x300121,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        HssetconstantbuffersInvalidbufferoffsetorcount = 0x300122,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        GssetconstantbuffersInvalidbufferoffsetorcount = 0x300123,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        PssetconstantbuffersInvalidbufferoffsetorcount = 0x300124,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        CssetconstantbuffersInvalidbufferoffsetorcount = 0x300125,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_INVALIDSIZE")]
        NegotiatecrpytosessionkeyexchangeInvalidsize = 0x300126,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDSIZE")]
        NegotiateauthenticatedchannelkeyexchangeInvalidsize = 0x300127,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDPRIORITY")]
        OfferresourcesInvalidpriority = 0x300128,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_OUTOFMEMORY")]
        GetcryptosessionhandleOutofmemory = 0x300129,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_NULLPARAM")]
        AcquirehandleforcaptureNullparam = 0x30012A,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDTYPE")]
        AcquirehandleforcaptureInvalidtype = 0x30012B,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDBIND")]
        AcquirehandleforcaptureInvalidbind = 0x30012C,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDARRAY")]
        AcquirehandleforcaptureInvalidarray = 0x30012D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_NULLPARAM")]
        VideoprocessorsetstreamrotationNullparam = 0x30012E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALIDSTREAM")]
        VideoprocessorsetstreamrotationInvalidstream = 0x30012F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALID")]
        VideoprocessorsetstreamrotationInvalid = 0x300130,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_UNSUPPORTED")]
        VideoprocessorsetstreamrotationUnsupported = 0x300131,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_NULLPARAM")]
        VideoprocessorgetstreamrotationNullparam = 0x300132,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDVIEW")]
        DeviceClearviewInvalidview = 0x300133,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatevertexshaderDoubleextensionsnotsupported = 0x300134,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreatevertexshaderShaderextensionsnotsupported = 0x300135,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatehullshaderDoubleextensionsnotsupported = 0x300136,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreatehullshaderShaderextensionsnotsupported = 0x300137,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatedomainshaderDoubleextensionsnotsupported = 0x300138,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreatedomainshaderShaderextensionsnotsupported = 0x300139,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreategeometryshaderDoubleextensionsnotsupported = 0x30013A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreategeometryshaderShaderextensionsnotsupported = 0x30013B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 0x30013C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputShaderextensionsnotsupported = 0x30013D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatepixelshaderDoubleextensionsnotsupported = 0x30013E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreatepixelshaderShaderextensionsnotsupported = 0x30013F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatecomputeshaderDoubleextensionsnotsupported = 0x300140,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        DeviceCreatecomputeshaderShaderextensionsnotsupported = 0x300141,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_MINPRECISION")]
        DeviceShaderLinkageMinprecision = 0x300142,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_UNSUPPORTED")]
        VideoprocessorsetstreamalphaUnsupported = 0x300143,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_UNSUPPORTED")]
        VideoprocessorsetstreampixelaspectratioUnsupported = 0x300144,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatevertexshaderUavsnotsupported = 0x300145,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatehullshaderUavsnotsupported = 0x300146,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatedomainshaderUavsnotsupported = 0x300147,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED")]
        DeviceCreategeometryshaderUavsnotsupported = 0x300148,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 0x300149,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatepixelshaderUavsnotsupported = 0x30014A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED")]
        DeviceCreatecomputeshaderUavsnotsupported = 0x30014B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_INVALIDOFFSET")]
        DeviceOmsetrendertargetsandunorderedaccessviewsInvalidoffset = 0x30014C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_TOOMANYVIEWS")]
        DeviceOmsetrendertargetsandunorderedaccessviewsToomanyviews = 0x30014D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_NOTSUPPORTED")]
        DeviceClearviewNotsupported = 0x30014E,
        [NativeName("Name", "D3D11_MESSAGE_ID_SWAPDEVICECONTEXTSTATE_NOTSUPPORTED")]
        SwapdevicecontextstateNotsupported = 0x30014F,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_PREFERUPDATESUBRESOURCE1")]
        UpdatesubresourcePreferupdatesubresource1 = 0x300150,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDC_INACCESSIBLE")]
        GetdcInaccessible = 0x300151,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDRECT")]
        DeviceClearviewInvalidrect = 0x300152,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLE_MASK_IGNORED_ON_FL9")]
        DeviceDrawSampleMaskIgnoredOnFL9 = 0x300153,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_NOT_SUPPORTED")]
        DeviceOpenSharedResource1NotSupported = 0x300154,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BY_NAME_NOT_SUPPORTED")]
        DeviceOpenSharedResourceByNameNotSupported = 0x300155,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_NOT_SUPPORTED")]
        EnqueueseteventNotSupported = 0x300156,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRELEASE_NOT_SUPPORTED")]
        OfferreleaseNotSupported = 0x300157,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INACCESSIBLE")]
        OfferresourcesInaccessible = 0x300158,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMSAA")]
        CreatevideoprocessorinputviewInvalidmsaa = 0x300159,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMSAA")]
        CreatevideoprocessoroutputviewInvalidmsaa = 0x30015A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT")]
        DeviceClearviewInvalidsourcerect = 0x30015B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT")]
        DeviceClearviewEmptyrect = 0x30015C,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_EMPTYDESTBOX")]
        UpdatesubresourceEmptydestbox = 0x30015D,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_EMPTYSOURCEBOX")]
        CopysubresourceregionEmptysourcebox = 0x30015E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS")]
        DeviceDrawOMRenderTargetDoesNotSupportLogicOps = 0x30015F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_DEPTHSTENCILVIEW_NOT_SET")]
        DeviceDrawDepthstencilviewNotSet = 0x300160,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET")]
        DeviceDrawRendertargetviewNotSet = 0x300161,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET_DUE_TO_FLIP_PRESENT")]
        DeviceDrawRendertargetviewNotSetDueToFlipPresent = 0x300162,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET_DUE_TO_FLIP_PRESENT")]
        DeviceUnorderedaccessviewNotSetDueToFlipPresent = 0x300163,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDATAFORNEWHARDWAREKEY_NULLPARAM")]
        GetdatafornewhardwarekeyNullparam = 0x300164,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOSESSIONSTATUS_NULLPARAM")]
        CheckcryptosessionstatusNullparam = 0x300165,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_NULLPARAM")]
        GetcryptosessionprivatedatasizeNullparam = 0x300166,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_NULLPARAM")]
        GetvideodecodercapsNullparam = 0x300167,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_ZEROWIDTHHEIGHT")]
        GetvideodecodercapsZerowidthheight = 0x300168,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_NULLPARAM")]
        CheckvideodecoderdownsamplingNullparam = 0x300169,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE")]
        CheckvideodecoderdownsamplingInvalidcolorspace = 0x30016A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT")]
        CheckvideodecoderdownsamplingZerowidthheight = 0x30016B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_NULLPARAM")]
        VideodecoderenabledownsamplingNullparam = 0x30016C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_UNSUPPORTED")]
        VideodecoderenabledownsamplingUnsupported = 0x30016D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_NULLPARAM")]
        VideodecoderupdatedownsamplingNullparam = 0x30016E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_UNSUPPORTED")]
        VideodecoderupdatedownsamplingUnsupported = 0x30016F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMATCONVERSION_NULLPARAM")]
        CheckvideoprocessorformatconversionNullparam = 0x300170,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE1_NULLPARAM")]
        Videoprocessorsetoutputcolorspace1Nullparam = 0x300171,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE1_NULLPARAM")]
        Videoprocessorgetoutputcolorspace1Nullparam = 0x300172,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_NULLPARAM")]
        Videoprocessorsetstreamcolorspace1Nullparam = 0x300173,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_INVALIDSTREAM")]
        Videoprocessorsetstreamcolorspace1Invalidstream = 0x300174,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_NULLPARAM")]
        VideoprocessorsetstreammirrorNullparam = 0x300175,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_INVALIDSTREAM")]
        VideoprocessorsetstreammirrorInvalidstream = 0x300176,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_UNSUPPORTED")]
        VideoprocessorsetstreammirrorUnsupported = 0x300177,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_NULLPARAM")]
        Videoprocessorgetstreamcolorspace1Nullparam = 0x300178,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_NULLPARAM")]
        VideoprocessorgetstreammirrorNullparam = 0x300179,
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_NULLPARAM")]
        RecommendvideodecoderdownsamplingNullparam = 0x30017A,
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE")]
        RecommendvideodecoderdownsamplingInvalidcolorspace = 0x30017B,
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT")]
        RecommendvideodecoderdownsamplingZerowidthheight = 0x30017C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSHADERUSAGE_NULLPARAM")]
        VideoprocessorsetoutputshaderusageNullparam = 0x30017D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSHADERUSAGE_NULLPARAM")]
        VideoprocessorgetoutputshaderusageNullparam = 0x30017E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_NULLPARAM")]
        VideoprocessorgetbehaviorhintsNullparam = 0x30017F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSTREAMCOUNT")]
        VideoprocessorgetbehaviorhintsInvalidstreamcount = 0x300180,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_TARGETRECT")]
        VideoprocessorgetbehaviorhintsTargetrect = 0x300181,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSOURCERECT")]
        VideoprocessorgetbehaviorhintsInvalidsourcerect = 0x300182,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDDESTRECT")]
        VideoprocessorgetbehaviorhintsInvaliddestrect = 0x300183,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_INVALID_KEY_EXCHANGE_TYPE")]
        GetcryptosessionprivatedatasizeInvalidKeyExchangeType = 0x300184,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_ACCESS_DENIED")]
        DeviceOpenSharedResource1AccessDenied = 0x300185,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_1_MESSAGES_END")]
        D3D111MessagesEnd = 0x300186,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_2_MESSAGES_START")]
        D3D112MessagesStart = 0x300187,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDUSAGE")]
        CreatebufferInvalidusage = 0x300188,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDUSAGE")]
        Createtexture1DInvalidusage = 0x300189,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDUSAGE")]
        Createtexture2DInvalidusage = 0x30018A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_STEPRATE_NOT_1")]
        CreateinputlayoutLevel9SteprateNot1 = 0x30018B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_INSTANCING_NOT_SUPPORTED")]
        CreateinputlayoutLevel9InstancingNotSupported = 0x30018C,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER")]
        UpdatetilemappingsInvalidParameter = 0x30018D,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER")]
        CopytilemappingsInvalidParameter = 0x30018E,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYTILES_INVALID_PARAMETER")]
        CopytilesInvalidParameter = 0x30018F,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATETILES_INVALID_PARAMETER")]
        UpdatetilesInvalidParameter = 0x300190,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESIZETILEPOOL_INVALID_PARAMETER")]
        ResizetilepoolInvalidParameter = 0x300191,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILEDRESOURCEBARRIER_INVALID_PARAMETER")]
        TiledresourcebarrierInvalidParameter = 0x300192,
        [NativeName("Name", "D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_WARNING")]
        NullTileMappingAccessWarning = 0x300193,
        [NativeName("Name", "D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_ERROR")]
        NullTileMappingAccessError = 0x300194,
        [NativeName("Name", "D3D11_MESSAGE_ID_DIRTY_TILE_MAPPING_ACCESS")]
        DirtyTileMappingAccess = 0x300195,
        [NativeName("Name", "D3D11_MESSAGE_ID_DUPLICATE_TILE_MAPPINGS_IN_COVERED_AREA")]
        DuplicateTileMappingsInCoveredArea = 0x300196,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_IN_COVERED_AREA_DUPLICATED_OUTSIDE")]
        TileMappingsInCoveredAreaDuplicatedOutside = 0x300197,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INCOMPATIBLE_RESOURCES")]
        TileMappingsSharedBetweenIncompatibleResources = 0x300198,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INPUT_AND_OUTPUT")]
        TileMappingsSharedBetweenInputAndOutput = 0x300199,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_INVALIDFLAGS")]
        CheckmultisamplequalitylevelsInvalidflags = 0x30019A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETRESOURCETILING_NONTILED_RESOURCE")]
        GetresourcetilingNontiledResource = 0x30019B,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESIZETILEPOOL_SHRINK_WITH_MAPPINGS_STILL_DEFINED_PAST_END")]
        ResizetilepoolShrinkWithMappingsStillDefinedPastEnd = 0x30019C,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEED_TO_CALL_TILEDRESOURCEBARRIER")]
        NeedToCallTiledresourcebarrier = 0x30019D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICE_INVALIDARGS")]
        CreatedeviceInvalidargs = 0x30019E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICE_WARNING")]
        CreatedeviceWarning = 0x30019F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWUINT_HAZARD")]
        ClearunorderedaccessviewuintHazard = 0x3001A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_HAZARD")]
        ClearunorderedaccessviewfloatHazard = 0x3001A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILED_RESOURCE_TIER_1_BUFFER_TEXTURE_MISMATCH")]
        TiledResourceTier1BufferTextureMismatch = 0x3001A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CRYPTOSESSION")]
        CreateCryptosession = 0x3001A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_AUTHENTICATEDCHANNEL")]
        CreateAuthenticatedchannel = 0x3001A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CRYPTOSESSION")]
        LiveCryptosession = 0x3001A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_AUTHENTICATEDCHANNEL")]
        LiveAuthenticatedchannel = 0x3001A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CRYPTOSESSION")]
        DestroyCryptosession = 0x3001A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_AUTHENTICATEDCHANNEL")]
        DestroyAuthenticatedchannel = 0x3001A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_2_MESSAGES_END")]
        D3D112MessagesEnd = 0x3001A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_3_MESSAGES_START")]
        D3D113MessagesStart = 0x3001AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE")]
        CreaterasterizerstateInvalidConservativerastermode = 0x3001AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_SYSTEMVALUE")]
        DeviceDrawInvalidSystemvalue = 0x3001AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDCONTEXTTYPE")]
        CreatequeryorpredicateInvalidcontexttype = 0x3001AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_DECODENOTSUPPORTED")]
        CreatequeryorpredicateDecodenotsupported = 0x3001AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_ENCODENOTSUPPORTED")]
        CreatequeryorpredicateEncodenotsupported = 0x3001AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANEINDEX")]
        CreateshaderresourceviewInvalidplaneindex = 0x3001B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANEINDEX")]
        CreateshaderresourceviewInvalidvideoplaneindex = 0x3001B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        CreateshaderresourceviewAmbiguousvideoplaneindex = 0x3001B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANEINDEX")]
        CreaterendertargetviewInvalidplaneindex = 0x3001B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANEINDEX")]
        CreaterendertargetviewInvalidvideoplaneindex = 0x3001B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        CreaterendertargetviewAmbiguousvideoplaneindex = 0x3001B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANEINDEX")]
        CreateunorderedaccessviewInvalidplaneindex = 0x3001B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANEINDEX")]
        CreateunorderedaccessviewInvalidvideoplaneindex = 0x3001B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        CreateunorderedaccessviewAmbiguousvideoplaneindex = 0x3001B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSCANDATAOFFSET")]
        JpegdecodeInvalidscandataoffset = 0x3001B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_NOTSUPPORTED")]
        JpegdecodeNotsupported = 0x3001BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DIMENSIONSTOOLARGE")]
        JpegdecodeDimensionstoolarge = 0x3001BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOMPONENTS")]
        JpegdecodeInvalidcomponents = 0x3001BC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTINATIONNOT2D")]
        JpegdecodeDestinationnot2D = 0x3001BD,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_TILEDRESOURCESUNSUPPORTED")]
        JpegdecodeTiledresourcesunsupported = 0x3001BE,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_GUARDRECTSUNSUPPORTED")]
        JpegdecodeGuardrectsunsupported = 0x3001BF,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_FORMATUNSUPPORTED")]
        JpegdecodeFormatunsupported = 0x3001C0,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSUBRESOURCE")]
        JpegdecodeInvalidsubresource = 0x3001C1,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDMIPLEVEL")]
        JpegdecodeInvalidmiplevel = 0x3001C2,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_EMPTYDESTBOX")]
        JpegdecodeEmptydestbox = 0x3001C3,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOT2D")]
        JpegdecodeDestboxnot2D = 0x3001C4,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOTSUB")]
        JpegdecodeDestboxnotsub = 0x3001C5,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXESINTERSECT")]
        JpegdecodeDestboxesintersect = 0x3001C6,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEMISMATCH")]
        JpegdecodeXsubsamplemismatch = 0x3001C7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEMISMATCH")]
        JpegdecodeYsubsamplemismatch = 0x3001C8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEODD")]
        JpegdecodeXsubsampleodd = 0x3001C9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEODD")]
        JpegdecodeYsubsampleodd = 0x3001CA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_OUTPUTDIMENSIONSTOOLARGE")]
        JpegdecodeOutputdimensionstoolarge = 0x3001CB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_NONPOW2SCALEUNSUPPORTED")]
        JpegdecodeNonpow2Scaleunsupported = 0x3001CC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_FRACTIONALDOWNSCALETOLARGE")]
        JpegdecodeFractionaldownscaletolarge = 0x3001CD,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_CHROMASIZEMISMATCH")]
        JpegdecodeChromasizemismatch = 0x3001CE,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_LUMACHROMASIZEMISMATCH")]
        JpegdecodeLumachromasizemismatch = 0x3001CF,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDNUMDESTINATIONS")]
        JpegdecodeInvalidnumdestinations = 0x3001D0,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_SUBBOXUNSUPPORTED")]
        JpegdecodeSubboxunsupported = 0x3001D1,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_1DESTUNSUPPORTEDFORMAT")]
        Jpegdecode1Destunsupportedformat = 0x3001D2,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_3DESTUNSUPPORTEDFORMAT")]
        Jpegdecode3Destunsupportedformat = 0x3001D3,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_SCALEUNSUPPORTED")]
        JpegdecodeScaleunsupported = 0x3001D4,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSOURCESIZE")]
        JpegdecodeInvalidsourcesize = 0x3001D5,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOPYFLAGS")]
        JpegdecodeInvalidcopyflags = 0x3001D6,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_HAZARD")]
        JpegdecodeHazard = 0x3001D7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERUSAGE")]
        JpegdecodeUnsupportedsrcbufferusage = 0x3001D8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERMISCFLAGS")]
        JpegdecodeUnsupportedsrcbuffermiscflags = 0x3001D9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDDSTTEXTUREUSAGE")]
        JpegdecodeUnsupporteddsttextureusage = 0x3001DA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_BACKBUFFERNOTSUPPORTED")]
        JpegdecodeBackbuffernotsupported = 0x3001DB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPRTEDCOPYFLAGS")]
        JpegdecodeUnsupprtedcopyflags = 0x3001DC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_NOTSUPPORTED")]
        JpegencodeNotsupported = 0x3001DD,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSCANDATAOFFSET")]
        JpegencodeInvalidscandataoffset = 0x3001DE,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDCOMPONENTS")]
        JpegencodeInvalidcomponents = 0x3001DF,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_SOURCENOT2D")]
        JpegencodeSourcenot2D = 0x3001E0,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_TILEDRESOURCESUNSUPPORTED")]
        JpegencodeTiledresourcesunsupported = 0x3001E1,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_GUARDRECTSUNSUPPORTED")]
        JpegencodeGuardrectsunsupported = 0x3001E2,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_XSUBSAMPLEMISMATCH")]
        JpegencodeXsubsamplemismatch = 0x3001E3,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_YSUBSAMPLEMISMATCH")]
        JpegencodeYsubsamplemismatch = 0x3001E4,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_FORMATUNSUPPORTED")]
        JpegencodeFormatunsupported = 0x3001E5,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSUBRESOURCE")]
        JpegencodeInvalidsubresource = 0x3001E6,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDMIPLEVEL")]
        JpegencodeInvalidmiplevel = 0x3001E7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_DIMENSIONSTOOLARGE")]
        JpegencodeDimensionstoolarge = 0x3001E8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_HAZARD")]
        JpegencodeHazard = 0x3001E9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERUSAGE")]
        JpegencodeUnsupporteddstbufferusage = 0x3001EA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERMISCFLAGS")]
        JpegencodeUnsupporteddstbuffermiscflags = 0x3001EB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDSRCTEXTUREUSAGE")]
        JpegencodeUnsupportedsrctextureusage = 0x3001EC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_BACKBUFFERNOTSUPPORTED")]
        JpegencodeBackbuffernotsupported = 0x3001ED,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNSUPPORTEDCONTEXTTTYPEFORQUERY")]
        CreatequeryorpredicateUnsupportedcontextttypeforquery = 0x3001EE,
        [NativeName("Name", "D3D11_MESSAGE_ID_FLUSH1_INVALIDCONTEXTTYPE")]
        Flush1Invalidcontexttype = 0x3001EF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETHARDWAREPROTECTION_INVALIDCONTEXT")]
        DeviceSethardwareprotectionInvalidcontext = 0x3001F0,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_NULLPARAM")]
        VideoprocessorsetoutputhdrmetadataNullparam = 0x3001F1,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_INVALIDSIZE")]
        VideoprocessorsetoutputhdrmetadataInvalidsize = 0x3001F2,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_NULLPARAM")]
        VideoprocessorgetoutputhdrmetadataNullparam = 0x3001F3,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_INVALIDSIZE")]
        VideoprocessorgetoutputhdrmetadataInvalidsize = 0x3001F4,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_NULLPARAM")]
        VideoprocessorsetstreamhdrmetadataNullparam = 0x3001F5,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSTREAM")]
        VideoprocessorsetstreamhdrmetadataInvalidstream = 0x3001F6,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSIZE")]
        VideoprocessorsetstreamhdrmetadataInvalidsize = 0x3001F7,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_NULLPARAM")]
        VideoprocessorgetstreamhdrmetadataNullparam = 0x3001F8,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSTREAM")]
        VideoprocessorgetstreamhdrmetadataInvalidstream = 0x3001F9,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSIZE")]
        VideoprocessorgetstreamhdrmetadataInvalidsize = 0x3001FA,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_INVALIDSTREAM")]
        VideoprocessorgetstreamframeformatInvalidstream = 0x3001FB,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_INVALIDSTREAM")]
        VideoprocessorgetstreamcolorspaceInvalidstream = 0x3001FC,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_INVALIDSTREAM")]
        VideoprocessorgetstreamoutputrateInvalidstream = 0x3001FD,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_INVALIDSTREAM")]
        VideoprocessorgetstreamsourcerectInvalidstream = 0x3001FE,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_INVALIDSTREAM")]
        VideoprocessorgetstreamdestrectInvalidstream = 0x3001FF,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_INVALIDSTREAM")]
        VideoprocessorgetstreamalphaInvalidstream = 0x300200,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_INVALIDSTREAM")]
        VideoprocessorgetstreampaletteInvalidstream = 0x300201,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_INVALIDSTREAM")]
        VideoprocessorgetstreampixelaspectratioInvalidstream = 0x300202,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_INVALIDSTREAM")]
        VideoprocessorgetstreamlumakeyInvalidstream = 0x300203,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_INVALIDSTREAM")]
        VideoprocessorgetstreamstereoformatInvalidstream = 0x300204,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM")]
        VideoprocessorgetstreamautoprocessingmodeInvalidstream = 0x300205,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_INVALIDSTREAM")]
        VideoprocessorgetstreamfilterInvalidstream = 0x300206,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_INVALIDSTREAM")]
        VideoprocessorgetstreamrotationInvalidstream = 0x300207,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_INVALIDSTREAM")]
        Videoprocessorgetstreamcolorspace1Invalidstream = 0x300208,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_INVALIDSTREAM")]
        VideoprocessorgetstreammirrorInvalidstream = 0x300209,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_FENCE")]
        CreateFence = 0x30020A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_FENCE")]
        LiveFence = 0x30020B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_FENCE")]
        DestroyFence = 0x30020C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SYNCHRONIZEDCHANNEL")]
        CreateSynchronizedchannel = 0x30020D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SYNCHRONIZEDCHANNEL")]
        LiveSynchronizedchannel = 0x30020E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SYNCHRONIZEDCHANNEL")]
        DestroySynchronizedchannel = 0x30020F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEFENCE_INVALIDFLAGS")]
        CreatefenceInvalidflags = 0x300210,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_3_MESSAGES_END")]
        D3D113MessagesEnd = 0x300211,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_5_MESSAGES_START")]
        D3D115MessagesStart = 0x300212,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_INVALIDKEYEXCHANGETYPE")]
        NegotiatecryptosessionkeyexchangemtInvalidkeyexchangetype = 0x300213,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_NOT_SUPPORTED")]
        NegotiatecryptosessionkeyexchangemtNotSupported = 0x300214,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT_COUNT")]
        DecoderbeginframeInvalidHistogramComponentCount = 0x300215,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT")]
        DecoderbeginframeInvalidHistogramComponent = 0x300216,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_SIZE")]
        DecoderbeginframeInvalidHistogramBufferSize = 0x300217,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_USAGE")]
        DecoderbeginframeInvalidHistogramBufferUsage = 0x300218,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_MISC_FLAGS")]
        DecoderbeginframeInvalidHistogramBufferMiscFlags = 0x300219,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_OFFSET")]
        DecoderbeginframeInvalidHistogramBufferOffset = 0x30021A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKEDWORKLOAD")]
        CreateTrackedworkload = 0x30021B,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TRACKEDWORKLOAD")]
        LiveTrackedworkload = 0x30021C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD")]
        DestroyTrackedworkload = 0x30021D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_NULLPARAM")]
        CreateTrackedWorkloadNullparam = 0x30021E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_MAX_INSTANCES")]
        CreateTrackedWorkloadInvalidMaxInstances = 0x30021F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_DEADLINE_TYPE")]
        CreateTrackedWorkloadInvalidDeadlineType = 0x300220,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_ENGINE_TYPE")]
        CreateTrackedWorkloadInvalidEngineType = 0x300221,
        [NativeName("Name", "D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS")]
        MultipleTrackedWorkloads = 0x300222,
        [NativeName("Name", "D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS")]
        MultipleTrackedWorkloadPairs = 0x300223,
        [NativeName("Name", "D3D11_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR")]
        IncompleteTrackedWorkloadPair = 0x300224,
        [NativeName("Name", "D3D11_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR")]
        OutOfOrderTrackedWorkloadPair = 0x300225,
        [NativeName("Name", "D3D11_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD")]
        CannotAddTrackedWorkload = 0x300226,
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED")]
        TrackedWorkloadNotSupported = 0x300227,
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_ENGINE_TYPE_NOT_FOUND")]
        TrackedWorkloadEngineTypeNotFound = 0x300228,
        [NativeName("Name", "D3D11_MESSAGE_ID_NO_TRACKED_WORKLOAD_SLOT_AVAILABLE")]
        NoTrackedWorkloadSlotAvailable = 0x300229,
        [NativeName("Name", "D3D11_MESSAGE_ID_END_TRACKED_WORKLOAD_INVALID_ARG")]
        EndTrackedWorkloadInvalidArg = 0x30022A,
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_DISJOINT_FAILURE")]
        TrackedWorkloadDisjointFailure = 0x30022B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_AND_WRITE_MASK_MISMATCH")]
        DeviceDrawResourceFormatAndWriteMaskMismatch = 0x30022C,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_5_MESSAGES_END")]
        D3D115MessagesEnd = 0x30022D,
    }
}
