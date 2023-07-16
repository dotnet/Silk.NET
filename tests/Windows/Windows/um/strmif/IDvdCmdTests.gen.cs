// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDvdCmd"/> struct.</summary>
public static unsafe partial class IDvdCmdTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDvdCmd"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDvdCmd).GUID, Is.EqualTo(IID_IDvdCmd));
    }

    /// <summary>Validates that the <see cref = "IDvdCmd"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDvdCmd>(), Is.EqualTo(sizeof(IDvdCmd)));
    }

    /// <summary>Validates that the <see cref = "IDvdCmd"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDvdCmd).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDvdCmd"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDvdCmd), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDvdCmd), Is.EqualTo(4));
        }
    }
}