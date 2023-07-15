// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WS_SERVICE_SECURITY_IDENTITIES"/> struct.</summary>
public static unsafe partial class WS_SERVICE_SECURITY_IDENTITIESTests
{
    /// <summary>Validates that the <see cref = "WS_SERVICE_SECURITY_IDENTITIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WS_SERVICE_SECURITY_IDENTITIES>(), Is.EqualTo(sizeof(WS_SERVICE_SECURITY_IDENTITIES)));
    }

    /// <summary>Validates that the <see cref = "WS_SERVICE_SECURITY_IDENTITIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_SERVICE_SECURITY_IDENTITIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_SERVICE_SECURITY_IDENTITIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WS_SERVICE_SECURITY_IDENTITIES), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WS_SERVICE_SECURITY_IDENTITIES), Is.EqualTo(8));
        }
    }
}