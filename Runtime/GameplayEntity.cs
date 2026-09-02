using UnityEngine;

namespace Plyground.Gameplay.Runtime
{
    [DisallowMultipleComponent]
    public sealed class GameplayEntity : MonoBehaviour
    {
        [SerializeField] private string entityId;
        [SerializeField] private GameplayRole roles;

        public string EntityId => entityId;
        public GameplayRole Roles => roles;

        public bool HasRole(GameplayRole role)
        {
            return role != GameplayRole.None && (roles & role) == role;
        }

        public void SetIdentity(string id, GameplayRole entityRoles)
        {
            entityId = id;
            roles = entityRoles;
        }
    }
}
