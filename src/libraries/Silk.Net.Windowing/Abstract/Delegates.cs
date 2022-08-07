using Silk.NET.Maths;
using Silk.NET.Windowing;

public delegate void Vector2DAction(Vector2D<int> newValue);
public delegate void DeltaAction(double deltaTime);
public delegate void WindowStateAction(WindowState newState);
public delegate void FilePathsAction(string[] filePaths);
public delegate void ToggleAction(bool newValue);