using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server._Adventure.Posters.Components

/// <summary>
///     Component which spawns entities after interaction. Essentially a copy of <see cref="SpawnAfterInteractComponent"/> but without IsTileClear check.
/// </summary>
{
    [RegisterComponent]
    public sealed partial class PosterComponent : Component
    {
        [DataField("prototype", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
        public string? Prototype { get; private set; }

        [DataField("ignoreDistance")]
        public bool IgnoreDistance { get; private set; }

        [DataField("doAfter")]
        public float DoAfterTime = 0;

        [DataField("removeOnInteract")]
        public bool RemoveOnInteract = false;
    }
}
