// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.MFNETSOURCE;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFNETSOURCE"/> class.</summary>
public static partial class MFNETSOURCETests
{
    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_SSLCERTIFICATE_MANAGER"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_SSLCERTIFICATE_MANAGERTest()
    {
        Assert.That(MFNETSOURCE_SSLCERTIFICATE_MANAGER, Is.EqualTo(new Guid(0x55e6cb27, 0xe69b, 0x4267, 0x94, 0x0c, 0x2d, 0x7e, 0xc5, 0xbb, 0x8a, 0x0f)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_RESOURCE_FILTER"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_RESOURCE_FILTERTest()
    {
        Assert.That(MFNETSOURCE_RESOURCE_FILTER, Is.EqualTo(new Guid(0x815d0ff6, 0x265a, 0x4477, 0x9e, 0x46, 0x7b, 0x80, 0xad, 0x80, 0xb5, 0xfb)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_STATISTICS_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_STATISTICS_SERVICETest()
    {
        Assert.That(MFNETSOURCE_STATISTICS_SERVICE, Is.EqualTo(new Guid(0x3cb1f275, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_STATISTICS"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_STATISTICSTest()
    {
        Assert.That(MFNETSOURCE_STATISTICS, Is.EqualTo(new Guid(0x3cb1f274, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_BUFFERINGTIME"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_BUFFERINGTIMETest()
    {
        Assert.That(MFNETSOURCE_BUFFERINGTIME, Is.EqualTo(new Guid(0x3cb1f276, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ACCELERATEDSTREAMINGDURATION"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ACCELERATEDSTREAMINGDURATIONTest()
    {
        Assert.That(MFNETSOURCE_ACCELERATEDSTREAMINGDURATION, Is.EqualTo(new Guid(0x3cb1f277, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATIONTest()
    {
        Assert.That(MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION, Is.EqualTo(new Guid(0x4aab2879, 0xbbe1, 0x4994, 0x9f, 0xf0, 0x54, 0x95, 0xbd, 0x25, 0x1, 0x29)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_MAXBUFFERTIMEMS"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_MAXBUFFERTIMEMSTest()
    {
        Assert.That(MFNETSOURCE_MAXBUFFERTIMEMS, Is.EqualTo(new Guid(0x408b24e6, 0x4038, 0x4401, 0xb5, 0xb2, 0xfe, 0x70, 0x1a, 0x9e, 0xbf, 0x10)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_CONNECTIONBANDWIDTH"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_CONNECTIONBANDWIDTHTest()
    {
        Assert.That(MFNETSOURCE_CONNECTIONBANDWIDTH, Is.EqualTo(new Guid(0x3cb1f278, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_CACHEENABLED"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_CACHEENABLEDTest()
    {
        Assert.That(MFNETSOURCE_CACHEENABLED, Is.EqualTo(new Guid(0x3cb1f279, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_AUTORECONNECTLIMIT"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_AUTORECONNECTLIMITTest()
    {
        Assert.That(MFNETSOURCE_AUTORECONNECTLIMIT, Is.EqualTo(new Guid(0x3cb1f27a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_RESENDSENABLED"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_RESENDSENABLEDTest()
    {
        Assert.That(MFNETSOURCE_RESENDSENABLED, Is.EqualTo(new Guid(0x3cb1f27b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_THINNINGENABLED"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_THINNINGENABLEDTest()
    {
        Assert.That(MFNETSOURCE_THINNINGENABLED, Is.EqualTo(new Guid(0x3cb1f27c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROTOCOL"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROTOCOLTest()
    {
        Assert.That(MFNETSOURCE_PROTOCOL, Is.EqualTo(new Guid(0x3cb1f27d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_TRANSPORT"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_TRANSPORTTest()
    {
        Assert.That(MFNETSOURCE_TRANSPORT, Is.EqualTo(new Guid(0x3cb1f27e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PREVIEWMODEENABLED"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PREVIEWMODEENABLEDTest()
    {
        Assert.That(MFNETSOURCE_PREVIEWMODEENABLED, Is.EqualTo(new Guid(0x3cb1f27f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_CREDENTIAL_MANAGER"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_CREDENTIAL_MANAGERTest()
    {
        Assert.That(MFNETSOURCE_CREDENTIAL_MANAGER, Is.EqualTo(new Guid(0x3cb1f280, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PPBANDWIDTH"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PPBANDWIDTHTest()
    {
        Assert.That(MFNETSOURCE_PPBANDWIDTH, Is.EqualTo(new Guid(0x3cb1f281, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_AUTORECONNECTPROGRESS"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_AUTORECONNECTPROGRESSTest()
    {
        Assert.That(MFNETSOURCE_AUTORECONNECTPROGRESS, Is.EqualTo(new Guid(0x3cb1f282, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYLOCATORFACTORY"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYLOCATORFACTORYTest()
    {
        Assert.That(MFNETSOURCE_PROXYLOCATORFACTORY, Is.EqualTo(new Guid(0x3cb1f283, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_BROWSERUSERAGENT"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_BROWSERUSERAGENTTest()
    {
        Assert.That(MFNETSOURCE_BROWSERUSERAGENT, Is.EqualTo(new Guid(0x3cb1f28b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_BROWSERWEBPAGE"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_BROWSERWEBPAGETest()
    {
        Assert.That(MFNETSOURCE_BROWSERWEBPAGE, Is.EqualTo(new Guid(0x3cb1f28c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PLAYERVERSION"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PLAYERVERSIONTest()
    {
        Assert.That(MFNETSOURCE_PLAYERVERSION, Is.EqualTo(new Guid(0x3cb1f28d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PLAYERID"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PLAYERIDTest()
    {
        Assert.That(MFNETSOURCE_PLAYERID, Is.EqualTo(new Guid(0x3cb1f28e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_HOSTEXE"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_HOSTEXETest()
    {
        Assert.That(MFNETSOURCE_HOSTEXE, Is.EqualTo(new Guid(0x3cb1f28f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_HOSTVERSION"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_HOSTVERSIONTest()
    {
        Assert.That(MFNETSOURCE_HOSTVERSION, Is.EqualTo(new Guid(0x3cb1f291, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PLAYERUSERAGENT"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PLAYERUSERAGENTTest()
    {
        Assert.That(MFNETSOURCE_PLAYERUSERAGENT, Is.EqualTo(new Guid(0x3cb1f292, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_CLIENTGUID"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_CLIENTGUIDTest()
    {
        Assert.That(MFNETSOURCE_CLIENTGUID, Is.EqualTo(new Guid(0x60a2c4a6, 0xf197, 0x4c14, 0xa5, 0xbf, 0x88, 0x83, 0xd, 0x24, 0x58, 0xaf)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_LOGURL"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_LOGURLTest()
    {
        Assert.That(MFNETSOURCE_LOGURL, Is.EqualTo(new Guid(0x3cb1f293, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_UDP"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_UDPTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_UDP, Is.EqualTo(new Guid(0x3cb1f294, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_TCP"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_TCPTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_TCP, Is.EqualTo(new Guid(0x3cb1f295, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_MSB"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_MSBTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_MSB, Is.EqualTo(new Guid(0x3cb1f296, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_RTSP"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_RTSPTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_RTSP, Is.EqualTo(new Guid(0x3cb1f298, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_HTTP"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_HTTPTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_HTTP, Is.EqualTo(new Guid(0x3cb1f299, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_STREAMING"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_STREAMINGTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_STREAMING, Is.EqualTo(new Guid(0x3cb1f29c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_DOWNLOAD"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_DOWNLOADTest()
    {
        Assert.That(MFNETSOURCE_ENABLE_DOWNLOAD, Is.EqualTo(new Guid(0x3cb1f29d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_ENABLE_PRIVATEMODE"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_ENABLE_PRIVATEMODETest()
    {
        Assert.That(MFNETSOURCE_ENABLE_PRIVATEMODE, Is.EqualTo(new Guid(0x824779d8, 0xf18b, 0x4405, 0x8c, 0xf1, 0x46, 0x4f, 0xb5, 0xaa, 0x8f, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_UDP_PORT_RANGE"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_UDP_PORT_RANGETest()
    {
        Assert.That(MFNETSOURCE_UDP_PORT_RANGE, Is.EqualTo(new Guid(0x3cb1f29a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYINFO"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYINFOTest()
    {
        Assert.That(MFNETSOURCE_PROXYINFO, Is.EqualTo(new Guid(0x3cb1f29b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_DRMNET_LICENSE_REPRESENTATIONTest()
    {
        Assert.That(MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION, Is.EqualTo(new Guid(0x47eae1bd, 0xbdfe, 0x42e2, 0x82, 0xf3, 0x54, 0xa4, 0x8c, 0x17, 0x96, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYSETTINGS"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYSETTINGSTest()
    {
        Assert.That(MFNETSOURCE_PROXYSETTINGS, Is.EqualTo(new Guid(0x3cb1f287, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYHOSTNAME"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYHOSTNAMETest()
    {
        Assert.That(MFNETSOURCE_PROXYHOSTNAME, Is.EqualTo(new Guid(0x3cb1f284, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYPORT"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYPORTTest()
    {
        Assert.That(MFNETSOURCE_PROXYPORT, Is.EqualTo(new Guid(0x3cb1f288, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYEXCEPTIONLIST"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYEXCEPTIONLISTTest()
    {
        Assert.That(MFNETSOURCE_PROXYEXCEPTIONLIST, Is.EqualTo(new Guid(0x3cb1f285, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYBYPASSFORLOCAL"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYBYPASSFORLOCALTest()
    {
        Assert.That(MFNETSOURCE_PROXYBYPASSFORLOCAL, Is.EqualTo(new Guid(0x3cb1f286, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PROXYRERUNAUTODETECTION"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PROXYRERUNAUTODETECTIONTest()
    {
        Assert.That(MFNETSOURCE_PROXYRERUNAUTODETECTION, Is.EqualTo(new Guid(0x3cb1f289, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_STREAM_LANGUAGE"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_STREAM_LANGUAGETest()
    {
        Assert.That(MFNETSOURCE_STREAM_LANGUAGE, Is.EqualTo(new Guid(0x9ab44318, 0xf7cd, 0x4f2d, 0x8d, 0x6d, 0xfa, 0x35, 0xb4, 0x92, 0xce, 0xcb)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_LOGPARAMS"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_LOGPARAMSTest()
    {
        Assert.That(MFNETSOURCE_LOGPARAMS, Is.EqualTo(new Guid(0x64936ae8, 0x9418, 0x453a, 0x8c, 0xda, 0x3e, 0xa, 0x66, 0x8b, 0x35, 0x3b)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_PEERMANAGER"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_PEERMANAGERTest()
    {
        Assert.That(MFNETSOURCE_PEERMANAGER, Is.EqualTo(new Guid(0x48b29adb, 0xfebf, 0x45ee, 0xa9, 0xbf, 0xef, 0xb8, 0x1c, 0x49, 0x2e, 0xfc)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_FRIENDLYNAME"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_FRIENDLYNAMETest()
    {
        Assert.That(MFNETSOURCE_FRIENDLYNAME, Is.EqualTo(new Guid(0x5b2a7757, 0xbc6b, 0x447e, 0xaa, 0x06, 0x0d, 0xda, 0x1c, 0x64, 0x6e, 0x2f)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_CROSS_ORIGIN_SUPPORT"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_CROSS_ORIGIN_SUPPORTTest()
    {
        Assert.That(MFNETSOURCE_CROSS_ORIGIN_SUPPORT, Is.EqualTo(new Guid(0x9842207c, 0xb02c, 0x4271, 0xa2, 0xfc, 0x72, 0xe4, 0x93, 0x8, 0xe5, 0xc2)));
    }

    /// <summary>Validates that the value of the <see cref = "MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER"/> property is correct.</summary>
    [Test]
    public static void MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDERTest()
    {
        Assert.That(MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER, Is.EqualTo(new Guid(0x7d55081e, 0x307d, 0x4d6d, 0xa6, 0x63, 0xa9, 0x3b, 0xe9, 0x7c, 0x4b, 0x5c)));
    }
}