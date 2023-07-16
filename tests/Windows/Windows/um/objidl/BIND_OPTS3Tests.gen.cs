// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BIND_OPTS3"/> struct.</summary>
public static unsafe partial class BIND_OPTS3Tests
{
    /// <summary>Validates that the <see cref = "BIND_OPTS3"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BIND_OPTS3>(), Is.EqualTo(sizeof(BIND_OPTS3)));
    }

    /// <summary>Validates that the <see cref = "BIND_OPTS3"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BIND_OPTS3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BIND_OPTS3"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BIND_OPTS3), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(BIND_OPTS3), Is.EqualTo(36));
        }
    }
}