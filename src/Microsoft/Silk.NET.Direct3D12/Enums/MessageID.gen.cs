// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESSAGE_ID")]
    public enum MessageID : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNKNOWN")]
        MessageIDUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"StringFromApplication\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_STRING_FROM_APPLICATION")]
        MessageIDStringFromApplication = 0x1,
        [Obsolete("Deprecated in favour of \"CorruptedThis\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_THIS")]
        MessageIDCorruptedThis = 0x2,
        [Obsolete("Deprecated in favour of \"CorruptedParameter1\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER1")]
        MessageIDCorruptedParameter1 = 0x3,
        [Obsolete("Deprecated in favour of \"CorruptedParameter2\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER2")]
        MessageIDCorruptedParameter2 = 0x4,
        [Obsolete("Deprecated in favour of \"CorruptedParameter3\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER3")]
        MessageIDCorruptedParameter3 = 0x5,
        [Obsolete("Deprecated in favour of \"CorruptedParameter4\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER4")]
        MessageIDCorruptedParameter4 = 0x6,
        [Obsolete("Deprecated in favour of \"CorruptedParameter5\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER5")]
        MessageIDCorruptedParameter5 = 0x7,
        [Obsolete("Deprecated in favour of \"CorruptedParameter6\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER6")]
        MessageIDCorruptedParameter6 = 0x8,
        [Obsolete("Deprecated in favour of \"CorruptedParameter7\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER7")]
        MessageIDCorruptedParameter7 = 0x9,
        [Obsolete("Deprecated in favour of \"CorruptedParameter8\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER8")]
        MessageIDCorruptedParameter8 = 0xA,
        [Obsolete("Deprecated in favour of \"CorruptedParameter9\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER9")]
        MessageIDCorruptedParameter9 = 0xB,
        [Obsolete("Deprecated in favour of \"CorruptedParameter10\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER10")]
        MessageIDCorruptedParameter10 = 0xC,
        [Obsolete("Deprecated in favour of \"CorruptedParameter11\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER11")]
        MessageIDCorruptedParameter11 = 0xD,
        [Obsolete("Deprecated in favour of \"CorruptedParameter12\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER12")]
        MessageIDCorruptedParameter12 = 0xE,
        [Obsolete("Deprecated in favour of \"CorruptedParameter13\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER13")]
        MessageIDCorruptedParameter13 = 0xF,
        [Obsolete("Deprecated in favour of \"CorruptedParameter14\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER14")]
        MessageIDCorruptedParameter14 = 0x10,
        [Obsolete("Deprecated in favour of \"CorruptedParameter15\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER15")]
        MessageIDCorruptedParameter15 = 0x11,
        [Obsolete("Deprecated in favour of \"CorruptedMultithreading\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_MULTITHREADING")]
        MessageIDCorruptedMultithreading = 0x12,
        [Obsolete("Deprecated in favour of \"MessageReportingOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY")]
        MessageIDMessageReportingOutofmemory = 0x13,
        [Obsolete("Deprecated in favour of \"GetprivatedataMoredata\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETPRIVATEDATA_MOREDATA")]
        MessageIDGetprivatedataMoredata = 0x14,
        [Obsolete("Deprecated in favour of \"SetprivatedataInvalidfreedata\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA")]
        MessageIDSetprivatedataInvalidfreedata = 0x15,
        [Obsolete("Deprecated in favour of \"SetprivatedataChangingparams\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS")]
        MessageIDSetprivatedataChangingparams = 0x18,
        [Obsolete("Deprecated in favour of \"SetprivatedataOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY")]
        MessageIDSetprivatedataOutofmemory = 0x19,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateshaderresourceviewUnrecognizedformat = 0x1A,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvaliddesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC")]
        MessageIDCreateshaderresourceviewInvaliddesc = 0x1B,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT")]
        MessageIDCreateshaderresourceviewInvalidformat = 0x1C,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidvideoplaneslice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANESLICE")]
        MessageIDCreateshaderresourceviewInvalidvideoplaneslice = 0x1D,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidplaneslice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANESLICE")]
        MessageIDCreateshaderresourceviewInvalidplaneslice = 0x1E,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvaliddimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateshaderresourceviewInvaliddimensions = 0x1F,
        [Obsolete("Deprecated in favour of \"CreateshaderresourceviewInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE")]
        MessageIDCreateshaderresourceviewInvalidresource = 0x20,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreaterendertargetviewUnrecognizedformat = 0x23,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewUnsupportedformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT")]
        MessageIDCreaterendertargetviewUnsupportedformat = 0x24,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvaliddesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC")]
        MessageIDCreaterendertargetviewInvaliddesc = 0x25,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT")]
        MessageIDCreaterendertargetviewInvalidformat = 0x26,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidvideoplaneslice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANESLICE")]
        MessageIDCreaterendertargetviewInvalidvideoplaneslice = 0x27,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidplaneslice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANESLICE")]
        MessageIDCreaterendertargetviewInvalidplaneslice = 0x28,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvaliddimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS")]
        MessageIDCreaterendertargetviewInvaliddimensions = 0x29,
        [Obsolete("Deprecated in favour of \"CreaterendertargetviewInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE")]
        MessageIDCreaterendertargetviewInvalidresource = 0x2A,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreatedepthstencilviewUnrecognizedformat = 0x2D,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvaliddesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC")]
        MessageIDCreatedepthstencilviewInvaliddesc = 0x2E,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT")]
        MessageIDCreatedepthstencilviewInvalidformat = 0x2F,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvaliddimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS")]
        MessageIDCreatedepthstencilviewInvaliddimensions = 0x30,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE")]
        MessageIDCreatedepthstencilviewInvalidresource = 0x31,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY")]
        MessageIDCreateinputlayoutOutofmemory = 0x34,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutToomanyelements\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS")]
        MessageIDCreateinputlayoutToomanyelements = 0x35,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT")]
        MessageIDCreateinputlayoutInvalidformat = 0x36,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutIncompatibleformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT")]
        MessageIDCreateinputlayoutIncompatibleformat = 0x37,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidslot\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT")]
        MessageIDCreateinputlayoutInvalidslot = 0x38,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidinputslotclass\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS")]
        MessageIDCreateinputlayoutInvalidinputslotclass = 0x39,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutSteprateslotclassmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH")]
        MessageIDCreateinputlayoutSteprateslotclassmismatch = 0x3A,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidslotclasschange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE")]
        MessageIDCreateinputlayoutInvalidslotclasschange = 0x3B,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidstepratechange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE")]
        MessageIDCreateinputlayoutInvalidstepratechange = 0x3C,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutInvalidalignment\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT")]
        MessageIDCreateinputlayoutInvalidalignment = 0x3D,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutDuplicatesemantic\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC")]
        MessageIDCreateinputlayoutDuplicatesemantic = 0x3E,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutUnparseableinputsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE")]
        MessageIDCreateinputlayoutUnparseableinputsignature = 0x3F,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutNullsemantic\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC")]
        MessageIDCreateinputlayoutNullsemantic = 0x40,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutMissingelement\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT")]
        MessageIDCreateinputlayoutMissingelement = 0x41,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY")]
        MessageIDCreatevertexshaderOutofmemory = 0x42,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatevertexshaderInvalidshaderbytecode = 0x43,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatevertexshaderInvalidshadertype = 0x44,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY")]
        MessageIDCreategeometryshaderOutofmemory = 0x45,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderInvalidshaderbytecode = 0x46,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderInvalidshadertype = 0x47,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY")]
        MessageIDCreategeometryshaderwithstreamoutputOutofmemory = 0x48,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshaderbytecode = 0x49,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshadertype = 0x4A,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidnumentries\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumentries = 0x4B,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOutputstreamstrideunused\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputstreamstrideunused = 0x4C,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOutputslot0Expected\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputslot0Expected = 0x4F,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidoutputslot\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputslot = 0x50,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputOnlyoneelementperslot\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputOnlyoneelementperslot = 0x51,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidcomponentcount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidcomponentcount = 0x52,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 0x53,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidgapdefinition\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidgapdefinition = 0x54,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputRepeatedoutput\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT")]
        MessageIDCreategeometryshaderwithstreamoutputRepeatedoutput = 0x55,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidoutputstreamstride\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 0x56,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputMissingsemantic\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputMissingsemantic = 0x57,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputMaskmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH")]
        MessageIDCreategeometryshaderwithstreamoutputMaskmismatch = 0x58,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputCanthaveonlygaps\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS")]
        MessageIDCreategeometryshaderwithstreamoutputCanthaveonlygaps = 0x59,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputDecltoocomplex\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX")]
        MessageIDCreategeometryshaderwithstreamoutputDecltoocomplex = 0x5A,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputMissingoutputsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE")]
        MessageIDCreategeometryshaderwithstreamoutputMissingoutputsignature = 0x5B,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY")]
        MessageIDCreatepixelshaderOutofmemory = 0x5C,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatepixelshaderInvalidshaderbytecode = 0x5D,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatepixelshaderInvalidshadertype = 0x5E,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidfillmode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE")]
        MessageIDCreaterasterizerstateInvalidfillmode = 0x5F,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidcullmode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE")]
        MessageIDCreaterasterizerstateInvalidcullmode = 0x60,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvaliddepthbiasclamp\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP")]
        MessageIDCreaterasterizerstateInvaliddepthbiasclamp = 0x61,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidslopescaleddepthbias\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS")]
        MessageIDCreaterasterizerstateInvalidslopescaleddepthbias = 0x62,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvaliddepthwritemask\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK")]
        MessageIDCreatedepthstencilstateInvaliddepthwritemask = 0x64,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvaliddepthfunc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC")]
        MessageIDCreatedepthstencilstateInvaliddepthfunc = 0x65,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilfailop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfailop = 0x66,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilzfailop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilzfailop = 0x67,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilpassop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilpassop = 0x68,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidfrontfacestencilfunc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfunc = 0x69,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilfailop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfailop = 0x6A,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilzfailop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilzfailop = 0x6B,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilpassop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilpassop = 0x6C,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateInvalidbackfacestencilfunc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfunc = 0x6D,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidsrcblend\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND")]
        MessageIDCreateblendstateInvalidsrcblend = 0x6F,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvaliddestblend\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND")]
        MessageIDCreateblendstateInvaliddestblend = 0x70,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidblendop\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP")]
        MessageIDCreateblendstateInvalidblendop = 0x71,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidsrcblendalpha\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA")]
        MessageIDCreateblendstateInvalidsrcblendalpha = 0x72,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvaliddestblendalpha\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA")]
        MessageIDCreateblendstateInvaliddestblendalpha = 0x73,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidblendopalpha\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA")]
        MessageIDCreateblendstateInvalidblendopalpha = 0x74,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidrendertargetwritemask\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK")]
        MessageIDCreateblendstateInvalidrendertargetwritemask = 0x75,
        [Obsolete("Deprecated in favour of \"GetProgramIdentifierError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_PROGRAM_IDENTIFIER_ERROR")]
        MessageIDGetProgramIdentifierError = 0x76,
        [Obsolete("Deprecated in favour of \"GetWorkGraphPropertiesError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_WORK_GRAPH_PROPERTIES_ERROR")]
        MessageIDGetWorkGraphPropertiesError = 0x77,
        [Obsolete("Deprecated in favour of \"SetProgramError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PROGRAM_ERROR")]
        MessageIDSetProgramError = 0x78,
        [Obsolete("Deprecated in favour of \"CleardepthstencilviewInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID")]
        MessageIDCleardepthstencilviewInvalid = 0x87,
        [Obsolete("Deprecated in favour of \"CommandListDrawRootSignatureNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_NOT_SET")]
        MessageIDCommandListDrawRootSignatureNotSet = 0xC8,
        [Obsolete("Deprecated in favour of \"CommandListDrawRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCommandListDrawRootSignatureMismatch = 0xC9,
        [Obsolete("Deprecated in favour of \"CommandListDrawVertexBufferNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_NOT_SET")]
        MessageIDCommandListDrawVertexBufferNotSet = 0xCA,
        [Obsolete("Deprecated in favour of \"CommandListDrawVertexBufferStrideTooSmall\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL")]
        MessageIDCommandListDrawVertexBufferStrideTooSmall = 0xD1,
        [Obsolete("Deprecated in favour of \"CommandListDrawVertexBufferTooSmall\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_TOO_SMALL")]
        MessageIDCommandListDrawVertexBufferTooSmall = 0xD2,
        [Obsolete("Deprecated in favour of \"CommandListDrawIndexBufferNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_NOT_SET")]
        MessageIDCommandListDrawIndexBufferNotSet = 0xD3,
        [Obsolete("Deprecated in favour of \"CommandListDrawIndexBufferFormatInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_FORMAT_INVALID")]
        MessageIDCommandListDrawIndexBufferFormatInvalid = 0xD4,
        [Obsolete("Deprecated in favour of \"CommandListDrawIndexBufferTooSmall\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_TOO_SMALL")]
        MessageIDCommandListDrawIndexBufferTooSmall = 0xD5,
        [Obsolete("Deprecated in favour of \"CommandListDrawInvalidPrimitivetopology\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INVALID_PRIMITIVETOPOLOGY")]
        MessageIDCommandListDrawInvalidPrimitivetopology = 0xDB,
        [Obsolete("Deprecated in favour of \"CommandListDrawVertexStrideUnaligned\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_STRIDE_UNALIGNED")]
        MessageIDCommandListDrawVertexStrideUnaligned = 0xDD,
        [Obsolete("Deprecated in favour of \"CommandListDrawIndexOffsetUnaligned\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_OFFSET_UNALIGNED")]
        MessageIDCommandListDrawIndexOffsetUnaligned = 0xDE,
        [Obsolete("Deprecated in favour of \"DeviceRemovalProcessATFault\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT")]
        MessageIDDeviceRemovalProcessATFault = 0xE8,
        [Obsolete("Deprecated in favour of \"DeviceRemovalProcessPossiblyATFault\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT")]
        MessageIDDeviceRemovalProcessPossiblyATFault = 0xE9,
        [Obsolete("Deprecated in favour of \"DeviceRemovalProcessNotATFault\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT")]
        MessageIDDeviceRemovalProcessNotATFault = 0xEA,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutTrailingDigitInSemantic\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreateinputlayoutTrailingDigitInSemantic = 0xEF,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputTrailingDigitInSemantic\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 0xF0,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutTypeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH")]
        MessageIDCreateinputlayoutTypeMismatch = 0xF5,
        [Obsolete("Deprecated in favour of \"CreateinputlayoutEmptyLayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT")]
        MessageIDCreateinputlayoutEmptyLayout = 0xFD,
        [Obsolete("Deprecated in favour of \"LiveObjectSummary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_OBJECT_SUMMARY")]
        MessageIDLiveObjectSummary = 0xFF,
        [Obsolete("Deprecated in favour of \"LiveDevice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_DEVICE")]
        MessageIDLiveDevice = 0x112,
        [Obsolete("Deprecated in favour of \"LiveSwapchain\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_SWAPCHAIN")]
        MessageIDLiveSwapchain = 0x113,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilviewInvalidflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS")]
        MessageIDCreatedepthstencilviewInvalidflags = 0x114,
        [Obsolete("Deprecated in favour of \"CreatevertexshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatevertexshaderInvalidclasslinkage = 0x115,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreategeometryshaderInvalidclasslinkage = 0x116,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 0x118,
        [Obsolete("Deprecated in favour of \"CreatepixelshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatepixelshaderInvalidclasslinkage = 0x11B,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidstream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstream = 0x11C,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputUnexpectedentries\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedentries = 0x11D,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputUnexpectedstrides\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedstrides = 0x11E,
        [Obsolete("Deprecated in favour of \"CreategeometryshaderwithstreamoutputInvalidnumstrides\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumstrides = 0x11F,
        [Obsolete("Deprecated in favour of \"CreatehullshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY")]
        MessageIDCreatehullshaderOutofmemory = 0x121,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatehullshaderInvalidshaderbytecode = 0x122,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatehullshaderInvalidshadertype = 0x123,
        [Obsolete("Deprecated in favour of \"CreatehullshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatehullshaderInvalidclasslinkage = 0x124,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY")]
        MessageIDCreatedomainshaderOutofmemory = 0x126,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatedomainshaderInvalidshaderbytecode = 0x127,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatedomainshaderInvalidshadertype = 0x128,
        [Obsolete("Deprecated in favour of \"CreatedomainshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatedomainshaderInvalidclasslinkage = 0x129,
        [Obsolete("Deprecated in favour of \"ResourceUnmapNotmapped\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED")]
        MessageIDResourceUnmapNotmapped = 0x136,
        [Obsolete("Deprecated in favour of \"DeviceCheckfeaturesupportMismatchedDataSize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE")]
        MessageIDDeviceCheckfeaturesupportMismatchedDataSize = 0x13E,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY")]
        MessageIDCreatecomputeshaderOutofmemory = 0x141,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatecomputeshaderInvalidshaderbytecode = 0x142,
        [Obsolete("Deprecated in favour of \"CreatecomputeshaderInvalidclasslinkage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatecomputeshaderInvalidclasslinkage = 0x143,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoublefloatopsnotsupported = 0x14B,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoublefloatopsnotsupported = 0x14C,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoublefloatopsnotsupported = 0x14D,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoublefloatopsnotsupported = 0x14E,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 0x14F,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoublefloatopsnotsupported = 0x150,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderDoublefloatopsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoublefloatopsnotsupported = 0x151,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE")]
        MessageIDCreateunorderedaccessviewInvalidresource = 0x154,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvaliddesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC")]
        MessageIDCreateunorderedaccessviewInvaliddesc = 0x155,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT")]
        MessageIDCreateunorderedaccessviewInvalidformat = 0x156,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidvideoplaneslice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANESLICE")]
        MessageIDCreateunorderedaccessviewInvalidvideoplaneslice = 0x157,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidplaneslice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANESLICE")]
        MessageIDCreateunorderedaccessviewInvalidplaneslice = 0x158,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvaliddimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateunorderedaccessviewInvaliddimensions = 0x159,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewUnrecognizedformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateunorderedaccessviewUnrecognizedformat = 0x15A,
        [Obsolete("Deprecated in favour of \"CreateunorderedaccessviewInvalidflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS")]
        MessageIDCreateunorderedaccessviewInvalidflags = 0x162,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidforcedsamplecount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT")]
        MessageIDCreaterasterizerstateInvalidforcedsamplecount = 0x191,
        [Obsolete("Deprecated in favour of \"CreateblendstateInvalidlogicops\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS")]
        MessageIDCreateblendstateInvalidlogicops = 0x193,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoubleextensionsnotsupported = 0x19A,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoubleextensionsnotsupported = 0x19C,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoubleextensionsnotsupported = 0x19E,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoubleextensionsnotsupported = 0x1A0,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 0x1A2,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoubleextensionsnotsupported = 0x1A4,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderDoubleextensionsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoubleextensionsnotsupported = 0x1A6,
        [Obsolete("Deprecated in favour of \"DeviceCreatevertexshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderUavsnotsupported = 0x1A9,
        [Obsolete("Deprecated in favour of \"DeviceCreatehullshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderUavsnotsupported = 0x1AA,
        [Obsolete("Deprecated in favour of \"DeviceCreatedomainshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderUavsnotsupported = 0x1AB,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderUavsnotsupported = 0x1AC,
        [Obsolete("Deprecated in favour of \"DeviceCreategeometryshaderwithstreamoutputUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 0x1AD,
        [Obsolete("Deprecated in favour of \"DeviceCreatepixelshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderUavsnotsupported = 0x1AE,
        [Obsolete("Deprecated in favour of \"DeviceCreatecomputeshaderUavsnotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderUavsnotsupported = 0x1AF,
        [Obsolete("Deprecated in favour of \"DeviceClearviewInvalidsourcerect\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT")]
        MessageIDDeviceClearviewInvalidsourcerect = 0x1BF,
        [Obsolete("Deprecated in favour of \"DeviceClearviewEmptyrect\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT")]
        MessageIDDeviceClearviewEmptyrect = 0x1C0,
        [Obsolete("Deprecated in favour of \"UpdatetilemappingsInvalidParameter\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDUpdatetilemappingsInvalidParameter = 0x1ED,
        [Obsolete("Deprecated in favour of \"CopytilemappingsInvalidParameter\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDCopytilemappingsInvalidParameter = 0x1EE,
        [Obsolete("Deprecated in favour of \"CreatedeviceInvalidargs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_INVALIDARGS")]
        MessageIDCreatedeviceInvalidargs = 0x1FA,
        [Obsolete("Deprecated in favour of \"CreatedeviceWarning\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_WARNING")]
        MessageIDCreatedeviceWarning = 0x1FB,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_TYPE")]
        MessageIDResourceBarrierInvalidType = 0x207,
        [Obsolete("Deprecated in favour of \"ResourceBarrierNullPointer\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_NULL_POINTER")]
        MessageIDResourceBarrierNullPointer = 0x208,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidSubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SUBRESOURCE")]
        MessageIDResourceBarrierInvalidSubresource = 0x209,
        [Obsolete("Deprecated in favour of \"ResourceBarrierReservedBits\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_RESERVED_BITS")]
        MessageIDResourceBarrierReservedBits = 0x20A,
        [Obsolete("Deprecated in favour of \"ResourceBarrierMissingBindFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISSING_BIND_FLAGS")]
        MessageIDResourceBarrierMissingBindFlags = 0x20B,
        [Obsolete("Deprecated in favour of \"ResourceBarrierMismatchingMiscFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_MISC_FLAGS")]
        MessageIDResourceBarrierMismatchingMiscFlags = 0x20C,
        [Obsolete("Deprecated in favour of \"ResourceBarrierMatchingStates\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MATCHING_STATES")]
        MessageIDResourceBarrierMatchingStates = 0x20D,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidCombination\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINATION")]
        MessageIDResourceBarrierInvalidCombination = 0x20E,
        [Obsolete("Deprecated in favour of \"ResourceBarrierBeforeAfterMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_BEFORE_AFTER_MISMATCH")]
        MessageIDResourceBarrierBeforeAfterMismatch = 0x20F,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_RESOURCE")]
        MessageIDResourceBarrierInvalidResource = 0x210,
        [Obsolete("Deprecated in favour of \"ResourceBarrierSampleCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_SAMPLE_COUNT")]
        MessageIDResourceBarrierSampleCount = 0x211,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS")]
        MessageIDResourceBarrierInvalidFlags = 0x212,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidCombinedFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINED_FLAGS")]
        MessageIDResourceBarrierInvalidCombinedFlags = 0x213,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidFlagsForFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS_FOR_FORMAT")]
        MessageIDResourceBarrierInvalidFlagsForFormat = 0x214,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidSplitBarrier\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SPLIT_BARRIER")]
        MessageIDResourceBarrierInvalidSplitBarrier = 0x215,
        [Obsolete("Deprecated in favour of \"ResourceBarrierUnmatchedEnd\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_END")]
        MessageIDResourceBarrierUnmatchedEnd = 0x216,
        [Obsolete("Deprecated in favour of \"ResourceBarrierUnmatchedBegin\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_BEGIN")]
        MessageIDResourceBarrierUnmatchedBegin = 0x217,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidFlag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAG")]
        MessageIDResourceBarrierInvalidFlag = 0x218,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidCommandListType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMMAND_LIST_TYPE")]
        MessageIDResourceBarrierInvalidCommandListType = 0x219,
        [Obsolete("Deprecated in favour of \"InvalidSubresourceState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_SUBRESOURCE_STATE")]
        MessageIDInvalidSubresourceState = 0x21A,
        [Obsolete("Deprecated in favour of \"CommandAllocatorContention\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CONTENTION")]
        MessageIDCommandAllocatorContention = 0x21C,
        [Obsolete("Deprecated in favour of \"CommandAllocatorReset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET")]
        MessageIDCommandAllocatorReset = 0x21D,
        [Obsolete("Deprecated in favour of \"CommandAllocatorResetBundle\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET_BUNDLE")]
        MessageIDCommandAllocatorResetBundle = 0x21E,
        [Obsolete("Deprecated in favour of \"CommandAllocatorCannotReset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CANNOT_RESET")]
        MessageIDCommandAllocatorCannotReset = 0x21F,
        [Obsolete("Deprecated in favour of \"CommandListOpen\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_OPEN")]
        MessageIDCommandListOpen = 0x220,
        [Obsolete("Deprecated in favour of \"InvalidBundleApi\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_BUNDLE_API")]
        MessageIDInvalidBundleApi = 0x222,
        [Obsolete("Deprecated in favour of \"CommandListClosed\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_CLOSED")]
        MessageIDCommandListClosed = 0x223,
        [Obsolete("Deprecated in favour of \"WrongCommandAllocatorType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRONG_COMMAND_ALLOCATOR_TYPE")]
        MessageIDWrongCommandAllocatorType = 0x225,
        [Obsolete("Deprecated in favour of \"CommandAllocatorSync\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_SYNC")]
        MessageIDCommandAllocatorSync = 0x228,
        [Obsolete("Deprecated in favour of \"CommandListSync\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_SYNC")]
        MessageIDCommandListSync = 0x229,
        [Obsolete("Deprecated in favour of \"SetDescriptorHeapInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_DESCRIPTOR_HEAP_INVALID")]
        MessageIDSetDescriptorHeapInvalid = 0x22A,
        [Obsolete("Deprecated in favour of \"CreateCommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDQUEUE")]
        MessageIDCreateCommandqueue = 0x22D,
        [Obsolete("Deprecated in favour of \"CreateCommandallocator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDALLOCATOR")]
        MessageIDCreateCommandallocator = 0x22E,
        [Obsolete("Deprecated in favour of \"CreatePipelinestate\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PIPELINESTATE")]
        MessageIDCreatePipelinestate = 0x22F,
        [Obsolete("Deprecated in favour of \"CreateCommandlist12\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDLIST12")]
        MessageIDCreateCommandlist12 = 0x230,
        [Obsolete("Deprecated in favour of \"CreateResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_RESOURCE")]
        MessageIDCreateResource = 0x232,
        [Obsolete("Deprecated in favour of \"CreateDescriptorheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTORHEAP")]
        MessageIDCreateDescriptorheap = 0x233,
        [Obsolete("Deprecated in favour of \"CreateRootsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOTSIGNATURE")]
        MessageIDCreateRootsignature = 0x234,
        [Obsolete("Deprecated in favour of \"CreateLibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_LIBRARY")]
        MessageIDCreateLibrary = 0x235,
        [Obsolete("Deprecated in favour of \"CreateHeap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_HEAP")]
        MessageIDCreateHeap = 0x236,
        [Obsolete("Deprecated in favour of \"CreateMonitoredfence\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_MONITOREDFENCE")]
        MessageIDCreateMonitoredfence = 0x237,
        [Obsolete("Deprecated in favour of \"CreateQueryheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUERYHEAP")]
        MessageIDCreateQueryheap = 0x238,
        [Obsolete("Deprecated in favour of \"CreateCommandsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDSIGNATURE")]
        MessageIDCreateCommandsignature = 0x239,
        [Obsolete("Deprecated in favour of \"LiveCommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDQUEUE")]
        MessageIDLiveCommandqueue = 0x23A,
        [Obsolete("Deprecated in favour of \"LiveCommandallocator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDALLOCATOR")]
        MessageIDLiveCommandallocator = 0x23B,
        [Obsolete("Deprecated in favour of \"LivePipelinestate\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PIPELINESTATE")]
        MessageIDLivePipelinestate = 0x23C,
        [Obsolete("Deprecated in favour of \"LiveCommandlist12\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDLIST12")]
        MessageIDLiveCommandlist12 = 0x23D,
        [Obsolete("Deprecated in favour of \"LiveResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_RESOURCE")]
        MessageIDLiveResource = 0x23F,
        [Obsolete("Deprecated in favour of \"LiveDescriptorheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_DESCRIPTORHEAP")]
        MessageIDLiveDescriptorheap = 0x240,
        [Obsolete("Deprecated in favour of \"LiveRootsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_ROOTSIGNATURE")]
        MessageIDLiveRootsignature = 0x241,
        [Obsolete("Deprecated in favour of \"LiveLibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_LIBRARY")]
        MessageIDLiveLibrary = 0x242,
        [Obsolete("Deprecated in favour of \"LiveHeap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_HEAP")]
        MessageIDLiveHeap = 0x243,
        [Obsolete("Deprecated in favour of \"LiveMonitoredfence\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_MONITOREDFENCE")]
        MessageIDLiveMonitoredfence = 0x244,
        [Obsolete("Deprecated in favour of \"LiveQueryheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_QUERYHEAP")]
        MessageIDLiveQueryheap = 0x245,
        [Obsolete("Deprecated in favour of \"LiveCommandsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDSIGNATURE")]
        MessageIDLiveCommandsignature = 0x246,
        [Obsolete("Deprecated in favour of \"DestroyCommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDQUEUE")]
        MessageIDDestroyCommandqueue = 0x247,
        [Obsolete("Deprecated in favour of \"DestroyCommandallocator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDALLOCATOR")]
        MessageIDDestroyCommandallocator = 0x248,
        [Obsolete("Deprecated in favour of \"DestroyPipelinestate\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PIPELINESTATE")]
        MessageIDDestroyPipelinestate = 0x249,
        [Obsolete("Deprecated in favour of \"DestroyCommandlist12\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDLIST12")]
        MessageIDDestroyCommandlist12 = 0x24A,
        [Obsolete("Deprecated in favour of \"DestroyResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_RESOURCE")]
        MessageIDDestroyResource = 0x24C,
        [Obsolete("Deprecated in favour of \"DestroyDescriptorheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_DESCRIPTORHEAP")]
        MessageIDDestroyDescriptorheap = 0x24D,
        [Obsolete("Deprecated in favour of \"DestroyRootsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_ROOTSIGNATURE")]
        MessageIDDestroyRootsignature = 0x24E,
        [Obsolete("Deprecated in favour of \"DestroyLibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_LIBRARY")]
        MessageIDDestroyLibrary = 0x24F,
        [Obsolete("Deprecated in favour of \"DestroyHeap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_HEAP")]
        MessageIDDestroyHeap = 0x250,
        [Obsolete("Deprecated in favour of \"DestroyMonitoredfence\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_MONITOREDFENCE")]
        MessageIDDestroyMonitoredfence = 0x251,
        [Obsolete("Deprecated in favour of \"DestroyQueryheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_QUERYHEAP")]
        MessageIDDestroyQueryheap = 0x252,
        [Obsolete("Deprecated in favour of \"DestroyCommandsignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDSIGNATURE")]
        MessageIDDestroyCommandsignature = 0x253,
        [Obsolete("Deprecated in favour of \"CreateresourceInvaliddimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONS")]
        MessageIDCreateresourceInvaliddimensions = 0x255,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidmiscflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMISCFLAGS")]
        MessageIDCreateresourceInvalidmiscflags = 0x257,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidargReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDARG_RETURN")]
        MessageIDCreateresourceInvalidargReturn = 0x25A,
        [Obsolete("Deprecated in favour of \"CreateresourceOutofmemoryReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_OUTOFMEMORY_RETURN")]
        MessageIDCreateresourceOutofmemoryReturn = 0x25B,
        [Obsolete("Deprecated in favour of \"CreateresourceInvaliddesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDESC")]
        MessageIDCreateresourceInvaliddesc = 0x25C,
        [Obsolete("Deprecated in favour of \"PossiblyInvalidSubresourceState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_POSSIBLY_INVALID_SUBRESOURCE_STATE")]
        MessageIDPossiblyInvalidSubresourceState = 0x25F,
        [Obsolete("Deprecated in favour of \"InvalidUseOfNonResidentResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_USE_OF_NON_RESIDENT_RESOURCE")]
        MessageIDInvalidUseOfNonResidentResource = 0x260,
        [Obsolete("Deprecated in favour of \"PossibleInvalidUseOfNonResidentResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_POSSIBLE_INVALID_USE_OF_NON_RESIDENT_RESOURCE")]
        MessageIDPossibleInvalidUseOfNonResidentResource = 0x261,
        [Obsolete("Deprecated in favour of \"BundlePipelineStateMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BUNDLE_PIPELINE_STATE_MISMATCH")]
        MessageIDBundlePipelineStateMismatch = 0x262,
        [Obsolete("Deprecated in favour of \"PrimitiveTopologyMismatchPipelineState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_MISMATCH_PIPELINE_STATE")]
        MessageIDPrimitiveTopologyMismatchPipelineState = 0x263,
        [Obsolete("Deprecated in favour of \"RenderTargetFormatMismatchPipelineState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_TARGET_FORMAT_MISMATCH_PIPELINE_STATE")]
        MessageIDRenderTargetFormatMismatchPipelineState = 0x265,
        [Obsolete("Deprecated in favour of \"RenderTargetSampleDescMismatchPipelineState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_TARGET_SAMPLE_DESC_MISMATCH_PIPELINE_STATE")]
        MessageIDRenderTargetSampleDescMismatchPipelineState = 0x266,
        [Obsolete("Deprecated in favour of \"DepthStencilFormatMismatchPipelineState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPTH_STENCIL_FORMAT_MISMATCH_PIPELINE_STATE")]
        MessageIDDepthStencilFormatMismatchPipelineState = 0x267,
        [Obsolete("Deprecated in favour of \"DepthStencilSampleDescMismatchPipelineState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPTH_STENCIL_SAMPLE_DESC_MISMATCH_PIPELINE_STATE")]
        MessageIDDepthStencilSampleDescMismatchPipelineState = 0x268,
        [Obsolete("Deprecated in favour of \"CreateshaderInvalidbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADER_INVALIDBYTECODE")]
        MessageIDCreateshaderInvalidbytecode = 0x26E,
        [Obsolete("Deprecated in favour of \"CreateheapNulldesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_NULLDESC")]
        MessageIDCreateheapNulldesc = 0x26F,
        [Obsolete("Deprecated in favour of \"CreateheapInvalidsize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDSIZE")]
        MessageIDCreateheapInvalidsize = 0x270,
        [Obsolete("Deprecated in favour of \"CreateheapUnrecognizedheaptype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDHEAPTYPE")]
        MessageIDCreateheapUnrecognizedheaptype = 0x271,
        [Obsolete("Deprecated in favour of \"CreateheapUnrecognizedcpupageproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES")]
        MessageIDCreateheapUnrecognizedcpupageproperties = 0x272,
        [Obsolete("Deprecated in favour of \"CreateheapUnrecognizedmemorypool\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMEMORYPOOL")]
        MessageIDCreateheapUnrecognizedmemorypool = 0x273,
        [Obsolete("Deprecated in favour of \"CreateheapInvalidproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDPROPERTIES")]
        MessageIDCreateheapInvalidproperties = 0x274,
        [Obsolete("Deprecated in favour of \"CreateheapInvalidalignment\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDALIGNMENT")]
        MessageIDCreateheapInvalidalignment = 0x275,
        [Obsolete("Deprecated in favour of \"CreateheapUnrecognizedmiscflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreateheapUnrecognizedmiscflags = 0x276,
        [Obsolete("Deprecated in favour of \"CreateheapInvalidmiscflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDMISCFLAGS")]
        MessageIDCreateheapInvalidmiscflags = 0x277,
        [Obsolete("Deprecated in favour of \"CreateheapInvalidargReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDARG_RETURN")]
        MessageIDCreateheapInvalidargReturn = 0x278,
        [Obsolete("Deprecated in favour of \"CreateheapOutofmemoryReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_OUTOFMEMORY_RETURN")]
        MessageIDCreateheapOutofmemoryReturn = 0x279,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapNullheapproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAPPROPERTIES")]
        MessageIDCreateresourceandheapNullheapproperties = 0x27A,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapUnrecognizedheaptype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPTYPE")]
        MessageIDCreateresourceandheapUnrecognizedheaptype = 0x27B,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapUnrecognizedcpupageproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES")]
        MessageIDCreateresourceandheapUnrecognizedcpupageproperties = 0x27C,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapUnrecognizedmemorypool\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDMEMORYPOOL")]
        MessageIDCreateresourceandheapUnrecognizedmemorypool = 0x27D,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapInvalidheapproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPPROPERTIES")]
        MessageIDCreateresourceandheapInvalidheapproperties = 0x27E,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapUnrecognizedheapmiscflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPMISCFLAGS")]
        MessageIDCreateresourceandheapUnrecognizedheapmiscflags = 0x27F,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapInvalidheapmiscflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPMISCFLAGS")]
        MessageIDCreateresourceandheapInvalidheapmiscflags = 0x280,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapInvalidargReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDARG_RETURN")]
        MessageIDCreateresourceandheapInvalidargReturn = 0x281,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapOutofmemoryReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_OUTOFMEMORY_RETURN")]
        MessageIDCreateresourceandheapOutofmemoryReturn = 0x282,
        [Obsolete("Deprecated in favour of \"GetcustomheappropertiesUnrecognizedheaptype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_UNRECOGNIZEDHEAPTYPE")]
        MessageIDGetcustomheappropertiesUnrecognizedheaptype = 0x283,
        [Obsolete("Deprecated in favour of \"GetcustomheappropertiesInvalidheaptype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_INVALIDHEAPTYPE")]
        MessageIDGetcustomheappropertiesInvalidheaptype = 0x284,
        [Obsolete("Deprecated in favour of \"CreateDescriptorHeapInvalidDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_INVALID_DESC")]
        MessageIDCreateDescriptorHeapInvalidDesc = 0x285,
        [Obsolete("Deprecated in favour of \"InvalidDescriptorHandle\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_DESCRIPTOR_HANDLE")]
        MessageIDInvalidDescriptorHandle = 0x286,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidConservativerastermode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE")]
        MessageIDCreaterasterizerstateInvalidConservativerastermode = 0x287,
        [Obsolete("Deprecated in favour of \"CreateConstantBufferViewInvalidResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_RESOURCE")]
        MessageIDCreateConstantBufferViewInvalidResource = 0x289,
        [Obsolete("Deprecated in favour of \"CreateConstantBufferViewInvalidDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_DESC")]
        MessageIDCreateConstantBufferViewInvalidDesc = 0x28A,
        [Obsolete("Deprecated in favour of \"CreateUnorderedaccessViewInvalidCounterUsage\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_UNORDEREDACCESS_VIEW_INVALID_COUNTER_USAGE")]
        MessageIDCreateUnorderedaccessViewInvalidCounterUsage = 0x28C,
        [Obsolete("Deprecated in favour of \"CopyDescriptorsInvalidRanges\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_DESCRIPTORS_INVALID_RANGES")]
        MessageIDCopyDescriptorsInvalidRanges = 0x28D,
        [Obsolete("Deprecated in favour of \"CopyDescriptorsWriteOnlyDescriptor\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_DESCRIPTORS_WRITE_ONLY_DESCRIPTOR")]
        MessageIDCopyDescriptorsWriteOnlyDescriptor = 0x28E,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateRtvFormatNotUnknown\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RTV_FORMAT_NOT_UNKNOWN")]
        MessageIDCreategraphicspipelinestateRtvFormatNotUnknown = 0x28F,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidRenderTargetCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_RENDER_TARGET_COUNT")]
        MessageIDCreategraphicspipelinestateInvalidRenderTargetCount = 0x290,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateVertexShaderNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VERTEX_SHADER_NOT_SET")]
        MessageIDCreategraphicspipelinestateVertexShaderNotSet = 0x291,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInputlayoutNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_NOT_SET")]
        MessageIDCreategraphicspipelinestateInputlayoutNotSet = 0x292,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageHSDSSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_HS_DS_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateShaderLinkageHSDSSignatureMismatch = 0x293,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageRegisterindex\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERINDEX")]
        MessageIDCreategraphicspipelinestateShaderLinkageRegisterindex = 0x294,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageComponenttype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_COMPONENTTYPE")]
        MessageIDCreategraphicspipelinestateShaderLinkageComponenttype = 0x295,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageRegistermask\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERMASK")]
        MessageIDCreategraphicspipelinestateShaderLinkageRegistermask = 0x296,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageSystemvalue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SYSTEMVALUE")]
        MessageIDCreategraphicspipelinestateShaderLinkageSystemvalue = 0x297,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageNeverwrittenAlwaysreads\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS")]
        MessageIDCreategraphicspipelinestateShaderLinkageNeverwrittenAlwaysreads = 0x298,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageMinprecision\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_MINPRECISION")]
        MessageIDCreategraphicspipelinestateShaderLinkageMinprecision = 0x299,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderLinkageSemanticnameNotFound\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND")]
        MessageIDCreategraphicspipelinestateShaderLinkageSemanticnameNotFound = 0x29A,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateHSXorDSMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_XOR_DS_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSXorDSMismatch = 0x29B,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateHullShaderInputTopologyMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH")]
        MessageIDCreategraphicspipelinestateHullShaderInputTopologyMismatch = 0x29C,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateHSDSControlPointCountMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_CONTROL_POINT_COUNT_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSDSControlPointCountMismatch = 0x29D,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateHSDSTessellatorDomainMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_TESSELLATOR_DOMAIN_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSDSTessellatorDomainMismatch = 0x29E,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidUseOfCenterMultisamplePattern\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN")]
        MessageIDCreategraphicspipelinestateInvalidUseOfCenterMultisamplePattern = 0x29F,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidUseOfForcedSampleCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_FORCED_SAMPLE_COUNT")]
        MessageIDCreategraphicspipelinestateInvalidUseOfForcedSampleCount = 0x2A0,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidPrimitivetopology\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_PRIMITIVETOPOLOGY")]
        MessageIDCreategraphicspipelinestateInvalidPrimitivetopology = 0x2A1,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidSystemvalue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SYSTEMVALUE")]
        MessageIDCreategraphicspipelinestateInvalidSystemvalue = 0x2A2,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateOMDualSourceBlendingCanOnlyHaveRenderTarget0\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0")]
        MessageIDCreategraphicspipelinestateOMDualSourceBlendingCanOnlyHaveRenderTarget0 = 0x2A3,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateOMRenderTargetDoesNotSupportBlending\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING")]
        MessageIDCreategraphicspipelinestateOMRenderTargetDoesNotSupportBlending = 0x2A4,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestatePSOutputTypeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_TYPE_MISMATCH")]
        MessageIDCreategraphicspipelinestatePSOutputTypeMismatch = 0x2A5,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateOMRenderTargetDoesNotSupportLogicOps\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS")]
        MessageIDCreategraphicspipelinestateOMRenderTargetDoesNotSupportLogicOps = 0x2A6,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateRendertargetviewNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDERTARGETVIEW_NOT_SET")]
        MessageIDCreategraphicspipelinestateRendertargetviewNotSet = 0x2A7,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateDepthstencilviewNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DEPTHSTENCILVIEW_NOT_SET")]
        MessageIDCreategraphicspipelinestateDepthstencilviewNotSet = 0x2A8,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateGSInputPrimitiveMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_INPUT_PRIMITIVE_MISMATCH")]
        MessageIDCreategraphicspipelinestateGSInputPrimitiveMismatch = 0x2A9,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestatePositionNotPresent\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_POSITION_NOT_PRESENT")]
        MessageIDCreategraphicspipelinestatePositionNotPresent = 0x2AA,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateMissingRootSignatureFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE_FLAGS")]
        MessageIDCreategraphicspipelinestateMissingRootSignatureFlags = 0x2AB,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidIndexBufferProperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_INDEX_BUFFER_PROPERTIES")]
        MessageIDCreategraphicspipelinestateInvalidIndexBufferProperties = 0x2AC,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInvalidSampleDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SAMPLE_DESC")]
        MessageIDCreategraphicspipelinestateInvalidSampleDesc = 0x2AD,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateHSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSRootSignatureMismatch = 0x2AE,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateDSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateDSRootSignatureMismatch = 0x2AF,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateVSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateVSRootSignatureMismatch = 0x2B0,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateGSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateGSRootSignatureMismatch = 0x2B1,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestatePSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestatePSRootSignatureMismatch = 0x2B2,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateMissingRootSignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE")]
        MessageIDCreategraphicspipelinestateMissingRootSignature = 0x2B3,
        [Obsolete("Deprecated in favour of \"ExecuteBundleOpenBundle\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_OPEN_BUNDLE")]
        MessageIDExecuteBundleOpenBundle = 0x2B4,
        [Obsolete("Deprecated in favour of \"ExecuteBundleDescriptorHeapMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_DESCRIPTOR_HEAP_MISMATCH")]
        MessageIDExecuteBundleDescriptorHeapMismatch = 0x2B5,
        [Obsolete("Deprecated in favour of \"ExecuteBundleType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_TYPE")]
        MessageIDExecuteBundleType = 0x2B6,
        [Obsolete("Deprecated in favour of \"DrawEmptyScissorRectangle\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DRAW_EMPTY_SCISSOR_RECTANGLE")]
        MessageIDDrawEmptyScissorRectangle = 0x2B7,
        [Obsolete("Deprecated in favour of \"CreateRootSignatureBlobNotFound\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_BLOB_NOT_FOUND")]
        MessageIDCreateRootSignatureBlobNotFound = 0x2B8,
        [Obsolete("Deprecated in favour of \"CreateRootSignatureDeserializeFailed\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_DESERIALIZE_FAILED")]
        MessageIDCreateRootSignatureDeserializeFailed = 0x2B9,
        [Obsolete("Deprecated in favour of \"CreateRootSignatureInvalidConfiguration\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_INVALID_CONFIGURATION")]
        MessageIDCreateRootSignatureInvalidConfiguration = 0x2BA,
        [Obsolete("Deprecated in favour of \"CreateRootSignatureNotSupportedOnDevice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDCreateRootSignatureNotSupportedOnDevice = 0x2BB,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapNullresourceproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLRESOURCEPROPERTIES")]
        MessageIDCreateresourceandheapNullresourceproperties = 0x2BC,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapNullheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAP")]
        MessageIDCreateresourceandheapNullheap = 0x2BD,
        [Obsolete("Deprecated in favour of \"GetresourceallocationinfoInvalidrdescs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETRESOURCEALLOCATIONINFO_INVALIDRDESCS")]
        MessageIDGetresourceallocationinfoInvalidrdescs = 0x2BE,
        [Obsolete("Deprecated in favour of \"MakeresidentNullobjectarray\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAKERESIDENT_NULLOBJECTARRAY")]
        MessageIDMakeresidentNullobjectarray = 0x2BF,
        [Obsolete("Deprecated in favour of \"EvictNullobjectarray\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EVICT_NULLOBJECTARRAY")]
        MessageIDEvictNullobjectarray = 0x2C1,
        [Obsolete("Deprecated in favour of \"SetDescriptorTableInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_DESCRIPTOR_TABLE_INVALID")]
        MessageIDSetDescriptorTableInvalid = 0x2C4,
        [Obsolete("Deprecated in favour of \"SetRootConstantInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_INVALID")]
        MessageIDSetRootConstantInvalid = 0x2C5,
        [Obsolete("Deprecated in favour of \"SetRootConstantBufferViewInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_BUFFER_VIEW_INVALID")]
        MessageIDSetRootConstantBufferViewInvalid = 0x2C6,
        [Obsolete("Deprecated in favour of \"SetRootShaderResourceViewInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_SHADER_RESOURCE_VIEW_INVALID")]
        MessageIDSetRootShaderResourceViewInvalid = 0x2C7,
        [Obsolete("Deprecated in favour of \"SetRootUnorderedAccessViewInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_UNORDERED_ACCESS_VIEW_INVALID")]
        MessageIDSetRootUnorderedAccessViewInvalid = 0x2C8,
        [Obsolete("Deprecated in favour of \"SetVertexBuffersInvalidDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID_DESC")]
        MessageIDSetVertexBuffersInvalidDesc = 0x2C9,
        [Obsolete("Deprecated in favour of \"SetIndexBufferInvalidDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID_DESC")]
        MessageIDSetIndexBufferInvalidDesc = 0x2CB,
        [Obsolete("Deprecated in favour of \"SetStreamOutputBuffersInvalidDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID_DESC")]
        MessageIDSetStreamOutputBuffersInvalidDesc = 0x2CD,
        [Obsolete("Deprecated in favour of \"CreateresourceUnrecognizeddimensionality\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDDIMENSIONALITY")]
        MessageIDCreateresourceUnrecognizeddimensionality = 0x2CE,
        [Obsolete("Deprecated in favour of \"CreateresourceUnrecognizedlayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDLAYOUT")]
        MessageIDCreateresourceUnrecognizedlayout = 0x2CF,
        [Obsolete("Deprecated in favour of \"CreateresourceInvaliddimensionality\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONALITY")]
        MessageIDCreateresourceInvaliddimensionality = 0x2D0,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidalignment\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT")]
        MessageIDCreateresourceInvalidalignment = 0x2D1,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidmiplevels\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMIPLEVELS")]
        MessageIDCreateresourceInvalidmiplevels = 0x2D2,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidsampledesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDSAMPLEDESC")]
        MessageIDCreateresourceInvalidsampledesc = 0x2D3,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidlayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDLAYOUT")]
        MessageIDCreateresourceInvalidlayout = 0x2D4,
        [Obsolete("Deprecated in favour of \"SetIndexBufferInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID")]
        MessageIDSetIndexBufferInvalid = 0x2D5,
        [Obsolete("Deprecated in favour of \"SetVertexBuffersInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID")]
        MessageIDSetVertexBuffersInvalid = 0x2D6,
        [Obsolete("Deprecated in favour of \"SetStreamOutputBuffersInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID")]
        MessageIDSetStreamOutputBuffersInvalid = 0x2D7,
        [Obsolete("Deprecated in favour of \"SetRenderTargetsInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_RENDER_TARGETS_INVALID")]
        MessageIDSetRenderTargetsInvalid = 0x2D8,
        [Obsolete("Deprecated in favour of \"CreatequeryHeapInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_INVALID_PARAMETERS")]
        MessageIDCreatequeryHeapInvalidParameters = 0x2D9,
        [Obsolete("Deprecated in favour of \"BeginEndQueryInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_END_QUERY_INVALID_PARAMETERS")]
        MessageIDBeginEndQueryInvalidParameters = 0x2DB,
        [Obsolete("Deprecated in favour of \"CloseCommandListOpenQuery\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLOSE_COMMAND_LIST_OPEN_QUERY")]
        MessageIDCloseCommandListOpenQuery = 0x2DC,
        [Obsolete("Deprecated in favour of \"ResolveQueryDataInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_QUERY_DATA_INVALID_PARAMETERS")]
        MessageIDResolveQueryDataInvalidParameters = 0x2DD,
        [Obsolete("Deprecated in favour of \"SetPredicationInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PREDICATION_INVALID_PARAMETERS")]
        MessageIDSetPredicationInvalidParameters = 0x2DE,
        [Obsolete("Deprecated in favour of \"TimestampsNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_TIMESTAMPS_NOT_SUPPORTED")]
        MessageIDTimestampsNotSupported = 0x2DF,
        [Obsolete("Deprecated in favour of \"CreateresourceUnrecognizedformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDFORMAT")]
        MessageIDCreateresourceUnrecognizedformat = 0x2E1,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDFORMAT")]
        MessageIDCreateresourceInvalidformat = 0x2E2,
        [Obsolete("Deprecated in favour of \"GetcopyablefootprintsInvalidsubresourcerange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDSUBRESOURCERANGE")]
        MessageIDGetcopyablefootprintsInvalidsubresourcerange = 0x2E3,
        [Obsolete("Deprecated in favour of \"GetcopyablefootprintsInvalidbaseoffset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDBASEOFFSET")]
        MessageIDGetcopyablefootprintsInvalidbaseoffset = 0x2E4,
        [Obsolete("Deprecated in favour of \"GetcopyablelayoutInvalidsubresourcerange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDSUBRESOURCERANGE")]
        MessageIDGetcopyablelayoutInvalidsubresourcerange = 0x2E3,
        [Obsolete("Deprecated in favour of \"GetcopyablelayoutInvalidbaseoffset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDBASEOFFSET")]
        MessageIDGetcopyablelayoutInvalidbaseoffset = 0x2E4,
        [Obsolete("Deprecated in favour of \"ResourceBarrierInvalidHeap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_HEAP")]
        MessageIDResourceBarrierInvalidHeap = 0x2E5,
        [Obsolete("Deprecated in favour of \"CreateSamplerInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SAMPLER_INVALID")]
        MessageIDCreateSamplerInvalid = 0x2E6,
        [Obsolete("Deprecated in favour of \"CreatecommandsignatureInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMMANDSIGNATURE_INVALID")]
        MessageIDCreatecommandsignatureInvalid = 0x2E7,
        [Obsolete("Deprecated in favour of \"ExecuteIndirectInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_INDIRECT_INVALID_PARAMETERS")]
        MessageIDExecuteIndirectInvalidParameters = 0x2E8,
        [Obsolete("Deprecated in favour of \"GetgpuvirtualaddressInvalidResourceDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_RESOURCE_DIMENSION")]
        MessageIDGetgpuvirtualaddressInvalidResourceDimension = 0x2E9,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidclearvalue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUE")]
        MessageIDCreateresourceInvalidclearvalue = 0x32F,
        [Obsolete("Deprecated in favour of \"CreateresourceUnrecognizedclearvalueformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDCLEARVALUEFORMAT")]
        MessageIDCreateresourceUnrecognizedclearvalueformat = 0x330,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidclearvalueformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUEFORMAT")]
        MessageIDCreateresourceInvalidclearvalueformat = 0x331,
        [Obsolete("Deprecated in favour of \"CreateresourceClearvaluedenormflush\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_CLEARVALUEDENORMFLUSH")]
        MessageIDCreateresourceClearvaluedenormflush = 0x332,
        [Obsolete("Deprecated in favour of \"ClearrendertargetviewMismatchingclearvalue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARRENDERTARGETVIEW_MISMATCHINGCLEARVALUE")]
        MessageIDClearrendertargetviewMismatchingclearvalue = 0x334,
        [Obsolete("Deprecated in favour of \"CleardepthstencilviewMismatchingclearvalue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_MISMATCHINGCLEARVALUE")]
        MessageIDCleardepthstencilviewMismatchingclearvalue = 0x335,
        [Obsolete("Deprecated in favour of \"MapInvalidheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDHEAP")]
        MessageIDMapInvalidheap = 0x336,
        [Obsolete("Deprecated in favour of \"UnmapInvalidheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDHEAP")]
        MessageIDUnmapInvalidheap = 0x337,
        [Obsolete("Deprecated in favour of \"MapInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDRESOURCE")]
        MessageIDMapInvalidresource = 0x338,
        [Obsolete("Deprecated in favour of \"UnmapInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDRESOURCE")]
        MessageIDUnmapInvalidresource = 0x339,
        [Obsolete("Deprecated in favour of \"MapInvalidsubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDSUBRESOURCE")]
        MessageIDMapInvalidsubresource = 0x33A,
        [Obsolete("Deprecated in favour of \"UnmapInvalidsubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDUnmapInvalidsubresource = 0x33B,
        [Obsolete("Deprecated in favour of \"MapInvalidrange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDRANGE")]
        MessageIDMapInvalidrange = 0x33C,
        [Obsolete("Deprecated in favour of \"UnmapInvalidrange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDRANGE")]
        MessageIDUnmapInvalidrange = 0x33D,
        [Obsolete("Deprecated in favour of \"MapInvaliddatapointer\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDDATAPOINTER")]
        MessageIDMapInvaliddatapointer = 0x340,
        [Obsolete("Deprecated in favour of \"MapInvalidargReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDARG_RETURN")]
        MessageIDMapInvalidargReturn = 0x341,
        [Obsolete("Deprecated in favour of \"MapOutofmemoryReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_OUTOFMEMORY_RETURN")]
        MessageIDMapOutofmemoryReturn = 0x342,
        [Obsolete("Deprecated in favour of \"ExecutecommandlistsBundlenotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_BUNDLENOTSUPPORTED")]
        MessageIDExecutecommandlistsBundlenotsupported = 0x343,
        [Obsolete("Deprecated in favour of \"ExecutecommandlistsCommandlistmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_COMMANDLISTMISMATCH")]
        MessageIDExecutecommandlistsCommandlistmismatch = 0x344,
        [Obsolete("Deprecated in favour of \"ExecutecommandlistsOpencommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_OPENCOMMANDLIST")]
        MessageIDExecutecommandlistsOpencommandlist = 0x345,
        [Obsolete("Deprecated in favour of \"ExecutecommandlistsFailedcommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_FAILEDCOMMANDLIST")]
        MessageIDExecutecommandlistsFailedcommandlist = 0x346,
        [Obsolete("Deprecated in favour of \"CopybufferregionNulldst\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLDST")]
        MessageIDCopybufferregionNulldst = 0x347,
        [Obsolete("Deprecated in favour of \"CopybufferregionInvaliddstresourcedimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDDSTRESOURCEDIMENSION")]
        MessageIDCopybufferregionInvaliddstresourcedimension = 0x348,
        [Obsolete("Deprecated in favour of \"CopybufferregionDstrangeoutofbounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_DSTRANGEOUTOFBOUNDS")]
        MessageIDCopybufferregionDstrangeoutofbounds = 0x349,
        [Obsolete("Deprecated in favour of \"CopybufferregionNullsrc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLSRC")]
        MessageIDCopybufferregionNullsrc = 0x34A,
        [Obsolete("Deprecated in favour of \"CopybufferregionInvalidsrcresourcedimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDSRCRESOURCEDIMENSION")]
        MessageIDCopybufferregionInvalidsrcresourcedimension = 0x34B,
        [Obsolete("Deprecated in favour of \"CopybufferregionSrcrangeoutofbounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_SRCRANGEOUTOFBOUNDS")]
        MessageIDCopybufferregionSrcrangeoutofbounds = 0x34C,
        [Obsolete("Deprecated in favour of \"CopybufferregionInvalidcopyflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDCOPYFLAGS")]
        MessageIDCopybufferregionInvalidcopyflags = 0x34D,
        [Obsolete("Deprecated in favour of \"CopytextureregionNulldst\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLDST")]
        MessageIDCopytextureregionNulldst = 0x34E,
        [Obsolete("Deprecated in favour of \"CopytextureregionUnrecognizeddsttype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTTYPE")]
        MessageIDCopytextureregionUnrecognizeddsttype = 0x34F,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstresourcedimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCEDIMENSION")]
        MessageIDCopytextureregionInvaliddstresourcedimension = 0x350,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCE")]
        MessageIDCopytextureregionInvaliddstresource = 0x351,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstsubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTSUBRESOURCE")]
        MessageIDCopytextureregionInvaliddstsubresource = 0x352,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstoffset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTOFFSET")]
        MessageIDCopytextureregionInvaliddstoffset = 0x353,
        [Obsolete("Deprecated in favour of \"CopytextureregionUnrecognizeddstformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTFORMAT")]
        MessageIDCopytextureregionUnrecognizeddstformat = 0x354,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTFORMAT")]
        MessageIDCopytextureregionInvaliddstformat = 0x355,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstdimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDIMENSIONS")]
        MessageIDCopytextureregionInvaliddstdimensions = 0x356,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstrowpitch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTROWPITCH")]
        MessageIDCopytextureregionInvaliddstrowpitch = 0x357,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstplacement\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTPLACEMENT")]
        MessageIDCopytextureregionInvaliddstplacement = 0x358,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstdsplacedfootprintformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDSPLACEDFOOTPRINTFORMAT")]
        MessageIDCopytextureregionInvaliddstdsplacedfootprintformat = 0x359,
        [Obsolete("Deprecated in favour of \"CopytextureregionDstregionoutofbounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_DSTREGIONOUTOFBOUNDS")]
        MessageIDCopytextureregionDstregionoutofbounds = 0x35A,
        [Obsolete("Deprecated in favour of \"CopytextureregionNullsrc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLSRC")]
        MessageIDCopytextureregionNullsrc = 0x35B,
        [Obsolete("Deprecated in favour of \"CopytextureregionUnrecognizedsrctype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCTYPE")]
        MessageIDCopytextureregionUnrecognizedsrctype = 0x35C,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcresourcedimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCEDIMENSION")]
        MessageIDCopytextureregionInvalidsrcresourcedimension = 0x35D,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCE")]
        MessageIDCopytextureregionInvalidsrcresource = 0x35E,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcsubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCSUBRESOURCE")]
        MessageIDCopytextureregionInvalidsrcsubresource = 0x35F,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcoffset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCOFFSET")]
        MessageIDCopytextureregionInvalidsrcoffset = 0x360,
        [Obsolete("Deprecated in favour of \"CopytextureregionUnrecognizedsrcformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCFORMAT")]
        MessageIDCopytextureregionUnrecognizedsrcformat = 0x361,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCFORMAT")]
        MessageIDCopytextureregionInvalidsrcformat = 0x362,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcdimensions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDIMENSIONS")]
        MessageIDCopytextureregionInvalidsrcdimensions = 0x363,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcrowpitch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCROWPITCH")]
        MessageIDCopytextureregionInvalidsrcrowpitch = 0x364,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcplacement\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCPLACEMENT")]
        MessageIDCopytextureregionInvalidsrcplacement = 0x365,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcdsplacedfootprintformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDSPLACEDFOOTPRINTFORMAT")]
        MessageIDCopytextureregionInvalidsrcdsplacedfootprintformat = 0x366,
        [Obsolete("Deprecated in favour of \"CopytextureregionSrcregionoutofbounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_SRCREGIONOUTOFBOUNDS")]
        MessageIDCopytextureregionSrcregionoutofbounds = 0x367,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvaliddstcoordinates\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTCOORDINATES")]
        MessageIDCopytextureregionInvaliddstcoordinates = 0x368,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidsrcbox\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCBOX")]
        MessageIDCopytextureregionInvalidsrcbox = 0x369,
        [Obsolete("Deprecated in favour of \"CopytextureregionFormatmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_FORMATMISMATCH")]
        MessageIDCopytextureregionFormatmismatch = 0x36A,
        [Obsolete("Deprecated in favour of \"CopytextureregionEmptybox\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_EMPTYBOX")]
        MessageIDCopytextureregionEmptybox = 0x36B,
        [Obsolete("Deprecated in favour of \"CopytextureregionInvalidcopyflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDCOPYFLAGS")]
        MessageIDCopytextureregionInvalidcopyflags = 0x36C,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceInvalidSubresourceIndex\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SUBRESOURCE_INDEX")]
        MessageIDResolvesubresourceInvalidSubresourceIndex = 0x36D,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceInvalidFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_FORMAT")]
        MessageIDResolvesubresourceInvalidFormat = 0x36E,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceResourceMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_MISMATCH")]
        MessageIDResolvesubresourceResourceMismatch = 0x36F,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceInvalidSampleCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SAMPLE_COUNT")]
        MessageIDResolvesubresourceInvalidSampleCount = 0x370,
        [Obsolete("Deprecated in favour of \"CreatecomputepipelinestateInvalidShader\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_INVALID_SHADER")]
        MessageIDCreatecomputepipelinestateInvalidShader = 0x371,
        [Obsolete("Deprecated in favour of \"CreatecomputepipelinestateCSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_CS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreatecomputepipelinestateCSRootSignatureMismatch = 0x372,
        [Obsolete("Deprecated in favour of \"CreatecomputepipelinestateMissingRootSignature\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_MISSING_ROOT_SIGNATURE")]
        MessageIDCreatecomputepipelinestateMissingRootSignature = 0x373,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateInvalidcachedblob\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALIDCACHEDBLOB")]
        MessageIDCreatepipelinestateInvalidcachedblob = 0x374,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateCachedblobadaptermismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBADAPTERMISMATCH")]
        MessageIDCreatepipelinestateCachedblobadaptermismatch = 0x375,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateCachedblobdriverversionmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDRIVERVERSIONMISMATCH")]
        MessageIDCreatepipelinestateCachedblobdriverversionmismatch = 0x376,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateCachedblobdescmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDESCMISMATCH")]
        MessageIDCreatepipelinestateCachedblobdescmismatch = 0x377,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateCachedblobignored\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBIGNORED")]
        MessageIDCreatepipelinestateCachedblobignored = 0x378,
        [Obsolete("Deprecated in favour of \"WritetosubresourceInvalidheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDHEAP")]
        MessageIDWritetosubresourceInvalidheap = 0x379,
        [Obsolete("Deprecated in favour of \"WritetosubresourceInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDRESOURCE")]
        MessageIDWritetosubresourceInvalidresource = 0x37A,
        [Obsolete("Deprecated in favour of \"WritetosubresourceInvalidbox\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDBOX")]
        MessageIDWritetosubresourceInvalidbox = 0x37B,
        [Obsolete("Deprecated in favour of \"WritetosubresourceInvalidsubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDSUBRESOURCE")]
        MessageIDWritetosubresourceInvalidsubresource = 0x37C,
        [Obsolete("Deprecated in favour of \"WritetosubresourceEmptybox\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_EMPTYBOX")]
        MessageIDWritetosubresourceEmptybox = 0x37D,
        [Obsolete("Deprecated in favour of \"ReadfromsubresourceInvalidheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDHEAP")]
        MessageIDReadfromsubresourceInvalidheap = 0x37E,
        [Obsolete("Deprecated in favour of \"ReadfromsubresourceInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDRESOURCE")]
        MessageIDReadfromsubresourceInvalidresource = 0x37F,
        [Obsolete("Deprecated in favour of \"ReadfromsubresourceInvalidbox\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDBOX")]
        MessageIDReadfromsubresourceInvalidbox = 0x380,
        [Obsolete("Deprecated in favour of \"ReadfromsubresourceInvalidsubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDSUBRESOURCE")]
        MessageIDReadfromsubresourceInvalidsubresource = 0x381,
        [Obsolete("Deprecated in favour of \"ReadfromsubresourceEmptybox\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_EMPTYBOX")]
        MessageIDReadfromsubresourceEmptybox = 0x382,
        [Obsolete("Deprecated in favour of \"TooManyNodesSpecified\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_TOO_MANY_NODES_SPECIFIED")]
        MessageIDTooManyNodesSpecified = 0x383,
        [Obsolete("Deprecated in favour of \"InvalidNodeIndex\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_NODE_INDEX")]
        MessageIDInvalidNodeIndex = 0x384,
        [Obsolete("Deprecated in favour of \"GetheappropertiesInvalidresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETHEAPPROPERTIES_INVALIDRESOURCE")]
        MessageIDGetheappropertiesInvalidresource = 0x385,
        [Obsolete("Deprecated in favour of \"NodeMaskMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NODE_MASK_MISMATCH")]
        MessageIDNodeMaskMismatch = 0x386,
        [Obsolete("Deprecated in favour of \"CommandListOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_OUTOFMEMORY")]
        MessageIDCommandListOutofmemory = 0x387,
        [Obsolete("Deprecated in favour of \"CommandListMultipleSwapchainBufferReferences\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_MULTIPLE_SWAPCHAIN_BUFFER_REFERENCES")]
        MessageIDCommandListMultipleSwapchainBufferReferences = 0x388,
        [Obsolete("Deprecated in favour of \"CommandListTooManySwapchainReferences\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_TOO_MANY_SWAPCHAIN_REFERENCES")]
        MessageIDCommandListTooManySwapchainReferences = 0x389,
        [Obsolete("Deprecated in favour of \"CommandQueueTooManySwapchainReferences\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_QUEUE_TOO_MANY_SWAPCHAIN_REFERENCES")]
        MessageIDCommandQueueTooManySwapchainReferences = 0x38A,
        [Obsolete("Deprecated in favour of \"ExecutecommandlistsWrongswapchainbufferreference\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_WRONGSWAPCHAINBUFFERREFERENCE")]
        MessageIDExecutecommandlistsWrongswapchainbufferreference = 0x38B,
        [Obsolete("Deprecated in favour of \"CommandListSetrendertargetsInvalidnumrendertargets\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_SETRENDERTARGETS_INVALIDNUMRENDERTARGETS")]
        MessageIDCommandListSetrendertargetsInvalidnumrendertargets = 0x38C,
        [Obsolete("Deprecated in favour of \"CreateQueueInvalidType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_TYPE")]
        MessageIDCreateQueueInvalidType = 0x38D,
        [Obsolete("Deprecated in favour of \"CreateQueueInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_FLAGS")]
        MessageIDCreateQueueInvalidFlags = 0x38E,
        [Obsolete("Deprecated in favour of \"CreatesharedresourceInvalidflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFLAGS")]
        MessageIDCreatesharedresourceInvalidflags = 0x38F,
        [Obsolete("Deprecated in favour of \"CreatesharedresourceInvalidformat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFORMAT")]
        MessageIDCreatesharedresourceInvalidformat = 0x390,
        [Obsolete("Deprecated in favour of \"CreatesharedheapInvalidflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDHEAP_INVALIDFLAGS")]
        MessageIDCreatesharedheapInvalidflags = 0x391,
        [Obsolete("Deprecated in favour of \"ReflectsharedpropertiesUnrecognizedproperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_UNRECOGNIZEDPROPERTIES")]
        MessageIDReflectsharedpropertiesUnrecognizedproperties = 0x392,
        [Obsolete("Deprecated in favour of \"ReflectsharedpropertiesInvalidsize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDSIZE")]
        MessageIDReflectsharedpropertiesInvalidsize = 0x393,
        [Obsolete("Deprecated in favour of \"ReflectsharedpropertiesInvalidobject\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDOBJECT")]
        MessageIDReflectsharedpropertiesInvalidobject = 0x394,
        [Obsolete("Deprecated in favour of \"KeyedmutexInvalidobject\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDOBJECT")]
        MessageIDKeyedmutexInvalidobject = 0x395,
        [Obsolete("Deprecated in favour of \"KeyedmutexInvalidkey\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDKEY")]
        MessageIDKeyedmutexInvalidkey = 0x396,
        [Obsolete("Deprecated in favour of \"KeyedmutexWrongstate\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_WRONGSTATE")]
        MessageIDKeyedmutexWrongstate = 0x397,
        [Obsolete("Deprecated in favour of \"CreateQueueInvalidPriority\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_PRIORITY")]
        MessageIDCreateQueueInvalidPriority = 0x398,
        [Obsolete("Deprecated in favour of \"ObjectDeletedWhileStillInUse\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_DELETED_WHILE_STILL_IN_USE")]
        MessageIDObjectDeletedWhileStillInUse = 0x399,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_FLAGS")]
        MessageIDCreatepipelinestateInvalidFlags = 0x39A,
        [Obsolete("Deprecated in favour of \"HeapAddressRangeHasNoResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_HAS_NO_RESOURCE")]
        MessageIDHeapAddressRangeHasNoResource = 0x39B,
        [Obsolete("Deprecated in favour of \"CommandListDrawRenderTargetDeleted\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_RENDER_TARGET_DELETED")]
        MessageIDCommandListDrawRenderTargetDeleted = 0x39C,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateAllRenderTargetsHaveUnknownFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_ALL_RENDER_TARGETS_HAVE_UNKNOWN_FORMAT")]
        MessageIDCreategraphicspipelinestateAllRenderTargetsHaveUnknownFormat = 0x39D,
        [Obsolete("Deprecated in favour of \"HeapAddressRangeIntersectsMultipleBuffers\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_INTERSECTS_MULTIPLE_BUFFERS")]
        MessageIDHeapAddressRangeIntersectsMultipleBuffers = 0x39E,
        [Obsolete("Deprecated in favour of \"ExecutecommandlistsGpuWrittenReadbackResourceMapped\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_GPU_WRITTEN_READBACK_RESOURCE_MAPPED")]
        MessageIDExecutecommandlistsGpuWrittenReadbackResourceMapped = 0x39F,
        [Obsolete("Deprecated in favour of \"UnmapRangeNotEmpty\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_RANGE_NOT_EMPTY")]
        MessageIDUnmapRangeNotEmpty = 0x3A1,
        [Obsolete("Deprecated in favour of \"MapInvalidNullrange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALID_NULLRANGE")]
        MessageIDMapInvalidNullrange = 0x3A2,
        [Obsolete("Deprecated in favour of \"UnmapInvalidNullrange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALID_NULLRANGE")]
        MessageIDUnmapInvalidNullrange = 0x3A3,
        [Obsolete("Deprecated in favour of \"NoGraphicsApiSupport\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_GRAPHICS_API_SUPPORT")]
        MessageIDNoGraphicsApiSupport = 0x3A4,
        [Obsolete("Deprecated in favour of \"NoComputeApiSupport\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_COMPUTE_API_SUPPORT")]
        MessageIDNoComputeApiSupport = 0x3A5,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceResourceFlagsNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_FLAGS_NOT_SUPPORTED")]
        MessageIDResolvesubresourceResourceFlagsNotSupported = 0x3A6,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationRootArgumentUninitialized\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_ARGUMENT_UNINITIALIZED")]
        MessageIDGpuBasedValidationRootArgumentUninitialized = 0x3A7,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationDescriptorHeapIndexOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_HEAP_INDEX_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationDescriptorHeapIndexOutOfBounds = 0x3A8,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationDescriptorTableRegisterIndexOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TABLE_REGISTER_INDEX_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationDescriptorTableRegisterIndexOutOfBounds = 0x3A9,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationDescriptorUninitialized\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_UNINITIALIZED")]
        MessageIDGpuBasedValidationDescriptorUninitialized = 0x3AA,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationDescriptorTypeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TYPE_MISMATCH")]
        MessageIDGpuBasedValidationDescriptorTypeMismatch = 0x3AB,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationSrvResourceDimensionMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SRV_RESOURCE_DIMENSION_MISMATCH")]
        MessageIDGpuBasedValidationSrvResourceDimensionMismatch = 0x3AC,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationUavResourceDimensionMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UAV_RESOURCE_DIMENSION_MISMATCH")]
        MessageIDGpuBasedValidationUavResourceDimensionMismatch = 0x3AD,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationIncompatibleResourceState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_RESOURCE_STATE")]
        MessageIDGpuBasedValidationIncompatibleResourceState = 0x3AE,
        [Obsolete("Deprecated in favour of \"CopyresourceNulldst\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_NULLDST")]
        MessageIDCopyresourceNulldst = 0x3AF,
        [Obsolete("Deprecated in favour of \"CopyresourceInvaliddstresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDDSTRESOURCE")]
        MessageIDCopyresourceInvaliddstresource = 0x3B0,
        [Obsolete("Deprecated in favour of \"CopyresourceNullsrc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_NULLSRC")]
        MessageIDCopyresourceNullsrc = 0x3B1,
        [Obsolete("Deprecated in favour of \"CopyresourceInvalidsrcresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDSRCRESOURCE")]
        MessageIDCopyresourceInvalidsrcresource = 0x3B2,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceNulldst\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLDST")]
        MessageIDResolvesubresourceNulldst = 0x3B3,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceInvaliddstresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDDSTRESOURCE")]
        MessageIDResolvesubresourceInvaliddstresource = 0x3B4,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceNullsrc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLSRC")]
        MessageIDResolvesubresourceNullsrc = 0x3B5,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceInvalidsrcresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDSRCRESOURCE")]
        MessageIDResolvesubresourceInvalidsrcresource = 0x3B6,
        [Obsolete("Deprecated in favour of \"PipelineStateTypeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PIPELINE_STATE_TYPE_MISMATCH")]
        MessageIDPipelineStateTypeMismatch = 0x3B7,
        [Obsolete("Deprecated in favour of \"CommandListDispatchRootSignatureNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_NOT_SET")]
        MessageIDCommandListDispatchRootSignatureNotSet = 0x3B8,
        [Obsolete("Deprecated in favour of \"CommandListDispatchRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCommandListDispatchRootSignatureMismatch = 0x3B9,
        [Obsolete("Deprecated in favour of \"ResourceBarrierZeroBarriers\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_ZERO_BARRIERS")]
        MessageIDResourceBarrierZeroBarriers = 0x3BA,
        [Obsolete("Deprecated in favour of \"BeginEndEventMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_END_EVENT_MISMATCH")]
        MessageIDBeginEndEventMismatch = 0x3BB,
        [Obsolete("Deprecated in favour of \"ResourceBarrierPossibleBeforeAfterMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_POSSIBLE_BEFORE_AFTER_MISMATCH")]
        MessageIDResourceBarrierPossibleBeforeAfterMismatch = 0x3BC,
        [Obsolete("Deprecated in favour of \"ResourceBarrierMismatchingBeginEnd\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_BEGIN_END")]
        MessageIDResourceBarrierMismatchingBeginEnd = 0x3BD,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationInvalidResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INVALID_RESOURCE")]
        MessageIDGpuBasedValidationInvalidResource = 0x3BE,
        [Obsolete("Deprecated in favour of \"UseOfZeroRefcountObject\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT")]
        MessageIDUseOfZeroRefcountObject = 0x3BF,
        [Obsolete("Deprecated in favour of \"ObjectEvictedWhileStillInUse\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_EVICTED_WHILE_STILL_IN_USE")]
        MessageIDObjectEvictedWhileStillInUse = 0x3C0,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationRootDescriptorAccessOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_DESCRIPTOR_ACCESS_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationRootDescriptorAccessOutOfBounds = 0x3C1,
        [Obsolete("Deprecated in favour of \"CreatepipelinelibraryInvalidlibraryblob\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_INVALIDLIBRARYBLOB")]
        MessageIDCreatepipelinelibraryInvalidlibraryblob = 0x3C2,
        [Obsolete("Deprecated in favour of \"CreatepipelinelibraryDriverversionmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_DRIVERVERSIONMISMATCH")]
        MessageIDCreatepipelinelibraryDriverversionmismatch = 0x3C3,
        [Obsolete("Deprecated in favour of \"CreatepipelinelibraryAdapterversionmismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_ADAPTERVERSIONMISMATCH")]
        MessageIDCreatepipelinelibraryAdapterversionmismatch = 0x3C4,
        [Obsolete("Deprecated in favour of \"CreatepipelinelibraryUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_UNSUPPORTED")]
        MessageIDCreatepipelinelibraryUnsupported = 0x3C5,
        [Obsolete("Deprecated in favour of \"CreatePipelinelibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PIPELINELIBRARY")]
        MessageIDCreatePipelinelibrary = 0x3C6,
        [Obsolete("Deprecated in favour of \"LivePipelinelibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PIPELINELIBRARY")]
        MessageIDLivePipelinelibrary = 0x3C7,
        [Obsolete("Deprecated in favour of \"DestroyPipelinelibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PIPELINELIBRARY")]
        MessageIDDestroyPipelinelibrary = 0x3C8,
        [Obsolete("Deprecated in favour of \"StorepipelineNoname\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_STOREPIPELINE_NONAME")]
        MessageIDStorepipelineNoname = 0x3C9,
        [Obsolete("Deprecated in favour of \"StorepipelineDuplicatename\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_STOREPIPELINE_DUPLICATENAME")]
        MessageIDStorepipelineDuplicatename = 0x3CA,
        [Obsolete("Deprecated in favour of \"LoadpipelineNamenotfound\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LOADPIPELINE_NAMENOTFOUND")]
        MessageIDLoadpipelineNamenotfound = 0x3CB,
        [Obsolete("Deprecated in favour of \"LoadpipelineInvaliddesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LOADPIPELINE_INVALIDDESC")]
        MessageIDLoadpipelineInvaliddesc = 0x3CC,
        [Obsolete("Deprecated in favour of \"PipelinelibrarySerializeNotenoughmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PIPELINELIBRARY_SERIALIZE_NOTENOUGHMEMORY")]
        MessageIDPipelinelibrarySerializeNotenoughmemory = 0x3CD,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestatePSOutputRTOutputMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_RT_OUTPUT_MISMATCH")]
        MessageIDCreategraphicspipelinestatePSOutputRTOutputMismatch = 0x3CE,
        [Obsolete("Deprecated in favour of \"SeteventonmultiplefencecompletionInvalidflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETEVENTONMULTIPLEFENCECOMPLETION_INVALIDFLAGS")]
        MessageIDSeteventonmultiplefencecompletionInvalidflags = 0x3CF,
        [Obsolete("Deprecated in favour of \"CreateQueueVideoNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateQueueVideoNotSupported = 0x3D0,
        [Obsolete("Deprecated in favour of \"CreateCommandAllocatorVideoNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_ALLOCATOR_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateCommandAllocatorVideoNotSupported = 0x3D1,
        [Obsolete("Deprecated in favour of \"CreatequeryHeapVideoDecodeStatisticsNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_VIDEO_DECODE_STATISTICS_NOT_SUPPORTED")]
        MessageIDCreatequeryHeapVideoDecodeStatisticsNotSupported = 0x3D2,
        [Obsolete("Deprecated in favour of \"CreateVideodecodecommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDLIST")]
        MessageIDCreateVideodecodecommandlist = 0x3D3,
        [Obsolete("Deprecated in favour of \"CreateVideodecoder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODER")]
        MessageIDCreateVideodecoder = 0x3D4,
        [Obsolete("Deprecated in favour of \"CreateVideodecodestream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODESTREAM")]
        MessageIDCreateVideodecodestream = 0x3D5,
        [Obsolete("Deprecated in favour of \"LiveVideodecodecommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDLIST")]
        MessageIDLiveVideodecodecommandlist = 0x3D6,
        [Obsolete("Deprecated in favour of \"LiveVideodecoder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODER")]
        MessageIDLiveVideodecoder = 0x3D7,
        [Obsolete("Deprecated in favour of \"LiveVideodecodestream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODESTREAM")]
        MessageIDLiveVideodecodestream = 0x3D8,
        [Obsolete("Deprecated in favour of \"DestroyVideodecodecommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDLIST")]
        MessageIDDestroyVideodecodecommandlist = 0x3D9,
        [Obsolete("Deprecated in favour of \"DestroyVideodecoder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODER")]
        MessageIDDestroyVideodecoder = 0x3DA,
        [Obsolete("Deprecated in favour of \"DestroyVideodecodestream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODESTREAM")]
        MessageIDDestroyVideodecodestream = 0x3DB,
        [Obsolete("Deprecated in favour of \"DecodeFrameInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DECODE_FRAME_INVALID_PARAMETERS")]
        MessageIDDecodeFrameInvalidParameters = 0x3DC,
        [Obsolete("Deprecated in favour of \"DeprecatedApi\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPRECATED_API")]
        MessageIDDeprecatedApi = 0x3DD,
        [Obsolete("Deprecated in favour of \"ResourceBarrierMismatchingCommandListType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_COMMAND_LIST_TYPE")]
        MessageIDResourceBarrierMismatchingCommandListType = 0x3DE,
        [Obsolete("Deprecated in favour of \"CommandListDescriptorTableNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DESCRIPTOR_TABLE_NOT_SET")]
        MessageIDCommandListDescriptorTableNotSet = 0x3DF,
        [Obsolete("Deprecated in favour of \"CommandListRootConstantBufferViewNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_CONSTANT_BUFFER_VIEW_NOT_SET")]
        MessageIDCommandListRootConstantBufferViewNotSet = 0x3E0,
        [Obsolete("Deprecated in favour of \"CommandListRootShaderResourceViewNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_SHADER_RESOURCE_VIEW_NOT_SET")]
        MessageIDCommandListRootShaderResourceViewNotSet = 0x3E1,
        [Obsolete("Deprecated in favour of \"CommandListRootUnorderedAccessViewNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_UNORDERED_ACCESS_VIEW_NOT_SET")]
        MessageIDCommandListRootUnorderedAccessViewNotSet = 0x3E2,
        [Obsolete("Deprecated in favour of \"DiscardInvalidSubresourceRange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_INVALID_SUBRESOURCE_RANGE")]
        MessageIDDiscardInvalidSubresourceRange = 0x3E3,
        [Obsolete("Deprecated in favour of \"DiscardOneSubresourceForMipsWithRects\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_ONE_SUBRESOURCE_FOR_MIPS_WITH_RECTS")]
        MessageIDDiscardOneSubresourceForMipsWithRects = 0x3E4,
        [Obsolete("Deprecated in favour of \"DiscardNoRectsForNonTexture2D\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_NO_RECTS_FOR_NON_TEXTURE2D")]
        MessageIDDiscardNoRectsForNonTexture2D = 0x3E5,
        [Obsolete("Deprecated in favour of \"CopyOnSameSubresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_ON_SAME_SUBRESOURCE")]
        MessageIDCopyOnSameSubresource = 0x3E6,
        [Obsolete("Deprecated in favour of \"SetresidencypriorityInvalidPageable\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PAGEABLE")]
        MessageIDSetresidencypriorityInvalidPageable = 0x3E7,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UNSUPPORTED")]
        MessageIDGpuBasedValidationUnsupported = 0x3E8,
        [Obsolete("Deprecated in favour of \"StaticDescriptorInvalidDescriptorChange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_STATIC_DESCRIPTOR_INVALID_DESCRIPTOR_CHANGE")]
        MessageIDStaticDescriptorInvalidDescriptorChange = 0x3E9,
        [Obsolete("Deprecated in favour of \"DataStaticDescriptorInvalidDataChange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DATA_STATIC_DESCRIPTOR_INVALID_DATA_CHANGE")]
        MessageIDDataStaticDescriptorInvalidDataChange = 0x3EA,
        [Obsolete("Deprecated in favour of \"DataStaticWhileSetATExecuteDescriptorInvalidDataChange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DATA_STATIC_WHILE_SET_AT_EXECUTE_DESCRIPTOR_INVALID_DATA_CHANGE")]
        MessageIDDataStaticWhileSetATExecuteDescriptorInvalidDataChange = 0x3EB,
        [Obsolete("Deprecated in favour of \"ExecuteBundleStaticDescriptorDataStaticNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_STATIC_DESCRIPTOR_DATA_STATIC_NOT_SET")]
        MessageIDExecuteBundleStaticDescriptorDataStaticNotSet = 0x3EC,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationResourceAccessOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_ACCESS_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationResourceAccessOutOfBounds = 0x3ED,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationSamplerModeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SAMPLER_MODE_MISMATCH")]
        MessageIDGpuBasedValidationSamplerModeMismatch = 0x3EE,
        [Obsolete("Deprecated in favour of \"CreateFenceInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_FENCE_INVALID_FLAGS")]
        MessageIDCreateFenceInvalidFlags = 0x3EF,
        [Obsolete("Deprecated in favour of \"ResourceBarrierDuplicateSubresourceTransitions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_DUPLICATE_SUBRESOURCE_TRANSITIONS")]
        MessageIDResourceBarrierDuplicateSubresourceTransitions = 0x3F0,
        [Obsolete("Deprecated in favour of \"SetresidencypriorityInvalidPriority\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PRIORITY")]
        MessageIDSetresidencypriorityInvalidPriority = 0x3F1,
        [Obsolete("Deprecated in favour of \"CreateDescriptorHeapLargeNumDescriptors\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_LARGE_NUM_DESCRIPTORS")]
        MessageIDCreateDescriptorHeapLargeNumDescriptors = 0x3F5,
        [Obsolete("Deprecated in favour of \"BeginEvent\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_EVENT")]
        MessageIDBeginEvent = 0x3F6,
        [Obsolete("Deprecated in favour of \"EndEvent\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_END_EVENT")]
        MessageIDEndEvent = 0x3F7,
        [Obsolete("Deprecated in favour of \"CreatedeviceDebugLayerStartupOptions\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_DEBUG_LAYER_STARTUP_OPTIONS")]
        MessageIDCreatedeviceDebugLayerStartupOptions = 0x3F8,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateDepthboundstestUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_DEPTHBOUNDSTEST_UNSUPPORTED")]
        MessageIDCreatedepthstencilstateDepthboundstestUnsupported = 0x3F9,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateDuplicateSubobject\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_DUPLICATE_SUBOBJECT")]
        MessageIDCreatepipelinestateDuplicateSubobject = 0x3FA,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateUnknownSubobject\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_UNKNOWN_SUBOBJECT")]
        MessageIDCreatepipelinestateUnknownSubobject = 0x3FB,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateZeroSizeStream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_ZERO_SIZE_STREAM")]
        MessageIDCreatepipelinestateZeroSizeStream = 0x3FC,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateInvalidStream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_STREAM")]
        MessageIDCreatepipelinestateInvalidStream = 0x3FD,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateCannotDeduceType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CANNOT_DEDUCE_TYPE")]
        MessageIDCreatepipelinestateCannotDeduceType = 0x3FE,
        [Obsolete("Deprecated in favour of \"CommandListStaticDescriptorResourceDimensionMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_RESOURCE_DIMENSION_MISMATCH")]
        MessageIDCommandListStaticDescriptorResourceDimensionMismatch = 0x3FF,
        [Obsolete("Deprecated in favour of \"CreateCommandQueueInsufficientPrivilegeForGlobalRealtime\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_PRIVILEGE_FOR_GLOBAL_REALTIME")]
        MessageIDCreateCommandQueueInsufficientPrivilegeForGlobalRealtime = 0x400,
        [Obsolete("Deprecated in favour of \"CreateCommandQueueInsufficientHardwareSupportForGlobalRealtime\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_HARDWARE_SUPPORT_FOR_GLOBAL_REALTIME")]
        MessageIDCreateCommandQueueInsufficientHardwareSupportForGlobalRealtime = 0x401,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidArchitecture\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_ARCHITECTURE")]
        MessageIDAtomiccopybufferInvalidArchitecture = 0x402,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferNullDst\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DST")]
        MessageIDAtomiccopybufferNullDst = 0x403,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidDstResourceDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE_DIMENSION")]
        MessageIDAtomiccopybufferInvalidDstResourceDimension = 0x404,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferDstRangeOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DST_RANGE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferDstRangeOutOfBounds = 0x405,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferNullSrc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_SRC")]
        MessageIDAtomiccopybufferNullSrc = 0x406,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidSrcResourceDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE_DIMENSION")]
        MessageIDAtomiccopybufferInvalidSrcResourceDimension = 0x407,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferSrcRangeOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_SRC_RANGE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferSrcRangeOutOfBounds = 0x408,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidOffsetAlignment\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_OFFSET_ALIGNMENT")]
        MessageIDAtomiccopybufferInvalidOffsetAlignment = 0x409,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferNullDependentResources\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_RESOURCES")]
        MessageIDAtomiccopybufferNullDependentResources = 0x40A,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferNullDependentSubresourceRanges\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_SUBRESOURCE_RANGES")]
        MessageIDAtomiccopybufferNullDependentSubresourceRanges = 0x40B,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidDependentResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_RESOURCE")]
        MessageIDAtomiccopybufferInvalidDependentResource = 0x40C,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidDependentSubresourceRange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_SUBRESOURCE_RANGE")]
        MessageIDAtomiccopybufferInvalidDependentSubresourceRange = 0x40D,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferDependentSubresourceOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_SUBRESOURCE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferDependentSubresourceOutOfBounds = 0x40E,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferDependentRangeOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_RANGE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferDependentRangeOutOfBounds = 0x40F,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferZeroDependencies\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_ZERO_DEPENDENCIES")]
        MessageIDAtomiccopybufferZeroDependencies = 0x410,
        [Obsolete("Deprecated in favour of \"DeviceCreateSharedHandleInvalidarg\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATE_SHARED_HANDLE_INVALIDARG")]
        MessageIDDeviceCreateSharedHandleInvalidarg = 0x411,
        [Obsolete("Deprecated in favour of \"DescriptorHandleWithInvalidResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESCRIPTOR_HANDLE_WITH_INVALID_RESOURCE")]
        MessageIDDescriptorHandleWithInvalidResource = 0x412,
        [Obsolete("Deprecated in favour of \"SetdepthboundsInvalidargs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETDEPTHBOUNDS_INVALIDARGS")]
        MessageIDSetdepthboundsInvalidargs = 0x413,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationResourceStateImprecise\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_STATE_IMPRECISE")]
        MessageIDGpuBasedValidationResourceStateImprecise = 0x414,
        [Obsolete("Deprecated in favour of \"CommandListPipelineStateNotSet\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_PIPELINE_STATE_NOT_SET")]
        MessageIDCommandListPipelineStateNotSet = 0x415,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateShaderModelMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_MODEL_MISMATCH")]
        MessageIDCreategraphicspipelinestateShaderModelMismatch = 0x416,
        [Obsolete("Deprecated in favour of \"ObjectAccessedWhileStillInUse\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_ACCESSED_WHILE_STILL_IN_USE")]
        MessageIDObjectAccessedWhileStillInUse = 0x417,
        [Obsolete("Deprecated in favour of \"ProgrammableMsaaUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PROGRAMMABLE_MSAA_UNSUPPORTED")]
        MessageIDProgrammableMsaaUnsupported = 0x418,
        [Obsolete("Deprecated in favour of \"SetsamplepositionsInvalidargs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETSAMPLEPOSITIONS_INVALIDARGS")]
        MessageIDSetsamplepositionsInvalidargs = 0x419,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceregionInvalidRect\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCEREGION_INVALID_RECT")]
        MessageIDResolvesubresourceregionInvalidRect = 0x41A,
        [Obsolete("Deprecated in favour of \"CreateVideodecodecommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDQUEUE")]
        MessageIDCreateVideodecodecommandqueue = 0x41B,
        [Obsolete("Deprecated in favour of \"CreateVideoprocesscommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDLIST")]
        MessageIDCreateVideoprocesscommandlist = 0x41C,
        [Obsolete("Deprecated in favour of \"CreateVideoprocesscommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDQUEUE")]
        MessageIDCreateVideoprocesscommandqueue = 0x41D,
        [Obsolete("Deprecated in favour of \"LiveVideodecodecommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDQUEUE")]
        MessageIDLiveVideodecodecommandqueue = 0x41E,
        [Obsolete("Deprecated in favour of \"LiveVideoprocesscommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDLIST")]
        MessageIDLiveVideoprocesscommandlist = 0x41F,
        [Obsolete("Deprecated in favour of \"LiveVideoprocesscommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDQUEUE")]
        MessageIDLiveVideoprocesscommandqueue = 0x420,
        [Obsolete("Deprecated in favour of \"DestroyVideodecodecommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDQUEUE")]
        MessageIDDestroyVideodecodecommandqueue = 0x421,
        [Obsolete("Deprecated in favour of \"DestroyVideoprocesscommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDLIST")]
        MessageIDDestroyVideoprocesscommandlist = 0x422,
        [Obsolete("Deprecated in favour of \"DestroyVideoprocesscommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDQUEUE")]
        MessageIDDestroyVideoprocesscommandqueue = 0x423,
        [Obsolete("Deprecated in favour of \"CreateVideoprocessor\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSOR")]
        MessageIDCreateVideoprocessor = 0x424,
        [Obsolete("Deprecated in favour of \"CreateVideoprocessstream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSSTREAM")]
        MessageIDCreateVideoprocessstream = 0x425,
        [Obsolete("Deprecated in favour of \"LiveVideoprocessor\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSOR")]
        MessageIDLiveVideoprocessor = 0x426,
        [Obsolete("Deprecated in favour of \"LiveVideoprocessstream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSSTREAM")]
        MessageIDLiveVideoprocessstream = 0x427,
        [Obsolete("Deprecated in favour of \"DestroyVideoprocessor\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSOR")]
        MessageIDDestroyVideoprocessor = 0x428,
        [Obsolete("Deprecated in favour of \"DestroyVideoprocessstream\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSSTREAM")]
        MessageIDDestroyVideoprocessstream = 0x429,
        [Obsolete("Deprecated in favour of \"ProcessFrameInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PROCESS_FRAME_INVALID_PARAMETERS")]
        MessageIDProcessFrameInvalidParameters = 0x42A,
        [Obsolete("Deprecated in favour of \"CopyInvalidlayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_INVALIDLAYOUT")]
        MessageIDCopyInvalidlayout = 0x42B,
        [Obsolete("Deprecated in favour of \"CreateCryptoSession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION")]
        MessageIDCreateCryptoSession = 0x42C,
        [Obsolete("Deprecated in favour of \"CreateCryptoSessionPolicy\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION_POLICY")]
        MessageIDCreateCryptoSessionPolicy = 0x42D,
        [Obsolete("Deprecated in favour of \"CreateProtectedResourceSession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION")]
        MessageIDCreateProtectedResourceSession = 0x42E,
        [Obsolete("Deprecated in favour of \"LiveCryptoSession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION")]
        MessageIDLiveCryptoSession = 0x42F,
        [Obsolete("Deprecated in favour of \"LiveCryptoSessionPolicy\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION_POLICY")]
        MessageIDLiveCryptoSessionPolicy = 0x430,
        [Obsolete("Deprecated in favour of \"LiveProtectedResourceSession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PROTECTED_RESOURCE_SESSION")]
        MessageIDLiveProtectedResourceSession = 0x431,
        [Obsolete("Deprecated in favour of \"DestroyCryptoSession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION")]
        MessageIDDestroyCryptoSession = 0x432,
        [Obsolete("Deprecated in favour of \"DestroyCryptoSessionPolicy\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION_POLICY")]
        MessageIDDestroyCryptoSessionPolicy = 0x433,
        [Obsolete("Deprecated in favour of \"DestroyProtectedResourceSession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PROTECTED_RESOURCE_SESSION")]
        MessageIDDestroyProtectedResourceSession = 0x434,
        [Obsolete("Deprecated in favour of \"ProtectedResourceSessionUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PROTECTED_RESOURCE_SESSION_UNSUPPORTED")]
        MessageIDProtectedResourceSessionUnsupported = 0x435,
        [Obsolete("Deprecated in favour of \"FenceInvalidoperation\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_FENCE_INVALIDOPERATION")]
        MessageIDFenceInvalidoperation = 0x436,
        [Obsolete("Deprecated in favour of \"CreatequeryHeapCopyQueueTimestampsNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_COPY_QUEUE_TIMESTAMPS_NOT_SUPPORTED")]
        MessageIDCreatequeryHeapCopyQueueTimestampsNotSupported = 0x437,
        [Obsolete("Deprecated in favour of \"SamplepositionsMismatchDeferred\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_DEFERRED")]
        MessageIDSamplepositionsMismatchDeferred = 0x438,
        [Obsolete("Deprecated in favour of \"SamplepositionsMismatchRecordtimeAssumedfromfirstuse\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMFIRSTUSE")]
        MessageIDSamplepositionsMismatchRecordtimeAssumedfromfirstuse = 0x439,
        [Obsolete("Deprecated in favour of \"SamplepositionsMismatchRecordtimeAssumedfromclear\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMCLEAR")]
        MessageIDSamplepositionsMismatchRecordtimeAssumedfromclear = 0x43A,
        [Obsolete("Deprecated in favour of \"CreateVideodecoderheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODERHEAP")]
        MessageIDCreateVideodecoderheap = 0x43B,
        [Obsolete("Deprecated in favour of \"LiveVideodecoderheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODERHEAP")]
        MessageIDLiveVideodecoderheap = 0x43C,
        [Obsolete("Deprecated in favour of \"DestroyVideodecoderheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODERHEAP")]
        MessageIDDestroyVideodecoderheap = 0x43D,
        [Obsolete("Deprecated in favour of \"OpenexistingheapInvalidargReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDARG_RETURN")]
        MessageIDOpenexistingheapInvalidargReturn = 0x43E,
        [Obsolete("Deprecated in favour of \"OpenexistingheapOutofmemoryReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_OUTOFMEMORY_RETURN")]
        MessageIDOpenexistingheapOutofmemoryReturn = 0x43F,
        [Obsolete("Deprecated in favour of \"OpenexistingheapInvalidaddress\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDADDRESS")]
        MessageIDOpenexistingheapInvalidaddress = 0x440,
        [Obsolete("Deprecated in favour of \"OpenexistingheapInvalidhandle\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDHANDLE")]
        MessageIDOpenexistingheapInvalidhandle = 0x441,
        [Obsolete("Deprecated in favour of \"WritebufferimmediateInvalidDest\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_DEST")]
        MessageIDWritebufferimmediateInvalidDest = 0x442,
        [Obsolete("Deprecated in favour of \"WritebufferimmediateInvalidMode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_MODE")]
        MessageIDWritebufferimmediateInvalidMode = 0x443,
        [Obsolete("Deprecated in favour of \"WritebufferimmediateInvalidAlignment\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_ALIGNMENT")]
        MessageIDWritebufferimmediateInvalidAlignment = 0x444,
        [Obsolete("Deprecated in favour of \"WritebufferimmediateNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_NOT_SUPPORTED")]
        MessageIDWritebufferimmediateNotSupported = 0x445,
        [Obsolete("Deprecated in favour of \"SetviewinstancemaskInvalidargs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETVIEWINSTANCEMASK_INVALIDARGS")]
        MessageIDSetviewinstancemaskInvalidargs = 0x446,
        [Obsolete("Deprecated in favour of \"ViewInstancingUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIEW_INSTANCING_UNSUPPORTED")]
        MessageIDViewInstancingUnsupported = 0x447,
        [Obsolete("Deprecated in favour of \"ViewInstancingInvalidargs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIEW_INSTANCING_INVALIDARGS")]
        MessageIDViewInstancingInvalidargs = 0x448,
        [Obsolete("Deprecated in favour of \"CopytextureregionMismatchDecodeReferenceOnlyFlag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_DECODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopytextureregionMismatchDecodeReferenceOnlyFlag = 0x449,
        [Obsolete("Deprecated in favour of \"CopyresourceMismatchDecodeReferenceOnlyFlag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_DECODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopyresourceMismatchDecodeReferenceOnlyFlag = 0x44A,
        [Obsolete("Deprecated in favour of \"CreateVideoDecodeHeapCapsFailure\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_FAILURE")]
        MessageIDCreateVideoDecodeHeapCapsFailure = 0x44B,
        [Obsolete("Deprecated in favour of \"CreateVideoDecodeHeapCapsUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_UNSUPPORTED")]
        MessageIDCreateVideoDecodeHeapCapsUnsupported = 0x44C,
        [Obsolete("Deprecated in favour of \"VideoDecodeSupportInvalidInput\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_INVALID_INPUT")]
        MessageIDVideoDecodeSupportInvalidInput = 0x44D,
        [Obsolete("Deprecated in favour of \"CreateVideoDecoderUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODER_UNSUPPORTED")]
        MessageIDCreateVideoDecoderUnsupported = 0x44E,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateMetadataError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_METADATA_ERROR")]
        MessageIDCreategraphicspipelinestateMetadataError = 0x44F,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateViewInstancingVertexSizeExceeded\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VIEW_INSTANCING_VERTEX_SIZE_EXCEEDED")]
        MessageIDCreategraphicspipelinestateViewInstancingVertexSizeExceeded = 0x450,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateRuntimeInternalError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RUNTIME_INTERNAL_ERROR")]
        MessageIDCreategraphicspipelinestateRuntimeInternalError = 0x451,
        [Obsolete("Deprecated in favour of \"NoVideoApiSupport\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_VIDEO_API_SUPPORT")]
        MessageIDNoVideoApiSupport = 0x452,
        [Obsolete("Deprecated in favour of \"VideoProcessSupportInvalidInput\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_INVALID_INPUT")]
        MessageIDVideoProcessSupportInvalidInput = 0x453,
        [Obsolete("Deprecated in favour of \"CreateVideoProcessorCapsFailure\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_PROCESSOR_CAPS_FAILURE")]
        MessageIDCreateVideoProcessorCapsFailure = 0x454,
        [Obsolete("Deprecated in favour of \"VideoProcessSupportUnsupportedFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_UNSUPPORTED_FORMAT")]
        MessageIDVideoProcessSupportUnsupportedFormat = 0x455,
        [Obsolete("Deprecated in favour of \"VideoDecodeFrameInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_FRAME_INVALID_ARGUMENT")]
        MessageIDVideoDecodeFrameInvalidArgument = 0x456,
        [Obsolete("Deprecated in favour of \"EnqueueMakeResidentInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ENQUEUE_MAKE_RESIDENT_INVALID_FLAGS")]
        MessageIDEnqueueMakeResidentInvalidFlags = 0x457,
        [Obsolete("Deprecated in favour of \"OpenexistingheapUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_UNSUPPORTED")]
        MessageIDOpenexistingheapUnsupported = 0x458,
        [Obsolete("Deprecated in favour of \"VideoProcessFramesInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_FRAMES_INVALID_ARGUMENT")]
        MessageIDVideoProcessFramesInvalidArgument = 0x459,
        [Obsolete("Deprecated in favour of \"VideoDecodeSupportUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_UNSUPPORTED")]
        MessageIDVideoDecodeSupportUnsupported = 0x45A,
        [Obsolete("Deprecated in favour of \"CreateCommandrecorder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDRECORDER")]
        MessageIDCreateCommandrecorder = 0x45B,
        [Obsolete("Deprecated in favour of \"LiveCommandrecorder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDRECORDER")]
        MessageIDLiveCommandrecorder = 0x45C,
        [Obsolete("Deprecated in favour of \"DestroyCommandrecorder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDRECORDER")]
        MessageIDDestroyCommandrecorder = 0x45D,
        [Obsolete("Deprecated in favour of \"CreateCommandRecorderVideoNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateCommandRecorderVideoNotSupported = 0x45E,
        [Obsolete("Deprecated in favour of \"CreateCommandRecorderInvalidSupportFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_SUPPORT_FLAGS")]
        MessageIDCreateCommandRecorderInvalidSupportFlags = 0x45F,
        [Obsolete("Deprecated in favour of \"CreateCommandRecorderInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_FLAGS")]
        MessageIDCreateCommandRecorderInvalidFlags = 0x460,
        [Obsolete("Deprecated in favour of \"CreateCommandRecorderMoreRecordersThanLogicalProcessors\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_MORE_RECORDERS_THAN_LOGICAL_PROCESSORS")]
        MessageIDCreateCommandRecorderMoreRecordersThanLogicalProcessors = 0x461,
        [Obsolete("Deprecated in favour of \"CreateCommandpool\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDPOOL")]
        MessageIDCreateCommandpool = 0x462,
        [Obsolete("Deprecated in favour of \"LiveCommandpool\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDPOOL")]
        MessageIDLiveCommandpool = 0x463,
        [Obsolete("Deprecated in favour of \"DestroyCommandpool\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDPOOL")]
        MessageIDDestroyCommandpool = 0x464,
        [Obsolete("Deprecated in favour of \"CreateCommandPoolInvalidFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_POOL_INVALID_FLAGS")]
        MessageIDCreateCommandPoolInvalidFlags = 0x465,
        [Obsolete("Deprecated in favour of \"CreateCommandListVideoNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateCommandListVideoNotSupported = 0x466,
        [Obsolete("Deprecated in favour of \"CommandRecorderSupportFlagsMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_SUPPORT_FLAGS_MISMATCH")]
        MessageIDCommandRecorderSupportFlagsMismatch = 0x467,
        [Obsolete("Deprecated in favour of \"CommandRecorderContention\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_CONTENTION")]
        MessageIDCommandRecorderContention = 0x468,
        [Obsolete("Deprecated in favour of \"CommandRecorderUsageWithCreatecommandlistCommandList\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_USAGE_WITH_CREATECOMMANDLIST_COMMAND_LIST")]
        MessageIDCommandRecorderUsageWithCreatecommandlistCommandList = 0x469,
        [Obsolete("Deprecated in favour of \"CommandAllocatorUsageWithCreatecommandlist1CommandList\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_USAGE_WITH_CREATECOMMANDLIST1_COMMAND_LIST")]
        MessageIDCommandAllocatorUsageWithCreatecommandlist1CommandList = 0x46A,
        [Obsolete("Deprecated in favour of \"CannotExecuteEmptyCommandList\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_EXECUTE_EMPTY_COMMAND_LIST")]
        MessageIDCannotExecuteEmptyCommandList = 0x46B,
        [Obsolete("Deprecated in favour of \"CannotResetCommandPoolWithOpenCommandLists\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_RESET_COMMAND_POOL_WITH_OPEN_COMMAND_LISTS")]
        MessageIDCannotResetCommandPoolWithOpenCommandLists = 0x46C,
        [Obsolete("Deprecated in favour of \"CannotUseCommandRecorderWithoutCurrentTarget\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_USE_COMMAND_RECORDER_WITHOUT_CURRENT_TARGET")]
        MessageIDCannotUseCommandRecorderWithoutCurrentTarget = 0x46D,
        [Obsolete("Deprecated in favour of \"CannotChangeCommandRecorderTargetWhileRecording\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_CHANGE_COMMAND_RECORDER_TARGET_WHILE_RECORDING")]
        MessageIDCannotChangeCommandRecorderTargetWhileRecording = 0x46E,
        [Obsolete("Deprecated in favour of \"CommandPoolSync\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_POOL_SYNC")]
        MessageIDCommandPoolSync = 0x46F,
        [Obsolete("Deprecated in favour of \"EvictUnderflow\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EVICT_UNDERFLOW")]
        MessageIDEvictUnderflow = 0x470,
        [Obsolete("Deprecated in favour of \"CreateMetaCommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_META_COMMAND")]
        MessageIDCreateMetaCommand = 0x471,
        [Obsolete("Deprecated in favour of \"LiveMetaCommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_META_COMMAND")]
        MessageIDLiveMetaCommand = 0x472,
        [Obsolete("Deprecated in favour of \"DestroyMetaCommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_META_COMMAND")]
        MessageIDDestroyMetaCommand = 0x473,
        [Obsolete("Deprecated in favour of \"CopybufferregionInvalidDstResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_DST_RESOURCE")]
        MessageIDCopybufferregionInvalidDstResource = 0x474,
        [Obsolete("Deprecated in favour of \"CopybufferregionInvalidSrcResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_SRC_RESOURCE")]
        MessageIDCopybufferregionInvalidSrcResource = 0x475,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidDstResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE")]
        MessageIDAtomiccopybufferInvalidDstResource = 0x476,
        [Obsolete("Deprecated in favour of \"AtomiccopybufferInvalidSrcResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE")]
        MessageIDAtomiccopybufferInvalidSrcResource = 0x477,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferNullBuffer\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_BUFFER")]
        MessageIDCreateplacedresourceonbufferNullBuffer = 0x478,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferNullResourceDesc\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_RESOURCE_DESC")]
        MessageIDCreateplacedresourceonbufferNullResourceDesc = 0x479,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_UNSUPPORTED")]
        MessageIDCreateplacedresourceonbufferUnsupported = 0x47A,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferInvalidBufferDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_DIMENSION")]
        MessageIDCreateplacedresourceonbufferInvalidBufferDimension = 0x47B,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferInvalidBufferFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_FLAGS")]
        MessageIDCreateplacedresourceonbufferInvalidBufferFlags = 0x47C,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferInvalidBufferOffset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_OFFSET")]
        MessageIDCreateplacedresourceonbufferInvalidBufferOffset = 0x47D,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferInvalidResourceDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_DIMENSION")]
        MessageIDCreateplacedresourceonbufferInvalidResourceDimension = 0x47E,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferInvalidResourceFlags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_FLAGS")]
        MessageIDCreateplacedresourceonbufferInvalidResourceFlags = 0x47F,
        [Obsolete("Deprecated in favour of \"CreateplacedresourceonbufferOutofmemoryReturn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_OUTOFMEMORY_RETURN")]
        MessageIDCreateplacedresourceonbufferOutofmemoryReturn = 0x480,
        [Obsolete("Deprecated in favour of \"CannotCreateGraphicsAndVideoCommandRecorder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_CREATE_GRAPHICS_AND_VIDEO_COMMAND_RECORDER")]
        MessageIDCannotCreateGraphicsAndVideoCommandRecorder = 0x481,
        [Obsolete("Deprecated in favour of \"UpdatetilemappingsPossiblyMismatchingProperties\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_POSSIBLY_MISMATCHING_PROPERTIES")]
        MessageIDUpdatetilemappingsPossiblyMismatchingProperties = 0x482,
        [Obsolete("Deprecated in favour of \"CreateCommandListInvalidCommandListType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE")]
        MessageIDCreateCommandListInvalidCommandListType = 0x483,
        [Obsolete("Deprecated in favour of \"ClearunorderedaccessviewIncompatibleWithStructuredBuffers\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INCOMPATIBLE_WITH_STRUCTURED_BUFFERS")]
        MessageIDClearunorderedaccessviewIncompatibleWithStructuredBuffers = 0x484,
        [Obsolete("Deprecated in favour of \"ComputeOnlyDeviceOperationUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMPUTE_ONLY_DEVICE_OPERATION_UNSUPPORTED")]
        MessageIDComputeOnlyDeviceOperationUnsupported = 0x485,
        [Obsolete("Deprecated in favour of \"BuildRaytracingAccelerationStructureInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INVALID")]
        MessageIDBuildRaytracingAccelerationStructureInvalid = 0x486,
        [Obsolete("Deprecated in favour of \"EmitRaytracingAccelerationStructurePostbuildInfoInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_INVALID")]
        MessageIDEmitRaytracingAccelerationStructurePostbuildInfoInvalid = 0x487,
        [Obsolete("Deprecated in favour of \"CopyRaytracingAccelerationStructureInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_RAYTRACING_ACCELERATION_STRUCTURE_INVALID")]
        MessageIDCopyRaytracingAccelerationStructureInvalid = 0x488,
        [Obsolete("Deprecated in favour of \"DispatchRaysInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DISPATCH_RAYS_INVALID")]
        MessageIDDispatchRaysInvalid = 0x489,
        [Obsolete("Deprecated in favour of \"GetRaytracingAccelerationStructurePrebuildInfoInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO_INVALID")]
        MessageIDGetRaytracingAccelerationStructurePrebuildInfoInvalid = 0x48A,
        [Obsolete("Deprecated in favour of \"CreateLifetimetracker\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_LIFETIMETRACKER")]
        MessageIDCreateLifetimetracker = 0x48B,
        [Obsolete("Deprecated in favour of \"LiveLifetimetracker\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_LIFETIMETRACKER")]
        MessageIDLiveLifetimetracker = 0x48C,
        [Obsolete("Deprecated in favour of \"DestroyLifetimetracker\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_LIFETIMETRACKER")]
        MessageIDDestroyLifetimetracker = 0x48D,
        [Obsolete("Deprecated in favour of \"DestroyownedobjectObjectnotowned\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROYOWNEDOBJECT_OBJECTNOTOWNED")]
        MessageIDDestroyownedobjectObjectnotowned = 0x48E,
        [Obsolete("Deprecated in favour of \"CreateTrackedworkload\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_TRACKEDWORKLOAD")]
        MessageIDCreateTrackedworkload = 0x48F,
        [Obsolete("Deprecated in favour of \"LiveTrackedworkload\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_TRACKEDWORKLOAD")]
        MessageIDLiveTrackedworkload = 0x490,
        [Obsolete("Deprecated in favour of \"DestroyTrackedworkload\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD")]
        MessageIDDestroyTrackedworkload = 0x491,
        [Obsolete("Deprecated in favour of \"RenderPassError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_ERROR")]
        MessageIDRenderPassError = 0x492,
        [Obsolete("Deprecated in favour of \"MetaCommandIDInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_ID_INVALID")]
        MessageIDMetaCommandIDInvalid = 0x493,
        [Obsolete("Deprecated in favour of \"MetaCommandUnsupportedParams\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_UNSUPPORTED_PARAMS")]
        MessageIDMetaCommandUnsupportedParams = 0x494,
        [Obsolete("Deprecated in favour of \"MetaCommandFailedEnumeration\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_FAILED_ENUMERATION")]
        MessageIDMetaCommandFailedEnumeration = 0x495,
        [Obsolete("Deprecated in favour of \"MetaCommandParameterSizeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_PARAMETER_SIZE_MISMATCH")]
        MessageIDMetaCommandParameterSizeMismatch = 0x496,
        [Obsolete("Deprecated in favour of \"UninitializedMetaCommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNINITIALIZED_META_COMMAND")]
        MessageIDUninitializedMetaCommand = 0x497,
        [Obsolete("Deprecated in favour of \"MetaCommandInvalidGpuVirtualAddress\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_INVALID_GPU_VIRTUAL_ADDRESS")]
        MessageIDMetaCommandInvalidGpuVirtualAddress = 0x498,
        [Obsolete("Deprecated in favour of \"CreateVideoencodecommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDLIST")]
        MessageIDCreateVideoencodecommandlist = 0x499,
        [Obsolete("Deprecated in favour of \"LiveVideoencodecommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDLIST")]
        MessageIDLiveVideoencodecommandlist = 0x49A,
        [Obsolete("Deprecated in favour of \"DestroyVideoencodecommandlist\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDLIST")]
        MessageIDDestroyVideoencodecommandlist = 0x49B,
        [Obsolete("Deprecated in favour of \"CreateVideoencodecommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDQUEUE")]
        MessageIDCreateVideoencodecommandqueue = 0x49C,
        [Obsolete("Deprecated in favour of \"LiveVideoencodecommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDQUEUE")]
        MessageIDLiveVideoencodecommandqueue = 0x49D,
        [Obsolete("Deprecated in favour of \"DestroyVideoencodecommandqueue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDQUEUE")]
        MessageIDDestroyVideoencodecommandqueue = 0x49E,
        [Obsolete("Deprecated in favour of \"CreateVideomotionestimator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONESTIMATOR")]
        MessageIDCreateVideomotionestimator = 0x49F,
        [Obsolete("Deprecated in favour of \"LiveVideomotionestimator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONESTIMATOR")]
        MessageIDLiveVideomotionestimator = 0x4A0,
        [Obsolete("Deprecated in favour of \"DestroyVideomotionestimator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONESTIMATOR")]
        MessageIDDestroyVideomotionestimator = 0x4A1,
        [Obsolete("Deprecated in favour of \"CreateVideomotionvectorheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONVECTORHEAP")]
        MessageIDCreateVideomotionvectorheap = 0x4A2,
        [Obsolete("Deprecated in favour of \"LiveVideomotionvectorheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONVECTORHEAP")]
        MessageIDLiveVideomotionvectorheap = 0x4A3,
        [Obsolete("Deprecated in favour of \"DestroyVideomotionvectorheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONVECTORHEAP")]
        MessageIDDestroyVideomotionvectorheap = 0x4A4,
        [Obsolete("Deprecated in favour of \"MultipleTrackedWorkloads\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS")]
        MessageIDMultipleTrackedWorkloads = 0x4A5,
        [Obsolete("Deprecated in favour of \"MultipleTrackedWorkloadPairs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS")]
        MessageIDMultipleTrackedWorkloadPairs = 0x4A6,
        [Obsolete("Deprecated in favour of \"OutOfOrderTrackedWorkloadPair\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR")]
        MessageIDOutOfOrderTrackedWorkloadPair = 0x4A7,
        [Obsolete("Deprecated in favour of \"CannotAddTrackedWorkload\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD")]
        MessageIDCannotAddTrackedWorkload = 0x4A8,
        [Obsolete("Deprecated in favour of \"IncompleteTrackedWorkloadPair\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR")]
        MessageIDIncompleteTrackedWorkloadPair = 0x4A9,
        [Obsolete("Deprecated in favour of \"CreateStateObjectError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_STATE_OBJECT_ERROR")]
        MessageIDCreateStateObjectError = 0x4AA,
        [Obsolete("Deprecated in favour of \"GetShaderIdentifierError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_ERROR")]
        MessageIDGetShaderIdentifierError = 0x4AB,
        [Obsolete("Deprecated in favour of \"GetShaderStackSizeError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_STACK_SIZE_ERROR")]
        MessageIDGetShaderStackSizeError = 0x4AC,
        [Obsolete("Deprecated in favour of \"GetPipelineStackSizeError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_PIPELINE_STACK_SIZE_ERROR")]
        MessageIDGetPipelineStackSizeError = 0x4AD,
        [Obsolete("Deprecated in favour of \"SetPipelineStackSizeError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PIPELINE_STACK_SIZE_ERROR")]
        MessageIDSetPipelineStackSizeError = 0x4AE,
        [Obsolete("Deprecated in favour of \"GetShaderIdentifierSizeInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_SIZE_INVALID")]
        MessageIDGetShaderIdentifierSizeInvalid = 0x4AF,
        [Obsolete("Deprecated in favour of \"CheckDriverMatchingIdentifierInvalid\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_INVALID")]
        MessageIDCheckDriverMatchingIdentifierInvalid = 0x4B0,
        [Obsolete("Deprecated in favour of \"CheckDriverMatchingIdentifierDriverReportedIssue\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_DRIVER_REPORTED_ISSUE")]
        MessageIDCheckDriverMatchingIdentifierDriverReportedIssue = 0x4B1,
        [Obsolete("Deprecated in favour of \"RenderPassInvalidResourceBarrier\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_INVALID_RESOURCE_BARRIER")]
        MessageIDRenderPassInvalidResourceBarrier = 0x4B2,
        [Obsolete("Deprecated in favour of \"RenderPassDisallowedApiCalled\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_DISALLOWED_API_CALLED")]
        MessageIDRenderPassDisallowedApiCalled = 0x4B3,
        [Obsolete("Deprecated in favour of \"RenderPassCannotNestRenderPasses\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_NEST_RENDER_PASSES")]
        MessageIDRenderPassCannotNestRenderPasses = 0x4B4,
        [Obsolete("Deprecated in favour of \"RenderPassCannotEndWithoutBegin\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_END_WITHOUT_BEGIN")]
        MessageIDRenderPassCannotEndWithoutBegin = 0x4B5,
        [Obsolete("Deprecated in favour of \"RenderPassCannotCloseCommandList\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_CLOSE_COMMAND_LIST")]
        MessageIDRenderPassCannotCloseCommandList = 0x4B6,
        [Obsolete("Deprecated in favour of \"RenderPassGpuWorkWhileSuspended\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_GPU_WORK_WHILE_SUSPENDED")]
        MessageIDRenderPassGpuWorkWhileSuspended = 0x4B7,
        [Obsolete("Deprecated in favour of \"RenderPassMismatchingSuspendResume\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_SUSPEND_RESUME")]
        MessageIDRenderPassMismatchingSuspendResume = 0x4B8,
        [Obsolete("Deprecated in favour of \"RenderPassNoPriorSuspendWithinExecutecommandlists\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_NO_PRIOR_SUSPEND_WITHIN_EXECUTECOMMANDLISTS")]
        MessageIDRenderPassNoPriorSuspendWithinExecutecommandlists = 0x4B9,
        [Obsolete("Deprecated in favour of \"RenderPassNoSubsequentResumeWithinExecutecommandlists\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_NO_SUBSEQUENT_RESUME_WITHIN_EXECUTECOMMANDLISTS")]
        MessageIDRenderPassNoSubsequentResumeWithinExecutecommandlists = 0x4BA,
        [Obsolete("Deprecated in favour of \"TrackedWorkloadCommandQueueMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_TRACKED_WORKLOAD_COMMAND_QUEUE_MISMATCH")]
        MessageIDTrackedWorkloadCommandQueueMismatch = 0x4BB,
        [Obsolete("Deprecated in favour of \"TrackedWorkloadNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED")]
        MessageIDTrackedWorkloadNotSupported = 0x4BC,
        [Obsolete("Deprecated in favour of \"RenderPassMismatchingNoAccess\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_NO_ACCESS")]
        MessageIDRenderPassMismatchingNoAccess = 0x4BD,
        [Obsolete("Deprecated in favour of \"RenderPassUnsupportedResolve\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_UNSUPPORTED_RESOLVE")]
        MessageIDRenderPassUnsupportedResolve = 0x4BE,
        [Obsolete("Deprecated in favour of \"ClearunorderedaccessviewInvalidResourcePtr\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INVALID_RESOURCE_PTR")]
        MessageIDClearunorderedaccessviewInvalidResourcePtr = 0x4BF,
        [Obsolete("Deprecated in favour of \"Windows7FenceOutoforderSignal\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_SIGNAL")]
        MessageIDWindows7FenceOutoforderSignal = 0x4C0,
        [Obsolete("Deprecated in favour of \"Windows7FenceOutoforderWait\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_WAIT")]
        MessageIDWindows7FenceOutoforderWait = 0x4C1,
        [Obsolete("Deprecated in favour of \"VideoCreateMotionEstimatorInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_ESTIMATOR_INVALID_ARGUMENT")]
        MessageIDVideoCreateMotionEstimatorInvalidArgument = 0x4C2,
        [Obsolete("Deprecated in favour of \"VideoCreateMotionVectorHeapInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT")]
        MessageIDVideoCreateMotionVectorHeapInvalidArgument = 0x4C3,
        [Obsolete("Deprecated in favour of \"EstimateMotionInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ESTIMATE_MOTION_INVALID_ARGUMENT")]
        MessageIDEstimateMotionInvalidArgument = 0x4C4,
        [Obsolete("Deprecated in favour of \"ResolveMotionVectorHeapInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT")]
        MessageIDResolveMotionVectorHeapInvalidArgument = 0x4C5,
        [Obsolete("Deprecated in favour of \"GetgpuvirtualaddressInvalidHeapType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_HEAP_TYPE")]
        MessageIDGetgpuvirtualaddressInvalidHeapType = 0x4C6,
        [Obsolete("Deprecated in favour of \"SetBackgroundProcessingModeInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_BACKGROUND_PROCESSING_MODE_INVALID_ARGUMENT")]
        MessageIDSetBackgroundProcessingModeInvalidArgument = 0x4C7,
        [Obsolete("Deprecated in favour of \"CreateCommandListInvalidCommandListTypeForFeatureLevel\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE_FOR_FEATURE_LEVEL")]
        MessageIDCreateCommandListInvalidCommandListTypeForFeatureLevel = 0x4C8,
        [Obsolete("Deprecated in favour of \"CreateVideoextensioncommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOEXTENSIONCOMMAND")]
        MessageIDCreateVideoextensioncommand = 0x4C9,
        [Obsolete("Deprecated in favour of \"LiveVideoextensioncommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOEXTENSIONCOMMAND")]
        MessageIDLiveVideoextensioncommand = 0x4CA,
        [Obsolete("Deprecated in favour of \"DestroyVideoextensioncommand\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOEXTENSIONCOMMAND")]
        MessageIDDestroyVideoextensioncommand = 0x4CB,
        [Obsolete("Deprecated in favour of \"InvalidVideoExtensionCommandID\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_VIDEO_EXTENSION_COMMAND_ID")]
        MessageIDInvalidVideoExtensionCommandID = 0x4CC,
        [Obsolete("Deprecated in favour of \"VideoExtensionCommandInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_EXTENSION_COMMAND_INVALID_ARGUMENT")]
        MessageIDVideoExtensionCommandInvalidArgument = 0x4CD,
        [Obsolete("Deprecated in favour of \"CreateRootSignatureNotUniqueInDxilLibrary\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_UNIQUE_IN_DXIL_LIBRARY")]
        MessageIDCreateRootSignatureNotUniqueInDxilLibrary = 0x4CE,
        [Obsolete("Deprecated in favour of \"VariableShadingRateNotAllowedWithTir\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VARIABLE_SHADING_RATE_NOT_ALLOWED_WITH_TIR")]
        MessageIDVariableShadingRateNotAllowedWithTir = 0x4CF,
        [Obsolete("Deprecated in favour of \"GeometryShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GEOMETRY_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDGeometryShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4D0,
        [Obsolete("Deprecated in favour of \"RssetshadingRateInvalidShadingRate\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_SHADING_RATE")]
        MessageIDRssetshadingRateInvalidShadingRate = 0x4D1,
        [Obsolete("Deprecated in favour of \"RssetshadingRateShadingRateNotPermittedByCap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_SHADING_RATE_NOT_PERMITTED_BY_CAP")]
        MessageIDRssetshadingRateShadingRateNotPermittedByCap = 0x4D2,
        [Obsolete("Deprecated in favour of \"RssetshadingRateInvalidCombiner\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_COMBINER")]
        MessageIDRssetshadingRateInvalidCombiner = 0x4D3,
        [Obsolete("Deprecated in favour of \"RssetshadingrateimageRequiresTier2\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADINGRATEIMAGE_REQUIRES_TIER_2")]
        MessageIDRssetshadingrateimageRequiresTier2 = 0x4D4,
        [Obsolete("Deprecated in favour of \"RssetshadingrateRequiresTier1\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADINGRATE_REQUIRES_TIER_1")]
        MessageIDRssetshadingrateRequiresTier1 = 0x4D5,
        [Obsolete("Deprecated in favour of \"ShadingRateImageIncorrectFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_FORMAT")]
        MessageIDShadingRateImageIncorrectFormat = 0x4D6,
        [Obsolete("Deprecated in favour of \"ShadingRateImageIncorrectArraySize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_ARRAY_SIZE")]
        MessageIDShadingRateImageIncorrectArraySize = 0x4D7,
        [Obsolete("Deprecated in favour of \"ShadingRateImageIncorrectMipLevel\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_MIP_LEVEL")]
        MessageIDShadingRateImageIncorrectMipLevel = 0x4D8,
        [Obsolete("Deprecated in favour of \"ShadingRateImageIncorrectSampleCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_COUNT")]
        MessageIDShadingRateImageIncorrectSampleCount = 0x4D9,
        [Obsolete("Deprecated in favour of \"ShadingRateImageIncorrectSampleQuality\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_QUALITY")]
        MessageIDShadingRateImageIncorrectSampleQuality = 0x4DA,
        [Obsolete("Deprecated in favour of \"NonRetailShaderModelWontValidate\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NON_RETAIL_SHADER_MODEL_WONT_VALIDATE")]
        MessageIDNonRetailShaderModelWontValidate = 0x4DB,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateAsRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateAsRootSignatureMismatch = 0x4DC,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateMSRootSignatureMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateMSRootSignatureMismatch = 0x4DD,
        [Obsolete("Deprecated in favour of \"AddToStateObjectError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ADD_TO_STATE_OBJECT_ERROR")]
        MessageIDAddToStateObjectError = 0x4DE,
        [Obsolete("Deprecated in favour of \"CreateProtectedResourceSessionInvalidArgument\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION_INVALID_ARGUMENT")]
        MessageIDCreateProtectedResourceSessionInvalidArgument = 0x4DF,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateMSPsoDescMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_PSO_DESC_MISMATCH")]
        MessageIDCreategraphicspipelinestateMSPsoDescMismatch = 0x4E0,
        [Obsolete("Deprecated in favour of \"CreatepipelinestateMSIncompleteType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_MS_INCOMPLETE_TYPE")]
        MessageIDCreatepipelinestateMSIncompleteType = 0x4E1,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateAsNotMSMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_NOT_MS_MISMATCH")]
        MessageIDCreategraphicspipelinestateAsNotMSMismatch = 0x4E2,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateMSNotPSMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_NOT_PS_MISMATCH")]
        MessageIDCreategraphicspipelinestateMSNotPSMismatch = 0x4E3,
        [Obsolete("Deprecated in favour of \"NonzeroSamplerFeedbackMipRegionWithIncompatibleFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NONZERO_SAMPLER_FEEDBACK_MIP_REGION_WITH_INCOMPATIBLE_FORMAT")]
        MessageIDNonzeroSamplerFeedbackMipRegionWithIncompatibleFormat = 0x4E4,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateInputlayoutShaderMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_SHADER_MISMATCH")]
        MessageIDCreategraphicspipelinestateInputlayoutShaderMismatch = 0x4E5,
        [Obsolete("Deprecated in favour of \"EmptyDispatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EMPTY_DISPATCH")]
        MessageIDEmptyDispatch = 0x4E6,
        [Obsolete("Deprecated in favour of \"ResourceFormatRequiresSamplerFeedbackCapability\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_FORMAT_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY")]
        MessageIDResourceFormatRequiresSamplerFeedbackCapability = 0x4E7,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMapInvalidMipRegion\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_MIP_REGION")]
        MessageIDSamplerFeedbackMapInvalidMipRegion = 0x4E8,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMapInvalidDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_DIMENSION")]
        MessageIDSamplerFeedbackMapInvalidDimension = 0x4E9,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMapInvalidSampleCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_COUNT")]
        MessageIDSamplerFeedbackMapInvalidSampleCount = 0x4EA,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMapInvalidSampleQuality\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_QUALITY")]
        MessageIDSamplerFeedbackMapInvalidSampleQuality = 0x4EB,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMapInvalidLayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_LAYOUT")]
        MessageIDSamplerFeedbackMapInvalidLayout = 0x4EC,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMapRequiresUnorderedAccessFlag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_REQUIRES_UNORDERED_ACCESS_FLAG")]
        MessageIDSamplerFeedbackMapRequiresUnorderedAccessFlag = 0x4ED,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackCreateUavNullArguments\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_NULL_ARGUMENTS")]
        MessageIDSamplerFeedbackCreateUavNullArguments = 0x4EE,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackUavRequiresSamplerFeedbackCapability\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_UAV_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY")]
        MessageIDSamplerFeedbackUavRequiresSamplerFeedbackCapability = 0x4EF,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackCreateUavRequiresFeedbackMapFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_REQUIRES_FEEDBACK_MAP_FORMAT")]
        MessageIDSamplerFeedbackCreateUavRequiresFeedbackMapFormat = 0x4F0,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatemeshshaderInvalidshaderbytecode = 0x4F1,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTOFMEMORY")]
        MessageIDCreatemeshshaderOutofmemory = 0x4F2,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderwithstreamoutputInvalidshadertype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        MessageIDCreatemeshshaderwithstreamoutputInvalidshadertype = 0x4F3,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceSamplerFeedbackTranscodeInvalidFormat\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_INVALID_FORMAT")]
        MessageIDResolvesubresourceSamplerFeedbackTranscodeInvalidFormat = 0x4F4,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceSamplerFeedbackInvalidMipLevelCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_INVALID_MIP_LEVEL_COUNT")]
        MessageIDResolvesubresourceSamplerFeedbackInvalidMipLevelCount = 0x4F5,
        [Obsolete("Deprecated in favour of \"ResolvesubresourceSamplerFeedbackTranscodeArraySizeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_ARRAY_SIZE_MISMATCH")]
        MessageIDResolvesubresourceSamplerFeedbackTranscodeArraySizeMismatch = 0x4F6,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackCreateUavMismatchingTargetedResource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_MISMATCHING_TARGETED_RESOURCE")]
        MessageIDSamplerFeedbackCreateUavMismatchingTargetedResource = 0x4F7,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderOutputexceedsmaxsize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTPUTEXCEEDSMAXSIZE")]
        MessageIDCreatemeshshaderOutputexceedsmaxsize = 0x4F8,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderGroupsharedexceedsmaxsize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_GROUPSHAREDEXCEEDSMAXSIZE")]
        MessageIDCreatemeshshaderGroupsharedexceedsmaxsize = 0x4F9,
        [Obsolete("Deprecated in favour of \"VertexShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VERTEX_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDVertexShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4FA,
        [Obsolete("Deprecated in favour of \"MeshShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_MESH_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDMeshShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4FB,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderMismatchedasmspayloadsize\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_MISMATCHEDASMSPAYLOADSIZE")]
        MessageIDCreatemeshshaderMismatchedasmspayloadsize = 0x4FC,
        [Obsolete("Deprecated in favour of \"CreateRootSignatureUnboundedStaticDescriptors\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_UNBOUNDED_STATIC_DESCRIPTORS")]
        MessageIDCreateRootSignatureUnboundedStaticDescriptors = 0x4FD,
        [Obsolete("Deprecated in favour of \"CreateamplificationshaderInvalidshaderbytecode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreateamplificationshaderInvalidshaderbytecode = 0x4FE,
        [Obsolete("Deprecated in favour of \"CreateamplificationshaderOutofmemory\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_OUTOFMEMORY")]
        MessageIDCreateamplificationshaderOutofmemory = 0x4FF,
        [Obsolete("Deprecated in favour of \"CreateShadercachesession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SHADERCACHESESSION")]
        MessageIDCreateShadercachesession = 0x500,
        [Obsolete("Deprecated in favour of \"LiveShadercachesession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_SHADERCACHESESSION")]
        MessageIDLiveShadercachesession = 0x501,
        [Obsolete("Deprecated in favour of \"DestroyShadercachesession\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_SHADERCACHESESSION")]
        MessageIDDestroyShadercachesession = 0x502,
        [Obsolete("Deprecated in favour of \"CreateshadercachesessionInvalidargs\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_INVALIDARGS")]
        MessageIDCreateshadercachesessionInvalidargs = 0x503,
        [Obsolete("Deprecated in favour of \"CreateshadercachesessionDisabled\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_DISABLED")]
        MessageIDCreateshadercachesessionDisabled = 0x504,
        [Obsolete("Deprecated in favour of \"CreateshadercachesessionAlreadyopen\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_ALREADYOPEN")]
        MessageIDCreateshadercachesessionAlreadyopen = 0x505,
        [Obsolete("Deprecated in favour of \"ShadercachecontrolDevelopermode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_DEVELOPERMODE")]
        MessageIDShadercachecontrolDevelopermode = 0x506,
        [Obsolete("Deprecated in favour of \"ShadercachecontrolInvalidflags\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_INVALIDFLAGS")]
        MessageIDShadercachecontrolInvalidflags = 0x507,
        [Obsolete("Deprecated in favour of \"ShadercachecontrolStatealreadyset\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_STATEALREADYSET")]
        MessageIDShadercachecontrolStatealreadyset = 0x508,
        [Obsolete("Deprecated in favour of \"ShadercachecontrolIgnoredflag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_IGNOREDFLAG")]
        MessageIDShadercachecontrolIgnoredflag = 0x509,
        [Obsolete("Deprecated in favour of \"ShadercachesessionStorevalueAlreadypresent\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_ALREADYPRESENT")]
        MessageIDShadercachesessionStorevalueAlreadypresent = 0x50A,
        [Obsolete("Deprecated in favour of \"ShadercachesessionStorevalueHashcollision\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_HASHCOLLISION")]
        MessageIDShadercachesessionStorevalueHashcollision = 0x50B,
        [Obsolete("Deprecated in favour of \"ShadercachesessionStorevalueCachefull\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_CACHEFULL")]
        MessageIDShadercachesessionStorevalueCachefull = 0x50C,
        [Obsolete("Deprecated in favour of \"ShadercachesessionFindvalueNotfound\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_FINDVALUE_NOTFOUND")]
        MessageIDShadercachesessionFindvalueNotfound = 0x50D,
        [Obsolete("Deprecated in favour of \"ShadercachesessionCorrupt\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_CORRUPT")]
        MessageIDShadercachesessionCorrupt = 0x50E,
        [Obsolete("Deprecated in favour of \"ShadercachesessionDisabled\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_DISABLED")]
        MessageIDShadercachesessionDisabled = 0x50F,
        [Obsolete("Deprecated in favour of \"OversizedDispatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OVERSIZED_DISPATCH")]
        MessageIDOversizedDispatch = 0x510,
        [Obsolete("Deprecated in favour of \"CreateVideoencoder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODER")]
        MessageIDCreateVideoencoder = 0x511,
        [Obsolete("Deprecated in favour of \"LiveVideoencoder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODER")]
        MessageIDLiveVideoencoder = 0x512,
        [Obsolete("Deprecated in favour of \"DestroyVideoencoder\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODER")]
        MessageIDDestroyVideoencoder = 0x513,
        [Obsolete("Deprecated in favour of \"CreateVideoencoderheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODERHEAP")]
        MessageIDCreateVideoencoderheap = 0x514,
        [Obsolete("Deprecated in favour of \"LiveVideoencoderheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODERHEAP")]
        MessageIDLiveVideoencoderheap = 0x515,
        [Obsolete("Deprecated in favour of \"DestroyVideoencoderheap\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODERHEAP")]
        MessageIDDestroyVideoencoderheap = 0x516,
        [Obsolete("Deprecated in favour of \"CopytextureregionMismatchEncodeReferenceOnlyFlag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopytextureregionMismatchEncodeReferenceOnlyFlag = 0x517,
        [Obsolete("Deprecated in favour of \"CopyresourceMismatchEncodeReferenceOnlyFlag\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopyresourceMismatchEncodeReferenceOnlyFlag = 0x518,
        [Obsolete("Deprecated in favour of \"EncodeFrameInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ENCODE_FRAME_INVALID_PARAMETERS")]
        MessageIDEncodeFrameInvalidParameters = 0x519,
        [Obsolete("Deprecated in favour of \"EncodeFrameUnsupportedParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ENCODE_FRAME_UNSUPPORTED_PARAMETERS")]
        MessageIDEncodeFrameUnsupportedParameters = 0x51A,
        [Obsolete("Deprecated in favour of \"ResolveEncoderOutputMetadataInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_INVALID_PARAMETERS")]
        MessageIDResolveEncoderOutputMetadataInvalidParameters = 0x51B,
        [Obsolete("Deprecated in favour of \"ResolveEncoderOutputMetadataUnsupportedParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_UNSUPPORTED_PARAMETERS")]
        MessageIDResolveEncoderOutputMetadataUnsupportedParameters = 0x51C,
        [Obsolete("Deprecated in favour of \"CreateVideoEncoderInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_INVALID_PARAMETERS")]
        MessageIDCreateVideoEncoderInvalidParameters = 0x51D,
        [Obsolete("Deprecated in favour of \"CreateVideoEncoderUnsupportedParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_UNSUPPORTED_PARAMETERS")]
        MessageIDCreateVideoEncoderUnsupportedParameters = 0x51E,
        [Obsolete("Deprecated in favour of \"CreateVideoEncoderHeapInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_INVALID_PARAMETERS")]
        MessageIDCreateVideoEncoderHeapInvalidParameters = 0x51F,
        [Obsolete("Deprecated in favour of \"CreateVideoEncoderHeapUnsupportedParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_UNSUPPORTED_PARAMETERS")]
        MessageIDCreateVideoEncoderHeapUnsupportedParameters = 0x520,
        [Obsolete("Deprecated in favour of \"CreatecommandlistNullCommandallocator\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMMANDLIST_NULL_COMMANDALLOCATOR")]
        MessageIDCreatecommandlistNullCommandallocator = 0x521,
        [Obsolete("Deprecated in favour of \"ClearUnorderedAccessViewInvalidDescriptorHandle\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEAR_UNORDERED_ACCESS_VIEW_INVALID_DESCRIPTOR_HANDLE")]
        MessageIDClearUnorderedAccessViewInvalidDescriptorHandle = 0x522,
        [Obsolete("Deprecated in favour of \"DescriptorHeapNotShaderVisible\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DESCRIPTOR_HEAP_NOT_SHADER_VISIBLE")]
        MessageIDDescriptorHeapNotShaderVisible = 0x523,
        [Obsolete("Deprecated in favour of \"CreateblendstateBlendopWarning\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOP_WARNING")]
        MessageIDCreateblendstateBlendopWarning = 0x524,
        [Obsolete("Deprecated in favour of \"CreateblendstateBlendopalphaWarning\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOPALPHA_WARNING")]
        MessageIDCreateblendstateBlendopalphaWarning = 0x525,
        [Obsolete("Deprecated in favour of \"WriteCombinePerformanceWarning\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITE_COMBINE_PERFORMANCE_WARNING")]
        MessageIDWriteCombinePerformanceWarning = 0x526,
        [Obsolete("Deprecated in favour of \"ResolveQueryInvalidQueryState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_QUERY_INVALID_QUERY_STATE")]
        MessageIDResolveQueryInvalidQueryState = 0x527,
        [Obsolete("Deprecated in favour of \"SetprivatedataNoAccess\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_NO_ACCESS")]
        MessageIDSetprivatedataNoAccess = 0x528,
        [Obsolete("Deprecated in favour of \"CommandListStaticDescriptorSamplerModeMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_SAMPLER_MODE_MISMATCH")]
        MessageIDCommandListStaticDescriptorSamplerModeMismatch = 0x529,
        [Obsolete("Deprecated in favour of \"GetcopyablefootprintsUnsupportedBufferWidth\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_UNSUPPORTED_BUFFER_WIDTH")]
        MessageIDGetcopyablefootprintsUnsupportedBufferWidth = 0x52A,
        [Obsolete("Deprecated in favour of \"CreatemeshshaderTopologyMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_TOPOLOGY_MISMATCH")]
        MessageIDCreatemeshshaderTopologyMismatch = 0x52B,
        [Obsolete("Deprecated in favour of \"VrsSumCombinerRequiresCapability\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_VRS_SUM_COMBINER_REQUIRES_CAPABILITY")]
        MessageIDVrsSumCombinerRequiresCapability = 0x52C,
        [Obsolete("Deprecated in favour of \"SettingShadingRateFromMSRequiresCapability\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SETTING_SHADING_RATE_FROM_MS_REQUIRES_CAPABILITY")]
        MessageIDSettingShadingRateFromMSRequiresCapability = 0x52D,
        [Obsolete("Deprecated in favour of \"ShadercachesessionShadercachedeleteNotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_SHADERCACHEDELETE_NOTSUPPORTED")]
        MessageIDShadercachesessionShadercachedeleteNotsupported = 0x52E,
        [Obsolete("Deprecated in favour of \"ShadercachecontrolShadercacheclearNotsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_SHADERCACHECLEAR_NOTSUPPORTED")]
        MessageIDShadercachecontrolShadercacheclearNotsupported = 0x52F,
        [Obsolete("Deprecated in favour of \"CreateresourceStateIgnored\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_STATE_IGNORED")]
        MessageIDCreateresourceStateIgnored = 0x530,
        [Obsolete("Deprecated in favour of \"UnusedCrossExecuteSplitBarrier\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNUSED_CROSS_EXECUTE_SPLIT_BARRIER")]
        MessageIDUnusedCrossExecuteSplitBarrier = 0x531,
        [Obsolete("Deprecated in favour of \"DeviceOpenSharedHandleAccessDenied\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_OPEN_SHARED_HANDLE_ACCESS_DENIED")]
        MessageIDDeviceOpenSharedHandleAccessDenied = 0x532,
        [Obsolete("Deprecated in favour of \"IncompatibleBarrierValues\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_VALUES")]
        MessageIDIncompatibleBarrierValues = 0x533,
        [Obsolete("Deprecated in favour of \"IncompatibleBarrierAccess\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_ACCESS")]
        MessageIDIncompatibleBarrierAccess = 0x534,
        [Obsolete("Deprecated in favour of \"IncompatibleBarrierSync\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_SYNC")]
        MessageIDIncompatibleBarrierSync = 0x535,
        [Obsolete("Deprecated in favour of \"IncompatibleBarrierLayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_LAYOUT")]
        MessageIDIncompatibleBarrierLayout = 0x536,
        [Obsolete("Deprecated in favour of \"IncompatibleBarrierType\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_TYPE")]
        MessageIDIncompatibleBarrierType = 0x537,
        [Obsolete("Deprecated in favour of \"OutOfBoundsBarrierSubresourceRange\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_OUT_OF_BOUNDS_BARRIER_SUBRESOURCE_RANGE")]
        MessageIDOutOfBoundsBarrierSubresourceRange = 0x538,
        [Obsolete("Deprecated in favour of \"IncompatibleBarrierResourceDimension\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_RESOURCE_DIMENSION")]
        MessageIDIncompatibleBarrierResourceDimension = 0x539,
        [Obsolete("Deprecated in favour of \"SetScissorRectsInvalidRect\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_SCISSOR_RECTS_INVALID_RECT")]
        MessageIDSetScissorRectsInvalidRect = 0x53A,
        [Obsolete("Deprecated in favour of \"ShadingRateSourceRequiresDimensionTexture2D\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_SOURCE_REQUIRES_DIMENSION_TEXTURE2D")]
        MessageIDShadingRateSourceRequiresDimensionTexture2D = 0x53B,
        [Obsolete("Deprecated in favour of \"BufferBarrierSubregionOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BUFFER_BARRIER_SUBREGION_OUT_OF_BOUNDS")]
        MessageIDBufferBarrierSubregionOutOfBounds = 0x53C,
        [Obsolete("Deprecated in favour of \"UnsupportedBarrierLayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_UNSUPPORTED_BARRIER_LAYOUT")]
        MessageIDUnsupportedBarrierLayout = 0x53D,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapInvalidParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALID_PARAMETERS")]
        MessageIDCreateresourceandheapInvalidParameters = 0x53E,
        [Obsolete("Deprecated in favour of \"EnhancedBarriersNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ENHANCED_BARRIERS_NOT_SUPPORTED")]
        MessageIDEnhancedBarriersNotSupported = 0x53F,
        [Obsolete("Deprecated in favour of \"LegacyBarrierValidationForcedOn\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_LEGACY_BARRIER_VALIDATION_FORCED_ON")]
        MessageIDLegacyBarrierValidationForcedOn = 0x542,
        [Obsolete("Deprecated in favour of \"EmptyRootDescriptorTable\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EMPTY_ROOT_DESCRIPTOR_TABLE")]
        MessageIDEmptyRootDescriptorTable = 0x543,
        [Obsolete("Deprecated in favour of \"CommandListDrawElementOffsetUnaligned\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ELEMENT_OFFSET_UNALIGNED")]
        MessageIDCommandListDrawElementOffsetUnaligned = 0x544,
        [Obsolete("Deprecated in favour of \"AlphaBlendFactorNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_ALPHA_BLEND_FACTOR_NOT_SUPPORTED")]
        MessageIDAlphaBlendFactorNotSupported = 0x545,
        [Obsolete("Deprecated in favour of \"BarrierInteropInvalidLayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BARRIER_INTEROP_INVALID_LAYOUT")]
        MessageIDBarrierInteropInvalidLayout = 0x546,
        [Obsolete("Deprecated in favour of \"BarrierInteropInvalidState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_BARRIER_INTEROP_INVALID_STATE")]
        MessageIDBarrierInteropInvalidState = 0x547,
        [Obsolete("Deprecated in favour of \"GraphicsPipelineStateDescZeroSampleMask\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GRAPHICS_PIPELINE_STATE_DESC_ZERO_SAMPLE_MASK")]
        MessageIDGraphicsPipelineStateDescZeroSampleMask = 0x548,
        [Obsolete("Deprecated in favour of \"IndependentStencilRefNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INDEPENDENT_STENCIL_REF_NOT_SUPPORTED")]
        MessageIDIndependentStencilRefNotSupported = 0x549,
        [Obsolete("Deprecated in favour of \"CreatedepthstencilstateIndependentMasksUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INDEPENDENT_MASKS_UNSUPPORTED")]
        MessageIDCreatedepthstencilstateIndependentMasksUnsupported = 0x54A,
        [Obsolete("Deprecated in favour of \"TextureBarrierSubresourcesOutOfBounds\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_TEXTURE_BARRIER_SUBRESOURCES_OUT_OF_BOUNDS")]
        MessageIDTextureBarrierSubresourcesOutOfBounds = 0x54B,
        [Obsolete("Deprecated in favour of \"NonOptimalBarrierOnlyExecuteCommandLists\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NON_OPTIMAL_BARRIER_ONLY_EXECUTE_COMMAND_LISTS")]
        MessageIDNonOptimalBarrierOnlyExecuteCommandLists = 0x54C,
        [Obsolete("Deprecated in favour of \"ExecuteIndirectZeroCommandCount\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_INDIRECT_ZERO_COMMAND_COUNT")]
        MessageIDExecuteIndirectZeroCommandCount = 0x54D,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationIncompatibleTextureLayout\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_TEXTURE_LAYOUT")]
        MessageIDGpuBasedValidationIncompatibleTextureLayout = 0x54E,
        [Obsolete("Deprecated in favour of \"DynamicIndexBufferStripCutNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_NOT_SUPPORTED")]
        MessageIDDynamicIndexBufferStripCutNotSupported = 0x54F,
        [Obsolete("Deprecated in favour of \"PrimitiveTopologyTriangleFansNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_TRIANGLE_FANS_NOT_SUPPORTED")]
        MessageIDPrimitiveTopologyTriangleFansNotSupported = 0x550,
        [Obsolete("Deprecated in favour of \"CreateSamplerComparisonFuncIgnored\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SAMPLER_COMPARISON_FUNC_IGNORED")]
        MessageIDCreateSamplerComparisonFuncIgnored = 0x551,
        [Obsolete("Deprecated in favour of \"CreateheapInvalidheaptype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDHEAPTYPE")]
        MessageIDCreateheapInvalidheaptype = 0x552,
        [Obsolete("Deprecated in favour of \"CreateresourceandheapInvalidheaptype\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPTYPE")]
        MessageIDCreateresourceandheapInvalidheaptype = 0x553,
        [Obsolete("Deprecated in favour of \"DynamicDepthBiasNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_NOT_SUPPORTED")]
        MessageIDDynamicDepthBiasNotSupported = 0x554,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateNonWholeDynamicDepthBias\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_NON_WHOLE_DYNAMIC_DEPTH_BIAS")]
        MessageIDCreaterasterizerstateNonWholeDynamicDepthBias = 0x555,
        [Obsolete("Deprecated in favour of \"DynamicDepthBiasFlagMissing\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_FLAG_MISSING")]
        MessageIDDynamicDepthBiasFlagMissing = 0x556,
        [Obsolete("Deprecated in favour of \"DynamicDepthBiasNoPipeline\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_NO_PIPELINE")]
        MessageIDDynamicDepthBiasNoPipeline = 0x557,
        [Obsolete("Deprecated in favour of \"DynamicIndexBufferStripCutFlagMissing\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_FLAG_MISSING")]
        MessageIDDynamicIndexBufferStripCutFlagMissing = 0x558,
        [Obsolete("Deprecated in favour of \"DynamicIndexBufferStripCutNoPipeline\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_NO_PIPELINE")]
        MessageIDDynamicIndexBufferStripCutNoPipeline = 0x559,
        [Obsolete("Deprecated in favour of \"NonnormalizedCoordinateSamplingNotSupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_NONNORMALIZED_COORDINATE_SAMPLING_NOT_SUPPORTED")]
        MessageIDNonnormalizedCoordinateSamplingNotSupported = 0x55A,
        [Obsolete("Deprecated in favour of \"InvalidCastTarget\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_CAST_TARGET")]
        MessageIDInvalidCastTarget = 0x55B,
        [Obsolete("Deprecated in favour of \"RenderPassCommandlistInvalidEndState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_COMMANDLIST_INVALID_END_STATE")]
        MessageIDRenderPassCommandlistInvalidEndState = 0x55C,
        [Obsolete("Deprecated in favour of \"RenderPassCommandlistInvalidStartState\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_COMMANDLIST_INVALID_START_STATE")]
        MessageIDRenderPassCommandlistInvalidStartState = 0x55D,
        [Obsolete("Deprecated in favour of \"RenderPassMismatchingAccess\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_ACCESS")]
        MessageIDRenderPassMismatchingAccess = 0x55E,
        [Obsolete("Deprecated in favour of \"RenderPassMismatchingLocalPreserveParameters\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_LOCAL_PRESERVE_PARAMETERS")]
        MessageIDRenderPassMismatchingLocalPreserveParameters = 0x55F,
        [Obsolete("Deprecated in favour of \"RenderPassLocalPreserveRenderParametersError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_LOCAL_PRESERVE_RENDER_PARAMETERS_ERROR")]
        MessageIDRenderPassLocalPreserveRenderParametersError = 0x560,
        [Obsolete("Deprecated in favour of \"RenderPassLocalDepthStencilError\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_LOCAL_DEPTH_STENCIL_ERROR")]
        MessageIDRenderPassLocalDepthStencilError = 0x561,
        [Obsolete("Deprecated in favour of \"DrawPotentiallyOutsideOfValidRenderArea\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_DRAW_POTENTIALLY_OUTSIDE_OF_VALID_RENDER_AREA")]
        MessageIDDrawPotentiallyOutsideOfValidRenderArea = 0x562,
        [Obsolete("Deprecated in favour of \"CreaterasterizerstateInvalidLinerasterizationmode\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_LINERASTERIZATIONMODE")]
        MessageIDCreaterasterizerstateInvalidLinerasterizationmode = 0x563,
        [Obsolete("Deprecated in favour of \"CreateresourceInvalidalignmentSmallresource\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT_SMALLRESOURCE")]
        MessageIDCreateresourceInvalidalignmentSmallresource = 0x564,
        [Obsolete("Deprecated in favour of \"GenericDeviceOperationUnsupported\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GENERIC_DEVICE_OPERATION_UNSUPPORTED")]
        MessageIDGenericDeviceOperationUnsupported = 0x565,
        [Obsolete("Deprecated in favour of \"CreategraphicspipelinestateRenderTargetWrongWriteMask\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDER_TARGET_WRONG_WRITE_MASK")]
        MessageIDCreategraphicspipelinestateRenderTargetWrongWriteMask = 0x566,
        [Obsolete("Deprecated in favour of \"ProbablePixEventLeak\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PROBABLE_PIX_EVENT_LEAK")]
        MessageIDProbablePixEventLeak = 0x567,
        [Obsolete("Deprecated in favour of \"PixEventUnderflow\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_PIX_EVENT_UNDERFLOW")]
        MessageIDPixEventUnderflow = 0x568,
        [Obsolete("Deprecated in favour of \"RecreateatInvalidTarget\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RECREATEAT_INVALID_TARGET")]
        MessageIDRecreateatInvalidTarget = 0x569,
        [Obsolete("Deprecated in favour of \"RecreateatInsufficientSupport\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_RECREATEAT_INSUFFICIENT_SUPPORT")]
        MessageIDRecreateatInsufficientSupport = 0x56A,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationStructuredBufferStrideMismatch\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_STRUCTURED_BUFFER_STRIDE_MISMATCH")]
        MessageIDGpuBasedValidationStructuredBufferStrideMismatch = 0x56B,
        [Obsolete("Deprecated in favour of \"D3D12MessagesEnd\"")]
        [NativeName("Name", "D3D12_MESSAGE_ID_D3D12_MESSAGES_END")]
        MessageIDD3D12MessagesEnd = 0x56C,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D12_MESSAGE_ID_STRING_FROM_APPLICATION")]
        StringFromApplication = 0x1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_THIS")]
        CorruptedThis = 0x2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER1")]
        CorruptedParameter1 = 0x3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER2")]
        CorruptedParameter2 = 0x4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER3")]
        CorruptedParameter3 = 0x5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER4")]
        CorruptedParameter4 = 0x6,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER5")]
        CorruptedParameter5 = 0x7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER6")]
        CorruptedParameter6 = 0x8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER7")]
        CorruptedParameter7 = 0x9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER8")]
        CorruptedParameter8 = 0xA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER9")]
        CorruptedParameter9 = 0xB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER10")]
        CorruptedParameter10 = 0xC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER11")]
        CorruptedParameter11 = 0xD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER12")]
        CorruptedParameter12 = 0xE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER13")]
        CorruptedParameter13 = 0xF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER14")]
        CorruptedParameter14 = 0x10,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER15")]
        CorruptedParameter15 = 0x11,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_MULTITHREADING")]
        CorruptedMultithreading = 0x12,
        [NativeName("Name", "D3D12_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY")]
        MessageReportingOutofmemory = 0x13,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETPRIVATEDATA_MOREDATA")]
        GetprivatedataMoredata = 0x14,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA")]
        SetprivatedataInvalidfreedata = 0x15,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS")]
        SetprivatedataChangingparams = 0x18,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY")]
        SetprivatedataOutofmemory = 0x19,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT")]
        CreateshaderresourceviewUnrecognizedformat = 0x1A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC")]
        CreateshaderresourceviewInvaliddesc = 0x1B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT")]
        CreateshaderresourceviewInvalidformat = 0x1C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANESLICE")]
        CreateshaderresourceviewInvalidvideoplaneslice = 0x1D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANESLICE")]
        CreateshaderresourceviewInvalidplaneslice = 0x1E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS")]
        CreateshaderresourceviewInvaliddimensions = 0x1F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE")]
        CreateshaderresourceviewInvalidresource = 0x20,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT")]
        CreaterendertargetviewUnrecognizedformat = 0x23,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT")]
        CreaterendertargetviewUnsupportedformat = 0x24,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC")]
        CreaterendertargetviewInvaliddesc = 0x25,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT")]
        CreaterendertargetviewInvalidformat = 0x26,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANESLICE")]
        CreaterendertargetviewInvalidvideoplaneslice = 0x27,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANESLICE")]
        CreaterendertargetviewInvalidplaneslice = 0x28,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS")]
        CreaterendertargetviewInvaliddimensions = 0x29,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE")]
        CreaterendertargetviewInvalidresource = 0x2A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT")]
        CreatedepthstencilviewUnrecognizedformat = 0x2D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC")]
        CreatedepthstencilviewInvaliddesc = 0x2E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT")]
        CreatedepthstencilviewInvalidformat = 0x2F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS")]
        CreatedepthstencilviewInvaliddimensions = 0x30,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE")]
        CreatedepthstencilviewInvalidresource = 0x31,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY")]
        CreateinputlayoutOutofmemory = 0x34,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS")]
        CreateinputlayoutToomanyelements = 0x35,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT")]
        CreateinputlayoutInvalidformat = 0x36,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT")]
        CreateinputlayoutIncompatibleformat = 0x37,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT")]
        CreateinputlayoutInvalidslot = 0x38,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS")]
        CreateinputlayoutInvalidinputslotclass = 0x39,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH")]
        CreateinputlayoutSteprateslotclassmismatch = 0x3A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE")]
        CreateinputlayoutInvalidslotclasschange = 0x3B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE")]
        CreateinputlayoutInvalidstepratechange = 0x3C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT")]
        CreateinputlayoutInvalidalignment = 0x3D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC")]
        CreateinputlayoutDuplicatesemantic = 0x3E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE")]
        CreateinputlayoutUnparseableinputsignature = 0x3F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC")]
        CreateinputlayoutNullsemantic = 0x40,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT")]
        CreateinputlayoutMissingelement = 0x41,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY")]
        CreatevertexshaderOutofmemory = 0x42,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE")]
        CreatevertexshaderInvalidshaderbytecode = 0x43,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE")]
        CreatevertexshaderInvalidshadertype = 0x44,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY")]
        CreategeometryshaderOutofmemory = 0x45,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE")]
        CreategeometryshaderInvalidshaderbytecode = 0x46,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE")]
        CreategeometryshaderInvalidshadertype = 0x47,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY")]
        CreategeometryshaderwithstreamoutputOutofmemory = 0x48,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE")]
        CreategeometryshaderwithstreamoutputInvalidshaderbytecode = 0x49,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        CreategeometryshaderwithstreamoutputInvalidshadertype = 0x4A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES")]
        CreategeometryshaderwithstreamoutputInvalidnumentries = 0x4B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED")]
        CreategeometryshaderwithstreamoutputOutputstreamstrideunused = 0x4C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED")]
        CreategeometryshaderwithstreamoutputOutputslot0Expected = 0x4F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT")]
        CreategeometryshaderwithstreamoutputInvalidoutputslot = 0x50,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT")]
        CreategeometryshaderwithstreamoutputOnlyoneelementperslot = 0x51,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT")]
        CreategeometryshaderwithstreamoutputInvalidcomponentcount = 0x52,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT")]
        CreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 0x53,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION")]
        CreategeometryshaderwithstreamoutputInvalidgapdefinition = 0x54,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT")]
        CreategeometryshaderwithstreamoutputRepeatedoutput = 0x55,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE")]
        CreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 0x56,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC")]
        CreategeometryshaderwithstreamoutputMissingsemantic = 0x57,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH")]
        CreategeometryshaderwithstreamoutputMaskmismatch = 0x58,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS")]
        CreategeometryshaderwithstreamoutputCanthaveonlygaps = 0x59,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX")]
        CreategeometryshaderwithstreamoutputDecltoocomplex = 0x5A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE")]
        CreategeometryshaderwithstreamoutputMissingoutputsignature = 0x5B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY")]
        CreatepixelshaderOutofmemory = 0x5C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE")]
        CreatepixelshaderInvalidshaderbytecode = 0x5D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE")]
        CreatepixelshaderInvalidshadertype = 0x5E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE")]
        CreaterasterizerstateInvalidfillmode = 0x5F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE")]
        CreaterasterizerstateInvalidcullmode = 0x60,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP")]
        CreaterasterizerstateInvaliddepthbiasclamp = 0x61,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS")]
        CreaterasterizerstateInvalidslopescaleddepthbias = 0x62,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK")]
        CreatedepthstencilstateInvaliddepthwritemask = 0x64,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC")]
        CreatedepthstencilstateInvaliddepthfunc = 0x65,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP")]
        CreatedepthstencilstateInvalidfrontfacestencilfailop = 0x66,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP")]
        CreatedepthstencilstateInvalidfrontfacestencilzfailop = 0x67,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP")]
        CreatedepthstencilstateInvalidfrontfacestencilpassop = 0x68,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC")]
        CreatedepthstencilstateInvalidfrontfacestencilfunc = 0x69,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP")]
        CreatedepthstencilstateInvalidbackfacestencilfailop = 0x6A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP")]
        CreatedepthstencilstateInvalidbackfacestencilzfailop = 0x6B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP")]
        CreatedepthstencilstateInvalidbackfacestencilpassop = 0x6C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC")]
        CreatedepthstencilstateInvalidbackfacestencilfunc = 0x6D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND")]
        CreateblendstateInvalidsrcblend = 0x6F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND")]
        CreateblendstateInvaliddestblend = 0x70,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP")]
        CreateblendstateInvalidblendop = 0x71,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA")]
        CreateblendstateInvalidsrcblendalpha = 0x72,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA")]
        CreateblendstateInvaliddestblendalpha = 0x73,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA")]
        CreateblendstateInvalidblendopalpha = 0x74,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK")]
        CreateblendstateInvalidrendertargetwritemask = 0x75,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_PROGRAM_IDENTIFIER_ERROR")]
        GetProgramIdentifierError = 0x76,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_WORK_GRAPH_PROPERTIES_ERROR")]
        GetWorkGraphPropertiesError = 0x77,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PROGRAM_ERROR")]
        SetProgramError = 0x78,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID")]
        CleardepthstencilviewInvalid = 0x87,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_NOT_SET")]
        CommandListDrawRootSignatureNotSet = 0xC8,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_MISMATCH")]
        CommandListDrawRootSignatureMismatch = 0xC9,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_NOT_SET")]
        CommandListDrawVertexBufferNotSet = 0xCA,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL")]
        CommandListDrawVertexBufferStrideTooSmall = 0xD1,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_TOO_SMALL")]
        CommandListDrawVertexBufferTooSmall = 0xD2,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_NOT_SET")]
        CommandListDrawIndexBufferNotSet = 0xD3,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_FORMAT_INVALID")]
        CommandListDrawIndexBufferFormatInvalid = 0xD4,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_TOO_SMALL")]
        CommandListDrawIndexBufferTooSmall = 0xD5,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INVALID_PRIMITIVETOPOLOGY")]
        CommandListDrawInvalidPrimitivetopology = 0xDB,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_STRIDE_UNALIGNED")]
        CommandListDrawVertexStrideUnaligned = 0xDD,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_OFFSET_UNALIGNED")]
        CommandListDrawIndexOffsetUnaligned = 0xDE,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT")]
        DeviceRemovalProcessATFault = 0xE8,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT")]
        DeviceRemovalProcessPossiblyATFault = 0xE9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT")]
        DeviceRemovalProcessNotATFault = 0xEA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC")]
        CreateinputlayoutTrailingDigitInSemantic = 0xEF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC")]
        CreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 0xF0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH")]
        CreateinputlayoutTypeMismatch = 0xF5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT")]
        CreateinputlayoutEmptyLayout = 0xFD,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_OBJECT_SUMMARY")]
        LiveObjectSummary = 0xFF,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_DEVICE")]
        LiveDevice = 0x112,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_SWAPCHAIN")]
        LiveSwapchain = 0x113,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS")]
        CreatedepthstencilviewInvalidflags = 0x114,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE")]
        CreatevertexshaderInvalidclasslinkage = 0x115,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE")]
        CreategeometryshaderInvalidclasslinkage = 0x116,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER")]
        CreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 0x118,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE")]
        CreatepixelshaderInvalidclasslinkage = 0x11B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM")]
        CreategeometryshaderwithstreamoutputInvalidstream = 0x11C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES")]
        CreategeometryshaderwithstreamoutputUnexpectedentries = 0x11D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES")]
        CreategeometryshaderwithstreamoutputUnexpectedstrides = 0x11E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES")]
        CreategeometryshaderwithstreamoutputInvalidnumstrides = 0x11F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY")]
        CreatehullshaderOutofmemory = 0x121,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE")]
        CreatehullshaderInvalidshaderbytecode = 0x122,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE")]
        CreatehullshaderInvalidshadertype = 0x123,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE")]
        CreatehullshaderInvalidclasslinkage = 0x124,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY")]
        CreatedomainshaderOutofmemory = 0x126,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE")]
        CreatedomainshaderInvalidshaderbytecode = 0x127,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE")]
        CreatedomainshaderInvalidshadertype = 0x128,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE")]
        CreatedomainshaderInvalidclasslinkage = 0x129,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED")]
        ResourceUnmapNotmapped = 0x136,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE")]
        DeviceCheckfeaturesupportMismatchedDataSize = 0x13E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY")]
        CreatecomputeshaderOutofmemory = 0x141,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE")]
        CreatecomputeshaderInvalidshaderbytecode = 0x142,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE")]
        CreatecomputeshaderInvalidclasslinkage = 0x143,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatevertexshaderDoublefloatopsnotsupported = 0x14B,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatehullshaderDoublefloatopsnotsupported = 0x14C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatedomainshaderDoublefloatopsnotsupported = 0x14D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreategeometryshaderDoublefloatopsnotsupported = 0x14E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 0x14F,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatepixelshaderDoublefloatopsnotsupported = 0x150,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        DeviceCreatecomputeshaderDoublefloatopsnotsupported = 0x151,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE")]
        CreateunorderedaccessviewInvalidresource = 0x154,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC")]
        CreateunorderedaccessviewInvaliddesc = 0x155,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT")]
        CreateunorderedaccessviewInvalidformat = 0x156,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANESLICE")]
        CreateunorderedaccessviewInvalidvideoplaneslice = 0x157,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANESLICE")]
        CreateunorderedaccessviewInvalidplaneslice = 0x158,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS")]
        CreateunorderedaccessviewInvaliddimensions = 0x159,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT")]
        CreateunorderedaccessviewUnrecognizedformat = 0x15A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS")]
        CreateunorderedaccessviewInvalidflags = 0x162,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT")]
        CreaterasterizerstateInvalidforcedsamplecount = 0x191,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS")]
        CreateblendstateInvalidlogicops = 0x193,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatevertexshaderDoubleextensionsnotsupported = 0x19A,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatehullshaderDoubleextensionsnotsupported = 0x19C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatedomainshaderDoubleextensionsnotsupported = 0x19E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreategeometryshaderDoubleextensionsnotsupported = 0x1A0,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 0x1A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatepixelshaderDoubleextensionsnotsupported = 0x1A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        DeviceCreatecomputeshaderDoubleextensionsnotsupported = 0x1A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatevertexshaderUavsnotsupported = 0x1A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatehullshaderUavsnotsupported = 0x1AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatedomainshaderUavsnotsupported = 0x1AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED")]
        DeviceCreategeometryshaderUavsnotsupported = 0x1AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED")]
        DeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 0x1AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED")]
        DeviceCreatepixelshaderUavsnotsupported = 0x1AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED")]
        DeviceCreatecomputeshaderUavsnotsupported = 0x1AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT")]
        DeviceClearviewInvalidsourcerect = 0x1BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT")]
        DeviceClearviewEmptyrect = 0x1C0,
        [NativeName("Name", "D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER")]
        UpdatetilemappingsInvalidParameter = 0x1ED,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER")]
        CopytilemappingsInvalidParameter = 0x1EE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_INVALIDARGS")]
        CreatedeviceInvalidargs = 0x1FA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_WARNING")]
        CreatedeviceWarning = 0x1FB,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_TYPE")]
        ResourceBarrierInvalidType = 0x207,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_NULL_POINTER")]
        ResourceBarrierNullPointer = 0x208,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SUBRESOURCE")]
        ResourceBarrierInvalidSubresource = 0x209,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_RESERVED_BITS")]
        ResourceBarrierReservedBits = 0x20A,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISSING_BIND_FLAGS")]
        ResourceBarrierMissingBindFlags = 0x20B,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_MISC_FLAGS")]
        ResourceBarrierMismatchingMiscFlags = 0x20C,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MATCHING_STATES")]
        ResourceBarrierMatchingStates = 0x20D,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINATION")]
        ResourceBarrierInvalidCombination = 0x20E,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_BEFORE_AFTER_MISMATCH")]
        ResourceBarrierBeforeAfterMismatch = 0x20F,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_RESOURCE")]
        ResourceBarrierInvalidResource = 0x210,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_SAMPLE_COUNT")]
        ResourceBarrierSampleCount = 0x211,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS")]
        ResourceBarrierInvalidFlags = 0x212,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINED_FLAGS")]
        ResourceBarrierInvalidCombinedFlags = 0x213,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS_FOR_FORMAT")]
        ResourceBarrierInvalidFlagsForFormat = 0x214,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SPLIT_BARRIER")]
        ResourceBarrierInvalidSplitBarrier = 0x215,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_END")]
        ResourceBarrierUnmatchedEnd = 0x216,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_BEGIN")]
        ResourceBarrierUnmatchedBegin = 0x217,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAG")]
        ResourceBarrierInvalidFlag = 0x218,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMMAND_LIST_TYPE")]
        ResourceBarrierInvalidCommandListType = 0x219,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_SUBRESOURCE_STATE")]
        InvalidSubresourceState = 0x21A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CONTENTION")]
        CommandAllocatorContention = 0x21C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET")]
        CommandAllocatorReset = 0x21D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET_BUNDLE")]
        CommandAllocatorResetBundle = 0x21E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CANNOT_RESET")]
        CommandAllocatorCannotReset = 0x21F,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_OPEN")]
        CommandListOpen = 0x220,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_BUNDLE_API")]
        InvalidBundleApi = 0x222,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_CLOSED")]
        CommandListClosed = 0x223,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRONG_COMMAND_ALLOCATOR_TYPE")]
        WrongCommandAllocatorType = 0x225,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_SYNC")]
        CommandAllocatorSync = 0x228,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_SYNC")]
        CommandListSync = 0x229,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_DESCRIPTOR_HEAP_INVALID")]
        SetDescriptorHeapInvalid = 0x22A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDQUEUE")]
        CreateCommandqueue = 0x22D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDALLOCATOR")]
        CreateCommandallocator = 0x22E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PIPELINESTATE")]
        CreatePipelinestate = 0x22F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDLIST12")]
        CreateCommandlist12 = 0x230,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_RESOURCE")]
        CreateResource = 0x232,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTORHEAP")]
        CreateDescriptorheap = 0x233,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOTSIGNATURE")]
        CreateRootsignature = 0x234,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_LIBRARY")]
        CreateLibrary = 0x235,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_HEAP")]
        CreateHeap = 0x236,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_MONITOREDFENCE")]
        CreateMonitoredfence = 0x237,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUERYHEAP")]
        CreateQueryheap = 0x238,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDSIGNATURE")]
        CreateCommandsignature = 0x239,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDQUEUE")]
        LiveCommandqueue = 0x23A,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDALLOCATOR")]
        LiveCommandallocator = 0x23B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PIPELINESTATE")]
        LivePipelinestate = 0x23C,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDLIST12")]
        LiveCommandlist12 = 0x23D,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_RESOURCE")]
        LiveResource = 0x23F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_DESCRIPTORHEAP")]
        LiveDescriptorheap = 0x240,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_ROOTSIGNATURE")]
        LiveRootsignature = 0x241,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_LIBRARY")]
        LiveLibrary = 0x242,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_HEAP")]
        LiveHeap = 0x243,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_MONITOREDFENCE")]
        LiveMonitoredfence = 0x244,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_QUERYHEAP")]
        LiveQueryheap = 0x245,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDSIGNATURE")]
        LiveCommandsignature = 0x246,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDQUEUE")]
        DestroyCommandqueue = 0x247,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDALLOCATOR")]
        DestroyCommandallocator = 0x248,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PIPELINESTATE")]
        DestroyPipelinestate = 0x249,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDLIST12")]
        DestroyCommandlist12 = 0x24A,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_RESOURCE")]
        DestroyResource = 0x24C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_DESCRIPTORHEAP")]
        DestroyDescriptorheap = 0x24D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_ROOTSIGNATURE")]
        DestroyRootsignature = 0x24E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_LIBRARY")]
        DestroyLibrary = 0x24F,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_HEAP")]
        DestroyHeap = 0x250,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_MONITOREDFENCE")]
        DestroyMonitoredfence = 0x251,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_QUERYHEAP")]
        DestroyQueryheap = 0x252,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDSIGNATURE")]
        DestroyCommandsignature = 0x253,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONS")]
        CreateresourceInvaliddimensions = 0x255,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMISCFLAGS")]
        CreateresourceInvalidmiscflags = 0x257,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDARG_RETURN")]
        CreateresourceInvalidargReturn = 0x25A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_OUTOFMEMORY_RETURN")]
        CreateresourceOutofmemoryReturn = 0x25B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDESC")]
        CreateresourceInvaliddesc = 0x25C,
        [NativeName("Name", "D3D12_MESSAGE_ID_POSSIBLY_INVALID_SUBRESOURCE_STATE")]
        PossiblyInvalidSubresourceState = 0x25F,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_USE_OF_NON_RESIDENT_RESOURCE")]
        InvalidUseOfNonResidentResource = 0x260,
        [NativeName("Name", "D3D12_MESSAGE_ID_POSSIBLE_INVALID_USE_OF_NON_RESIDENT_RESOURCE")]
        PossibleInvalidUseOfNonResidentResource = 0x261,
        [NativeName("Name", "D3D12_MESSAGE_ID_BUNDLE_PIPELINE_STATE_MISMATCH")]
        BundlePipelineStateMismatch = 0x262,
        [NativeName("Name", "D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_MISMATCH_PIPELINE_STATE")]
        PrimitiveTopologyMismatchPipelineState = 0x263,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_TARGET_FORMAT_MISMATCH_PIPELINE_STATE")]
        RenderTargetFormatMismatchPipelineState = 0x265,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_TARGET_SAMPLE_DESC_MISMATCH_PIPELINE_STATE")]
        RenderTargetSampleDescMismatchPipelineState = 0x266,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPTH_STENCIL_FORMAT_MISMATCH_PIPELINE_STATE")]
        DepthStencilFormatMismatchPipelineState = 0x267,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPTH_STENCIL_SAMPLE_DESC_MISMATCH_PIPELINE_STATE")]
        DepthStencilSampleDescMismatchPipelineState = 0x268,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADER_INVALIDBYTECODE")]
        CreateshaderInvalidbytecode = 0x26E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_NULLDESC")]
        CreateheapNulldesc = 0x26F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDSIZE")]
        CreateheapInvalidsize = 0x270,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDHEAPTYPE")]
        CreateheapUnrecognizedheaptype = 0x271,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES")]
        CreateheapUnrecognizedcpupageproperties = 0x272,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMEMORYPOOL")]
        CreateheapUnrecognizedmemorypool = 0x273,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDPROPERTIES")]
        CreateheapInvalidproperties = 0x274,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDALIGNMENT")]
        CreateheapInvalidalignment = 0x275,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMISCFLAGS")]
        CreateheapUnrecognizedmiscflags = 0x276,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDMISCFLAGS")]
        CreateheapInvalidmiscflags = 0x277,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDARG_RETURN")]
        CreateheapInvalidargReturn = 0x278,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_OUTOFMEMORY_RETURN")]
        CreateheapOutofmemoryReturn = 0x279,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAPPROPERTIES")]
        CreateresourceandheapNullheapproperties = 0x27A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPTYPE")]
        CreateresourceandheapUnrecognizedheaptype = 0x27B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES")]
        CreateresourceandheapUnrecognizedcpupageproperties = 0x27C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDMEMORYPOOL")]
        CreateresourceandheapUnrecognizedmemorypool = 0x27D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPPROPERTIES")]
        CreateresourceandheapInvalidheapproperties = 0x27E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPMISCFLAGS")]
        CreateresourceandheapUnrecognizedheapmiscflags = 0x27F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPMISCFLAGS")]
        CreateresourceandheapInvalidheapmiscflags = 0x280,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDARG_RETURN")]
        CreateresourceandheapInvalidargReturn = 0x281,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_OUTOFMEMORY_RETURN")]
        CreateresourceandheapOutofmemoryReturn = 0x282,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_UNRECOGNIZEDHEAPTYPE")]
        GetcustomheappropertiesUnrecognizedheaptype = 0x283,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_INVALIDHEAPTYPE")]
        GetcustomheappropertiesInvalidheaptype = 0x284,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_INVALID_DESC")]
        CreateDescriptorHeapInvalidDesc = 0x285,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_DESCRIPTOR_HANDLE")]
        InvalidDescriptorHandle = 0x286,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE")]
        CreaterasterizerstateInvalidConservativerastermode = 0x287,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_RESOURCE")]
        CreateConstantBufferViewInvalidResource = 0x289,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_DESC")]
        CreateConstantBufferViewInvalidDesc = 0x28A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_UNORDEREDACCESS_VIEW_INVALID_COUNTER_USAGE")]
        CreateUnorderedaccessViewInvalidCounterUsage = 0x28C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_DESCRIPTORS_INVALID_RANGES")]
        CopyDescriptorsInvalidRanges = 0x28D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_DESCRIPTORS_WRITE_ONLY_DESCRIPTOR")]
        CopyDescriptorsWriteOnlyDescriptor = 0x28E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RTV_FORMAT_NOT_UNKNOWN")]
        CreategraphicspipelinestateRtvFormatNotUnknown = 0x28F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_RENDER_TARGET_COUNT")]
        CreategraphicspipelinestateInvalidRenderTargetCount = 0x290,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VERTEX_SHADER_NOT_SET")]
        CreategraphicspipelinestateVertexShaderNotSet = 0x291,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_NOT_SET")]
        CreategraphicspipelinestateInputlayoutNotSet = 0x292,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_HS_DS_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateShaderLinkageHSDSSignatureMismatch = 0x293,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERINDEX")]
        CreategraphicspipelinestateShaderLinkageRegisterindex = 0x294,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_COMPONENTTYPE")]
        CreategraphicspipelinestateShaderLinkageComponenttype = 0x295,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERMASK")]
        CreategraphicspipelinestateShaderLinkageRegistermask = 0x296,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SYSTEMVALUE")]
        CreategraphicspipelinestateShaderLinkageSystemvalue = 0x297,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS")]
        CreategraphicspipelinestateShaderLinkageNeverwrittenAlwaysreads = 0x298,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_MINPRECISION")]
        CreategraphicspipelinestateShaderLinkageMinprecision = 0x299,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND")]
        CreategraphicspipelinestateShaderLinkageSemanticnameNotFound = 0x29A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_XOR_DS_MISMATCH")]
        CreategraphicspipelinestateHSXorDSMismatch = 0x29B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH")]
        CreategraphicspipelinestateHullShaderInputTopologyMismatch = 0x29C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_CONTROL_POINT_COUNT_MISMATCH")]
        CreategraphicspipelinestateHSDSControlPointCountMismatch = 0x29D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_TESSELLATOR_DOMAIN_MISMATCH")]
        CreategraphicspipelinestateHSDSTessellatorDomainMismatch = 0x29E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN")]
        CreategraphicspipelinestateInvalidUseOfCenterMultisamplePattern = 0x29F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_FORCED_SAMPLE_COUNT")]
        CreategraphicspipelinestateInvalidUseOfForcedSampleCount = 0x2A0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_PRIMITIVETOPOLOGY")]
        CreategraphicspipelinestateInvalidPrimitivetopology = 0x2A1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SYSTEMVALUE")]
        CreategraphicspipelinestateInvalidSystemvalue = 0x2A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0")]
        CreategraphicspipelinestateOMDualSourceBlendingCanOnlyHaveRenderTarget0 = 0x2A3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING")]
        CreategraphicspipelinestateOMRenderTargetDoesNotSupportBlending = 0x2A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_TYPE_MISMATCH")]
        CreategraphicspipelinestatePSOutputTypeMismatch = 0x2A5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS")]
        CreategraphicspipelinestateOMRenderTargetDoesNotSupportLogicOps = 0x2A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDERTARGETVIEW_NOT_SET")]
        CreategraphicspipelinestateRendertargetviewNotSet = 0x2A7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DEPTHSTENCILVIEW_NOT_SET")]
        CreategraphicspipelinestateDepthstencilviewNotSet = 0x2A8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_INPUT_PRIMITIVE_MISMATCH")]
        CreategraphicspipelinestateGSInputPrimitiveMismatch = 0x2A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_POSITION_NOT_PRESENT")]
        CreategraphicspipelinestatePositionNotPresent = 0x2AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE_FLAGS")]
        CreategraphicspipelinestateMissingRootSignatureFlags = 0x2AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_INDEX_BUFFER_PROPERTIES")]
        CreategraphicspipelinestateInvalidIndexBufferProperties = 0x2AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SAMPLE_DESC")]
        CreategraphicspipelinestateInvalidSampleDesc = 0x2AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateHSRootSignatureMismatch = 0x2AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateDSRootSignatureMismatch = 0x2AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateVSRootSignatureMismatch = 0x2B0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateGSRootSignatureMismatch = 0x2B1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestatePSRootSignatureMismatch = 0x2B2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE")]
        CreategraphicspipelinestateMissingRootSignature = 0x2B3,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_OPEN_BUNDLE")]
        ExecuteBundleOpenBundle = 0x2B4,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_DESCRIPTOR_HEAP_MISMATCH")]
        ExecuteBundleDescriptorHeapMismatch = 0x2B5,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_TYPE")]
        ExecuteBundleType = 0x2B6,
        [NativeName("Name", "D3D12_MESSAGE_ID_DRAW_EMPTY_SCISSOR_RECTANGLE")]
        DrawEmptyScissorRectangle = 0x2B7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_BLOB_NOT_FOUND")]
        CreateRootSignatureBlobNotFound = 0x2B8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_DESERIALIZE_FAILED")]
        CreateRootSignatureDeserializeFailed = 0x2B9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_INVALID_CONFIGURATION")]
        CreateRootSignatureInvalidConfiguration = 0x2BA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_SUPPORTED_ON_DEVICE")]
        CreateRootSignatureNotSupportedOnDevice = 0x2BB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLRESOURCEPROPERTIES")]
        CreateresourceandheapNullresourceproperties = 0x2BC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAP")]
        CreateresourceandheapNullheap = 0x2BD,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETRESOURCEALLOCATIONINFO_INVALIDRDESCS")]
        GetresourceallocationinfoInvalidrdescs = 0x2BE,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAKERESIDENT_NULLOBJECTARRAY")]
        MakeresidentNullobjectarray = 0x2BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_EVICT_NULLOBJECTARRAY")]
        EvictNullobjectarray = 0x2C1,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_DESCRIPTOR_TABLE_INVALID")]
        SetDescriptorTableInvalid = 0x2C4,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_INVALID")]
        SetRootConstantInvalid = 0x2C5,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_BUFFER_VIEW_INVALID")]
        SetRootConstantBufferViewInvalid = 0x2C6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_SHADER_RESOURCE_VIEW_INVALID")]
        SetRootShaderResourceViewInvalid = 0x2C7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_UNORDERED_ACCESS_VIEW_INVALID")]
        SetRootUnorderedAccessViewInvalid = 0x2C8,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID_DESC")]
        SetVertexBuffersInvalidDesc = 0x2C9,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID_DESC")]
        SetIndexBufferInvalidDesc = 0x2CB,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID_DESC")]
        SetStreamOutputBuffersInvalidDesc = 0x2CD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDDIMENSIONALITY")]
        CreateresourceUnrecognizeddimensionality = 0x2CE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDLAYOUT")]
        CreateresourceUnrecognizedlayout = 0x2CF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONALITY")]
        CreateresourceInvaliddimensionality = 0x2D0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT")]
        CreateresourceInvalidalignment = 0x2D1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMIPLEVELS")]
        CreateresourceInvalidmiplevels = 0x2D2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDSAMPLEDESC")]
        CreateresourceInvalidsampledesc = 0x2D3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDLAYOUT")]
        CreateresourceInvalidlayout = 0x2D4,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID")]
        SetIndexBufferInvalid = 0x2D5,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID")]
        SetVertexBuffersInvalid = 0x2D6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID")]
        SetStreamOutputBuffersInvalid = 0x2D7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_RENDER_TARGETS_INVALID")]
        SetRenderTargetsInvalid = 0x2D8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_INVALID_PARAMETERS")]
        CreatequeryHeapInvalidParameters = 0x2D9,
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_END_QUERY_INVALID_PARAMETERS")]
        BeginEndQueryInvalidParameters = 0x2DB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLOSE_COMMAND_LIST_OPEN_QUERY")]
        CloseCommandListOpenQuery = 0x2DC,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_QUERY_DATA_INVALID_PARAMETERS")]
        ResolveQueryDataInvalidParameters = 0x2DD,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PREDICATION_INVALID_PARAMETERS")]
        SetPredicationInvalidParameters = 0x2DE,
        [NativeName("Name", "D3D12_MESSAGE_ID_TIMESTAMPS_NOT_SUPPORTED")]
        TimestampsNotSupported = 0x2DF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDFORMAT")]
        CreateresourceUnrecognizedformat = 0x2E1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDFORMAT")]
        CreateresourceInvalidformat = 0x2E2,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDSUBRESOURCERANGE")]
        GetcopyablefootprintsInvalidsubresourcerange = 0x2E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDBASEOFFSET")]
        GetcopyablefootprintsInvalidbaseoffset = 0x2E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDSUBRESOURCERANGE")]
        GetcopyablelayoutInvalidsubresourcerange = 0x2E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDBASEOFFSET")]
        GetcopyablelayoutInvalidbaseoffset = 0x2E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_HEAP")]
        ResourceBarrierInvalidHeap = 0x2E5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SAMPLER_INVALID")]
        CreateSamplerInvalid = 0x2E6,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMMANDSIGNATURE_INVALID")]
        CreatecommandsignatureInvalid = 0x2E7,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_INDIRECT_INVALID_PARAMETERS")]
        ExecuteIndirectInvalidParameters = 0x2E8,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_RESOURCE_DIMENSION")]
        GetgpuvirtualaddressInvalidResourceDimension = 0x2E9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUE")]
        CreateresourceInvalidclearvalue = 0x32F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDCLEARVALUEFORMAT")]
        CreateresourceUnrecognizedclearvalueformat = 0x330,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUEFORMAT")]
        CreateresourceInvalidclearvalueformat = 0x331,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_CLEARVALUEDENORMFLUSH")]
        CreateresourceClearvaluedenormflush = 0x332,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARRENDERTARGETVIEW_MISMATCHINGCLEARVALUE")]
        ClearrendertargetviewMismatchingclearvalue = 0x334,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_MISMATCHINGCLEARVALUE")]
        CleardepthstencilviewMismatchingclearvalue = 0x335,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDHEAP")]
        MapInvalidheap = 0x336,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDHEAP")]
        UnmapInvalidheap = 0x337,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDRESOURCE")]
        MapInvalidresource = 0x338,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDRESOURCE")]
        UnmapInvalidresource = 0x339,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDSUBRESOURCE")]
        MapInvalidsubresource = 0x33A,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDSUBRESOURCE")]
        UnmapInvalidsubresource = 0x33B,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDRANGE")]
        MapInvalidrange = 0x33C,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDRANGE")]
        UnmapInvalidrange = 0x33D,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDDATAPOINTER")]
        MapInvaliddatapointer = 0x340,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDARG_RETURN")]
        MapInvalidargReturn = 0x341,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_OUTOFMEMORY_RETURN")]
        MapOutofmemoryReturn = 0x342,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_BUNDLENOTSUPPORTED")]
        ExecutecommandlistsBundlenotsupported = 0x343,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_COMMANDLISTMISMATCH")]
        ExecutecommandlistsCommandlistmismatch = 0x344,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_OPENCOMMANDLIST")]
        ExecutecommandlistsOpencommandlist = 0x345,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_FAILEDCOMMANDLIST")]
        ExecutecommandlistsFailedcommandlist = 0x346,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLDST")]
        CopybufferregionNulldst = 0x347,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDDSTRESOURCEDIMENSION")]
        CopybufferregionInvaliddstresourcedimension = 0x348,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_DSTRANGEOUTOFBOUNDS")]
        CopybufferregionDstrangeoutofbounds = 0x349,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLSRC")]
        CopybufferregionNullsrc = 0x34A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDSRCRESOURCEDIMENSION")]
        CopybufferregionInvalidsrcresourcedimension = 0x34B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_SRCRANGEOUTOFBOUNDS")]
        CopybufferregionSrcrangeoutofbounds = 0x34C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDCOPYFLAGS")]
        CopybufferregionInvalidcopyflags = 0x34D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLDST")]
        CopytextureregionNulldst = 0x34E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTTYPE")]
        CopytextureregionUnrecognizeddsttype = 0x34F,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCEDIMENSION")]
        CopytextureregionInvaliddstresourcedimension = 0x350,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCE")]
        CopytextureregionInvaliddstresource = 0x351,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTSUBRESOURCE")]
        CopytextureregionInvaliddstsubresource = 0x352,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTOFFSET")]
        CopytextureregionInvaliddstoffset = 0x353,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTFORMAT")]
        CopytextureregionUnrecognizeddstformat = 0x354,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTFORMAT")]
        CopytextureregionInvaliddstformat = 0x355,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDIMENSIONS")]
        CopytextureregionInvaliddstdimensions = 0x356,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTROWPITCH")]
        CopytextureregionInvaliddstrowpitch = 0x357,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTPLACEMENT")]
        CopytextureregionInvaliddstplacement = 0x358,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDSPLACEDFOOTPRINTFORMAT")]
        CopytextureregionInvaliddstdsplacedfootprintformat = 0x359,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_DSTREGIONOUTOFBOUNDS")]
        CopytextureregionDstregionoutofbounds = 0x35A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLSRC")]
        CopytextureregionNullsrc = 0x35B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCTYPE")]
        CopytextureregionUnrecognizedsrctype = 0x35C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCEDIMENSION")]
        CopytextureregionInvalidsrcresourcedimension = 0x35D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCE")]
        CopytextureregionInvalidsrcresource = 0x35E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCSUBRESOURCE")]
        CopytextureregionInvalidsrcsubresource = 0x35F,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCOFFSET")]
        CopytextureregionInvalidsrcoffset = 0x360,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCFORMAT")]
        CopytextureregionUnrecognizedsrcformat = 0x361,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCFORMAT")]
        CopytextureregionInvalidsrcformat = 0x362,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDIMENSIONS")]
        CopytextureregionInvalidsrcdimensions = 0x363,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCROWPITCH")]
        CopytextureregionInvalidsrcrowpitch = 0x364,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCPLACEMENT")]
        CopytextureregionInvalidsrcplacement = 0x365,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDSPLACEDFOOTPRINTFORMAT")]
        CopytextureregionInvalidsrcdsplacedfootprintformat = 0x366,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_SRCREGIONOUTOFBOUNDS")]
        CopytextureregionSrcregionoutofbounds = 0x367,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTCOORDINATES")]
        CopytextureregionInvaliddstcoordinates = 0x368,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCBOX")]
        CopytextureregionInvalidsrcbox = 0x369,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_FORMATMISMATCH")]
        CopytextureregionFormatmismatch = 0x36A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_EMPTYBOX")]
        CopytextureregionEmptybox = 0x36B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDCOPYFLAGS")]
        CopytextureregionInvalidcopyflags = 0x36C,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SUBRESOURCE_INDEX")]
        ResolvesubresourceInvalidSubresourceIndex = 0x36D,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_FORMAT")]
        ResolvesubresourceInvalidFormat = 0x36E,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_MISMATCH")]
        ResolvesubresourceResourceMismatch = 0x36F,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SAMPLE_COUNT")]
        ResolvesubresourceInvalidSampleCount = 0x370,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_INVALID_SHADER")]
        CreatecomputepipelinestateInvalidShader = 0x371,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_CS_ROOT_SIGNATURE_MISMATCH")]
        CreatecomputepipelinestateCSRootSignatureMismatch = 0x372,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_MISSING_ROOT_SIGNATURE")]
        CreatecomputepipelinestateMissingRootSignature = 0x373,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALIDCACHEDBLOB")]
        CreatepipelinestateInvalidcachedblob = 0x374,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBADAPTERMISMATCH")]
        CreatepipelinestateCachedblobadaptermismatch = 0x375,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDRIVERVERSIONMISMATCH")]
        CreatepipelinestateCachedblobdriverversionmismatch = 0x376,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDESCMISMATCH")]
        CreatepipelinestateCachedblobdescmismatch = 0x377,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBIGNORED")]
        CreatepipelinestateCachedblobignored = 0x378,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDHEAP")]
        WritetosubresourceInvalidheap = 0x379,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDRESOURCE")]
        WritetosubresourceInvalidresource = 0x37A,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDBOX")]
        WritetosubresourceInvalidbox = 0x37B,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDSUBRESOURCE")]
        WritetosubresourceInvalidsubresource = 0x37C,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_EMPTYBOX")]
        WritetosubresourceEmptybox = 0x37D,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDHEAP")]
        ReadfromsubresourceInvalidheap = 0x37E,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDRESOURCE")]
        ReadfromsubresourceInvalidresource = 0x37F,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDBOX")]
        ReadfromsubresourceInvalidbox = 0x380,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDSUBRESOURCE")]
        ReadfromsubresourceInvalidsubresource = 0x381,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_EMPTYBOX")]
        ReadfromsubresourceEmptybox = 0x382,
        [NativeName("Name", "D3D12_MESSAGE_ID_TOO_MANY_NODES_SPECIFIED")]
        TooManyNodesSpecified = 0x383,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_NODE_INDEX")]
        InvalidNodeIndex = 0x384,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETHEAPPROPERTIES_INVALIDRESOURCE")]
        GetheappropertiesInvalidresource = 0x385,
        [NativeName("Name", "D3D12_MESSAGE_ID_NODE_MASK_MISMATCH")]
        NodeMaskMismatch = 0x386,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_OUTOFMEMORY")]
        CommandListOutofmemory = 0x387,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_MULTIPLE_SWAPCHAIN_BUFFER_REFERENCES")]
        CommandListMultipleSwapchainBufferReferences = 0x388,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_TOO_MANY_SWAPCHAIN_REFERENCES")]
        CommandListTooManySwapchainReferences = 0x389,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_QUEUE_TOO_MANY_SWAPCHAIN_REFERENCES")]
        CommandQueueTooManySwapchainReferences = 0x38A,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_WRONGSWAPCHAINBUFFERREFERENCE")]
        ExecutecommandlistsWrongswapchainbufferreference = 0x38B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_SETRENDERTARGETS_INVALIDNUMRENDERTARGETS")]
        CommandListSetrendertargetsInvalidnumrendertargets = 0x38C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_TYPE")]
        CreateQueueInvalidType = 0x38D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_FLAGS")]
        CreateQueueInvalidFlags = 0x38E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFLAGS")]
        CreatesharedresourceInvalidflags = 0x38F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFORMAT")]
        CreatesharedresourceInvalidformat = 0x390,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDHEAP_INVALIDFLAGS")]
        CreatesharedheapInvalidflags = 0x391,
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_UNRECOGNIZEDPROPERTIES")]
        ReflectsharedpropertiesUnrecognizedproperties = 0x392,
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDSIZE")]
        ReflectsharedpropertiesInvalidsize = 0x393,
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDOBJECT")]
        ReflectsharedpropertiesInvalidobject = 0x394,
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDOBJECT")]
        KeyedmutexInvalidobject = 0x395,
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDKEY")]
        KeyedmutexInvalidkey = 0x396,
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_WRONGSTATE")]
        KeyedmutexWrongstate = 0x397,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_PRIORITY")]
        CreateQueueInvalidPriority = 0x398,
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_DELETED_WHILE_STILL_IN_USE")]
        ObjectDeletedWhileStillInUse = 0x399,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_FLAGS")]
        CreatepipelinestateInvalidFlags = 0x39A,
        [NativeName("Name", "D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_HAS_NO_RESOURCE")]
        HeapAddressRangeHasNoResource = 0x39B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_RENDER_TARGET_DELETED")]
        CommandListDrawRenderTargetDeleted = 0x39C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_ALL_RENDER_TARGETS_HAVE_UNKNOWN_FORMAT")]
        CreategraphicspipelinestateAllRenderTargetsHaveUnknownFormat = 0x39D,
        [NativeName("Name", "D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_INTERSECTS_MULTIPLE_BUFFERS")]
        HeapAddressRangeIntersectsMultipleBuffers = 0x39E,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_GPU_WRITTEN_READBACK_RESOURCE_MAPPED")]
        ExecutecommandlistsGpuWrittenReadbackResourceMapped = 0x39F,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_RANGE_NOT_EMPTY")]
        UnmapRangeNotEmpty = 0x3A1,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALID_NULLRANGE")]
        MapInvalidNullrange = 0x3A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALID_NULLRANGE")]
        UnmapInvalidNullrange = 0x3A3,
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_GRAPHICS_API_SUPPORT")]
        NoGraphicsApiSupport = 0x3A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_COMPUTE_API_SUPPORT")]
        NoComputeApiSupport = 0x3A5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_FLAGS_NOT_SUPPORTED")]
        ResolvesubresourceResourceFlagsNotSupported = 0x3A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_ARGUMENT_UNINITIALIZED")]
        GpuBasedValidationRootArgumentUninitialized = 0x3A7,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_HEAP_INDEX_OUT_OF_BOUNDS")]
        GpuBasedValidationDescriptorHeapIndexOutOfBounds = 0x3A8,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TABLE_REGISTER_INDEX_OUT_OF_BOUNDS")]
        GpuBasedValidationDescriptorTableRegisterIndexOutOfBounds = 0x3A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_UNINITIALIZED")]
        GpuBasedValidationDescriptorUninitialized = 0x3AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TYPE_MISMATCH")]
        GpuBasedValidationDescriptorTypeMismatch = 0x3AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SRV_RESOURCE_DIMENSION_MISMATCH")]
        GpuBasedValidationSrvResourceDimensionMismatch = 0x3AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UAV_RESOURCE_DIMENSION_MISMATCH")]
        GpuBasedValidationUavResourceDimensionMismatch = 0x3AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_RESOURCE_STATE")]
        GpuBasedValidationIncompatibleResourceState = 0x3AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_NULLDST")]
        CopyresourceNulldst = 0x3AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDDSTRESOURCE")]
        CopyresourceInvaliddstresource = 0x3B0,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_NULLSRC")]
        CopyresourceNullsrc = 0x3B1,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDSRCRESOURCE")]
        CopyresourceInvalidsrcresource = 0x3B2,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLDST")]
        ResolvesubresourceNulldst = 0x3B3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDDSTRESOURCE")]
        ResolvesubresourceInvaliddstresource = 0x3B4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLSRC")]
        ResolvesubresourceNullsrc = 0x3B5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDSRCRESOURCE")]
        ResolvesubresourceInvalidsrcresource = 0x3B6,
        [NativeName("Name", "D3D12_MESSAGE_ID_PIPELINE_STATE_TYPE_MISMATCH")]
        PipelineStateTypeMismatch = 0x3B7,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_NOT_SET")]
        CommandListDispatchRootSignatureNotSet = 0x3B8,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_MISMATCH")]
        CommandListDispatchRootSignatureMismatch = 0x3B9,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_ZERO_BARRIERS")]
        ResourceBarrierZeroBarriers = 0x3BA,
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_END_EVENT_MISMATCH")]
        BeginEndEventMismatch = 0x3BB,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_POSSIBLE_BEFORE_AFTER_MISMATCH")]
        ResourceBarrierPossibleBeforeAfterMismatch = 0x3BC,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_BEGIN_END")]
        ResourceBarrierMismatchingBeginEnd = 0x3BD,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INVALID_RESOURCE")]
        GpuBasedValidationInvalidResource = 0x3BE,
        [NativeName("Name", "D3D12_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT")]
        UseOfZeroRefcountObject = 0x3BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_EVICTED_WHILE_STILL_IN_USE")]
        ObjectEvictedWhileStillInUse = 0x3C0,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_DESCRIPTOR_ACCESS_OUT_OF_BOUNDS")]
        GpuBasedValidationRootDescriptorAccessOutOfBounds = 0x3C1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_INVALIDLIBRARYBLOB")]
        CreatepipelinelibraryInvalidlibraryblob = 0x3C2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_DRIVERVERSIONMISMATCH")]
        CreatepipelinelibraryDriverversionmismatch = 0x3C3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_ADAPTERVERSIONMISMATCH")]
        CreatepipelinelibraryAdapterversionmismatch = 0x3C4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_UNSUPPORTED")]
        CreatepipelinelibraryUnsupported = 0x3C5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PIPELINELIBRARY")]
        CreatePipelinelibrary = 0x3C6,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PIPELINELIBRARY")]
        LivePipelinelibrary = 0x3C7,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PIPELINELIBRARY")]
        DestroyPipelinelibrary = 0x3C8,
        [NativeName("Name", "D3D12_MESSAGE_ID_STOREPIPELINE_NONAME")]
        StorepipelineNoname = 0x3C9,
        [NativeName("Name", "D3D12_MESSAGE_ID_STOREPIPELINE_DUPLICATENAME")]
        StorepipelineDuplicatename = 0x3CA,
        [NativeName("Name", "D3D12_MESSAGE_ID_LOADPIPELINE_NAMENOTFOUND")]
        LoadpipelineNamenotfound = 0x3CB,
        [NativeName("Name", "D3D12_MESSAGE_ID_LOADPIPELINE_INVALIDDESC")]
        LoadpipelineInvaliddesc = 0x3CC,
        [NativeName("Name", "D3D12_MESSAGE_ID_PIPELINELIBRARY_SERIALIZE_NOTENOUGHMEMORY")]
        PipelinelibrarySerializeNotenoughmemory = 0x3CD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_RT_OUTPUT_MISMATCH")]
        CreategraphicspipelinestatePSOutputRTOutputMismatch = 0x3CE,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETEVENTONMULTIPLEFENCECOMPLETION_INVALIDFLAGS")]
        SeteventonmultiplefencecompletionInvalidflags = 0x3CF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_VIDEO_NOT_SUPPORTED")]
        CreateQueueVideoNotSupported = 0x3D0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_ALLOCATOR_VIDEO_NOT_SUPPORTED")]
        CreateCommandAllocatorVideoNotSupported = 0x3D1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_VIDEO_DECODE_STATISTICS_NOT_SUPPORTED")]
        CreatequeryHeapVideoDecodeStatisticsNotSupported = 0x3D2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDLIST")]
        CreateVideodecodecommandlist = 0x3D3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODER")]
        CreateVideodecoder = 0x3D4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODESTREAM")]
        CreateVideodecodestream = 0x3D5,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDLIST")]
        LiveVideodecodecommandlist = 0x3D6,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODER")]
        LiveVideodecoder = 0x3D7,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODESTREAM")]
        LiveVideodecodestream = 0x3D8,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDLIST")]
        DestroyVideodecodecommandlist = 0x3D9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODER")]
        DestroyVideodecoder = 0x3DA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODESTREAM")]
        DestroyVideodecodestream = 0x3DB,
        [NativeName("Name", "D3D12_MESSAGE_ID_DECODE_FRAME_INVALID_PARAMETERS")]
        DecodeFrameInvalidParameters = 0x3DC,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPRECATED_API")]
        DeprecatedApi = 0x3DD,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_COMMAND_LIST_TYPE")]
        ResourceBarrierMismatchingCommandListType = 0x3DE,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DESCRIPTOR_TABLE_NOT_SET")]
        CommandListDescriptorTableNotSet = 0x3DF,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_CONSTANT_BUFFER_VIEW_NOT_SET")]
        CommandListRootConstantBufferViewNotSet = 0x3E0,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_SHADER_RESOURCE_VIEW_NOT_SET")]
        CommandListRootShaderResourceViewNotSet = 0x3E1,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_UNORDERED_ACCESS_VIEW_NOT_SET")]
        CommandListRootUnorderedAccessViewNotSet = 0x3E2,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_INVALID_SUBRESOURCE_RANGE")]
        DiscardInvalidSubresourceRange = 0x3E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_ONE_SUBRESOURCE_FOR_MIPS_WITH_RECTS")]
        DiscardOneSubresourceForMipsWithRects = 0x3E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_NO_RECTS_FOR_NON_TEXTURE2D")]
        DiscardNoRectsForNonTexture2D = 0x3E5,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_ON_SAME_SUBRESOURCE")]
        CopyOnSameSubresource = 0x3E6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PAGEABLE")]
        SetresidencypriorityInvalidPageable = 0x3E7,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UNSUPPORTED")]
        GpuBasedValidationUnsupported = 0x3E8,
        [NativeName("Name", "D3D12_MESSAGE_ID_STATIC_DESCRIPTOR_INVALID_DESCRIPTOR_CHANGE")]
        StaticDescriptorInvalidDescriptorChange = 0x3E9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DATA_STATIC_DESCRIPTOR_INVALID_DATA_CHANGE")]
        DataStaticDescriptorInvalidDataChange = 0x3EA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DATA_STATIC_WHILE_SET_AT_EXECUTE_DESCRIPTOR_INVALID_DATA_CHANGE")]
        DataStaticWhileSetATExecuteDescriptorInvalidDataChange = 0x3EB,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_STATIC_DESCRIPTOR_DATA_STATIC_NOT_SET")]
        ExecuteBundleStaticDescriptorDataStaticNotSet = 0x3EC,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_ACCESS_OUT_OF_BOUNDS")]
        GpuBasedValidationResourceAccessOutOfBounds = 0x3ED,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SAMPLER_MODE_MISMATCH")]
        GpuBasedValidationSamplerModeMismatch = 0x3EE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_FENCE_INVALID_FLAGS")]
        CreateFenceInvalidFlags = 0x3EF,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_DUPLICATE_SUBRESOURCE_TRANSITIONS")]
        ResourceBarrierDuplicateSubresourceTransitions = 0x3F0,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PRIORITY")]
        SetresidencypriorityInvalidPriority = 0x3F1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_LARGE_NUM_DESCRIPTORS")]
        CreateDescriptorHeapLargeNumDescriptors = 0x3F5,
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_EVENT")]
        BeginEvent = 0x3F6,
        [NativeName("Name", "D3D12_MESSAGE_ID_END_EVENT")]
        EndEvent = 0x3F7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_DEBUG_LAYER_STARTUP_OPTIONS")]
        CreatedeviceDebugLayerStartupOptions = 0x3F8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_DEPTHBOUNDSTEST_UNSUPPORTED")]
        CreatedepthstencilstateDepthboundstestUnsupported = 0x3F9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_DUPLICATE_SUBOBJECT")]
        CreatepipelinestateDuplicateSubobject = 0x3FA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_UNKNOWN_SUBOBJECT")]
        CreatepipelinestateUnknownSubobject = 0x3FB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_ZERO_SIZE_STREAM")]
        CreatepipelinestateZeroSizeStream = 0x3FC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_STREAM")]
        CreatepipelinestateInvalidStream = 0x3FD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CANNOT_DEDUCE_TYPE")]
        CreatepipelinestateCannotDeduceType = 0x3FE,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_RESOURCE_DIMENSION_MISMATCH")]
        CommandListStaticDescriptorResourceDimensionMismatch = 0x3FF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_PRIVILEGE_FOR_GLOBAL_REALTIME")]
        CreateCommandQueueInsufficientPrivilegeForGlobalRealtime = 0x400,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_HARDWARE_SUPPORT_FOR_GLOBAL_REALTIME")]
        CreateCommandQueueInsufficientHardwareSupportForGlobalRealtime = 0x401,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_ARCHITECTURE")]
        AtomiccopybufferInvalidArchitecture = 0x402,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DST")]
        AtomiccopybufferNullDst = 0x403,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE_DIMENSION")]
        AtomiccopybufferInvalidDstResourceDimension = 0x404,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DST_RANGE_OUT_OF_BOUNDS")]
        AtomiccopybufferDstRangeOutOfBounds = 0x405,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_SRC")]
        AtomiccopybufferNullSrc = 0x406,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE_DIMENSION")]
        AtomiccopybufferInvalidSrcResourceDimension = 0x407,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_SRC_RANGE_OUT_OF_BOUNDS")]
        AtomiccopybufferSrcRangeOutOfBounds = 0x408,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_OFFSET_ALIGNMENT")]
        AtomiccopybufferInvalidOffsetAlignment = 0x409,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_RESOURCES")]
        AtomiccopybufferNullDependentResources = 0x40A,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_SUBRESOURCE_RANGES")]
        AtomiccopybufferNullDependentSubresourceRanges = 0x40B,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_RESOURCE")]
        AtomiccopybufferInvalidDependentResource = 0x40C,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_SUBRESOURCE_RANGE")]
        AtomiccopybufferInvalidDependentSubresourceRange = 0x40D,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_SUBRESOURCE_OUT_OF_BOUNDS")]
        AtomiccopybufferDependentSubresourceOutOfBounds = 0x40E,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_RANGE_OUT_OF_BOUNDS")]
        AtomiccopybufferDependentRangeOutOfBounds = 0x40F,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_ZERO_DEPENDENCIES")]
        AtomiccopybufferZeroDependencies = 0x410,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATE_SHARED_HANDLE_INVALIDARG")]
        DeviceCreateSharedHandleInvalidarg = 0x411,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESCRIPTOR_HANDLE_WITH_INVALID_RESOURCE")]
        DescriptorHandleWithInvalidResource = 0x412,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETDEPTHBOUNDS_INVALIDARGS")]
        SetdepthboundsInvalidargs = 0x413,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_STATE_IMPRECISE")]
        GpuBasedValidationResourceStateImprecise = 0x414,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_PIPELINE_STATE_NOT_SET")]
        CommandListPipelineStateNotSet = 0x415,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_MODEL_MISMATCH")]
        CreategraphicspipelinestateShaderModelMismatch = 0x416,
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_ACCESSED_WHILE_STILL_IN_USE")]
        ObjectAccessedWhileStillInUse = 0x417,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROGRAMMABLE_MSAA_UNSUPPORTED")]
        ProgrammableMsaaUnsupported = 0x418,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETSAMPLEPOSITIONS_INVALIDARGS")]
        SetsamplepositionsInvalidargs = 0x419,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCEREGION_INVALID_RECT")]
        ResolvesubresourceregionInvalidRect = 0x41A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDQUEUE")]
        CreateVideodecodecommandqueue = 0x41B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDLIST")]
        CreateVideoprocesscommandlist = 0x41C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDQUEUE")]
        CreateVideoprocesscommandqueue = 0x41D,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDQUEUE")]
        LiveVideodecodecommandqueue = 0x41E,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDLIST")]
        LiveVideoprocesscommandlist = 0x41F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDQUEUE")]
        LiveVideoprocesscommandqueue = 0x420,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDQUEUE")]
        DestroyVideodecodecommandqueue = 0x421,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDLIST")]
        DestroyVideoprocesscommandlist = 0x422,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDQUEUE")]
        DestroyVideoprocesscommandqueue = 0x423,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSOR")]
        CreateVideoprocessor = 0x424,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSSTREAM")]
        CreateVideoprocessstream = 0x425,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSOR")]
        LiveVideoprocessor = 0x426,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSSTREAM")]
        LiveVideoprocessstream = 0x427,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSOR")]
        DestroyVideoprocessor = 0x428,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSSTREAM")]
        DestroyVideoprocessstream = 0x429,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROCESS_FRAME_INVALID_PARAMETERS")]
        ProcessFrameInvalidParameters = 0x42A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_INVALIDLAYOUT")]
        CopyInvalidlayout = 0x42B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION")]
        CreateCryptoSession = 0x42C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION_POLICY")]
        CreateCryptoSessionPolicy = 0x42D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION")]
        CreateProtectedResourceSession = 0x42E,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION")]
        LiveCryptoSession = 0x42F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION_POLICY")]
        LiveCryptoSessionPolicy = 0x430,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PROTECTED_RESOURCE_SESSION")]
        LiveProtectedResourceSession = 0x431,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION")]
        DestroyCryptoSession = 0x432,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION_POLICY")]
        DestroyCryptoSessionPolicy = 0x433,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PROTECTED_RESOURCE_SESSION")]
        DestroyProtectedResourceSession = 0x434,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROTECTED_RESOURCE_SESSION_UNSUPPORTED")]
        ProtectedResourceSessionUnsupported = 0x435,
        [NativeName("Name", "D3D12_MESSAGE_ID_FENCE_INVALIDOPERATION")]
        FenceInvalidoperation = 0x436,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_COPY_QUEUE_TIMESTAMPS_NOT_SUPPORTED")]
        CreatequeryHeapCopyQueueTimestampsNotSupported = 0x437,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_DEFERRED")]
        SamplepositionsMismatchDeferred = 0x438,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMFIRSTUSE")]
        SamplepositionsMismatchRecordtimeAssumedfromfirstuse = 0x439,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMCLEAR")]
        SamplepositionsMismatchRecordtimeAssumedfromclear = 0x43A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODERHEAP")]
        CreateVideodecoderheap = 0x43B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODERHEAP")]
        LiveVideodecoderheap = 0x43C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODERHEAP")]
        DestroyVideodecoderheap = 0x43D,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDARG_RETURN")]
        OpenexistingheapInvalidargReturn = 0x43E,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_OUTOFMEMORY_RETURN")]
        OpenexistingheapOutofmemoryReturn = 0x43F,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDADDRESS")]
        OpenexistingheapInvalidaddress = 0x440,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDHANDLE")]
        OpenexistingheapInvalidhandle = 0x441,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_DEST")]
        WritebufferimmediateInvalidDest = 0x442,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_MODE")]
        WritebufferimmediateInvalidMode = 0x443,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_ALIGNMENT")]
        WritebufferimmediateInvalidAlignment = 0x444,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_NOT_SUPPORTED")]
        WritebufferimmediateNotSupported = 0x445,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETVIEWINSTANCEMASK_INVALIDARGS")]
        SetviewinstancemaskInvalidargs = 0x446,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIEW_INSTANCING_UNSUPPORTED")]
        ViewInstancingUnsupported = 0x447,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIEW_INSTANCING_INVALIDARGS")]
        ViewInstancingInvalidargs = 0x448,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_DECODE_REFERENCE_ONLY_FLAG")]
        CopytextureregionMismatchDecodeReferenceOnlyFlag = 0x449,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_DECODE_REFERENCE_ONLY_FLAG")]
        CopyresourceMismatchDecodeReferenceOnlyFlag = 0x44A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_FAILURE")]
        CreateVideoDecodeHeapCapsFailure = 0x44B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_UNSUPPORTED")]
        CreateVideoDecodeHeapCapsUnsupported = 0x44C,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_INVALID_INPUT")]
        VideoDecodeSupportInvalidInput = 0x44D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODER_UNSUPPORTED")]
        CreateVideoDecoderUnsupported = 0x44E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_METADATA_ERROR")]
        CreategraphicspipelinestateMetadataError = 0x44F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VIEW_INSTANCING_VERTEX_SIZE_EXCEEDED")]
        CreategraphicspipelinestateViewInstancingVertexSizeExceeded = 0x450,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RUNTIME_INTERNAL_ERROR")]
        CreategraphicspipelinestateRuntimeInternalError = 0x451,
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_VIDEO_API_SUPPORT")]
        NoVideoApiSupport = 0x452,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_INVALID_INPUT")]
        VideoProcessSupportInvalidInput = 0x453,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_PROCESSOR_CAPS_FAILURE")]
        CreateVideoProcessorCapsFailure = 0x454,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_UNSUPPORTED_FORMAT")]
        VideoProcessSupportUnsupportedFormat = 0x455,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_FRAME_INVALID_ARGUMENT")]
        VideoDecodeFrameInvalidArgument = 0x456,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENQUEUE_MAKE_RESIDENT_INVALID_FLAGS")]
        EnqueueMakeResidentInvalidFlags = 0x457,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_UNSUPPORTED")]
        OpenexistingheapUnsupported = 0x458,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_FRAMES_INVALID_ARGUMENT")]
        VideoProcessFramesInvalidArgument = 0x459,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_UNSUPPORTED")]
        VideoDecodeSupportUnsupported = 0x45A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDRECORDER")]
        CreateCommandrecorder = 0x45B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDRECORDER")]
        LiveCommandrecorder = 0x45C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDRECORDER")]
        DestroyCommandrecorder = 0x45D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_VIDEO_NOT_SUPPORTED")]
        CreateCommandRecorderVideoNotSupported = 0x45E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_SUPPORT_FLAGS")]
        CreateCommandRecorderInvalidSupportFlags = 0x45F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_FLAGS")]
        CreateCommandRecorderInvalidFlags = 0x460,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_MORE_RECORDERS_THAN_LOGICAL_PROCESSORS")]
        CreateCommandRecorderMoreRecordersThanLogicalProcessors = 0x461,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDPOOL")]
        CreateCommandpool = 0x462,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDPOOL")]
        LiveCommandpool = 0x463,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDPOOL")]
        DestroyCommandpool = 0x464,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_POOL_INVALID_FLAGS")]
        CreateCommandPoolInvalidFlags = 0x465,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_VIDEO_NOT_SUPPORTED")]
        CreateCommandListVideoNotSupported = 0x466,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_SUPPORT_FLAGS_MISMATCH")]
        CommandRecorderSupportFlagsMismatch = 0x467,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_CONTENTION")]
        CommandRecorderContention = 0x468,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_USAGE_WITH_CREATECOMMANDLIST_COMMAND_LIST")]
        CommandRecorderUsageWithCreatecommandlistCommandList = 0x469,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_USAGE_WITH_CREATECOMMANDLIST1_COMMAND_LIST")]
        CommandAllocatorUsageWithCreatecommandlist1CommandList = 0x46A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_EXECUTE_EMPTY_COMMAND_LIST")]
        CannotExecuteEmptyCommandList = 0x46B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_RESET_COMMAND_POOL_WITH_OPEN_COMMAND_LISTS")]
        CannotResetCommandPoolWithOpenCommandLists = 0x46C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_USE_COMMAND_RECORDER_WITHOUT_CURRENT_TARGET")]
        CannotUseCommandRecorderWithoutCurrentTarget = 0x46D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_CHANGE_COMMAND_RECORDER_TARGET_WHILE_RECORDING")]
        CannotChangeCommandRecorderTargetWhileRecording = 0x46E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_POOL_SYNC")]
        CommandPoolSync = 0x46F,
        [NativeName("Name", "D3D12_MESSAGE_ID_EVICT_UNDERFLOW")]
        EvictUnderflow = 0x470,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_META_COMMAND")]
        CreateMetaCommand = 0x471,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_META_COMMAND")]
        LiveMetaCommand = 0x472,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_META_COMMAND")]
        DestroyMetaCommand = 0x473,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_DST_RESOURCE")]
        CopybufferregionInvalidDstResource = 0x474,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_SRC_RESOURCE")]
        CopybufferregionInvalidSrcResource = 0x475,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE")]
        AtomiccopybufferInvalidDstResource = 0x476,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE")]
        AtomiccopybufferInvalidSrcResource = 0x477,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_BUFFER")]
        CreateplacedresourceonbufferNullBuffer = 0x478,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_RESOURCE_DESC")]
        CreateplacedresourceonbufferNullResourceDesc = 0x479,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_UNSUPPORTED")]
        CreateplacedresourceonbufferUnsupported = 0x47A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_DIMENSION")]
        CreateplacedresourceonbufferInvalidBufferDimension = 0x47B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_FLAGS")]
        CreateplacedresourceonbufferInvalidBufferFlags = 0x47C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_OFFSET")]
        CreateplacedresourceonbufferInvalidBufferOffset = 0x47D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_DIMENSION")]
        CreateplacedresourceonbufferInvalidResourceDimension = 0x47E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_FLAGS")]
        CreateplacedresourceonbufferInvalidResourceFlags = 0x47F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_OUTOFMEMORY_RETURN")]
        CreateplacedresourceonbufferOutofmemoryReturn = 0x480,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_CREATE_GRAPHICS_AND_VIDEO_COMMAND_RECORDER")]
        CannotCreateGraphicsAndVideoCommandRecorder = 0x481,
        [NativeName("Name", "D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_POSSIBLY_MISMATCHING_PROPERTIES")]
        UpdatetilemappingsPossiblyMismatchingProperties = 0x482,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE")]
        CreateCommandListInvalidCommandListType = 0x483,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INCOMPATIBLE_WITH_STRUCTURED_BUFFERS")]
        ClearunorderedaccessviewIncompatibleWithStructuredBuffers = 0x484,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMPUTE_ONLY_DEVICE_OPERATION_UNSUPPORTED")]
        ComputeOnlyDeviceOperationUnsupported = 0x485,
        [NativeName("Name", "D3D12_MESSAGE_ID_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INVALID")]
        BuildRaytracingAccelerationStructureInvalid = 0x486,
        [NativeName("Name", "D3D12_MESSAGE_ID_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_INVALID")]
        EmitRaytracingAccelerationStructurePostbuildInfoInvalid = 0x487,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_RAYTRACING_ACCELERATION_STRUCTURE_INVALID")]
        CopyRaytracingAccelerationStructureInvalid = 0x488,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISPATCH_RAYS_INVALID")]
        DispatchRaysInvalid = 0x489,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO_INVALID")]
        GetRaytracingAccelerationStructurePrebuildInfoInvalid = 0x48A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_LIFETIMETRACKER")]
        CreateLifetimetracker = 0x48B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_LIFETIMETRACKER")]
        LiveLifetimetracker = 0x48C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_LIFETIMETRACKER")]
        DestroyLifetimetracker = 0x48D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROYOWNEDOBJECT_OBJECTNOTOWNED")]
        DestroyownedobjectObjectnotowned = 0x48E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_TRACKEDWORKLOAD")]
        CreateTrackedworkload = 0x48F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_TRACKEDWORKLOAD")]
        LiveTrackedworkload = 0x490,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD")]
        DestroyTrackedworkload = 0x491,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_ERROR")]
        RenderPassError = 0x492,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_ID_INVALID")]
        MetaCommandIDInvalid = 0x493,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_UNSUPPORTED_PARAMS")]
        MetaCommandUnsupportedParams = 0x494,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_FAILED_ENUMERATION")]
        MetaCommandFailedEnumeration = 0x495,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_PARAMETER_SIZE_MISMATCH")]
        MetaCommandParameterSizeMismatch = 0x496,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNINITIALIZED_META_COMMAND")]
        UninitializedMetaCommand = 0x497,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_INVALID_GPU_VIRTUAL_ADDRESS")]
        MetaCommandInvalidGpuVirtualAddress = 0x498,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDLIST")]
        CreateVideoencodecommandlist = 0x499,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDLIST")]
        LiveVideoencodecommandlist = 0x49A,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDLIST")]
        DestroyVideoencodecommandlist = 0x49B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDQUEUE")]
        CreateVideoencodecommandqueue = 0x49C,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDQUEUE")]
        LiveVideoencodecommandqueue = 0x49D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDQUEUE")]
        DestroyVideoencodecommandqueue = 0x49E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONESTIMATOR")]
        CreateVideomotionestimator = 0x49F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONESTIMATOR")]
        LiveVideomotionestimator = 0x4A0,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONESTIMATOR")]
        DestroyVideomotionestimator = 0x4A1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONVECTORHEAP")]
        CreateVideomotionvectorheap = 0x4A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONVECTORHEAP")]
        LiveVideomotionvectorheap = 0x4A3,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONVECTORHEAP")]
        DestroyVideomotionvectorheap = 0x4A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS")]
        MultipleTrackedWorkloads = 0x4A5,
        [NativeName("Name", "D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS")]
        MultipleTrackedWorkloadPairs = 0x4A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR")]
        OutOfOrderTrackedWorkloadPair = 0x4A7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD")]
        CannotAddTrackedWorkload = 0x4A8,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR")]
        IncompleteTrackedWorkloadPair = 0x4A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_STATE_OBJECT_ERROR")]
        CreateStateObjectError = 0x4AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_ERROR")]
        GetShaderIdentifierError = 0x4AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_STACK_SIZE_ERROR")]
        GetShaderStackSizeError = 0x4AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_PIPELINE_STACK_SIZE_ERROR")]
        GetPipelineStackSizeError = 0x4AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PIPELINE_STACK_SIZE_ERROR")]
        SetPipelineStackSizeError = 0x4AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_SIZE_INVALID")]
        GetShaderIdentifierSizeInvalid = 0x4AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_INVALID")]
        CheckDriverMatchingIdentifierInvalid = 0x4B0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_DRIVER_REPORTED_ISSUE")]
        CheckDriverMatchingIdentifierDriverReportedIssue = 0x4B1,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_INVALID_RESOURCE_BARRIER")]
        RenderPassInvalidResourceBarrier = 0x4B2,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_DISALLOWED_API_CALLED")]
        RenderPassDisallowedApiCalled = 0x4B3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_NEST_RENDER_PASSES")]
        RenderPassCannotNestRenderPasses = 0x4B4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_END_WITHOUT_BEGIN")]
        RenderPassCannotEndWithoutBegin = 0x4B5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_CLOSE_COMMAND_LIST")]
        RenderPassCannotCloseCommandList = 0x4B6,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_GPU_WORK_WHILE_SUSPENDED")]
        RenderPassGpuWorkWhileSuspended = 0x4B7,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_SUSPEND_RESUME")]
        RenderPassMismatchingSuspendResume = 0x4B8,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_NO_PRIOR_SUSPEND_WITHIN_EXECUTECOMMANDLISTS")]
        RenderPassNoPriorSuspendWithinExecutecommandlists = 0x4B9,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_NO_SUBSEQUENT_RESUME_WITHIN_EXECUTECOMMANDLISTS")]
        RenderPassNoSubsequentResumeWithinExecutecommandlists = 0x4BA,
        [NativeName("Name", "D3D12_MESSAGE_ID_TRACKED_WORKLOAD_COMMAND_QUEUE_MISMATCH")]
        TrackedWorkloadCommandQueueMismatch = 0x4BB,
        [NativeName("Name", "D3D12_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED")]
        TrackedWorkloadNotSupported = 0x4BC,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_NO_ACCESS")]
        RenderPassMismatchingNoAccess = 0x4BD,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_UNSUPPORTED_RESOLVE")]
        RenderPassUnsupportedResolve = 0x4BE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INVALID_RESOURCE_PTR")]
        ClearunorderedaccessviewInvalidResourcePtr = 0x4BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_SIGNAL")]
        Windows7FenceOutoforderSignal = 0x4C0,
        [NativeName("Name", "D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_WAIT")]
        Windows7FenceOutoforderWait = 0x4C1,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_ESTIMATOR_INVALID_ARGUMENT")]
        VideoCreateMotionEstimatorInvalidArgument = 0x4C2,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT")]
        VideoCreateMotionVectorHeapInvalidArgument = 0x4C3,
        [NativeName("Name", "D3D12_MESSAGE_ID_ESTIMATE_MOTION_INVALID_ARGUMENT")]
        EstimateMotionInvalidArgument = 0x4C4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT")]
        ResolveMotionVectorHeapInvalidArgument = 0x4C5,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_HEAP_TYPE")]
        GetgpuvirtualaddressInvalidHeapType = 0x4C6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_BACKGROUND_PROCESSING_MODE_INVALID_ARGUMENT")]
        SetBackgroundProcessingModeInvalidArgument = 0x4C7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE_FOR_FEATURE_LEVEL")]
        CreateCommandListInvalidCommandListTypeForFeatureLevel = 0x4C8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOEXTENSIONCOMMAND")]
        CreateVideoextensioncommand = 0x4C9,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOEXTENSIONCOMMAND")]
        LiveVideoextensioncommand = 0x4CA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOEXTENSIONCOMMAND")]
        DestroyVideoextensioncommand = 0x4CB,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_VIDEO_EXTENSION_COMMAND_ID")]
        InvalidVideoExtensionCommandID = 0x4CC,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_EXTENSION_COMMAND_INVALID_ARGUMENT")]
        VideoExtensionCommandInvalidArgument = 0x4CD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_UNIQUE_IN_DXIL_LIBRARY")]
        CreateRootSignatureNotUniqueInDxilLibrary = 0x4CE,
        [NativeName("Name", "D3D12_MESSAGE_ID_VARIABLE_SHADING_RATE_NOT_ALLOWED_WITH_TIR")]
        VariableShadingRateNotAllowedWithTir = 0x4CF,
        [NativeName("Name", "D3D12_MESSAGE_ID_GEOMETRY_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        GeometryShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4D0,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_SHADING_RATE")]
        RssetshadingRateInvalidShadingRate = 0x4D1,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_SHADING_RATE_NOT_PERMITTED_BY_CAP")]
        RssetshadingRateShadingRateNotPermittedByCap = 0x4D2,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_COMBINER")]
        RssetshadingRateInvalidCombiner = 0x4D3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADINGRATEIMAGE_REQUIRES_TIER_2")]
        RssetshadingrateimageRequiresTier2 = 0x4D4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADINGRATE_REQUIRES_TIER_1")]
        RssetshadingrateRequiresTier1 = 0x4D5,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_FORMAT")]
        ShadingRateImageIncorrectFormat = 0x4D6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_ARRAY_SIZE")]
        ShadingRateImageIncorrectArraySize = 0x4D7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_MIP_LEVEL")]
        ShadingRateImageIncorrectMipLevel = 0x4D8,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_COUNT")]
        ShadingRateImageIncorrectSampleCount = 0x4D9,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_QUALITY")]
        ShadingRateImageIncorrectSampleQuality = 0x4DA,
        [NativeName("Name", "D3D12_MESSAGE_ID_NON_RETAIL_SHADER_MODEL_WONT_VALIDATE")]
        NonRetailShaderModelWontValidate = 0x4DB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateAsRootSignatureMismatch = 0x4DC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_ROOT_SIGNATURE_MISMATCH")]
        CreategraphicspipelinestateMSRootSignatureMismatch = 0x4DD,
        [NativeName("Name", "D3D12_MESSAGE_ID_ADD_TO_STATE_OBJECT_ERROR")]
        AddToStateObjectError = 0x4DE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION_INVALID_ARGUMENT")]
        CreateProtectedResourceSessionInvalidArgument = 0x4DF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_PSO_DESC_MISMATCH")]
        CreategraphicspipelinestateMSPsoDescMismatch = 0x4E0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_MS_INCOMPLETE_TYPE")]
        CreatepipelinestateMSIncompleteType = 0x4E1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_NOT_MS_MISMATCH")]
        CreategraphicspipelinestateAsNotMSMismatch = 0x4E2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_NOT_PS_MISMATCH")]
        CreategraphicspipelinestateMSNotPSMismatch = 0x4E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_NONZERO_SAMPLER_FEEDBACK_MIP_REGION_WITH_INCOMPATIBLE_FORMAT")]
        NonzeroSamplerFeedbackMipRegionWithIncompatibleFormat = 0x4E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_SHADER_MISMATCH")]
        CreategraphicspipelinestateInputlayoutShaderMismatch = 0x4E5,
        [NativeName("Name", "D3D12_MESSAGE_ID_EMPTY_DISPATCH")]
        EmptyDispatch = 0x4E6,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_FORMAT_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY")]
        ResourceFormatRequiresSamplerFeedbackCapability = 0x4E7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_MIP_REGION")]
        SamplerFeedbackMapInvalidMipRegion = 0x4E8,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_DIMENSION")]
        SamplerFeedbackMapInvalidDimension = 0x4E9,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_COUNT")]
        SamplerFeedbackMapInvalidSampleCount = 0x4EA,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_QUALITY")]
        SamplerFeedbackMapInvalidSampleQuality = 0x4EB,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_LAYOUT")]
        SamplerFeedbackMapInvalidLayout = 0x4EC,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_REQUIRES_UNORDERED_ACCESS_FLAG")]
        SamplerFeedbackMapRequiresUnorderedAccessFlag = 0x4ED,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_NULL_ARGUMENTS")]
        SamplerFeedbackCreateUavNullArguments = 0x4EE,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_UAV_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY")]
        SamplerFeedbackUavRequiresSamplerFeedbackCapability = 0x4EF,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_REQUIRES_FEEDBACK_MAP_FORMAT")]
        SamplerFeedbackCreateUavRequiresFeedbackMapFormat = 0x4F0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_INVALIDSHADERBYTECODE")]
        CreatemeshshaderInvalidshaderbytecode = 0x4F1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTOFMEMORY")]
        CreatemeshshaderOutofmemory = 0x4F2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        CreatemeshshaderwithstreamoutputInvalidshadertype = 0x4F3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_INVALID_FORMAT")]
        ResolvesubresourceSamplerFeedbackTranscodeInvalidFormat = 0x4F4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_INVALID_MIP_LEVEL_COUNT")]
        ResolvesubresourceSamplerFeedbackInvalidMipLevelCount = 0x4F5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_ARRAY_SIZE_MISMATCH")]
        ResolvesubresourceSamplerFeedbackTranscodeArraySizeMismatch = 0x4F6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_MISMATCHING_TARGETED_RESOURCE")]
        SamplerFeedbackCreateUavMismatchingTargetedResource = 0x4F7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTPUTEXCEEDSMAXSIZE")]
        CreatemeshshaderOutputexceedsmaxsize = 0x4F8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_GROUPSHAREDEXCEEDSMAXSIZE")]
        CreatemeshshaderGroupsharedexceedsmaxsize = 0x4F9,
        [NativeName("Name", "D3D12_MESSAGE_ID_VERTEX_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        VertexShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4FA,
        [NativeName("Name", "D3D12_MESSAGE_ID_MESH_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MeshShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4FB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_MISMATCHEDASMSPAYLOADSIZE")]
        CreatemeshshaderMismatchedasmspayloadsize = 0x4FC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_UNBOUNDED_STATIC_DESCRIPTORS")]
        CreateRootSignatureUnboundedStaticDescriptors = 0x4FD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_INVALIDSHADERBYTECODE")]
        CreateamplificationshaderInvalidshaderbytecode = 0x4FE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_OUTOFMEMORY")]
        CreateamplificationshaderOutofmemory = 0x4FF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SHADERCACHESESSION")]
        CreateShadercachesession = 0x500,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_SHADERCACHESESSION")]
        LiveShadercachesession = 0x501,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_SHADERCACHESESSION")]
        DestroyShadercachesession = 0x502,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_INVALIDARGS")]
        CreateshadercachesessionInvalidargs = 0x503,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_DISABLED")]
        CreateshadercachesessionDisabled = 0x504,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_ALREADYOPEN")]
        CreateshadercachesessionAlreadyopen = 0x505,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_DEVELOPERMODE")]
        ShadercachecontrolDevelopermode = 0x506,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_INVALIDFLAGS")]
        ShadercachecontrolInvalidflags = 0x507,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_STATEALREADYSET")]
        ShadercachecontrolStatealreadyset = 0x508,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_IGNOREDFLAG")]
        ShadercachecontrolIgnoredflag = 0x509,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_ALREADYPRESENT")]
        ShadercachesessionStorevalueAlreadypresent = 0x50A,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_HASHCOLLISION")]
        ShadercachesessionStorevalueHashcollision = 0x50B,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_CACHEFULL")]
        ShadercachesessionStorevalueCachefull = 0x50C,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_FINDVALUE_NOTFOUND")]
        ShadercachesessionFindvalueNotfound = 0x50D,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_CORRUPT")]
        ShadercachesessionCorrupt = 0x50E,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_DISABLED")]
        ShadercachesessionDisabled = 0x50F,
        [NativeName("Name", "D3D12_MESSAGE_ID_OVERSIZED_DISPATCH")]
        OversizedDispatch = 0x510,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODER")]
        CreateVideoencoder = 0x511,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODER")]
        LiveVideoencoder = 0x512,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODER")]
        DestroyVideoencoder = 0x513,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODERHEAP")]
        CreateVideoencoderheap = 0x514,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODERHEAP")]
        LiveVideoencoderheap = 0x515,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODERHEAP")]
        DestroyVideoencoderheap = 0x516,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG")]
        CopytextureregionMismatchEncodeReferenceOnlyFlag = 0x517,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG")]
        CopyresourceMismatchEncodeReferenceOnlyFlag = 0x518,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENCODE_FRAME_INVALID_PARAMETERS")]
        EncodeFrameInvalidParameters = 0x519,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENCODE_FRAME_UNSUPPORTED_PARAMETERS")]
        EncodeFrameUnsupportedParameters = 0x51A,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_INVALID_PARAMETERS")]
        ResolveEncoderOutputMetadataInvalidParameters = 0x51B,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_UNSUPPORTED_PARAMETERS")]
        ResolveEncoderOutputMetadataUnsupportedParameters = 0x51C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_INVALID_PARAMETERS")]
        CreateVideoEncoderInvalidParameters = 0x51D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_UNSUPPORTED_PARAMETERS")]
        CreateVideoEncoderUnsupportedParameters = 0x51E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_INVALID_PARAMETERS")]
        CreateVideoEncoderHeapInvalidParameters = 0x51F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_UNSUPPORTED_PARAMETERS")]
        CreateVideoEncoderHeapUnsupportedParameters = 0x520,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMMANDLIST_NULL_COMMANDALLOCATOR")]
        CreatecommandlistNullCommandallocator = 0x521,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEAR_UNORDERED_ACCESS_VIEW_INVALID_DESCRIPTOR_HANDLE")]
        ClearUnorderedAccessViewInvalidDescriptorHandle = 0x522,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESCRIPTOR_HEAP_NOT_SHADER_VISIBLE")]
        DescriptorHeapNotShaderVisible = 0x523,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOP_WARNING")]
        CreateblendstateBlendopWarning = 0x524,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOPALPHA_WARNING")]
        CreateblendstateBlendopalphaWarning = 0x525,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITE_COMBINE_PERFORMANCE_WARNING")]
        WriteCombinePerformanceWarning = 0x526,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_QUERY_INVALID_QUERY_STATE")]
        ResolveQueryInvalidQueryState = 0x527,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_NO_ACCESS")]
        SetprivatedataNoAccess = 0x528,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_SAMPLER_MODE_MISMATCH")]
        CommandListStaticDescriptorSamplerModeMismatch = 0x529,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_UNSUPPORTED_BUFFER_WIDTH")]
        GetcopyablefootprintsUnsupportedBufferWidth = 0x52A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_TOPOLOGY_MISMATCH")]
        CreatemeshshaderTopologyMismatch = 0x52B,
        [NativeName("Name", "D3D12_MESSAGE_ID_VRS_SUM_COMBINER_REQUIRES_CAPABILITY")]
        VrsSumCombinerRequiresCapability = 0x52C,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETTING_SHADING_RATE_FROM_MS_REQUIRES_CAPABILITY")]
        SettingShadingRateFromMSRequiresCapability = 0x52D,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_SHADERCACHEDELETE_NOTSUPPORTED")]
        ShadercachesessionShadercachedeleteNotsupported = 0x52E,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_SHADERCACHECLEAR_NOTSUPPORTED")]
        ShadercachecontrolShadercacheclearNotsupported = 0x52F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_STATE_IGNORED")]
        CreateresourceStateIgnored = 0x530,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNUSED_CROSS_EXECUTE_SPLIT_BARRIER")]
        UnusedCrossExecuteSplitBarrier = 0x531,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_OPEN_SHARED_HANDLE_ACCESS_DENIED")]
        DeviceOpenSharedHandleAccessDenied = 0x532,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_VALUES")]
        IncompatibleBarrierValues = 0x533,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_ACCESS")]
        IncompatibleBarrierAccess = 0x534,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_SYNC")]
        IncompatibleBarrierSync = 0x535,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_LAYOUT")]
        IncompatibleBarrierLayout = 0x536,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_TYPE")]
        IncompatibleBarrierType = 0x537,
        [NativeName("Name", "D3D12_MESSAGE_ID_OUT_OF_BOUNDS_BARRIER_SUBRESOURCE_RANGE")]
        OutOfBoundsBarrierSubresourceRange = 0x538,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPATIBLE_BARRIER_RESOURCE_DIMENSION")]
        IncompatibleBarrierResourceDimension = 0x539,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_SCISSOR_RECTS_INVALID_RECT")]
        SetScissorRectsInvalidRect = 0x53A,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_SOURCE_REQUIRES_DIMENSION_TEXTURE2D")]
        ShadingRateSourceRequiresDimensionTexture2D = 0x53B,
        [NativeName("Name", "D3D12_MESSAGE_ID_BUFFER_BARRIER_SUBREGION_OUT_OF_BOUNDS")]
        BufferBarrierSubregionOutOfBounds = 0x53C,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNSUPPORTED_BARRIER_LAYOUT")]
        UnsupportedBarrierLayout = 0x53D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALID_PARAMETERS")]
        CreateresourceandheapInvalidParameters = 0x53E,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENHANCED_BARRIERS_NOT_SUPPORTED")]
        EnhancedBarriersNotSupported = 0x53F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LEGACY_BARRIER_VALIDATION_FORCED_ON")]
        LegacyBarrierValidationForcedOn = 0x542,
        [NativeName("Name", "D3D12_MESSAGE_ID_EMPTY_ROOT_DESCRIPTOR_TABLE")]
        EmptyRootDescriptorTable = 0x543,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ELEMENT_OFFSET_UNALIGNED")]
        CommandListDrawElementOffsetUnaligned = 0x544,
        [NativeName("Name", "D3D12_MESSAGE_ID_ALPHA_BLEND_FACTOR_NOT_SUPPORTED")]
        AlphaBlendFactorNotSupported = 0x545,
        [NativeName("Name", "D3D12_MESSAGE_ID_BARRIER_INTEROP_INVALID_LAYOUT")]
        BarrierInteropInvalidLayout = 0x546,
        [NativeName("Name", "D3D12_MESSAGE_ID_BARRIER_INTEROP_INVALID_STATE")]
        BarrierInteropInvalidState = 0x547,
        [NativeName("Name", "D3D12_MESSAGE_ID_GRAPHICS_PIPELINE_STATE_DESC_ZERO_SAMPLE_MASK")]
        GraphicsPipelineStateDescZeroSampleMask = 0x548,
        [NativeName("Name", "D3D12_MESSAGE_ID_INDEPENDENT_STENCIL_REF_NOT_SUPPORTED")]
        IndependentStencilRefNotSupported = 0x549,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INDEPENDENT_MASKS_UNSUPPORTED")]
        CreatedepthstencilstateIndependentMasksUnsupported = 0x54A,
        [NativeName("Name", "D3D12_MESSAGE_ID_TEXTURE_BARRIER_SUBRESOURCES_OUT_OF_BOUNDS")]
        TextureBarrierSubresourcesOutOfBounds = 0x54B,
        [NativeName("Name", "D3D12_MESSAGE_ID_NON_OPTIMAL_BARRIER_ONLY_EXECUTE_COMMAND_LISTS")]
        NonOptimalBarrierOnlyExecuteCommandLists = 0x54C,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_INDIRECT_ZERO_COMMAND_COUNT")]
        ExecuteIndirectZeroCommandCount = 0x54D,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_TEXTURE_LAYOUT")]
        GpuBasedValidationIncompatibleTextureLayout = 0x54E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_NOT_SUPPORTED")]
        DynamicIndexBufferStripCutNotSupported = 0x54F,
        [NativeName("Name", "D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_TRIANGLE_FANS_NOT_SUPPORTED")]
        PrimitiveTopologyTriangleFansNotSupported = 0x550,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SAMPLER_COMPARISON_FUNC_IGNORED")]
        CreateSamplerComparisonFuncIgnored = 0x551,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDHEAPTYPE")]
        CreateheapInvalidheaptype = 0x552,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPTYPE")]
        CreateresourceandheapInvalidheaptype = 0x553,
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_NOT_SUPPORTED")]
        DynamicDepthBiasNotSupported = 0x554,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_NON_WHOLE_DYNAMIC_DEPTH_BIAS")]
        CreaterasterizerstateNonWholeDynamicDepthBias = 0x555,
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_FLAG_MISSING")]
        DynamicDepthBiasFlagMissing = 0x556,
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_DEPTH_BIAS_NO_PIPELINE")]
        DynamicDepthBiasNoPipeline = 0x557,
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_FLAG_MISSING")]
        DynamicIndexBufferStripCutFlagMissing = 0x558,
        [NativeName("Name", "D3D12_MESSAGE_ID_DYNAMIC_INDEX_BUFFER_STRIP_CUT_NO_PIPELINE")]
        DynamicIndexBufferStripCutNoPipeline = 0x559,
        [NativeName("Name", "D3D12_MESSAGE_ID_NONNORMALIZED_COORDINATE_SAMPLING_NOT_SUPPORTED")]
        NonnormalizedCoordinateSamplingNotSupported = 0x55A,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_CAST_TARGET")]
        InvalidCastTarget = 0x55B,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_COMMANDLIST_INVALID_END_STATE")]
        RenderPassCommandlistInvalidEndState = 0x55C,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_COMMANDLIST_INVALID_START_STATE")]
        RenderPassCommandlistInvalidStartState = 0x55D,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_ACCESS")]
        RenderPassMismatchingAccess = 0x55E,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_LOCAL_PRESERVE_PARAMETERS")]
        RenderPassMismatchingLocalPreserveParameters = 0x55F,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_LOCAL_PRESERVE_RENDER_PARAMETERS_ERROR")]
        RenderPassLocalPreserveRenderParametersError = 0x560,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_LOCAL_DEPTH_STENCIL_ERROR")]
        RenderPassLocalDepthStencilError = 0x561,
        [NativeName("Name", "D3D12_MESSAGE_ID_DRAW_POTENTIALLY_OUTSIDE_OF_VALID_RENDER_AREA")]
        DrawPotentiallyOutsideOfValidRenderArea = 0x562,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_LINERASTERIZATIONMODE")]
        CreaterasterizerstateInvalidLinerasterizationmode = 0x563,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT_SMALLRESOURCE")]
        CreateresourceInvalidalignmentSmallresource = 0x564,
        [NativeName("Name", "D3D12_MESSAGE_ID_GENERIC_DEVICE_OPERATION_UNSUPPORTED")]
        GenericDeviceOperationUnsupported = 0x565,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDER_TARGET_WRONG_WRITE_MASK")]
        CreategraphicspipelinestateRenderTargetWrongWriteMask = 0x566,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROBABLE_PIX_EVENT_LEAK")]
        ProbablePixEventLeak = 0x567,
        [NativeName("Name", "D3D12_MESSAGE_ID_PIX_EVENT_UNDERFLOW")]
        PixEventUnderflow = 0x568,
        [NativeName("Name", "D3D12_MESSAGE_ID_RECREATEAT_INVALID_TARGET")]
        RecreateatInvalidTarget = 0x569,
        [NativeName("Name", "D3D12_MESSAGE_ID_RECREATEAT_INSUFFICIENT_SUPPORT")]
        RecreateatInsufficientSupport = 0x56A,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_STRUCTURED_BUFFER_STRIDE_MISMATCH")]
        GpuBasedValidationStructuredBufferStrideMismatch = 0x56B,
        [NativeName("Name", "D3D12_MESSAGE_ID_D3D12_MESSAGES_END")]
        D3D12MessagesEnd = 0x56C,
    }
}
