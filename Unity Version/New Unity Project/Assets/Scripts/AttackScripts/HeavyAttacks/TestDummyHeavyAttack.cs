using UnityEngine;

namespace AttackScripts.HeavyAttacks
{
    public class TestDummyHeavyAttack : IAttackBehaviour
    {
        public void PerformAttack()
        {
            Debug.Log("Heavy attack performed");
        }
    }
}