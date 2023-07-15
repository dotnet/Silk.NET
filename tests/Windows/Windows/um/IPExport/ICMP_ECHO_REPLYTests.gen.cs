// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ICMP_ECHO_REPLY"/> struct.</summary>
public static unsafe partial class ICMP_ECHO_REPLYTests
{
    /// <summary>Validates that the <see cref = "ICMP_ECHO_REPLY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICMP_ECHO_REPLY>(), Is.EqualTo(sizeof(ICMP_ECHO_REPLY)));
    }

    /// <summary>Validates that the <see cref = "ICMP_ECHO_REPLY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICMP_ECHO_REPLY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICMP_ECHO_REPLY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICMP_ECHO_REPLY), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ICMP_ECHO_REPLY), Is.EqualTo(28));
        }
    }
}