// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PROVDATA_SIP"/> struct.</summary>
public static unsafe partial class PROVDATA_SIPTests
{
    /// <summary>Validates that the <see cref = "PROVDATA_SIP"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROVDATA_SIP>(), Is.EqualTo(sizeof(PROVDATA_SIP)));
    }

    /// <summary>Validates that the <see cref = "PROVDATA_SIP"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROVDATA_SIP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROVDATA_SIP"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROVDATA_SIP), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(PROVDATA_SIP), Is.EqualTo(40));
        }
    }
}
