// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IProcessInitControl"/> struct.</summary>
public static unsafe partial class IProcessInitControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IProcessInitControl"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IProcessInitControl).GUID, Is.EqualTo(IID_IProcessInitControl));
    }

    /// <summary>Validates that the <see cref = "IProcessInitControl"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IProcessInitControl>(), Is.EqualTo(sizeof(IProcessInitControl)));
    }

    /// <summary>Validates that the <see cref = "IProcessInitControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IProcessInitControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IProcessInitControl"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IProcessInitControl), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IProcessInitControl), Is.EqualTo(4));
        }
    }
}