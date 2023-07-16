// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CERT_DH_PARAMETERS"/> struct.</summary>
public static unsafe partial class CERT_DH_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "CERT_DH_PARAMETERS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CERT_DH_PARAMETERS>(), Is.EqualTo(sizeof(CERT_DH_PARAMETERS)));
    }

    /// <summary>Validates that the <see cref = "CERT_DH_PARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CERT_DH_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CERT_DH_PARAMETERS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CERT_DH_PARAMETERS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CERT_DH_PARAMETERS), Is.EqualTo(16));
        }
    }
}