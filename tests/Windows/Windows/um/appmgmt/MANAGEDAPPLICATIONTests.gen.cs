// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MANAGEDAPPLICATION"/> struct.</summary>
public static unsafe partial class MANAGEDAPPLICATIONTests
{
    /// <summary>Validates that the <see cref = "MANAGEDAPPLICATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MANAGEDAPPLICATION>(), Is.EqualTo(sizeof(MANAGEDAPPLICATION)));
    }

    /// <summary>Validates that the <see cref = "MANAGEDAPPLICATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MANAGEDAPPLICATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MANAGEDAPPLICATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MANAGEDAPPLICATION), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(MANAGEDAPPLICATION), Is.EqualTo(88));
        }
    }
}