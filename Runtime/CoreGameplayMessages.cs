using UnityEngine;

namespace Plyground.Gameplay.Runtime
{
    public abstract class CoreGameplayMessage : GameplayMessage
    {
        private readonly string id;
        protected CoreGameplayMessage(string messageId) { id = messageId; }
        public override string Id => id;
    }

    public sealed class EntityDefeatedMessage : CoreGameplayMessage { public EntityDefeatedMessage() : base("core.entity.defeated") { } public GameObject Subject { get; set; } public GameObject Instigator { get; set; } public string Cause { get; set; } }
    public sealed class ItemCollectedMessage : CoreGameplayMessage { public ItemCollectedMessage() : base("core.item.collected") { } public GameObject Item { get; set; } public GameObject Collector { get; set; } }
    public sealed class ItemUsedMessage : CoreGameplayMessage { public ItemUsedMessage() : base("core.item.used") { } public GameObject Item { get; set; } public GameObject User { get; set; } }
    public sealed class InventoryChangedMessage : CoreGameplayMessage { public InventoryChangedMessage() : base("core.inventory.changed") { } public GameObject Owner { get; set; } public GameObject Item { get; set; } public int? Quantity { get; set; } }
    public sealed class DamageAppliedMessage : CoreGameplayMessage { public DamageAppliedMessage() : base("core.damage.applied") { } public GameObject Subject { get; set; } public GameObject Instigator { get; set; } public float Amount { get; set; } }
    public sealed class HealthChangedMessage : CoreGameplayMessage { public HealthChangedMessage() : base("core.health.changed") { } public GameObject Subject { get; set; } public GameObject Instigator { get; set; } public float PreviousHealth { get; set; } public float CurrentHealth { get; set; } }
    public sealed class HealthDepletedMessage : CoreGameplayMessage { public HealthDepletedMessage() : base("core.health.depleted") { } public GameObject Subject { get; set; } public GameObject Instigator { get; set; } }
    public sealed class InteractionPerformedMessage : CoreGameplayMessage { public InteractionPerformedMessage() : base("core.interaction.performed") { } public GameObject Actor { get; set; } public GameObject Target { get; set; } }
    public sealed class DoorOpenedMessage : CoreGameplayMessage { public DoorOpenedMessage() : base("core.door.opened") { } public GameObject Door { get; set; } public GameObject Instigator { get; set; } }
    public sealed class SwitchActivatedMessage : CoreGameplayMessage { public SwitchActivatedMessage() : base("core.switch.activated") { } public GameObject Switch { get; set; } public GameObject Instigator { get; set; } }
    public sealed class EnemyDetectedPlayerMessage : CoreGameplayMessage { public EnemyDetectedPlayerMessage() : base("core.enemy.detected_player") { } public GameObject Enemy { get; set; } public GameObject Player { get; set; } }
    public sealed class EnemyLostPlayerMessage : CoreGameplayMessage { public EnemyLostPlayerMessage() : base("core.enemy.lost_player") { } public GameObject Enemy { get; set; } public GameObject Player { get; set; } }
    public sealed class AlertRaisedMessage : CoreGameplayMessage { public AlertRaisedMessage() : base("core.alert.raised") { } public GameObject Source { get; set; } public int? Level { get; set; } }
    public sealed class SoundHeardMessage : CoreGameplayMessage { public SoundHeardMessage() : base("core.sound.heard") { } public GameObject Listener { get; set; } public GameObject Source { get; set; } public Vector3 Position { get; set; } }
    public sealed class VehicleEnteredMessage : CoreGameplayMessage { public VehicleEnteredMessage() : base("core.vehicle.entered") { } public GameObject Vehicle { get; set; } public GameObject Driver { get; set; } }
    public sealed class DialogueCompletedMessage : CoreGameplayMessage { public DialogueCompletedMessage() : base("core.dialogue.completed") { } public string ConversationId { get; set; } public GameObject Participant { get; set; } }
    public sealed class ZoneEnteredMessage : CoreGameplayMessage { public ZoneEnteredMessage() : base("core.zone.entered") { } public GameObject Subject { get; set; } public GameObject Zone { get; set; } }
    public sealed class ObjectiveCompletedMessage : CoreGameplayMessage { public ObjectiveCompletedMessage() : base("core.objective.completed") { } public GameObject Objective { get; set; } }
    public sealed class TimerElapsedMessage : CoreGameplayMessage { public TimerElapsedMessage() : base("core.timer.elapsed") { } public string TimerId { get; set; } }
    public sealed class ScoreAwardRequestedMessage : CoreGameplayMessage { public ScoreAwardRequestedMessage() : base("core.score.award.requested") { } public int Amount { get; set; } public GameObject Recipient { get; set; } }
    public sealed class DamageRequestedMessage : CoreGameplayMessage { public DamageRequestedMessage() : base("core.damage.requested") { } public GameObject Subject { get; set; } public GameObject Instigator { get; set; } public float Amount { get; set; } }
    public sealed class EntitySpawnRequestedMessage : CoreGameplayMessage { public EntitySpawnRequestedMessage() : base("core.entity.spawn.requested") { } public GameObject SpawnPoint { get; set; } public Vector3? Position { get; set; } }
    public sealed class PlayerRespawnRequestedMessage : CoreGameplayMessage { public PlayerRespawnRequestedMessage() : base("core.player.respawn.requested") { } public GameObject Player { get; set; } public GameObject SpawnPoint { get; set; } }
    public sealed class DoorOpenRequestedMessage : CoreGameplayMessage { public DoorOpenRequestedMessage() : base("core.door.open.requested") { } public GameObject Door { get; set; } public GameObject Instigator { get; set; } }
    public sealed class GameEndRequestedMessage : CoreGameplayMessage { public GameEndRequestedMessage() : base("core.game.end.requested") { } public string Reason { get; set; } }
    public sealed class WaveStartRequestedMessage : CoreGameplayMessage { public WaveStartRequestedMessage() : base("core.wave.start.requested") { } public int WaveIndex { get; set; } }
    public sealed class UiMessageRequestedMessage : CoreGameplayMessage { public UiMessageRequestedMessage() : base("core.ui.message.requested") { } public string Text { get; set; } public GameObject Recipient { get; set; } }
}

