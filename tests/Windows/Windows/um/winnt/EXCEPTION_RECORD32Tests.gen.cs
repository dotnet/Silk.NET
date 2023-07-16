// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EXCEPTION_RECORD32"/> struct.</summary>
public static unsafe partial class EXCEPTION_RECORD32Tests
{
    /// <summary>Validates that the <see cref = "EXCEPTION_RECORD32"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EXCEPTION_RECORD32>(), Is.EqualTo(sizeof(EXCEPTION_RECORD32)));
    }

    /// <summary>Validates that the <see cref = "EXCEPTION_RECORD32"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EXCEPTION_RECORD32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EXCEPTION_RECORD32"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EXCEPTION_RECORD32), Is.EqualTo(80));
    }
}