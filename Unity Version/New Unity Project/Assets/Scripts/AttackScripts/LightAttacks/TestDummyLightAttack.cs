using UnityEngine;

namespace AttackScripts.LightAttacks
{
    public class TestDummyLightAttack : IAttackBehaviour
    {
        public void PerformAttack()
        {
            Debug.Log("Light attack performed");
        }
    }
}