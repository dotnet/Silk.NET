// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLEANLOCALSTORAGE"/> struct.</summary>
public static unsafe partial class CLEANLOCALSTORAGETests
{
    /// <summary>Validates that the <see cref = "CLEANLOCALSTORAGE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CLEANLOCALSTORAGE>(), Is.EqualTo(sizeof(CLEANLOCALSTORAGE)));
    }

    /// <summary>Validates that the <see cref = "CLEANLOCALSTORAGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CLEANLOCALSTORAGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CLEANLOCALSTORAGE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CLEANLOCALSTORAGE), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CLEANLOCALSTORAGE), Is.EqualTo(12));
        }
    }
}
