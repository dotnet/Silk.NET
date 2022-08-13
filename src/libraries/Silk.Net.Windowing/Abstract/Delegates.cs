// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using Silk.NET.Maths;
using Silk.NET.Windowing;

//TODO: Copy proposal explanation as to why we are doing this, also other than Vector2DAction these names are HIGHLY specialized for no apparently good reason, I am not a fan.
/// <summary>
/// An action that takes a <see cref="Vector2D{T}"/>
/// </summary>
public delegate void Vector2DAction(Vector2D<int> newValue);

/// <summary>
/// An action that takes a double as a parameter
/// </summary>
public delegate void DeltaAction(double deltaTime);
/// <summary>
///  An action that takes a <see cref="WindowState"/>
/// </summary>
public delegate void WindowStateAction(WindowState newState);
/// <summary>
/// An action that takes a list of strings as a parameter, intended for file path callbacks
/// </summary>
public delegate void FilePathsAction(string[] filePaths);
/// <summary>
/// An action that takes a bool as a parameter, intended for a callback when things are toggled.
/// </summary>
public delegate void ToggleAction(bool newValue);
