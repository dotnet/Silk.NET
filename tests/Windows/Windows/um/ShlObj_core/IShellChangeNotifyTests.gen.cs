// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IShellChangeNotify"/> struct.</summary>
public static unsafe partial class IShellChangeNotifyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellChangeNotify"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellChangeNotify).GUID, Is.EqualTo(IID_IShellChangeNotify));
    }

    /// <summary>Validates that the <see cref = "IShellChangeNotify"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellChangeNotify>(), Is.EqualTo(sizeof(IShellChangeNotify)));
    }

    /// <summary>Validates that the <see cref = "IShellChangeNotify"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellChangeNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellChangeNotify"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellChangeNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellChangeNotify), Is.EqualTo(4));
        }
    }
}