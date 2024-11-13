/// <summary>
/// Provides the ability to spawn children surfaces.
/// </summary>
public interface ISurfaceChildren
{
    /// <summary>
    /// Spawns an application to run within a new child surface. This call shall not block.
    /// </summary>
    /// <typeparam name="T">The application to run within the child surface.</typeparam>
    void Spawn<T>()
        where T : ISurfaceApplication;
}
