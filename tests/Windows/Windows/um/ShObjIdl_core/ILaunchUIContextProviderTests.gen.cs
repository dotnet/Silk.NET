// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ILaunchUIContextProvider"/> struct.</summary>
public static unsafe partial class ILaunchUIContextProviderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ILaunchUIContextProvider"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ILaunchUIContextProvider).GUID, Is.EqualTo(IID_ILaunchUIContextProvider));
    }

    /// <summary>Validates that the <see cref = "ILaunchUIContextProvider"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ILaunchUIContextProvider>(), Is.EqualTo(sizeof(ILaunchUIContextProvider)));
    }

    /// <summary>Validates that the <see cref = "ILaunchUIContextProvider"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ILaunchUIContextProvider).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ILaunchUIContextProvider"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ILaunchUIContextProvider), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ILaunchUIContextProvider), Is.EqualTo(4));
        }
    }
}