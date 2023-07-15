// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IViewObjectPresentNotify"/> struct.</summary>
public static unsafe partial class IViewObjectPresentNotifyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IViewObjectPresentNotify"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IViewObjectPresentNotify).GUID, Is.EqualTo(IID_IViewObjectPresentNotify));
    }

    /// <summary>Validates that the <see cref = "IViewObjectPresentNotify"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IViewObjectPresentNotify>(), Is.EqualTo(sizeof(IViewObjectPresentNotify)));
    }

    /// <summary>Validates that the <see cref = "IViewObjectPresentNotify"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IViewObjectPresentNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IViewObjectPresentNotify"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IViewObjectPresentNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IViewObjectPresentNotify), Is.EqualTo(4));
        }
    }
}