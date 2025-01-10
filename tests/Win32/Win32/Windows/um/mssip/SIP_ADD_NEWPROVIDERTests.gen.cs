// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SIP_ADD_NEWPROVIDER"/> struct.</summary>
public static unsafe partial class SIP_ADD_NEWPROVIDERTests
{
    /// <summary>Validates that the <see cref = "SIP_ADD_NEWPROVIDER"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SIP_ADD_NEWPROVIDER>(), Is.EqualTo(sizeof(SIP_ADD_NEWPROVIDER)));
    }

    /// <summary>Validates that the <see cref = "SIP_ADD_NEWPROVIDER"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIP_ADD_NEWPROVIDER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIP_ADD_NEWPROVIDER"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SIP_ADD_NEWPROVIDER), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(SIP_ADD_NEWPROVIDER), Is.EqualTo(48));
        }
    }
}
