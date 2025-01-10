using Configs;
using UnityEngine;

namespace Interfaces
{
    public interface IDamageDealable
    {
        public void DoAttack(WeaponConfig config, Vector2 spawnPosition, float angle);
    }
}
